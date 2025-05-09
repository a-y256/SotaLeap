
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{
    // C++: class Xfeatures2d


    public partial class Xfeatures2d
    {

        //
        // C++:  void cv::xfeatures2d::matchGMS(Size size1, Size size2, vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_DMatch matches1to2, vector_DMatch& matchesGMS, bool withRotation = false, bool withScale = false, double thresholdFactor = 6.0)
        //

        /// <summary>
        ///  GMS (Grid-based Motion Statistics) feature matching strategy described in @cite Bian2017gms .
        /// </summary>
        /// <param name="size1">
        /// Input size of image1.
        /// </param>
        /// <param name="size2">
        /// Input size of image2.
        /// </param>
        /// <param name="keypoints1">
        /// Input keypoints of image1.
        /// </param>
        /// <param name="keypoints2">
        /// Input keypoints of image2.
        /// </param>
        /// <param name="matches1to2">
        /// Input 1-nearest neighbor matches.
        /// </param>
        /// <param name="matchesGMS">
        /// Matches returned by the GMS matching strategy.
        /// </param>
        /// <param name="withRotation">
        /// Take rotation transformation into account.
        /// </param>
        /// <param name="withScale">
        /// Take scale transformation into account.
        /// </param>
        /// <param name="thresholdFactor">
        /// The higher, the less matches.
        ///      @note
        ///          Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
        ///          If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
        ///          If your images have big rotation and scale changes, please set withRotation or withScale to true.
        /// </param>
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation, bool withScale, double thresholdFactor)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
            Mat keypoints1_mat = keypoints1;
            Mat keypoints2_mat = keypoints2;
            Mat matches1to2_mat = matches1to2;
            Mat matchesGMS_mat = matchesGMS;
            xfeatures2d_Xfeatures2d_matchGMS_10(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj, withRotation, withScale, thresholdFactor);


        }

        /// <summary>
        ///  GMS (Grid-based Motion Statistics) feature matching strategy described in @cite Bian2017gms .
        /// </summary>
        /// <param name="size1">
        /// Input size of image1.
        /// </param>
        /// <param name="size2">
        /// Input size of image2.
        /// </param>
        /// <param name="keypoints1">
        /// Input keypoints of image1.
        /// </param>
        /// <param name="keypoints2">
        /// Input keypoints of image2.
        /// </param>
        /// <param name="matches1to2">
        /// Input 1-nearest neighbor matches.
        /// </param>
        /// <param name="matchesGMS">
        /// Matches returned by the GMS matching strategy.
        /// </param>
        /// <param name="withRotation">
        /// Take rotation transformation into account.
        /// </param>
        /// <param name="withScale">
        /// Take scale transformation into account.
        /// </param>
        /// <param name="thresholdFactor">
        /// The higher, the less matches.
        ///      @note
        ///          Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
        ///          If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
        ///          If your images have big rotation and scale changes, please set withRotation or withScale to true.
        /// </param>
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation, bool withScale)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
            Mat keypoints1_mat = keypoints1;
            Mat keypoints2_mat = keypoints2;
            Mat matches1to2_mat = matches1to2;
            Mat matchesGMS_mat = matchesGMS;
            xfeatures2d_Xfeatures2d_matchGMS_11(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj, withRotation, withScale);


        }

        /// <summary>
        ///  GMS (Grid-based Motion Statistics) feature matching strategy described in @cite Bian2017gms .
        /// </summary>
        /// <param name="size1">
        /// Input size of image1.
        /// </param>
        /// <param name="size2">
        /// Input size of image2.
        /// </param>
        /// <param name="keypoints1">
        /// Input keypoints of image1.
        /// </param>
        /// <param name="keypoints2">
        /// Input keypoints of image2.
        /// </param>
        /// <param name="matches1to2">
        /// Input 1-nearest neighbor matches.
        /// </param>
        /// <param name="matchesGMS">
        /// Matches returned by the GMS matching strategy.
        /// </param>
        /// <param name="withRotation">
        /// Take rotation transformation into account.
        /// </param>
        /// <param name="withScale">
        /// Take scale transformation into account.
        /// </param>
        /// <param name="thresholdFactor">
        /// The higher, the less matches.
        ///      @note
        ///          Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
        ///          If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
        ///          If your images have big rotation and scale changes, please set withRotation or withScale to true.
        /// </param>
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS, bool withRotation)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
            Mat keypoints1_mat = keypoints1;
            Mat keypoints2_mat = keypoints2;
            Mat matches1to2_mat = matches1to2;
            Mat matchesGMS_mat = matchesGMS;
            xfeatures2d_Xfeatures2d_matchGMS_12(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj, withRotation);


        }

        /// <summary>
        ///  GMS (Grid-based Motion Statistics) feature matching strategy described in @cite Bian2017gms .
        /// </summary>
        /// <param name="size1">
        /// Input size of image1.
        /// </param>
        /// <param name="size2">
        /// Input size of image2.
        /// </param>
        /// <param name="keypoints1">
        /// Input keypoints of image1.
        /// </param>
        /// <param name="keypoints2">
        /// Input keypoints of image2.
        /// </param>
        /// <param name="matches1to2">
        /// Input 1-nearest neighbor matches.
        /// </param>
        /// <param name="matchesGMS">
        /// Matches returned by the GMS matching strategy.
        /// </param>
        /// <param name="withRotation">
        /// Take rotation transformation into account.
        /// </param>
        /// <param name="withScale">
        /// Take scale transformation into account.
        /// </param>
        /// <param name="thresholdFactor">
        /// The higher, the less matches.
        ///      @note
        ///          Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
        ///          If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
        ///          If your images have big rotation and scale changes, please set withRotation or withScale to true.
        /// </param>
        public static void matchGMS(Size size1, Size size2, MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfDMatch matches1to2, MatOfDMatch matchesGMS)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            if (matchesGMS != null) matchesGMS.ThrowIfDisposed();
            Mat keypoints1_mat = keypoints1;
            Mat keypoints2_mat = keypoints2;
            Mat matches1to2_mat = matches1to2;
            Mat matchesGMS_mat = matchesGMS;
            xfeatures2d_Xfeatures2d_matchGMS_13(size1.width, size1.height, size2.width, size2.height, keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, matches1to2_mat.nativeObj, matchesGMS_mat.nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::matchLOGOS(vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_int nn1, vector_int nn2, vector_DMatch& matches1to2)
        //

        /// <summary>
        ///  LOGOS (Local geometric support for high-outlier spatial verification) feature matching strategy described in @cite Lowry2018LOGOSLG .
        /// </summary>
        /// <param name="keypoints1">
        /// Input keypoints of image1.
        /// </param>
        /// <param name="keypoints2">
        /// Input keypoints of image2.
        /// </param>
        /// <param name="nn1">
        /// Index to the closest BoW centroid for each descriptors of image1.
        /// </param>
        /// <param name="nn2">
        /// Index to the closest BoW centroid for each descriptors of image2.
        /// </param>
        /// <param name="matches1to2">
        /// Matches returned by the LOGOS matching strategy.
        ///      @note
        ///          This matching strategy is suitable for features matching against large scale database.
        ///          First step consists in constructing the bag-of-words (BoW) from a representative image database.
        ///          Image descriptors are then represented by their closest codevector (nearest BoW centroid).
        /// </param>
        public static void matchLOGOS(MatOfKeyPoint keypoints1, MatOfKeyPoint keypoints2, MatOfInt nn1, MatOfInt nn2, MatOfDMatch matches1to2)
        {
            if (keypoints1 != null) keypoints1.ThrowIfDisposed();
            if (keypoints2 != null) keypoints2.ThrowIfDisposed();
            if (nn1 != null) nn1.ThrowIfDisposed();
            if (nn2 != null) nn2.ThrowIfDisposed();
            if (matches1to2 != null) matches1to2.ThrowIfDisposed();
            Mat keypoints1_mat = keypoints1;
            Mat keypoints2_mat = keypoints2;
            Mat nn1_mat = nn1;
            Mat nn2_mat = nn2;
            Mat matches1to2_mat = matches1to2;
            xfeatures2d_Xfeatures2d_matchLOGOS_10(keypoints1_mat.nativeObj, keypoints2_mat.nativeObj, nn1_mat.nativeObj, nn2_mat.nativeObj, matches1to2_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::xfeatures2d::matchGMS(Size size1, Size size2, vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_DMatch matches1to2, vector_DMatch& matchesGMS, bool withRotation = false, bool withScale = false, double thresholdFactor = 6.0)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_10(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool withRotation, [MarshalAs(UnmanagedType.U1)] bool withScale, double thresholdFactor);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_11(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool withRotation, [MarshalAs(UnmanagedType.U1)] bool withScale);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_12(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool withRotation);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchGMS_13(double size1_width, double size1_height, double size2_width, double size2_height, IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj, IntPtr matchesGMS_mat_nativeObj);

        // C++:  void cv::xfeatures2d::matchLOGOS(vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_int nn1, vector_int nn2, vector_DMatch& matches1to2)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_Xfeatures2d_matchLOGOS_10(IntPtr keypoints1_mat_nativeObj, IntPtr keypoints2_mat_nativeObj, IntPtr nn1_mat_nativeObj, IntPtr nn2_mat_nativeObj, IntPtr matches1to2_mat_nativeObj);

    }
}
