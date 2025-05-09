using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UnityUtils.Helper;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace OpenCVForUnityExample
{
    /// <summary>
    /// Document Scanner Example
    /// An example of document scanning (like receipts, business cards etc) using the Imgproc class.
    /// </summary>
    [RequireComponent(typeof(MultiSource2MatHelper))]
    public class DocumentScannerExample : MonoBehaviour
    {
        [Header("Output")]
        /// <summary>
        /// The RawImage for previewing the result.
        /// </summary>
        public RawImage resultPreview;

        [Space(10)]

        /// <summary>
        /// Determines if debug mode.
        /// </summary>
        public bool isDebugMode = false;

        /// <summary>
        /// The debug mode toggle.
        /// </summary>
        public Toggle isDebugModeToggle;

        Mat yuvMat;
        Mat yMat;

        Mat displayMat;
        Mat inputDisplayAreaMat;
        Mat outputDisplayAreaMat;

        Scalar CONTOUR_COLOR;
        Scalar DEBUG_CONTOUR_COLOR;
        Scalar DEBUG_CORNER_NUMBER_COLOR;

        /// <summary>
        /// The texture.
        /// </summary>
        Texture2D texture;

        /// <summary>
        /// The multi source to mat helper.
        /// </summary>
        MultiSource2MatHelper multiSource2MatHelper;

        /// <summary>
        /// The FPS monitor.
        /// </summary>
        FpsMonitor fpsMonitor;

        // Use this for initialization
        void Start()
        {
            fpsMonitor = GetComponent<FpsMonitor>();

            multiSource2MatHelper = gameObject.GetComponent<MultiSource2MatHelper>();
            multiSource2MatHelper.outputColorFormat = Source2MatHelperColorFormat.RGBA;
            multiSource2MatHelper.Initialize();

            isDebugModeToggle.isOn = isDebugMode;
        }

        /// <summary>
        /// Raises the source to mat helper initialized event.
        /// </summary>
        public void OnSourceToMatHelperInitialized()
        {
            Debug.Log("OnSourceToMatHelperInitialized");

            Mat rgbaMat = multiSource2MatHelper.GetMat();

            if (rgbaMat.width() < rgbaMat.height())
            {
                displayMat = new Mat(rgbaMat.rows(), rgbaMat.cols() * 2, rgbaMat.type(), new Scalar(0, 0, 0, 255));
                inputDisplayAreaMat = new Mat(displayMat, new OpenCVForUnity.CoreModule.Rect(0, 0, rgbaMat.width(), rgbaMat.height()));
                outputDisplayAreaMat = new Mat(displayMat, new OpenCVForUnity.CoreModule.Rect(rgbaMat.width(), 0, rgbaMat.width(), rgbaMat.height()));
            }
            else
            {
                displayMat = new Mat(rgbaMat.rows() * 2, rgbaMat.cols(), rgbaMat.type(), new Scalar(0, 0, 0, 255));
                inputDisplayAreaMat = new Mat(displayMat, new OpenCVForUnity.CoreModule.Rect(0, 0, rgbaMat.width(), rgbaMat.height()));
                outputDisplayAreaMat = new Mat(displayMat, new OpenCVForUnity.CoreModule.Rect(0, rgbaMat.height(), rgbaMat.width(), rgbaMat.height()));
            }

            texture = new Texture2D(displayMat.cols(), displayMat.rows(), TextureFormat.RGBA32, false);

            resultPreview.texture = texture;
            resultPreview.GetComponent<AspectRatioFitter>().aspectRatio = (float)texture.width / texture.height;


            if (fpsMonitor != null)
            {
                fpsMonitor.Add("width", displayMat.width().ToString());
                fpsMonitor.Add("height", displayMat.height().ToString());
                fpsMonitor.Add("orientation", Screen.orientation.ToString());
                fpsMonitor.consoleText = "Please place a document paper (receipt or business card) on a plain background.";
            }

            yuvMat = new Mat();
            yMat = new Mat();
            CONTOUR_COLOR = new Scalar(255, 0, 0, 255);
            DEBUG_CONTOUR_COLOR = new Scalar(255, 255, 0, 255);
            DEBUG_CORNER_NUMBER_COLOR = new Scalar(255, 255, 255, 255);

#if !OPENCV_DONT_USE_WEBCAMTEXTURE_API
            // If the WebCam is front facing, flip the Mat horizontally. Required for successful detection.
            if (multiSource2MatHelper.source2MatHelper is WebCamTexture2MatHelper webCamHelper)
                webCamHelper.flipHorizontal = webCamHelper.IsFrontFacing();
#endif
        }

        /// <summary>
        /// Raises the source to mat helper disposed event.
        /// </summary>
        public void OnSourceToMatHelperDisposed()
        {
            Debug.Log("OnSourceToMatHelperDisposed");

            if (texture != null)
            {
                Texture2D.Destroy(texture);
                texture = null;
            }

            if (yuvMat != null)
                yuvMat.Dispose();

            if (yMat != null)
                yMat.Dispose();

            if (displayMat != null)
                displayMat.Dispose();
        }

        /// <summary>
        /// Raises the source to mat helper error occurred event.
        /// </summary>
        /// <param name="errorCode">Error code.</param>
        /// <param name="message">Message.</param>
        public void OnSourceToMatHelperErrorOccurred(Source2MatHelperErrorCode errorCode, string message)
        {
            Debug.Log("OnSourceToMatHelperErrorOccurred " + errorCode + ":" + message);

            if (fpsMonitor != null)
            {
                fpsMonitor.consoleText = "ErrorCode: " + errorCode + ":" + message;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (multiSource2MatHelper.IsPlaying() && multiSource2MatHelper.DidUpdateThisFrame())
            {
                Mat rgbaMat = multiSource2MatHelper.GetMat();

                // change the color space to YUV.
                Imgproc.cvtColor(rgbaMat, yuvMat, Imgproc.COLOR_RGBA2RGB);
                Imgproc.cvtColor(yuvMat, yuvMat, Imgproc.COLOR_RGB2YUV);
                // grap only the Y component.
                Core.extractChannel(yuvMat, yMat, 0);

                // blur the image to reduce high frequency noises.
                Imgproc.GaussianBlur(yMat, yMat, new Size(3, 3), 0);
                // find edges in the image.
                Imgproc.Canny(yMat, yMat, 50, 200, 3);

                // find contours.
                List<MatOfPoint> contours = new List<MatOfPoint>();
                Find4PointContours(yMat, contours);

                // pick the contour of the largest area and rearrange the points in a consistent order.
                MatOfPoint maxAreaContour = GetMaxAreaContour(contours);
                maxAreaContour = OrderCornerPoints(maxAreaContour);

                bool found = (maxAreaContour.size().area() > 0);
                if (found)
                {
                    // trasform the prospective of original image.
                    using (Mat transformedMat = PerspectiveTransform(rgbaMat, maxAreaContour))
                    {
                        outputDisplayAreaMat.setTo(new Scalar(0, 0, 0, 255));

                        if (transformedMat.width() <= outputDisplayAreaMat.width() && transformedMat.height() <= outputDisplayAreaMat.height()
                            && transformedMat.total() >= outputDisplayAreaMat.total() / 16)
                        {
                            int x = outputDisplayAreaMat.width() / 2 - transformedMat.width() / 2;
                            int y = outputDisplayAreaMat.height() / 2 - transformedMat.height() / 2;
                            using (Mat dstAreaMat = new Mat(outputDisplayAreaMat, new OpenCVForUnity.CoreModule.Rect(x, y, transformedMat.width(), transformedMat.height())))
                            {
                                transformedMat.copyTo(dstAreaMat);
                            }
                        }
                    }
                }

                if (isDebugMode)
                {
                    // draw edge image.
                    Imgproc.cvtColor(yMat, rgbaMat, Imgproc.COLOR_GRAY2RGBA);

                    // draw all found conours.
                    Imgproc.drawContours(rgbaMat, contours, -1, DEBUG_CONTOUR_COLOR, 1);
                }

                if (found)
                {
                    // draw max area contour.
                    Imgproc.drawContours(rgbaMat, new List<MatOfPoint> { maxAreaContour }, -1, CONTOUR_COLOR, 2);

                    if (isDebugMode)
                    {
                        // draw corner numbers.
                        for (int i = 0; i < maxAreaContour.toArray().Length; i++)
                        {
                            var pt = maxAreaContour.get(i, 0);
                            Imgproc.putText(rgbaMat, i.ToString(), new Point(pt[0], pt[1]), Imgproc.FONT_HERSHEY_SIMPLEX, 0.5, DEBUG_CORNER_NUMBER_COLOR, 1, Imgproc.LINE_AA, false);
                        }
                    }
                }

                rgbaMat.copyTo(inputDisplayAreaMat);

                Utils.matToTexture2D(displayMat, texture);
            }
        }

        private void Find4PointContours(Mat image, List<MatOfPoint> contours)
        {
            contours.Clear();
            List<MatOfPoint> tmp_contours = new List<MatOfPoint>();
            Mat hierarchy = new Mat();
            Imgproc.findContours(image, tmp_contours, hierarchy, Imgproc.RETR_EXTERNAL, Imgproc.CHAIN_APPROX_SIMPLE);

            foreach (var cnt in tmp_contours)
            {
                MatOfInt hull = new MatOfInt();
                Imgproc.convexHull(cnt, hull, false);

                Point[] cnt_arr = cnt.toArray();
                int[] hull_arr = hull.toArray();
                Point[] pts = new Point[hull_arr.Length];
                for (int i = 0; i < hull_arr.Length; i++)
                {
                    pts[i] = cnt_arr[hull_arr[i]];
                }

                MatOfPoint2f ptsFC2 = new MatOfPoint2f(pts);
                MatOfPoint2f approxFC2 = new MatOfPoint2f();
                MatOfPoint approxSC2 = new MatOfPoint();

                double arclen = Imgproc.arcLength(ptsFC2, true);
                Imgproc.approxPolyDP(ptsFC2, approxFC2, 0.01 * arclen, true);
                approxFC2.convertTo(approxSC2, CvType.CV_32S);

                if (approxSC2.size().area() != 4)
                    continue;

                contours.Add(approxSC2);
            }
        }

        private MatOfPoint GetMaxAreaContour(List<MatOfPoint> contours)
        {
            if (contours.Count == 0)
                return new MatOfPoint();

            int index = -1;
            double area = 0;
            for (int i = 0; i < contours.Count; i++)
            {
                double tmp = Imgproc.contourArea(contours[i]);
                if (area < tmp)
                {
                    area = tmp;
                    index = i;
                }
            }
            return contours[index];
        }

        private MatOfPoint OrderCornerPoints(MatOfPoint corners)
        {
            if (corners.size().area() <= 0 || corners.rows() < 4)
                return corners;

            // rearrange the points in the order of upper left, upper right, lower right, lower left.
            using (Mat x = new Mat(corners.size(), CvType.CV_32SC1))
            using (Mat y = new Mat(corners.size(), CvType.CV_32SC1))
            using (Mat d = new Mat(corners.size(), CvType.CV_32SC1))
            using (Mat dst = new Mat(corners.size(), CvType.CV_32SC2))
            {
                Core.extractChannel(corners, x, 0);
                Core.extractChannel(corners, y, 1);

                // the sum of the upper left points is the smallest and the sum of the lower right points is the largest.
                Core.add(x, y, d);
                Core.MinMaxLocResult result = Core.minMaxLoc(d);
                dst.put(0, 0, corners.get((int)result.minLoc.y, 0));
                dst.put(2, 0, corners.get((int)result.maxLoc.y, 0));

                // the difference in the upper right point is the smallest, and the difference in the lower left is the largest.
                Core.subtract(y, x, d);
                result = Core.minMaxLoc(d);
                dst.put(1, 0, corners.get((int)result.minLoc.y, 0));
                dst.put(3, 0, corners.get((int)result.maxLoc.y, 0));

                dst.copyTo(corners);
            }
            return corners;
        }

        private Mat PerspectiveTransform(Mat image, MatOfPoint corners)
        {
            if (corners.size().area() <= 0 || corners.rows() < 4)
                return image;

            Point[] pts = corners.toArray();
            Point tl = pts[0];
            Point tr = pts[1];
            Point br = pts[2];
            Point bl = pts[3];

            double widthA = Math.Sqrt((br.x - bl.x) * (br.x - bl.x) + (br.y - bl.y) * (br.y - bl.y));
            double widthB = Math.Sqrt((tr.x - tl.x) * (tr.x - tl.x) + (tr.y - tl.y) * (tr.y - tl.y));
            int maxWidth = Math.Max((int)widthA, (int)widthB);

            double heightA = Math.Sqrt((tr.x - br.x) * (tr.x - br.x) + (tr.y - br.y) * (tr.y - br.y));
            double heightB = Math.Sqrt((tl.x - bl.x) * (tl.x - bl.x) + (tl.y - bl.y) * (tl.y - bl.y));
            int maxHeight = Math.Max((int)heightA, (int)heightB);

            maxWidth = (maxWidth < 1) ? 1 : maxWidth;
            maxHeight = (maxHeight < 1) ? 1 : maxHeight;

            Mat src = new Mat();
            corners.convertTo(src, CvType.CV_32FC2);
            Mat dst = new Mat(4, 1, CvType.CV_32FC2);
            dst.put(0, 0, 0, 0, maxWidth - 1, 0, maxWidth - 1, maxHeight - 1, 0, maxHeight - 1);

            // compute and apply the perspective transformation matrix.
            Mat outputMat = new Mat(maxHeight, maxWidth, image.type(), new Scalar(0, 0, 0, 255));
            Mat perspectiveTransform = Imgproc.getPerspectiveTransform(src, dst);
            Imgproc.warpPerspective(image, outputMat, perspectiveTransform, new Size(outputMat.cols(), outputMat.rows()));

            // return the transformed image.
            return outputMat;
        }

        /// <summary>
        /// Raises the destroy event.
        /// </summary>
        void OnDestroy()
        {
            multiSource2MatHelper.Dispose();
        }

        /// <summary>
        /// Raises the back button click event.
        /// </summary>
        public void OnBackButtonClick()
        {
            SceneManager.LoadScene("OpenCVForUnityExample");
        }

        /// <summary>
        /// Raises the play button click event.
        /// </summary>
        public void OnPlayButtonClick()
        {
            multiSource2MatHelper.Play();
        }

        /// <summary>
        /// Raises the pause button click event.
        /// </summary>
        public void OnPauseButtonClick()
        {
            multiSource2MatHelper.Pause();
        }

        /// <summary>
        /// Raises the stop button click event.
        /// </summary>
        public void OnStopButtonClick()
        {
            multiSource2MatHelper.Stop();
        }

        /// <summary>
        /// Raises the change camera button click event.
        /// </summary>
        public void OnChangeCameraButtonClick()
        {
            multiSource2MatHelper.requestedIsFrontFacing = !multiSource2MatHelper.requestedIsFrontFacing;
        }

        /// <summary>
        /// Raises the is debug mode toggle value changed event.
        /// </summary>
        public void OnIsDebugModeToggleValueChanged()
        {
            if (isDebugMode != isDebugModeToggle.isOn)
            {
                isDebugMode = isDebugModeToggle.isOn;
            }
        }
    }
}