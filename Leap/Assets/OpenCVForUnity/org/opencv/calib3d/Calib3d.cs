
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{
    // C++: class Calib3d


    public partial class Calib3d
    {

        // C++: enum <unnamed>
        public const int CV_ITERATIVE = 0;
        public const int CV_EPNP = 1;
        public const int CV_P3P = 2;
        public const int CV_DLS = 3;
        public const int CvLevMarq_DONE = 0;
        public const int CvLevMarq_STARTED = 1;
        public const int CvLevMarq_CALC_J = 2;
        public const int CvLevMarq_CHECK_ERR = 3;
        public const int LMEDS = 4;
        public const int RANSAC = 8;
        public const int RHO = 16;
        public const int USAC_DEFAULT = 32;
        public const int USAC_PARALLEL = 33;
        public const int USAC_FM_8PTS = 34;
        public const int USAC_FAST = 35;
        public const int USAC_ACCURATE = 36;
        public const int USAC_PROSAC = 37;
        public const int USAC_MAGSAC = 38;
        public const int CALIB_CB_ADAPTIVE_THRESH = 1;
        public const int CALIB_CB_NORMALIZE_IMAGE = 2;
        public const int CALIB_CB_FILTER_QUADS = 4;
        public const int CALIB_CB_FAST_CHECK = 8;
        public const int CALIB_CB_EXHAUSTIVE = 16;
        public const int CALIB_CB_ACCURACY = 32;
        public const int CALIB_CB_LARGER = 64;
        public const int CALIB_CB_MARKER = 128;
        public const int CALIB_CB_PLAIN = 256;
        public const int CALIB_CB_SYMMETRIC_GRID = 1;
        public const int CALIB_CB_ASYMMETRIC_GRID = 2;
        public const int CALIB_CB_CLUSTERING = 4;
        public const int CALIB_NINTRINSIC = 18;
        public const int CALIB_USE_INTRINSIC_GUESS = 0x00001;
        public const int CALIB_FIX_ASPECT_RATIO = 0x00002;
        public const int CALIB_FIX_PRINCIPAL_POINT = 0x00004;
        public const int CALIB_ZERO_TANGENT_DIST = 0x00008;
        public const int CALIB_FIX_FOCAL_LENGTH = 0x00010;
        public const int CALIB_FIX_K1 = 0x00020;
        public const int CALIB_FIX_K2 = 0x00040;
        public const int CALIB_FIX_K3 = 0x00080;
        public const int CALIB_FIX_K4 = 0x00800;
        public const int CALIB_FIX_K5 = 0x01000;
        public const int CALIB_FIX_K6 = 0x02000;
        public const int CALIB_RATIONAL_MODEL = 0x04000;
        public const int CALIB_THIN_PRISM_MODEL = 0x08000;
        public const int CALIB_FIX_S1_S2_S3_S4 = 0x10000;
        public const int CALIB_TILTED_MODEL = 0x40000;
        public const int CALIB_FIX_TAUX_TAUY = 0x80000;
        public const int CALIB_USE_QR = 0x100000;
        public const int CALIB_FIX_TANGENT_DIST = 0x200000;
        public const int CALIB_FIX_INTRINSIC = 0x00100;
        public const int CALIB_SAME_FOCAL_LENGTH = 0x00200;
        public const int CALIB_ZERO_DISPARITY = 0x00400;
        public const int CALIB_USE_LU = (1 << 17);
        public const int CALIB_USE_EXTRINSIC_GUESS = (1 << 22);
        public const int FM_7POINT = 1;
        public const int FM_8POINT = 2;
        public const int FM_LMEDS = 4;
        public const int FM_RANSAC = 8;
        public const int fisheye_CALIB_USE_INTRINSIC_GUESS = 1 << 0;
        public const int fisheye_CALIB_RECOMPUTE_EXTRINSIC = 1 << 1;
        public const int fisheye_CALIB_CHECK_COND = 1 << 2;
        public const int fisheye_CALIB_FIX_SKEW = 1 << 3;
        public const int fisheye_CALIB_FIX_K1 = 1 << 4;
        public const int fisheye_CALIB_FIX_K2 = 1 << 5;
        public const int fisheye_CALIB_FIX_K3 = 1 << 6;
        public const int fisheye_CALIB_FIX_K4 = 1 << 7;
        public const int fisheye_CALIB_FIX_INTRINSIC = 1 << 8;
        public const int fisheye_CALIB_FIX_PRINCIPAL_POINT = 1 << 9;
        public const int fisheye_CALIB_ZERO_DISPARITY = 1 << 10;
        public const int fisheye_CALIB_FIX_FOCAL_LENGTH = 1 << 11;
        // C++: enum cv.CirclesGridFinderParameters.GridType
        public const int CirclesGridFinderParameters_SYMMETRIC_GRID = 0;
        public const int CirclesGridFinderParameters_ASYMMETRIC_GRID = 1;
        // C++: enum cv.HandEyeCalibrationMethod
        public const int CALIB_HAND_EYE_TSAI = 0;
        public const int CALIB_HAND_EYE_PARK = 1;
        public const int CALIB_HAND_EYE_HORAUD = 2;
        public const int CALIB_HAND_EYE_ANDREFF = 3;
        public const int CALIB_HAND_EYE_DANIILIDIS = 4;
        // C++: enum cv.LocalOptimMethod
        public const int LOCAL_OPTIM_NULL = 0;
        public const int LOCAL_OPTIM_INNER_LO = 1;
        public const int LOCAL_OPTIM_INNER_AND_ITER_LO = 2;
        public const int LOCAL_OPTIM_GC = 3;
        public const int LOCAL_OPTIM_SIGMA = 4;
        // C++: enum cv.NeighborSearchMethod
        public const int NEIGH_FLANN_KNN = 0;
        public const int NEIGH_GRID = 1;
        public const int NEIGH_FLANN_RADIUS = 2;
        // C++: enum cv.PolishingMethod
        public const int NONE_POLISHER = 0;
        public const int LSQ_POLISHER = 1;
        public const int MAGSAC = 2;
        public const int COV_POLISHER = 3;
        // C++: enum cv.RobotWorldHandEyeCalibrationMethod
        public const int CALIB_ROBOT_WORLD_HAND_EYE_SHAH = 0;
        public const int CALIB_ROBOT_WORLD_HAND_EYE_LI = 1;
        // C++: enum cv.SamplingMethod
        public const int SAMPLING_UNIFORM = 0;
        public const int SAMPLING_PROGRESSIVE_NAPSAC = 1;
        public const int SAMPLING_NAPSAC = 2;
        public const int SAMPLING_PROSAC = 3;
        // C++: enum cv.ScoreMethod
        public const int SCORE_METHOD_RANSAC = 0;
        public const int SCORE_METHOD_MSAC = 1;
        public const int SCORE_METHOD_MAGSAC = 2;
        public const int SCORE_METHOD_LMEDS = 3;
        // C++: enum cv.SolvePnPMethod
        public const int SOLVEPNP_ITERATIVE = 0;
        public const int SOLVEPNP_EPNP = 1;
        public const int SOLVEPNP_P3P = 2;
        public const int SOLVEPNP_DLS = 3;
        public const int SOLVEPNP_UPNP = 4;
        public const int SOLVEPNP_AP3P = 5;
        public const int SOLVEPNP_IPPE = 6;
        public const int SOLVEPNP_IPPE_SQUARE = 7;
        public const int SOLVEPNP_SQPNP = 8;
        public const int SOLVEPNP_MAX_COUNT = 8 + 1;
        // C++: enum cv.UndistortTypes
        public const int PROJ_SPHERICAL_ORTHO = 0;
        public const int PROJ_SPHERICAL_EQRECT = 1;
        //
        // C++:  void cv::Rodrigues(Mat src, Mat& dst, Mat& jacobian = Mat())
        //

        /// <summary>
        ///  Converts a rotation matrix to a rotation vector or vice versa.
        /// </summary>
        /// <param name="src">
        /// Input rotation vector (3x1 or 1x3) or rotation matrix (3x3).
        /// </param>
        /// <param name="dst">
        /// Output rotation matrix (3x3) or rotation vector (3x1 or 1x3), respectively.
        /// </param>
        /// <param name="jacobian">
        /// Optional output Jacobian matrix, 3x9 or 9x3, which is a matrix of partial
        ///  derivatives of the output array components with respect to the input array components.
        /// </param>
        /// <remarks>
        ///  \f[\begin{array}{l} \theta \leftarrow norm(r) \\ r  \leftarrow r/ \theta \\ R =  \cos(\theta) I + (1- \cos{\theta} ) r r^T +  \sin(\theta) \vecthreethree{0}{-r_z}{r_y}{r_z}{0}{-r_x}{-r_y}{r_x}{0} \end{array}\f]
        ///  
        ///  Inverse transformation can be also done easily, since
        ///  
        ///  \f[\sin ( \theta ) \vecthreethree{0}{-r_z}{r_y}{r_z}{0}{-r_x}{-r_y}{r_x}{0} = \frac{R - R^T}{2}\f]
        ///  
        ///  A rotation vector is a convenient and most compact representation of a rotation matrix (since any
        ///  rotation matrix has just 3 degrees of freedom). The representation is used in the global 3D geometry
        ///  optimization procedures like @ref calibrateCamera, @ref stereoCalibrate, or @ref solvePnP .
        ///  
        ///  @note More information about the computation of the derivative of a 3D rotation matrix with respect to its exponential coordinate
        ///  can be found in:
        ///      - A Compact Formula for the Derivative of a 3-D Rotation in Exponential Coordinates, Guillermo Gallego, Anthony J. Yezzi @cite Gallego2014ACF
        ///  
        ///  @note Useful information on SE(3) and Lie Groups can be found in:
        ///      - A tutorial on SE(3) transformation parameterizations and on-manifold optimization, Jose-Luis Blanco @cite blanco2010tutorial
        ///      - Lie Groups for 2D and 3D Transformation, Ethan Eade @cite Eade17
        ///      - A micro Lie theory for state estimation in robotics, Joan Solà, Jérémie Deray, Dinesh Atchuthan @cite Sol2018AML
        /// </remarks>
        public static void Rodrigues(Mat src, Mat dst, Mat jacobian)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();

            calib3d_Calib3d_Rodrigues_10(src.nativeObj, dst.nativeObj, jacobian.nativeObj);


        }

        /// <summary>
        ///  Converts a rotation matrix to a rotation vector or vice versa.
        /// </summary>
        /// <param name="src">
        /// Input rotation vector (3x1 or 1x3) or rotation matrix (3x3).
        /// </param>
        /// <param name="dst">
        /// Output rotation matrix (3x3) or rotation vector (3x1 or 1x3), respectively.
        /// </param>
        /// <param name="jacobian">
        /// Optional output Jacobian matrix, 3x9 or 9x3, which is a matrix of partial
        ///  derivatives of the output array components with respect to the input array components.
        /// </param>
        /// <remarks>
        ///  \f[\begin{array}{l} \theta \leftarrow norm(r) \\ r  \leftarrow r/ \theta \\ R =  \cos(\theta) I + (1- \cos{\theta} ) r r^T +  \sin(\theta) \vecthreethree{0}{-r_z}{r_y}{r_z}{0}{-r_x}{-r_y}{r_x}{0} \end{array}\f]
        ///  
        ///  Inverse transformation can be also done easily, since
        ///  
        ///  \f[\sin ( \theta ) \vecthreethree{0}{-r_z}{r_y}{r_z}{0}{-r_x}{-r_y}{r_x}{0} = \frac{R - R^T}{2}\f]
        ///  
        ///  A rotation vector is a convenient and most compact representation of a rotation matrix (since any
        ///  rotation matrix has just 3 degrees of freedom). The representation is used in the global 3D geometry
        ///  optimization procedures like @ref calibrateCamera, @ref stereoCalibrate, or @ref solvePnP .
        ///  
        ///  @note More information about the computation of the derivative of a 3D rotation matrix with respect to its exponential coordinate
        ///  can be found in:
        ///      - A Compact Formula for the Derivative of a 3-D Rotation in Exponential Coordinates, Guillermo Gallego, Anthony J. Yezzi @cite Gallego2014ACF
        ///  
        ///  @note Useful information on SE(3) and Lie Groups can be found in:
        ///      - A tutorial on SE(3) transformation parameterizations and on-manifold optimization, Jose-Luis Blanco @cite blanco2010tutorial
        ///      - Lie Groups for 2D and 3D Transformation, Ethan Eade @cite Eade17
        ///      - A micro Lie theory for state estimation in robotics, Joan Solà, Jérémie Deray, Dinesh Atchuthan @cite Sol2018AML
        /// </remarks>
        public static void Rodrigues(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            calib3d_Calib3d_Rodrigues_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Mat cv::findHomography(vector_Point2f srcPoints, vector_Point2f dstPoints, int method = 0, double ransacReprojThreshold = 3, Mat& mask = Mat(), int maxIters = 2000, double confidence = 0.995)
        //

        /// <summary>
        ///  Finds a perspective transformation between two planes.
        /// </summary>
        /// <param name="srcPoints">
        /// Coordinates of the points in the original plane, a matrix of the type CV_32FC2
        ///  or vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="dstPoints">
        /// Coordinates of the points in the target plane, a matrix of the type CV_32FC2 or
        ///  a vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="method">
        /// Method used to compute a homography matrix. The following methods are possible:
        ///  -   **0** - a regular method using all the points, i.e., the least squares method
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  -   @ref RHO - PROSAC-based robust method
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum allowed reprojection error to treat a point pair as an inlier
        ///  (used in the RANSAC and RHO methods only). That is, if
        ///  \f[\| \texttt{dstPoints} _i -  \texttt{convertPointsHomogeneous} ( \texttt{H} \cdot \texttt{srcPoints} _i) \|_2  &gt;  \texttt{ransacReprojThreshold}\f]
        ///  then the point \f$i\f$ is considered as an outlier. If srcPoints and dstPoints are measured in pixels,
        ///  it usually makes sense to set this parameter somewhere in the range of 1 to 10.
        /// </param>
        /// <param name="mask">
        /// Optional output mask set by a robust method ( RANSAC or LMeDS ). Note that the input
        ///  mask values are ignored.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of RANSAC iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1.
        /// </param>
        /// <remarks>
        ///  The function finds and returns the perspective transformation \f$H\f$ between the source and the
        ///  destination planes:
        ///  
        ///  \f[s_i  \vecthree{x'_i}{y'_i}{1} \sim H  \vecthree{x_i}{y_i}{1}\f]
        ///  
        ///  so that the back-projection error
        ///  
        ///  \f[\sum _i \left ( x'_i- \frac{h_{11} x_i + h_{12} y_i + h_{13}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2+ \left ( y'_i- \frac{h_{21} x_i + h_{22} y_i + h_{23}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2\f]
        ///  
        ///  is minimized. If the parameter method is set to the default value 0, the function uses all the point
        ///  pairs to compute an initial homography estimate with a simple least-squares scheme.
        ///  
        ///  However, if not all of the point pairs ( \f$srcPoints_i\f$, \f$dstPoints_i\f$ ) fit the rigid perspective
        ///  transformation (that is, there are some outliers), this initial estimate will be poor. In this case,
        ///  you can use one of the three robust methods. The methods RANSAC, LMeDS and RHO try many different
        ///  random subsets of the corresponding point pairs (of four pairs each, collinear pairs are discarded), estimate the homography matrix
        ///  using this subset and a simple least-squares algorithm, and then compute the quality/goodness of the
        ///  computed homography (which is the number of inliers for RANSAC or the least median re-projection error for
        ///  LMeDS). The best subset is then used to produce the initial estimate of the homography matrix and
        ///  the mask of inliers/outliers.
        ///  
        ///  Regardless of the method, robust or not, the computed homography matrix is refined further (using
        ///  inliers only in case of a robust method) with the Levenberg-Marquardt method to reduce the
        ///  re-projection error even more.
        ///  
        ///  The methods RANSAC and RHO can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers. Finally, if there are no outliers and the
        ///  noise is rather small, use the default method (method=0).
        ///  
        ///  The function is used to find initial intrinsic and extrinsic matrices. Homography matrix is
        ///  determined up to a scale. If \f$h_{33}\f$ is non-zero, the matrix is normalized so that \f$h_{33}=1\f$.
        ///  @note Whenever an \f$H\f$ matrix cannot be estimated, an empty one will be returned.
        ///  
        ///  @sa
        ///  getAffineTransform, estimateAffine2D, estimateAffinePartial2D, getPerspectiveTransform, warpPerspective,
        ///  perspectiveTransform
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold, Mat mask, int maxIters, double confidence)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_10(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold, mask.nativeObj, maxIters, confidence)));


        }

        /// <summary>
        ///  Finds a perspective transformation between two planes.
        /// </summary>
        /// <param name="srcPoints">
        /// Coordinates of the points in the original plane, a matrix of the type CV_32FC2
        ///  or vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="dstPoints">
        /// Coordinates of the points in the target plane, a matrix of the type CV_32FC2 or
        ///  a vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="method">
        /// Method used to compute a homography matrix. The following methods are possible:
        ///  -   **0** - a regular method using all the points, i.e., the least squares method
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  -   @ref RHO - PROSAC-based robust method
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum allowed reprojection error to treat a point pair as an inlier
        ///  (used in the RANSAC and RHO methods only). That is, if
        ///  \f[\| \texttt{dstPoints} _i -  \texttt{convertPointsHomogeneous} ( \texttt{H} \cdot \texttt{srcPoints} _i) \|_2  &gt;  \texttt{ransacReprojThreshold}\f]
        ///  then the point \f$i\f$ is considered as an outlier. If srcPoints and dstPoints are measured in pixels,
        ///  it usually makes sense to set this parameter somewhere in the range of 1 to 10.
        /// </param>
        /// <param name="mask">
        /// Optional output mask set by a robust method ( RANSAC or LMeDS ). Note that the input
        ///  mask values are ignored.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of RANSAC iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1.
        /// </param>
        /// <remarks>
        ///  The function finds and returns the perspective transformation \f$H\f$ between the source and the
        ///  destination planes:
        ///  
        ///  \f[s_i  \vecthree{x'_i}{y'_i}{1} \sim H  \vecthree{x_i}{y_i}{1}\f]
        ///  
        ///  so that the back-projection error
        ///  
        ///  \f[\sum _i \left ( x'_i- \frac{h_{11} x_i + h_{12} y_i + h_{13}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2+ \left ( y'_i- \frac{h_{21} x_i + h_{22} y_i + h_{23}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2\f]
        ///  
        ///  is minimized. If the parameter method is set to the default value 0, the function uses all the point
        ///  pairs to compute an initial homography estimate with a simple least-squares scheme.
        ///  
        ///  However, if not all of the point pairs ( \f$srcPoints_i\f$, \f$dstPoints_i\f$ ) fit the rigid perspective
        ///  transformation (that is, there are some outliers), this initial estimate will be poor. In this case,
        ///  you can use one of the three robust methods. The methods RANSAC, LMeDS and RHO try many different
        ///  random subsets of the corresponding point pairs (of four pairs each, collinear pairs are discarded), estimate the homography matrix
        ///  using this subset and a simple least-squares algorithm, and then compute the quality/goodness of the
        ///  computed homography (which is the number of inliers for RANSAC or the least median re-projection error for
        ///  LMeDS). The best subset is then used to produce the initial estimate of the homography matrix and
        ///  the mask of inliers/outliers.
        ///  
        ///  Regardless of the method, robust or not, the computed homography matrix is refined further (using
        ///  inliers only in case of a robust method) with the Levenberg-Marquardt method to reduce the
        ///  re-projection error even more.
        ///  
        ///  The methods RANSAC and RHO can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers. Finally, if there are no outliers and the
        ///  noise is rather small, use the default method (method=0).
        ///  
        ///  The function is used to find initial intrinsic and extrinsic matrices. Homography matrix is
        ///  determined up to a scale. If \f$h_{33}\f$ is non-zero, the matrix is normalized so that \f$h_{33}=1\f$.
        ///  @note Whenever an \f$H\f$ matrix cannot be estimated, an empty one will be returned.
        ///  
        ///  @sa
        ///  getAffineTransform, estimateAffine2D, estimateAffinePartial2D, getPerspectiveTransform, warpPerspective,
        ///  perspectiveTransform
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold, Mat mask, int maxIters)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_11(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold, mask.nativeObj, maxIters)));


        }

        /// <summary>
        ///  Finds a perspective transformation between two planes.
        /// </summary>
        /// <param name="srcPoints">
        /// Coordinates of the points in the original plane, a matrix of the type CV_32FC2
        ///  or vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="dstPoints">
        /// Coordinates of the points in the target plane, a matrix of the type CV_32FC2 or
        ///  a vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="method">
        /// Method used to compute a homography matrix. The following methods are possible:
        ///  -   **0** - a regular method using all the points, i.e., the least squares method
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  -   @ref RHO - PROSAC-based robust method
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum allowed reprojection error to treat a point pair as an inlier
        ///  (used in the RANSAC and RHO methods only). That is, if
        ///  \f[\| \texttt{dstPoints} _i -  \texttt{convertPointsHomogeneous} ( \texttt{H} \cdot \texttt{srcPoints} _i) \|_2  &gt;  \texttt{ransacReprojThreshold}\f]
        ///  then the point \f$i\f$ is considered as an outlier. If srcPoints and dstPoints are measured in pixels,
        ///  it usually makes sense to set this parameter somewhere in the range of 1 to 10.
        /// </param>
        /// <param name="mask">
        /// Optional output mask set by a robust method ( RANSAC or LMeDS ). Note that the input
        ///  mask values are ignored.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of RANSAC iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1.
        /// </param>
        /// <remarks>
        ///  The function finds and returns the perspective transformation \f$H\f$ between the source and the
        ///  destination planes:
        ///  
        ///  \f[s_i  \vecthree{x'_i}{y'_i}{1} \sim H  \vecthree{x_i}{y_i}{1}\f]
        ///  
        ///  so that the back-projection error
        ///  
        ///  \f[\sum _i \left ( x'_i- \frac{h_{11} x_i + h_{12} y_i + h_{13}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2+ \left ( y'_i- \frac{h_{21} x_i + h_{22} y_i + h_{23}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2\f]
        ///  
        ///  is minimized. If the parameter method is set to the default value 0, the function uses all the point
        ///  pairs to compute an initial homography estimate with a simple least-squares scheme.
        ///  
        ///  However, if not all of the point pairs ( \f$srcPoints_i\f$, \f$dstPoints_i\f$ ) fit the rigid perspective
        ///  transformation (that is, there are some outliers), this initial estimate will be poor. In this case,
        ///  you can use one of the three robust methods. The methods RANSAC, LMeDS and RHO try many different
        ///  random subsets of the corresponding point pairs (of four pairs each, collinear pairs are discarded), estimate the homography matrix
        ///  using this subset and a simple least-squares algorithm, and then compute the quality/goodness of the
        ///  computed homography (which is the number of inliers for RANSAC or the least median re-projection error for
        ///  LMeDS). The best subset is then used to produce the initial estimate of the homography matrix and
        ///  the mask of inliers/outliers.
        ///  
        ///  Regardless of the method, robust or not, the computed homography matrix is refined further (using
        ///  inliers only in case of a robust method) with the Levenberg-Marquardt method to reduce the
        ///  re-projection error even more.
        ///  
        ///  The methods RANSAC and RHO can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers. Finally, if there are no outliers and the
        ///  noise is rather small, use the default method (method=0).
        ///  
        ///  The function is used to find initial intrinsic and extrinsic matrices. Homography matrix is
        ///  determined up to a scale. If \f$h_{33}\f$ is non-zero, the matrix is normalized so that \f$h_{33}=1\f$.
        ///  @note Whenever an \f$H\f$ matrix cannot be estimated, an empty one will be returned.
        ///  
        ///  @sa
        ///  getAffineTransform, estimateAffine2D, estimateAffinePartial2D, getPerspectiveTransform, warpPerspective,
        ///  perspectiveTransform
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold, Mat mask)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_12(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold, mask.nativeObj)));


        }

        /// <summary>
        ///  Finds a perspective transformation between two planes.
        /// </summary>
        /// <param name="srcPoints">
        /// Coordinates of the points in the original plane, a matrix of the type CV_32FC2
        ///  or vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="dstPoints">
        /// Coordinates of the points in the target plane, a matrix of the type CV_32FC2 or
        ///  a vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="method">
        /// Method used to compute a homography matrix. The following methods are possible:
        ///  -   **0** - a regular method using all the points, i.e., the least squares method
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  -   @ref RHO - PROSAC-based robust method
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum allowed reprojection error to treat a point pair as an inlier
        ///  (used in the RANSAC and RHO methods only). That is, if
        ///  \f[\| \texttt{dstPoints} _i -  \texttt{convertPointsHomogeneous} ( \texttt{H} \cdot \texttt{srcPoints} _i) \|_2  &gt;  \texttt{ransacReprojThreshold}\f]
        ///  then the point \f$i\f$ is considered as an outlier. If srcPoints and dstPoints are measured in pixels,
        ///  it usually makes sense to set this parameter somewhere in the range of 1 to 10.
        /// </param>
        /// <param name="mask">
        /// Optional output mask set by a robust method ( RANSAC or LMeDS ). Note that the input
        ///  mask values are ignored.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of RANSAC iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1.
        /// </param>
        /// <remarks>
        ///  The function finds and returns the perspective transformation \f$H\f$ between the source and the
        ///  destination planes:
        ///  
        ///  \f[s_i  \vecthree{x'_i}{y'_i}{1} \sim H  \vecthree{x_i}{y_i}{1}\f]
        ///  
        ///  so that the back-projection error
        ///  
        ///  \f[\sum _i \left ( x'_i- \frac{h_{11} x_i + h_{12} y_i + h_{13}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2+ \left ( y'_i- \frac{h_{21} x_i + h_{22} y_i + h_{23}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2\f]
        ///  
        ///  is minimized. If the parameter method is set to the default value 0, the function uses all the point
        ///  pairs to compute an initial homography estimate with a simple least-squares scheme.
        ///  
        ///  However, if not all of the point pairs ( \f$srcPoints_i\f$, \f$dstPoints_i\f$ ) fit the rigid perspective
        ///  transformation (that is, there are some outliers), this initial estimate will be poor. In this case,
        ///  you can use one of the three robust methods. The methods RANSAC, LMeDS and RHO try many different
        ///  random subsets of the corresponding point pairs (of four pairs each, collinear pairs are discarded), estimate the homography matrix
        ///  using this subset and a simple least-squares algorithm, and then compute the quality/goodness of the
        ///  computed homography (which is the number of inliers for RANSAC or the least median re-projection error for
        ///  LMeDS). The best subset is then used to produce the initial estimate of the homography matrix and
        ///  the mask of inliers/outliers.
        ///  
        ///  Regardless of the method, robust or not, the computed homography matrix is refined further (using
        ///  inliers only in case of a robust method) with the Levenberg-Marquardt method to reduce the
        ///  re-projection error even more.
        ///  
        ///  The methods RANSAC and RHO can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers. Finally, if there are no outliers and the
        ///  noise is rather small, use the default method (method=0).
        ///  
        ///  The function is used to find initial intrinsic and extrinsic matrices. Homography matrix is
        ///  determined up to a scale. If \f$h_{33}\f$ is non-zero, the matrix is normalized so that \f$h_{33}=1\f$.
        ///  @note Whenever an \f$H\f$ matrix cannot be estimated, an empty one will be returned.
        ///  
        ///  @sa
        ///  getAffineTransform, estimateAffine2D, estimateAffinePartial2D, getPerspectiveTransform, warpPerspective,
        ///  perspectiveTransform
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method, double ransacReprojThreshold)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_13(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method, ransacReprojThreshold)));


        }

        /// <summary>
        ///  Finds a perspective transformation between two planes.
        /// </summary>
        /// <param name="srcPoints">
        /// Coordinates of the points in the original plane, a matrix of the type CV_32FC2
        ///  or vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="dstPoints">
        /// Coordinates of the points in the target plane, a matrix of the type CV_32FC2 or
        ///  a vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="method">
        /// Method used to compute a homography matrix. The following methods are possible:
        ///  -   **0** - a regular method using all the points, i.e., the least squares method
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  -   @ref RHO - PROSAC-based robust method
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum allowed reprojection error to treat a point pair as an inlier
        ///  (used in the RANSAC and RHO methods only). That is, if
        ///  \f[\| \texttt{dstPoints} _i -  \texttt{convertPointsHomogeneous} ( \texttt{H} \cdot \texttt{srcPoints} _i) \|_2  &gt;  \texttt{ransacReprojThreshold}\f]
        ///  then the point \f$i\f$ is considered as an outlier. If srcPoints and dstPoints are measured in pixels,
        ///  it usually makes sense to set this parameter somewhere in the range of 1 to 10.
        /// </param>
        /// <param name="mask">
        /// Optional output mask set by a robust method ( RANSAC or LMeDS ). Note that the input
        ///  mask values are ignored.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of RANSAC iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1.
        /// </param>
        /// <remarks>
        ///  The function finds and returns the perspective transformation \f$H\f$ between the source and the
        ///  destination planes:
        ///  
        ///  \f[s_i  \vecthree{x'_i}{y'_i}{1} \sim H  \vecthree{x_i}{y_i}{1}\f]
        ///  
        ///  so that the back-projection error
        ///  
        ///  \f[\sum _i \left ( x'_i- \frac{h_{11} x_i + h_{12} y_i + h_{13}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2+ \left ( y'_i- \frac{h_{21} x_i + h_{22} y_i + h_{23}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2\f]
        ///  
        ///  is minimized. If the parameter method is set to the default value 0, the function uses all the point
        ///  pairs to compute an initial homography estimate with a simple least-squares scheme.
        ///  
        ///  However, if not all of the point pairs ( \f$srcPoints_i\f$, \f$dstPoints_i\f$ ) fit the rigid perspective
        ///  transformation (that is, there are some outliers), this initial estimate will be poor. In this case,
        ///  you can use one of the three robust methods. The methods RANSAC, LMeDS and RHO try many different
        ///  random subsets of the corresponding point pairs (of four pairs each, collinear pairs are discarded), estimate the homography matrix
        ///  using this subset and a simple least-squares algorithm, and then compute the quality/goodness of the
        ///  computed homography (which is the number of inliers for RANSAC or the least median re-projection error for
        ///  LMeDS). The best subset is then used to produce the initial estimate of the homography matrix and
        ///  the mask of inliers/outliers.
        ///  
        ///  Regardless of the method, robust or not, the computed homography matrix is refined further (using
        ///  inliers only in case of a robust method) with the Levenberg-Marquardt method to reduce the
        ///  re-projection error even more.
        ///  
        ///  The methods RANSAC and RHO can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers. Finally, if there are no outliers and the
        ///  noise is rather small, use the default method (method=0).
        ///  
        ///  The function is used to find initial intrinsic and extrinsic matrices. Homography matrix is
        ///  determined up to a scale. If \f$h_{33}\f$ is non-zero, the matrix is normalized so that \f$h_{33}=1\f$.
        ///  @note Whenever an \f$H\f$ matrix cannot be estimated, an empty one will be returned.
        ///  
        ///  @sa
        ///  getAffineTransform, estimateAffine2D, estimateAffinePartial2D, getPerspectiveTransform, warpPerspective,
        ///  perspectiveTransform
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, int method)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_14(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, method)));


        }

        /// <summary>
        ///  Finds a perspective transformation between two planes.
        /// </summary>
        /// <param name="srcPoints">
        /// Coordinates of the points in the original plane, a matrix of the type CV_32FC2
        ///  or vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="dstPoints">
        /// Coordinates of the points in the target plane, a matrix of the type CV_32FC2 or
        ///  a vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="method">
        /// Method used to compute a homography matrix. The following methods are possible:
        ///  -   **0** - a regular method using all the points, i.e., the least squares method
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  -   @ref RHO - PROSAC-based robust method
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum allowed reprojection error to treat a point pair as an inlier
        ///  (used in the RANSAC and RHO methods only). That is, if
        ///  \f[\| \texttt{dstPoints} _i -  \texttt{convertPointsHomogeneous} ( \texttt{H} \cdot \texttt{srcPoints} _i) \|_2  &gt;  \texttt{ransacReprojThreshold}\f]
        ///  then the point \f$i\f$ is considered as an outlier. If srcPoints and dstPoints are measured in pixels,
        ///  it usually makes sense to set this parameter somewhere in the range of 1 to 10.
        /// </param>
        /// <param name="mask">
        /// Optional output mask set by a robust method ( RANSAC or LMeDS ). Note that the input
        ///  mask values are ignored.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of RANSAC iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1.
        /// </param>
        /// <remarks>
        ///  The function finds and returns the perspective transformation \f$H\f$ between the source and the
        ///  destination planes:
        ///  
        ///  \f[s_i  \vecthree{x'_i}{y'_i}{1} \sim H  \vecthree{x_i}{y_i}{1}\f]
        ///  
        ///  so that the back-projection error
        ///  
        ///  \f[\sum _i \left ( x'_i- \frac{h_{11} x_i + h_{12} y_i + h_{13}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2+ \left ( y'_i- \frac{h_{21} x_i + h_{22} y_i + h_{23}}{h_{31} x_i + h_{32} y_i + h_{33}} \right )^2\f]
        ///  
        ///  is minimized. If the parameter method is set to the default value 0, the function uses all the point
        ///  pairs to compute an initial homography estimate with a simple least-squares scheme.
        ///  
        ///  However, if not all of the point pairs ( \f$srcPoints_i\f$, \f$dstPoints_i\f$ ) fit the rigid perspective
        ///  transformation (that is, there are some outliers), this initial estimate will be poor. In this case,
        ///  you can use one of the three robust methods. The methods RANSAC, LMeDS and RHO try many different
        ///  random subsets of the corresponding point pairs (of four pairs each, collinear pairs are discarded), estimate the homography matrix
        ///  using this subset and a simple least-squares algorithm, and then compute the quality/goodness of the
        ///  computed homography (which is the number of inliers for RANSAC or the least median re-projection error for
        ///  LMeDS). The best subset is then used to produce the initial estimate of the homography matrix and
        ///  the mask of inliers/outliers.
        ///  
        ///  Regardless of the method, robust or not, the computed homography matrix is refined further (using
        ///  inliers only in case of a robust method) with the Levenberg-Marquardt method to reduce the
        ///  re-projection error even more.
        ///  
        ///  The methods RANSAC and RHO can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers. Finally, if there are no outliers and the
        ///  noise is rather small, use the default method (method=0).
        ///  
        ///  The function is used to find initial intrinsic and extrinsic matrices. Homography matrix is
        ///  determined up to a scale. If \f$h_{33}\f$ is non-zero, the matrix is normalized so that \f$h_{33}=1\f$.
        ///  @note Whenever an \f$H\f$ matrix cannot be estimated, an empty one will be returned.
        ///  
        ///  @sa
        ///  getAffineTransform, estimateAffine2D, estimateAffinePartial2D, getPerspectiveTransform, warpPerspective,
        ///  perspectiveTransform
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_15(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj)));


        }


        //
        // C++:  Mat cv::findHomography(vector_Point2f srcPoints, vector_Point2f dstPoints, Mat& mask, UsacParams _params)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findHomography(MatOfPoint2f srcPoints, MatOfPoint2f dstPoints, Mat mask, UsacParams _params)
        {
            if (srcPoints != null) srcPoints.ThrowIfDisposed();
            if (dstPoints != null) dstPoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat srcPoints_mat = srcPoints;
            Mat dstPoints_mat = dstPoints;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findHomography_16(srcPoints_mat.nativeObj, dstPoints_mat.nativeObj, mask.nativeObj, _params.nativeObj)));


        }


        //
        // C++:  Vec3d cv::RQDecomp3x3(Mat src, Mat& mtxR, Mat& mtxQ, Mat& Qx = Mat(), Mat& Qy = Mat(), Mat& Qz = Mat())
        //

        /// <summary>
        ///  Computes an RQ decomposition of 3x3 matrices.
        /// </summary>
        /// <param name="src">
        /// 3x3 input matrix.
        /// </param>
        /// <param name="mtxR">
        /// Output 3x3 upper-triangular matrix.
        /// </param>
        /// <param name="mtxQ">
        /// Output 3x3 orthogonal matrix.
        /// </param>
        /// <param name="Qx">
        /// Optional output 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="Qy">
        /// Optional output 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="Qz">
        /// Optional output 3x3 rotation matrix around z-axis.
        /// </param>
        /// <remarks>
        ///  The function computes a RQ decomposition using the given rotations. This function is used in
        ///  #decomposeProjectionMatrix to decompose the left 3x3 submatrix of a projection matrix into a camera
        ///  and a rotation matrix.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and the three Euler angles in
        ///  degrees (as the return value) that could be used in OpenGL. Note, there is always more than one
        ///  sequence of rotations about the three principal axes that results in the same orientation of an
        ///  object, e.g. see @cite Slabaugh . Returned three rotation matrices and corresponding three Euler angles
        ///  are only one of the possible solutions.
        /// </remarks>
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ, Mat Qx, Mat Qy, Mat Qz)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
            if (Qx != null) Qx.ThrowIfDisposed();
            if (Qy != null) Qy.ThrowIfDisposed();
            if (Qz != null) Qz.ThrowIfDisposed();

            double[] retVal = new double[3];
            calib3d_Calib3d_RQDecomp3x3_10(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, Qx.nativeObj, Qy.nativeObj, Qz.nativeObj, retVal);

            return retVal;
        }

        /// <summary>
        ///  Computes an RQ decomposition of 3x3 matrices.
        /// </summary>
        /// <param name="src">
        /// 3x3 input matrix.
        /// </param>
        /// <param name="mtxR">
        /// Output 3x3 upper-triangular matrix.
        /// </param>
        /// <param name="mtxQ">
        /// Output 3x3 orthogonal matrix.
        /// </param>
        /// <param name="Qx">
        /// Optional output 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="Qy">
        /// Optional output 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="Qz">
        /// Optional output 3x3 rotation matrix around z-axis.
        /// </param>
        /// <remarks>
        ///  The function computes a RQ decomposition using the given rotations. This function is used in
        ///  #decomposeProjectionMatrix to decompose the left 3x3 submatrix of a projection matrix into a camera
        ///  and a rotation matrix.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and the three Euler angles in
        ///  degrees (as the return value) that could be used in OpenGL. Note, there is always more than one
        ///  sequence of rotations about the three principal axes that results in the same orientation of an
        ///  object, e.g. see @cite Slabaugh . Returned three rotation matrices and corresponding three Euler angles
        ///  are only one of the possible solutions.
        /// </remarks>
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ, Mat Qx, Mat Qy)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
            if (Qx != null) Qx.ThrowIfDisposed();
            if (Qy != null) Qy.ThrowIfDisposed();

            double[] retVal = new double[3];
            calib3d_Calib3d_RQDecomp3x3_11(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, Qx.nativeObj, Qy.nativeObj, retVal);

            return retVal;
        }

        /// <summary>
        ///  Computes an RQ decomposition of 3x3 matrices.
        /// </summary>
        /// <param name="src">
        /// 3x3 input matrix.
        /// </param>
        /// <param name="mtxR">
        /// Output 3x3 upper-triangular matrix.
        /// </param>
        /// <param name="mtxQ">
        /// Output 3x3 orthogonal matrix.
        /// </param>
        /// <param name="Qx">
        /// Optional output 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="Qy">
        /// Optional output 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="Qz">
        /// Optional output 3x3 rotation matrix around z-axis.
        /// </param>
        /// <remarks>
        ///  The function computes a RQ decomposition using the given rotations. This function is used in
        ///  #decomposeProjectionMatrix to decompose the left 3x3 submatrix of a projection matrix into a camera
        ///  and a rotation matrix.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and the three Euler angles in
        ///  degrees (as the return value) that could be used in OpenGL. Note, there is always more than one
        ///  sequence of rotations about the three principal axes that results in the same orientation of an
        ///  object, e.g. see @cite Slabaugh . Returned three rotation matrices and corresponding three Euler angles
        ///  are only one of the possible solutions.
        /// </remarks>
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ, Mat Qx)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();
            if (Qx != null) Qx.ThrowIfDisposed();

            double[] retVal = new double[3];
            calib3d_Calib3d_RQDecomp3x3_12(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, Qx.nativeObj, retVal);

            return retVal;
        }

        /// <summary>
        ///  Computes an RQ decomposition of 3x3 matrices.
        /// </summary>
        /// <param name="src">
        /// 3x3 input matrix.
        /// </param>
        /// <param name="mtxR">
        /// Output 3x3 upper-triangular matrix.
        /// </param>
        /// <param name="mtxQ">
        /// Output 3x3 orthogonal matrix.
        /// </param>
        /// <param name="Qx">
        /// Optional output 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="Qy">
        /// Optional output 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="Qz">
        /// Optional output 3x3 rotation matrix around z-axis.
        /// </param>
        /// <remarks>
        ///  The function computes a RQ decomposition using the given rotations. This function is used in
        ///  #decomposeProjectionMatrix to decompose the left 3x3 submatrix of a projection matrix into a camera
        ///  and a rotation matrix.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and the three Euler angles in
        ///  degrees (as the return value) that could be used in OpenGL. Note, there is always more than one
        ///  sequence of rotations about the three principal axes that results in the same orientation of an
        ///  object, e.g. see @cite Slabaugh . Returned three rotation matrices and corresponding three Euler angles
        ///  are only one of the possible solutions.
        /// </remarks>
        public static double[] RQDecomp3x3(Mat src, Mat mtxR, Mat mtxQ)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mtxR != null) mtxR.ThrowIfDisposed();
            if (mtxQ != null) mtxQ.ThrowIfDisposed();

            double[] retVal = new double[3];
            calib3d_Calib3d_RQDecomp3x3_13(src.nativeObj, mtxR.nativeObj, mtxQ.nativeObj, retVal);

            return retVal;
        }


        //
        // C++:  void cv::decomposeProjectionMatrix(Mat projMatrix, Mat& cameraMatrix, Mat& rotMatrix, Mat& transVect, Mat& rotMatrixX = Mat(), Mat& rotMatrixY = Mat(), Mat& rotMatrixZ = Mat(), Mat& eulerAngles = Mat())
        //

        /// <summary>
        ///  Decomposes a projection matrix into a rotation matrix and a camera intrinsic matrix.
        /// </summary>
        /// <param name="projMatrix">
        /// 3x4 input projection matrix P.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 camera intrinsic matrix \f$\cameramatrix{A}\f$.
        /// </param>
        /// <param name="rotMatrix">
        /// Output 3x3 external rotation matrix R.
        /// </param>
        /// <param name="transVect">
        /// Output 4x1 translation vector T.
        /// </param>
        /// <param name="rotMatrixX">
        /// Optional 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="rotMatrixY">
        /// Optional 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="rotMatrixZ">
        /// Optional 3x3 rotation matrix around z-axis.
        /// </param>
        /// <param name="eulerAngles">
        /// Optional three-element vector containing three Euler angles of rotation in
        ///  degrees.
        /// </param>
        /// <remarks>
        ///  The function computes a decomposition of a projection matrix into a calibration and a rotation
        ///  matrix and the position of a camera.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and three Euler angles that could
        ///  be used in OpenGL. Note, there is always more than one sequence of rotations about the three
        ///  principal axes that results in the same orientation of an object, e.g. see @cite Slabaugh . Returned
        ///  three rotation matrices and corresponding three Euler angles are only one of the possible solutions.
        ///  
        ///  The function is based on #RQDecomp3x3 .
        /// </remarks>
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY, Mat rotMatrixZ, Mat eulerAngles)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
            if (rotMatrixY != null) rotMatrixY.ThrowIfDisposed();
            if (rotMatrixZ != null) rotMatrixZ.ThrowIfDisposed();
            if (eulerAngles != null) eulerAngles.ThrowIfDisposed();

            calib3d_Calib3d_decomposeProjectionMatrix_10(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj, rotMatrixY.nativeObj, rotMatrixZ.nativeObj, eulerAngles.nativeObj);


        }

        /// <summary>
        ///  Decomposes a projection matrix into a rotation matrix and a camera intrinsic matrix.
        /// </summary>
        /// <param name="projMatrix">
        /// 3x4 input projection matrix P.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 camera intrinsic matrix \f$\cameramatrix{A}\f$.
        /// </param>
        /// <param name="rotMatrix">
        /// Output 3x3 external rotation matrix R.
        /// </param>
        /// <param name="transVect">
        /// Output 4x1 translation vector T.
        /// </param>
        /// <param name="rotMatrixX">
        /// Optional 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="rotMatrixY">
        /// Optional 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="rotMatrixZ">
        /// Optional 3x3 rotation matrix around z-axis.
        /// </param>
        /// <param name="eulerAngles">
        /// Optional three-element vector containing three Euler angles of rotation in
        ///  degrees.
        /// </param>
        /// <remarks>
        ///  The function computes a decomposition of a projection matrix into a calibration and a rotation
        ///  matrix and the position of a camera.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and three Euler angles that could
        ///  be used in OpenGL. Note, there is always more than one sequence of rotations about the three
        ///  principal axes that results in the same orientation of an object, e.g. see @cite Slabaugh . Returned
        ///  three rotation matrices and corresponding three Euler angles are only one of the possible solutions.
        ///  
        ///  The function is based on #RQDecomp3x3 .
        /// </remarks>
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY, Mat rotMatrixZ)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
            if (rotMatrixY != null) rotMatrixY.ThrowIfDisposed();
            if (rotMatrixZ != null) rotMatrixZ.ThrowIfDisposed();

            calib3d_Calib3d_decomposeProjectionMatrix_11(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj, rotMatrixY.nativeObj, rotMatrixZ.nativeObj);


        }

        /// <summary>
        ///  Decomposes a projection matrix into a rotation matrix and a camera intrinsic matrix.
        /// </summary>
        /// <param name="projMatrix">
        /// 3x4 input projection matrix P.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 camera intrinsic matrix \f$\cameramatrix{A}\f$.
        /// </param>
        /// <param name="rotMatrix">
        /// Output 3x3 external rotation matrix R.
        /// </param>
        /// <param name="transVect">
        /// Output 4x1 translation vector T.
        /// </param>
        /// <param name="rotMatrixX">
        /// Optional 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="rotMatrixY">
        /// Optional 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="rotMatrixZ">
        /// Optional 3x3 rotation matrix around z-axis.
        /// </param>
        /// <param name="eulerAngles">
        /// Optional three-element vector containing three Euler angles of rotation in
        ///  degrees.
        /// </param>
        /// <remarks>
        ///  The function computes a decomposition of a projection matrix into a calibration and a rotation
        ///  matrix and the position of a camera.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and three Euler angles that could
        ///  be used in OpenGL. Note, there is always more than one sequence of rotations about the three
        ///  principal axes that results in the same orientation of an object, e.g. see @cite Slabaugh . Returned
        ///  three rotation matrices and corresponding three Euler angles are only one of the possible solutions.
        ///  
        ///  The function is based on #RQDecomp3x3 .
        /// </remarks>
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX, Mat rotMatrixY)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();
            if (rotMatrixY != null) rotMatrixY.ThrowIfDisposed();

            calib3d_Calib3d_decomposeProjectionMatrix_12(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj, rotMatrixY.nativeObj);


        }

        /// <summary>
        ///  Decomposes a projection matrix into a rotation matrix and a camera intrinsic matrix.
        /// </summary>
        /// <param name="projMatrix">
        /// 3x4 input projection matrix P.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 camera intrinsic matrix \f$\cameramatrix{A}\f$.
        /// </param>
        /// <param name="rotMatrix">
        /// Output 3x3 external rotation matrix R.
        /// </param>
        /// <param name="transVect">
        /// Output 4x1 translation vector T.
        /// </param>
        /// <param name="rotMatrixX">
        /// Optional 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="rotMatrixY">
        /// Optional 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="rotMatrixZ">
        /// Optional 3x3 rotation matrix around z-axis.
        /// </param>
        /// <param name="eulerAngles">
        /// Optional three-element vector containing three Euler angles of rotation in
        ///  degrees.
        /// </param>
        /// <remarks>
        ///  The function computes a decomposition of a projection matrix into a calibration and a rotation
        ///  matrix and the position of a camera.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and three Euler angles that could
        ///  be used in OpenGL. Note, there is always more than one sequence of rotations about the three
        ///  principal axes that results in the same orientation of an object, e.g. see @cite Slabaugh . Returned
        ///  three rotation matrices and corresponding three Euler angles are only one of the possible solutions.
        ///  
        ///  The function is based on #RQDecomp3x3 .
        /// </remarks>
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect, Mat rotMatrixX)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();
            if (rotMatrixX != null) rotMatrixX.ThrowIfDisposed();

            calib3d_Calib3d_decomposeProjectionMatrix_13(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj, rotMatrixX.nativeObj);


        }

        /// <summary>
        ///  Decomposes a projection matrix into a rotation matrix and a camera intrinsic matrix.
        /// </summary>
        /// <param name="projMatrix">
        /// 3x4 input projection matrix P.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 camera intrinsic matrix \f$\cameramatrix{A}\f$.
        /// </param>
        /// <param name="rotMatrix">
        /// Output 3x3 external rotation matrix R.
        /// </param>
        /// <param name="transVect">
        /// Output 4x1 translation vector T.
        /// </param>
        /// <param name="rotMatrixX">
        /// Optional 3x3 rotation matrix around x-axis.
        /// </param>
        /// <param name="rotMatrixY">
        /// Optional 3x3 rotation matrix around y-axis.
        /// </param>
        /// <param name="rotMatrixZ">
        /// Optional 3x3 rotation matrix around z-axis.
        /// </param>
        /// <param name="eulerAngles">
        /// Optional three-element vector containing three Euler angles of rotation in
        ///  degrees.
        /// </param>
        /// <remarks>
        ///  The function computes a decomposition of a projection matrix into a calibration and a rotation
        ///  matrix and the position of a camera.
        ///  
        ///  It optionally returns three rotation matrices, one for each axis, and three Euler angles that could
        ///  be used in OpenGL. Note, there is always more than one sequence of rotations about the three
        ///  principal axes that results in the same orientation of an object, e.g. see @cite Slabaugh . Returned
        ///  three rotation matrices and corresponding three Euler angles are only one of the possible solutions.
        ///  
        ///  The function is based on #RQDecomp3x3 .
        /// </remarks>
        public static void decomposeProjectionMatrix(Mat projMatrix, Mat cameraMatrix, Mat rotMatrix, Mat transVect)
        {
            if (projMatrix != null) projMatrix.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (rotMatrix != null) rotMatrix.ThrowIfDisposed();
            if (transVect != null) transVect.ThrowIfDisposed();

            calib3d_Calib3d_decomposeProjectionMatrix_14(projMatrix.nativeObj, cameraMatrix.nativeObj, rotMatrix.nativeObj, transVect.nativeObj);


        }


        //
        // C++:  void cv::matMulDeriv(Mat A, Mat B, Mat& dABdA, Mat& dABdB)
        //

        /// <summary>
        ///  Computes partial derivatives of the matrix product for each multiplied matrix.
        /// </summary>
        /// <param name="A">
        /// First multiplied matrix.
        /// </param>
        /// <param name="B">
        /// Second multiplied matrix.
        /// </param>
        /// <param name="dABdA">
        /// First output derivative matrix d(A\*B)/dA of size
        ///  \f$\texttt{A.rows*B.cols} \times {A.rows*A.cols}\f$ .
        /// </param>
        /// <param name="dABdB">
        /// Second output derivative matrix d(A\*B)/dB of size
        ///  \f$\texttt{A.rows*B.cols} \times {B.rows*B.cols}\f$ .
        /// </param>
        /// <remarks>
        ///  The function computes partial derivatives of the elements of the matrix product \f$A*B\f$ with regard to
        ///  the elements of each of the two input matrices. The function is used to compute the Jacobian
        ///  matrices in #stereoCalibrate but can also be used in any other similar optimization function.
        /// </remarks>
        public static void matMulDeriv(Mat A, Mat B, Mat dABdA, Mat dABdB)
        {
            if (A != null) A.ThrowIfDisposed();
            if (B != null) B.ThrowIfDisposed();
            if (dABdA != null) dABdA.ThrowIfDisposed();
            if (dABdB != null) dABdB.ThrowIfDisposed();

            calib3d_Calib3d_matMulDeriv_10(A.nativeObj, B.nativeObj, dABdA.nativeObj, dABdB.nativeObj);


        }


        //
        // C++:  void cv::composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat& rvec3, Mat& tvec3, Mat& dr3dr1 = Mat(), Mat& dr3dt1 = Mat(), Mat& dr3dr2 = Mat(), Mat& dr3dt2 = Mat(), Mat& dt3dr1 = Mat(), Mat& dt3dt1 = Mat(), Mat& dt3dr2 = Mat(), Mat& dt3dt2 = Mat())
        //

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1, Mat dt3dr2, Mat dt3dt2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
            if (dt3dt1 != null) dt3dt1.ThrowIfDisposed();
            if (dt3dr2 != null) dt3dr2.ThrowIfDisposed();
            if (dt3dt2 != null) dt3dt2.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_10(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj, dt3dt1.nativeObj, dt3dr2.nativeObj, dt3dt2.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1, Mat dt3dr2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
            if (dt3dt1 != null) dt3dt1.ThrowIfDisposed();
            if (dt3dr2 != null) dt3dr2.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_11(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj, dt3dt1.nativeObj, dt3dr2.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1, Mat dt3dt1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();
            if (dt3dt1 != null) dt3dt1.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_12(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj, dt3dt1.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2, Mat dt3dr1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();
            if (dt3dr1 != null) dt3dr1.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_13(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj, dt3dr1.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2, Mat dr3dt2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();
            if (dr3dt2 != null) dr3dt2.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_14(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj, dr3dt2.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1, Mat dr3dr2)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();
            if (dr3dr2 != null) dr3dr2.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_15(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj, dr3dr2.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1, Mat dr3dt1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();
            if (dr3dt1 != null) dr3dt1.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_16(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj, dr3dt1.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3, Mat dr3dr1)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();
            if (dr3dr1 != null) dr3dr1.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_17(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj, dr3dr1.nativeObj);


        }

        /// <summary>
        ///  Combines two rotation-and-shift transformations.
        /// </summary>
        /// <param name="rvec1">
        /// First rotation vector.
        /// </param>
        /// <param name="tvec1">
        /// First translation vector.
        /// </param>
        /// <param name="rvec2">
        /// Second rotation vector.
        /// </param>
        /// <param name="tvec2">
        /// Second translation vector.
        /// </param>
        /// <param name="rvec3">
        /// Output rotation vector of the superposition.
        /// </param>
        /// <param name="tvec3">
        /// Output translation vector of the superposition.
        /// </param>
        /// <param name="dr3dr1">
        /// Optional output derivative of rvec3 with regard to rvec1
        /// </param>
        /// <param name="dr3dt1">
        /// Optional output derivative of rvec3 with regard to tvec1
        /// </param>
        /// <param name="dr3dr2">
        /// Optional output derivative of rvec3 with regard to rvec2
        /// </param>
        /// <param name="dr3dt2">
        /// Optional output derivative of rvec3 with regard to tvec2
        /// </param>
        /// <param name="dt3dr1">
        /// Optional output derivative of tvec3 with regard to rvec1
        /// </param>
        /// <param name="dt3dt1">
        /// Optional output derivative of tvec3 with regard to tvec1
        /// </param>
        /// <param name="dt3dr2">
        /// Optional output derivative of tvec3 with regard to rvec2
        /// </param>
        /// <param name="dt3dt2">
        /// Optional output derivative of tvec3 with regard to tvec2
        /// </param>
        /// <remarks>
        ///  The functions compute:
        ///  
        ///  \f[\begin{array}{l} \texttt{rvec3} =  \mathrm{rodrigues} ^{-1} \left ( \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \mathrm{rodrigues} ( \texttt{rvec1} ) \right )  \\ \texttt{tvec3} =  \mathrm{rodrigues} ( \texttt{rvec2} )  \cdot \texttt{tvec1} +  \texttt{tvec2} \end{array} ,\f]
        ///  
        ///  where \f$\mathrm{rodrigues}\f$ denotes a rotation vector to a rotation matrix transformation, and
        ///  \f$\mathrm{rodrigues}^{-1}\f$ denotes the inverse transformation. See #Rodrigues for details.
        ///  
        ///  Also, the functions can compute the derivatives of the output vectors with regards to the input
        ///  vectors (see #matMulDeriv ). The functions are used inside #stereoCalibrate but can also be used in
        ///  your own code where Levenberg-Marquardt or another gradient-based solver is used to optimize a
        ///  function that contains a matrix multiplication.
        /// </remarks>
        public static void composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat rvec3, Mat tvec3)
        {
            if (rvec1 != null) rvec1.ThrowIfDisposed();
            if (tvec1 != null) tvec1.ThrowIfDisposed();
            if (rvec2 != null) rvec2.ThrowIfDisposed();
            if (tvec2 != null) tvec2.ThrowIfDisposed();
            if (rvec3 != null) rvec3.ThrowIfDisposed();
            if (tvec3 != null) tvec3.ThrowIfDisposed();

            calib3d_Calib3d_composeRT_18(rvec1.nativeObj, tvec1.nativeObj, rvec2.nativeObj, tvec2.nativeObj, rvec3.nativeObj, tvec3.nativeObj);


        }


        //
        // C++:  void cv::projectPoints(vector_Point3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, vector_double distCoeffs, vector_Point2f& imagePoints, Mat& jacobian = Mat(), double aspectRatio = 0)
        //

        /// <summary>
        ///  Projects 3D points to an image plane.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points expressed wrt. the world coordinate frame. A 3xN/Nx3
        ///  1-channel or 1xN/Nx1 3-channel (or vector&lt;Point3f&gt; ), where N is the number of points in the view.
        /// </param>
        /// <param name="rvec">
        /// The rotation vector (@ref Rodrigues) that, together with tvec, performs a change of
        ///  basis from world to camera coordinate system, see @ref calibrateCamera for details.
        /// </param>
        /// <param name="tvec">
        /// The translation vector, see parameter description above.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$ . If the vector is empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="imagePoints">
        /// Output array of image points, 1xN/Nx1 2-channel, or
        ///  vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="jacobian">
        /// Optional output 2Nx(10+&lt;numDistCoeffs&gt;) jacobian matrix of derivatives of image
        ///  points with respect to components of the rotation vector, translation vector, focal lengths,
        ///  coordinates of the principal point and the distortion coefficients. In the old interface different
        ///  components of the jacobian are returned via different output parameters.
        /// </param>
        /// <param name="aspectRatio">
        /// Optional "fixed aspect ratio" parameter. If the parameter is not 0, the
        ///  function assumes that the aspect ratio (\f$f_x / f_y\f$) is fixed and correspondingly adjusts the
        ///  jacobian matrix.
        /// </param>
        /// <remarks>
        ///  The function computes the 2D projections of 3D points to the image plane, given intrinsic and
        ///  extrinsic camera parameters. Optionally, the function computes Jacobians -matrices of partial
        ///  derivatives of image points coordinates (as functions of all the input parameters) with respect to
        ///  the particular parameters, intrinsic and/or extrinsic. The Jacobians are used during the global
        ///  optimization in @ref calibrateCamera, @ref solvePnP, and @ref stereoCalibrate. The function itself
        ///  can also be used to compute a re-projection error, given the current intrinsic and extrinsic
        ///  parameters.
        ///  
        ///  @note By setting rvec = tvec = \f$[0, 0, 0]\f$, or by setting cameraMatrix to a 3x3 identity matrix,
        ///  or by passing zero distortion coefficients, one can get various useful partial cases of the
        ///  function. This means, one can compute the distorted coordinates for a sparse set of points or apply
        ///  a perspective transformation (and also compute the derivatives) in the ideal zero-distortion setup.
        /// </remarks>
        public static void projectPoints(MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints, Mat jacobian, double aspectRatio)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat distCoeffs_mat = distCoeffs;
            Mat imagePoints_mat = imagePoints;
            calib3d_Calib3d_projectPoints_10(objectPoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, imagePoints_mat.nativeObj, jacobian.nativeObj, aspectRatio);


        }

        /// <summary>
        ///  Projects 3D points to an image plane.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points expressed wrt. the world coordinate frame. A 3xN/Nx3
        ///  1-channel or 1xN/Nx1 3-channel (or vector&lt;Point3f&gt; ), where N is the number of points in the view.
        /// </param>
        /// <param name="rvec">
        /// The rotation vector (@ref Rodrigues) that, together with tvec, performs a change of
        ///  basis from world to camera coordinate system, see @ref calibrateCamera for details.
        /// </param>
        /// <param name="tvec">
        /// The translation vector, see parameter description above.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$ . If the vector is empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="imagePoints">
        /// Output array of image points, 1xN/Nx1 2-channel, or
        ///  vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="jacobian">
        /// Optional output 2Nx(10+&lt;numDistCoeffs&gt;) jacobian matrix of derivatives of image
        ///  points with respect to components of the rotation vector, translation vector, focal lengths,
        ///  coordinates of the principal point and the distortion coefficients. In the old interface different
        ///  components of the jacobian are returned via different output parameters.
        /// </param>
        /// <param name="aspectRatio">
        /// Optional "fixed aspect ratio" parameter. If the parameter is not 0, the
        ///  function assumes that the aspect ratio (\f$f_x / f_y\f$) is fixed and correspondingly adjusts the
        ///  jacobian matrix.
        /// </param>
        /// <remarks>
        ///  The function computes the 2D projections of 3D points to the image plane, given intrinsic and
        ///  extrinsic camera parameters. Optionally, the function computes Jacobians -matrices of partial
        ///  derivatives of image points coordinates (as functions of all the input parameters) with respect to
        ///  the particular parameters, intrinsic and/or extrinsic. The Jacobians are used during the global
        ///  optimization in @ref calibrateCamera, @ref solvePnP, and @ref stereoCalibrate. The function itself
        ///  can also be used to compute a re-projection error, given the current intrinsic and extrinsic
        ///  parameters.
        ///  
        ///  @note By setting rvec = tvec = \f$[0, 0, 0]\f$, or by setting cameraMatrix to a 3x3 identity matrix,
        ///  or by passing zero distortion coefficients, one can get various useful partial cases of the
        ///  function. This means, one can compute the distorted coordinates for a sparse set of points or apply
        ///  a perspective transformation (and also compute the derivatives) in the ideal zero-distortion setup.
        /// </remarks>
        public static void projectPoints(MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints, Mat jacobian)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat distCoeffs_mat = distCoeffs;
            Mat imagePoints_mat = imagePoints;
            calib3d_Calib3d_projectPoints_11(objectPoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, imagePoints_mat.nativeObj, jacobian.nativeObj);


        }

        /// <summary>
        ///  Projects 3D points to an image plane.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points expressed wrt. the world coordinate frame. A 3xN/Nx3
        ///  1-channel or 1xN/Nx1 3-channel (or vector&lt;Point3f&gt; ), where N is the number of points in the view.
        /// </param>
        /// <param name="rvec">
        /// The rotation vector (@ref Rodrigues) that, together with tvec, performs a change of
        ///  basis from world to camera coordinate system, see @ref calibrateCamera for details.
        /// </param>
        /// <param name="tvec">
        /// The translation vector, see parameter description above.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$ . If the vector is empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="imagePoints">
        /// Output array of image points, 1xN/Nx1 2-channel, or
        ///  vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="jacobian">
        /// Optional output 2Nx(10+&lt;numDistCoeffs&gt;) jacobian matrix of derivatives of image
        ///  points with respect to components of the rotation vector, translation vector, focal lengths,
        ///  coordinates of the principal point and the distortion coefficients. In the old interface different
        ///  components of the jacobian are returned via different output parameters.
        /// </param>
        /// <param name="aspectRatio">
        /// Optional "fixed aspect ratio" parameter. If the parameter is not 0, the
        ///  function assumes that the aspect ratio (\f$f_x / f_y\f$) is fixed and correspondingly adjusts the
        ///  jacobian matrix.
        /// </param>
        /// <remarks>
        ///  The function computes the 2D projections of 3D points to the image plane, given intrinsic and
        ///  extrinsic camera parameters. Optionally, the function computes Jacobians -matrices of partial
        ///  derivatives of image points coordinates (as functions of all the input parameters) with respect to
        ///  the particular parameters, intrinsic and/or extrinsic. The Jacobians are used during the global
        ///  optimization in @ref calibrateCamera, @ref solvePnP, and @ref stereoCalibrate. The function itself
        ///  can also be used to compute a re-projection error, given the current intrinsic and extrinsic
        ///  parameters.
        ///  
        ///  @note By setting rvec = tvec = \f$[0, 0, 0]\f$, or by setting cameraMatrix to a 3x3 identity matrix,
        ///  or by passing zero distortion coefficients, one can get various useful partial cases of the
        ///  function. This means, one can compute the distorted coordinates for a sparse set of points or apply
        ///  a perspective transformation (and also compute the derivatives) in the ideal zero-distortion setup.
        /// </remarks>
        public static void projectPoints(MatOfPoint3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, MatOfDouble distCoeffs, MatOfPoint2f imagePoints)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat distCoeffs_mat = distCoeffs;
            Mat imagePoints_mat = imagePoints;
            calib3d_Calib3d_projectPoints_12(objectPoints_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, imagePoints_mat.nativeObj);


        }


        //
        // C++:  bool cv::solvePnP(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int flags = SOLVEPNP_ITERATIVE)
        //

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///  coordinate frame to the camera coordinate frame, using different methods:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <remarks>
        ///  More information about Perspective-n-Points is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      -  With @ref SOLVEPNP_SQPNP input points must be &gt;= 3
        /// </remarks>
        public static bool solvePnP(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnP_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, flags);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///  coordinate frame to the camera coordinate frame, using different methods:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <remarks>
        ///  More information about Perspective-n-Points is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      -  With @ref SOLVEPNP_SQPNP input points must be &gt;= 3
        /// </remarks>
        public static bool solvePnP(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnP_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///  coordinate frame to the camera coordinate frame, using different methods:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <remarks>
        ///  More information about Perspective-n-Points is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      -  With @ref SOLVEPNP_SQPNP input points must be &gt;= 3
        /// </remarks>
        public static bool solvePnP(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnP_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj);


        }


        //
        // C++:  bool cv::solvePnPRansac(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int iterationsCount = 100, float reprojectionError = 8.0, double confidence = 0.99, Mat& inliers = Mat(), int flags = SOLVEPNP_ITERATIVE)
        //

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError, confidence, inliers.nativeObj, flags);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, Mat inliers)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError, confidence, inliers.nativeObj);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError, confidence);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount, float reprojectionError)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_13(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount, reprojectionError);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int iterationsCount)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_14(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, iterationsCount);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_15(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences using the RANSAC scheme.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for @ref SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="iterationsCount">
        /// Number of iterations.
        /// </param>
        /// <param name="reprojectionError">
        /// Inlier threshold value used by the RANSAC procedure. The parameter value
        ///  is the maximum allowed distance between the observed and computed point projections to consider it
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// The probability that the algorithm produces a useful result.
        /// </param>
        /// <param name="inliers">
        /// Output vector that contains indices of inliers in objectPoints and imagePoints .
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem (see @ref solvePnP ).
        /// </param>
        /// <remarks>
        ///  The function estimates an object pose given a set of object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients. This function finds such
        ///  a pose that minimizes reprojection error, that is, the sum of squared distances between the observed
        ///  projections imagePoints and the projected (using @ref projectPoints ) objectPoints. The use of RANSAC
        ///  makes the function resistant to outliers.
        ///  
        ///  @note
        ///     -   An example of how to use solvePNPRansac for object detection can be found at
        ///          opencv_source_code/samples/cpp/tutorial_code/calib3d/real_time_pose_estimation/
        ///     -   The default method used to estimate the camera pose for the Minimal Sample Sets step
        ///         is #SOLVEPNP_EPNP. Exceptions are:
        ///           - if you choose #SOLVEPNP_P3P or #SOLVEPNP_AP3P, these methods will be used.
        ///           - if the number of input points is equal to 4, #SOLVEPNP_P3P is used.
        ///     -   The method used to estimate the camera pose using all the inliers is defined by the
        ///         flags parameters unless it is equal to #SOLVEPNP_P3P or #SOLVEPNP_AP3P. In this case,
        ///         the method #SOLVEPNP_EPNP will be used instead.
        /// </remarks>
        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_16(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj);


        }


        //
        // C++:  bool cv::solvePnPRansac(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat& cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, Mat& inliers, UsacParams _params = UsacParams())
        //

        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, Mat inliers, UsacParams _params)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_17(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, inliers.nativeObj, _params.nativeObj);


        }

        public static bool solvePnPRansac(MatOfPoint3f objectPoints, MatOfPoint2f imagePoints, Mat cameraMatrix, MatOfDouble distCoeffs, Mat rvec, Mat tvec, Mat inliers)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
            Mat objectPoints_mat = objectPoints;
            Mat imagePoints_mat = imagePoints;
            Mat distCoeffs_mat = distCoeffs;
            return calib3d_Calib3d_solvePnPRansac_18(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs_mat.nativeObj, rvec.nativeObj, tvec.nativeObj, inliers.nativeObj);


        }


        //
        // C++:  int cv::solveP3P(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags)
        //

        /// <summary>
        ///  Finds an object pose from 3 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, 3x3 1-channel or
        ///  1x3/3x1 3-channel. vector&lt;Point3f&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, 3x2 1-channel or 1x3/3x1 2-channel.
        ///   vector&lt;Point2f&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system. A P3P problem has up to 4 solutions.
        /// </param>
        /// <param name="tvecs">
        /// Output translation vectors.
        /// </param>
        /// <param name="flags">
        /// Method for solving a P3P problem:
        ///  -   @ref SOLVEPNP_P3P Method is based on the paper of X.S. Gao, X.-R. Hou, J. Tang, H.-F. Chang
        ///  "Complete Solution Classification for the Perspective-Three-Point Problem" (@cite gao2003complete).
        ///  -   @ref SOLVEPNP_AP3P Method is based on the paper of T. Ke and S. Roumeliotis.
        ///  "An Efficient Algebraic Solution to the Perspective-Three-Point Problem" (@cite Ke17).
        /// </param>
        /// <remarks>
        ///  The function estimates the object pose given 3 object points, their corresponding image
        ///  projections, as well as the camera intrinsic matrix and the distortion coefficients.
        ///  
        ///  @note
        ///  The solutions are sorted by reprojection errors (lowest to highest).
        /// </remarks>
        public static int solveP3P(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solveP3P_10(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  void cv::solvePnPRefineLM(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, TermCriteria criteria = TermCriteria(TermCriteria::EPS + TermCriteria::COUNT, 20, FLT_EPSILON))
        //

        /// <summary>
        ///  Refine a pose (the translation and the rotation that transform a 3D point expressed in the object coordinate frame
        ///  to the camera coordinate frame) from a 3D-2D point correspondences and starting from an initial solution.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or 1xN/Nx1 3-channel,
        ///  where N is the number of points. vector&lt;Point3d&gt; can also be passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can also be passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Input/Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system. Input values are used as an initial solution.
        /// </param>
        /// <param name="tvec">
        /// Input/Output translation vector. Input values are used as an initial solution.
        /// </param>
        /// <param name="criteria">
        /// Criteria when to stop the Levenberg-Marquard iterative algorithm.
        /// </param>
        /// <remarks>
        ///  The function refines the object pose given at least 3 object points, their corresponding image
        ///  projections, an initial solution for the rotation and translation vector,
        ///  as well as the camera intrinsic matrix and the distortion coefficients.
        ///  The function minimizes the projection error with respect to the rotation and the translation vectors, according
        ///  to a Levenberg-Marquardt iterative minimization @cite Madsen04 @cite Eade13 process.
        /// </remarks>
        public static void solvePnPRefineLM(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, TermCriteria criteria)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_solvePnPRefineLM_10(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        /// <summary>
        ///  Refine a pose (the translation and the rotation that transform a 3D point expressed in the object coordinate frame
        ///  to the camera coordinate frame) from a 3D-2D point correspondences and starting from an initial solution.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or 1xN/Nx1 3-channel,
        ///  where N is the number of points. vector&lt;Point3d&gt; can also be passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can also be passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Input/Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system. Input values are used as an initial solution.
        /// </param>
        /// <param name="tvec">
        /// Input/Output translation vector. Input values are used as an initial solution.
        /// </param>
        /// <param name="criteria">
        /// Criteria when to stop the Levenberg-Marquard iterative algorithm.
        /// </param>
        /// <remarks>
        ///  The function refines the object pose given at least 3 object points, their corresponding image
        ///  projections, an initial solution for the rotation and translation vector,
        ///  as well as the camera intrinsic matrix and the distortion coefficients.
        ///  The function minimizes the projection error with respect to the rotation and the translation vectors, according
        ///  to a Levenberg-Marquardt iterative minimization @cite Madsen04 @cite Eade13 process.
        /// </remarks>
        public static void solvePnPRefineLM(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_solvePnPRefineLM_11(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj);


        }


        //
        // C++:  void cv::solvePnPRefineVVS(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, TermCriteria criteria = TermCriteria(TermCriteria::EPS + TermCriteria::COUNT, 20, FLT_EPSILON), double VVSlambda = 1)
        //

        /// <summary>
        ///  Refine a pose (the translation and the rotation that transform a 3D point expressed in the object coordinate frame
        ///  to the camera coordinate frame) from a 3D-2D point correspondences and starting from an initial solution.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or 1xN/Nx1 3-channel,
        ///  where N is the number of points. vector&lt;Point3d&gt; can also be passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can also be passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Input/Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system. Input values are used as an initial solution.
        /// </param>
        /// <param name="tvec">
        /// Input/Output translation vector. Input values are used as an initial solution.
        /// </param>
        /// <param name="criteria">
        /// Criteria when to stop the Levenberg-Marquard iterative algorithm.
        /// </param>
        /// <param name="VVSlambda">
        /// Gain for the virtual visual servoing control law, equivalent to the \f$\alpha\f$
        ///  gain in the Damped Gauss-Newton formulation.
        /// </param>
        /// <remarks>
        ///  The function refines the object pose given at least 3 object points, their corresponding image
        ///  projections, an initial solution for the rotation and translation vector,
        ///  as well as the camera intrinsic matrix and the distortion coefficients.
        ///  The function minimizes the projection error with respect to the rotation and the translation vectors, using a
        ///  virtual visual servoing (VVS) @cite Chaumette06 @cite Marchand16 scheme.
        /// </remarks>
        public static void solvePnPRefineVVS(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, TermCriteria criteria, double VVSlambda)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_solvePnPRefineVVS_10(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon, VVSlambda);


        }

        /// <summary>
        ///  Refine a pose (the translation and the rotation that transform a 3D point expressed in the object coordinate frame
        ///  to the camera coordinate frame) from a 3D-2D point correspondences and starting from an initial solution.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or 1xN/Nx1 3-channel,
        ///  where N is the number of points. vector&lt;Point3d&gt; can also be passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can also be passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Input/Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system. Input values are used as an initial solution.
        /// </param>
        /// <param name="tvec">
        /// Input/Output translation vector. Input values are used as an initial solution.
        /// </param>
        /// <param name="criteria">
        /// Criteria when to stop the Levenberg-Marquard iterative algorithm.
        /// </param>
        /// <param name="VVSlambda">
        /// Gain for the virtual visual servoing control law, equivalent to the \f$\alpha\f$
        ///  gain in the Damped Gauss-Newton formulation.
        /// </param>
        /// <remarks>
        ///  The function refines the object pose given at least 3 object points, their corresponding image
        ///  projections, an initial solution for the rotation and translation vector,
        ///  as well as the camera intrinsic matrix and the distortion coefficients.
        ///  The function minimizes the projection error with respect to the rotation and the translation vectors, using a
        ///  virtual visual servoing (VVS) @cite Chaumette06 @cite Marchand16 scheme.
        /// </remarks>
        public static void solvePnPRefineVVS(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, TermCriteria criteria)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_solvePnPRefineVVS_11(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        /// <summary>
        ///  Refine a pose (the translation and the rotation that transform a 3D point expressed in the object coordinate frame
        ///  to the camera coordinate frame) from a 3D-2D point correspondences and starting from an initial solution.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or 1xN/Nx1 3-channel,
        ///  where N is the number of points. vector&lt;Point3d&gt; can also be passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can also be passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvec">
        /// Input/Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system. Input values are used as an initial solution.
        /// </param>
        /// <param name="tvec">
        /// Input/Output translation vector. Input values are used as an initial solution.
        /// </param>
        /// <param name="criteria">
        /// Criteria when to stop the Levenberg-Marquard iterative algorithm.
        /// </param>
        /// <param name="VVSlambda">
        /// Gain for the virtual visual servoing control law, equivalent to the \f$\alpha\f$
        ///  gain in the Damped Gauss-Newton formulation.
        /// </param>
        /// <remarks>
        ///  The function refines the object pose given at least 3 object points, their corresponding image
        ///  projections, an initial solution for the rotation and translation vector,
        ///  as well as the camera intrinsic matrix and the distortion coefficients.
        ///  The function minimizes the projection error with respect to the rotation and the translation vectors, using a
        ///  virtual visual servoing (VVS) @cite Chaumette06 @cite Marchand16 scheme.
        /// </remarks>
        public static void solvePnPRefineVVS(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_solvePnPRefineVVS_12(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj);


        }


        //
        // C++:  int cv::solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, bool useExtrinsicGuess = false, SolvePnPMethod flags = SOLVEPNP_ITERATIVE, Mat rvec = Mat(), Mat tvec = Mat(), Mat& reprojectionError = Mat())
        //

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns a list of all the possible solutions (a solution is a &lt;rotation vector, translation vector&gt;
        ///  couple), depending on the number of input points and the chosen method:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): 3 or 4 input points. Number of returned solutions can be between 0 and 4 with 3 input points.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar. Returns 2 solutions.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4 and 2 solutions are returned. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        ///  Only 1 solution is returned.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Vector of output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvecs">
        /// Vector of output translation vectors.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <param name="rvec">
        /// Rotation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="tvec">
        /// Translation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="reprojectionError">
        /// Optional vector of reprojection error, that is the RMS error
        ///  (\f$ \text{RMSE} = \sqrt{\frac{\sum_{i}^{N} \left ( \hat{y_i} - y_i \right )^2}{N}} \f$) between the input image points
        ///  and the 3D object points projected with the estimated pose.
        /// </param>
        /// <remarks>
        ///  More information is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        /// </remarks>
        public static int solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, bool useExtrinsicGuess, int flags, Mat rvec, Mat tvec, Mat reprojectionError)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (reprojectionError != null) reprojectionError.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solvePnPGeneric_10(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, useExtrinsicGuess, flags, rvec.nativeObj, tvec.nativeObj, reprojectionError.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns a list of all the possible solutions (a solution is a &lt;rotation vector, translation vector&gt;
        ///  couple), depending on the number of input points and the chosen method:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): 3 or 4 input points. Number of returned solutions can be between 0 and 4 with 3 input points.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar. Returns 2 solutions.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4 and 2 solutions are returned. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        ///  Only 1 solution is returned.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Vector of output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvecs">
        /// Vector of output translation vectors.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <param name="rvec">
        /// Rotation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="tvec">
        /// Translation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="reprojectionError">
        /// Optional vector of reprojection error, that is the RMS error
        ///  (\f$ \text{RMSE} = \sqrt{\frac{\sum_{i}^{N} \left ( \hat{y_i} - y_i \right )^2}{N}} \f$) between the input image points
        ///  and the 3D object points projected with the estimated pose.
        /// </param>
        /// <remarks>
        ///  More information is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        /// </remarks>
        public static int solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, bool useExtrinsicGuess, int flags, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solvePnPGeneric_11(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, useExtrinsicGuess, flags, rvec.nativeObj, tvec.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns a list of all the possible solutions (a solution is a &lt;rotation vector, translation vector&gt;
        ///  couple), depending on the number of input points and the chosen method:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): 3 or 4 input points. Number of returned solutions can be between 0 and 4 with 3 input points.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar. Returns 2 solutions.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4 and 2 solutions are returned. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        ///  Only 1 solution is returned.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Vector of output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvecs">
        /// Vector of output translation vectors.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <param name="rvec">
        /// Rotation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="tvec">
        /// Translation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="reprojectionError">
        /// Optional vector of reprojection error, that is the RMS error
        ///  (\f$ \text{RMSE} = \sqrt{\frac{\sum_{i}^{N} \left ( \hat{y_i} - y_i \right )^2}{N}} \f$) between the input image points
        ///  and the 3D object points projected with the estimated pose.
        /// </param>
        /// <remarks>
        ///  More information is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        /// </remarks>
        public static int solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, bool useExtrinsicGuess, int flags, Mat rvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solvePnPGeneric_12(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, useExtrinsicGuess, flags, rvec.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns a list of all the possible solutions (a solution is a &lt;rotation vector, translation vector&gt;
        ///  couple), depending on the number of input points and the chosen method:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): 3 or 4 input points. Number of returned solutions can be between 0 and 4 with 3 input points.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar. Returns 2 solutions.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4 and 2 solutions are returned. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        ///  Only 1 solution is returned.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Vector of output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvecs">
        /// Vector of output translation vectors.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <param name="rvec">
        /// Rotation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="tvec">
        /// Translation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="reprojectionError">
        /// Optional vector of reprojection error, that is the RMS error
        ///  (\f$ \text{RMSE} = \sqrt{\frac{\sum_{i}^{N} \left ( \hat{y_i} - y_i \right )^2}{N}} \f$) between the input image points
        ///  and the 3D object points projected with the estimated pose.
        /// </param>
        /// <remarks>
        ///  More information is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        /// </remarks>
        public static int solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, bool useExtrinsicGuess, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solvePnPGeneric_13(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, useExtrinsicGuess, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns a list of all the possible solutions (a solution is a &lt;rotation vector, translation vector&gt;
        ///  couple), depending on the number of input points and the chosen method:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): 3 or 4 input points. Number of returned solutions can be between 0 and 4 with 3 input points.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar. Returns 2 solutions.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4 and 2 solutions are returned. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        ///  Only 1 solution is returned.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Vector of output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvecs">
        /// Vector of output translation vectors.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <param name="rvec">
        /// Rotation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="tvec">
        /// Translation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="reprojectionError">
        /// Optional vector of reprojection error, that is the RMS error
        ///  (\f$ \text{RMSE} = \sqrt{\frac{\sum_{i}^{N} \left ( \hat{y_i} - y_i \right )^2}{N}} \f$) between the input image points
        ///  and the 3D object points projected with the estimated pose.
        /// </param>
        /// <remarks>
        ///  More information is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        /// </remarks>
        public static int solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, bool useExtrinsicGuess)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solvePnPGeneric_14(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, useExtrinsicGuess);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences.
        /// </summary>
        /// <remarks>
        ///  @see @ref calib3d_solvePnP
        ///  
        ///  This function returns a list of all the possible solutions (a solution is a &lt;rotation vector, translation vector&gt;
        ///  couple), depending on the number of input points and the chosen method:
        ///  - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): 3 or 4 input points. Number of returned solutions can be between 0 and 4 with 3 input points.
        ///  - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar. Returns 2 solutions.
        ///  - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///  Number of input points must be 4 and 2 solutions are returned. Object points must be defined in the following order:
        ///    - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///    - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///    - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///    - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///  - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        ///  Only 1 solution is returned.
        /// </remarks>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///  1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///  where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="rvecs">
        /// Vector of output rotation vectors (see @ref Rodrigues ) that, together with tvecs, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvecs">
        /// Vector of output translation vectors.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///  the provided rvec and tvec values as initial approximations of the rotation and translation
        ///  vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        /// </param>
        /// <param name="rvec">
        /// Rotation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="tvec">
        /// Translation vector used to initialize an iterative PnP refinement algorithm, when flag is @ref SOLVEPNP_ITERATIVE
        ///  and useExtrinsicGuess is set to true.
        /// </param>
        /// <param name="reprojectionError">
        /// Optional vector of reprojection error, that is the RMS error
        ///  (\f$ \text{RMSE} = \sqrt{\frac{\sum_{i}^{N} \left ( \hat{y_i} - y_i \right )^2}{N}} \f$) between the input image points
        ///  and the 3D object points projected with the estimated pose.
        /// </param>
        /// <remarks>
        ///  More information is described in @ref calib3d_solvePnP
        ///  
        ///  @note
        ///     -   An example of how to use solvePnP for planar augmented reality can be found at
        ///          opencv_source_code/samples/python/plane_ar.py
        ///     -   If you are using Python:
        ///          - Numpy array slices won't work as input because solvePnP requires contiguous
        ///          arrays (enforced by the assertion using cv::Mat::checkVector() around line 55 of
        ///          modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          - The P3P algorithm requires image points to be in an array of shape (N,1,2) due
        ///          to its calling of #undistortPoints (around line 75 of modules/calib3d/src/solvepnp.cpp version 2.4.9)
        ///          which requires 2-channel information.
        ///          - Thus, given some data D = np.array(...) where D.shape = (N,M), in order to use a subset of
        ///          it as, e.g., imagePoints, one must effectively copy it into a new array: imagePoints =
        ///          np.ascontiguousarray(D[:,:2]).reshape((N,1,2))
        ///     -   The methods @ref SOLVEPNP_DLS and @ref SOLVEPNP_UPNP cannot be used as the current implementations are
        ///         unstable and sometimes give completely wrong results. If you pass one of these two
        ///         flags, @ref SOLVEPNP_EPNP method will be used instead.
        ///     -   The minimum number of points is 4 in the general case. In the case of @ref SOLVEPNP_P3P and @ref SOLVEPNP_AP3P
        ///         methods, it is required to use exactly 4 points (the first 3 points are used to estimate all the solutions
        ///         of the P3P problem, the last one is used to retain the best solution that minimizes the reprojection error).
        ///     -   With @ref SOLVEPNP_ITERATIVE method and `useExtrinsicGuess=true`, the minimum number of points is 3 (3 points
        ///         are sufficient to compute a pose but there are up to 4 solutions). The initial solution should be close to the
        ///         global solution to converge.
        ///     -   With @ref SOLVEPNP_IPPE input points must be &gt;= 4 and object points must be coplanar.
        ///     -   With @ref SOLVEPNP_IPPE_SQUARE this is a special case suitable for marker pose estimation.
        ///         Number of input points must be 4. Object points must be defined in the following order:
        ///           - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///           - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///           - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///           - point 3: [-squareLength / 2, -squareLength / 2, 0]
        /// </remarks>
        public static int solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            int retVal = calib3d_Calib3d_solvePnPGeneric_15(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  Mat cv::initCameraMatrix2D(vector_vector_Point3f objectPoints, vector_vector_Point2f imagePoints, Size imageSize, double aspectRatio = 1.0)
        //

        /// <summary>
        ///  Finds an initial camera intrinsic matrix from 3D-2D point correspondences.
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points in the calibration pattern
        ///  coordinate space. In the old interface all the per-view vectors are concatenated. See
        ///  #calibrateCamera for details.
        /// </param>
        /// <param name="imagePoints">
        /// Vector of vectors of the projections of the calibration pattern points. In the
        ///  old interface all the per-view vectors are concatenated.
        /// </param>
        /// <param name="imageSize">
        /// Image size in pixels used to initialize the principal point.
        /// </param>
        /// <param name="aspectRatio">
        /// If it is zero or negative, both \f$f_x\f$ and \f$f_y\f$ are estimated independently.
        ///  Otherwise, \f$f_x = f_y \cdot \texttt{aspectRatio}\f$ .
        /// </param>
        /// <remarks>
        ///  The function estimates and returns an initial camera intrinsic matrix for the camera calibration process.
        ///  Currently, the function only supports planar calibration patterns, which are patterns where each
        ///  object point has z-coordinate =0.
        /// </remarks>
        public static Mat initCameraMatrix2D(List<MatOfPoint3f> objectPoints, List<MatOfPoint2f> imagePoints, Size imageSize, double aspectRatio)
        {

            List<Mat> objectPoints_tmplm = new List<Mat>((objectPoints != null) ? objectPoints.Count : 0);
            Mat objectPoints_mat = Converters.vector_vector_Point3f_to_Mat(objectPoints, objectPoints_tmplm);
            List<Mat> imagePoints_tmplm = new List<Mat>((imagePoints != null) ? imagePoints.Count : 0);
            Mat imagePoints_mat = Converters.vector_vector_Point2f_to_Mat(imagePoints, imagePoints_tmplm);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_initCameraMatrix2D_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, aspectRatio)));


        }

        /// <summary>
        ///  Finds an initial camera intrinsic matrix from 3D-2D point correspondences.
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points in the calibration pattern
        ///  coordinate space. In the old interface all the per-view vectors are concatenated. See
        ///  #calibrateCamera for details.
        /// </param>
        /// <param name="imagePoints">
        /// Vector of vectors of the projections of the calibration pattern points. In the
        ///  old interface all the per-view vectors are concatenated.
        /// </param>
        /// <param name="imageSize">
        /// Image size in pixels used to initialize the principal point.
        /// </param>
        /// <param name="aspectRatio">
        /// If it is zero or negative, both \f$f_x\f$ and \f$f_y\f$ are estimated independently.
        ///  Otherwise, \f$f_x = f_y \cdot \texttt{aspectRatio}\f$ .
        /// </param>
        /// <remarks>
        ///  The function estimates and returns an initial camera intrinsic matrix for the camera calibration process.
        ///  Currently, the function only supports planar calibration patterns, which are patterns where each
        ///  object point has z-coordinate =0.
        /// </remarks>
        public static Mat initCameraMatrix2D(List<MatOfPoint3f> objectPoints, List<MatOfPoint2f> imagePoints, Size imageSize)
        {

            List<Mat> objectPoints_tmplm = new List<Mat>((objectPoints != null) ? objectPoints.Count : 0);
            Mat objectPoints_mat = Converters.vector_vector_Point3f_to_Mat(objectPoints, objectPoints_tmplm);
            List<Mat> imagePoints_tmplm = new List<Mat>((imagePoints != null) ? imagePoints.Count : 0);
            Mat imagePoints_mat = Converters.vector_vector_Point2f_to_Mat(imagePoints, imagePoints_tmplm);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_initCameraMatrix2D_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height)));


        }


        //
        // C++:  bool cv::findChessboardCorners(Mat image, Size patternSize, vector_Point2f& corners, int flags = CALIB_CB_ADAPTIVE_THRESH + CALIB_CB_NORMALIZE_IMAGE)
        //

        /// <summary>
        ///  Finds the positions of internal corners of the chessboard.
        /// </summary>
        /// <param name="image">
        /// Source chessboard view. It must be an 8-bit grayscale or color image.
        /// </param>
        /// <param name="patternSize">
        /// Number of inner corners per a chessboard row and column
        ///  ( patternSize = cv::Size(points_per_row,points_per_colum) = cv::Size(columns,rows) ).
        /// </param>
        /// <param name="corners">
        /// Output array of detected corners.
        /// </param>
        /// <param name="flags">
        /// Various operation flags that can be zero or a combination of the following values:
        ///  -   @ref CALIB_CB_ADAPTIVE_THRESH Use adaptive thresholding to convert the image to black
        ///  and white, rather than a fixed threshold level (computed from the average image brightness).
        ///  -   @ref CALIB_CB_NORMALIZE_IMAGE Normalize the image gamma with #equalizeHist before
        ///  applying fixed or adaptive thresholding.
        ///  -   @ref CALIB_CB_FILTER_QUADS Use additional criteria (like contour area, perimeter,
        ///  square-like shape) to filter out false quads extracted at the contour retrieval stage.
        ///  -   @ref CALIB_CB_FAST_CHECK Run a fast check on the image that looks for chessboard corners,
        ///  and shortcut the call if none is found. This can drastically speed up the call in the
        ///  degenerate condition when no chessboard is observed.
        ///  -   @ref CALIB_CB_PLAIN All other flags are ignored. The input image is taken as is.
        ///  No image processing is done to improve to find the checkerboard. This has the effect of speeding up the
        ///  execution of the function but could lead to not recognizing the checkerboard if the image
        ///  is not previously binarized in the appropriate manner.
        /// </param>
        /// <remarks>
        ///  The function attempts to determine whether the input image is a view of the chessboard pattern and
        ///  locate the internal chessboard corners. The function returns a non-zero value if all of the corners
        ///  are found and they are placed in a certain order (row by row, left to right in every row).
        ///  Otherwise, if the function fails to find all the corners or reorder them, it returns 0. For example,
        ///  a regular chessboard has 8 x 8 squares and 7 x 7 internal corners, that is, points where the black
        ///  squares touch each other. The detected coordinates are approximate, and to determine their positions
        ///  more accurately, the function calls #cornerSubPix. You also may use the function #cornerSubPix with
        ///  different parameters if returned coordinates are not accurate enough.
        ///  
        ///  Sample usage of detecting and drawing chessboard corners: :
        /// </remarks>
        /// <code language="c++">
        ///      Size patternsize(8,6); //interior number of corners
        ///      Mat gray = ....; //source image
        ///      vector&lt;Point2f&gt; corners; //this will be filled by the detected corners
        ///  
        ///      //CALIB_CB_FAST_CHECK saves a lot of time on images
        ///      //that do not contain any chessboard corners
        ///      bool patternfound = findChessboardCorners(gray, patternsize, corners,
        ///              CALIB_CB_ADAPTIVE_THRESH + CALIB_CB_NORMALIZE_IMAGE
        ///              + CALIB_CB_FAST_CHECK);
        ///  
        ///      if(patternfound)
        ///        cornerSubPix(gray, corners, Size(11, 11), Size(-1, -1),
        ///          TermCriteria(CV_TERMCRIT_EPS + CV_TERMCRIT_ITER, 30, 0.1));
        ///  
        ///      drawChessboardCorners(img, patternsize, Mat(corners), patternfound);
        /// </code>
        /// <remarks>
        ///  @note The function requires white space (like a square-thick border, the wider the better) around
        ///  the board to make the detection more robust in various environments. Otherwise, if there is no
        ///  border and the background is dark, the outer black squares cannot be segmented properly and so the
        ///  square grouping and ordering algorithm fails.
        ///  
        ///  Use gen_pattern.py (@ref tutorial_camera_calibration_pattern) to create checkerboard.
        /// </remarks>
        public static bool findChessboardCorners(Mat image, Size patternSize, MatOfPoint2f corners, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
            Mat corners_mat = corners;
            return calib3d_Calib3d_findChessboardCorners_10(image.nativeObj, patternSize.width, patternSize.height, corners_mat.nativeObj, flags);


        }

        /// <summary>
        ///  Finds the positions of internal corners of the chessboard.
        /// </summary>
        /// <param name="image">
        /// Source chessboard view. It must be an 8-bit grayscale or color image.
        /// </param>
        /// <param name="patternSize">
        /// Number of inner corners per a chessboard row and column
        ///  ( patternSize = cv::Size(points_per_row,points_per_colum) = cv::Size(columns,rows) ).
        /// </param>
        /// <param name="corners">
        /// Output array of detected corners.
        /// </param>
        /// <param name="flags">
        /// Various operation flags that can be zero or a combination of the following values:
        ///  -   @ref CALIB_CB_ADAPTIVE_THRESH Use adaptive thresholding to convert the image to black
        ///  and white, rather than a fixed threshold level (computed from the average image brightness).
        ///  -   @ref CALIB_CB_NORMALIZE_IMAGE Normalize the image gamma with #equalizeHist before
        ///  applying fixed or adaptive thresholding.
        ///  -   @ref CALIB_CB_FILTER_QUADS Use additional criteria (like contour area, perimeter,
        ///  square-like shape) to filter out false quads extracted at the contour retrieval stage.
        ///  -   @ref CALIB_CB_FAST_CHECK Run a fast check on the image that looks for chessboard corners,
        ///  and shortcut the call if none is found. This can drastically speed up the call in the
        ///  degenerate condition when no chessboard is observed.
        ///  -   @ref CALIB_CB_PLAIN All other flags are ignored. The input image is taken as is.
        ///  No image processing is done to improve to find the checkerboard. This has the effect of speeding up the
        ///  execution of the function but could lead to not recognizing the checkerboard if the image
        ///  is not previously binarized in the appropriate manner.
        /// </param>
        /// <remarks>
        ///  The function attempts to determine whether the input image is a view of the chessboard pattern and
        ///  locate the internal chessboard corners. The function returns a non-zero value if all of the corners
        ///  are found and they are placed in a certain order (row by row, left to right in every row).
        ///  Otherwise, if the function fails to find all the corners or reorder them, it returns 0. For example,
        ///  a regular chessboard has 8 x 8 squares and 7 x 7 internal corners, that is, points where the black
        ///  squares touch each other. The detected coordinates are approximate, and to determine their positions
        ///  more accurately, the function calls #cornerSubPix. You also may use the function #cornerSubPix with
        ///  different parameters if returned coordinates are not accurate enough.
        ///  
        ///  Sample usage of detecting and drawing chessboard corners: :
        /// </remarks>
        /// <code language="c++">
        ///      Size patternsize(8,6); //interior number of corners
        ///      Mat gray = ....; //source image
        ///      vector&lt;Point2f&gt; corners; //this will be filled by the detected corners
        ///  
        ///      //CALIB_CB_FAST_CHECK saves a lot of time on images
        ///      //that do not contain any chessboard corners
        ///      bool patternfound = findChessboardCorners(gray, patternsize, corners,
        ///              CALIB_CB_ADAPTIVE_THRESH + CALIB_CB_NORMALIZE_IMAGE
        ///              + CALIB_CB_FAST_CHECK);
        ///  
        ///      if(patternfound)
        ///        cornerSubPix(gray, corners, Size(11, 11), Size(-1, -1),
        ///          TermCriteria(CV_TERMCRIT_EPS + CV_TERMCRIT_ITER, 30, 0.1));
        ///  
        ///      drawChessboardCorners(img, patternsize, Mat(corners), patternfound);
        /// </code>
        /// <remarks>
        ///  @note The function requires white space (like a square-thick border, the wider the better) around
        ///  the board to make the detection more robust in various environments. Otherwise, if there is no
        ///  border and the background is dark, the outer black squares cannot be segmented properly and so the
        ///  square grouping and ordering algorithm fails.
        ///  
        ///  Use gen_pattern.py (@ref tutorial_camera_calibration_pattern) to create checkerboard.
        /// </remarks>
        public static bool findChessboardCorners(Mat image, Size patternSize, MatOfPoint2f corners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
            Mat corners_mat = corners;
            return calib3d_Calib3d_findChessboardCorners_11(image.nativeObj, patternSize.width, patternSize.height, corners_mat.nativeObj);


        }


        //
        // C++:  bool cv::checkChessboard(Mat img, Size size)
        //

        public static bool checkChessboard(Mat img, Size size)
        {
            if (img != null) img.ThrowIfDisposed();

            return calib3d_Calib3d_checkChessboard_10(img.nativeObj, size.width, size.height);


        }


        //
        // C++:  bool cv::findChessboardCornersSB(Mat image, Size patternSize, Mat& corners, int flags, Mat& meta)
        //

        /// <summary>
        ///  Finds the positions of internal corners of the chessboard using a sector based approach.
        /// </summary>
        /// <param name="image">
        /// Source chessboard view. It must be an 8-bit grayscale or color image.
        /// </param>
        /// <param name="patternSize">
        /// Number of inner corners per a chessboard row and column
        ///  ( patternSize = cv::Size(points_per_row,points_per_colum) = cv::Size(columns,rows) ).
        /// </param>
        /// <param name="corners">
        /// Output array of detected corners.
        /// </param>
        /// <param name="flags">
        /// Various operation flags that can be zero or a combination of the following values:
        ///  -   @ref CALIB_CB_NORMALIZE_IMAGE Normalize the image gamma with equalizeHist before detection.
        ///  -   @ref CALIB_CB_EXHAUSTIVE Run an exhaustive search to improve detection rate.
        ///  -   @ref CALIB_CB_ACCURACY Up sample input image to improve sub-pixel accuracy due to aliasing effects.
        ///  -   @ref CALIB_CB_LARGER The detected pattern is allowed to be larger than patternSize (see description).
        ///  -   @ref CALIB_CB_MARKER The detected pattern must have a marker (see description).
        ///  This should be used if an accurate camera calibration is required.
        /// </param>
        /// <param name="meta">
        /// Optional output arrray of detected corners (CV_8UC1 and size = cv::Size(columns,rows)).
        ///  Each entry stands for one corner of the pattern and can have one of the following values:
        ///  -   0 = no meta data attached
        ///  -   1 = left-top corner of a black cell
        ///  -   2 = left-top corner of a white cell
        ///  -   3 = left-top corner of a black cell with a white marker dot
        ///  -   4 = left-top corner of a white cell with a black marker dot (pattern origin in case of markers otherwise first corner)
        /// </param>
        /// <remarks>
        ///  The function is analog to #findChessboardCorners but uses a localized radon
        ///  transformation approximated by box filters being more robust to all sort of
        ///  noise, faster on larger images and is able to directly return the sub-pixel
        ///  position of the internal chessboard corners. The Method is based on the paper
        ///  @cite duda2018 "Accurate Detection and Localization of Checkerboard Corners for
        ///  Calibration" demonstrating that the returned sub-pixel positions are more
        ///  accurate than the one returned by cornerSubPix allowing a precise camera
        ///  calibration for demanding applications.
        ///  
        ///  In the case, the flags @ref CALIB_CB_LARGER or @ref CALIB_CB_MARKER are given,
        ///  the result can be recovered from the optional meta array. Both flags are
        ///  helpful to use calibration patterns exceeding the field of view of the camera.
        ///  These oversized patterns allow more accurate calibrations as corners can be
        ///  utilized, which are as close as possible to the image borders.  For a
        ///  consistent coordinate system across all images, the optional marker (see image
        ///  below) can be used to move the origin of the board to the location where the
        ///  black circle is located.
        ///  
        ///  @note The function requires a white boarder with roughly the same width as one
        ///  of the checkerboard fields around the whole board to improve the detection in
        ///  various environments. In addition, because of the localized radon
        ///  transformation it is beneficial to use round corners for the field corners
        ///  which are located on the outside of the board. The following figure illustrates
        ///  a sample checkerboard optimized for the detection. However, any other checkerboard
        ///  can be used as well.
        ///  
        ///  Use gen_pattern.py (@ref tutorial_camera_calibration_pattern) to create checkerboard.
        ///  ![Checkerboard](pics/checkerboard_radon.png)
        /// </remarks>
        public static bool findChessboardCornersSBWithMeta(Mat image, Size patternSize, Mat corners, int flags, Mat meta)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
            if (meta != null) meta.ThrowIfDisposed();

            return calib3d_Calib3d_findChessboardCornersSBWithMeta_10(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, flags, meta.nativeObj);


        }


        //
        // C++:  bool cv::findChessboardCornersSB(Mat image, Size patternSize, Mat& corners, int flags = 0)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static bool findChessboardCornersSB(Mat image, Size patternSize, Mat corners, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();

            return calib3d_Calib3d_findChessboardCornersSB_10(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, flags);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static bool findChessboardCornersSB(Mat image, Size patternSize, Mat corners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();

            return calib3d_Calib3d_findChessboardCornersSB_11(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj);


        }


        //
        // C++:  Scalar cv::estimateChessboardSharpness(Mat image, Size patternSize, Mat corners, float rise_distance = 0.8F, bool vertical = false, Mat& sharpness = Mat())
        //

        /// <summary>
        ///  Estimates the sharpness of a detected chessboard.
        /// </summary>
        /// <remarks>
        ///  Image sharpness, as well as brightness, are a critical parameter for accuracte
        ///  camera calibration. For accessing these parameters for filtering out
        ///  problematic calibraiton images, this method calculates edge profiles by traveling from
        ///  black to white chessboard cell centers. Based on this, the number of pixels is
        ///  calculated required to transit from black to white. This width of the
        ///  transition area is a good indication of how sharp the chessboard is imaged
        ///  and should be below ~3.0 pixels.
        /// </remarks>
        /// <param name="image">
        /// Gray image used to find chessboard corners
        /// </param>
        /// <param name="patternSize">
        /// Size of a found chessboard pattern
        /// </param>
        /// <param name="corners">
        /// Corners found by #findChessboardCornersSB
        /// </param>
        /// <param name="rise_distance">
        /// Rise distance 0.8 means 10% ... 90% of the final signal strength
        /// </param>
        /// <param name="vertical">
        /// By default edge responses for horizontal lines are calculated
        /// </param>
        /// <param name="sharpness">
        /// Optional output array with a sharpness value for calculated edge responses (see description)
        /// </param>
        /// <remarks>
        ///  The optional sharpness array is of type CV_32FC1 and has for each calculated
        ///  profile one row with the following five entries:
        ///    0 = x coordinate of the underlying edge in the image
        ///    1 = y coordinate of the underlying edge in the image
        ///    2 = width of the transition area (sharpness)
        ///    3 = signal strength in the black cell (min brightness)
        ///    4 = signal strength in the white cell (max brightness)
        /// </remarks>
        /// <returns>
        ///  Scalar(average sharpness, average min brightness, average max brightness,0)
        /// </returns>
        public static Scalar estimateChessboardSharpness(Mat image, Size patternSize, Mat corners, float rise_distance, bool vertical, Mat sharpness)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
            if (sharpness != null) sharpness.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            calib3d_Calib3d_estimateChessboardSharpness_10(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, rise_distance, vertical, sharpness.nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }

        /// <summary>
        ///  Estimates the sharpness of a detected chessboard.
        /// </summary>
        /// <remarks>
        ///  Image sharpness, as well as brightness, are a critical parameter for accuracte
        ///  camera calibration. For accessing these parameters for filtering out
        ///  problematic calibraiton images, this method calculates edge profiles by traveling from
        ///  black to white chessboard cell centers. Based on this, the number of pixels is
        ///  calculated required to transit from black to white. This width of the
        ///  transition area is a good indication of how sharp the chessboard is imaged
        ///  and should be below ~3.0 pixels.
        /// </remarks>
        /// <param name="image">
        /// Gray image used to find chessboard corners
        /// </param>
        /// <param name="patternSize">
        /// Size of a found chessboard pattern
        /// </param>
        /// <param name="corners">
        /// Corners found by #findChessboardCornersSB
        /// </param>
        /// <param name="rise_distance">
        /// Rise distance 0.8 means 10% ... 90% of the final signal strength
        /// </param>
        /// <param name="vertical">
        /// By default edge responses for horizontal lines are calculated
        /// </param>
        /// <param name="sharpness">
        /// Optional output array with a sharpness value for calculated edge responses (see description)
        /// </param>
        /// <remarks>
        ///  The optional sharpness array is of type CV_32FC1 and has for each calculated
        ///  profile one row with the following five entries:
        ///    0 = x coordinate of the underlying edge in the image
        ///    1 = y coordinate of the underlying edge in the image
        ///    2 = width of the transition area (sharpness)
        ///    3 = signal strength in the black cell (min brightness)
        ///    4 = signal strength in the white cell (max brightness)
        /// </remarks>
        /// <returns>
        ///  Scalar(average sharpness, average min brightness, average max brightness,0)
        /// </returns>
        public static Scalar estimateChessboardSharpness(Mat image, Size patternSize, Mat corners, float rise_distance, bool vertical)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            calib3d_Calib3d_estimateChessboardSharpness_11(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, rise_distance, vertical, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }

        /// <summary>
        ///  Estimates the sharpness of a detected chessboard.
        /// </summary>
        /// <remarks>
        ///  Image sharpness, as well as brightness, are a critical parameter for accuracte
        ///  camera calibration. For accessing these parameters for filtering out
        ///  problematic calibraiton images, this method calculates edge profiles by traveling from
        ///  black to white chessboard cell centers. Based on this, the number of pixels is
        ///  calculated required to transit from black to white. This width of the
        ///  transition area is a good indication of how sharp the chessboard is imaged
        ///  and should be below ~3.0 pixels.
        /// </remarks>
        /// <param name="image">
        /// Gray image used to find chessboard corners
        /// </param>
        /// <param name="patternSize">
        /// Size of a found chessboard pattern
        /// </param>
        /// <param name="corners">
        /// Corners found by #findChessboardCornersSB
        /// </param>
        /// <param name="rise_distance">
        /// Rise distance 0.8 means 10% ... 90% of the final signal strength
        /// </param>
        /// <param name="vertical">
        /// By default edge responses for horizontal lines are calculated
        /// </param>
        /// <param name="sharpness">
        /// Optional output array with a sharpness value for calculated edge responses (see description)
        /// </param>
        /// <remarks>
        ///  The optional sharpness array is of type CV_32FC1 and has for each calculated
        ///  profile one row with the following five entries:
        ///    0 = x coordinate of the underlying edge in the image
        ///    1 = y coordinate of the underlying edge in the image
        ///    2 = width of the transition area (sharpness)
        ///    3 = signal strength in the black cell (min brightness)
        ///    4 = signal strength in the white cell (max brightness)
        /// </remarks>
        /// <returns>
        ///  Scalar(average sharpness, average min brightness, average max brightness,0)
        /// </returns>
        public static Scalar estimateChessboardSharpness(Mat image, Size patternSize, Mat corners, float rise_distance)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            calib3d_Calib3d_estimateChessboardSharpness_12(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, rise_distance, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }

        /// <summary>
        ///  Estimates the sharpness of a detected chessboard.
        /// </summary>
        /// <remarks>
        ///  Image sharpness, as well as brightness, are a critical parameter for accuracte
        ///  camera calibration. For accessing these parameters for filtering out
        ///  problematic calibraiton images, this method calculates edge profiles by traveling from
        ///  black to white chessboard cell centers. Based on this, the number of pixels is
        ///  calculated required to transit from black to white. This width of the
        ///  transition area is a good indication of how sharp the chessboard is imaged
        ///  and should be below ~3.0 pixels.
        /// </remarks>
        /// <param name="image">
        /// Gray image used to find chessboard corners
        /// </param>
        /// <param name="patternSize">
        /// Size of a found chessboard pattern
        /// </param>
        /// <param name="corners">
        /// Corners found by #findChessboardCornersSB
        /// </param>
        /// <param name="rise_distance">
        /// Rise distance 0.8 means 10% ... 90% of the final signal strength
        /// </param>
        /// <param name="vertical">
        /// By default edge responses for horizontal lines are calculated
        /// </param>
        /// <param name="sharpness">
        /// Optional output array with a sharpness value for calculated edge responses (see description)
        /// </param>
        /// <remarks>
        ///  The optional sharpness array is of type CV_32FC1 and has for each calculated
        ///  profile one row with the following five entries:
        ///    0 = x coordinate of the underlying edge in the image
        ///    1 = y coordinate of the underlying edge in the image
        ///    2 = width of the transition area (sharpness)
        ///    3 = signal strength in the black cell (min brightness)
        ///    4 = signal strength in the white cell (max brightness)
        /// </remarks>
        /// <returns>
        ///  Scalar(average sharpness, average min brightness, average max brightness,0)
        /// </returns>
        public static Scalar estimateChessboardSharpness(Mat image, Size patternSize, Mat corners)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            calib3d_Calib3d_estimateChessboardSharpness_13(image.nativeObj, patternSize.width, patternSize.height, corners.nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }


        //
        // C++:  bool cv::find4QuadCornerSubpix(Mat img, Mat& corners, Size region_size)
        //

        public static bool find4QuadCornerSubpix(Mat img, Mat corners, Size region_size)
        {
            if (img != null) img.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();

            return calib3d_Calib3d_find4QuadCornerSubpix_10(img.nativeObj, corners.nativeObj, region_size.width, region_size.height);


        }


        //
        // C++:  void cv::drawChessboardCorners(Mat& image, Size patternSize, vector_Point2f corners, bool patternWasFound)
        //

        /// <summary>
        ///  Renders the detected chessboard corners.
        /// </summary>
        /// <param name="image">
        /// Destination image. It must be an 8-bit color image.
        /// </param>
        /// <param name="patternSize">
        /// Number of inner corners per a chessboard row and column
        ///  (patternSize = cv::Size(points_per_row,points_per_column)).
        /// </param>
        /// <param name="corners">
        /// Array of detected corners, the output of #findChessboardCorners.
        /// </param>
        /// <param name="patternWasFound">
        /// Parameter indicating whether the complete board was found or not. The
        ///  return value of #findChessboardCorners should be passed here.
        /// </param>
        /// <remarks>
        ///  The function draws individual chessboard corners detected either as red circles if the board was not
        ///  found, or as colored corners connected with lines if the board was found.
        /// </remarks>
        public static void drawChessboardCorners(Mat image, Size patternSize, MatOfPoint2f corners, bool patternWasFound)
        {
            if (image != null) image.ThrowIfDisposed();
            if (corners != null) corners.ThrowIfDisposed();
            Mat corners_mat = corners;
            calib3d_Calib3d_drawChessboardCorners_10(image.nativeObj, patternSize.width, patternSize.height, corners_mat.nativeObj, patternWasFound);


        }


        //
        // C++:  void cv::drawFrameAxes(Mat& image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness = 3)
        //

        /// <summary>
        ///  Draw axes of the world/object coordinate system from pose estimation. @sa solvePnP
        /// </summary>
        /// <param name="image">
        /// Input/output image. It must have 1 or 3 channels. The number of channels is not altered.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input 3x3 floating-point matrix of camera intrinsic parameters.
        ///  \f$\cameramatrix{A}\f$
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="rvec">
        /// Rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Translation vector.
        /// </param>
        /// <param name="length">
        /// Length of the painted axes in the same unit than tvec (usually in meters).
        /// </param>
        /// <param name="thickness">
        /// Line thickness of the painted axes.
        /// </param>
        /// <remarks>
        ///  This function draws the axes of the world/object coordinate system w.r.t. to the camera frame.
        ///  OX is drawn in red, OY in green and OZ in blue.
        /// </remarks>
        public static void drawFrameAxes(Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness)
        {
            if (image != null) image.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_drawFrameAxes_10(image.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, length, thickness);


        }

        /// <summary>
        ///  Draw axes of the world/object coordinate system from pose estimation. @sa solvePnP
        /// </summary>
        /// <param name="image">
        /// Input/output image. It must have 1 or 3 channels. The number of channels is not altered.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input 3x3 floating-point matrix of camera intrinsic parameters.
        ///  \f$\cameramatrix{A}\f$
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="rvec">
        /// Rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///  the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Translation vector.
        /// </param>
        /// <param name="length">
        /// Length of the painted axes in the same unit than tvec (usually in meters).
        /// </param>
        /// <param name="thickness">
        /// Line thickness of the painted axes.
        /// </param>
        /// <remarks>
        ///  This function draws the axes of the world/object coordinate system w.r.t. to the camera frame.
        ///  OX is drawn in red, OY in green and OZ in blue.
        /// </remarks>
        public static void drawFrameAxes(Mat image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length)
        {
            if (image != null) image.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            calib3d_Calib3d_drawFrameAxes_11(image.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, length);


        }


        //
        // C++:  bool cv::findCirclesGrid(Mat image, Size patternSize, Mat& centers, int flags, Ptr_FeatureDetector blobDetector, CirclesGridFinderParameters parameters)
        //

        // Unknown type 'Ptr_FeatureDetector' (I), skipping the function


        //
        // C++:  bool cv::findCirclesGrid(Mat image, Size patternSize, Mat& centers, int flags = CALIB_CB_SYMMETRIC_GRID, Ptr_FeatureDetector blobDetector = SimpleBlobDetector::create())
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static bool findCirclesGrid(Mat image, Size patternSize, Mat centers, int flags)
        {
            if (image != null) image.ThrowIfDisposed();
            if (centers != null) centers.ThrowIfDisposed();

            return calib3d_Calib3d_findCirclesGrid_10(image.nativeObj, patternSize.width, patternSize.height, centers.nativeObj, flags);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static bool findCirclesGrid(Mat image, Size patternSize, Mat centers)
        {
            if (image != null) image.ThrowIfDisposed();
            if (centers != null) centers.ThrowIfDisposed();

            return calib3d_Calib3d_findCirclesGrid_12(image.nativeObj, patternSize.width, patternSize.height, centers.nativeObj);


        }


        //
        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        /// <summary>
        ///  Finds the camera intrinsic and extrinsic parameters from several views of a calibration
        ///  pattern.
        /// </summary>
        /// <param name="objectPoints">
        /// In the new interface it is a vector of vectors of calibration pattern points in
        ///  the calibration pattern coordinate space (e.g. std::vector&lt;std::vector&lt;cv::Vec3f&gt;&gt;). The outer
        ///  vector contains as many elements as the number of pattern views. If the same calibration pattern
        ///  is shown in each view and it is fully visible, all the vectors will be the same. Although, it is
        ///  possible to use partially occluded patterns or even different patterns in different views. Then,
        ///  the vectors will be different. Although the points are 3D, they all lie in the calibration pattern's
        ///  XY coordinate plane (thus 0 in the Z-coordinate), if the used calibration pattern is a planar rig.
        ///  In the old interface all the vectors of object points from different views are concatenated
        ///  together.
        /// </param>
        /// <param name="imagePoints">
        /// In the new interface it is a vector of vectors of the projections of calibration
        ///  pattern points (e.g. std::vector&lt;std::vector&lt;cv::Vec2f&gt;&gt;). imagePoints.size() and
        ///  objectPoints.size(), and imagePoints[i].size() and objectPoints[i].size() for each i, must be equal,
        ///  respectively. In the old interface all the vectors of object points from different views are
        ///  concatenated together.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the camera intrinsic matrix.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input/output 3x3 floating-point camera intrinsic matrix
        ///  \f$\cameramatrix{A}\f$ . If @ref CALIB_USE_INTRINSIC_GUESS
        ///  and/or @ref CALIB_FIX_ASPECT_RATIO, @ref CALIB_FIX_PRINCIPAL_POINT or @ref CALIB_FIX_FOCAL_LENGTH
        ///  are specified, some or all of fx, fy, cx, cy must be initialized before calling the function.
        /// </param>
        /// <param name="distCoeffs">
        /// Input/output vector of distortion coefficients
        ///  \f$\distcoeffs\f$.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors (@ref Rodrigues ) estimated for each pattern view
        ///  (e.g. std::vector&lt;cv::Mat&gt;&gt;). That is, each i-th rotation vector together with the corresponding
        ///  i-th translation vector (see the next output parameter description) brings the calibration pattern
        ///  from the object coordinate space (in which object points are specified) to the camera coordinate
        ///  space. In more technical terms, the tuple of the i-th rotation and translation vector performs
        ///  a change of basis from object coordinate space to camera coordinate space. Due to its duality, this
        ///  tuple is equivalent to the position of the calibration pattern with respect to the camera coordinate
        ///  space.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter
        ///  describtion above.
        /// </param>
        /// <param name="stdDeviationsIntrinsics">
        /// Output vector of standard deviations estimated for intrinsic
        ///  parameters. Order of deviations values:
        ///  \f$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
        ///   s_4, \tau_x, \tau_y)\f$ If one of parameters is not estimated, it's deviation is equals to zero.
        /// </param>
        /// <param name="stdDeviationsExtrinsics">
        /// Output vector of standard deviations estimated for extrinsic
        ///  parameters. Order of deviations values: \f$(R_0, T_0, \dotsc , R_{M - 1}, T_{M - 1})\f$ where M is
        ///  the number of pattern views. \f$R_i, T_i\f$ are concatenated 1x3 vectors.
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///  -   @ref CALIB_USE_INTRINSIC_GUESS cameraMatrix contains valid initial values of
        ///  fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///  center ( imageSize is used), and focal distances are computed in a least-squares fashion.
        ///  Note, that if intrinsic parameters are known, there is no need to use this function just to
        ///  estimate extrinsic parameters. Use @ref solvePnP instead.
        ///  -   @ref CALIB_FIX_PRINCIPAL_POINT The principal point is not changed during the global
        ///  optimization. It stays at the center or at a different location specified when
        ///   @ref CALIB_USE_INTRINSIC_GUESS is set too.
        ///  -   @ref CALIB_FIX_ASPECT_RATIO The functions consider only fy as a free parameter. The
        ///  ratio fx/fy stays the same as in the input cameraMatrix . When
        ///   @ref CALIB_USE_INTRINSIC_GUESS is not set, the actual input values of fx and fy are
        ///  ignored, only their ratio is computed and used further.
        ///  -   @ref CALIB_ZERO_TANGENT_DIST Tangential distortion coefficients \f$(p_1, p_2)\f$ are set
        ///  to zeros and stay zero.
        ///  -   @ref CALIB_FIX_FOCAL_LENGTH The focal length is not changed during the global optimization if
        ///   @ref CALIB_USE_INTRINSIC_GUESS is set.
        ///  -   @ref CALIB_FIX_K1,..., @ref CALIB_FIX_K6 The corresponding radial distortion
        ///  coefficient is not changed during the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is
        ///  set, the coefficient from the supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_RATIONAL_MODEL Coefficients k4, k5, and k6 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the rational model and return 8 coefficients or more.
        ///  -   @ref CALIB_THIN_PRISM_MODEL Coefficients s1, s2, s3 and s4 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the thin prism model and return 12 coefficients or more.
        ///  -   @ref CALIB_FIX_S1_S2_S3_S4 The thin prism distortion coefficients are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_TILTED_MODEL Coefficients tauX and tauY are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the tilted sensor model and return 14 coefficients.
        ///  -   @ref CALIB_FIX_TAUX_TAUY The coefficients of the tilted sensor model are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <returns>
        ///  the overall RMS re-projection error.
        /// </returns>
        /// <remarks>
        ///  The function estimates the intrinsic camera parameters and extrinsic parameters for each of the
        ///  views. The algorithm is based on @cite Zhang2000 and @cite BouguetMCT . The coordinates of 3D object
        ///  points and their corresponding 2D projections in each view must be specified. That may be achieved
        ///  by using an object with known geometry and easily detectable feature points. Such an object is
        ///  called a calibration rig or calibration pattern, and OpenCV has built-in support for a chessboard as
        ///  a calibration rig (see @ref findChessboardCorners). Currently, initialization of intrinsic
        ///  parameters (when @ref CALIB_USE_INTRINSIC_GUESS is not set) is only implemented for planar calibration
        ///  patterns (where Z-coordinates of the object points must be all zeros). 3D calibration rigs can also
        ///  be used as long as initial cameraMatrix is provided.
        ///  
        ///  The algorithm performs the following steps:
        ///  
        ///  -   Compute the initial intrinsic parameters (the option only available for planar calibration
        ///      patterns) or read them from the input parameters. The distortion coefficients are all set to
        ///      zeros initially unless some of CALIB_FIX_K? are specified.
        ///  
        ///  -   Estimate the initial camera pose as if the intrinsic parameters have been already known. This is
        ///      done using @ref solvePnP .
        ///  
        ///  -   Run the global Levenberg-Marquardt optimization algorithm to minimize the reprojection error,
        ///      that is, the total sum of squared distances between the observed feature points imagePoints and
        ///      the projected (using the current estimates for camera parameters and the poses) object points
        ///      objectPoints. See @ref projectPoints for details.
        ///  
        ///  @note
        ///      If you use a non-square (i.e. non-N-by-N) grid and @ref findChessboardCorners for calibration,
        ///      and @ref calibrateCamera returns bad values (zero distortion coefficients, \f$c_x\f$ and
        ///      \f$c_y\f$ very far from the image center, and/or large differences between \f$f_x\f$ and
        ///      \f$f_y\f$ (ratios of 10:1 or more)), then you are probably using patternSize=cvSize(rows,cols)
        ///      instead of using patternSize=cvSize(cols,rows) in @ref findChessboardCorners.
        ///  
        ///  @note
        ///      The function may throw exceptions, if unsupported combination of parameters is provided or
        ///      the system is underconstrained.
        ///  
        ///  @sa
        ///     calibrateCameraRO, findChessboardCorners, solvePnP, initCameraMatrix2D, stereoCalibrate,
        ///     undistort
        /// </remarks>
        public static double calibrateCameraExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraExtended_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds the camera intrinsic and extrinsic parameters from several views of a calibration
        ///  pattern.
        /// </summary>
        /// <param name="objectPoints">
        /// In the new interface it is a vector of vectors of calibration pattern points in
        ///  the calibration pattern coordinate space (e.g. std::vector&lt;std::vector&lt;cv::Vec3f&gt;&gt;). The outer
        ///  vector contains as many elements as the number of pattern views. If the same calibration pattern
        ///  is shown in each view and it is fully visible, all the vectors will be the same. Although, it is
        ///  possible to use partially occluded patterns or even different patterns in different views. Then,
        ///  the vectors will be different. Although the points are 3D, they all lie in the calibration pattern's
        ///  XY coordinate plane (thus 0 in the Z-coordinate), if the used calibration pattern is a planar rig.
        ///  In the old interface all the vectors of object points from different views are concatenated
        ///  together.
        /// </param>
        /// <param name="imagePoints">
        /// In the new interface it is a vector of vectors of the projections of calibration
        ///  pattern points (e.g. std::vector&lt;std::vector&lt;cv::Vec2f&gt;&gt;). imagePoints.size() and
        ///  objectPoints.size(), and imagePoints[i].size() and objectPoints[i].size() for each i, must be equal,
        ///  respectively. In the old interface all the vectors of object points from different views are
        ///  concatenated together.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the camera intrinsic matrix.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input/output 3x3 floating-point camera intrinsic matrix
        ///  \f$\cameramatrix{A}\f$ . If @ref CALIB_USE_INTRINSIC_GUESS
        ///  and/or @ref CALIB_FIX_ASPECT_RATIO, @ref CALIB_FIX_PRINCIPAL_POINT or @ref CALIB_FIX_FOCAL_LENGTH
        ///  are specified, some or all of fx, fy, cx, cy must be initialized before calling the function.
        /// </param>
        /// <param name="distCoeffs">
        /// Input/output vector of distortion coefficients
        ///  \f$\distcoeffs\f$.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors (@ref Rodrigues ) estimated for each pattern view
        ///  (e.g. std::vector&lt;cv::Mat&gt;&gt;). That is, each i-th rotation vector together with the corresponding
        ///  i-th translation vector (see the next output parameter description) brings the calibration pattern
        ///  from the object coordinate space (in which object points are specified) to the camera coordinate
        ///  space. In more technical terms, the tuple of the i-th rotation and translation vector performs
        ///  a change of basis from object coordinate space to camera coordinate space. Due to its duality, this
        ///  tuple is equivalent to the position of the calibration pattern with respect to the camera coordinate
        ///  space.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter
        ///  describtion above.
        /// </param>
        /// <param name="stdDeviationsIntrinsics">
        /// Output vector of standard deviations estimated for intrinsic
        ///  parameters. Order of deviations values:
        ///  \f$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
        ///   s_4, \tau_x, \tau_y)\f$ If one of parameters is not estimated, it's deviation is equals to zero.
        /// </param>
        /// <param name="stdDeviationsExtrinsics">
        /// Output vector of standard deviations estimated for extrinsic
        ///  parameters. Order of deviations values: \f$(R_0, T_0, \dotsc , R_{M - 1}, T_{M - 1})\f$ where M is
        ///  the number of pattern views. \f$R_i, T_i\f$ are concatenated 1x3 vectors.
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///  -   @ref CALIB_USE_INTRINSIC_GUESS cameraMatrix contains valid initial values of
        ///  fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///  center ( imageSize is used), and focal distances are computed in a least-squares fashion.
        ///  Note, that if intrinsic parameters are known, there is no need to use this function just to
        ///  estimate extrinsic parameters. Use @ref solvePnP instead.
        ///  -   @ref CALIB_FIX_PRINCIPAL_POINT The principal point is not changed during the global
        ///  optimization. It stays at the center or at a different location specified when
        ///   @ref CALIB_USE_INTRINSIC_GUESS is set too.
        ///  -   @ref CALIB_FIX_ASPECT_RATIO The functions consider only fy as a free parameter. The
        ///  ratio fx/fy stays the same as in the input cameraMatrix . When
        ///   @ref CALIB_USE_INTRINSIC_GUESS is not set, the actual input values of fx and fy are
        ///  ignored, only their ratio is computed and used further.
        ///  -   @ref CALIB_ZERO_TANGENT_DIST Tangential distortion coefficients \f$(p_1, p_2)\f$ are set
        ///  to zeros and stay zero.
        ///  -   @ref CALIB_FIX_FOCAL_LENGTH The focal length is not changed during the global optimization if
        ///   @ref CALIB_USE_INTRINSIC_GUESS is set.
        ///  -   @ref CALIB_FIX_K1,..., @ref CALIB_FIX_K6 The corresponding radial distortion
        ///  coefficient is not changed during the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is
        ///  set, the coefficient from the supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_RATIONAL_MODEL Coefficients k4, k5, and k6 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the rational model and return 8 coefficients or more.
        ///  -   @ref CALIB_THIN_PRISM_MODEL Coefficients s1, s2, s3 and s4 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the thin prism model and return 12 coefficients or more.
        ///  -   @ref CALIB_FIX_S1_S2_S3_S4 The thin prism distortion coefficients are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_TILTED_MODEL Coefficients tauX and tauY are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the tilted sensor model and return 14 coefficients.
        ///  -   @ref CALIB_FIX_TAUX_TAUY The coefficients of the tilted sensor model are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <returns>
        ///  the overall RMS re-projection error.
        /// </returns>
        /// <remarks>
        ///  The function estimates the intrinsic camera parameters and extrinsic parameters for each of the
        ///  views. The algorithm is based on @cite Zhang2000 and @cite BouguetMCT . The coordinates of 3D object
        ///  points and their corresponding 2D projections in each view must be specified. That may be achieved
        ///  by using an object with known geometry and easily detectable feature points. Such an object is
        ///  called a calibration rig or calibration pattern, and OpenCV has built-in support for a chessboard as
        ///  a calibration rig (see @ref findChessboardCorners). Currently, initialization of intrinsic
        ///  parameters (when @ref CALIB_USE_INTRINSIC_GUESS is not set) is only implemented for planar calibration
        ///  patterns (where Z-coordinates of the object points must be all zeros). 3D calibration rigs can also
        ///  be used as long as initial cameraMatrix is provided.
        ///  
        ///  The algorithm performs the following steps:
        ///  
        ///  -   Compute the initial intrinsic parameters (the option only available for planar calibration
        ///      patterns) or read them from the input parameters. The distortion coefficients are all set to
        ///      zeros initially unless some of CALIB_FIX_K? are specified.
        ///  
        ///  -   Estimate the initial camera pose as if the intrinsic parameters have been already known. This is
        ///      done using @ref solvePnP .
        ///  
        ///  -   Run the global Levenberg-Marquardt optimization algorithm to minimize the reprojection error,
        ///      that is, the total sum of squared distances between the observed feature points imagePoints and
        ///      the projected (using the current estimates for camera parameters and the poses) object points
        ///      objectPoints. See @ref projectPoints for details.
        ///  
        ///  @note
        ///      If you use a non-square (i.e. non-N-by-N) grid and @ref findChessboardCorners for calibration,
        ///      and @ref calibrateCamera returns bad values (zero distortion coefficients, \f$c_x\f$ and
        ///      \f$c_y\f$ very far from the image center, and/or large differences between \f$f_x\f$ and
        ///      \f$f_y\f$ (ratios of 10:1 or more)), then you are probably using patternSize=cvSize(rows,cols)
        ///      instead of using patternSize=cvSize(cols,rows) in @ref findChessboardCorners.
        ///  
        ///  @note
        ///      The function may throw exceptions, if unsupported combination of parameters is provided or
        ///      the system is underconstrained.
        ///  
        ///  @sa
        ///     calibrateCameraRO, findChessboardCorners, solvePnP, initCameraMatrix2D, stereoCalibrate,
        ///     undistort
        /// </remarks>
        public static double calibrateCameraExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraExtended_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds the camera intrinsic and extrinsic parameters from several views of a calibration
        ///  pattern.
        /// </summary>
        /// <param name="objectPoints">
        /// In the new interface it is a vector of vectors of calibration pattern points in
        ///  the calibration pattern coordinate space (e.g. std::vector&lt;std::vector&lt;cv::Vec3f&gt;&gt;). The outer
        ///  vector contains as many elements as the number of pattern views. If the same calibration pattern
        ///  is shown in each view and it is fully visible, all the vectors will be the same. Although, it is
        ///  possible to use partially occluded patterns or even different patterns in different views. Then,
        ///  the vectors will be different. Although the points are 3D, they all lie in the calibration pattern's
        ///  XY coordinate plane (thus 0 in the Z-coordinate), if the used calibration pattern is a planar rig.
        ///  In the old interface all the vectors of object points from different views are concatenated
        ///  together.
        /// </param>
        /// <param name="imagePoints">
        /// In the new interface it is a vector of vectors of the projections of calibration
        ///  pattern points (e.g. std::vector&lt;std::vector&lt;cv::Vec2f&gt;&gt;). imagePoints.size() and
        ///  objectPoints.size(), and imagePoints[i].size() and objectPoints[i].size() for each i, must be equal,
        ///  respectively. In the old interface all the vectors of object points from different views are
        ///  concatenated together.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the camera intrinsic matrix.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input/output 3x3 floating-point camera intrinsic matrix
        ///  \f$\cameramatrix{A}\f$ . If @ref CALIB_USE_INTRINSIC_GUESS
        ///  and/or @ref CALIB_FIX_ASPECT_RATIO, @ref CALIB_FIX_PRINCIPAL_POINT or @ref CALIB_FIX_FOCAL_LENGTH
        ///  are specified, some or all of fx, fy, cx, cy must be initialized before calling the function.
        /// </param>
        /// <param name="distCoeffs">
        /// Input/output vector of distortion coefficients
        ///  \f$\distcoeffs\f$.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors (@ref Rodrigues ) estimated for each pattern view
        ///  (e.g. std::vector&lt;cv::Mat&gt;&gt;). That is, each i-th rotation vector together with the corresponding
        ///  i-th translation vector (see the next output parameter description) brings the calibration pattern
        ///  from the object coordinate space (in which object points are specified) to the camera coordinate
        ///  space. In more technical terms, the tuple of the i-th rotation and translation vector performs
        ///  a change of basis from object coordinate space to camera coordinate space. Due to its duality, this
        ///  tuple is equivalent to the position of the calibration pattern with respect to the camera coordinate
        ///  space.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter
        ///  describtion above.
        /// </param>
        /// <param name="stdDeviationsIntrinsics">
        /// Output vector of standard deviations estimated for intrinsic
        ///  parameters. Order of deviations values:
        ///  \f$(f_x, f_y, c_x, c_y, k_1, k_2, p_1, p_2, k_3, k_4, k_5, k_6 , s_1, s_2, s_3,
        ///   s_4, \tau_x, \tau_y)\f$ If one of parameters is not estimated, it's deviation is equals to zero.
        /// </param>
        /// <param name="stdDeviationsExtrinsics">
        /// Output vector of standard deviations estimated for extrinsic
        ///  parameters. Order of deviations values: \f$(R_0, T_0, \dotsc , R_{M - 1}, T_{M - 1})\f$ where M is
        ///  the number of pattern views. \f$R_i, T_i\f$ are concatenated 1x3 vectors.
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///  -   @ref CALIB_USE_INTRINSIC_GUESS cameraMatrix contains valid initial values of
        ///  fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///  center ( imageSize is used), and focal distances are computed in a least-squares fashion.
        ///  Note, that if intrinsic parameters are known, there is no need to use this function just to
        ///  estimate extrinsic parameters. Use @ref solvePnP instead.
        ///  -   @ref CALIB_FIX_PRINCIPAL_POINT The principal point is not changed during the global
        ///  optimization. It stays at the center or at a different location specified when
        ///   @ref CALIB_USE_INTRINSIC_GUESS is set too.
        ///  -   @ref CALIB_FIX_ASPECT_RATIO The functions consider only fy as a free parameter. The
        ///  ratio fx/fy stays the same as in the input cameraMatrix . When
        ///   @ref CALIB_USE_INTRINSIC_GUESS is not set, the actual input values of fx and fy are
        ///  ignored, only their ratio is computed and used further.
        ///  -   @ref CALIB_ZERO_TANGENT_DIST Tangential distortion coefficients \f$(p_1, p_2)\f$ are set
        ///  to zeros and stay zero.
        ///  -   @ref CALIB_FIX_FOCAL_LENGTH The focal length is not changed during the global optimization if
        ///   @ref CALIB_USE_INTRINSIC_GUESS is set.
        ///  -   @ref CALIB_FIX_K1,..., @ref CALIB_FIX_K6 The corresponding radial distortion
        ///  coefficient is not changed during the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is
        ///  set, the coefficient from the supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_RATIONAL_MODEL Coefficients k4, k5, and k6 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the rational model and return 8 coefficients or more.
        ///  -   @ref CALIB_THIN_PRISM_MODEL Coefficients s1, s2, s3 and s4 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the thin prism model and return 12 coefficients or more.
        ///  -   @ref CALIB_FIX_S1_S2_S3_S4 The thin prism distortion coefficients are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_TILTED_MODEL Coefficients tauX and tauY are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the tilted sensor model and return 14 coefficients.
        ///  -   @ref CALIB_FIX_TAUX_TAUY The coefficients of the tilted sensor model are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <returns>
        ///  the overall RMS re-projection error.
        /// </returns>
        /// <remarks>
        ///  The function estimates the intrinsic camera parameters and extrinsic parameters for each of the
        ///  views. The algorithm is based on @cite Zhang2000 and @cite BouguetMCT . The coordinates of 3D object
        ///  points and their corresponding 2D projections in each view must be specified. That may be achieved
        ///  by using an object with known geometry and easily detectable feature points. Such an object is
        ///  called a calibration rig or calibration pattern, and OpenCV has built-in support for a chessboard as
        ///  a calibration rig (see @ref findChessboardCorners). Currently, initialization of intrinsic
        ///  parameters (when @ref CALIB_USE_INTRINSIC_GUESS is not set) is only implemented for planar calibration
        ///  patterns (where Z-coordinates of the object points must be all zeros). 3D calibration rigs can also
        ///  be used as long as initial cameraMatrix is provided.
        ///  
        ///  The algorithm performs the following steps:
        ///  
        ///  -   Compute the initial intrinsic parameters (the option only available for planar calibration
        ///      patterns) or read them from the input parameters. The distortion coefficients are all set to
        ///      zeros initially unless some of CALIB_FIX_K? are specified.
        ///  
        ///  -   Estimate the initial camera pose as if the intrinsic parameters have been already known. This is
        ///      done using @ref solvePnP .
        ///  
        ///  -   Run the global Levenberg-Marquardt optimization algorithm to minimize the reprojection error,
        ///      that is, the total sum of squared distances between the observed feature points imagePoints and
        ///      the projected (using the current estimates for camera parameters and the poses) object points
        ///      objectPoints. See @ref projectPoints for details.
        ///  
        ///  @note
        ///      If you use a non-square (i.e. non-N-by-N) grid and @ref findChessboardCorners for calibration,
        ///      and @ref calibrateCamera returns bad values (zero distortion coefficients, \f$c_x\f$ and
        ///      \f$c_y\f$ very far from the image center, and/or large differences between \f$f_x\f$ and
        ///      \f$f_y\f$ (ratios of 10:1 or more)), then you are probably using patternSize=cvSize(rows,cols)
        ///      instead of using patternSize=cvSize(cols,rows) in @ref findChessboardCorners.
        ///  
        ///  @note
        ///      The function may throw exceptions, if unsupported combination of parameters is provided or
        ///      the system is underconstrained.
        ///  
        ///  @sa
        ///     calibrateCameraRO, findChessboardCorners, solvePnP, initCameraMatrix2D, stereoCalibrate,
        ///     undistort
        /// </remarks>
        public static double calibrateCameraExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat perViewErrors)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraExtended_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, perViewErrors.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static double calibrateCamera(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCamera_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static double calibrateCamera(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCamera_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static double calibrateCamera(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCamera_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& stdDeviationsObjPoints, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        /// <summary>
        ///  Finds the camera intrinsic and extrinsic parameters from several views of a calibration pattern.
        /// </summary>
        /// <remarks>
        ///  This function is an extension of #calibrateCamera with the method of releasing object which was
        ///  proposed in @cite strobl2011iccv. In many common cases with inaccurate, unmeasured, roughly planar
        ///  targets (calibration plates), this method can dramatically improve the precision of the estimated
        ///  camera parameters. Both the object-releasing method and standard method are supported by this
        ///  function. Use the parameter **iFixedPoint** for method selection. In the internal implementation,
        ///  #calibrateCamera is a wrapper for this function.
        /// </remarks>
        /// <param name="objectPoints">
        /// Vector of vectors of calibration pattern points in the calibration pattern
        ///  coordinate space. See #calibrateCamera for details. If the method of releasing object to be used,
        ///  the identical calibration board must be used in each view and it must be fully visible, and all
        ///  objectPoints[i] must be the same and all points should be roughly close to a plane. **The calibration
        ///  target has to be rigid, or at least static if the camera (rather than the calibration target) is
        ///  shifted for grabbing images.**
        /// </param>
        /// <param name="imagePoints">
        /// Vector of vectors of the projections of calibration pattern points. See
        ///  #calibrateCamera for details.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the intrinsic camera matrix.
        /// </param>
        /// <param name="iFixedPoint">
        /// The index of the 3D object point in objectPoints[0] to be fixed. It also acts as
        ///  a switch for calibration method selection. If object-releasing method to be used, pass in the
        ///  parameter in the range of [1, objectPoints[0].size()-2], otherwise a value out of this range will
        ///  make standard calibration method selected. Usually the top-right corner point of the calibration
        ///  board grid is recommended to be fixed when object-releasing method being utilized. According to
        ///  \cite strobl2011iccv, two other points are also fixed. In this implementation, objectPoints[0].front
        ///  and objectPoints[0].back.z are used. With object-releasing method, accurate rvecs, tvecs and
        ///  newObjPoints are only possible if coordinates of these three fixed points are accurate enough.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 floating-point camera matrix. See #calibrateCamera for details.
        /// </param>
        /// <param name="distCoeffs">
        /// Output vector of distortion coefficients. See #calibrateCamera for details.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors estimated for each pattern view. See #calibrateCamera
        ///  for details.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view.
        /// </param>
        /// <param name="newObjPoints">
        /// The updated output vector of calibration pattern points. The coordinates might
        ///  be scaled based on three fixed points. The returned coordinates are accurate only if the above
        ///  mentioned three fixed points are accurate. If not needed, noArray() can be passed in. This parameter
        ///  is ignored with standard calibration method.
        /// </param>
        /// <param name="stdDeviationsIntrinsics">
        /// Output vector of standard deviations estimated for intrinsic parameters.
        ///  See #calibrateCamera for details.
        /// </param>
        /// <param name="stdDeviationsExtrinsics">
        /// Output vector of standard deviations estimated for extrinsic parameters.
        ///  See #calibrateCamera for details.
        /// </param>
        /// <param name="stdDeviationsObjPoints">
        /// Output vector of standard deviations estimated for refined coordinates
        ///  of calibration pattern points. It has the same size and order as objectPoints[0] vector. This
        ///  parameter is ignored with standard calibration method.
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of some predefined values. See
        ///  #calibrateCamera for details. If the method of releasing object is used, the calibration time may
        ///  be much longer. CALIB_USE_QR or CALIB_USE_LU could be used for faster calibration with potentially
        ///  less precise and less stable in some rare cases.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <returns>
        ///  the overall RMS re-projection error.
        /// </returns>
        /// <remarks>
        ///  The function estimates the intrinsic camera parameters and extrinsic parameters for each of the
        ///  views. The algorithm is based on @cite Zhang2000, @cite BouguetMCT and @cite strobl2011iccv. See
        ///  #calibrateCamera for other detailed explanations.
        ///  @sa
        ///     calibrateCamera, findChessboardCorners, solvePnP, initCameraMatrix2D, stereoCalibrate, undistort
        /// </remarks>
        public static double calibrateCameraROExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (stdDeviationsObjPoints != null) stdDeviationsObjPoints.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraROExtended_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, stdDeviationsObjPoints.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds the camera intrinsic and extrinsic parameters from several views of a calibration pattern.
        /// </summary>
        /// <remarks>
        ///  This function is an extension of #calibrateCamera with the method of releasing object which was
        ///  proposed in @cite strobl2011iccv. In many common cases with inaccurate, unmeasured, roughly planar
        ///  targets (calibration plates), this method can dramatically improve the precision of the estimated
        ///  camera parameters. Both the object-releasing method and standard method are supported by this
        ///  function. Use the parameter **iFixedPoint** for method selection. In the internal implementation,
        ///  #calibrateCamera is a wrapper for this function.
        /// </remarks>
        /// <param name="objectPoints">
        /// Vector of vectors of calibration pattern points in the calibration pattern
        ///  coordinate space. See #calibrateCamera for details. If the method of releasing object to be used,
        ///  the identical calibration board must be used in each view and it must be fully visible, and all
        ///  objectPoints[i] must be the same and all points should be roughly close to a plane. **The calibration
        ///  target has to be rigid, or at least static if the camera (rather than the calibration target) is
        ///  shifted for grabbing images.**
        /// </param>
        /// <param name="imagePoints">
        /// Vector of vectors of the projections of calibration pattern points. See
        ///  #calibrateCamera for details.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the intrinsic camera matrix.
        /// </param>
        /// <param name="iFixedPoint">
        /// The index of the 3D object point in objectPoints[0] to be fixed. It also acts as
        ///  a switch for calibration method selection. If object-releasing method to be used, pass in the
        ///  parameter in the range of [1, objectPoints[0].size()-2], otherwise a value out of this range will
        ///  make standard calibration method selected. Usually the top-right corner point of the calibration
        ///  board grid is recommended to be fixed when object-releasing method being utilized. According to
        ///  \cite strobl2011iccv, two other points are also fixed. In this implementation, objectPoints[0].front
        ///  and objectPoints[0].back.z are used. With object-releasing method, accurate rvecs, tvecs and
        ///  newObjPoints are only possible if coordinates of these three fixed points are accurate enough.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 floating-point camera matrix. See #calibrateCamera for details.
        /// </param>
        /// <param name="distCoeffs">
        /// Output vector of distortion coefficients. See #calibrateCamera for details.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors estimated for each pattern view. See #calibrateCamera
        ///  for details.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view.
        /// </param>
        /// <param name="newObjPoints">
        /// The updated output vector of calibration pattern points. The coordinates might
        ///  be scaled based on three fixed points. The returned coordinates are accurate only if the above
        ///  mentioned three fixed points are accurate. If not needed, noArray() can be passed in. This parameter
        ///  is ignored with standard calibration method.
        /// </param>
        /// <param name="stdDeviationsIntrinsics">
        /// Output vector of standard deviations estimated for intrinsic parameters.
        ///  See #calibrateCamera for details.
        /// </param>
        /// <param name="stdDeviationsExtrinsics">
        /// Output vector of standard deviations estimated for extrinsic parameters.
        ///  See #calibrateCamera for details.
        /// </param>
        /// <param name="stdDeviationsObjPoints">
        /// Output vector of standard deviations estimated for refined coordinates
        ///  of calibration pattern points. It has the same size and order as objectPoints[0] vector. This
        ///  parameter is ignored with standard calibration method.
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of some predefined values. See
        ///  #calibrateCamera for details. If the method of releasing object is used, the calibration time may
        ///  be much longer. CALIB_USE_QR or CALIB_USE_LU could be used for faster calibration with potentially
        ///  less precise and less stable in some rare cases.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <returns>
        ///  the overall RMS re-projection error.
        /// </returns>
        /// <remarks>
        ///  The function estimates the intrinsic camera parameters and extrinsic parameters for each of the
        ///  views. The algorithm is based on @cite Zhang2000, @cite BouguetMCT and @cite strobl2011iccv. See
        ///  #calibrateCamera for other detailed explanations.
        ///  @sa
        ///     calibrateCamera, findChessboardCorners, solvePnP, initCameraMatrix2D, stereoCalibrate, undistort
        /// </remarks>
        public static double calibrateCameraROExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (stdDeviationsObjPoints != null) stdDeviationsObjPoints.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraROExtended_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, stdDeviationsObjPoints.nativeObj, perViewErrors.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Finds the camera intrinsic and extrinsic parameters from several views of a calibration pattern.
        /// </summary>
        /// <remarks>
        ///  This function is an extension of #calibrateCamera with the method of releasing object which was
        ///  proposed in @cite strobl2011iccv. In many common cases with inaccurate, unmeasured, roughly planar
        ///  targets (calibration plates), this method can dramatically improve the precision of the estimated
        ///  camera parameters. Both the object-releasing method and standard method are supported by this
        ///  function. Use the parameter **iFixedPoint** for method selection. In the internal implementation,
        ///  #calibrateCamera is a wrapper for this function.
        /// </remarks>
        /// <param name="objectPoints">
        /// Vector of vectors of calibration pattern points in the calibration pattern
        ///  coordinate space. See #calibrateCamera for details. If the method of releasing object to be used,
        ///  the identical calibration board must be used in each view and it must be fully visible, and all
        ///  objectPoints[i] must be the same and all points should be roughly close to a plane. **The calibration
        ///  target has to be rigid, or at least static if the camera (rather than the calibration target) is
        ///  shifted for grabbing images.**
        /// </param>
        /// <param name="imagePoints">
        /// Vector of vectors of the projections of calibration pattern points. See
        ///  #calibrateCamera for details.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the intrinsic camera matrix.
        /// </param>
        /// <param name="iFixedPoint">
        /// The index of the 3D object point in objectPoints[0] to be fixed. It also acts as
        ///  a switch for calibration method selection. If object-releasing method to be used, pass in the
        ///  parameter in the range of [1, objectPoints[0].size()-2], otherwise a value out of this range will
        ///  make standard calibration method selected. Usually the top-right corner point of the calibration
        ///  board grid is recommended to be fixed when object-releasing method being utilized. According to
        ///  \cite strobl2011iccv, two other points are also fixed. In this implementation, objectPoints[0].front
        ///  and objectPoints[0].back.z are used. With object-releasing method, accurate rvecs, tvecs and
        ///  newObjPoints are only possible if coordinates of these three fixed points are accurate enough.
        /// </param>
        /// <param name="cameraMatrix">
        /// Output 3x3 floating-point camera matrix. See #calibrateCamera for details.
        /// </param>
        /// <param name="distCoeffs">
        /// Output vector of distortion coefficients. See #calibrateCamera for details.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors estimated for each pattern view. See #calibrateCamera
        ///  for details.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view.
        /// </param>
        /// <param name="newObjPoints">
        /// The updated output vector of calibration pattern points. The coordinates might
        ///  be scaled based on three fixed points. The returned coordinates are accurate only if the above
        ///  mentioned three fixed points are accurate. If not needed, noArray() can be passed in. This parameter
        ///  is ignored with standard calibration method.
        /// </param>
        /// <param name="stdDeviationsIntrinsics">
        /// Output vector of standard deviations estimated for intrinsic parameters.
        ///  See #calibrateCamera for details.
        /// </param>
        /// <param name="stdDeviationsExtrinsics">
        /// Output vector of standard deviations estimated for extrinsic parameters.
        ///  See #calibrateCamera for details.
        /// </param>
        /// <param name="stdDeviationsObjPoints">
        /// Output vector of standard deviations estimated for refined coordinates
        ///  of calibration pattern points. It has the same size and order as objectPoints[0] vector. This
        ///  parameter is ignored with standard calibration method.
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of some predefined values. See
        ///  #calibrateCamera for details. If the method of releasing object is used, the calibration time may
        ///  be much longer. CALIB_USE_QR or CALIB_USE_LU could be used for faster calibration with potentially
        ///  less precise and less stable in some rare cases.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <returns>
        ///  the overall RMS re-projection error.
        /// </returns>
        /// <remarks>
        ///  The function estimates the intrinsic camera parameters and extrinsic parameters for each of the
        ///  views. The algorithm is based on @cite Zhang2000, @cite BouguetMCT and @cite strobl2011iccv. See
        ///  #calibrateCamera for other detailed explanations.
        ///  @sa
        ///     calibrateCamera, findChessboardCorners, solvePnP, initCameraMatrix2D, stereoCalibrate, undistort
        /// </remarks>
        public static double calibrateCameraROExtended(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, Mat stdDeviationsIntrinsics, Mat stdDeviationsExtrinsics, Mat stdDeviationsObjPoints, Mat perViewErrors)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            if (stdDeviationsIntrinsics != null) stdDeviationsIntrinsics.ThrowIfDisposed();
            if (stdDeviationsExtrinsics != null) stdDeviationsExtrinsics.ThrowIfDisposed();
            if (stdDeviationsObjPoints != null) stdDeviationsObjPoints.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraROExtended_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, stdDeviationsIntrinsics.nativeObj, stdDeviationsExtrinsics.nativeObj, stdDeviationsObjPoints.nativeObj, perViewErrors.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static double calibrateCameraRO(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, int flags, TermCriteria criteria)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraRO_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static double calibrateCameraRO(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints, int flags)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraRO_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static double calibrateCameraRO(List<Mat> objectPoints, List<Mat> imagePoints, Size imageSize, int iFixedPoint, Mat cameraMatrix, Mat distCoeffs, List<Mat> rvecs, List<Mat> tvecs, Mat newObjPoints)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newObjPoints != null) newObjPoints.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_calibrateCameraRO_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, imageSize.width, imageSize.height, iFixedPoint, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, newObjPoints.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  void cv::calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double& fovx, double& fovy, double& focalLength, Point2d& principalPoint, double& aspectRatio)
        //

        /// <summary>
        ///  Computes useful camera characteristics from the camera intrinsic matrix.
        /// </summary>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix that can be estimated by #calibrateCamera or
        ///  #stereoCalibrate .
        /// </param>
        /// <param name="imageSize">
        /// Input image size in pixels.
        /// </param>
        /// <param name="apertureWidth">
        /// Physical width in mm of the sensor.
        /// </param>
        /// <param name="apertureHeight">
        /// Physical height in mm of the sensor.
        /// </param>
        /// <param name="fovx">
        /// Output field of view in degrees along the horizontal sensor axis.
        /// </param>
        /// <param name="fovy">
        /// Output field of view in degrees along the vertical sensor axis.
        /// </param>
        /// <param name="focalLength">
        /// Focal length of the lens in mm.
        /// </param>
        /// <param name="principalPoint">
        /// Principal point in mm.
        /// </param>
        /// <param name="aspectRatio">
        /// \f$f_y/f_x\f$
        /// </param>
        /// <remarks>
        ///  The function computes various useful camera characteristics from the previously estimated camera
        ///  matrix.
        ///  
        ///  @note
        ///     Do keep in mind that the unity measure 'mm' stands for whatever unit of measure one chooses for
        ///      the chessboard pitch (it can thus be any value).
        /// </remarks>
        public static void calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double[] fovx, double[] fovy, double[] focalLength, Point principalPoint, double[] aspectRatio)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            double[] fovx_out = new double[1];
            double[] fovy_out = new double[1];
            double[] focalLength_out = new double[1];
            double[] principalPoint_out = new double[2];
            double[] aspectRatio_out = new double[1];
            calib3d_Calib3d_calibrationMatrixValues_10(cameraMatrix.nativeObj, imageSize.width, imageSize.height, apertureWidth, apertureHeight, fovx_out, fovy_out, focalLength_out, principalPoint_out, aspectRatio_out);
            if (fovx != null) fovx[0] = (double)fovx_out[0];
            if (fovy != null) fovy[0] = (double)fovy_out[0];
            if (focalLength != null) focalLength[0] = (double)focalLength_out[0];
            if (principalPoint != null) { principalPoint.x = principalPoint_out[0]; principalPoint.y = principalPoint_out[1]; }
            if (aspectRatio != null) aspectRatio[0] = (double)aspectRatio_out[0];

        }


        //
        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, vector_Mat& rvecs, vector_Mat& tvecs, Mat& perViewErrors, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        //

        /// <summary>
        ///  Calibrates a stereo camera set up. This function finds the intrinsic parameters
        ///  for each of the two cameras and the extrinsic parameters between the two cameras.
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points. The same structure as
        ///  in @ref calibrateCamera. For each pattern view, both cameras need to see the same object
        ///  points. Therefore, objectPoints.size(), imagePoints1.size(), and imagePoints2.size() need to be
        ///  equal as well as objectPoints[i].size(), imagePoints1[i].size(), and imagePoints2[i].size() need to
        ///  be equal for each i.
        /// </param>
        /// <param name="imagePoints1">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///  observed by the first camera. The same structure as in @ref calibrateCamera.
        /// </param>
        /// <param name="imagePoints2">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///  observed by the second camera. The same structure as in @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera intrinsic matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output second camera intrinsic matrix for the second camera. See description for
        ///  cameraMatrix1.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output lens distortion coefficients for the second camera. See
        ///  description for distCoeffs1.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the camera intrinsic matrices.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector T, this matrix brings
        ///  points given in the first camera's coordinate system to points in the second camera's
        ///  coordinate system. In more technical terms, the tuple of R and T performs a change of basis
        ///  from the first camera's coordinate system to the second camera's coordinate system. Due to its
        ///  duality, this tuple is equivalent to the position of the first camera with respect to the
        ///  second camera coordinate system.
        /// </param>
        /// <param name="T">
        /// Output translation vector, see description above.
        /// </param>
        /// <param name="E">
        /// Output essential matrix.
        /// </param>
        /// <param name="F">
        /// Output fundamental matrix.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors ( @ref Rodrigues ) estimated for each pattern view in the
        ///  coordinate system of the first camera of the stereo pair (e.g. std::vector&lt;cv::Mat&gt;). More in detail, each
        ///  i-th rotation vector together with the corresponding i-th translation vector (see the next output parameter
        ///  description) brings the calibration pattern from the object coordinate space (in which object points are
        ///  specified) to the camera coordinate space of the first camera of the stereo pair. In more technical terms,
        ///  the tuple of the i-th rotation and translation vector performs a change of basis from object coordinate space
        ///  to camera coordinate space of the first camera of the stereo pair.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter description
        ///  of previous output parameter ( rvecs ).
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///  -   @ref CALIB_FIX_INTRINSIC Fix cameraMatrix? and distCoeffs? so that only R, T, E, and F
        ///  matrices are estimated.
        ///  -   @ref CALIB_USE_INTRINSIC_GUESS Optimize some or all of the intrinsic parameters
        ///  according to the specified flags. Initial values are provided by the user.
        ///  -   @ref CALIB_USE_EXTRINSIC_GUESS R and T contain valid initial values that are optimized further.
        ///  Otherwise R and T are initialized to the median value of the pattern views (each dimension separately).
        ///  -   @ref CALIB_FIX_PRINCIPAL_POINT Fix the principal points during the optimization.
        ///  -   @ref CALIB_FIX_FOCAL_LENGTH Fix \f$f^{(j)}_x\f$ and \f$f^{(j)}_y\f$ .
        ///  -   @ref CALIB_FIX_ASPECT_RATIO Optimize \f$f^{(j)}_y\f$ . Fix the ratio \f$f^{(j)}_x/f^{(j)}_y\f$
        ///  .
        ///  -   @ref CALIB_SAME_FOCAL_LENGTH Enforce \f$f^{(0)}_x=f^{(1)}_x\f$ and \f$f^{(0)}_y=f^{(1)}_y\f$ .
        ///  -   @ref CALIB_ZERO_TANGENT_DIST Set tangential distortion coefficients for each camera to
        ///  zeros and fix there.
        ///  -   @ref CALIB_FIX_K1,..., @ref CALIB_FIX_K6 Do not change the corresponding radial
        ///  distortion coefficient during the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set,
        ///  the coefficient from the supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_RATIONAL_MODEL Enable coefficients k4, k5, and k6. To provide the backward
        ///  compatibility, this extra flag should be explicitly specified to make the calibration
        ///  function use the rational model and return 8 coefficients. If the flag is not set, the
        ///  function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_THIN_PRISM_MODEL Coefficients s1, s2, s3 and s4 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the thin prism model and return 12 coefficients. If the flag is not
        ///  set, the function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_FIX_S1_S2_S3_S4 The thin prism distortion coefficients are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_TILTED_MODEL Coefficients tauX and tauY are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the tilted sensor model and return 14 coefficients. If the flag is not
        ///  set, the function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_FIX_TAUX_TAUY The coefficients of the tilted sensor model are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <remarks>
        ///  The function estimates the transformation between two cameras making a stereo pair. If one computes
        ///  the poses of an object relative to the first camera and to the second camera,
        ///  ( \f$R_1\f$,\f$T_1\f$ ) and (\f$R_2\f$,\f$T_2\f$), respectively, for a stereo camera where the
        ///  relative position and orientation between the two cameras are fixed, then those poses definitely
        ///  relate to each other. This means, if the relative position and orientation (\f$R\f$,\f$T\f$) of the
        ///  two cameras is known, it is possible to compute (\f$R_2\f$,\f$T_2\f$) when (\f$R_1\f$,\f$T_1\f$) is
        ///  given. This is what the described function does. It computes (\f$R\f$,\f$T\f$) such that:
        ///  
        ///  \f[R_2=R R_1\f]
        ///  \f[T_2=R T_1 + T.\f]
        ///  
        ///  Therefore, one can compute the coordinate representation of a 3D point for the second camera's
        ///  coordinate system when given the point's coordinate representation in the first camera's coordinate
        ///  system:
        ///  
        ///  \f[\begin{bmatrix}
        ///  X_2 \\
        ///  Y_2 \\
        ///  Z_2 \\
        ///  1
        ///  \end{bmatrix} = \begin{bmatrix}
        ///  R &amp; T \\
        ///  0 &amp; 1
        ///  \end{bmatrix} \begin{bmatrix}
        ///  X_1 \\
        ///  Y_1 \\
        ///  Z_1 \\
        ///  1
        ///  \end{bmatrix}.\f]
        ///  
        ///  
        ///  Optionally, it computes the essential matrix E:
        ///  
        ///  \f[E= \vecthreethree{0}{-T_2}{T_1}{T_2}{0}{-T_0}{-T_1}{T_0}{0} R\f]
        ///  
        ///  where \f$T_i\f$ are components of the translation vector \f$T\f$ : \f$T=[T_0, T_1, T_2]^T\f$ .
        ///  And the function can also compute the fundamental matrix F:
        ///  
        ///  \f[F = cameraMatrix2^{-T}\cdot E \cdot cameraMatrix1^{-1}\f]
        ///  
        ///  Besides the stereo-related information, the function can also perform a full calibration of each of
        ///  the two cameras. However, due to the high dimensionality of the parameter space and noise in the
        ///  input data, the function can diverge from the correct solution. If the intrinsic parameters can be
        ///  estimated with high accuracy for each of the cameras individually (for example, using
        ///  #calibrateCamera ), you are recommended to do so and then pass @ref CALIB_FIX_INTRINSIC flag to the
        ///  function along with the computed intrinsic parameters. Otherwise, if all the parameters are
        ///  estimated at once, it makes sense to restrict some parameters, for example, pass
        ///   @ref CALIB_SAME_FOCAL_LENGTH and @ref CALIB_ZERO_TANGENT_DIST flags, which is usually a
        ///  reasonable assumption.
        ///  
        ///  Similarly to #calibrateCamera, the function minimizes the total re-projection error for all the
        ///  points in all the available views from both cameras. The function returns the final value of the
        ///  re-projection error.
        /// </remarks>
        public static double stereoCalibrateExtended(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, List<Mat> rvecs, List<Mat> tvecs, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_stereoCalibrateExtended_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Calibrates a stereo camera set up. This function finds the intrinsic parameters
        ///  for each of the two cameras and the extrinsic parameters between the two cameras.
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points. The same structure as
        ///  in @ref calibrateCamera. For each pattern view, both cameras need to see the same object
        ///  points. Therefore, objectPoints.size(), imagePoints1.size(), and imagePoints2.size() need to be
        ///  equal as well as objectPoints[i].size(), imagePoints1[i].size(), and imagePoints2[i].size() need to
        ///  be equal for each i.
        /// </param>
        /// <param name="imagePoints1">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///  observed by the first camera. The same structure as in @ref calibrateCamera.
        /// </param>
        /// <param name="imagePoints2">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///  observed by the second camera. The same structure as in @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera intrinsic matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output second camera intrinsic matrix for the second camera. See description for
        ///  cameraMatrix1.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output lens distortion coefficients for the second camera. See
        ///  description for distCoeffs1.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the camera intrinsic matrices.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector T, this matrix brings
        ///  points given in the first camera's coordinate system to points in the second camera's
        ///  coordinate system. In more technical terms, the tuple of R and T performs a change of basis
        ///  from the first camera's coordinate system to the second camera's coordinate system. Due to its
        ///  duality, this tuple is equivalent to the position of the first camera with respect to the
        ///  second camera coordinate system.
        /// </param>
        /// <param name="T">
        /// Output translation vector, see description above.
        /// </param>
        /// <param name="E">
        /// Output essential matrix.
        /// </param>
        /// <param name="F">
        /// Output fundamental matrix.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors ( @ref Rodrigues ) estimated for each pattern view in the
        ///  coordinate system of the first camera of the stereo pair (e.g. std::vector&lt;cv::Mat&gt;). More in detail, each
        ///  i-th rotation vector together with the corresponding i-th translation vector (see the next output parameter
        ///  description) brings the calibration pattern from the object coordinate space (in which object points are
        ///  specified) to the camera coordinate space of the first camera of the stereo pair. In more technical terms,
        ///  the tuple of the i-th rotation and translation vector performs a change of basis from object coordinate space
        ///  to camera coordinate space of the first camera of the stereo pair.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter description
        ///  of previous output parameter ( rvecs ).
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///  -   @ref CALIB_FIX_INTRINSIC Fix cameraMatrix? and distCoeffs? so that only R, T, E, and F
        ///  matrices are estimated.
        ///  -   @ref CALIB_USE_INTRINSIC_GUESS Optimize some or all of the intrinsic parameters
        ///  according to the specified flags. Initial values are provided by the user.
        ///  -   @ref CALIB_USE_EXTRINSIC_GUESS R and T contain valid initial values that are optimized further.
        ///  Otherwise R and T are initialized to the median value of the pattern views (each dimension separately).
        ///  -   @ref CALIB_FIX_PRINCIPAL_POINT Fix the principal points during the optimization.
        ///  -   @ref CALIB_FIX_FOCAL_LENGTH Fix \f$f^{(j)}_x\f$ and \f$f^{(j)}_y\f$ .
        ///  -   @ref CALIB_FIX_ASPECT_RATIO Optimize \f$f^{(j)}_y\f$ . Fix the ratio \f$f^{(j)}_x/f^{(j)}_y\f$
        ///  .
        ///  -   @ref CALIB_SAME_FOCAL_LENGTH Enforce \f$f^{(0)}_x=f^{(1)}_x\f$ and \f$f^{(0)}_y=f^{(1)}_y\f$ .
        ///  -   @ref CALIB_ZERO_TANGENT_DIST Set tangential distortion coefficients for each camera to
        ///  zeros and fix there.
        ///  -   @ref CALIB_FIX_K1,..., @ref CALIB_FIX_K6 Do not change the corresponding radial
        ///  distortion coefficient during the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set,
        ///  the coefficient from the supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_RATIONAL_MODEL Enable coefficients k4, k5, and k6. To provide the backward
        ///  compatibility, this extra flag should be explicitly specified to make the calibration
        ///  function use the rational model and return 8 coefficients. If the flag is not set, the
        ///  function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_THIN_PRISM_MODEL Coefficients s1, s2, s3 and s4 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the thin prism model and return 12 coefficients. If the flag is not
        ///  set, the function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_FIX_S1_S2_S3_S4 The thin prism distortion coefficients are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_TILTED_MODEL Coefficients tauX and tauY are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the tilted sensor model and return 14 coefficients. If the flag is not
        ///  set, the function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_FIX_TAUX_TAUY The coefficients of the tilted sensor model are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <remarks>
        ///  The function estimates the transformation between two cameras making a stereo pair. If one computes
        ///  the poses of an object relative to the first camera and to the second camera,
        ///  ( \f$R_1\f$,\f$T_1\f$ ) and (\f$R_2\f$,\f$T_2\f$), respectively, for a stereo camera where the
        ///  relative position and orientation between the two cameras are fixed, then those poses definitely
        ///  relate to each other. This means, if the relative position and orientation (\f$R\f$,\f$T\f$) of the
        ///  two cameras is known, it is possible to compute (\f$R_2\f$,\f$T_2\f$) when (\f$R_1\f$,\f$T_1\f$) is
        ///  given. This is what the described function does. It computes (\f$R\f$,\f$T\f$) such that:
        ///  
        ///  \f[R_2=R R_1\f]
        ///  \f[T_2=R T_1 + T.\f]
        ///  
        ///  Therefore, one can compute the coordinate representation of a 3D point for the second camera's
        ///  coordinate system when given the point's coordinate representation in the first camera's coordinate
        ///  system:
        ///  
        ///  \f[\begin{bmatrix}
        ///  X_2 \\
        ///  Y_2 \\
        ///  Z_2 \\
        ///  1
        ///  \end{bmatrix} = \begin{bmatrix}
        ///  R &amp; T \\
        ///  0 &amp; 1
        ///  \end{bmatrix} \begin{bmatrix}
        ///  X_1 \\
        ///  Y_1 \\
        ///  Z_1 \\
        ///  1
        ///  \end{bmatrix}.\f]
        ///  
        ///  
        ///  Optionally, it computes the essential matrix E:
        ///  
        ///  \f[E= \vecthreethree{0}{-T_2}{T_1}{T_2}{0}{-T_0}{-T_1}{T_0}{0} R\f]
        ///  
        ///  where \f$T_i\f$ are components of the translation vector \f$T\f$ : \f$T=[T_0, T_1, T_2]^T\f$ .
        ///  And the function can also compute the fundamental matrix F:
        ///  
        ///  \f[F = cameraMatrix2^{-T}\cdot E \cdot cameraMatrix1^{-1}\f]
        ///  
        ///  Besides the stereo-related information, the function can also perform a full calibration of each of
        ///  the two cameras. However, due to the high dimensionality of the parameter space and noise in the
        ///  input data, the function can diverge from the correct solution. If the intrinsic parameters can be
        ///  estimated with high accuracy for each of the cameras individually (for example, using
        ///  #calibrateCamera ), you are recommended to do so and then pass @ref CALIB_FIX_INTRINSIC flag to the
        ///  function along with the computed intrinsic parameters. Otherwise, if all the parameters are
        ///  estimated at once, it makes sense to restrict some parameters, for example, pass
        ///   @ref CALIB_SAME_FOCAL_LENGTH and @ref CALIB_ZERO_TANGENT_DIST flags, which is usually a
        ///  reasonable assumption.
        ///  
        ///  Similarly to #calibrateCamera, the function minimizes the total re-projection error for all the
        ///  points in all the available views from both cameras. The function returns the final value of the
        ///  re-projection error.
        /// </remarks>
        public static double stereoCalibrateExtended(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, List<Mat> rvecs, List<Mat> tvecs, Mat perViewErrors, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_stereoCalibrateExtended_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, perViewErrors.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Calibrates a stereo camera set up. This function finds the intrinsic parameters
        ///  for each of the two cameras and the extrinsic parameters between the two cameras.
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points. The same structure as
        ///  in @ref calibrateCamera. For each pattern view, both cameras need to see the same object
        ///  points. Therefore, objectPoints.size(), imagePoints1.size(), and imagePoints2.size() need to be
        ///  equal as well as objectPoints[i].size(), imagePoints1[i].size(), and imagePoints2[i].size() need to
        ///  be equal for each i.
        /// </param>
        /// <param name="imagePoints1">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///  observed by the first camera. The same structure as in @ref calibrateCamera.
        /// </param>
        /// <param name="imagePoints2">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///  observed by the second camera. The same structure as in @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera intrinsic matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output second camera intrinsic matrix for the second camera. See description for
        ///  cameraMatrix1.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output lens distortion coefficients for the second camera. See
        ///  description for distCoeffs1.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize the camera intrinsic matrices.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector T, this matrix brings
        ///  points given in the first camera's coordinate system to points in the second camera's
        ///  coordinate system. In more technical terms, the tuple of R and T performs a change of basis
        ///  from the first camera's coordinate system to the second camera's coordinate system. Due to its
        ///  duality, this tuple is equivalent to the position of the first camera with respect to the
        ///  second camera coordinate system.
        /// </param>
        /// <param name="T">
        /// Output translation vector, see description above.
        /// </param>
        /// <param name="E">
        /// Output essential matrix.
        /// </param>
        /// <param name="F">
        /// Output fundamental matrix.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors ( @ref Rodrigues ) estimated for each pattern view in the
        ///  coordinate system of the first camera of the stereo pair (e.g. std::vector&lt;cv::Mat&gt;). More in detail, each
        ///  i-th rotation vector together with the corresponding i-th translation vector (see the next output parameter
        ///  description) brings the calibration pattern from the object coordinate space (in which object points are
        ///  specified) to the camera coordinate space of the first camera of the stereo pair. In more technical terms,
        ///  the tuple of the i-th rotation and translation vector performs a change of basis from object coordinate space
        ///  to camera coordinate space of the first camera of the stereo pair.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter description
        ///  of previous output parameter ( rvecs ).
        /// </param>
        /// <param name="perViewErrors">
        /// Output vector of the RMS re-projection error estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///  -   @ref CALIB_FIX_INTRINSIC Fix cameraMatrix? and distCoeffs? so that only R, T, E, and F
        ///  matrices are estimated.
        ///  -   @ref CALIB_USE_INTRINSIC_GUESS Optimize some or all of the intrinsic parameters
        ///  according to the specified flags. Initial values are provided by the user.
        ///  -   @ref CALIB_USE_EXTRINSIC_GUESS R and T contain valid initial values that are optimized further.
        ///  Otherwise R and T are initialized to the median value of the pattern views (each dimension separately).
        ///  -   @ref CALIB_FIX_PRINCIPAL_POINT Fix the principal points during the optimization.
        ///  -   @ref CALIB_FIX_FOCAL_LENGTH Fix \f$f^{(j)}_x\f$ and \f$f^{(j)}_y\f$ .
        ///  -   @ref CALIB_FIX_ASPECT_RATIO Optimize \f$f^{(j)}_y\f$ . Fix the ratio \f$f^{(j)}_x/f^{(j)}_y\f$
        ///  .
        ///  -   @ref CALIB_SAME_FOCAL_LENGTH Enforce \f$f^{(0)}_x=f^{(1)}_x\f$ and \f$f^{(0)}_y=f^{(1)}_y\f$ .
        ///  -   @ref CALIB_ZERO_TANGENT_DIST Set tangential distortion coefficients for each camera to
        ///  zeros and fix there.
        ///  -   @ref CALIB_FIX_K1,..., @ref CALIB_FIX_K6 Do not change the corresponding radial
        ///  distortion coefficient during the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set,
        ///  the coefficient from the supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_RATIONAL_MODEL Enable coefficients k4, k5, and k6. To provide the backward
        ///  compatibility, this extra flag should be explicitly specified to make the calibration
        ///  function use the rational model and return 8 coefficients. If the flag is not set, the
        ///  function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_THIN_PRISM_MODEL Coefficients s1, s2, s3 and s4 are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the thin prism model and return 12 coefficients. If the flag is not
        ///  set, the function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_FIX_S1_S2_S3_S4 The thin prism distortion coefficients are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        ///  -   @ref CALIB_TILTED_MODEL Coefficients tauX and tauY are enabled. To provide the
        ///  backward compatibility, this extra flag should be explicitly specified to make the
        ///  calibration function use the tilted sensor model and return 14 coefficients. If the flag is not
        ///  set, the function computes and returns only 5 distortion coefficients.
        ///  -   @ref CALIB_FIX_TAUX_TAUY The coefficients of the tilted sensor model are not changed during
        ///  the optimization. If @ref CALIB_USE_INTRINSIC_GUESS is set, the coefficient from the
        ///  supplied distCoeffs matrix is used. Otherwise, it is set to 0.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        /// <remarks>
        ///  The function estimates the transformation between two cameras making a stereo pair. If one computes
        ///  the poses of an object relative to the first camera and to the second camera,
        ///  ( \f$R_1\f$,\f$T_1\f$ ) and (\f$R_2\f$,\f$T_2\f$), respectively, for a stereo camera where the
        ///  relative position and orientation between the two cameras are fixed, then those poses definitely
        ///  relate to each other. This means, if the relative position and orientation (\f$R\f$,\f$T\f$) of the
        ///  two cameras is known, it is possible to compute (\f$R_2\f$,\f$T_2\f$) when (\f$R_1\f$,\f$T_1\f$) is
        ///  given. This is what the described function does. It computes (\f$R\f$,\f$T\f$) such that:
        ///  
        ///  \f[R_2=R R_1\f]
        ///  \f[T_2=R T_1 + T.\f]
        ///  
        ///  Therefore, one can compute the coordinate representation of a 3D point for the second camera's
        ///  coordinate system when given the point's coordinate representation in the first camera's coordinate
        ///  system:
        ///  
        ///  \f[\begin{bmatrix}
        ///  X_2 \\
        ///  Y_2 \\
        ///  Z_2 \\
        ///  1
        ///  \end{bmatrix} = \begin{bmatrix}
        ///  R &amp; T \\
        ///  0 &amp; 1
        ///  \end{bmatrix} \begin{bmatrix}
        ///  X_1 \\
        ///  Y_1 \\
        ///  Z_1 \\
        ///  1
        ///  \end{bmatrix}.\f]
        ///  
        ///  
        ///  Optionally, it computes the essential matrix E:
        ///  
        ///  \f[E= \vecthreethree{0}{-T_2}{T_1}{T_2}{0}{-T_0}{-T_1}{T_0}{0} R\f]
        ///  
        ///  where \f$T_i\f$ are components of the translation vector \f$T\f$ : \f$T=[T_0, T_1, T_2]^T\f$ .
        ///  And the function can also compute the fundamental matrix F:
        ///  
        ///  \f[F = cameraMatrix2^{-T}\cdot E \cdot cameraMatrix1^{-1}\f]
        ///  
        ///  Besides the stereo-related information, the function can also perform a full calibration of each of
        ///  the two cameras. However, due to the high dimensionality of the parameter space and noise in the
        ///  input data, the function can diverge from the correct solution. If the intrinsic parameters can be
        ///  estimated with high accuracy for each of the cameras individually (for example, using
        ///  #calibrateCamera ), you are recommended to do so and then pass @ref CALIB_FIX_INTRINSIC flag to the
        ///  function along with the computed intrinsic parameters. Otherwise, if all the parameters are
        ///  estimated at once, it makes sense to restrict some parameters, for example, pass
        ///   @ref CALIB_SAME_FOCAL_LENGTH and @ref CALIB_ZERO_TANGENT_DIST flags, which is usually a
        ///  reasonable assumption.
        ///  
        ///  Similarly to #calibrateCamera, the function minimizes the total re-projection error for all the
        ///  points in all the available views from both cameras. The function returns the final value of the
        ///  re-projection error.
        /// </remarks>
        public static double stereoCalibrateExtended(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, List<Mat> rvecs, List<Mat> tvecs, Mat perViewErrors)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_stereoCalibrateExtended_12(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, perViewErrors.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        //

        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, int flags, TermCriteria criteria)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_stereoCalibrate_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_stereoCalibrate_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, flags);


        }

        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_stereoCalibrate_12(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj);


        }


        //
        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, Mat& perViewErrors, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        //

        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors, int flags, TermCriteria criteria)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_stereoCalibrate_13(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, perViewErrors.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_stereoCalibrate_14(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, perViewErrors.nativeObj, flags);


        }

        public static double stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat E, Mat F, Mat perViewErrors)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (perViewErrors != null) perViewErrors.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_stereoCalibrate_15(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, E.nativeObj, F.nativeObj, perViewErrors.nativeObj);


        }


        //
        // C++:  void cv::stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags = CALIB_ZERO_DISPARITY, double alpha = -1, Size newImageSize = Size(), Rect* validPixROI1 = 0, Rect* validPixROI2 = 0)
        //

        /// <summary>
        ///  Computes rectification transforms for each head of a calibrated stereo camera.
        /// </summary>
        /// <param name="cameraMatrix1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="T">
        /// Translation vector from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera. This matrix
        ///  brings points given in the unrectified first camera's coordinate system to points in the rectified
        ///  first camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified first camera's coordinate system to the rectified first camera's coordinate system.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera. This matrix
        ///  brings points given in the unrectified second camera's coordinate system to points in the rectified
        ///  second camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified second camera's coordinate system to the rectified second camera's coordinate system.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified first camera's image.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified second camera's image.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see @ref reprojectImageTo3D).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref CALIB_ZERO_DISPARITY . If the flag is set,
        ///  the function makes the principal points of each camera have the same pixel coordinates in the
        ///  rectified views. And if the flag is not set, the function may still shift the images in the
        ///  horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///  useful image area.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter. If it is -1 or absent, the function performs the default
        ///  scaling. Otherwise, the parameter should be between 0 and 1. alpha=0 means that the rectified
        ///  images are zoomed and shifted so that only valid pixels are visible (no black areas after
        ///  rectification). alpha=1 means that the rectified image is decimated and shifted so that all the
        ///  pixels from the original images from the cameras are retained in the rectified images (no source
        ///  image pixels are lost). Any intermediate value yields an intermediate result between
        ///  those two extreme cases.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///  #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///  is passed (default), it is set to the original imageSize . Setting it to a larger value can help you
        ///  preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="validPixROI1">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <param name="validPixROI2">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <remarks>
        ///  The function computes the rotation matrices for each camera that (virtually) make both camera image
        ///  planes the same plane. Consequently, this makes all the epipolar lines parallel and thus simplifies
        ///  the dense stereo correspondence problem. The function takes the matrices computed by #stereoCalibrate
        ///  as input. As output, it provides two rotation matrices and also two projection matrices in the new
        ///  coordinates. The function distinguishes the following two cases:
        ///  
        ///  -   **Horizontal stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly along the x-axis (with possible small vertical shift). In the rectified images, the
        ///      corresponding epipolar lines in the left and right cameras are horizontal and have the same
        ///      y-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_1 &amp; 0 \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_2 &amp; T_x \cdot f \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix} ,\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx_1 \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_x} &amp; \frac{cx_1 - cx_2}{T_x}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_x\f$ is a horizontal shift between the cameras and \f$cx_1=cx_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  -   **Vertical stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly in the vertical direction (and probably a bit in the horizontal direction too). The epipolar
        ///      lines in the rectified images are vertical and have the same x-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_1 &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_2 &amp; T_y \cdot f \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix},\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy_1 \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_y} &amp; \frac{cy_1 - cy_2}{T_y}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_y\f$ is a vertical shift between the cameras and \f$cy_1=cy_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  As you can see, the first three columns of P1 and P2 will effectively be the new "rectified" camera
        ///  matrices. The matrices, together with R1 and R2 , can then be passed to #initUndistortRectifyMap to
        ///  initialize the rectification map for each camera.
        ///  
        ///  See below the screenshot from the stereo_calib.cpp sample. Some red horizontal lines pass through
        ///  the corresponding image regions. This means that the images are well rectified, which is what most
        ///  stereo correspondence algorithms rely on. The green rectangles are roi1 and roi2 . You see that
        ///  their interiors are all valid pixels.
        ///  
        ///  ![image](pics/stereo_undistort.jpg)
        /// </remarks>
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size newImageSize, Rect validPixROI1, Rect validPixROI2)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
            double[] validPixROI1_out = new double[4];
            double[] validPixROI2_out = new double[4];
            calib3d_Calib3d_stereoRectify_10(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha, newImageSize.width, newImageSize.height, validPixROI1_out, validPixROI2_out);
            if (validPixROI1 != null) { validPixROI1.x = (int)validPixROI1_out[0]; validPixROI1.y = (int)validPixROI1_out[1]; validPixROI1.width = (int)validPixROI1_out[2]; validPixROI1.height = (int)validPixROI1_out[3]; }
            if (validPixROI2 != null) { validPixROI2.x = (int)validPixROI2_out[0]; validPixROI2.y = (int)validPixROI2_out[1]; validPixROI2.width = (int)validPixROI2_out[2]; validPixROI2.height = (int)validPixROI2_out[3]; }

        }

        /// <summary>
        ///  Computes rectification transforms for each head of a calibrated stereo camera.
        /// </summary>
        /// <param name="cameraMatrix1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="T">
        /// Translation vector from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera. This matrix
        ///  brings points given in the unrectified first camera's coordinate system to points in the rectified
        ///  first camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified first camera's coordinate system to the rectified first camera's coordinate system.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera. This matrix
        ///  brings points given in the unrectified second camera's coordinate system to points in the rectified
        ///  second camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified second camera's coordinate system to the rectified second camera's coordinate system.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified first camera's image.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified second camera's image.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see @ref reprojectImageTo3D).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref CALIB_ZERO_DISPARITY . If the flag is set,
        ///  the function makes the principal points of each camera have the same pixel coordinates in the
        ///  rectified views. And if the flag is not set, the function may still shift the images in the
        ///  horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///  useful image area.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter. If it is -1 or absent, the function performs the default
        ///  scaling. Otherwise, the parameter should be between 0 and 1. alpha=0 means that the rectified
        ///  images are zoomed and shifted so that only valid pixels are visible (no black areas after
        ///  rectification). alpha=1 means that the rectified image is decimated and shifted so that all the
        ///  pixels from the original images from the cameras are retained in the rectified images (no source
        ///  image pixels are lost). Any intermediate value yields an intermediate result between
        ///  those two extreme cases.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///  #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///  is passed (default), it is set to the original imageSize . Setting it to a larger value can help you
        ///  preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="validPixROI1">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <param name="validPixROI2">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <remarks>
        ///  The function computes the rotation matrices for each camera that (virtually) make both camera image
        ///  planes the same plane. Consequently, this makes all the epipolar lines parallel and thus simplifies
        ///  the dense stereo correspondence problem. The function takes the matrices computed by #stereoCalibrate
        ///  as input. As output, it provides two rotation matrices and also two projection matrices in the new
        ///  coordinates. The function distinguishes the following two cases:
        ///  
        ///  -   **Horizontal stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly along the x-axis (with possible small vertical shift). In the rectified images, the
        ///      corresponding epipolar lines in the left and right cameras are horizontal and have the same
        ///      y-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_1 &amp; 0 \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_2 &amp; T_x \cdot f \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix} ,\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx_1 \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_x} &amp; \frac{cx_1 - cx_2}{T_x}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_x\f$ is a horizontal shift between the cameras and \f$cx_1=cx_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  -   **Vertical stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly in the vertical direction (and probably a bit in the horizontal direction too). The epipolar
        ///      lines in the rectified images are vertical and have the same x-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_1 &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_2 &amp; T_y \cdot f \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix},\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy_1 \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_y} &amp; \frac{cy_1 - cy_2}{T_y}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_y\f$ is a vertical shift between the cameras and \f$cy_1=cy_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  As you can see, the first three columns of P1 and P2 will effectively be the new "rectified" camera
        ///  matrices. The matrices, together with R1 and R2 , can then be passed to #initUndistortRectifyMap to
        ///  initialize the rectification map for each camera.
        ///  
        ///  See below the screenshot from the stereo_calib.cpp sample. Some red horizontal lines pass through
        ///  the corresponding image regions. This means that the images are well rectified, which is what most
        ///  stereo correspondence algorithms rely on. The green rectangles are roi1 and roi2 . You see that
        ///  their interiors are all valid pixels.
        ///  
        ///  ![image](pics/stereo_undistort.jpg)
        /// </remarks>
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size newImageSize, Rect validPixROI1)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
            double[] validPixROI1_out = new double[4];
            calib3d_Calib3d_stereoRectify_11(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha, newImageSize.width, newImageSize.height, validPixROI1_out);
            if (validPixROI1 != null) { validPixROI1.x = (int)validPixROI1_out[0]; validPixROI1.y = (int)validPixROI1_out[1]; validPixROI1.width = (int)validPixROI1_out[2]; validPixROI1.height = (int)validPixROI1_out[3]; }

        }

        /// <summary>
        ///  Computes rectification transforms for each head of a calibrated stereo camera.
        /// </summary>
        /// <param name="cameraMatrix1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="T">
        /// Translation vector from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera. This matrix
        ///  brings points given in the unrectified first camera's coordinate system to points in the rectified
        ///  first camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified first camera's coordinate system to the rectified first camera's coordinate system.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera. This matrix
        ///  brings points given in the unrectified second camera's coordinate system to points in the rectified
        ///  second camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified second camera's coordinate system to the rectified second camera's coordinate system.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified first camera's image.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified second camera's image.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see @ref reprojectImageTo3D).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref CALIB_ZERO_DISPARITY . If the flag is set,
        ///  the function makes the principal points of each camera have the same pixel coordinates in the
        ///  rectified views. And if the flag is not set, the function may still shift the images in the
        ///  horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///  useful image area.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter. If it is -1 or absent, the function performs the default
        ///  scaling. Otherwise, the parameter should be between 0 and 1. alpha=0 means that the rectified
        ///  images are zoomed and shifted so that only valid pixels are visible (no black areas after
        ///  rectification). alpha=1 means that the rectified image is decimated and shifted so that all the
        ///  pixels from the original images from the cameras are retained in the rectified images (no source
        ///  image pixels are lost). Any intermediate value yields an intermediate result between
        ///  those two extreme cases.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///  #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///  is passed (default), it is set to the original imageSize . Setting it to a larger value can help you
        ///  preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="validPixROI1">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <param name="validPixROI2">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <remarks>
        ///  The function computes the rotation matrices for each camera that (virtually) make both camera image
        ///  planes the same plane. Consequently, this makes all the epipolar lines parallel and thus simplifies
        ///  the dense stereo correspondence problem. The function takes the matrices computed by #stereoCalibrate
        ///  as input. As output, it provides two rotation matrices and also two projection matrices in the new
        ///  coordinates. The function distinguishes the following two cases:
        ///  
        ///  -   **Horizontal stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly along the x-axis (with possible small vertical shift). In the rectified images, the
        ///      corresponding epipolar lines in the left and right cameras are horizontal and have the same
        ///      y-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_1 &amp; 0 \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_2 &amp; T_x \cdot f \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix} ,\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx_1 \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_x} &amp; \frac{cx_1 - cx_2}{T_x}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_x\f$ is a horizontal shift between the cameras and \f$cx_1=cx_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  -   **Vertical stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly in the vertical direction (and probably a bit in the horizontal direction too). The epipolar
        ///      lines in the rectified images are vertical and have the same x-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_1 &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_2 &amp; T_y \cdot f \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix},\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy_1 \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_y} &amp; \frac{cy_1 - cy_2}{T_y}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_y\f$ is a vertical shift between the cameras and \f$cy_1=cy_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  As you can see, the first three columns of P1 and P2 will effectively be the new "rectified" camera
        ///  matrices. The matrices, together with R1 and R2 , can then be passed to #initUndistortRectifyMap to
        ///  initialize the rectification map for each camera.
        ///  
        ///  See below the screenshot from the stereo_calib.cpp sample. Some red horizontal lines pass through
        ///  the corresponding image regions. This means that the images are well rectified, which is what most
        ///  stereo correspondence algorithms rely on. The green rectangles are roi1 and roi2 . You see that
        ///  their interiors are all valid pixels.
        ///  
        ///  ![image](pics/stereo_undistort.jpg)
        /// </remarks>
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha, Size newImageSize)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_stereoRectify_12(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha, newImageSize.width, newImageSize.height);


        }

        /// <summary>
        ///  Computes rectification transforms for each head of a calibrated stereo camera.
        /// </summary>
        /// <param name="cameraMatrix1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="T">
        /// Translation vector from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera. This matrix
        ///  brings points given in the unrectified first camera's coordinate system to points in the rectified
        ///  first camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified first camera's coordinate system to the rectified first camera's coordinate system.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera. This matrix
        ///  brings points given in the unrectified second camera's coordinate system to points in the rectified
        ///  second camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified second camera's coordinate system to the rectified second camera's coordinate system.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified first camera's image.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified second camera's image.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see @ref reprojectImageTo3D).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref CALIB_ZERO_DISPARITY . If the flag is set,
        ///  the function makes the principal points of each camera have the same pixel coordinates in the
        ///  rectified views. And if the flag is not set, the function may still shift the images in the
        ///  horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///  useful image area.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter. If it is -1 or absent, the function performs the default
        ///  scaling. Otherwise, the parameter should be between 0 and 1. alpha=0 means that the rectified
        ///  images are zoomed and shifted so that only valid pixels are visible (no black areas after
        ///  rectification). alpha=1 means that the rectified image is decimated and shifted so that all the
        ///  pixels from the original images from the cameras are retained in the rectified images (no source
        ///  image pixels are lost). Any intermediate value yields an intermediate result between
        ///  those two extreme cases.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///  #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///  is passed (default), it is set to the original imageSize . Setting it to a larger value can help you
        ///  preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="validPixROI1">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <param name="validPixROI2">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <remarks>
        ///  The function computes the rotation matrices for each camera that (virtually) make both camera image
        ///  planes the same plane. Consequently, this makes all the epipolar lines parallel and thus simplifies
        ///  the dense stereo correspondence problem. The function takes the matrices computed by #stereoCalibrate
        ///  as input. As output, it provides two rotation matrices and also two projection matrices in the new
        ///  coordinates. The function distinguishes the following two cases:
        ///  
        ///  -   **Horizontal stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly along the x-axis (with possible small vertical shift). In the rectified images, the
        ///      corresponding epipolar lines in the left and right cameras are horizontal and have the same
        ///      y-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_1 &amp; 0 \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_2 &amp; T_x \cdot f \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix} ,\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx_1 \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_x} &amp; \frac{cx_1 - cx_2}{T_x}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_x\f$ is a horizontal shift between the cameras and \f$cx_1=cx_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  -   **Vertical stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly in the vertical direction (and probably a bit in the horizontal direction too). The epipolar
        ///      lines in the rectified images are vertical and have the same x-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_1 &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_2 &amp; T_y \cdot f \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix},\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy_1 \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_y} &amp; \frac{cy_1 - cy_2}{T_y}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_y\f$ is a vertical shift between the cameras and \f$cy_1=cy_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  As you can see, the first three columns of P1 and P2 will effectively be the new "rectified" camera
        ///  matrices. The matrices, together with R1 and R2 , can then be passed to #initUndistortRectifyMap to
        ///  initialize the rectification map for each camera.
        ///  
        ///  See below the screenshot from the stereo_calib.cpp sample. Some red horizontal lines pass through
        ///  the corresponding image regions. This means that the images are well rectified, which is what most
        ///  stereo correspondence algorithms rely on. The green rectangles are roi1 and roi2 . You see that
        ///  their interiors are all valid pixels.
        ///  
        ///  ![image](pics/stereo_undistort.jpg)
        /// </remarks>
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, double alpha)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_stereoRectify_13(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, alpha);


        }

        /// <summary>
        ///  Computes rectification transforms for each head of a calibrated stereo camera.
        /// </summary>
        /// <param name="cameraMatrix1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="T">
        /// Translation vector from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera. This matrix
        ///  brings points given in the unrectified first camera's coordinate system to points in the rectified
        ///  first camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified first camera's coordinate system to the rectified first camera's coordinate system.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera. This matrix
        ///  brings points given in the unrectified second camera's coordinate system to points in the rectified
        ///  second camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified second camera's coordinate system to the rectified second camera's coordinate system.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified first camera's image.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified second camera's image.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see @ref reprojectImageTo3D).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref CALIB_ZERO_DISPARITY . If the flag is set,
        ///  the function makes the principal points of each camera have the same pixel coordinates in the
        ///  rectified views. And if the flag is not set, the function may still shift the images in the
        ///  horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///  useful image area.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter. If it is -1 or absent, the function performs the default
        ///  scaling. Otherwise, the parameter should be between 0 and 1. alpha=0 means that the rectified
        ///  images are zoomed and shifted so that only valid pixels are visible (no black areas after
        ///  rectification). alpha=1 means that the rectified image is decimated and shifted so that all the
        ///  pixels from the original images from the cameras are retained in the rectified images (no source
        ///  image pixels are lost). Any intermediate value yields an intermediate result between
        ///  those two extreme cases.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///  #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///  is passed (default), it is set to the original imageSize . Setting it to a larger value can help you
        ///  preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="validPixROI1">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <param name="validPixROI2">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <remarks>
        ///  The function computes the rotation matrices for each camera that (virtually) make both camera image
        ///  planes the same plane. Consequently, this makes all the epipolar lines parallel and thus simplifies
        ///  the dense stereo correspondence problem. The function takes the matrices computed by #stereoCalibrate
        ///  as input. As output, it provides two rotation matrices and also two projection matrices in the new
        ///  coordinates. The function distinguishes the following two cases:
        ///  
        ///  -   **Horizontal stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly along the x-axis (with possible small vertical shift). In the rectified images, the
        ///      corresponding epipolar lines in the left and right cameras are horizontal and have the same
        ///      y-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_1 &amp; 0 \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_2 &amp; T_x \cdot f \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix} ,\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx_1 \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_x} &amp; \frac{cx_1 - cx_2}{T_x}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_x\f$ is a horizontal shift between the cameras and \f$cx_1=cx_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  -   **Vertical stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly in the vertical direction (and probably a bit in the horizontal direction too). The epipolar
        ///      lines in the rectified images are vertical and have the same x-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_1 &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_2 &amp; T_y \cdot f \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix},\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy_1 \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_y} &amp; \frac{cy_1 - cy_2}{T_y}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_y\f$ is a vertical shift between the cameras and \f$cy_1=cy_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  As you can see, the first three columns of P1 and P2 will effectively be the new "rectified" camera
        ///  matrices. The matrices, together with R1 and R2 , can then be passed to #initUndistortRectifyMap to
        ///  initialize the rectification map for each camera.
        ///  
        ///  See below the screenshot from the stereo_calib.cpp sample. Some red horizontal lines pass through
        ///  the corresponding image regions. This means that the images are well rectified, which is what most
        ///  stereo correspondence algorithms rely on. The green rectangles are roi1 and roi2 . You see that
        ///  their interiors are all valid pixels.
        ///  
        ///  ![image](pics/stereo_undistort.jpg)
        /// </remarks>
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_stereoRectify_14(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags);


        }

        /// <summary>
        ///  Computes rectification transforms for each head of a calibrated stereo camera.
        /// </summary>
        /// <param name="cameraMatrix1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="T">
        /// Translation vector from the coordinate system of the first camera to the second camera,
        ///  see @ref stereoCalibrate.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera. This matrix
        ///  brings points given in the unrectified first camera's coordinate system to points in the rectified
        ///  first camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified first camera's coordinate system to the rectified first camera's coordinate system.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera. This matrix
        ///  brings points given in the unrectified second camera's coordinate system to points in the rectified
        ///  second camera's coordinate system. In more technical terms, it performs a change of basis from the
        ///  unrectified second camera's coordinate system to the rectified second camera's coordinate system.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified first camera's image.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///  camera, i.e. it projects points given in the rectified first camera coordinate system into the
        ///  rectified second camera's image.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see @ref reprojectImageTo3D).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref CALIB_ZERO_DISPARITY . If the flag is set,
        ///  the function makes the principal points of each camera have the same pixel coordinates in the
        ///  rectified views. And if the flag is not set, the function may still shift the images in the
        ///  horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///  useful image area.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter. If it is -1 or absent, the function performs the default
        ///  scaling. Otherwise, the parameter should be between 0 and 1. alpha=0 means that the rectified
        ///  images are zoomed and shifted so that only valid pixels are visible (no black areas after
        ///  rectification). alpha=1 means that the rectified image is decimated and shifted so that all the
        ///  pixels from the original images from the cameras are retained in the rectified images (no source
        ///  image pixels are lost). Any intermediate value yields an intermediate result between
        ///  those two extreme cases.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///  #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///  is passed (default), it is set to the original imageSize . Setting it to a larger value can help you
        ///  preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="validPixROI1">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <param name="validPixROI2">
        /// Optional output rectangles inside the rectified images where all the pixels
        ///  are valid. If alpha=0 , the ROIs cover the whole images. Otherwise, they are likely to be smaller
        ///  (see the picture below).
        /// </param>
        /// <remarks>
        ///  The function computes the rotation matrices for each camera that (virtually) make both camera image
        ///  planes the same plane. Consequently, this makes all the epipolar lines parallel and thus simplifies
        ///  the dense stereo correspondence problem. The function takes the matrices computed by #stereoCalibrate
        ///  as input. As output, it provides two rotation matrices and also two projection matrices in the new
        ///  coordinates. The function distinguishes the following two cases:
        ///  
        ///  -   **Horizontal stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly along the x-axis (with possible small vertical shift). In the rectified images, the
        ///      corresponding epipolar lines in the left and right cameras are horizontal and have the same
        ///      y-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_1 &amp; 0 \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx_2 &amp; T_x \cdot f \\
        ///                          0 &amp; f &amp; cy &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix} ,\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx_1 \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_x} &amp; \frac{cx_1 - cx_2}{T_x}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_x\f$ is a horizontal shift between the cameras and \f$cx_1=cx_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  -   **Vertical stereo**: the first and the second camera views are shifted relative to each other
        ///      mainly in the vertical direction (and probably a bit in the horizontal direction too). The epipolar
        ///      lines in the rectified images are vertical and have the same x-coordinate. P1 and P2 look like:
        ///  
        ///      \f[\texttt{P1} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_1 &amp; 0 \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix}\f]
        ///  
        ///      \f[\texttt{P2} = \begin{bmatrix}
        ///                          f &amp; 0 &amp; cx &amp; 0 \\
        ///                          0 &amp; f &amp; cy_2 &amp; T_y \cdot f \\
        ///                          0 &amp; 0 &amp; 1 &amp; 0
        ///                       \end{bmatrix},\f]
        ///  
        ///      \f[\texttt{Q} = \begin{bmatrix}
        ///                          1 &amp; 0 &amp; 0 &amp; -cx \\
        ///                          0 &amp; 1 &amp; 0 &amp; -cy_1 \\
        ///                          0 &amp; 0 &amp; 0 &amp; f \\
        ///                          0 &amp; 0 &amp; -\frac{1}{T_y} &amp; \frac{cy_1 - cy_2}{T_y}
        ///                      \end{bmatrix} \f]
        ///  
        ///      where \f$T_y\f$ is a vertical shift between the cameras and \f$cy_1=cy_2\f$ if
        ///      @ref CALIB_ZERO_DISPARITY is set.
        ///  
        ///  As you can see, the first three columns of P1 and P2 will effectively be the new "rectified" camera
        ///  matrices. The matrices, together with R1 and R2 , can then be passed to #initUndistortRectifyMap to
        ///  initialize the rectification map for each camera.
        ///  
        ///  See below the screenshot from the stereo_calib.cpp sample. Some red horizontal lines pass through
        ///  the corresponding image regions. This means that the images are well rectified, which is what most
        ///  stereo correspondence algorithms rely on. The green rectangles are roi1 and roi2 . You see that
        ///  their interiors are all valid pixels.
        ///  
        ///  ![image](pics/stereo_undistort.jpg)
        /// </remarks>
        public static void stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_stereoRectify_15(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj);


        }


        //
        // C++:  bool cv::stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat& H1, Mat& H2, double threshold = 5)
        //

        /// <summary>
        ///  Computes a rectification transform for an uncalibrated stereo camera.
        /// </summary>
        /// <param name="points1">
        /// Array of feature points in the first image.
        /// </param>
        /// <param name="points2">
        /// The corresponding points in the second image. The same formats as in
        ///  #findFundamentalMat are supported.
        /// </param>
        /// <param name="F">
        /// Input fundamental matrix. It can be computed from the same set of point pairs using
        ///  #findFundamentalMat .
        /// </param>
        /// <param name="imgSize">
        /// Size of the image.
        /// </param>
        /// <param name="H1">
        /// Output rectification homography matrix for the first image.
        /// </param>
        /// <param name="H2">
        /// Output rectification homography matrix for the second image.
        /// </param>
        /// <param name="threshold">
        /// Optional threshold used to filter out the outliers. If the parameter is greater
        ///  than zero, all the point pairs that do not comply with the epipolar geometry (that is, the points
        ///  for which \f$|\texttt{points2[i]}^T \cdot \texttt{F} \cdot \texttt{points1[i]}|&gt;\texttt{threshold}\f$ )
        ///  are rejected prior to computing the homographies. Otherwise, all the points are considered inliers.
        /// </param>
        /// <remarks>
        ///  The function computes the rectification transformations without knowing intrinsic parameters of the
        ///  cameras and their relative position in the space, which explains the suffix "uncalibrated". Another
        ///  related difference from #stereoRectify is that the function outputs not the rectification
        ///  transformations in the object (3D) space, but the planar perspective transformations encoded by the
        ///  homography matrices H1 and H2 . The function implements the algorithm @cite Hartley99 .
        ///  
        ///  @note
        ///     While the algorithm does not need to know the intrinsic parameters of the cameras, it heavily
        ///      depends on the epipolar geometry. Therefore, if the camera lenses have a significant distortion,
        ///      it would be better to correct it before computing the fundamental matrix and calling this
        ///      function. For example, distortion coefficients can be estimated for each head of stereo camera
        ///      separately by using #calibrateCamera . Then, the images can be corrected using #undistort , or
        ///      just the point coordinates can be corrected with #undistortPoints .
        /// </remarks>
        public static bool stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat H1, Mat H2, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (H1 != null) H1.ThrowIfDisposed();
            if (H2 != null) H2.ThrowIfDisposed();

            return calib3d_Calib3d_stereoRectifyUncalibrated_10(points1.nativeObj, points2.nativeObj, F.nativeObj, imgSize.width, imgSize.height, H1.nativeObj, H2.nativeObj, threshold);


        }

        /// <summary>
        ///  Computes a rectification transform for an uncalibrated stereo camera.
        /// </summary>
        /// <param name="points1">
        /// Array of feature points in the first image.
        /// </param>
        /// <param name="points2">
        /// The corresponding points in the second image. The same formats as in
        ///  #findFundamentalMat are supported.
        /// </param>
        /// <param name="F">
        /// Input fundamental matrix. It can be computed from the same set of point pairs using
        ///  #findFundamentalMat .
        /// </param>
        /// <param name="imgSize">
        /// Size of the image.
        /// </param>
        /// <param name="H1">
        /// Output rectification homography matrix for the first image.
        /// </param>
        /// <param name="H2">
        /// Output rectification homography matrix for the second image.
        /// </param>
        /// <param name="threshold">
        /// Optional threshold used to filter out the outliers. If the parameter is greater
        ///  than zero, all the point pairs that do not comply with the epipolar geometry (that is, the points
        ///  for which \f$|\texttt{points2[i]}^T \cdot \texttt{F} \cdot \texttt{points1[i]}|&gt;\texttt{threshold}\f$ )
        ///  are rejected prior to computing the homographies. Otherwise, all the points are considered inliers.
        /// </param>
        /// <remarks>
        ///  The function computes the rectification transformations without knowing intrinsic parameters of the
        ///  cameras and their relative position in the space, which explains the suffix "uncalibrated". Another
        ///  related difference from #stereoRectify is that the function outputs not the rectification
        ///  transformations in the object (3D) space, but the planar perspective transformations encoded by the
        ///  homography matrices H1 and H2 . The function implements the algorithm @cite Hartley99 .
        ///  
        ///  @note
        ///     While the algorithm does not need to know the intrinsic parameters of the cameras, it heavily
        ///      depends on the epipolar geometry. Therefore, if the camera lenses have a significant distortion,
        ///      it would be better to correct it before computing the fundamental matrix and calling this
        ///      function. For example, distortion coefficients can be estimated for each head of stereo camera
        ///      separately by using #calibrateCamera . Then, the images can be corrected using #undistort , or
        ///      just the point coordinates can be corrected with #undistortPoints .
        /// </remarks>
        public static bool stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat H1, Mat H2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (H1 != null) H1.ThrowIfDisposed();
            if (H2 != null) H2.ThrowIfDisposed();

            return calib3d_Calib3d_stereoRectifyUncalibrated_11(points1.nativeObj, points2.nativeObj, F.nativeObj, imgSize.width, imgSize.height, H1.nativeObj, H2.nativeObj);


        }


        //
        // C++:  float cv::rectify3Collinear(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, vector_Mat imgpt1, vector_Mat imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat& R1, Mat& R2, Mat& R3, Mat& P1, Mat& P2, Mat& P3, Mat& Q, double alpha, Size newImgSize, Rect* roi1, Rect* roi2, int flags)
        //

        public static float rectify3Collinear(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, List<Mat> imgpt1, List<Mat> imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat R1, Mat R2, Mat R3, Mat P1, Mat P2, Mat P3, Mat Q, double alpha, Size newImgSize, Rect roi1, Rect roi2, int flags)
        {
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (cameraMatrix3 != null) cameraMatrix3.ThrowIfDisposed();
            if (distCoeffs3 != null) distCoeffs3.ThrowIfDisposed();
            if (R12 != null) R12.ThrowIfDisposed();
            if (T12 != null) T12.ThrowIfDisposed();
            if (R13 != null) R13.ThrowIfDisposed();
            if (T13 != null) T13.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (R3 != null) R3.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (P3 != null) P3.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();
            Mat imgpt1_mat = Converters.vector_Mat_to_Mat(imgpt1);
            Mat imgpt3_mat = Converters.vector_Mat_to_Mat(imgpt3);
            double[] roi1_out = new double[4];
            double[] roi2_out = new double[4];
            float retVal = calib3d_Calib3d_rectify3Collinear_10(cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, cameraMatrix3.nativeObj, distCoeffs3.nativeObj, imgpt1_mat.nativeObj, imgpt3_mat.nativeObj, imageSize.width, imageSize.height, R12.nativeObj, T12.nativeObj, R13.nativeObj, T13.nativeObj, R1.nativeObj, R2.nativeObj, R3.nativeObj, P1.nativeObj, P2.nativeObj, P3.nativeObj, Q.nativeObj, alpha, newImgSize.width, newImgSize.height, roi1_out, roi2_out, flags);
            if (roi1 != null) { roi1.x = (int)roi1_out[0]; roi1.y = (int)roi1_out[1]; roi1.width = (int)roi1_out[2]; roi1.height = (int)roi1_out[3]; }
            if (roi2 != null) { roi2.x = (int)roi2_out[0]; roi2.y = (int)roi2_out[1]; roi2.width = (int)roi2_out[2]; roi2.height = (int)roi2_out[3]; }
            return retVal;
        }


        //
        // C++:  Mat cv::getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize = Size(), Rect* validPixROI = 0, bool centerPrincipalPoint = false)
        //

        /// <summary>
        ///  Returns the new camera intrinsic matrix based on the free scaling parameter.
        /// </summary>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="imageSize">
        /// Original image size.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter between 0 (when all the pixels in the undistorted image are
        ///  valid) and 1 (when all the source image pixels are retained in the undistorted image). See
        ///  #stereoRectify for details.
        /// </param>
        /// <param name="newImgSize">
        /// Image size after rectification. By default, it is set to imageSize .
        /// </param>
        /// <param name="validPixROI">
        /// Optional output rectangle that outlines all-good-pixels region in the
        ///  undistorted image. See roi1, roi2 description in #stereoRectify .
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Optional flag that indicates whether in the new camera intrinsic matrix the
        ///  principal point should be at the image center or not. By default, the principal point is chosen to
        ///  best fit a subset of the source image (determined by alpha) to the corrected image.
        /// </param>
        /// <returns>
        ///  new_camera_matrix Output new camera intrinsic matrix.
        /// </returns>
        /// <remarks>
        ///  The function computes and returns the optimal new camera intrinsic matrix based on the free scaling parameter.
        ///  By varying this parameter, you may retrieve only sensible pixels alpha=0 , keep all the original
        ///  image pixels if there is valuable information in the corners alpha=1 , or get something in between.
        ///  When alpha&gt;0 , the undistorted result is likely to have some black pixels corresponding to
        ///  "virtual" pixels outside of the captured distorted image. The original camera intrinsic matrix, distortion
        ///  coefficients, the computed new camera intrinsic matrix, and newImageSize should be passed to
        ///  #initUndistortRectifyMap to produce the maps for #remap .
        /// </remarks>
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize, Rect validPixROI, bool centerPrincipalPoint)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            double[] validPixROI_out = new double[4];
            Mat retVal = new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getOptimalNewCameraMatrix_10(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha, newImgSize.width, newImgSize.height, validPixROI_out, centerPrincipalPoint)));
            if (validPixROI != null) { validPixROI.x = (int)validPixROI_out[0]; validPixROI.y = (int)validPixROI_out[1]; validPixROI.width = (int)validPixROI_out[2]; validPixROI.height = (int)validPixROI_out[3]; }
            return retVal;
        }

        /// <summary>
        ///  Returns the new camera intrinsic matrix based on the free scaling parameter.
        /// </summary>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="imageSize">
        /// Original image size.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter between 0 (when all the pixels in the undistorted image are
        ///  valid) and 1 (when all the source image pixels are retained in the undistorted image). See
        ///  #stereoRectify for details.
        /// </param>
        /// <param name="newImgSize">
        /// Image size after rectification. By default, it is set to imageSize .
        /// </param>
        /// <param name="validPixROI">
        /// Optional output rectangle that outlines all-good-pixels region in the
        ///  undistorted image. See roi1, roi2 description in #stereoRectify .
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Optional flag that indicates whether in the new camera intrinsic matrix the
        ///  principal point should be at the image center or not. By default, the principal point is chosen to
        ///  best fit a subset of the source image (determined by alpha) to the corrected image.
        /// </param>
        /// <returns>
        ///  new_camera_matrix Output new camera intrinsic matrix.
        /// </returns>
        /// <remarks>
        ///  The function computes and returns the optimal new camera intrinsic matrix based on the free scaling parameter.
        ///  By varying this parameter, you may retrieve only sensible pixels alpha=0 , keep all the original
        ///  image pixels if there is valuable information in the corners alpha=1 , or get something in between.
        ///  When alpha&gt;0 , the undistorted result is likely to have some black pixels corresponding to
        ///  "virtual" pixels outside of the captured distorted image. The original camera intrinsic matrix, distortion
        ///  coefficients, the computed new camera intrinsic matrix, and newImageSize should be passed to
        ///  #initUndistortRectifyMap to produce the maps for #remap .
        /// </remarks>
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize, Rect validPixROI)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            double[] validPixROI_out = new double[4];
            Mat retVal = new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getOptimalNewCameraMatrix_11(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha, newImgSize.width, newImgSize.height, validPixROI_out)));
            if (validPixROI != null) { validPixROI.x = (int)validPixROI_out[0]; validPixROI.y = (int)validPixROI_out[1]; validPixROI.width = (int)validPixROI_out[2]; validPixROI.height = (int)validPixROI_out[3]; }
            return retVal;
        }

        /// <summary>
        ///  Returns the new camera intrinsic matrix based on the free scaling parameter.
        /// </summary>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="imageSize">
        /// Original image size.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter between 0 (when all the pixels in the undistorted image are
        ///  valid) and 1 (when all the source image pixels are retained in the undistorted image). See
        ///  #stereoRectify for details.
        /// </param>
        /// <param name="newImgSize">
        /// Image size after rectification. By default, it is set to imageSize .
        /// </param>
        /// <param name="validPixROI">
        /// Optional output rectangle that outlines all-good-pixels region in the
        ///  undistorted image. See roi1, roi2 description in #stereoRectify .
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Optional flag that indicates whether in the new camera intrinsic matrix the
        ///  principal point should be at the image center or not. By default, the principal point is chosen to
        ///  best fit a subset of the source image (determined by alpha) to the corrected image.
        /// </param>
        /// <returns>
        ///  new_camera_matrix Output new camera intrinsic matrix.
        /// </returns>
        /// <remarks>
        ///  The function computes and returns the optimal new camera intrinsic matrix based on the free scaling parameter.
        ///  By varying this parameter, you may retrieve only sensible pixels alpha=0 , keep all the original
        ///  image pixels if there is valuable information in the corners alpha=1 , or get something in between.
        ///  When alpha&gt;0 , the undistorted result is likely to have some black pixels corresponding to
        ///  "virtual" pixels outside of the captured distorted image. The original camera intrinsic matrix, distortion
        ///  coefficients, the computed new camera intrinsic matrix, and newImageSize should be passed to
        ///  #initUndistortRectifyMap to produce the maps for #remap .
        /// </remarks>
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getOptimalNewCameraMatrix_12(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha, newImgSize.width, newImgSize.height)));


        }

        /// <summary>
        ///  Returns the new camera intrinsic matrix based on the free scaling parameter.
        /// </summary>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix.
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$\distcoeffs\f$. If the vector is NULL/empty, the zero distortion coefficients are
        ///  assumed.
        /// </param>
        /// <param name="imageSize">
        /// Original image size.
        /// </param>
        /// <param name="alpha">
        /// Free scaling parameter between 0 (when all the pixels in the undistorted image are
        ///  valid) and 1 (when all the source image pixels are retained in the undistorted image). See
        ///  #stereoRectify for details.
        /// </param>
        /// <param name="newImgSize">
        /// Image size after rectification. By default, it is set to imageSize .
        /// </param>
        /// <param name="validPixROI">
        /// Optional output rectangle that outlines all-good-pixels region in the
        ///  undistorted image. See roi1, roi2 description in #stereoRectify .
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Optional flag that indicates whether in the new camera intrinsic matrix the
        ///  principal point should be at the image center or not. By default, the principal point is chosen to
        ///  best fit a subset of the source image (determined by alpha) to the corrected image.
        /// </param>
        /// <returns>
        ///  new_camera_matrix Output new camera intrinsic matrix.
        /// </returns>
        /// <remarks>
        ///  The function computes and returns the optimal new camera intrinsic matrix based on the free scaling parameter.
        ///  By varying this parameter, you may retrieve only sensible pixels alpha=0 , keep all the original
        ///  image pixels if there is valuable information in the corners alpha=1 , or get something in between.
        ///  When alpha&gt;0 , the undistorted result is likely to have some black pixels corresponding to
        ///  "virtual" pixels outside of the captured distorted image. The original camera intrinsic matrix, distortion
        ///  coefficients, the computed new camera intrinsic matrix, and newImageSize should be passed to
        ///  #initUndistortRectifyMap to produce the maps for #remap .
        /// </remarks>
        public static Mat getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getOptimalNewCameraMatrix_13(cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, alpha)));


        }


        //
        // C++:  void cv::calibrateHandEye(vector_Mat R_gripper2base, vector_Mat t_gripper2base, vector_Mat R_target2cam, vector_Mat t_target2cam, Mat& R_cam2gripper, Mat& t_cam2gripper, HandEyeCalibrationMethod method = CALIB_HAND_EYE_TSAI)
        //

        /// <summary>
        ///  Computes Hand-Eye calibration: \f$_{}^{g}\textrm{T}_c\f$
        /// </summary>
        /// <remarks>
        ///  The function performs the Hand-Eye calibration using various methods. One approach consists in estimating the
        ///  rotation then the translation (separable solutions) and the following methods are implemented:
        ///    - R. Tsai, R. Lenz A New Technique for Fully Autonomous and Efficient 3D Robotics Hand/EyeCalibration \cite Tsai89
        ///    - F. Park, B. Martin Robot Sensor Calibration: Solving AX = XB on the Euclidean Group \cite Park94
        ///    - R. Horaud, F. Dornaika Hand-Eye Calibration \cite Horaud95
        ///  
        ///  Another approach consists in estimating simultaneously the rotation and the translation (simultaneous solutions),
        ///  with the following implemented methods:
        ///    - N. Andreff, R. Horaud, B. Espiau On-line Hand-Eye Calibration \cite Andreff99
        ///    - K. Daniilidis Hand-Eye Calibration Using Dual Quaternions \cite Daniilidis98
        ///  
        ///  The following picture describes the Hand-Eye calibration problem where the transformation between a camera ("eye")
        ///  mounted on a robot gripper ("hand") has to be estimated. This configuration is called eye-in-hand.
        ///  
        ///  The eye-to-hand configuration consists in a static camera observing a calibration pattern mounted on the robot
        ///  end-effector. The transformation from the camera to the robot base frame can then be estimated by inputting
        ///  the suitable transformations to the function, see below.
        ///  
        ///  ![](pics/hand-eye_figure.png)
        ///  
        ///  The calibration procedure is the following:
        ///    - a static calibration pattern is used to estimate the transformation between the target frame
        ///    and the camera frame
        ///    - the robot gripper is moved in order to acquire several poses
        ///    - for each pose, the homogeneous transformation between the gripper frame and the robot base frame is recorded using for
        ///    instance the robot kinematics
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_b\\
        ///      Y_b\\
        ///      Z_b\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{b}\textrm{R}_g &amp; _{}^{b}\textrm{t}_g \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///    - for each pose, the homogeneous transformation between the calibration target frame and the camera frame is recorded using
        ///    for instance a pose estimation method (PnP) from 2D-3D point correspondences
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{c}\textrm{R}_t &amp; _{}^{c}\textrm{t}_t \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_t\\
        ///      Y_t\\
        ///      Z_t\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  The Hand-Eye calibration procedure returns the following homogeneous transformation
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{g}\textrm{R}_c &amp; _{}^{g}\textrm{t}_c \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  This problem is also known as solving the \f$\mathbf{A}\mathbf{X}=\mathbf{X}\mathbf{B}\f$ equation:
        ///    - for an eye-in-hand configuration
        ///  \f[
        ///      \begin{align*}
        ///      ^{b}{\textrm{T}_g}^{(1)} \hspace{0.2em} ^{g}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(1)} &amp;=
        ///      \hspace{0.1em} ^{b}{\textrm{T}_g}^{(2)} \hspace{0.2em} ^{g}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} \\
        ///  
        ///      (^{b}{\textrm{T}_g}^{(2)})^{-1} \hspace{0.2em} ^{b}{\textrm{T}_g}^{(1)} \hspace{0.2em} ^{g}\textrm{T}_c &amp;=
        ///      \hspace{0.1em} ^{g}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} (^{c}{\textrm{T}_t}^{(1)})^{-1} \\
        ///  
        ///      \textrm{A}_i \textrm{X} &amp;= \textrm{X} \textrm{B}_i \\
        ///      \end{align*}
        ///  \f]
        ///  
        ///    - for an eye-to-hand configuration
        ///  \f[
        ///      \begin{align*}
        ///      ^{g}{\textrm{T}_b}^{(1)} \hspace{0.2em} ^{b}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(1)} &amp;=
        ///      \hspace{0.1em} ^{g}{\textrm{T}_b}^{(2)} \hspace{0.2em} ^{b}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} \\
        ///  
        ///      (^{g}{\textrm{T}_b}^{(2)})^{-1} \hspace{0.2em} ^{g}{\textrm{T}_b}^{(1)} \hspace{0.2em} ^{b}\textrm{T}_c &amp;=
        ///      \hspace{0.1em} ^{b}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} (^{c}{\textrm{T}_t}^{(1)})^{-1} \\
        ///  
        ///      \textrm{A}_i \textrm{X} &amp;= \textrm{X} \textrm{B}_i \\
        ///      \end{align*}
        ///  \f]
        ///  
        ///  \note
        ///  Additional information can be found on this [website](http://campar.in.tum.de/Chair/HandEyeCalibration).
        ///  \note
        ///  A minimum of 2 motions with non parallel rotation axes are necessary to determine the hand-eye transformation.
        ///  So at least 3 different poses are required, but it is strongly recommended to use many more poses.
        /// </remarks>
        public static void calibrateHandEye(List<Mat> R_gripper2base, List<Mat> t_gripper2base, List<Mat> R_target2cam, List<Mat> t_target2cam, Mat R_cam2gripper, Mat t_cam2gripper, int method)
        {
            if (R_cam2gripper != null) R_cam2gripper.ThrowIfDisposed();
            if (t_cam2gripper != null) t_cam2gripper.ThrowIfDisposed();
            Mat R_gripper2base_mat = Converters.vector_Mat_to_Mat(R_gripper2base);
            Mat t_gripper2base_mat = Converters.vector_Mat_to_Mat(t_gripper2base);
            Mat R_target2cam_mat = Converters.vector_Mat_to_Mat(R_target2cam);
            Mat t_target2cam_mat = Converters.vector_Mat_to_Mat(t_target2cam);
            calib3d_Calib3d_calibrateHandEye_10(R_gripper2base_mat.nativeObj, t_gripper2base_mat.nativeObj, R_target2cam_mat.nativeObj, t_target2cam_mat.nativeObj, R_cam2gripper.nativeObj, t_cam2gripper.nativeObj, method);


        }

        /// <summary>
        ///  Computes Hand-Eye calibration: \f$_{}^{g}\textrm{T}_c\f$
        /// </summary>
        /// <remarks>
        ///  The function performs the Hand-Eye calibration using various methods. One approach consists in estimating the
        ///  rotation then the translation (separable solutions) and the following methods are implemented:
        ///    - R. Tsai, R. Lenz A New Technique for Fully Autonomous and Efficient 3D Robotics Hand/EyeCalibration \cite Tsai89
        ///    - F. Park, B. Martin Robot Sensor Calibration: Solving AX = XB on the Euclidean Group \cite Park94
        ///    - R. Horaud, F. Dornaika Hand-Eye Calibration \cite Horaud95
        ///  
        ///  Another approach consists in estimating simultaneously the rotation and the translation (simultaneous solutions),
        ///  with the following implemented methods:
        ///    - N. Andreff, R. Horaud, B. Espiau On-line Hand-Eye Calibration \cite Andreff99
        ///    - K. Daniilidis Hand-Eye Calibration Using Dual Quaternions \cite Daniilidis98
        ///  
        ///  The following picture describes the Hand-Eye calibration problem where the transformation between a camera ("eye")
        ///  mounted on a robot gripper ("hand") has to be estimated. This configuration is called eye-in-hand.
        ///  
        ///  The eye-to-hand configuration consists in a static camera observing a calibration pattern mounted on the robot
        ///  end-effector. The transformation from the camera to the robot base frame can then be estimated by inputting
        ///  the suitable transformations to the function, see below.
        ///  
        ///  ![](pics/hand-eye_figure.png)
        ///  
        ///  The calibration procedure is the following:
        ///    - a static calibration pattern is used to estimate the transformation between the target frame
        ///    and the camera frame
        ///    - the robot gripper is moved in order to acquire several poses
        ///    - for each pose, the homogeneous transformation between the gripper frame and the robot base frame is recorded using for
        ///    instance the robot kinematics
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_b\\
        ///      Y_b\\
        ///      Z_b\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{b}\textrm{R}_g &amp; _{}^{b}\textrm{t}_g \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///    - for each pose, the homogeneous transformation between the calibration target frame and the camera frame is recorded using
        ///    for instance a pose estimation method (PnP) from 2D-3D point correspondences
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{c}\textrm{R}_t &amp; _{}^{c}\textrm{t}_t \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_t\\
        ///      Y_t\\
        ///      Z_t\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  The Hand-Eye calibration procedure returns the following homogeneous transformation
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{g}\textrm{R}_c &amp; _{}^{g}\textrm{t}_c \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  This problem is also known as solving the \f$\mathbf{A}\mathbf{X}=\mathbf{X}\mathbf{B}\f$ equation:
        ///    - for an eye-in-hand configuration
        ///  \f[
        ///      \begin{align*}
        ///      ^{b}{\textrm{T}_g}^{(1)} \hspace{0.2em} ^{g}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(1)} &amp;=
        ///      \hspace{0.1em} ^{b}{\textrm{T}_g}^{(2)} \hspace{0.2em} ^{g}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} \\
        ///  
        ///      (^{b}{\textrm{T}_g}^{(2)})^{-1} \hspace{0.2em} ^{b}{\textrm{T}_g}^{(1)} \hspace{0.2em} ^{g}\textrm{T}_c &amp;=
        ///      \hspace{0.1em} ^{g}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} (^{c}{\textrm{T}_t}^{(1)})^{-1} \\
        ///  
        ///      \textrm{A}_i \textrm{X} &amp;= \textrm{X} \textrm{B}_i \\
        ///      \end{align*}
        ///  \f]
        ///  
        ///    - for an eye-to-hand configuration
        ///  \f[
        ///      \begin{align*}
        ///      ^{g}{\textrm{T}_b}^{(1)} \hspace{0.2em} ^{b}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(1)} &amp;=
        ///      \hspace{0.1em} ^{g}{\textrm{T}_b}^{(2)} \hspace{0.2em} ^{b}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} \\
        ///  
        ///      (^{g}{\textrm{T}_b}^{(2)})^{-1} \hspace{0.2em} ^{g}{\textrm{T}_b}^{(1)} \hspace{0.2em} ^{b}\textrm{T}_c &amp;=
        ///      \hspace{0.1em} ^{b}\textrm{T}_c \hspace{0.2em} ^{c}{\textrm{T}_t}^{(2)} (^{c}{\textrm{T}_t}^{(1)})^{-1} \\
        ///  
        ///      \textrm{A}_i \textrm{X} &amp;= \textrm{X} \textrm{B}_i \\
        ///      \end{align*}
        ///  \f]
        ///  
        ///  \note
        ///  Additional information can be found on this [website](http://campar.in.tum.de/Chair/HandEyeCalibration).
        ///  \note
        ///  A minimum of 2 motions with non parallel rotation axes are necessary to determine the hand-eye transformation.
        ///  So at least 3 different poses are required, but it is strongly recommended to use many more poses.
        /// </remarks>
        public static void calibrateHandEye(List<Mat> R_gripper2base, List<Mat> t_gripper2base, List<Mat> R_target2cam, List<Mat> t_target2cam, Mat R_cam2gripper, Mat t_cam2gripper)
        {
            if (R_cam2gripper != null) R_cam2gripper.ThrowIfDisposed();
            if (t_cam2gripper != null) t_cam2gripper.ThrowIfDisposed();
            Mat R_gripper2base_mat = Converters.vector_Mat_to_Mat(R_gripper2base);
            Mat t_gripper2base_mat = Converters.vector_Mat_to_Mat(t_gripper2base);
            Mat R_target2cam_mat = Converters.vector_Mat_to_Mat(R_target2cam);
            Mat t_target2cam_mat = Converters.vector_Mat_to_Mat(t_target2cam);
            calib3d_Calib3d_calibrateHandEye_11(R_gripper2base_mat.nativeObj, t_gripper2base_mat.nativeObj, R_target2cam_mat.nativeObj, t_target2cam_mat.nativeObj, R_cam2gripper.nativeObj, t_cam2gripper.nativeObj);


        }


        //
        // C++:  void cv::calibrateRobotWorldHandEye(vector_Mat R_world2cam, vector_Mat t_world2cam, vector_Mat R_base2gripper, vector_Mat t_base2gripper, Mat& R_base2world, Mat& t_base2world, Mat& R_gripper2cam, Mat& t_gripper2cam, RobotWorldHandEyeCalibrationMethod method = CALIB_ROBOT_WORLD_HAND_EYE_SHAH)
        //

        /// <summary>
        ///  Computes Robot-World/Hand-Eye calibration: \f$_{}^{w}\textrm{T}_b\f$ and \f$_{}^{c}\textrm{T}_g\f$
        /// </summary>
        /// <remarks>
        ///  The function performs the Robot-World/Hand-Eye calibration using various methods. One approach consists in estimating the
        ///  rotation then the translation (separable solutions):
        ///    - M. Shah, Solving the robot-world/hand-eye calibration problem using the kronecker product \cite Shah2013SolvingTR
        ///  
        ///  Another approach consists in estimating simultaneously the rotation and the translation (simultaneous solutions),
        ///  with the following implemented method:
        ///    - A. Li, L. Wang, and D. Wu, Simultaneous robot-world and hand-eye calibration using dual-quaternions and kronecker product \cite Li2010SimultaneousRA
        ///  
        ///  The following picture describes the Robot-World/Hand-Eye calibration problem where the transformations between a robot and a world frame
        ///  and between a robot gripper ("hand") and a camera ("eye") mounted at the robot end-effector have to be estimated.
        ///  
        ///  ![](pics/robot-world_hand-eye_figure.png)
        ///  
        ///  The calibration procedure is the following:
        ///    - a static calibration pattern is used to estimate the transformation between the target frame
        ///    and the camera frame
        ///    - the robot gripper is moved in order to acquire several poses
        ///    - for each pose, the homogeneous transformation between the gripper frame and the robot base frame is recorded using for
        ///    instance the robot kinematics
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{g}\textrm{R}_b &amp; _{}^{g}\textrm{t}_b \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_b\\
        ///      Y_b\\
        ///      Z_b\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///    - for each pose, the homogeneous transformation between the calibration target frame (the world frame) and the camera frame is recorded using
        ///    for instance a pose estimation method (PnP) from 2D-3D point correspondences
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{c}\textrm{R}_w &amp; _{}^{c}\textrm{t}_w \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_w\\
        ///      Y_w\\
        ///      Z_w\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  The Robot-World/Hand-Eye calibration procedure returns the following homogeneous transformations
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_w\\
        ///      Y_w\\
        ///      Z_w\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{w}\textrm{R}_b &amp; _{}^{w}\textrm{t}_b \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_b\\
        ///      Y_b\\
        ///      Z_b\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{c}\textrm{R}_g &amp; _{}^{c}\textrm{t}_g \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  This problem is also known as solving the \f$\mathbf{A}\mathbf{X}=\mathbf{Z}\mathbf{B}\f$ equation, with:
        ///    - \f$\mathbf{A} \Leftrightarrow \hspace{0.1em} _{}^{c}\textrm{T}_w\f$
        ///    - \f$\mathbf{X} \Leftrightarrow \hspace{0.1em} _{}^{w}\textrm{T}_b\f$
        ///    - \f$\mathbf{Z} \Leftrightarrow \hspace{0.1em} _{}^{c}\textrm{T}_g\f$
        ///    - \f$\mathbf{B} \Leftrightarrow \hspace{0.1em} _{}^{g}\textrm{T}_b\f$
        ///  
        ///  \note
        ///  At least 3 measurements are required (input vectors size must be greater or equal to 3).
        /// </remarks>
        public static void calibrateRobotWorldHandEye(List<Mat> R_world2cam, List<Mat> t_world2cam, List<Mat> R_base2gripper, List<Mat> t_base2gripper, Mat R_base2world, Mat t_base2world, Mat R_gripper2cam, Mat t_gripper2cam, int method)
        {
            if (R_base2world != null) R_base2world.ThrowIfDisposed();
            if (t_base2world != null) t_base2world.ThrowIfDisposed();
            if (R_gripper2cam != null) R_gripper2cam.ThrowIfDisposed();
            if (t_gripper2cam != null) t_gripper2cam.ThrowIfDisposed();
            Mat R_world2cam_mat = Converters.vector_Mat_to_Mat(R_world2cam);
            Mat t_world2cam_mat = Converters.vector_Mat_to_Mat(t_world2cam);
            Mat R_base2gripper_mat = Converters.vector_Mat_to_Mat(R_base2gripper);
            Mat t_base2gripper_mat = Converters.vector_Mat_to_Mat(t_base2gripper);
            calib3d_Calib3d_calibrateRobotWorldHandEye_10(R_world2cam_mat.nativeObj, t_world2cam_mat.nativeObj, R_base2gripper_mat.nativeObj, t_base2gripper_mat.nativeObj, R_base2world.nativeObj, t_base2world.nativeObj, R_gripper2cam.nativeObj, t_gripper2cam.nativeObj, method);


        }

        /// <summary>
        ///  Computes Robot-World/Hand-Eye calibration: \f$_{}^{w}\textrm{T}_b\f$ and \f$_{}^{c}\textrm{T}_g\f$
        /// </summary>
        /// <remarks>
        ///  The function performs the Robot-World/Hand-Eye calibration using various methods. One approach consists in estimating the
        ///  rotation then the translation (separable solutions):
        ///    - M. Shah, Solving the robot-world/hand-eye calibration problem using the kronecker product \cite Shah2013SolvingTR
        ///  
        ///  Another approach consists in estimating simultaneously the rotation and the translation (simultaneous solutions),
        ///  with the following implemented method:
        ///    - A. Li, L. Wang, and D. Wu, Simultaneous robot-world and hand-eye calibration using dual-quaternions and kronecker product \cite Li2010SimultaneousRA
        ///  
        ///  The following picture describes the Robot-World/Hand-Eye calibration problem where the transformations between a robot and a world frame
        ///  and between a robot gripper ("hand") and a camera ("eye") mounted at the robot end-effector have to be estimated.
        ///  
        ///  ![](pics/robot-world_hand-eye_figure.png)
        ///  
        ///  The calibration procedure is the following:
        ///    - a static calibration pattern is used to estimate the transformation between the target frame
        ///    and the camera frame
        ///    - the robot gripper is moved in order to acquire several poses
        ///    - for each pose, the homogeneous transformation between the gripper frame and the robot base frame is recorded using for
        ///    instance the robot kinematics
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{g}\textrm{R}_b &amp; _{}^{g}\textrm{t}_b \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_b\\
        ///      Y_b\\
        ///      Z_b\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///    - for each pose, the homogeneous transformation between the calibration target frame (the world frame) and the camera frame is recorded using
        ///    for instance a pose estimation method (PnP) from 2D-3D point correspondences
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{c}\textrm{R}_w &amp; _{}^{c}\textrm{t}_w \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_w\\
        ///      Y_w\\
        ///      Z_w\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  The Robot-World/Hand-Eye calibration procedure returns the following homogeneous transformations
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_w\\
        ///      Y_w\\
        ///      Z_w\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{w}\textrm{R}_b &amp; _{}^{w}\textrm{t}_b \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_b\\
        ///      Y_b\\
        ///      Z_b\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  \f[
        ///      \begin{bmatrix}
        ///      X_c\\
        ///      Y_c\\
        ///      Z_c\\
        ///      1
        ///      \end{bmatrix}
        ///      =
        ///      \begin{bmatrix}
        ///      _{}^{c}\textrm{R}_g &amp; _{}^{c}\textrm{t}_g \\
        ///      0_{1 \times 3} &amp; 1
        ///      \end{bmatrix}
        ///      \begin{bmatrix}
        ///      X_g\\
        ///      Y_g\\
        ///      Z_g\\
        ///      1
        ///      \end{bmatrix}
        ///  \f]
        ///  
        ///  This problem is also known as solving the \f$\mathbf{A}\mathbf{X}=\mathbf{Z}\mathbf{B}\f$ equation, with:
        ///    - \f$\mathbf{A} \Leftrightarrow \hspace{0.1em} _{}^{c}\textrm{T}_w\f$
        ///    - \f$\mathbf{X} \Leftrightarrow \hspace{0.1em} _{}^{w}\textrm{T}_b\f$
        ///    - \f$\mathbf{Z} \Leftrightarrow \hspace{0.1em} _{}^{c}\textrm{T}_g\f$
        ///    - \f$\mathbf{B} \Leftrightarrow \hspace{0.1em} _{}^{g}\textrm{T}_b\f$
        ///  
        ///  \note
        ///  At least 3 measurements are required (input vectors size must be greater or equal to 3).
        /// </remarks>
        public static void calibrateRobotWorldHandEye(List<Mat> R_world2cam, List<Mat> t_world2cam, List<Mat> R_base2gripper, List<Mat> t_base2gripper, Mat R_base2world, Mat t_base2world, Mat R_gripper2cam, Mat t_gripper2cam)
        {
            if (R_base2world != null) R_base2world.ThrowIfDisposed();
            if (t_base2world != null) t_base2world.ThrowIfDisposed();
            if (R_gripper2cam != null) R_gripper2cam.ThrowIfDisposed();
            if (t_gripper2cam != null) t_gripper2cam.ThrowIfDisposed();
            Mat R_world2cam_mat = Converters.vector_Mat_to_Mat(R_world2cam);
            Mat t_world2cam_mat = Converters.vector_Mat_to_Mat(t_world2cam);
            Mat R_base2gripper_mat = Converters.vector_Mat_to_Mat(R_base2gripper);
            Mat t_base2gripper_mat = Converters.vector_Mat_to_Mat(t_base2gripper);
            calib3d_Calib3d_calibrateRobotWorldHandEye_11(R_world2cam_mat.nativeObj, t_world2cam_mat.nativeObj, R_base2gripper_mat.nativeObj, t_base2gripper_mat.nativeObj, R_base2world.nativeObj, t_base2world.nativeObj, R_gripper2cam.nativeObj, t_gripper2cam.nativeObj);


        }


        //
        // C++:  void cv::convertPointsToHomogeneous(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Converts points from Euclidean to homogeneous space.
        /// </summary>
        /// <param name="src">
        /// Input vector of N-dimensional points.
        /// </param>
        /// <param name="dst">
        /// Output vector of N+1-dimensional points.
        /// </param>
        /// <remarks>
        ///  The function converts points from Euclidean to homogeneous space by appending 1's to the tuple of
        ///  point coordinates. That is, each point (x1, x2, ..., xn) is converted to (x1, x2, ..., xn, 1).
        /// </remarks>
        public static void convertPointsToHomogeneous(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            calib3d_Calib3d_convertPointsToHomogeneous_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::convertPointsFromHomogeneous(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Converts points from homogeneous to Euclidean space.
        /// </summary>
        /// <param name="src">
        /// Input vector of N-dimensional points.
        /// </param>
        /// <param name="dst">
        /// Output vector of N-1-dimensional points.
        /// </param>
        /// <remarks>
        ///  The function converts points homogeneous to Euclidean space using perspective projection. That is,
        ///  each point (x1, x2, ... x(n-1), xn) is converted to (x1/xn, x2/xn, ..., x(n-1)/xn). When xn=0, the
        ///  output point coordinates will be (0,0,0,...).
        /// </remarks>
        public static void convertPointsFromHomogeneous(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            calib3d_Calib3d_convertPointsFromHomogeneous_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, int method, double ransacReprojThreshold, double confidence, int maxIters, Mat& mask = Mat())
        //

        /// <summary>
        ///  Calculates a fundamental matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref FM_7POINT for a 7-point algorithm. \f$N = 7\f$
        ///  -   @ref FM_8POINT for an 8-point algorithm. \f$N \ge 8\f$
        ///  -   @ref FM_RANSAC for the RANSAC algorithm. \f$N \ge 8\f$
        ///  -   @ref FM_LMEDS for the LMedS algorithm. \f$N \ge 8\f$
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Parameter used only for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="confidence">
        /// Parameter used for the RANSAC and LMedS methods only. It specifies a desirable level
        ///  of confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T F [p_1; 1] = 0\f]
        ///  
        ///  where \f$F\f$ is a fundamental matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively.
        ///  
        ///  The function calculates the fundamental matrix using one of four methods listed above and returns
        ///  the found fundamental matrix. Normally just one matrix is found. But in case of the 7-point
        ///  algorithm, the function may return up to 3 solutions ( \f$9 \times 3\f$ matrix that stores all 3
        ///  matrices sequentially).
        ///  
        ///  The calculated fundamental matrix may be passed further to #computeCorrespondEpilines that finds the
        ///  epipolar lines corresponding to the specified points. It can also be passed to
        ///  #stereoRectifyUncalibrated to compute the rectification transformation. :
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      Mat fundamental_matrix =
        ///       findFundamentalMat(points1, points2, FM_RANSAC, 3, 0.99);
        /// </code>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold, double confidence, int maxIters, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_10(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold, confidence, maxIters, mask.nativeObj)));


        }

        /// <summary>
        ///  Calculates a fundamental matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref FM_7POINT for a 7-point algorithm. \f$N = 7\f$
        ///  -   @ref FM_8POINT for an 8-point algorithm. \f$N \ge 8\f$
        ///  -   @ref FM_RANSAC for the RANSAC algorithm. \f$N \ge 8\f$
        ///  -   @ref FM_LMEDS for the LMedS algorithm. \f$N \ge 8\f$
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Parameter used only for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="confidence">
        /// Parameter used for the RANSAC and LMedS methods only. It specifies a desirable level
        ///  of confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T F [p_1; 1] = 0\f]
        ///  
        ///  where \f$F\f$ is a fundamental matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively.
        ///  
        ///  The function calculates the fundamental matrix using one of four methods listed above and returns
        ///  the found fundamental matrix. Normally just one matrix is found. But in case of the 7-point
        ///  algorithm, the function may return up to 3 solutions ( \f$9 \times 3\f$ matrix that stores all 3
        ///  matrices sequentially).
        ///  
        ///  The calculated fundamental matrix may be passed further to #computeCorrespondEpilines that finds the
        ///  epipolar lines corresponding to the specified points. It can also be passed to
        ///  #stereoRectifyUncalibrated to compute the rectification transformation. :
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      Mat fundamental_matrix =
        ///       findFundamentalMat(points1, points2, FM_RANSAC, 3, 0.99);
        /// </code>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold, double confidence, int maxIters)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_11(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold, confidence, maxIters)));


        }


        //
        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, int method = FM_RANSAC, double ransacReprojThreshold = 3., double confidence = 0.99, Mat& mask = Mat())
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold, double confidence, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_12(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold, confidence, mask.nativeObj)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold, double confidence)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_13(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold, confidence)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method, double ransacReprojThreshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_14(points1_mat.nativeObj, points2_mat.nativeObj, method, ransacReprojThreshold)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_15(points1_mat.nativeObj, points2_mat.nativeObj, method)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_16(points1_mat.nativeObj, points2_mat.nativeObj)));


        }


        //
        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, Mat& mask, UsacParams _params)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static Mat findFundamentalMat(MatOfPoint2f points1, MatOfPoint2f points2, Mat mask, UsacParams _params)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();
            Mat points1_mat = points1;
            Mat points2_mat = points2;
            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findFundamentalMat_17(points1_mat.nativeObj, points2_mat.nativeObj, mask.nativeObj, _params.nativeObj)));


        }


        //
        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method = RANSAC, double prob = 0.999, double threshold = 1.0, int maxIters = 1000, Mat& mask = Mat())
        //

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix. If this assumption does not hold for your use case, use another
        ///  function overload or #undistortPoints with `P = cv::NoArray()` for both cameras to transform image
        ///  points to normalized image coordinates, which are valid for the identity camera intrinsic matrix.
        ///  When passing these coordinates, pass the identity matrix for this parameter.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold, int maxIters, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_10(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob, threshold, maxIters, mask.nativeObj)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix. If this assumption does not hold for your use case, use another
        ///  function overload or #undistortPoints with `P = cv::NoArray()` for both cameras to transform image
        ///  points to normalized image coordinates, which are valid for the identity camera intrinsic matrix.
        ///  When passing these coordinates, pass the identity matrix for this parameter.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold, int maxIters)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_11(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob, threshold, maxIters)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix. If this assumption does not hold for your use case, use another
        ///  function overload or #undistortPoints with `P = cv::NoArray()` for both cameras to transform image
        ///  points to normalized image coordinates, which are valid for the identity camera intrinsic matrix.
        ///  When passing these coordinates, pass the identity matrix for this parameter.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_12(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob, threshold)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix. If this assumption does not hold for your use case, use another
        ///  function overload or #undistortPoints with `P = cv::NoArray()` for both cameras to transform image
        ///  points to normalized image coordinates, which are valid for the identity camera intrinsic matrix.
        ///  When passing these coordinates, pass the identity matrix for this parameter.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method, double prob)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_13(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method, prob)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix. If this assumption does not hold for your use case, use another
        ///  function overload or #undistortPoints with `P = cv::NoArray()` for both cameras to transform image
        ///  points to normalized image coordinates, which are valid for the identity camera intrinsic matrix.
        ///  When passing these coordinates, pass the identity matrix for this parameter.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_14(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, method)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix. If this assumption does not hold for your use case, use another
        ///  function overload or #undistortPoints with `P = cv::NoArray()` for both cameras to transform image
        ///  points to normalized image coordinates, which are valid for the identity camera intrinsic matrix.
        ///  When passing these coordinates, pass the identity matrix for this parameter.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_15(points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj)));


        }


        //
        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, double focal = 1.0, Point2d pp = Point2d(0, 0), int method = RANSAC, double prob = 0.999, double threshold = 1.0, int maxIters = 1000, Mat& mask = Mat())
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob, double threshold, int maxIters, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_16(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob, threshold, maxIters, mask.nativeObj)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob, double threshold, int maxIters)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_17(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob, threshold, maxIters)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_18(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob, threshold)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method, double prob)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_19(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method, prob)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_110(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y, method)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal, Point pp)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_111(points1.nativeObj, points2.nativeObj, focal, pp.x, pp.y)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, double focal)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_112(points1.nativeObj, points2.nativeObj, focal)));


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="focal">
        /// focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="method">
        /// Method for computing a fundamental matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_113(points1.nativeObj, points2.nativeObj)));


        }


        //
        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method = RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        //

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images from potentially two different cameras.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Camera matrix for the first camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="cameraMatrix2">
        /// Camera matrix for the second camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs1">
        /// Input vector of distortion coefficients for the first camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input vector of distortion coefficients for the second camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or  #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method, double prob, double threshold, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_114(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, method, prob, threshold, mask.nativeObj)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images from potentially two different cameras.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Camera matrix for the first camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="cameraMatrix2">
        /// Camera matrix for the second camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs1">
        /// Input vector of distortion coefficients for the first camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input vector of distortion coefficients for the second camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or  #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method, double prob, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_115(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, method, prob, threshold)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images from potentially two different cameras.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Camera matrix for the first camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="cameraMatrix2">
        /// Camera matrix for the second camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs1">
        /// Input vector of distortion coefficients for the first camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input vector of distortion coefficients for the second camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or  #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method, double prob)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_116(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, method, prob)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images from potentially two different cameras.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Camera matrix for the first camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="cameraMatrix2">
        /// Camera matrix for the second camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs1">
        /// Input vector of distortion coefficients for the first camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input vector of distortion coefficients for the second camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or  #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_117(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, method)));


        }

        /// <summary>
        ///  Calculates an essential matrix from the corresponding points in two images from potentially two different cameras.
        /// </summary>
        /// <param name="points1">
        /// Array of N (N &gt;= 5) 2D points from the first image. The point coordinates should
        ///  be floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix1">
        /// Camera matrix for the first camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="cameraMatrix2">
        /// Camera matrix for the second camera \f$K = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs1">
        /// Input vector of distortion coefficients for the first camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input vector of distortion coefficients for the second camera
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Output array of N elements, every element of which is set to 0 for outliers and to 1
        ///  for the other points. The array is computed only in the RANSAC and LMedS methods.
        /// </param>
        /// <remarks>
        ///  This function estimates essential matrix based on the five-point algorithm solver in @cite Nister03 .
        ///  @cite SteweniusCFS is also a related. The epipolar geometry is described by the following equation:
        ///  
        ///  \f[[p_2; 1]^T K^{-T} E K^{-1} [p_1; 1] = 0\f]
        ///  
        ///  where \f$E\f$ is an essential matrix, \f$p_1\f$ and \f$p_2\f$ are corresponding points in the first and the
        ///  second images, respectively. The result of this function may be passed further to
        ///  #decomposeEssentialMat or  #recoverPose to recover the relative pose between cameras.
        /// </remarks>
        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_118(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj)));


        }


        //
        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat cameraMatrix2, Mat dist_coeff1, Mat dist_coeff2, Mat& mask, UsacParams _params)
        //

        public static Mat findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat cameraMatrix2, Mat dist_coeff1, Mat dist_coeff2, Mat mask, UsacParams _params)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (dist_coeff1 != null) dist_coeff1.ThrowIfDisposed();
            if (dist_coeff2 != null) dist_coeff2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_findEssentialMat_119(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, cameraMatrix2.nativeObj, dist_coeff1.nativeObj, dist_coeff2.nativeObj, mask.nativeObj, _params.nativeObj)));


        }


        //
        // C++:  void cv::decomposeEssentialMat(Mat E, Mat& R1, Mat& R2, Mat& t)
        //

        /// <summary>
        ///  Decompose an essential matrix to possible rotations and translation.
        /// </summary>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="R1">
        /// One possible rotation matrix.
        /// </param>
        /// <param name="R2">
        /// Another possible rotation matrix.
        /// </param>
        /// <param name="t">
        /// One possible translation.
        /// </param>
        /// <remarks>
        ///  This function decomposes the essential matrix E using svd decomposition @cite HartleyZ00. In
        ///  general, four possible poses exist for the decomposition of E. They are \f$[R_1, t]\f$,
        ///  \f$[R_1, -t]\f$, \f$[R_2, t]\f$, \f$[R_2, -t]\f$.
        ///  
        ///  If E gives the epipolar constraint \f$[p_2; 1]^T A^{-T} E A^{-1} [p_1; 1] = 0\f$ between the image
        ///  points \f$p_1\f$ in the first image and \f$p_2\f$ in second image, then any of the tuples
        ///  \f$[R_1, t]\f$, \f$[R_1, -t]\f$, \f$[R_2, t]\f$, \f$[R_2, -t]\f$ is a change of basis from the first
        ///  camera's coordinate system to the second camera's coordinate system. However, by decomposing E, one
        ///  can only get the direction of the translation. For this reason, the translation t is returned with
        ///  unit length.
        /// </remarks>
        public static void decomposeEssentialMat(Mat E, Mat R1, Mat R2, Mat t)
        {
            if (E != null) E.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            calib3d_Calib3d_decomposeEssentialMat_10(E.nativeObj, R1.nativeObj, R2.nativeObj, t.nativeObj);


        }


        //
        // C++:  int cv::recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat& E, Mat& R, Mat& t, int method = cv::RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        //

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from corresponding points in two images from two different cameras, using cheirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="E">
        /// The output essential matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for then given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the cheirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing cheirality check. The cheirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for findEssentialMat.:
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // Input: camera calibration of both cameras, for example using intrinsic chessboard calibration.
        ///      Mat cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2;
        ///  
        ///      // Output: Essential matrix, relative rotation and relative translation.
        ///      Mat E, R, t, mask;
        ///  
        ///      recoverPose(points1, points2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, E, R, t, mask);
        /// </code>
        public static int recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method, double prob, double threshold, Mat mask)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_10(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, E.nativeObj, R.nativeObj, t.nativeObj, method, prob, threshold, mask.nativeObj);


        }

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from corresponding points in two images from two different cameras, using cheirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="E">
        /// The output essential matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for then given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the cheirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing cheirality check. The cheirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for findEssentialMat.:
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // Input: camera calibration of both cameras, for example using intrinsic chessboard calibration.
        ///      Mat cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2;
        ///  
        ///      // Output: Essential matrix, relative rotation and relative translation.
        ///      Mat E, R, t, mask;
        ///  
        ///      recoverPose(points1, points2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, E, R, t, mask);
        /// </code>
        public static int recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method, double prob, double threshold)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_11(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, E.nativeObj, R.nativeObj, t.nativeObj, method, prob, threshold);


        }

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from corresponding points in two images from two different cameras, using cheirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="E">
        /// The output essential matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for then given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the cheirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing cheirality check. The cheirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for findEssentialMat.:
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // Input: camera calibration of both cameras, for example using intrinsic chessboard calibration.
        ///      Mat cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2;
        ///  
        ///      // Output: Essential matrix, relative rotation and relative translation.
        ///      Mat E, R, t, mask;
        ///  
        ///      recoverPose(points1, points2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, E, R, t, mask);
        /// </code>
        public static int recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method, double prob)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_12(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, E.nativeObj, R.nativeObj, t.nativeObj, method, prob);


        }

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from corresponding points in two images from two different cameras, using cheirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="E">
        /// The output essential matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for then given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the cheirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing cheirality check. The cheirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for findEssentialMat.:
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // Input: camera calibration of both cameras, for example using intrinsic chessboard calibration.
        ///      Mat cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2;
        ///  
        ///      // Output: Essential matrix, relative rotation and relative translation.
        ///      Mat E, R, t, mask;
        ///  
        ///      recoverPose(points1, points2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, E, R, t, mask);
        /// </code>
        public static int recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t, int method)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_13(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, E.nativeObj, R.nativeObj, t.nativeObj, method);


        }

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from corresponding points in two images from two different cameras, using cheirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix1">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs1">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="cameraMatrix2">
        /// Input/output camera matrix for the first camera, the same as in
        ///  @ref calibrateCamera. Furthermore, for the stereo case, additional flags may be used, see below.
        /// </param>
        /// <param name="distCoeffs2">
        /// Input/output vector of distortion coefficients, the same as in
        ///  @ref calibrateCamera.
        /// </param>
        /// <param name="E">
        /// The output essential matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="method">
        /// Method for computing an essential matrix.
        ///  -   @ref RANSAC for the RANSAC algorithm.
        ///  -   @ref LMEDS for the LMedS algorithm.
        /// </param>
        /// <param name="prob">
        /// Parameter used for the RANSAC or LMedS methods only. It specifies a desirable level of
        ///  confidence (probability) that the estimated matrix is correct.
        /// </param>
        /// <param name="threshold">
        /// Parameter used for RANSAC. It is the maximum distance from a point to an epipolar
        ///  line in pixels, beyond which the point is considered an outlier and is not used for computing the
        ///  final fundamental matrix. It can be set to something like 1-3, depending on the accuracy of the
        ///  point localization, image resolution, and the image noise.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for then given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the cheirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing cheirality check. The cheirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for findEssentialMat.:
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // Input: camera calibration of both cameras, for example using intrinsic chessboard calibration.
        ///      Mat cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2;
        ///  
        ///      // Output: Essential matrix, relative rotation and relative translation.
        ///      Mat E, R, t, mask;
        ///  
        ///      recoverPose(points1, points2, cameraMatrix1, distCoeffs1, cameraMatrix2, distCoeffs2, E, R, t, mask);
        /// </code>
        public static int recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat E, Mat R, Mat t)
        {
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix1 != null) cameraMatrix1.ThrowIfDisposed();
            if (distCoeffs1 != null) distCoeffs1.ThrowIfDisposed();
            if (cameraMatrix2 != null) cameraMatrix2.ThrowIfDisposed();
            if (distCoeffs2 != null) distCoeffs2.ThrowIfDisposed();
            if (E != null) E.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_14(points1.nativeObj, points2.nativeObj, cameraMatrix1.nativeObj, distCoeffs1.nativeObj, cameraMatrix2.nativeObj, distCoeffs2.nativeObj, E.nativeObj, R.nativeObj, t.nativeObj);


        }


        //
        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, Mat& mask = Mat())
        //

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from an estimated essential
        ///  matrix and the corresponding points in two images, using chirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing chirality check. The chirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for #findEssentialMat :
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // cametra matrix with both focal lengths = 1, and principal point = (0, 0)
        ///      Mat cameraMatrix = Mat::eye(3, 3, CV_64F);
        ///  
        ///      Mat E, R, t, mask;
        ///  
        ///      E = findEssentialMat(points1, points2, cameraMatrix, RANSAC, 0.999, 1.0, mask);
        ///      recoverPose(E, points1, points2, cameraMatrix, R, t, mask);
        /// </code>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, Mat mask)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_15(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///  Recovers the relative camera rotation and the translation from an estimated essential
        ///  matrix and the corresponding points in two images, using chirality check. Returns the number of
        ///  inliers that pass the check.
        /// </summary>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  described below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <remarks>
        ///  This function decomposes an essential matrix using @ref decomposeEssentialMat and then verifies
        ///  possible pose hypotheses by doing chirality check. The chirality check means that the
        ///  triangulated 3D points should have positive depth. Some details can be found in @cite Nister03.
        ///  
        ///  This function can be used to process the output E and mask from @ref findEssentialMat. In this
        ///  scenario, points1 and points2 are the same input for #findEssentialMat :
        /// </remarks>
        /// <code language="c++">
        ///      // Example. Estimation of fundamental matrix using the RANSAC algorithm
        ///      int point_count = 100;
        ///      vector&lt;Point2f&gt; points1(point_count);
        ///      vector&lt;Point2f&gt; points2(point_count);
        ///  
        ///      // initialize the points here ...
        ///      for( int i = 0; i &lt; point_count; i++ )
        ///      {
        ///          points1[i] = ...;
        ///          points2[i] = ...;
        ///      }
        ///  
        ///      // cametra matrix with both focal lengths = 1, and principal point = (0, 0)
        ///      Mat cameraMatrix = Mat::eye(3, 3, CV_64F);
        ///  
        ///      Mat E, R, t, mask;
        ///  
        ///      E = findEssentialMat(points1, points2, cameraMatrix, RANSAC, 0.999, 1.0, mask);
        ///      recoverPose(E, points1, points2, cameraMatrix, R, t, mask);
        /// </code>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_16(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj);


        }


        //
        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat& R, Mat& t, double focal = 1.0, Point2d pp = Point2d(0, 0), Mat& mask = Mat())
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="focal">
        /// Focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal, Point pp, Mat mask)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_17(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj, focal, pp.x, pp.y, mask.nativeObj);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="focal">
        /// Focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal, Point pp)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_18(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj, focal, pp.x, pp.y);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="focal">
        /// Focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t, double focal)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_19(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj, focal);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1 .
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="focal">
        /// Focal length of the camera. Note that this function assumes that points1 and points2
        ///  are feature points from cameras with same focal length and principal point.
        /// </param>
        /// <param name="pp">
        /// principal point of the camera.
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it computes camera intrinsic matrix from focal length and
        ///  principal point:
        ///  
        ///  \f[A =
        ///  \begin{bmatrix}
        ///  f &amp; 0 &amp; x_{pp}  \\
        ///  0 &amp; f &amp; y_{pp}  \\
        ///  0 &amp; 0 &amp; 1
        ///  \end{bmatrix}\f]
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat R, Mat t)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_110(E.nativeObj, points1.nativeObj, points2.nativeObj, R.nativeObj, t.nativeObj);


        }


        //
        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, double distanceThresh, Mat& mask = Mat(), Mat& triangulatedPoints = Mat())
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="distanceThresh">
        /// threshold distance which is used to filter out far away points (i.e. infinite
        ///  points).
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <param name="triangulatedPoints">
        /// 3D points which were reconstructed by triangulation.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it outputs the triangulated 3D point that are used for
        ///  the chirality check.
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh, Mat mask, Mat triangulatedPoints)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (triangulatedPoints != null) triangulatedPoints.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_111(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, distanceThresh, mask.nativeObj, triangulatedPoints.nativeObj);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="distanceThresh">
        /// threshold distance which is used to filter out far away points (i.e. infinite
        ///  points).
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <param name="triangulatedPoints">
        /// 3D points which were reconstructed by triangulation.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it outputs the triangulated 3D point that are used for
        ///  the chirality check.
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh, Mat mask)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_112(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, distanceThresh, mask.nativeObj);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="E">
        /// The input essential matrix.
        /// </param>
        /// <param name="points1">
        /// Array of N 2D points from the first image. The point coordinates should be
        ///  floating-point (single or double precision).
        /// </param>
        /// <param name="points2">
        /// Array of the second image points of the same size and format as points1.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        ///  Note that this function assumes that points1 and points2 are feature points from cameras with the
        ///  same camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix. Together with the translation vector, this matrix makes up a tuple
        ///  that performs a change of basis from the first camera's coordinate system to the second camera's
        ///  coordinate system. Note that, in general, t can not be used for this tuple, see the parameter
        ///  description below.
        /// </param>
        /// <param name="t">
        /// Output translation vector. This vector is obtained by @ref decomposeEssentialMat and
        ///  therefore is only known up to scale, i.e. t is the direction of the translation vector and has unit
        ///  length.
        /// </param>
        /// <param name="distanceThresh">
        /// threshold distance which is used to filter out far away points (i.e. infinite
        ///  points).
        /// </param>
        /// <param name="mask">
        /// Input/output mask for inliers in points1 and points2. If it is not empty, then it marks
        ///  inliers in points1 and points2 for the given essential matrix E. Only these inliers will be used to
        ///  recover pose. In the output mask only inliers which pass the chirality check.
        /// </param>
        /// <param name="triangulatedPoints">
        /// 3D points which were reconstructed by triangulation.
        /// </param>
        /// <remarks>
        ///  This function differs from the one above that it outputs the triangulated 3D point that are used for
        ///  the chirality check.
        /// </remarks>
        public static int recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat R, Mat t, double distanceThresh)
        {
            if (E != null) E.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (t != null) t.ThrowIfDisposed();

            return calib3d_Calib3d_recoverPose_113(E.nativeObj, points1.nativeObj, points2.nativeObj, cameraMatrix.nativeObj, R.nativeObj, t.nativeObj, distanceThresh);


        }


        //
        // C++:  void cv::computeCorrespondEpilines(Mat points, int whichImage, Mat F, Mat& lines)
        //

        /// <summary>
        ///  For points in an image of a stereo pair, computes the corresponding epilines in the other image.
        /// </summary>
        /// <param name="points">
        /// Input points. \f$N \times 1\f$ or \f$1 \times N\f$ matrix of type CV_32FC2 or
        ///  vector&lt;Point2f&gt; .
        /// </param>
        /// <param name="whichImage">
        /// Index of the image (1 or 2) that contains the points .
        /// </param>
        /// <param name="F">
        /// Fundamental matrix that can be estimated using #findFundamentalMat or #stereoRectify .
        /// </param>
        /// <param name="lines">
        /// Output vector of the epipolar lines corresponding to the points in the other image.
        ///  Each line \f$ax + by + c=0\f$ is encoded by 3 numbers \f$(a, b, c)\f$ .
        /// </param>
        /// <remarks>
        ///  For every point in one of the two images of a stereo pair, the function finds the equation of the
        ///  corresponding epipolar line in the other image.
        ///  
        ///  From the fundamental matrix definition (see #findFundamentalMat ), line \f$l^{(2)}_i\f$ in the second
        ///  image for the point \f$p^{(1)}_i\f$ in the first image (when whichImage=1 ) is computed as:
        ///  
        ///  \f[l^{(2)}_i = F p^{(1)}_i\f]
        ///  
        ///  And vice versa, when whichImage=2, \f$l^{(1)}_i\f$ is computed from \f$p^{(2)}_i\f$ as:
        ///  
        ///  \f[l^{(1)}_i = F^T p^{(2)}_i\f]
        ///  
        ///  Line coefficients are defined up to a scale. They are normalized so that \f$a_i^2+b_i^2=1\f$ .
        /// </remarks>
        public static void computeCorrespondEpilines(Mat points, int whichImage, Mat F, Mat lines)
        {
            if (points != null) points.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();

            calib3d_Calib3d_computeCorrespondEpilines_10(points.nativeObj, whichImage, F.nativeObj, lines.nativeObj);


        }


        //
        // C++:  void cv::triangulatePoints(Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat& points4D)
        //

        /// <summary>
        ///  This function reconstructs 3-dimensional points (in homogeneous coordinates) by using
        ///  their observations with a stereo camera.
        /// </summary>
        /// <param name="projMatr1">
        /// 3x4 projection matrix of the first camera, i.e. this matrix projects 3D points
        ///  given in the world's coordinate system into the first image.
        /// </param>
        /// <param name="projMatr2">
        /// 3x4 projection matrix of the second camera, i.e. this matrix projects 3D points
        ///  given in the world's coordinate system into the second image.
        /// </param>
        /// <param name="projPoints1">
        /// 2xN array of feature points in the first image. In the case of the c++ version,
        ///  it can be also a vector of feature points or two-channel matrix of size 1xN or Nx1.
        /// </param>
        /// <param name="projPoints2">
        /// 2xN array of corresponding points in the second image. In the case of the c++
        ///  version, it can be also a vector of feature points or two-channel matrix of size 1xN or Nx1.
        /// </param>
        /// <param name="points4D">
        /// 4xN array of reconstructed points in homogeneous coordinates. These points are
        ///  returned in the world's coordinate system.
        /// </param>
        /// <remarks>
        ///  @note
        ///     Keep in mind that all input data should be of float type in order for this function to work.
        ///  
        ///  @note
        ///     If the projection matrices from @ref stereoRectify are used, then the returned points are
        ///     represented in the first camera's rectified coordinate system.
        ///  
        ///  @sa
        ///     reprojectImageTo3D
        /// </remarks>
        public static void triangulatePoints(Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat points4D)
        {
            if (projMatr1 != null) projMatr1.ThrowIfDisposed();
            if (projMatr2 != null) projMatr2.ThrowIfDisposed();
            if (projPoints1 != null) projPoints1.ThrowIfDisposed();
            if (projPoints2 != null) projPoints2.ThrowIfDisposed();
            if (points4D != null) points4D.ThrowIfDisposed();

            calib3d_Calib3d_triangulatePoints_10(projMatr1.nativeObj, projMatr2.nativeObj, projPoints1.nativeObj, projPoints2.nativeObj, points4D.nativeObj);


        }


        //
        // C++:  void cv::correctMatches(Mat F, Mat points1, Mat points2, Mat& newPoints1, Mat& newPoints2)
        //

        /// <summary>
        ///  Refines coordinates of corresponding points.
        /// </summary>
        /// <param name="F">
        /// 3x3 fundamental matrix.
        /// </param>
        /// <param name="points1">
        /// 1xN array containing the first set of points.
        /// </param>
        /// <param name="points2">
        /// 1xN array containing the second set of points.
        /// </param>
        /// <param name="newPoints1">
        /// The optimized points1.
        /// </param>
        /// <param name="newPoints2">
        /// The optimized points2.
        /// </param>
        /// <remarks>
        ///  The function implements the Optimal Triangulation Method (see Multiple View Geometry @cite HartleyZ00 for details).
        ///  For each given point correspondence points1[i] &lt;-&gt; points2[i], and a fundamental matrix F, it
        ///  computes the corrected correspondences newPoints1[i] &lt;-&gt; newPoints2[i] that minimize the geometric
        ///  error \f$d(points1[i], newPoints1[i])^2 + d(points2[i],newPoints2[i])^2\f$ (where \f$d(a,b)\f$ is the
        ///  geometric distance between points \f$a\f$ and \f$b\f$ ) subject to the epipolar constraint
        ///  \f$newPoints2^T \cdot F \cdot newPoints1 = 0\f$ .
        /// </remarks>
        public static void correctMatches(Mat F, Mat points1, Mat points2, Mat newPoints1, Mat newPoints2)
        {
            if (F != null) F.ThrowIfDisposed();
            if (points1 != null) points1.ThrowIfDisposed();
            if (points2 != null) points2.ThrowIfDisposed();
            if (newPoints1 != null) newPoints1.ThrowIfDisposed();
            if (newPoints2 != null) newPoints2.ThrowIfDisposed();

            calib3d_Calib3d_correctMatches_10(F.nativeObj, points1.nativeObj, points2.nativeObj, newPoints1.nativeObj, newPoints2.nativeObj);


        }


        //
        // C++:  void cv::filterSpeckles(Mat& img, double newVal, int maxSpeckleSize, double maxDiff, Mat& buf = Mat())
        //

        /// <summary>
        ///  Filters off small noise blobs (speckles) in the disparity map
        /// </summary>
        /// <param name="img">
        /// The input 16-bit signed disparity image
        /// </param>
        /// <param name="newVal">
        /// The disparity value used to paint-off the speckles
        /// </param>
        /// <param name="maxSpeckleSize">
        /// The maximum speckle size to consider it a speckle. Larger blobs are not
        ///  affected by the algorithm
        /// </param>
        /// <param name="maxDiff">
        /// Maximum difference between neighbor disparity pixels to put them into the same
        ///  blob. Note that since StereoBM, StereoSGBM and may be other algorithms return a fixed-point
        ///  disparity map, where disparity values are multiplied by 16, this scale factor should be taken into
        ///  account when specifying this parameter value.
        /// </param>
        /// <param name="buf">
        /// The optional temporary buffer to avoid memory allocation within the function.
        /// </param>
        public static void filterSpeckles(Mat img, double newVal, int maxSpeckleSize, double maxDiff, Mat buf)
        {
            if (img != null) img.ThrowIfDisposed();
            if (buf != null) buf.ThrowIfDisposed();

            calib3d_Calib3d_filterSpeckles_10(img.nativeObj, newVal, maxSpeckleSize, maxDiff, buf.nativeObj);


        }

        /// <summary>
        ///  Filters off small noise blobs (speckles) in the disparity map
        /// </summary>
        /// <param name="img">
        /// The input 16-bit signed disparity image
        /// </param>
        /// <param name="newVal">
        /// The disparity value used to paint-off the speckles
        /// </param>
        /// <param name="maxSpeckleSize">
        /// The maximum speckle size to consider it a speckle. Larger blobs are not
        ///  affected by the algorithm
        /// </param>
        /// <param name="maxDiff">
        /// Maximum difference between neighbor disparity pixels to put them into the same
        ///  blob. Note that since StereoBM, StereoSGBM and may be other algorithms return a fixed-point
        ///  disparity map, where disparity values are multiplied by 16, this scale factor should be taken into
        ///  account when specifying this parameter value.
        /// </param>
        /// <param name="buf">
        /// The optional temporary buffer to avoid memory allocation within the function.
        /// </param>
        public static void filterSpeckles(Mat img, double newVal, int maxSpeckleSize, double maxDiff)
        {
            if (img != null) img.ThrowIfDisposed();

            calib3d_Calib3d_filterSpeckles_11(img.nativeObj, newVal, maxSpeckleSize, maxDiff);


        }


        //
        // C++:  Rect cv::getValidDisparityROI(Rect roi1, Rect roi2, int minDisparity, int numberOfDisparities, int blockSize)
        //

        public static Rect getValidDisparityROI(Rect roi1, Rect roi2, int minDisparity, int numberOfDisparities, int blockSize)
        {


            double[] tmpArray = new double[4];
            calib3d_Calib3d_getValidDisparityROI_10(roi1.x, roi1.y, roi1.width, roi1.height, roi2.x, roi2.y, roi2.width, roi2.height, minDisparity, numberOfDisparities, blockSize, tmpArray);
            Rect retVal = new Rect(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::validateDisparity(Mat& disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp = 1)
        //

        public static void validateDisparity(Mat disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (cost != null) cost.ThrowIfDisposed();

            calib3d_Calib3d_validateDisparity_10(disparity.nativeObj, cost.nativeObj, minDisparity, numberOfDisparities, disp12MaxDisp);


        }

        public static void validateDisparity(Mat disparity, Mat cost, int minDisparity, int numberOfDisparities)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (cost != null) cost.ThrowIfDisposed();

            calib3d_Calib3d_validateDisparity_11(disparity.nativeObj, cost.nativeObj, minDisparity, numberOfDisparities);


        }


        //
        // C++:  void cv::reprojectImageTo3D(Mat disparity, Mat& _3dImage, Mat Q, bool handleMissingValues = false, int ddepth = -1)
        //

        /// <summary>
        ///  Reprojects a disparity image to 3D space.
        /// </summary>
        /// <param name="disparity">
        /// Input single-channel 8-bit unsigned, 16-bit signed, 32-bit signed or 32-bit
        ///  floating-point disparity image. The values of 8-bit / 16-bit signed formats are assumed to have no
        ///  fractional bits. If the disparity is 16-bit signed format, as computed by @ref StereoBM or
        ///  @ref StereoSGBM and maybe other algorithms, it should be divided by 16 (and scaled to float) before
        ///  being used here.
        /// </param>
        /// <param name="_3dImage">
        /// Output 3-channel floating-point image of the same size as disparity. Each element of
        ///  _3dImage(x,y) contains 3D coordinates of the point (x,y) computed from the disparity map. If one
        ///  uses Q obtained by @ref stereoRectify, then the returned points are represented in the first
        ///  camera's rectified coordinate system.
        /// </param>
        /// <param name="Q">
        /// \f$4 \times 4\f$ perspective transformation matrix that can be obtained with
        ///  @ref stereoRectify.
        /// </param>
        /// <param name="handleMissingValues">
        /// Indicates, whether the function should handle missing values (i.e.
        ///  points where the disparity was not computed). If handleMissingValues=true, then pixels with the
        ///  minimal disparity that corresponds to the outliers (see StereoMatcher::compute ) are transformed
        ///  to 3D points with a very large Z value (currently set to 10000).
        /// </param>
        /// <param name="ddepth">
        /// The optional output array depth. If it is -1, the output image will have CV_32F
        ///  depth. ddepth can also be set to CV_16S, CV_32S or CV_32F.
        /// </param>
        /// <remarks>
        ///  The function transforms a single-channel disparity map to a 3-channel image representing a 3D
        ///  surface. That is, for each pixel (x,y) and the corresponding disparity d=disparity(x,y) , it
        ///  computes:
        ///  
        ///  \f[\begin{bmatrix}
        ///  X \\
        ///  Y \\
        ///  Z \\
        ///  W
        ///  \end{bmatrix} = Q \begin{bmatrix}
        ///  x \\
        ///  y \\
        ///  \texttt{disparity} (x,y) \\
        ///  1
        ///  \end{bmatrix}.\f]
        ///  
        ///  @sa
        ///     To reproject a sparse set of points {(x,y,d),...} to 3D space, use perspectiveTransform.
        /// </remarks>
        public static void reprojectImageTo3D(Mat disparity, Mat _3dImage, Mat Q, bool handleMissingValues, int ddepth)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (_3dImage != null) _3dImage.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_reprojectImageTo3D_10(disparity.nativeObj, _3dImage.nativeObj, Q.nativeObj, handleMissingValues, ddepth);


        }

        /// <summary>
        ///  Reprojects a disparity image to 3D space.
        /// </summary>
        /// <param name="disparity">
        /// Input single-channel 8-bit unsigned, 16-bit signed, 32-bit signed or 32-bit
        ///  floating-point disparity image. The values of 8-bit / 16-bit signed formats are assumed to have no
        ///  fractional bits. If the disparity is 16-bit signed format, as computed by @ref StereoBM or
        ///  @ref StereoSGBM and maybe other algorithms, it should be divided by 16 (and scaled to float) before
        ///  being used here.
        /// </param>
        /// <param name="_3dImage">
        /// Output 3-channel floating-point image of the same size as disparity. Each element of
        ///  _3dImage(x,y) contains 3D coordinates of the point (x,y) computed from the disparity map. If one
        ///  uses Q obtained by @ref stereoRectify, then the returned points are represented in the first
        ///  camera's rectified coordinate system.
        /// </param>
        /// <param name="Q">
        /// \f$4 \times 4\f$ perspective transformation matrix that can be obtained with
        ///  @ref stereoRectify.
        /// </param>
        /// <param name="handleMissingValues">
        /// Indicates, whether the function should handle missing values (i.e.
        ///  points where the disparity was not computed). If handleMissingValues=true, then pixels with the
        ///  minimal disparity that corresponds to the outliers (see StereoMatcher::compute ) are transformed
        ///  to 3D points with a very large Z value (currently set to 10000).
        /// </param>
        /// <param name="ddepth">
        /// The optional output array depth. If it is -1, the output image will have CV_32F
        ///  depth. ddepth can also be set to CV_16S, CV_32S or CV_32F.
        /// </param>
        /// <remarks>
        ///  The function transforms a single-channel disparity map to a 3-channel image representing a 3D
        ///  surface. That is, for each pixel (x,y) and the corresponding disparity d=disparity(x,y) , it
        ///  computes:
        ///  
        ///  \f[\begin{bmatrix}
        ///  X \\
        ///  Y \\
        ///  Z \\
        ///  W
        ///  \end{bmatrix} = Q \begin{bmatrix}
        ///  x \\
        ///  y \\
        ///  \texttt{disparity} (x,y) \\
        ///  1
        ///  \end{bmatrix}.\f]
        ///  
        ///  @sa
        ///     To reproject a sparse set of points {(x,y,d),...} to 3D space, use perspectiveTransform.
        /// </remarks>
        public static void reprojectImageTo3D(Mat disparity, Mat _3dImage, Mat Q, bool handleMissingValues)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (_3dImage != null) _3dImage.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_reprojectImageTo3D_11(disparity.nativeObj, _3dImage.nativeObj, Q.nativeObj, handleMissingValues);


        }

        /// <summary>
        ///  Reprojects a disparity image to 3D space.
        /// </summary>
        /// <param name="disparity">
        /// Input single-channel 8-bit unsigned, 16-bit signed, 32-bit signed or 32-bit
        ///  floating-point disparity image. The values of 8-bit / 16-bit signed formats are assumed to have no
        ///  fractional bits. If the disparity is 16-bit signed format, as computed by @ref StereoBM or
        ///  @ref StereoSGBM and maybe other algorithms, it should be divided by 16 (and scaled to float) before
        ///  being used here.
        /// </param>
        /// <param name="_3dImage">
        /// Output 3-channel floating-point image of the same size as disparity. Each element of
        ///  _3dImage(x,y) contains 3D coordinates of the point (x,y) computed from the disparity map. If one
        ///  uses Q obtained by @ref stereoRectify, then the returned points are represented in the first
        ///  camera's rectified coordinate system.
        /// </param>
        /// <param name="Q">
        /// \f$4 \times 4\f$ perspective transformation matrix that can be obtained with
        ///  @ref stereoRectify.
        /// </param>
        /// <param name="handleMissingValues">
        /// Indicates, whether the function should handle missing values (i.e.
        ///  points where the disparity was not computed). If handleMissingValues=true, then pixels with the
        ///  minimal disparity that corresponds to the outliers (see StereoMatcher::compute ) are transformed
        ///  to 3D points with a very large Z value (currently set to 10000).
        /// </param>
        /// <param name="ddepth">
        /// The optional output array depth. If it is -1, the output image will have CV_32F
        ///  depth. ddepth can also be set to CV_16S, CV_32S or CV_32F.
        /// </param>
        /// <remarks>
        ///  The function transforms a single-channel disparity map to a 3-channel image representing a 3D
        ///  surface. That is, for each pixel (x,y) and the corresponding disparity d=disparity(x,y) , it
        ///  computes:
        ///  
        ///  \f[\begin{bmatrix}
        ///  X \\
        ///  Y \\
        ///  Z \\
        ///  W
        ///  \end{bmatrix} = Q \begin{bmatrix}
        ///  x \\
        ///  y \\
        ///  \texttt{disparity} (x,y) \\
        ///  1
        ///  \end{bmatrix}.\f]
        ///  
        ///  @sa
        ///     To reproject a sparse set of points {(x,y,d),...} to 3D space, use perspectiveTransform.
        /// </remarks>
        public static void reprojectImageTo3D(Mat disparity, Mat _3dImage, Mat Q)
        {
            if (disparity != null) disparity.ThrowIfDisposed();
            if (_3dImage != null) _3dImage.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_reprojectImageTo3D_12(disparity.nativeObj, _3dImage.nativeObj, Q.nativeObj);


        }


        //
        // C++:  double cv::sampsonDistance(Mat pt1, Mat pt2, Mat F)
        //

        /// <summary>
        ///  Calculates the Sampson Distance between two points.
        /// </summary>
        /// <remarks>
        ///  The function cv::sampsonDistance calculates and returns the first order approximation of the geometric error as:
        ///  \f[
        ///  sd( \texttt{pt1} , \texttt{pt2} )=
        ///  \frac{(\texttt{pt2}^t \cdot \texttt{F} \cdot \texttt{pt1})^2}
        ///  {((\texttt{F} \cdot \texttt{pt1})(0))^2 +
        ///  ((\texttt{F} \cdot \texttt{pt1})(1))^2 +
        ///  ((\texttt{F}^t \cdot \texttt{pt2})(0))^2 +
        ///  ((\texttt{F}^t \cdot \texttt{pt2})(1))^2}
        ///  \f]
        ///  The fundamental matrix may be calculated using the #findFundamentalMat function. See @cite HartleyZ00 11.4.3 for details.
        /// </remarks>
        /// <param name="pt1">
        /// first homogeneous 2d point
        /// </param>
        /// <param name="pt2">
        /// second homogeneous 2d point
        /// </param>
        /// <param name="F">
        /// fundamental matrix
        /// </param>
        /// <returns>
        ///  The computed Sampson distance.
        /// </returns>
        public static double sampsonDistance(Mat pt1, Mat pt2, Mat F)
        {
            if (pt1 != null) pt1.ThrowIfDisposed();
            if (pt2 != null) pt2.ThrowIfDisposed();
            if (F != null) F.ThrowIfDisposed();

            return calib3d_Calib3d_sampsonDistance_10(pt1.nativeObj, pt2.nativeObj, F.nativeObj);


        }


        //
        // C++:  int cv::estimateAffine3D(Mat src, Mat dst, Mat& _out, Mat& inliers, double ransacThreshold = 3, double confidence = 0.99)
        //

        /// <summary>
        ///  Computes an optimal affine transformation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  z\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; a_{13}\\
        ///  a_{21} &amp; a_{22} &amp; a_{23}\\
        ///  a_{31} &amp; a_{32} &amp; a_{33}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  Z\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  b_3\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set containing \f$(X,Y,Z)\f$.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set containing \f$(x,y,z)\f$.
        /// </param>
        /// <param name="out">
        /// Output 3D affine transformation matrix \f$3 \times 4\f$ of the form
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; a_{13} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; a_{23} &amp; b_2\\
        ///  a_{31} &amp; a_{32} &amp; a_{33} &amp; b_3\\
        ///  \end{bmatrix}
        ///  \f]
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="ransacThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider a point as
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <remarks>
        ///  The function estimates an optimal 3D affine transformation between two 3D point sets using the
        ///  RANSAC algorithm.
        /// </remarks>
        public static int estimateAffine3D(Mat src, Mat dst, Mat _out, Mat inliers, double ransacThreshold, double confidence)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return calib3d_Calib3d_estimateAffine3D_10(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj, ransacThreshold, confidence);


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  z\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; a_{13}\\
        ///  a_{21} &amp; a_{22} &amp; a_{23}\\
        ///  a_{31} &amp; a_{32} &amp; a_{33}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  Z\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  b_3\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set containing \f$(X,Y,Z)\f$.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set containing \f$(x,y,z)\f$.
        /// </param>
        /// <param name="out">
        /// Output 3D affine transformation matrix \f$3 \times 4\f$ of the form
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; a_{13} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; a_{23} &amp; b_2\\
        ///  a_{31} &amp; a_{32} &amp; a_{33} &amp; b_3\\
        ///  \end{bmatrix}
        ///  \f]
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="ransacThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider a point as
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <remarks>
        ///  The function estimates an optimal 3D affine transformation between two 3D point sets using the
        ///  RANSAC algorithm.
        /// </remarks>
        public static int estimateAffine3D(Mat src, Mat dst, Mat _out, Mat inliers, double ransacThreshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return calib3d_Calib3d_estimateAffine3D_11(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj, ransacThreshold);


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  z\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; a_{13}\\
        ///  a_{21} &amp; a_{22} &amp; a_{23}\\
        ///  a_{31} &amp; a_{32} &amp; a_{33}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  Z\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  b_3\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set containing \f$(X,Y,Z)\f$.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set containing \f$(x,y,z)\f$.
        /// </param>
        /// <param name="out">
        /// Output 3D affine transformation matrix \f$3 \times 4\f$ of the form
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; a_{13} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; a_{23} &amp; b_2\\
        ///  a_{31} &amp; a_{32} &amp; a_{33} &amp; b_3\\
        ///  \end{bmatrix}
        ///  \f]
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="ransacThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider a point as
        ///  an inlier.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <remarks>
        ///  The function estimates an optimal 3D affine transformation between two 3D point sets using the
        ///  RANSAC algorithm.
        /// </remarks>
        public static int estimateAffine3D(Mat src, Mat dst, Mat _out, Mat inliers)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return calib3d_Calib3d_estimateAffine3D_12(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj);


        }


        //
        // C++:  Mat cv::estimateAffine3D(Mat src, Mat dst, double* scale = nullptr, bool force_rotation = true)
        //

        /// <summary>
        ///  Computes an optimal affine transformation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes \f$R,s,t\f$ minimizing \f$\sum{i} dst_i - c \cdot R \cdot src_i \f$
        ///  where \f$R\f$ is a 3x3 rotation matrix, \f$t\f$ is a 3x1 translation vector and \f$s\f$ is a
        ///  scalar size value. This is an implementation of the algorithm by Umeyama \cite umeyama1991least .
        ///  The estimated affine transform has a homogeneous scale which is a subclass of affine
        ///  transformations with 7 degrees of freedom. The paired point sets need to comprise at least 3
        ///  points each.
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set.
        /// </param>
        /// <param name="scale">
        /// If null is passed, the scale parameter c will be assumed to be 1.0.
        ///  Else the pointed-to variable will be set to the optimal scale.
        /// </param>
        /// <param name="force_rotation">
        /// If true, the returned rotation will never be a reflection.
        ///  This might be unwanted, e.g. when optimizing a transform between a right- and a
        ///  left-handed coordinate system.
        /// </param>
        /// <returns>
        ///  3D affine transformation matrix \f$3 \times 4\f$ of the form
        ///  \f[T =
        ///  \begin{bmatrix}
        ///  R &amp; t\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        public static Mat estimateAffine3D(Mat src, Mat dst, double[] scale, bool force_rotation)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            double[] scale_out = new double[1];
            Mat retVal = new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine3D_13(src.nativeObj, dst.nativeObj, scale_out, force_rotation)));
            if (scale != null) scale[0] = (double)scale_out[0];
            return retVal;
        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes \f$R,s,t\f$ minimizing \f$\sum{i} dst_i - c \cdot R \cdot src_i \f$
        ///  where \f$R\f$ is a 3x3 rotation matrix, \f$t\f$ is a 3x1 translation vector and \f$s\f$ is a
        ///  scalar size value. This is an implementation of the algorithm by Umeyama \cite umeyama1991least .
        ///  The estimated affine transform has a homogeneous scale which is a subclass of affine
        ///  transformations with 7 degrees of freedom. The paired point sets need to comprise at least 3
        ///  points each.
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set.
        /// </param>
        /// <param name="scale">
        /// If null is passed, the scale parameter c will be assumed to be 1.0.
        ///  Else the pointed-to variable will be set to the optimal scale.
        /// </param>
        /// <param name="force_rotation">
        /// If true, the returned rotation will never be a reflection.
        ///  This might be unwanted, e.g. when optimizing a transform between a right- and a
        ///  left-handed coordinate system.
        /// </param>
        /// <returns>
        ///  3D affine transformation matrix \f$3 \times 4\f$ of the form
        ///  \f[T =
        ///  \begin{bmatrix}
        ///  R &amp; t\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        public static Mat estimateAffine3D(Mat src, Mat dst, double[] scale)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            double[] scale_out = new double[1];
            Mat retVal = new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine3D_14(src.nativeObj, dst.nativeObj, scale_out)));
            if (scale != null) scale[0] = (double)scale_out[0];
            return retVal;
        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes \f$R,s,t\f$ minimizing \f$\sum{i} dst_i - c \cdot R \cdot src_i \f$
        ///  where \f$R\f$ is a 3x3 rotation matrix, \f$t\f$ is a 3x1 translation vector and \f$s\f$ is a
        ///  scalar size value. This is an implementation of the algorithm by Umeyama \cite umeyama1991least .
        ///  The estimated affine transform has a homogeneous scale which is a subclass of affine
        ///  transformations with 7 degrees of freedom. The paired point sets need to comprise at least 3
        ///  points each.
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set.
        /// </param>
        /// <param name="scale">
        /// If null is passed, the scale parameter c will be assumed to be 1.0.
        ///  Else the pointed-to variable will be set to the optimal scale.
        /// </param>
        /// <param name="force_rotation">
        /// If true, the returned rotation will never be a reflection.
        ///  This might be unwanted, e.g. when optimizing a transform between a right- and a
        ///  left-handed coordinate system.
        /// </param>
        /// <returns>
        ///  3D affine transformation matrix \f$3 \times 4\f$ of the form
        ///  \f[T =
        ///  \begin{bmatrix}
        ///  R &amp; t\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        public static Mat estimateAffine3D(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine3D_15(src.nativeObj, dst.nativeObj)));


        }


        //
        // C++:  int cv::estimateTranslation3D(Mat src, Mat dst, Mat& _out, Mat& inliers, double ransacThreshold = 3, double confidence = 0.99)
        //

        /// <summary>
        ///  Computes an optimal translation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///     It computes
        ///     \f[
        ///     \begin{bmatrix}
        ///     x\\
        ///     y\\
        ///     z\\
        ///     \end{bmatrix}
        ///     =
        ///     \begin{bmatrix}
        ///     X\\
        ///     Y\\
        ///     Z\\
        ///     \end{bmatrix}
        ///     +
        ///     \begin{bmatrix}
        ///     b_1\\
        ///     b_2\\
        ///     b_3\\
        ///     \end{bmatrix}
        ///     \f]
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set containing \f$(X,Y,Z)\f$.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set containing \f$(x,y,z)\f$.
        /// </param>
        /// <param name="out">
        /// Output 3D translation vector \f$3 \times 1\f$ of the form
        ///     \f[
        ///     \begin{bmatrix}
        ///     b_1 \\
        ///     b_2 \\
        ///     b_3 \\
        ///     \end{bmatrix}
        ///     \f]
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="ransacThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider a point as
        ///     an inlier.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///     between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///     significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <remarks>
        ///     The function estimates an optimal 3D translation between two 3D point sets using the
        ///     RANSAC algorithm.
        /// </remarks>
        public static int estimateTranslation3D(Mat src, Mat dst, Mat _out, Mat inliers, double ransacThreshold, double confidence)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return calib3d_Calib3d_estimateTranslation3D_10(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj, ransacThreshold, confidence);


        }

        /// <summary>
        ///  Computes an optimal translation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///     It computes
        ///     \f[
        ///     \begin{bmatrix}
        ///     x\\
        ///     y\\
        ///     z\\
        ///     \end{bmatrix}
        ///     =
        ///     \begin{bmatrix}
        ///     X\\
        ///     Y\\
        ///     Z\\
        ///     \end{bmatrix}
        ///     +
        ///     \begin{bmatrix}
        ///     b_1\\
        ///     b_2\\
        ///     b_3\\
        ///     \end{bmatrix}
        ///     \f]
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set containing \f$(X,Y,Z)\f$.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set containing \f$(x,y,z)\f$.
        /// </param>
        /// <param name="out">
        /// Output 3D translation vector \f$3 \times 1\f$ of the form
        ///     \f[
        ///     \begin{bmatrix}
        ///     b_1 \\
        ///     b_2 \\
        ///     b_3 \\
        ///     \end{bmatrix}
        ///     \f]
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="ransacThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider a point as
        ///     an inlier.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///     between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///     significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <remarks>
        ///     The function estimates an optimal 3D translation between two 3D point sets using the
        ///     RANSAC algorithm.
        /// </remarks>
        public static int estimateTranslation3D(Mat src, Mat dst, Mat _out, Mat inliers, double ransacThreshold)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return calib3d_Calib3d_estimateTranslation3D_11(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj, ransacThreshold);


        }

        /// <summary>
        ///  Computes an optimal translation between two 3D point sets.
        /// </summary>
        /// <remarks>
        ///     It computes
        ///     \f[
        ///     \begin{bmatrix}
        ///     x\\
        ///     y\\
        ///     z\\
        ///     \end{bmatrix}
        ///     =
        ///     \begin{bmatrix}
        ///     X\\
        ///     Y\\
        ///     Z\\
        ///     \end{bmatrix}
        ///     +
        ///     \begin{bmatrix}
        ///     b_1\\
        ///     b_2\\
        ///     b_3\\
        ///     \end{bmatrix}
        ///     \f]
        /// </remarks>
        /// <param name="src">
        /// First input 3D point set containing \f$(X,Y,Z)\f$.
        /// </param>
        /// <param name="dst">
        /// Second input 3D point set containing \f$(x,y,z)\f$.
        /// </param>
        /// <param name="out">
        /// Output 3D translation vector \f$3 \times 1\f$ of the form
        ///     \f[
        ///     \begin{bmatrix}
        ///     b_1 \\
        ///     b_2 \\
        ///     b_3 \\
        ///     \end{bmatrix}
        ///     \f]
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="ransacThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider a point as
        ///     an inlier.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///     between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///     significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <remarks>
        ///     The function estimates an optimal 3D translation between two 3D point sets using the
        ///     RANSAC algorithm.
        /// </remarks>
        public static int estimateTranslation3D(Mat src, Mat dst, Mat _out, Mat inliers)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return calib3d_Calib3d_estimateTranslation3D_12(src.nativeObj, dst.nativeObj, _out.nativeObj, inliers.nativeObj);


        }


        //
        // C++:  Mat cv::estimateAffine2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        //

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_10(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence, refineIters)));


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_11(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence)));


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_12(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters)));


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_13(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold)));


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers, int method)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_14(from.nativeObj, to.nativeObj, inliers.nativeObj, method)));


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to, Mat inliers)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_15(from.nativeObj, to.nativeObj, inliers.nativeObj)));


        }

        /// <summary>
        ///  Computes an optimal affine transformation between two 2D point sets.
        /// </summary>
        /// <remarks>
        ///  It computes
        ///  \f[
        ///  \begin{bmatrix}
        ///  x\\
        ///  y\\
        ///  \end{bmatrix}
        ///  =
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12}\\
        ///  a_{21} &amp; a_{22}\\
        ///  \end{bmatrix}
        ///  \begin{bmatrix}
        ///  X\\
        ///  Y\\
        ///  \end{bmatrix}
        ///  +
        ///  \begin{bmatrix}
        ///  b_1\\
        ///  b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </remarks>
        /// <param name="from">
        /// First input 2D point set containing \f$(X,Y)\f$.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set containing \f$(x,y)\f$.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers (1-inlier, 0-outlier).
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation matrix \f$2 \times 3\f$ or empty matrix if transformation
        ///  could not be estimated. The returned matrix has the following form:
        ///  \f[
        ///  \begin{bmatrix}
        ///  a_{11} &amp; a_{12} &amp; b_1\\
        ///  a_{21} &amp; a_{22} &amp; b_2\\
        ///  \end{bmatrix}
        ///  \f]
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation between two 2D point sets using the
        ///  selected robust algorithm.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but needs a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffinePartial2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffine2D(Mat from, Mat to)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_16(from.nativeObj, to.nativeObj)));


        }


        //
        // C++:  Mat cv::estimateAffine2D(Mat pts1, Mat pts2, Mat& inliers, UsacParams _params)
        //

        public static Mat estimateAffine2D(Mat pts1, Mat pts2, Mat inliers, UsacParams _params)
        {
            if (pts1 != null) pts1.ThrowIfDisposed();
            if (pts2 != null) pts2.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffine2D_17(pts1.nativeObj, pts2.nativeObj, inliers.nativeObj, _params.nativeObj)));


        }


        //
        // C++:  Mat cv::estimateAffinePartial2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        //

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_10(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence, refineIters)));


        }

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters, double confidence)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_11(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters, confidence)));


        }

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold, long maxIters)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_12(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold, maxIters)));


        }

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method, double ransacReprojThreshold)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_13(from.nativeObj, to.nativeObj, inliers.nativeObj, method, ransacReprojThreshold)));


        }

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers, int method)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_14(from.nativeObj, to.nativeObj, inliers.nativeObj, method)));


        }

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to, Mat inliers)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();
            if (inliers != null) inliers.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_15(from.nativeObj, to.nativeObj, inliers.nativeObj)));


        }

        /// <summary>
        ///  Computes an optimal limited affine transformation with 4 degrees of freedom between
        ///  two 2D point sets.
        /// </summary>
        /// <param name="from">
        /// First input 2D point set.
        /// </param>
        /// <param name="to">
        /// Second input 2D point set.
        /// </param>
        /// <param name="inliers">
        /// Output vector indicating which points are inliers.
        /// </param>
        /// <param name="method">
        /// Robust method used to compute transformation. The following methods are possible:
        ///  -   @ref RANSAC - RANSAC-based robust method
        ///  -   @ref LMEDS - Least-Median robust method
        ///  RANSAC is the default method.
        /// </param>
        /// <param name="ransacReprojThreshold">
        /// Maximum reprojection error in the RANSAC algorithm to consider
        ///  a point as an inlier. Applies only to RANSAC.
        /// </param>
        /// <param name="maxIters">
        /// The maximum number of robust method iterations.
        /// </param>
        /// <param name="confidence">
        /// Confidence level, between 0 and 1, for the estimated transformation. Anything
        ///  between 0.95 and 0.99 is usually good enough. Values too close to 1 can slow down the estimation
        ///  significantly. Values lower than 0.8-0.9 can result in an incorrectly estimated transformation.
        /// </param>
        /// <param name="refineIters">
        /// Maximum number of iterations of refining algorithm (Levenberg-Marquardt).
        ///  Passing 0 will disable refining, so the output matrix will be output of robust method.
        /// </param>
        /// <returns>
        ///  Output 2D affine transformation (4 degrees of freedom) matrix \f$2 \times 3\f$ or
        ///  empty matrix if transformation could not be estimated.
        /// </returns>
        /// <remarks>
        ///  The function estimates an optimal 2D affine transformation with 4 degrees of freedom limited to
        ///  combinations of translation, rotation, and uniform scaling. Uses the selected algorithm for robust
        ///  estimation.
        ///  
        ///  The computed transformation is then refined further (using only inliers) with the
        ///  Levenberg-Marquardt method to reduce the re-projection error even more.
        ///  
        ///  Estimated transformation matrix is:
        ///  \f[ \begin{bmatrix} \cos(\theta) \cdot s &amp; -\sin(\theta) \cdot s &amp; t_x \\
        ///                  \sin(\theta) \cdot s &amp; \cos(\theta) \cdot s &amp; t_y
        ///  \end{bmatrix} \f]
        ///  Where \f$ \theta \f$ is the rotation angle, \f$ s \f$ the scaling factor and \f$ t_x, t_y \f$ are
        ///  translations in \f$ x, y \f$ axes respectively.
        ///  
        ///  @note
        ///  The RANSAC method can handle practically any ratio of outliers but need a threshold to
        ///  distinguish inliers from outliers. The method LMeDS does not need any threshold but it works
        ///  correctly only when there are more than 50% of inliers.
        ///  
        ///  @sa estimateAffine2D, getAffineTransform
        /// </remarks>
        public static Mat estimateAffinePartial2D(Mat from, Mat to)
        {
            if (from != null) from.ThrowIfDisposed();
            if (to != null) to.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_estimateAffinePartial2D_16(from.nativeObj, to.nativeObj)));


        }


        //
        // C++:  int cv::decomposeHomographyMat(Mat H, Mat K, vector_Mat& rotations, vector_Mat& translations, vector_Mat& normals)
        //

        /// <summary>
        ///  Decompose a homography matrix to rotation(s), translation(s) and plane normal(s).
        /// </summary>
        /// <param name="H">
        /// The input homography matrix between two images.
        /// </param>
        /// <param name="K">
        /// The input camera intrinsic matrix.
        /// </param>
        /// <param name="rotations">
        /// Array of rotation matrices.
        /// </param>
        /// <param name="translations">
        /// Array of translation matrices.
        /// </param>
        /// <param name="normals">
        /// Array of plane normal matrices.
        /// </param>
        /// <remarks>
        ///  This function extracts relative camera motion between two views of a planar object and returns up to
        ///  four mathematical solution tuples of rotation, translation, and plane normal. The decomposition of
        ///  the homography matrix H is described in detail in @cite Malis2007.
        ///  
        ///  If the homography H, induced by the plane, gives the constraint
        ///  \f[s_i \vecthree{x'_i}{y'_i}{1} \sim H \vecthree{x_i}{y_i}{1}\f] on the source image points
        ///  \f$p_i\f$ and the destination image points \f$p'_i\f$, then the tuple of rotations[k] and
        ///  translations[k] is a change of basis from the source camera's coordinate system to the destination
        ///  camera's coordinate system. However, by decomposing H, one can only get the translation normalized
        ///  by the (typically unknown) depth of the scene, i.e. its direction but with normalized length.
        ///  
        ///  If point correspondences are available, at least two solutions may further be invalidated, by
        ///  applying positive depth constraint, i.e. all points must be in front of the camera.
        /// </remarks>
        public static int decomposeHomographyMat(Mat H, Mat K, List<Mat> rotations, List<Mat> translations, List<Mat> normals)
        {
            if (H != null) H.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            Mat rotations_mat = new Mat();
            Mat translations_mat = new Mat();
            Mat normals_mat = new Mat();
            int retVal = calib3d_Calib3d_decomposeHomographyMat_10(H.nativeObj, K.nativeObj, rotations_mat.nativeObj, translations_mat.nativeObj, normals_mat.nativeObj);
            Converters.Mat_to_vector_Mat(rotations_mat, rotations);
            rotations_mat.release();
            Converters.Mat_to_vector_Mat(translations_mat, translations);
            translations_mat.release();
            Converters.Mat_to_vector_Mat(normals_mat, normals);
            normals_mat.release();
            return retVal;
        }


        //
        // C++:  void cv::filterHomographyDecompByVisibleRefpoints(vector_Mat rotations, vector_Mat normals, Mat beforePoints, Mat afterPoints, Mat& possibleSolutions, Mat pointsMask = Mat())
        //

        /// <summary>
        ///  Filters homography decompositions based on additional information.
        /// </summary>
        /// <param name="rotations">
        /// Vector of rotation matrices.
        /// </param>
        /// <param name="normals">
        /// Vector of plane normal matrices.
        /// </param>
        /// <param name="beforePoints">
        /// Vector of (rectified) visible reference points before the homography is applied
        /// </param>
        /// <param name="afterPoints">
        /// Vector of (rectified) visible reference points after the homography is applied
        /// </param>
        /// <param name="possibleSolutions">
        /// Vector of int indices representing the viable solution set after filtering
        /// </param>
        /// <param name="pointsMask">
        /// optional Mat/Vector of 8u type representing the mask for the inliers as given by the #findHomography function
        /// </param>
        /// <remarks>
        ///  This function is intended to filter the output of the #decomposeHomographyMat based on additional
        ///  information as described in @cite Malis2007 . The summary of the method: the #decomposeHomographyMat function
        ///  returns 2 unique solutions and their "opposites" for a total of 4 solutions. If we have access to the
        ///  sets of points visible in the camera frame before and after the homography transformation is applied,
        ///  we can determine which are the true potential solutions and which are the opposites by verifying which
        ///  homographies are consistent with all visible reference points being in front of the camera. The inputs
        ///  are left unchanged; the filtered solution set is returned as indices into the existing one.
        /// </remarks>
        public static void filterHomographyDecompByVisibleRefpoints(List<Mat> rotations, List<Mat> normals, Mat beforePoints, Mat afterPoints, Mat possibleSolutions, Mat pointsMask)
        {
            if (beforePoints != null) beforePoints.ThrowIfDisposed();
            if (afterPoints != null) afterPoints.ThrowIfDisposed();
            if (possibleSolutions != null) possibleSolutions.ThrowIfDisposed();
            if (pointsMask != null) pointsMask.ThrowIfDisposed();
            Mat rotations_mat = Converters.vector_Mat_to_Mat(rotations);
            Mat normals_mat = Converters.vector_Mat_to_Mat(normals);
            calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_10(rotations_mat.nativeObj, normals_mat.nativeObj, beforePoints.nativeObj, afterPoints.nativeObj, possibleSolutions.nativeObj, pointsMask.nativeObj);


        }

        /// <summary>
        ///  Filters homography decompositions based on additional information.
        /// </summary>
        /// <param name="rotations">
        /// Vector of rotation matrices.
        /// </param>
        /// <param name="normals">
        /// Vector of plane normal matrices.
        /// </param>
        /// <param name="beforePoints">
        /// Vector of (rectified) visible reference points before the homography is applied
        /// </param>
        /// <param name="afterPoints">
        /// Vector of (rectified) visible reference points after the homography is applied
        /// </param>
        /// <param name="possibleSolutions">
        /// Vector of int indices representing the viable solution set after filtering
        /// </param>
        /// <param name="pointsMask">
        /// optional Mat/Vector of 8u type representing the mask for the inliers as given by the #findHomography function
        /// </param>
        /// <remarks>
        ///  This function is intended to filter the output of the #decomposeHomographyMat based on additional
        ///  information as described in @cite Malis2007 . The summary of the method: the #decomposeHomographyMat function
        ///  returns 2 unique solutions and their "opposites" for a total of 4 solutions. If we have access to the
        ///  sets of points visible in the camera frame before and after the homography transformation is applied,
        ///  we can determine which are the true potential solutions and which are the opposites by verifying which
        ///  homographies are consistent with all visible reference points being in front of the camera. The inputs
        ///  are left unchanged; the filtered solution set is returned as indices into the existing one.
        /// </remarks>
        public static void filterHomographyDecompByVisibleRefpoints(List<Mat> rotations, List<Mat> normals, Mat beforePoints, Mat afterPoints, Mat possibleSolutions)
        {
            if (beforePoints != null) beforePoints.ThrowIfDisposed();
            if (afterPoints != null) afterPoints.ThrowIfDisposed();
            if (possibleSolutions != null) possibleSolutions.ThrowIfDisposed();
            Mat rotations_mat = Converters.vector_Mat_to_Mat(rotations);
            Mat normals_mat = Converters.vector_Mat_to_Mat(normals);
            calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_11(rotations_mat.nativeObj, normals_mat.nativeObj, beforePoints.nativeObj, afterPoints.nativeObj, possibleSolutions.nativeObj);


        }


        //
        // C++:  void cv::undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
        //

        /// <summary>
        ///  Transforms an image to compensate for lens distortion.
        /// </summary>
        /// <remarks>
        ///  The function transforms an image to compensate radial and tangential lens distortion.
        ///  
        ///  The function is simply a combination of #initUndistortRectifyMap (with unity R ) and #remap
        ///  (with bilinear interpolation). See the former function for details of the transformation being
        ///  performed.
        ///  
        ///  Those pixels in the destination image, for which there is no correspondent pixels in the source
        ///  image, are filled with zeros (black color).
        ///  
        ///  A particular subset of the source image that will be visible in the corrected image can be regulated
        ///  by newCameraMatrix. You can use #getOptimalNewCameraMatrix to compute the appropriate
        ///  newCameraMatrix depending on your requirements.
        ///  
        ///  The camera matrix and the distortion parameters can be determined using #calibrateCamera. If
        ///  the resolution of images is different from the resolution used at the calibration stage, \f$f_x,
        ///  f_y, c_x\f$ and \f$c_y\f$ need to be scaled accordingly, while the distortion coefficients remain
        ///  the same.
        /// </remarks>
        /// <param name="src">
        /// Input (distorted) image.
        /// </param>
        /// <param name="dst">
        /// Output (corrected) image that has the same size and type as src .
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera matrix \f$A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="newCameraMatrix">
        /// Camera matrix of the distorted image. By default, it is the same as
        ///  cameraMatrix but you may additionally scale and shift the result by using a different matrix.
        /// </param>
        public static void undistort(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (newCameraMatrix != null) newCameraMatrix.ThrowIfDisposed();

            calib3d_Calib3d_undistort_10(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, newCameraMatrix.nativeObj);


        }

        /// <summary>
        ///  Transforms an image to compensate for lens distortion.
        /// </summary>
        /// <remarks>
        ///  The function transforms an image to compensate radial and tangential lens distortion.
        ///  
        ///  The function is simply a combination of #initUndistortRectifyMap (with unity R ) and #remap
        ///  (with bilinear interpolation). See the former function for details of the transformation being
        ///  performed.
        ///  
        ///  Those pixels in the destination image, for which there is no correspondent pixels in the source
        ///  image, are filled with zeros (black color).
        ///  
        ///  A particular subset of the source image that will be visible in the corrected image can be regulated
        ///  by newCameraMatrix. You can use #getOptimalNewCameraMatrix to compute the appropriate
        ///  newCameraMatrix depending on your requirements.
        ///  
        ///  The camera matrix and the distortion parameters can be determined using #calibrateCamera. If
        ///  the resolution of images is different from the resolution used at the calibration stage, \f$f_x,
        ///  f_y, c_x\f$ and \f$c_y\f$ need to be scaled accordingly, while the distortion coefficients remain
        ///  the same.
        /// </remarks>
        /// <param name="src">
        /// Input (distorted) image.
        /// </param>
        /// <param name="dst">
        /// Output (corrected) image that has the same size and type as src .
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera matrix \f$A = \vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="newCameraMatrix">
        /// Camera matrix of the distorted image. By default, it is the same as
        ///  cameraMatrix but you may additionally scale and shift the result by using a different matrix.
        /// </param>
        public static void undistort(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();

            calib3d_Calib3d_undistort_11(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);


        }


        //
        // C++:  void cv::initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
        //

        /// <summary>
        ///  Computes the undistortion and rectification transformation map.
        /// </summary>
        /// <remarks>
        ///  The function computes the joint undistortion and rectification transformation and represents the
        ///  result in the form of maps for #remap. The undistorted image looks like original, as if it is
        ///  captured with a camera using the camera matrix =newCameraMatrix and zero distortion. In case of a
        ///  monocular camera, newCameraMatrix is usually equal to cameraMatrix, or it can be computed by
        ///  #getOptimalNewCameraMatrix for a better control over scaling. In case of a stereo camera,
        ///  newCameraMatrix is normally set to P1 or P2 computed by #stereoRectify .
        ///  
        ///  Also, this new camera is oriented differently in the coordinate space, according to R. That, for
        ///  example, helps to align two heads of a stereo camera so that the epipolar lines on both images
        ///  become horizontal and have the same y- coordinate (in case of a horizontally aligned stereo camera).
        ///  
        ///  The function actually builds the maps for the inverse mapping algorithm that is used by #remap. That
        ///  is, for each pixel \f$(u, v)\f$ in the destination (corrected and rectified) image, the function
        ///  computes the corresponding coordinates in the source image (that is, in the original image from
        ///  camera). The following process is applied:
        ///  \f[
        ///  \begin{array}{l}
        ///  x  \leftarrow (u - {c'}_x)/{f'}_x  \\
        ///  y  \leftarrow (v - {c'}_y)/{f'}_y  \\
        ///  {[X\,Y\,W]} ^T  \leftarrow R^{-1}*[x \, y \, 1]^T  \\
        ///  x'  \leftarrow X/W  \\
        ///  y'  \leftarrow Y/W  \\
        ///  r^2  \leftarrow x'^2 + y'^2 \\
        ///  x''  \leftarrow x' \frac{1 + k_1 r^2 + k_2 r^4 + k_3 r^6}{1 + k_4 r^2 + k_5 r^4 + k_6 r^6}
        ///  + 2p_1 x' y' + p_2(r^2 + 2 x'^2)  + s_1 r^2 + s_2 r^4\\
        ///  y''  \leftarrow y' \frac{1 + k_1 r^2 + k_2 r^4 + k_3 r^6}{1 + k_4 r^2 + k_5 r^4 + k_6 r^6}
        ///  + p_1 (r^2 + 2 y'^2) + 2 p_2 x' y' + s_3 r^2 + s_4 r^4 \\
        ///  s\vecthree{x'''}{y'''}{1} =
        ///  \vecthreethree{R_{33}(\tau_x, \tau_y)}{0}{-R_{13}((\tau_x, \tau_y)}
        ///  {0}{R_{33}(\tau_x, \tau_y)}{-R_{23}(\tau_x, \tau_y)}
        ///  {0}{0}{1} R(\tau_x, \tau_y) \vecthree{x''}{y''}{1}\\
        ///  map_x(u,v)  \leftarrow x''' f_x + c_x  \\
        ///  map_y(u,v)  \leftarrow y''' f_y + c_y
        ///  \end{array}
        ///  \f]
        ///  where \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  are the distortion coefficients.
        ///  
        ///  In case of a stereo camera, this function is called twice: once for each camera head, after
        ///  #stereoRectify, which in its turn is called after #stereoCalibrate. But if the stereo camera
        ///  was not calibrated, it is still possible to compute the rectification transformations directly from
        ///  the fundamental matrix using #stereoRectifyUncalibrated. For each camera, the function computes
        ///  homography H as the rectification transformation in a pixel domain, not a rotation matrix R in 3D
        ///  space. R can be computed from H as
        ///  \f[\texttt{R} = \texttt{cameraMatrix} ^{-1} \cdot \texttt{H} \cdot \texttt{cameraMatrix}\f]
        ///  where cameraMatrix can be chosen arbitrarily.
        /// </remarks>
        /// <param name="cameraMatrix">
        /// Input camera matrix \f$A=\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="R">
        /// Optional rectification transformation in the object space (3x3 matrix). R1 or R2 ,
        ///  computed by #stereoRectify can be passed here. If the matrix is empty, the identity transformation
        ///  is assumed. In #initUndistortRectifyMap R assumed to be an identity matrix.
        /// </param>
        /// <param name="newCameraMatrix">
        /// New camera matrix \f$A'=\vecthreethree{f_x'}{0}{c_x'}{0}{f_y'}{c_y'}{0}{0}{1}\f$.
        /// </param>
        /// <param name="size">
        /// Undistorted image size.
        /// </param>
        /// <param name="m1type">
        /// Type of the first output map that can be CV_32FC1, CV_32FC2 or CV_16SC2, see #convertMaps
        /// </param>
        /// <param name="map1">
        /// The first output map.
        /// </param>
        /// <param name="map2">
        /// The second output map.
        /// </param>
        public static void initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat map1, Mat map2)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (newCameraMatrix != null) newCameraMatrix.ThrowIfDisposed();
            if (map1 != null) map1.ThrowIfDisposed();
            if (map2 != null) map2.ThrowIfDisposed();

            calib3d_Calib3d_initUndistortRectifyMap_10(cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, newCameraMatrix.nativeObj, size.width, size.height, m1type, map1.nativeObj, map2.nativeObj);


        }


        //
        // C++:  void cv::initInverseRectificationMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
        //

        /// <summary>
        ///  Computes the projection and inverse-rectification transformation map. In essense, this is the inverse of
        ///  #initUndistortRectifyMap to accomodate stereo-rectification of projectors ('inverse-cameras') in projector-camera pairs.
        /// </summary>
        /// <remarks>
        ///  The function computes the joint projection and inverse rectification transformation and represents the
        ///  result in the form of maps for #remap. The projected image looks like a distorted version of the original which,
        ///  once projected by a projector, should visually match the original. In case of a monocular camera, newCameraMatrix
        ///  is usually equal to cameraMatrix, or it can be computed by
        ///  #getOptimalNewCameraMatrix for a better control over scaling. In case of a projector-camera pair,
        ///  newCameraMatrix is normally set to P1 or P2 computed by #stereoRectify .
        ///  
        ///  The projector is oriented differently in the coordinate space, according to R. In case of projector-camera pairs,
        ///  this helps align the projector (in the same manner as #initUndistortRectifyMap for the camera) to create a stereo-rectified pair. This
        ///  allows epipolar lines on both images to become horizontal and have the same y-coordinate (in case of a horizontally aligned projector-camera pair).
        ///  
        ///  The function builds the maps for the inverse mapping algorithm that is used by #remap. That
        ///  is, for each pixel \f$(u, v)\f$ in the destination (projected and inverse-rectified) image, the function
        ///  computes the corresponding coordinates in the source image (that is, in the original digital image). The following process is applied:
        ///  
        ///  \f[
        ///  \begin{array}{l}
        ///  \text{newCameraMatrix}\\
        ///  x  \leftarrow (u - {c'}_x)/{f'}_x  \\
        ///  y  \leftarrow (v - {c'}_y)/{f'}_y  \\
        ///  
        ///  \\\text{Undistortion}
        ///  \\\scriptsize{\textit{though equation shown is for radial undistortion, function implements cv::undistortPoints()}}\\
        ///  r^2  \leftarrow x^2 + y^2 \\
        ///  \theta \leftarrow \frac{1 + k_1 r^2 + k_2 r^4 + k_3 r^6}{1 + k_4 r^2 + k_5 r^4 + k_6 r^6}\\
        ///  x' \leftarrow \frac{x}{\theta} \\
        ///  y'  \leftarrow \frac{y}{\theta} \\
        ///  
        ///  \\\text{Rectification}\\
        ///  {[X\,Y\,W]} ^T  \leftarrow R*[x' \, y' \, 1]^T  \\
        ///  x''  \leftarrow X/W  \\
        ///  y''  \leftarrow Y/W  \\
        ///  
        ///  \\\text{cameraMatrix}\\
        ///  map_x(u,v)  \leftarrow x'' f_x + c_x  \\
        ///  map_y(u,v)  \leftarrow y'' f_y + c_y
        ///  \end{array}
        ///  \f]
        ///  where \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  are the distortion coefficients vector distCoeffs.
        ///  
        ///  In case of a stereo-rectified projector-camera pair, this function is called for the projector while #initUndistortRectifyMap is called for the camera head.
        ///  This is done after #stereoRectify, which in turn is called after #stereoCalibrate. If the projector-camera pair
        ///  is not calibrated, it is still possible to compute the rectification transformations directly from
        ///  the fundamental matrix using #stereoRectifyUncalibrated. For the projector and camera, the function computes
        ///  homography H as the rectification transformation in a pixel domain, not a rotation matrix R in 3D
        ///  space. R can be computed from H as
        ///  \f[\texttt{R} = \texttt{cameraMatrix} ^{-1} \cdot \texttt{H} \cdot \texttt{cameraMatrix}\f]
        ///  where cameraMatrix can be chosen arbitrarily.
        /// </remarks>
        /// <param name="cameraMatrix">
        /// Input camera matrix \f$A=\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="R">
        /// Optional rectification transformation in the object space (3x3 matrix). R1 or R2,
        ///  computed by #stereoRectify can be passed here. If the matrix is empty, the identity transformation
        ///  is assumed.
        /// </param>
        /// <param name="newCameraMatrix">
        /// New camera matrix \f$A'=\vecthreethree{f_x'}{0}{c_x'}{0}{f_y'}{c_y'}{0}{0}{1}\f$.
        /// </param>
        /// <param name="size">
        /// Distorted image size.
        /// </param>
        /// <param name="m1type">
        /// Type of the first output map. Can be CV_32FC1, CV_32FC2 or CV_16SC2, see #convertMaps
        /// </param>
        /// <param name="map1">
        /// The first output map for #remap.
        /// </param>
        /// <param name="map2">
        /// The second output map for #remap.
        /// </param>
        public static void initInverseRectificationMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat map1, Mat map2)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (newCameraMatrix != null) newCameraMatrix.ThrowIfDisposed();
            if (map1 != null) map1.ThrowIfDisposed();
            if (map2 != null) map2.ThrowIfDisposed();

            calib3d_Calib3d_initInverseRectificationMap_10(cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, newCameraMatrix.nativeObj, size.width, size.height, m1type, map1.nativeObj, map2.nativeObj);


        }


        //
        // C++:  Mat cv::getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
        //

        /// <summary>
        ///  Returns the default new camera matrix.
        /// </summary>
        /// <remarks>
        ///  The function returns the camera matrix that is either an exact copy of the input cameraMatrix (when
        ///  centerPrinicipalPoint=false ), or the modified one (when centerPrincipalPoint=true).
        ///  
        ///  In the latter case, the new camera matrix will be:
        ///  
        ///  \f[\begin{bmatrix} f_x &amp;&amp; 0 &amp;&amp; ( \texttt{imgSize.width} -1)*0.5  \\ 0 &amp;&amp; f_y &amp;&amp; ( \texttt{imgSize.height} -1)*0.5  \\ 0 &amp;&amp; 0 &amp;&amp; 1 \end{bmatrix} ,\f]
        ///  
        ///  where \f$f_x\f$ and \f$f_y\f$ are \f$(0,0)\f$ and \f$(1,1)\f$ elements of cameraMatrix, respectively.
        ///  
        ///  By default, the undistortion functions in OpenCV (see #initUndistortRectifyMap, #undistort) do not
        ///  move the principal point. However, when you work with stereo, it is important to move the principal
        ///  points in both views to the same y-coordinate (which is required by most of stereo correspondence
        ///  algorithms), and may be to the same x-coordinate too. So, you can form the new camera matrix for
        ///  each view where the principal points are located at the center.
        /// </remarks>
        /// <param name="cameraMatrix">
        /// Input camera matrix.
        /// </param>
        /// <param name="imgsize">
        /// Camera view image size in pixels.
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Location of the principal point in the new camera matrix. The
        ///  parameter indicates whether this location should be at the image center or not.
        /// </param>
        public static Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize, bool centerPrincipalPoint)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getDefaultNewCameraMatrix_10(cameraMatrix.nativeObj, imgsize.width, imgsize.height, centerPrincipalPoint)));


        }

        /// <summary>
        ///  Returns the default new camera matrix.
        /// </summary>
        /// <remarks>
        ///  The function returns the camera matrix that is either an exact copy of the input cameraMatrix (when
        ///  centerPrinicipalPoint=false ), or the modified one (when centerPrincipalPoint=true).
        ///  
        ///  In the latter case, the new camera matrix will be:
        ///  
        ///  \f[\begin{bmatrix} f_x &amp;&amp; 0 &amp;&amp; ( \texttt{imgSize.width} -1)*0.5  \\ 0 &amp;&amp; f_y &amp;&amp; ( \texttt{imgSize.height} -1)*0.5  \\ 0 &amp;&amp; 0 &amp;&amp; 1 \end{bmatrix} ,\f]
        ///  
        ///  where \f$f_x\f$ and \f$f_y\f$ are \f$(0,0)\f$ and \f$(1,1)\f$ elements of cameraMatrix, respectively.
        ///  
        ///  By default, the undistortion functions in OpenCV (see #initUndistortRectifyMap, #undistort) do not
        ///  move the principal point. However, when you work with stereo, it is important to move the principal
        ///  points in both views to the same y-coordinate (which is required by most of stereo correspondence
        ///  algorithms), and may be to the same x-coordinate too. So, you can form the new camera matrix for
        ///  each view where the principal points are located at the center.
        /// </remarks>
        /// <param name="cameraMatrix">
        /// Input camera matrix.
        /// </param>
        /// <param name="imgsize">
        /// Camera view image size in pixels.
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Location of the principal point in the new camera matrix. The
        ///  parameter indicates whether this location should be at the image center or not.
        /// </param>
        public static Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getDefaultNewCameraMatrix_11(cameraMatrix.nativeObj, imgsize.width, imgsize.height)));


        }

        /// <summary>
        ///  Returns the default new camera matrix.
        /// </summary>
        /// <remarks>
        ///  The function returns the camera matrix that is either an exact copy of the input cameraMatrix (when
        ///  centerPrinicipalPoint=false ), or the modified one (when centerPrincipalPoint=true).
        ///  
        ///  In the latter case, the new camera matrix will be:
        ///  
        ///  \f[\begin{bmatrix} f_x &amp;&amp; 0 &amp;&amp; ( \texttt{imgSize.width} -1)*0.5  \\ 0 &amp;&amp; f_y &amp;&amp; ( \texttt{imgSize.height} -1)*0.5  \\ 0 &amp;&amp; 0 &amp;&amp; 1 \end{bmatrix} ,\f]
        ///  
        ///  where \f$f_x\f$ and \f$f_y\f$ are \f$(0,0)\f$ and \f$(1,1)\f$ elements of cameraMatrix, respectively.
        ///  
        ///  By default, the undistortion functions in OpenCV (see #initUndistortRectifyMap, #undistort) do not
        ///  move the principal point. However, when you work with stereo, it is important to move the principal
        ///  points in both views to the same y-coordinate (which is required by most of stereo correspondence
        ///  algorithms), and may be to the same x-coordinate too. So, you can form the new camera matrix for
        ///  each view where the principal points are located at the center.
        /// </remarks>
        /// <param name="cameraMatrix">
        /// Input camera matrix.
        /// </param>
        /// <param name="imgsize">
        /// Camera view image size in pixels.
        /// </param>
        /// <param name="centerPrincipalPoint">
        /// Location of the principal point in the new camera matrix. The
        ///  parameter indicates whether this location should be at the image center or not.
        /// </param>
        public static Mat getDefaultNewCameraMatrix(Mat cameraMatrix)
        {
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(calib3d_Calib3d_getDefaultNewCameraMatrix_12(cameraMatrix.nativeObj)));


        }


        //
        // C++:  void cv::undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
        //

        /// <summary>
        ///  Computes the ideal point coordinates from the observed point coordinates.
        /// </summary>
        /// <remarks>
        ///  The function is similar to #undistort and #initUndistortRectifyMap but it operates on a
        ///  sparse set of points instead of a raster image. Also the function performs a reverse transformation
        ///  to  #projectPoints. In case of a 3D object, it does not reconstruct its 3D coordinates, but for a
        ///  planar object, it does, up to a translation vector, if the proper R is specified.
        ///  
        ///  For each observed point coordinate \f$(u, v)\f$ the function computes:
        ///  \f[
        ///  \begin{array}{l}
        ///  x^{"}  \leftarrow (u - c_x)/f_x  \\
        ///  y^{"}  \leftarrow (v - c_y)/f_y  \\
        ///  (x',y') = undistort(x^{"},y^{"}, \texttt{distCoeffs}) \\
        ///  {[X\,Y\,W]} ^T  \leftarrow R*[x' \, y' \, 1]^T  \\
        ///  x  \leftarrow X/W  \\
        ///  y  \leftarrow Y/W  \\
        ///  \text{only performed if P is specified:} \\
        ///  u'  \leftarrow x {f'}_x + {c'}_x  \\
        ///  v'  \leftarrow y {f'}_y + {c'}_y
        ///  \end{array}
        ///  \f]
        ///  
        ///  where *undistort* is an approximate iterative algorithm that estimates the normalized original
        ///  point coordinates out of the normalized distorted point coordinates ("normalized" means that the
        ///  coordinates do not depend on the camera matrix).
        ///  
        ///  The function can be used for both a stereo camera head or a monocular camera (when R is empty).
        /// </remarks>
        /// <param name="src">
        /// Observed point coordinates, 2xN/Nx2 1-channel or 1xN/Nx1 2-channel (CV_32FC2 or CV_64FC2) (or
        ///  vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="dst">
        /// Output ideal point coordinates (1xN/Nx1 2-channel or vector&lt;Point2f&gt; ) after undistortion and reverse perspective
        ///  transformation. If matrix P is identity or omitted, dst will contain normalized point coordinates.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera matrix \f$\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space (3x3 matrix). R1 or R2 computed by
        ///  #stereoRectify can be passed here. If the matrix is empty, the identity transformation is used.
        /// </param>
        /// <param name="P">
        /// New camera matrix (3x3) or new projection matrix (3x4) \f$\begin{bmatrix} {f'}_x &amp; 0 &amp; {c'}_x &amp; t_x \\ 0 &amp; {f'}_y &amp; {c'}_y &amp; t_y \\ 0 &amp; 0 &amp; 1 &amp; t_z \end{bmatrix}\f$. P1 or P2 computed by
        ///  #stereoRectify can be passed here. If the matrix is empty, the identity new camera matrix is used.
        /// </param>
        public static void undistortPoints(MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
            Mat src_mat = src;
            Mat dst_mat = dst;
            calib3d_Calib3d_undistortPoints_10(src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, P.nativeObj);


        }

        /// <summary>
        ///  Computes the ideal point coordinates from the observed point coordinates.
        /// </summary>
        /// <remarks>
        ///  The function is similar to #undistort and #initUndistortRectifyMap but it operates on a
        ///  sparse set of points instead of a raster image. Also the function performs a reverse transformation
        ///  to  #projectPoints. In case of a 3D object, it does not reconstruct its 3D coordinates, but for a
        ///  planar object, it does, up to a translation vector, if the proper R is specified.
        ///  
        ///  For each observed point coordinate \f$(u, v)\f$ the function computes:
        ///  \f[
        ///  \begin{array}{l}
        ///  x^{"}  \leftarrow (u - c_x)/f_x  \\
        ///  y^{"}  \leftarrow (v - c_y)/f_y  \\
        ///  (x',y') = undistort(x^{"},y^{"}, \texttt{distCoeffs}) \\
        ///  {[X\,Y\,W]} ^T  \leftarrow R*[x' \, y' \, 1]^T  \\
        ///  x  \leftarrow X/W  \\
        ///  y  \leftarrow Y/W  \\
        ///  \text{only performed if P is specified:} \\
        ///  u'  \leftarrow x {f'}_x + {c'}_x  \\
        ///  v'  \leftarrow y {f'}_y + {c'}_y
        ///  \end{array}
        ///  \f]
        ///  
        ///  where *undistort* is an approximate iterative algorithm that estimates the normalized original
        ///  point coordinates out of the normalized distorted point coordinates ("normalized" means that the
        ///  coordinates do not depend on the camera matrix).
        ///  
        ///  The function can be used for both a stereo camera head or a monocular camera (when R is empty).
        /// </remarks>
        /// <param name="src">
        /// Observed point coordinates, 2xN/Nx2 1-channel or 1xN/Nx1 2-channel (CV_32FC2 or CV_64FC2) (or
        ///  vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="dst">
        /// Output ideal point coordinates (1xN/Nx1 2-channel or vector&lt;Point2f&gt; ) after undistortion and reverse perspective
        ///  transformation. If matrix P is identity or omitted, dst will contain normalized point coordinates.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera matrix \f$\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space (3x3 matrix). R1 or R2 computed by
        ///  #stereoRectify can be passed here. If the matrix is empty, the identity transformation is used.
        /// </param>
        /// <param name="P">
        /// New camera matrix (3x3) or new projection matrix (3x4) \f$\begin{bmatrix} {f'}_x &amp; 0 &amp; {c'}_x &amp; t_x \\ 0 &amp; {f'}_y &amp; {c'}_y &amp; t_y \\ 0 &amp; 0 &amp; 1 &amp; t_z \end{bmatrix}\f$. P1 or P2 computed by
        ///  #stereoRectify can be passed here. If the matrix is empty, the identity new camera matrix is used.
        /// </param>
        public static void undistortPoints(MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs, Mat R)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            Mat src_mat = src;
            Mat dst_mat = dst;
            calib3d_Calib3d_undistortPoints_11(src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj);


        }

        /// <summary>
        ///  Computes the ideal point coordinates from the observed point coordinates.
        /// </summary>
        /// <remarks>
        ///  The function is similar to #undistort and #initUndistortRectifyMap but it operates on a
        ///  sparse set of points instead of a raster image. Also the function performs a reverse transformation
        ///  to  #projectPoints. In case of a 3D object, it does not reconstruct its 3D coordinates, but for a
        ///  planar object, it does, up to a translation vector, if the proper R is specified.
        ///  
        ///  For each observed point coordinate \f$(u, v)\f$ the function computes:
        ///  \f[
        ///  \begin{array}{l}
        ///  x^{"}  \leftarrow (u - c_x)/f_x  \\
        ///  y^{"}  \leftarrow (v - c_y)/f_y  \\
        ///  (x',y') = undistort(x^{"},y^{"}, \texttt{distCoeffs}) \\
        ///  {[X\,Y\,W]} ^T  \leftarrow R*[x' \, y' \, 1]^T  \\
        ///  x  \leftarrow X/W  \\
        ///  y  \leftarrow Y/W  \\
        ///  \text{only performed if P is specified:} \\
        ///  u'  \leftarrow x {f'}_x + {c'}_x  \\
        ///  v'  \leftarrow y {f'}_y + {c'}_y
        ///  \end{array}
        ///  \f]
        ///  
        ///  where *undistort* is an approximate iterative algorithm that estimates the normalized original
        ///  point coordinates out of the normalized distorted point coordinates ("normalized" means that the
        ///  coordinates do not depend on the camera matrix).
        ///  
        ///  The function can be used for both a stereo camera head or a monocular camera (when R is empty).
        /// </remarks>
        /// <param name="src">
        /// Observed point coordinates, 2xN/Nx2 1-channel or 1xN/Nx1 2-channel (CV_32FC2 or CV_64FC2) (or
        ///  vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="dst">
        /// Output ideal point coordinates (1xN/Nx1 2-channel or vector&lt;Point2f&gt; ) after undistortion and reverse perspective
        ///  transformation. If matrix P is identity or omitted, dst will contain normalized point coordinates.
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera matrix \f$\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients
        ///  \f$(k_1, k_2, p_1, p_2[, k_3[, k_4, k_5, k_6[, s_1, s_2, s_3, s_4[, \tau_x, \tau_y]]]])\f$
        ///  of 4, 5, 8, 12 or 14 elements. If the vector is NULL/empty, the zero distortion coefficients are assumed.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space (3x3 matrix). R1 or R2 computed by
        ///  #stereoRectify can be passed here. If the matrix is empty, the identity transformation is used.
        /// </param>
        /// <param name="P">
        /// New camera matrix (3x3) or new projection matrix (3x4) \f$\begin{bmatrix} {f'}_x &amp; 0 &amp; {c'}_x &amp; t_x \\ 0 &amp; {f'}_y &amp; {c'}_y &amp; t_y \\ 0 &amp; 0 &amp; 1 &amp; t_z \end{bmatrix}\f$. P1 or P2 computed by
        ///  #stereoRectify can be passed here. If the matrix is empty, the identity new camera matrix is used.
        /// </param>
        public static void undistortPoints(MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            Mat src_mat = src;
            Mat dst_mat = dst;
            calib3d_Calib3d_undistortPoints_12(src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);


        }


        //
        // C++:  void cv::undistortPoints(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria)
        //

        /// <remarks>
        ///  @overload
        ///      @note Default version of #undistortPoints does 5 iterations to compute undistorted points.
        /// </remarks>
        public static void undistortPointsIter(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_undistortPointsIter_10(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, P.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon);


        }


        //
        // C++:  void cv::undistortImagePoints(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, TermCriteria arg1 = TermCriteria(TermCriteria::MAX_ITER + TermCriteria::EPS, 5, 0.01))
        //

        /// <summary>
        ///  Compute undistorted image points position
        /// </summary>
        /// <param name="src">
        /// Observed points position, 2xN/Nx2 1-channel or 1xN/Nx1 2-channel (CV_32FC2 or
        ///  CV_64FC2) (or vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="dst">
        /// Output undistorted points position (1xN/Nx1 2-channel or vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera matrix \f$\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Distortion coefficients
        /// </param>
        public static void undistortImagePoints(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, TermCriteria arg1)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();

            calib3d_Calib3d_undistortImagePoints_10(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, arg1.type, arg1.maxCount, arg1.epsilon);


        }

        /// <summary>
        ///  Compute undistorted image points position
        /// </summary>
        /// <param name="src">
        /// Observed points position, 2xN/Nx2 1-channel or 1xN/Nx1 2-channel (CV_32FC2 or
        ///  CV_64FC2) (or vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="dst">
        /// Output undistorted points position (1xN/Nx1 2-channel or vector&lt;Point2f&gt; ).
        /// </param>
        /// <param name="cameraMatrix">
        /// Camera matrix \f$\vecthreethree{f_x}{0}{c_x}{0}{f_y}{c_y}{0}{0}{1}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Distortion coefficients
        /// </param>
        public static void undistortImagePoints(Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();

            calib3d_Calib3d_undistortImagePoints_11(src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);


        }


        //
        // C++:  void cv::fisheye::projectPoints(Mat objectPoints, Mat& imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha = 0, Mat& jacobian = Mat())
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static void fisheye_projectPoints(Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha, Mat jacobian)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (jacobian != null) jacobian.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1projectPoints_10(objectPoints.nativeObj, imagePoints.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, D.nativeObj, alpha, jacobian.nativeObj);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static void fisheye_projectPoints(Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1projectPoints_11(objectPoints.nativeObj, imagePoints.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, D.nativeObj, alpha);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static void fisheye_projectPoints(Mat objectPoints, Mat imagePoints, Mat rvec, Mat tvec, Mat K, Mat D)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1projectPoints_12(objectPoints.nativeObj, imagePoints.nativeObj, rvec.nativeObj, tvec.nativeObj, K.nativeObj, D.nativeObj);


        }


        //
        // C++:  void cv::fisheye::distortPoints(Mat undistorted, Mat& distorted, Mat K, Mat D, double alpha = 0)
        //

        /// <summary>
        ///  Distorts 2D points using fisheye model.
        /// </summary>
        /// <param name="undistorted">
        /// Array of object points, 1xN/Nx1 2-channel (or vector&lt;Point2f&gt; ), where N is
        ///      the number of points in the view.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="alpha">
        /// The skew coefficient.
        /// </param>
        /// <param name="distorted">
        /// Output array of image points, 1xN/Nx1 2-channel, or vector&lt;Point2f&gt; .
        /// </param>
        /// <remarks>
        ///      Note that the function assumes the camera intrinsic matrix of the undistorted points to be identity.
        ///      This means if you want to distort image points you have to multiply them with \f$K^{-1}\f$.
        /// </remarks>
        public static void fisheye_distortPoints(Mat undistorted, Mat distorted, Mat K, Mat D, double alpha)
        {
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (distorted != null) distorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1distortPoints_10(undistorted.nativeObj, distorted.nativeObj, K.nativeObj, D.nativeObj, alpha);


        }

        /// <summary>
        ///  Distorts 2D points using fisheye model.
        /// </summary>
        /// <param name="undistorted">
        /// Array of object points, 1xN/Nx1 2-channel (or vector&lt;Point2f&gt; ), where N is
        ///      the number of points in the view.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="alpha">
        /// The skew coefficient.
        /// </param>
        /// <param name="distorted">
        /// Output array of image points, 1xN/Nx1 2-channel, or vector&lt;Point2f&gt; .
        /// </param>
        /// <remarks>
        ///      Note that the function assumes the camera intrinsic matrix of the undistorted points to be identity.
        ///      This means if you want to distort image points you have to multiply them with \f$K^{-1}\f$.
        /// </remarks>
        public static void fisheye_distortPoints(Mat undistorted, Mat distorted, Mat K, Mat D)
        {
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (distorted != null) distorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1distortPoints_11(undistorted.nativeObj, distorted.nativeObj, K.nativeObj, D.nativeObj);


        }


        //
        // C++:  void cv::fisheye::undistortPoints(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat R = Mat(), Mat P = Mat(), TermCriteria criteria = TermCriteria(TermCriteria::MAX_ITER + TermCriteria::EPS, 10, 1e-8))
        //

        /// <summary>
        ///  Undistorts 2D points using fisheye model
        /// </summary>
        /// <param name="distorted">
        /// Array of object points, 1xN/Nx1 2-channel (or vector&lt;Point2f&gt; ), where N is the
        ///      number of points in the view.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="criteria">
        /// Termination criteria
        /// </param>
        /// <param name="undistorted">
        /// Output array of image points, 1xN/Nx1 2-channel, or vector&lt;Point2f&gt; .
        /// </param>
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D, Mat R, Mat P, TermCriteria criteria)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortPoints_10(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, R.nativeObj, P.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        /// <summary>
        ///  Undistorts 2D points using fisheye model
        /// </summary>
        /// <param name="distorted">
        /// Array of object points, 1xN/Nx1 2-channel (or vector&lt;Point2f&gt; ), where N is the
        ///      number of points in the view.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="criteria">
        /// Termination criteria
        /// </param>
        /// <param name="undistorted">
        /// Output array of image points, 1xN/Nx1 2-channel, or vector&lt;Point2f&gt; .
        /// </param>
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D, Mat R, Mat P)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortPoints_11(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, R.nativeObj, P.nativeObj);


        }

        /// <summary>
        ///  Undistorts 2D points using fisheye model
        /// </summary>
        /// <param name="distorted">
        /// Array of object points, 1xN/Nx1 2-channel (or vector&lt;Point2f&gt; ), where N is the
        ///      number of points in the view.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="criteria">
        /// Termination criteria
        /// </param>
        /// <param name="undistorted">
        /// Output array of image points, 1xN/Nx1 2-channel, or vector&lt;Point2f&gt; .
        /// </param>
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D, Mat R)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortPoints_12(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, R.nativeObj);


        }

        /// <summary>
        ///  Undistorts 2D points using fisheye model
        /// </summary>
        /// <param name="distorted">
        /// Array of object points, 1xN/Nx1 2-channel (or vector&lt;Point2f&gt; ), where N is the
        ///      number of points in the view.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="criteria">
        /// Termination criteria
        /// </param>
        /// <param name="undistorted">
        /// Output array of image points, 1xN/Nx1 2-channel, or vector&lt;Point2f&gt; .
        /// </param>
        public static void fisheye_undistortPoints(Mat distorted, Mat undistorted, Mat K, Mat D)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortPoints_13(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj);


        }


        //
        // C++:  void cv::fisheye::initUndistortRectifyMap(Mat K, Mat D, Mat R, Mat P, Size size, int m1type, Mat& map1, Mat& map2)
        //

        /// <summary>
        ///  Computes undistortion and rectification maps for image transform by #remap. If D is empty zero
        ///      distortion is used, if R or P is empty identity matrixes are used.
        /// </summary>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="size">
        /// Undistorted image size.
        /// </param>
        /// <param name="m1type">
        /// Type of the first output map that can be CV_32FC1 or CV_16SC2 . See #convertMaps
        ///      for details.
        /// </param>
        /// <param name="map1">
        /// The first output map.
        /// </param>
        /// <param name="map2">
        /// The second output map.
        /// </param>
        public static void fisheye_initUndistortRectifyMap(Mat K, Mat D, Mat R, Mat P, Size size, int m1type, Mat map1, Mat map2)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();
            if (map1 != null) map1.ThrowIfDisposed();
            if (map2 != null) map2.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1initUndistortRectifyMap_10(K.nativeObj, D.nativeObj, R.nativeObj, P.nativeObj, size.width, size.height, m1type, map1.nativeObj, map2.nativeObj);


        }


        //
        // C++:  void cv::fisheye::undistortImage(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat Knew = cv::Mat(), Size new_size = Size())
        //

        /// <summary>
        ///  Transforms an image to compensate for fisheye lens distortion.
        /// </summary>
        /// <param name="distorted">
        /// image with fisheye lens distortion.
        /// </param>
        /// <param name="undistorted">
        /// Output image with compensated fisheye lens distortion.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="Knew">
        /// Camera intrinsic matrix of the distorted image. By default, it is the identity matrix but you
        ///      may additionally scale and shift the result by using a different matrix.
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <remarks>
        ///      The function transforms an image to compensate radial and tangential lens distortion.
        ///  
        ///      The function is simply a combination of #fisheye::initUndistortRectifyMap (with unity R ) and #remap
        ///      (with bilinear interpolation). See the former function for details of the transformation being
        ///      performed.
        ///  
        ///      See below the results of undistortImage.
        ///         -   a\) result of undistort of perspective camera model (all possible coefficients (k_1, k_2, k_3,
        ///              k_4, k_5, k_6) of distortion were optimized under calibration)
        ///          -   b\) result of #fisheye::undistortImage of fisheye camera model (all possible coefficients (k_1, k_2,
        ///              k_3, k_4) of fisheye distortion were optimized under calibration)
        ///          -   c\) original image was captured with fisheye lens
        ///  
        ///      Pictures a) and b) almost the same. But if we consider points of image located far from the center
        ///      of image, we can notice that on image a) these points are distorted.
        ///  
        ///      ![image](pics/fisheye_undistorted.jpg)
        /// </remarks>
        public static void fisheye_undistortImage(Mat distorted, Mat undistorted, Mat K, Mat D, Mat Knew, Size new_size)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (Knew != null) Knew.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortImage_10(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, Knew.nativeObj, new_size.width, new_size.height);


        }

        /// <summary>
        ///  Transforms an image to compensate for fisheye lens distortion.
        /// </summary>
        /// <param name="distorted">
        /// image with fisheye lens distortion.
        /// </param>
        /// <param name="undistorted">
        /// Output image with compensated fisheye lens distortion.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="Knew">
        /// Camera intrinsic matrix of the distorted image. By default, it is the identity matrix but you
        ///      may additionally scale and shift the result by using a different matrix.
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <remarks>
        ///      The function transforms an image to compensate radial and tangential lens distortion.
        ///  
        ///      The function is simply a combination of #fisheye::initUndistortRectifyMap (with unity R ) and #remap
        ///      (with bilinear interpolation). See the former function for details of the transformation being
        ///      performed.
        ///  
        ///      See below the results of undistortImage.
        ///         -   a\) result of undistort of perspective camera model (all possible coefficients (k_1, k_2, k_3,
        ///              k_4, k_5, k_6) of distortion were optimized under calibration)
        ///          -   b\) result of #fisheye::undistortImage of fisheye camera model (all possible coefficients (k_1, k_2,
        ///              k_3, k_4) of fisheye distortion were optimized under calibration)
        ///          -   c\) original image was captured with fisheye lens
        ///  
        ///      Pictures a) and b) almost the same. But if we consider points of image located far from the center
        ///      of image, we can notice that on image a) these points are distorted.
        ///  
        ///      ![image](pics/fisheye_undistorted.jpg)
        /// </remarks>
        public static void fisheye_undistortImage(Mat distorted, Mat undistorted, Mat K, Mat D, Mat Knew)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (Knew != null) Knew.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortImage_11(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj, Knew.nativeObj);


        }

        /// <summary>
        ///  Transforms an image to compensate for fisheye lens distortion.
        /// </summary>
        /// <param name="distorted">
        /// image with fisheye lens distortion.
        /// </param>
        /// <param name="undistorted">
        /// Output image with compensated fisheye lens distortion.
        /// </param>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="Knew">
        /// Camera intrinsic matrix of the distorted image. By default, it is the identity matrix but you
        ///      may additionally scale and shift the result by using a different matrix.
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <remarks>
        ///      The function transforms an image to compensate radial and tangential lens distortion.
        ///  
        ///      The function is simply a combination of #fisheye::initUndistortRectifyMap (with unity R ) and #remap
        ///      (with bilinear interpolation). See the former function for details of the transformation being
        ///      performed.
        ///  
        ///      See below the results of undistortImage.
        ///         -   a\) result of undistort of perspective camera model (all possible coefficients (k_1, k_2, k_3,
        ///              k_4, k_5, k_6) of distortion were optimized under calibration)
        ///          -   b\) result of #fisheye::undistortImage of fisheye camera model (all possible coefficients (k_1, k_2,
        ///              k_3, k_4) of fisheye distortion were optimized under calibration)
        ///          -   c\) original image was captured with fisheye lens
        ///  
        ///      Pictures a) and b) almost the same. But if we consider points of image located far from the center
        ///      of image, we can notice that on image a) these points are distorted.
        ///  
        ///      ![image](pics/fisheye_undistorted.jpg)
        /// </remarks>
        public static void fisheye_undistortImage(Mat distorted, Mat undistorted, Mat K, Mat D)
        {
            if (distorted != null) distorted.ThrowIfDisposed();
            if (undistorted != null) undistorted.ThrowIfDisposed();
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1undistortImage_12(distorted.nativeObj, undistorted.nativeObj, K.nativeObj, D.nativeObj);


        }


        //
        // C++:  void cv::fisheye::estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat& P, double balance = 0.0, Size new_size = Size(), double fov_scale = 1.0)
        //

        /// <summary>
        ///  Estimates new camera intrinsic matrix for undistortion or rectification.
        /// </summary>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="image_size">
        /// Size of the image
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P, double balance, Size new_size, double fov_scale)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_10(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj, balance, new_size.width, new_size.height, fov_scale);


        }

        /// <summary>
        ///  Estimates new camera intrinsic matrix for undistortion or rectification.
        /// </summary>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="image_size">
        /// Size of the image
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P, double balance, Size new_size)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_11(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj, balance, new_size.width, new_size.height);


        }

        /// <summary>
        ///  Estimates new camera intrinsic matrix for undistortion or rectification.
        /// </summary>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="image_size">
        /// Size of the image
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P, double balance)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_12(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj, balance);


        }

        /// <summary>
        ///  Estimates new camera intrinsic matrix for undistortion or rectification.
        /// </summary>
        /// <param name="K">
        /// Camera intrinsic matrix \f$cameramatrix{K}\f$.
        /// </param>
        /// <param name="image_size">
        /// Size of the image
        /// </param>
        /// <param name="D">
        /// Input vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="R">
        /// Rectification transformation in the object space: 3x3 1-channel, or vector: 3x1/1x3
        ///      1-channel or 1x1 3-channel
        /// </param>
        /// <param name="P">
        /// New camera intrinsic matrix (3x3) or new projection matrix (3x4)
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="new_size">
        /// the new size
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat P)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (P != null) P.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_13(K.nativeObj, D.nativeObj, image_size.width, image_size.height, R.nativeObj, P.nativeObj);


        }


        //
        // C++:  double cv::fisheye::calibrate(vector_Mat objectPoints, vector_Mat imagePoints, Size image_size, Mat& K, Mat& D, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        //

        /// <summary>
        ///  Performs camera calibration
        /// </summary>
        /// <param name="objectPoints">
        /// vector of vectors of calibration pattern points in the calibration pattern
        ///      coordinate space.
        /// </param>
        /// <param name="imagePoints">
        /// vector of vectors of the projections of calibration pattern points.
        ///      imagePoints.size() and objectPoints.size() and imagePoints[i].size() must be equal to
        ///      objectPoints[i].size() for each i.
        /// </param>
        /// <param name="image_size">
        /// Size of the image used only to initialize the camera intrinsic matrix.
        /// </param>
        /// <param name="K">
        /// Output 3x3 floating-point camera intrinsic matrix
        ///      \f$\cameramatrix{A}\f$ . If
        ///      @ref fisheye::CALIB_USE_INTRINSIC_GUESS is specified, some or all of fx, fy, cx, cy must be
        ///      initialized before calling the function.
        /// </param>
        /// <param name="D">
        /// Output vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors (see Rodrigues ) estimated for each pattern view.
        ///      That is, each k-th rotation vector together with the corresponding k-th translation vector (see
        ///      the next output parameter description) brings the calibration pattern from the model coordinate
        ///      space (in which object points are specified) to the world coordinate space, that is, a real
        ///      position of the calibration pattern in the k-th pattern view (k=0.. *M* -1).
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///      -    @ref fisheye::CALIB_USE_INTRINSIC_GUESS  cameraMatrix contains valid initial values of
        ///      fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///      center ( imageSize is used), and focal distances are computed in a least-squares fashion.
        ///      -    @ref fisheye::CALIB_RECOMPUTE_EXTRINSIC  Extrinsic will be recomputed after each iteration
        ///      of intrinsic optimization.
        ///      -    @ref fisheye::CALIB_CHECK_COND  The functions will check validity of condition number.
        ///      -    @ref fisheye::CALIB_FIX_SKEW  Skew coefficient (alpha) is set to zero and stay zero.
        ///      -    @ref fisheye::CALIB_FIX_K1,..., @ref fisheye::CALIB_FIX_K4 Selected distortion coefficients
        ///      are set to zeros and stay zero.
        ///      -    @ref fisheye::CALIB_FIX_PRINCIPAL_POINT  The principal point is not changed during the global
        ///  optimization. It stays at the center or at a different location specified when @ref fisheye::CALIB_USE_INTRINSIC_GUESS is set too.
        ///      -    @ref fisheye::CALIB_FIX_FOCAL_LENGTH The focal length is not changed during the global
        ///  optimization. It is the \f$max(width,height)/\pi\f$ or the provided \f$f_x\f$, \f$f_y\f$ when @ref fisheye::CALIB_USE_INTRINSIC_GUESS is set too.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        public static double fisheye_calibrate(List<Mat> objectPoints, List<Mat> imagePoints, Size image_size, Mat K, Mat D, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_fisheye_1calibrate_10(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, image_size.width, image_size.height, K.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Performs camera calibration
        /// </summary>
        /// <param name="objectPoints">
        /// vector of vectors of calibration pattern points in the calibration pattern
        ///      coordinate space.
        /// </param>
        /// <param name="imagePoints">
        /// vector of vectors of the projections of calibration pattern points.
        ///      imagePoints.size() and objectPoints.size() and imagePoints[i].size() must be equal to
        ///      objectPoints[i].size() for each i.
        /// </param>
        /// <param name="image_size">
        /// Size of the image used only to initialize the camera intrinsic matrix.
        /// </param>
        /// <param name="K">
        /// Output 3x3 floating-point camera intrinsic matrix
        ///      \f$\cameramatrix{A}\f$ . If
        ///      @ref fisheye::CALIB_USE_INTRINSIC_GUESS is specified, some or all of fx, fy, cx, cy must be
        ///      initialized before calling the function.
        /// </param>
        /// <param name="D">
        /// Output vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors (see Rodrigues ) estimated for each pattern view.
        ///      That is, each k-th rotation vector together with the corresponding k-th translation vector (see
        ///      the next output parameter description) brings the calibration pattern from the model coordinate
        ///      space (in which object points are specified) to the world coordinate space, that is, a real
        ///      position of the calibration pattern in the k-th pattern view (k=0.. *M* -1).
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///      -    @ref fisheye::CALIB_USE_INTRINSIC_GUESS  cameraMatrix contains valid initial values of
        ///      fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///      center ( imageSize is used), and focal distances are computed in a least-squares fashion.
        ///      -    @ref fisheye::CALIB_RECOMPUTE_EXTRINSIC  Extrinsic will be recomputed after each iteration
        ///      of intrinsic optimization.
        ///      -    @ref fisheye::CALIB_CHECK_COND  The functions will check validity of condition number.
        ///      -    @ref fisheye::CALIB_FIX_SKEW  Skew coefficient (alpha) is set to zero and stay zero.
        ///      -    @ref fisheye::CALIB_FIX_K1,..., @ref fisheye::CALIB_FIX_K4 Selected distortion coefficients
        ///      are set to zeros and stay zero.
        ///      -    @ref fisheye::CALIB_FIX_PRINCIPAL_POINT  The principal point is not changed during the global
        ///  optimization. It stays at the center or at a different location specified when @ref fisheye::CALIB_USE_INTRINSIC_GUESS is set too.
        ///      -    @ref fisheye::CALIB_FIX_FOCAL_LENGTH The focal length is not changed during the global
        ///  optimization. It is the \f$max(width,height)/\pi\f$ or the provided \f$f_x\f$, \f$f_y\f$ when @ref fisheye::CALIB_USE_INTRINSIC_GUESS is set too.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        public static double fisheye_calibrate(List<Mat> objectPoints, List<Mat> imagePoints, Size image_size, Mat K, Mat D, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_fisheye_1calibrate_11(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, image_size.width, image_size.height, K.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Performs camera calibration
        /// </summary>
        /// <param name="objectPoints">
        /// vector of vectors of calibration pattern points in the calibration pattern
        ///      coordinate space.
        /// </param>
        /// <param name="imagePoints">
        /// vector of vectors of the projections of calibration pattern points.
        ///      imagePoints.size() and objectPoints.size() and imagePoints[i].size() must be equal to
        ///      objectPoints[i].size() for each i.
        /// </param>
        /// <param name="image_size">
        /// Size of the image used only to initialize the camera intrinsic matrix.
        /// </param>
        /// <param name="K">
        /// Output 3x3 floating-point camera intrinsic matrix
        ///      \f$\cameramatrix{A}\f$ . If
        ///      @ref fisheye::CALIB_USE_INTRINSIC_GUESS is specified, some or all of fx, fy, cx, cy must be
        ///      initialized before calling the function.
        /// </param>
        /// <param name="D">
        /// Output vector of distortion coefficients \f$\distcoeffsfisheye\f$.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors (see Rodrigues ) estimated for each pattern view.
        ///      That is, each k-th rotation vector together with the corresponding k-th translation vector (see
        ///      the next output parameter description) brings the calibration pattern from the model coordinate
        ///      space (in which object points are specified) to the world coordinate space, that is, a real
        ///      position of the calibration pattern in the k-th pattern view (k=0.. *M* -1).
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view.
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///      -    @ref fisheye::CALIB_USE_INTRINSIC_GUESS  cameraMatrix contains valid initial values of
        ///      fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///      center ( imageSize is used), and focal distances are computed in a least-squares fashion.
        ///      -    @ref fisheye::CALIB_RECOMPUTE_EXTRINSIC  Extrinsic will be recomputed after each iteration
        ///      of intrinsic optimization.
        ///      -    @ref fisheye::CALIB_CHECK_COND  The functions will check validity of condition number.
        ///      -    @ref fisheye::CALIB_FIX_SKEW  Skew coefficient (alpha) is set to zero and stay zero.
        ///      -    @ref fisheye::CALIB_FIX_K1,..., @ref fisheye::CALIB_FIX_K4 Selected distortion coefficients
        ///      are set to zeros and stay zero.
        ///      -    @ref fisheye::CALIB_FIX_PRINCIPAL_POINT  The principal point is not changed during the global
        ///  optimization. It stays at the center or at a different location specified when @ref fisheye::CALIB_USE_INTRINSIC_GUESS is set too.
        ///      -    @ref fisheye::CALIB_FIX_FOCAL_LENGTH The focal length is not changed during the global
        ///  optimization. It is the \f$max(width,height)/\pi\f$ or the provided \f$f_x\f$, \f$f_y\f$ when @ref fisheye::CALIB_USE_INTRINSIC_GUESS is set too.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        public static double fisheye_calibrate(List<Mat> objectPoints, List<Mat> imagePoints, Size image_size, Mat K, Mat D, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (K != null) K.ThrowIfDisposed();
            if (D != null) D.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints_mat = Converters.vector_Mat_to_Mat(imagePoints);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_fisheye_1calibrate_12(objectPoints_mat.nativeObj, imagePoints_mat.nativeObj, image_size.width, image_size.height, K.nativeObj, D.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  void cv::fisheye::stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags, Size newImageSize = Size(), double balance = 0.0, double fov_scale = 1.0)
        //

        /// <summary>
        ///  Stereo rectification for fisheye camera model
        /// </summary>
        /// <param name="K1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="D1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="K2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="D2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix between the coordinate systems of the first and the second
        ///      cameras.
        /// </param>
        /// <param name="tvec">
        /// Translation vector between coordinate systems of the cameras.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///      camera.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///      camera.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see #reprojectImageTo3D ).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref fisheye::CALIB_ZERO_DISPARITY . If the flag is set,
        ///      the function makes the principal points of each camera have the same pixel coordinates in the
        ///      rectified views. And if the flag is not set, the function may still shift the images in the
        ///      horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///      useful image area.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///      #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///      is passed (default), it is set to the original imageSize . Setting it to larger value can help you
        ///      preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size newImageSize, double balance, double fov_scale)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1stereoRectify_10(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, newImageSize.width, newImageSize.height, balance, fov_scale);


        }

        /// <summary>
        ///  Stereo rectification for fisheye camera model
        /// </summary>
        /// <param name="K1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="D1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="K2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="D2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix between the coordinate systems of the first and the second
        ///      cameras.
        /// </param>
        /// <param name="tvec">
        /// Translation vector between coordinate systems of the cameras.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///      camera.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///      camera.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see #reprojectImageTo3D ).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref fisheye::CALIB_ZERO_DISPARITY . If the flag is set,
        ///      the function makes the principal points of each camera have the same pixel coordinates in the
        ///      rectified views. And if the flag is not set, the function may still shift the images in the
        ///      horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///      useful image area.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///      #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///      is passed (default), it is set to the original imageSize . Setting it to larger value can help you
        ///      preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size newImageSize, double balance)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1stereoRectify_11(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, newImageSize.width, newImageSize.height, balance);


        }

        /// <summary>
        ///  Stereo rectification for fisheye camera model
        /// </summary>
        /// <param name="K1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="D1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="K2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="D2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix between the coordinate systems of the first and the second
        ///      cameras.
        /// </param>
        /// <param name="tvec">
        /// Translation vector between coordinate systems of the cameras.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///      camera.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///      camera.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see #reprojectImageTo3D ).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref fisheye::CALIB_ZERO_DISPARITY . If the flag is set,
        ///      the function makes the principal points of each camera have the same pixel coordinates in the
        ///      rectified views. And if the flag is not set, the function may still shift the images in the
        ///      horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///      useful image area.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///      #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///      is passed (default), it is set to the original imageSize . Setting it to larger value can help you
        ///      preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags, Size newImageSize)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1stereoRectify_12(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags, newImageSize.width, newImageSize.height);


        }

        /// <summary>
        ///  Stereo rectification for fisheye camera model
        /// </summary>
        /// <param name="K1">
        /// First camera intrinsic matrix.
        /// </param>
        /// <param name="D1">
        /// First camera distortion parameters.
        /// </param>
        /// <param name="K2">
        /// Second camera intrinsic matrix.
        /// </param>
        /// <param name="D2">
        /// Second camera distortion parameters.
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used for stereo calibration.
        /// </param>
        /// <param name="R">
        /// Rotation matrix between the coordinate systems of the first and the second
        ///      cameras.
        /// </param>
        /// <param name="tvec">
        /// Translation vector between coordinate systems of the cameras.
        /// </param>
        /// <param name="R1">
        /// Output 3x3 rectification transform (rotation matrix) for the first camera.
        /// </param>
        /// <param name="R2">
        /// Output 3x3 rectification transform (rotation matrix) for the second camera.
        /// </param>
        /// <param name="P1">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the first
        ///      camera.
        /// </param>
        /// <param name="P2">
        /// Output 3x4 projection matrix in the new (rectified) coordinate systems for the second
        ///      camera.
        /// </param>
        /// <param name="Q">
        /// Output \f$4 \times 4\f$ disparity-to-depth mapping matrix (see #reprojectImageTo3D ).
        /// </param>
        /// <param name="flags">
        /// Operation flags that may be zero or @ref fisheye::CALIB_ZERO_DISPARITY . If the flag is set,
        ///      the function makes the principal points of each camera have the same pixel coordinates in the
        ///      rectified views. And if the flag is not set, the function may still shift the images in the
        ///      horizontal or vertical direction (depending on the orientation of epipolar lines) to maximize the
        ///      useful image area.
        /// </param>
        /// <param name="newImageSize">
        /// New image resolution after rectification. The same size should be passed to
        ///      #initUndistortRectifyMap (see the stereo_calib.cpp sample in OpenCV samples directory). When (0,0)
        ///      is passed (default), it is set to the original imageSize . Setting it to larger value can help you
        ///      preserve details in the original image, especially when there is a big radial distortion.
        /// </param>
        /// <param name="balance">
        /// Sets the new focal length in range between the min focal length and the max focal
        ///      length. Balance is in range of [0, 1].
        /// </param>
        /// <param name="fov_scale">
        /// Divisor for new focal length.
        /// </param>
        public static void fisheye_stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat R1, Mat R2, Mat P1, Mat P2, Mat Q, int flags)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();
            if (R1 != null) R1.ThrowIfDisposed();
            if (R2 != null) R2.ThrowIfDisposed();
            if (P1 != null) P1.ThrowIfDisposed();
            if (P2 != null) P2.ThrowIfDisposed();
            if (Q != null) Q.ThrowIfDisposed();

            calib3d_Calib3d_fisheye_1stereoRectify_13(K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, tvec.nativeObj, R1.nativeObj, R2.nativeObj, P1.nativeObj, P2.nativeObj, Q.nativeObj, flags);


        }


        //
        // C++:  double cv::fisheye::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& K1, Mat& D1, Mat& K2, Mat& D2, Size imageSize, Mat& R, Mat& T, vector_Mat& rvecs, vector_Mat& tvecs, int flags = fisheye::CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        //

        /// <summary>
        ///  Performs stereo calibration
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points.
        /// </param>
        /// <param name="imagePoints1">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///      observed by the first camera.
        /// </param>
        /// <param name="imagePoints2">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///      observed by the second camera.
        /// </param>
        /// <param name="K1">
        /// Input/output first camera intrinsic matrix:
        ///      \f$\vecthreethree{f_x^{(j)}}{0}{c_x^{(j)}}{0}{f_y^{(j)}}{c_y^{(j)}}{0}{0}{1}\f$ , \f$j = 0,\, 1\f$ . If
        ///      any of @ref fisheye::CALIB_USE_INTRINSIC_GUESS , @ref fisheye::CALIB_FIX_INTRINSIC are specified,
        ///      some or all of the matrix components must be initialized.
        /// </param>
        /// <param name="D1">
        /// Input/output vector of distortion coefficients \f$\distcoeffsfisheye\f$ of 4 elements.
        /// </param>
        /// <param name="K2">
        /// Input/output second camera intrinsic matrix. The parameter is similar to K1 .
        /// </param>
        /// <param name="D2">
        /// Input/output lens distortion coefficients for the second camera. The parameter is
        ///      similar to D1 .
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix between the 1st and the 2nd camera coordinate systems.
        /// </param>
        /// <param name="T">
        /// Output translation vector between the coordinate systems of the cameras.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors ( @ref Rodrigues ) estimated for each pattern view in the
        ///      coordinate system of the first camera of the stereo pair (e.g. std::vector&lt;cv::Mat&gt;). More in detail, each
        ///      i-th rotation vector together with the corresponding i-th translation vector (see the next output parameter
        ///      description) brings the calibration pattern from the object coordinate space (in which object points are
        ///      specified) to the camera coordinate space of the first camera of the stereo pair. In more technical terms,
        ///      the tuple of the i-th rotation and translation vector performs a change of basis from object coordinate space
        ///      to camera coordinate space of the first camera of the stereo pair.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter description
        ///      of previous output parameter ( rvecs ).
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///      -    @ref fisheye::CALIB_FIX_INTRINSIC  Fix K1, K2? and D1, D2? so that only R, T matrices
        ///      are estimated.
        ///      -    @ref fisheye::CALIB_USE_INTRINSIC_GUESS  K1, K2 contains valid initial values of
        ///      fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///      center (imageSize is used), and focal distances are computed in a least-squares fashion.
        ///      -    @ref fisheye::CALIB_RECOMPUTE_EXTRINSIC  Extrinsic will be recomputed after each iteration
        ///      of intrinsic optimization.
        ///      -    @ref fisheye::CALIB_CHECK_COND  The functions will check validity of condition number.
        ///      -    @ref fisheye::CALIB_FIX_SKEW  Skew coefficient (alpha) is set to zero and stay zero.
        ///      -   @ref fisheye::CALIB_FIX_K1,..., @ref fisheye::CALIB_FIX_K4 Selected distortion coefficients are set to zeros and stay
        ///      zero.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, List<Mat> rvecs, List<Mat> tvecs, int flags, TermCriteria criteria)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_fisheye_1stereoCalibrate_10(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Performs stereo calibration
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points.
        /// </param>
        /// <param name="imagePoints1">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///      observed by the first camera.
        /// </param>
        /// <param name="imagePoints2">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///      observed by the second camera.
        /// </param>
        /// <param name="K1">
        /// Input/output first camera intrinsic matrix:
        ///      \f$\vecthreethree{f_x^{(j)}}{0}{c_x^{(j)}}{0}{f_y^{(j)}}{c_y^{(j)}}{0}{0}{1}\f$ , \f$j = 0,\, 1\f$ . If
        ///      any of @ref fisheye::CALIB_USE_INTRINSIC_GUESS , @ref fisheye::CALIB_FIX_INTRINSIC are specified,
        ///      some or all of the matrix components must be initialized.
        /// </param>
        /// <param name="D1">
        /// Input/output vector of distortion coefficients \f$\distcoeffsfisheye\f$ of 4 elements.
        /// </param>
        /// <param name="K2">
        /// Input/output second camera intrinsic matrix. The parameter is similar to K1 .
        /// </param>
        /// <param name="D2">
        /// Input/output lens distortion coefficients for the second camera. The parameter is
        ///      similar to D1 .
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix between the 1st and the 2nd camera coordinate systems.
        /// </param>
        /// <param name="T">
        /// Output translation vector between the coordinate systems of the cameras.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors ( @ref Rodrigues ) estimated for each pattern view in the
        ///      coordinate system of the first camera of the stereo pair (e.g. std::vector&lt;cv::Mat&gt;). More in detail, each
        ///      i-th rotation vector together with the corresponding i-th translation vector (see the next output parameter
        ///      description) brings the calibration pattern from the object coordinate space (in which object points are
        ///      specified) to the camera coordinate space of the first camera of the stereo pair. In more technical terms,
        ///      the tuple of the i-th rotation and translation vector performs a change of basis from object coordinate space
        ///      to camera coordinate space of the first camera of the stereo pair.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter description
        ///      of previous output parameter ( rvecs ).
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///      -    @ref fisheye::CALIB_FIX_INTRINSIC  Fix K1, K2? and D1, D2? so that only R, T matrices
        ///      are estimated.
        ///      -    @ref fisheye::CALIB_USE_INTRINSIC_GUESS  K1, K2 contains valid initial values of
        ///      fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///      center (imageSize is used), and focal distances are computed in a least-squares fashion.
        ///      -    @ref fisheye::CALIB_RECOMPUTE_EXTRINSIC  Extrinsic will be recomputed after each iteration
        ///      of intrinsic optimization.
        ///      -    @ref fisheye::CALIB_CHECK_COND  The functions will check validity of condition number.
        ///      -    @ref fisheye::CALIB_FIX_SKEW  Skew coefficient (alpha) is set to zero and stay zero.
        ///      -   @ref fisheye::CALIB_FIX_K1,..., @ref fisheye::CALIB_FIX_K4 Selected distortion coefficients are set to zeros and stay
        ///      zero.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, List<Mat> rvecs, List<Mat> tvecs, int flags)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_fisheye_1stereoCalibrate_11(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj, flags);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }

        /// <summary>
        ///  Performs stereo calibration
        /// </summary>
        /// <param name="objectPoints">
        /// Vector of vectors of the calibration pattern points.
        /// </param>
        /// <param name="imagePoints1">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///      observed by the first camera.
        /// </param>
        /// <param name="imagePoints2">
        /// Vector of vectors of the projections of the calibration pattern points,
        ///      observed by the second camera.
        /// </param>
        /// <param name="K1">
        /// Input/output first camera intrinsic matrix:
        ///      \f$\vecthreethree{f_x^{(j)}}{0}{c_x^{(j)}}{0}{f_y^{(j)}}{c_y^{(j)}}{0}{0}{1}\f$ , \f$j = 0,\, 1\f$ . If
        ///      any of @ref fisheye::CALIB_USE_INTRINSIC_GUESS , @ref fisheye::CALIB_FIX_INTRINSIC are specified,
        ///      some or all of the matrix components must be initialized.
        /// </param>
        /// <param name="D1">
        /// Input/output vector of distortion coefficients \f$\distcoeffsfisheye\f$ of 4 elements.
        /// </param>
        /// <param name="K2">
        /// Input/output second camera intrinsic matrix. The parameter is similar to K1 .
        /// </param>
        /// <param name="D2">
        /// Input/output lens distortion coefficients for the second camera. The parameter is
        ///      similar to D1 .
        /// </param>
        /// <param name="imageSize">
        /// Size of the image used only to initialize camera intrinsic matrix.
        /// </param>
        /// <param name="R">
        /// Output rotation matrix between the 1st and the 2nd camera coordinate systems.
        /// </param>
        /// <param name="T">
        /// Output translation vector between the coordinate systems of the cameras.
        /// </param>
        /// <param name="rvecs">
        /// Output vector of rotation vectors ( @ref Rodrigues ) estimated for each pattern view in the
        ///      coordinate system of the first camera of the stereo pair (e.g. std::vector&lt;cv::Mat&gt;). More in detail, each
        ///      i-th rotation vector together with the corresponding i-th translation vector (see the next output parameter
        ///      description) brings the calibration pattern from the object coordinate space (in which object points are
        ///      specified) to the camera coordinate space of the first camera of the stereo pair. In more technical terms,
        ///      the tuple of the i-th rotation and translation vector performs a change of basis from object coordinate space
        ///      to camera coordinate space of the first camera of the stereo pair.
        /// </param>
        /// <param name="tvecs">
        /// Output vector of translation vectors estimated for each pattern view, see parameter description
        ///      of previous output parameter ( rvecs ).
        /// </param>
        /// <param name="flags">
        /// Different flags that may be zero or a combination of the following values:
        ///      -    @ref fisheye::CALIB_FIX_INTRINSIC  Fix K1, K2? and D1, D2? so that only R, T matrices
        ///      are estimated.
        ///      -    @ref fisheye::CALIB_USE_INTRINSIC_GUESS  K1, K2 contains valid initial values of
        ///      fx, fy, cx, cy that are optimized further. Otherwise, (cx, cy) is initially set to the image
        ///      center (imageSize is used), and focal distances are computed in a least-squares fashion.
        ///      -    @ref fisheye::CALIB_RECOMPUTE_EXTRINSIC  Extrinsic will be recomputed after each iteration
        ///      of intrinsic optimization.
        ///      -    @ref fisheye::CALIB_CHECK_COND  The functions will check validity of condition number.
        ///      -    @ref fisheye::CALIB_FIX_SKEW  Skew coefficient (alpha) is set to zero and stay zero.
        ///      -   @ref fisheye::CALIB_FIX_K1,..., @ref fisheye::CALIB_FIX_K4 Selected distortion coefficients are set to zeros and stay
        ///      zero.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for the iterative optimization algorithm.
        /// </param>
        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, List<Mat> rvecs, List<Mat> tvecs)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            Mat rvecs_mat = new Mat();
            Mat tvecs_mat = new Mat();
            double retVal = calib3d_Calib3d_fisheye_1stereoCalibrate_12(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, rvecs_mat.nativeObj, tvecs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(rvecs_mat, rvecs);
            rvecs_mat.release();
            Converters.Mat_to_vector_Mat(tvecs_mat, tvecs);
            tvecs_mat.release();
            return retVal;
        }


        //
        // C++:  double cv::fisheye::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& K1, Mat& D1, Mat& K2, Mat& D2, Size imageSize, Mat& R, Mat& T, int flags = fisheye::CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        //

        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, int flags, TermCriteria criteria)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_fisheye_1stereoCalibrate_13(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, flags, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T, int flags)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_fisheye_1stereoCalibrate_14(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj, flags);


        }

        public static double fisheye_stereoCalibrate(List<Mat> objectPoints, List<Mat> imagePoints1, List<Mat> imagePoints2, Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat T)
        {
            if (K1 != null) K1.ThrowIfDisposed();
            if (D1 != null) D1.ThrowIfDisposed();
            if (K2 != null) K2.ThrowIfDisposed();
            if (D2 != null) D2.ThrowIfDisposed();
            if (R != null) R.ThrowIfDisposed();
            if (T != null) T.ThrowIfDisposed();
            Mat objectPoints_mat = Converters.vector_Mat_to_Mat(objectPoints);
            Mat imagePoints1_mat = Converters.vector_Mat_to_Mat(imagePoints1);
            Mat imagePoints2_mat = Converters.vector_Mat_to_Mat(imagePoints2);
            return calib3d_Calib3d_fisheye_1stereoCalibrate_15(objectPoints_mat.nativeObj, imagePoints1_mat.nativeObj, imagePoints2_mat.nativeObj, K1.nativeObj, D1.nativeObj, K2.nativeObj, D2.nativeObj, imageSize.width, imageSize.height, R.nativeObj, T.nativeObj);


        }


        //
        // C++:  bool cv::fisheye::solvePnP(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int flags = SOLVEPNP_ITERATIVE, TermCriteria criteria = TermCriteria(TermCriteria::MAX_ITER + TermCriteria::EPS, 10, 1e-8))
        //

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences for fisheye camera moodel.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///      1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///      where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients (4x1/1x4).
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///      the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///      the provided rvec and tvec values as initial approximations of the rotation and translation
        ///      vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        ///      This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///      coordinate frame to the camera coordinate frame, using different methods:
        ///      - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///      - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///      - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///      Number of input points must be 4. Object points must be defined in the following order:
        ///      - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///      - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///      - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///      - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for internal undistortPoints call.
        ///      The function interally undistorts points with @ref undistortPoints and call @ref cv::solvePnP,
        ///      thus the input are very similar. Check there and Perspective-n-Points is described in @ref calib3d_solvePnP
        ///      for more information.
        /// </param>
        public static bool fisheye_solvePnP(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags, TermCriteria criteria)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            return calib3d_Calib3d_fisheye_1solvePnP_10(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, flags, criteria.type, criteria.maxCount, criteria.epsilon);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences for fisheye camera moodel.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///      1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///      where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients (4x1/1x4).
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///      the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///      the provided rvec and tvec values as initial approximations of the rotation and translation
        ///      vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        ///      This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///      coordinate frame to the camera coordinate frame, using different methods:
        ///      - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///      - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///      - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///      Number of input points must be 4. Object points must be defined in the following order:
        ///      - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///      - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///      - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///      - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for internal undistortPoints call.
        ///      The function interally undistorts points with @ref undistortPoints and call @ref cv::solvePnP,
        ///      thus the input are very similar. Check there and Perspective-n-Points is described in @ref calib3d_solvePnP
        ///      for more information.
        /// </param>
        public static bool fisheye_solvePnP(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess, int flags)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            return calib3d_Calib3d_fisheye_1solvePnP_11(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess, flags);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences for fisheye camera moodel.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///      1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///      where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients (4x1/1x4).
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///      the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///      the provided rvec and tvec values as initial approximations of the rotation and translation
        ///      vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        ///      This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///      coordinate frame to the camera coordinate frame, using different methods:
        ///      - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///      - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///      - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///      Number of input points must be 4. Object points must be defined in the following order:
        ///      - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///      - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///      - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///      - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for internal undistortPoints call.
        ///      The function interally undistorts points with @ref undistortPoints and call @ref cv::solvePnP,
        ///      thus the input are very similar. Check there and Perspective-n-Points is described in @ref calib3d_solvePnP
        ///      for more information.
        /// </param>
        public static bool fisheye_solvePnP(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, bool useExtrinsicGuess)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            return calib3d_Calib3d_fisheye_1solvePnP_12(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj, useExtrinsicGuess);


        }

        /// <summary>
        ///  Finds an object pose from 3D-2D point correspondences for fisheye camera moodel.
        /// </summary>
        /// <param name="objectPoints">
        /// Array of object points in the object coordinate space, Nx3 1-channel or
        ///      1xN/Nx1 3-channel, where N is the number of points. vector&lt;Point3d&gt; can be also passed here.
        /// </param>
        /// <param name="imagePoints">
        /// Array of corresponding image points, Nx2 1-channel or 1xN/Nx1 2-channel,
        ///      where N is the number of points. vector&lt;Point2d&gt; can be also passed here.
        /// </param>
        /// <param name="cameraMatrix">
        /// Input camera intrinsic matrix \f$\cameramatrix{A}\f$ .
        /// </param>
        /// <param name="distCoeffs">
        /// Input vector of distortion coefficients (4x1/1x4).
        /// </param>
        /// <param name="rvec">
        /// Output rotation vector (see @ref Rodrigues ) that, together with tvec, brings points from
        ///      the model coordinate system to the camera coordinate system.
        /// </param>
        /// <param name="tvec">
        /// Output translation vector.
        /// </param>
        /// <param name="useExtrinsicGuess">
        /// Parameter used for #SOLVEPNP_ITERATIVE. If true (1), the function uses
        ///      the provided rvec and tvec values as initial approximations of the rotation and translation
        ///      vectors, respectively, and further optimizes them.
        /// </param>
        /// <param name="flags">
        /// Method for solving a PnP problem: see @ref calib3d_solvePnP_flags
        ///      This function returns the rotation and the translation vectors that transform a 3D point expressed in the object
        ///      coordinate frame to the camera coordinate frame, using different methods:
        ///      - P3P methods (@ref SOLVEPNP_P3P, @ref SOLVEPNP_AP3P): need 4 input points to return a unique solution.
        ///      - @ref SOLVEPNP_IPPE Input points must be &gt;= 4 and object points must be coplanar.
        ///      - @ref SOLVEPNP_IPPE_SQUARE Special case suitable for marker pose estimation.
        ///      Number of input points must be 4. Object points must be defined in the following order:
        ///      - point 0: [-squareLength / 2,  squareLength / 2, 0]
        ///      - point 1: [ squareLength / 2,  squareLength / 2, 0]
        ///      - point 2: [ squareLength / 2, -squareLength / 2, 0]
        ///      - point 3: [-squareLength / 2, -squareLength / 2, 0]
        ///      - for all the other flags, number of input points must be &gt;= 4 and object points can be in any configuration.
        /// </param>
        /// <param name="criteria">
        /// Termination criteria for internal undistortPoints call.
        ///      The function interally undistorts points with @ref undistortPoints and call @ref cv::solvePnP,
        ///      thus the input are very similar. Check there and Perspective-n-Points is described in @ref calib3d_solvePnP
        ///      for more information.
        /// </param>
        public static bool fisheye_solvePnP(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec)
        {
            if (objectPoints != null) objectPoints.ThrowIfDisposed();
            if (imagePoints != null) imagePoints.ThrowIfDisposed();
            if (cameraMatrix != null) cameraMatrix.ThrowIfDisposed();
            if (distCoeffs != null) distCoeffs.ThrowIfDisposed();
            if (rvec != null) rvec.ThrowIfDisposed();
            if (tvec != null) tvec.ThrowIfDisposed();

            return calib3d_Calib3d_fisheye_1solvePnP_13(objectPoints.nativeObj, imagePoints.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, rvec.nativeObj, tvec.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::Rodrigues(Mat src, Mat& dst, Mat& jacobian = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_Rodrigues_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr jacobian_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_Rodrigues_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  Mat cv::findHomography(vector_Point2f srcPoints, vector_Point2f dstPoints, int method = 0, double ransacReprojThreshold = 3, Mat& mask = Mat(), int maxIters = 2000, double confidence = 0.995)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_10(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold, IntPtr mask_nativeObj, int maxIters, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_11(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold, IntPtr mask_nativeObj, int maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_12(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_13(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_14(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_15(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj);

        // C++:  Mat cv::findHomography(vector_Point2f srcPoints, vector_Point2f dstPoints, Mat& mask, UsacParams _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findHomography_16(IntPtr srcPoints_mat_nativeObj, IntPtr dstPoints_mat_nativeObj, IntPtr mask_nativeObj, IntPtr _params_nativeObj);

        // C++:  Vec3d cv::RQDecomp3x3(Mat src, Mat& mtxR, Mat& mtxQ, Mat& Qx = Mat(), Mat& Qy = Mat(), Mat& Qz = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_10(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, IntPtr Qx_nativeObj, IntPtr Qy_nativeObj, IntPtr Qz_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_11(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, IntPtr Qx_nativeObj, IntPtr Qy_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_12(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, IntPtr Qx_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_RQDecomp3x3_13(IntPtr src_nativeObj, IntPtr mtxR_nativeObj, IntPtr mtxQ_nativeObj, double[] retVal);

        // C++:  void cv::decomposeProjectionMatrix(Mat projMatrix, Mat& cameraMatrix, Mat& rotMatrix, Mat& transVect, Mat& rotMatrixX = Mat(), Mat& rotMatrixY = Mat(), Mat& rotMatrixZ = Mat(), Mat& eulerAngles = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_10(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj, IntPtr rotMatrixY_nativeObj, IntPtr rotMatrixZ_nativeObj, IntPtr eulerAngles_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_11(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj, IntPtr rotMatrixY_nativeObj, IntPtr rotMatrixZ_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_12(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj, IntPtr rotMatrixY_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_13(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj, IntPtr rotMatrixX_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeProjectionMatrix_14(IntPtr projMatrix_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr rotMatrix_nativeObj, IntPtr transVect_nativeObj);

        // C++:  void cv::matMulDeriv(Mat A, Mat B, Mat& dABdA, Mat& dABdB)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_matMulDeriv_10(IntPtr A_nativeObj, IntPtr B_nativeObj, IntPtr dABdA_nativeObj, IntPtr dABdB_nativeObj);

        // C++:  void cv::composeRT(Mat rvec1, Mat tvec1, Mat rvec2, Mat tvec2, Mat& rvec3, Mat& tvec3, Mat& dr3dr1 = Mat(), Mat& dr3dt1 = Mat(), Mat& dr3dr2 = Mat(), Mat& dr3dt2 = Mat(), Mat& dt3dr1 = Mat(), Mat& dt3dt1 = Mat(), Mat& dt3dr2 = Mat(), Mat& dt3dt2 = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_10(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj, IntPtr dt3dt1_nativeObj, IntPtr dt3dr2_nativeObj, IntPtr dt3dt2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_11(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj, IntPtr dt3dt1_nativeObj, IntPtr dt3dr2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_12(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj, IntPtr dt3dt1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_13(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj, IntPtr dt3dr1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_14(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj, IntPtr dr3dt2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_15(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj, IntPtr dr3dr2_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_16(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj, IntPtr dr3dt1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_17(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj, IntPtr dr3dr1_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_composeRT_18(IntPtr rvec1_nativeObj, IntPtr tvec1_nativeObj, IntPtr rvec2_nativeObj, IntPtr tvec2_nativeObj, IntPtr rvec3_nativeObj, IntPtr tvec3_nativeObj);

        // C++:  void cv::projectPoints(vector_Point3f objectPoints, Mat rvec, Mat tvec, Mat cameraMatrix, vector_double distCoeffs, vector_Point2f& imagePoints, Mat& jacobian = Mat(), double aspectRatio = 0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_projectPoints_10(IntPtr objectPoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr jacobian_nativeObj, double aspectRatio);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_projectPoints_11(IntPtr objectPoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr jacobian_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_projectPoints_12(IntPtr objectPoints_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr imagePoints_mat_nativeObj);

        // C++:  bool cv::solvePnP(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int flags = SOLVEPNP_ITERATIVE)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnP_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnP_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnP_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  bool cv::solvePnPRansac(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int iterationsCount = 100, float reprojectionError = 8.0, double confidence = 0.99, Mat& inliers = Mat(), int flags = SOLVEPNP_ITERATIVE)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, IntPtr inliers_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence, IntPtr inliers_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError, double confidence);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_13(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount, float reprojectionError);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_14(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int iterationsCount);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_15(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_16(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  bool cv::solvePnPRansac(vector_Point3f objectPoints, vector_Point2f imagePoints, Mat& cameraMatrix, vector_double distCoeffs, Mat& rvec, Mat& tvec, Mat& inliers, UsacParams _params = UsacParams())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_17(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr inliers_nativeObj, IntPtr _params_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_solvePnPRansac_18(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_mat_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr inliers_nativeObj);

        // C++:  int cv::solveP3P(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solveP3P_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);

        // C++:  void cv::solvePnPRefineLM(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, TermCriteria criteria = TermCriteria(TermCriteria::EPS + TermCriteria::COUNT, 20, FLT_EPSILON))
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_solvePnPRefineLM_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_solvePnPRefineLM_11(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  void cv::solvePnPRefineVVS(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, TermCriteria criteria = TermCriteria(TermCriteria::EPS + TermCriteria::COUNT, 20, FLT_EPSILON), double VVSlambda = 1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_solvePnPRefineVVS_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon, double VVSlambda);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_solvePnPRefineVVS_11(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_solvePnPRefineVVS_12(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

        // C++:  int cv::solvePnPGeneric(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, bool useExtrinsicGuess = false, SolvePnPMethod flags = SOLVEPNP_ITERATIVE, Mat rvec = Mat(), Mat tvec = Mat(), Mat& reprojectionError = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solvePnPGeneric_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr reprojectionError_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solvePnPGeneric_11(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solvePnPGeneric_12(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags, IntPtr rvec_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solvePnPGeneric_13(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solvePnPGeneric_14(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_solvePnPGeneric_15(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);

        // C++:  Mat cv::initCameraMatrix2D(vector_vector_Point3f objectPoints, vector_vector_Point2f imagePoints, Size imageSize, double aspectRatio = 1.0)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_initCameraMatrix2D_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, double aspectRatio);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_initCameraMatrix2D_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height);

        // C++:  bool cv::findChessboardCorners(Mat image, Size patternSize, vector_Point2f& corners, int flags = CALIB_CB_ADAPTIVE_THRESH + CALIB_CB_NORMALIZE_IMAGE)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCorners_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCorners_11(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_mat_nativeObj);

        // C++:  bool cv::checkChessboard(Mat img, Size size)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_checkChessboard_10(IntPtr img_nativeObj, double size_width, double size_height);

        // C++:  bool cv::findChessboardCornersSB(Mat image, Size patternSize, Mat& corners, int flags, Mat& meta)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCornersSBWithMeta_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, int flags, IntPtr meta_nativeObj);

        // C++:  bool cv::findChessboardCornersSB(Mat image, Size patternSize, Mat& corners, int flags = 0)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCornersSB_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findChessboardCornersSB_11(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj);

        // C++:  Scalar cv::estimateChessboardSharpness(Mat image, Size patternSize, Mat corners, float rise_distance = 0.8F, bool vertical = false, Mat& sharpness = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_estimateChessboardSharpness_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, float rise_distance, [MarshalAs(UnmanagedType.U1)] bool vertical, IntPtr sharpness_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_estimateChessboardSharpness_11(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, float rise_distance, [MarshalAs(UnmanagedType.U1)] bool vertical, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_estimateChessboardSharpness_12(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, float rise_distance, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_estimateChessboardSharpness_13(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_nativeObj, double[] retVal);

        // C++:  bool cv::find4QuadCornerSubpix(Mat img, Mat& corners, Size region_size)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_find4QuadCornerSubpix_10(IntPtr img_nativeObj, IntPtr corners_nativeObj, double region_size_width, double region_size_height);

        // C++:  void cv::drawChessboardCorners(Mat& image, Size patternSize, vector_Point2f corners, bool patternWasFound)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_drawChessboardCorners_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr corners_mat_nativeObj, [MarshalAs(UnmanagedType.U1)] bool patternWasFound);

        // C++:  void cv::drawFrameAxes(Mat& image, Mat cameraMatrix, Mat distCoeffs, Mat rvec, Mat tvec, float length, int thickness = 3)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_drawFrameAxes_10(IntPtr image_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, float length, int thickness);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_drawFrameAxes_11(IntPtr image_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, float length);

        // C++:  bool cv::findCirclesGrid(Mat image, Size patternSize, Mat& centers, int flags = CALIB_CB_SYMMETRIC_GRID, Ptr_FeatureDetector blobDetector = SimpleBlobDetector::create())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findCirclesGrid_10(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr centers_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_findCirclesGrid_12(IntPtr image_nativeObj, double patternSize_width, double patternSize_height, IntPtr centers_nativeObj);

        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraExtended_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraExtended_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraExtended_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::calibrateCamera(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCamera_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCamera_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCamera_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);

        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, Mat& stdDeviationsIntrinsics, Mat& stdDeviationsExtrinsics, Mat& stdDeviationsObjPoints, Mat& perViewErrors, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraROExtended_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr stdDeviationsObjPoints_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraROExtended_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr stdDeviationsObjPoints_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraROExtended_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, IntPtr stdDeviationsIntrinsics_nativeObj, IntPtr stdDeviationsExtrinsics_nativeObj, IntPtr stdDeviationsObjPoints_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::calibrateCameraRO(vector_Mat objectPoints, vector_Mat imagePoints, Size imageSize, int iFixedPoint, Mat& cameraMatrix, Mat& distCoeffs, vector_Mat& rvecs, vector_Mat& tvecs, Mat& newObjPoints, int flags = 0, TermCriteria criteria = TermCriteria( TermCriteria::COUNT + TermCriteria::EPS, 30, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraRO_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraRO_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_calibrateCameraRO_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double imageSize_width, double imageSize_height, int iFixedPoint, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr newObjPoints_nativeObj);

        // C++:  void cv::calibrationMatrixValues(Mat cameraMatrix, Size imageSize, double apertureWidth, double apertureHeight, double& fovx, double& fovy, double& focalLength, Point2d& principalPoint, double& aspectRatio)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrationMatrixValues_10(IntPtr cameraMatrix_nativeObj, double imageSize_width, double imageSize_height, double apertureWidth, double apertureHeight, double[] fovx_out, double[] fovy_out, double[] focalLength_out, double[] principalPoint_out, double[] aspectRatio_out);

        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, vector_Mat& rvecs, vector_Mat& tvecs, Mat& perViewErrors, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrateExtended_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrateExtended_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrateExtended_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj);

        // C++:  double cv::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& cameraMatrix1, Mat& distCoeffs1, Mat& cameraMatrix2, Mat& distCoeffs2, Size imageSize, Mat& R, Mat& T, Mat& E, Mat& F, Mat& perViewErrors, int flags = CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 1e-6))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_13(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr perViewErrors_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_14(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr perViewErrors_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_stereoCalibrate_15(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr E_nativeObj, IntPtr F_nativeObj, IntPtr perViewErrors_nativeObj);

        // C++:  void cv::stereoRectify(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Size imageSize, Mat R, Mat T, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags = CALIB_ZERO_DISPARITY, double alpha = -1, Size newImageSize = Size(), Rect* validPixROI1 = 0, Rect* validPixROI2 = 0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_10(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha, double newImageSize_width, double newImageSize_height, double[] validPixROI1_out, double[] validPixROI2_out);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_11(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha, double newImageSize_width, double newImageSize_height, double[] validPixROI1_out);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_12(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha, double newImageSize_width, double newImageSize_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_13(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double alpha);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_14(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_stereoRectify_15(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj);

        // C++:  bool cv::stereoRectifyUncalibrated(Mat points1, Mat points2, Mat F, Size imgSize, Mat& H1, Mat& H2, double threshold = 5)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_stereoRectifyUncalibrated_10(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr F_nativeObj, double imgSize_width, double imgSize_height, IntPtr H1_nativeObj, IntPtr H2_nativeObj, double threshold);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_stereoRectifyUncalibrated_11(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr F_nativeObj, double imgSize_width, double imgSize_height, IntPtr H1_nativeObj, IntPtr H2_nativeObj);

        // C++:  float cv::rectify3Collinear(Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat cameraMatrix3, Mat distCoeffs3, vector_Mat imgpt1, vector_Mat imgpt3, Size imageSize, Mat R12, Mat T12, Mat R13, Mat T13, Mat& R1, Mat& R2, Mat& R3, Mat& P1, Mat& P2, Mat& P3, Mat& Q, double alpha, Size newImgSize, Rect* roi1, Rect* roi2, int flags)
        [DllImport(LIBNAME)]
        private static extern float calib3d_Calib3d_rectify3Collinear_10(IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr cameraMatrix3_nativeObj, IntPtr distCoeffs3_nativeObj, IntPtr imgpt1_mat_nativeObj, IntPtr imgpt3_mat_nativeObj, double imageSize_width, double imageSize_height, IntPtr R12_nativeObj, IntPtr T12_nativeObj, IntPtr R13_nativeObj, IntPtr T13_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr R3_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr P3_nativeObj, IntPtr Q_nativeObj, double alpha, double newImgSize_width, double newImgSize_height, double[] roi1_out, double[] roi2_out, int flags);

        // C++:  Mat cv::getOptimalNewCameraMatrix(Mat cameraMatrix, Mat distCoeffs, Size imageSize, double alpha, Size newImgSize = Size(), Rect* validPixROI = 0, bool centerPrincipalPoint = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_10(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha, double newImgSize_width, double newImgSize_height, double[] validPixROI_out, [MarshalAs(UnmanagedType.U1)] bool centerPrincipalPoint);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_11(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha, double newImgSize_width, double newImgSize_height, double[] validPixROI_out);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_12(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha, double newImgSize_width, double newImgSize_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getOptimalNewCameraMatrix_13(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, double alpha);

        // C++:  void cv::calibrateHandEye(vector_Mat R_gripper2base, vector_Mat t_gripper2base, vector_Mat R_target2cam, vector_Mat t_target2cam, Mat& R_cam2gripper, Mat& t_cam2gripper, HandEyeCalibrationMethod method = CALIB_HAND_EYE_TSAI)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrateHandEye_10(IntPtr R_gripper2base_mat_nativeObj, IntPtr t_gripper2base_mat_nativeObj, IntPtr R_target2cam_mat_nativeObj, IntPtr t_target2cam_mat_nativeObj, IntPtr R_cam2gripper_nativeObj, IntPtr t_cam2gripper_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrateHandEye_11(IntPtr R_gripper2base_mat_nativeObj, IntPtr t_gripper2base_mat_nativeObj, IntPtr R_target2cam_mat_nativeObj, IntPtr t_target2cam_mat_nativeObj, IntPtr R_cam2gripper_nativeObj, IntPtr t_cam2gripper_nativeObj);

        // C++:  void cv::calibrateRobotWorldHandEye(vector_Mat R_world2cam, vector_Mat t_world2cam, vector_Mat R_base2gripper, vector_Mat t_base2gripper, Mat& R_base2world, Mat& t_base2world, Mat& R_gripper2cam, Mat& t_gripper2cam, RobotWorldHandEyeCalibrationMethod method = CALIB_ROBOT_WORLD_HAND_EYE_SHAH)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrateRobotWorldHandEye_10(IntPtr R_world2cam_mat_nativeObj, IntPtr t_world2cam_mat_nativeObj, IntPtr R_base2gripper_mat_nativeObj, IntPtr t_base2gripper_mat_nativeObj, IntPtr R_base2world_nativeObj, IntPtr t_base2world_nativeObj, IntPtr R_gripper2cam_nativeObj, IntPtr t_gripper2cam_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_calibrateRobotWorldHandEye_11(IntPtr R_world2cam_mat_nativeObj, IntPtr t_world2cam_mat_nativeObj, IntPtr R_base2gripper_mat_nativeObj, IntPtr t_base2gripper_mat_nativeObj, IntPtr R_base2world_nativeObj, IntPtr t_base2world_nativeObj, IntPtr R_gripper2cam_nativeObj, IntPtr t_gripper2cam_nativeObj);

        // C++:  void cv::convertPointsToHomogeneous(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_convertPointsToHomogeneous_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::convertPointsFromHomogeneous(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_convertPointsFromHomogeneous_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, int method, double ransacReprojThreshold, double confidence, int maxIters, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_10(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold, double confidence, int maxIters, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_11(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold, double confidence, int maxIters);

        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, int method = FM_RANSAC, double ransacReprojThreshold = 3., double confidence = 0.99, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_12(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold, double confidence, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_13(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_14(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_15(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_16(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj);

        // C++:  Mat cv::findFundamentalMat(vector_Point2f points1, vector_Point2f points2, Mat& mask, UsacParams _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findFundamentalMat_17(IntPtr points1_mat_nativeObj, IntPtr points2_mat_nativeObj, IntPtr mask_nativeObj, IntPtr _params_nativeObj);

        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix, int method = RANSAC, double prob = 0.999, double threshold = 1.0, int maxIters = 1000, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_10(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob, double threshold, int maxIters, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_11(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob, double threshold, int maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_12(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_13(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method, double prob);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_14(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_15(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj);

        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, double focal = 1.0, Point2d pp = Point2d(0, 0), int method = RANSAC, double prob = 0.999, double threshold = 1.0, int maxIters = 1000, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_16(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob, double threshold, int maxIters, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_17(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob, double threshold, int maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_18(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_19(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method, double prob);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_110(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_111(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal, double pp_x, double pp_y);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_112(IntPtr points1_nativeObj, IntPtr points2_nativeObj, double focal);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_113(IntPtr points1_nativeObj, IntPtr points2_nativeObj);

        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, int method = RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_114(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, int method, double prob, double threshold, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_115(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, int method, double prob, double threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_116(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, int method, double prob);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_117(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_118(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj);

        // C++:  Mat cv::findEssentialMat(Mat points1, Mat points2, Mat cameraMatrix1, Mat cameraMatrix2, Mat dist_coeff1, Mat dist_coeff2, Mat& mask, UsacParams _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_findEssentialMat_119(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr dist_coeff1_nativeObj, IntPtr dist_coeff2_nativeObj, IntPtr mask_nativeObj, IntPtr _params_nativeObj);

        // C++:  void cv::decomposeEssentialMat(Mat E, Mat& R1, Mat& R2, Mat& t)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_decomposeEssentialMat_10(IntPtr E_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr t_nativeObj);

        // C++:  int cv::recoverPose(Mat points1, Mat points2, Mat cameraMatrix1, Mat distCoeffs1, Mat cameraMatrix2, Mat distCoeffs2, Mat& E, Mat& R, Mat& t, int method = cv::RANSAC, double prob = 0.999, double threshold = 1.0, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_10(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr E_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, int method, double prob, double threshold, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_11(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr E_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, int method, double prob, double threshold);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_12(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr E_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, int method, double prob);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_13(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr E_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_14(IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix1_nativeObj, IntPtr distCoeffs1_nativeObj, IntPtr cameraMatrix2_nativeObj, IntPtr distCoeffs2_nativeObj, IntPtr E_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj);

        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_15(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_16(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj);

        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat& R, Mat& t, double focal = 1.0, Point2d pp = Point2d(0, 0), Mat& mask = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_17(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double focal, double pp_x, double pp_y, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_18(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double focal, double pp_x, double pp_y);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_19(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double focal);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_110(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj);

        // C++:  int cv::recoverPose(Mat E, Mat points1, Mat points2, Mat cameraMatrix, Mat& R, Mat& t, double distanceThresh, Mat& mask = Mat(), Mat& triangulatedPoints = Mat())
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_111(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double distanceThresh, IntPtr mask_nativeObj, IntPtr triangulatedPoints_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_112(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double distanceThresh, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_recoverPose_113(IntPtr E_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr R_nativeObj, IntPtr t_nativeObj, double distanceThresh);

        // C++:  void cv::computeCorrespondEpilines(Mat points, int whichImage, Mat F, Mat& lines)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_computeCorrespondEpilines_10(IntPtr points_nativeObj, int whichImage, IntPtr F_nativeObj, IntPtr lines_nativeObj);

        // C++:  void cv::triangulatePoints(Mat projMatr1, Mat projMatr2, Mat projPoints1, Mat projPoints2, Mat& points4D)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_triangulatePoints_10(IntPtr projMatr1_nativeObj, IntPtr projMatr2_nativeObj, IntPtr projPoints1_nativeObj, IntPtr projPoints2_nativeObj, IntPtr points4D_nativeObj);

        // C++:  void cv::correctMatches(Mat F, Mat points1, Mat points2, Mat& newPoints1, Mat& newPoints2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_correctMatches_10(IntPtr F_nativeObj, IntPtr points1_nativeObj, IntPtr points2_nativeObj, IntPtr newPoints1_nativeObj, IntPtr newPoints2_nativeObj);

        // C++:  void cv::filterSpeckles(Mat& img, double newVal, int maxSpeckleSize, double maxDiff, Mat& buf = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterSpeckles_10(IntPtr img_nativeObj, double newVal, int maxSpeckleSize, double maxDiff, IntPtr buf_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterSpeckles_11(IntPtr img_nativeObj, double newVal, int maxSpeckleSize, double maxDiff);

        // C++:  Rect cv::getValidDisparityROI(Rect roi1, Rect roi2, int minDisparity, int numberOfDisparities, int blockSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_getValidDisparityROI_10(int roi1_x, int roi1_y, int roi1_width, int roi1_height, int roi2_x, int roi2_y, int roi2_width, int roi2_height, int minDisparity, int numberOfDisparities, int blockSize, double[] retVal);

        // C++:  void cv::validateDisparity(Mat& disparity, Mat cost, int minDisparity, int numberOfDisparities, int disp12MaxDisp = 1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_validateDisparity_10(IntPtr disparity_nativeObj, IntPtr cost_nativeObj, int minDisparity, int numberOfDisparities, int disp12MaxDisp);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_validateDisparity_11(IntPtr disparity_nativeObj, IntPtr cost_nativeObj, int minDisparity, int numberOfDisparities);

        // C++:  void cv::reprojectImageTo3D(Mat disparity, Mat& _3dImage, Mat Q, bool handleMissingValues = false, int ddepth = -1)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_reprojectImageTo3D_10(IntPtr disparity_nativeObj, IntPtr _3dImage_nativeObj, IntPtr Q_nativeObj, [MarshalAs(UnmanagedType.U1)] bool handleMissingValues, int ddepth);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_reprojectImageTo3D_11(IntPtr disparity_nativeObj, IntPtr _3dImage_nativeObj, IntPtr Q_nativeObj, [MarshalAs(UnmanagedType.U1)] bool handleMissingValues);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_reprojectImageTo3D_12(IntPtr disparity_nativeObj, IntPtr _3dImage_nativeObj, IntPtr Q_nativeObj);

        // C++:  double cv::sampsonDistance(Mat pt1, Mat pt2, Mat F)
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_sampsonDistance_10(IntPtr pt1_nativeObj, IntPtr pt2_nativeObj, IntPtr F_nativeObj);

        // C++:  int cv::estimateAffine3D(Mat src, Mat dst, Mat& _out, Mat& inliers, double ransacThreshold = 3, double confidence = 0.99)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateAffine3D_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj, double ransacThreshold, double confidence);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateAffine3D_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj, double ransacThreshold);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateAffine3D_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj);

        // C++:  Mat cv::estimateAffine3D(Mat src, Mat dst, double* scale = nullptr, bool force_rotation = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine3D_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, double[] scale_out, [MarshalAs(UnmanagedType.U1)] bool force_rotation);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine3D_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, double[] scale_out);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine3D_15(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  int cv::estimateTranslation3D(Mat src, Mat dst, Mat& _out, Mat& inliers, double ransacThreshold = 3, double confidence = 0.99)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateTranslation3D_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj, double ransacThreshold, double confidence);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateTranslation3D_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj, double ransacThreshold);
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_estimateTranslation3D_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr _out_nativeObj, IntPtr inliers_nativeObj);

        // C++:  Mat cv::estimateAffine2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_10(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_11(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_12(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_13(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_14(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_15(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_16(IntPtr from_nativeObj, IntPtr to_nativeObj);

        // C++:  Mat cv::estimateAffine2D(Mat pts1, Mat pts2, Mat& inliers, UsacParams _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffine2D_17(IntPtr pts1_nativeObj, IntPtr pts2_nativeObj, IntPtr inliers_nativeObj, IntPtr _params_nativeObj);

        // C++:  Mat cv::estimateAffinePartial2D(Mat from, Mat to, Mat& inliers = Mat(), int method = RANSAC, double ransacReprojThreshold = 3, size_t maxIters = 2000, double confidence = 0.99, size_t refineIters = 10)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_10(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence, long refineIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_11(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters, double confidence);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_12(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold, long maxIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_13(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method, double ransacReprojThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_14(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj, int method);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_15(IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr inliers_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_estimateAffinePartial2D_16(IntPtr from_nativeObj, IntPtr to_nativeObj);

        // C++:  int cv::decomposeHomographyMat(Mat H, Mat K, vector_Mat& rotations, vector_Mat& translations, vector_Mat& normals)
        [DllImport(LIBNAME)]
        private static extern int calib3d_Calib3d_decomposeHomographyMat_10(IntPtr H_nativeObj, IntPtr K_nativeObj, IntPtr rotations_mat_nativeObj, IntPtr translations_mat_nativeObj, IntPtr normals_mat_nativeObj);

        // C++:  void cv::filterHomographyDecompByVisibleRefpoints(vector_Mat rotations, vector_Mat normals, Mat beforePoints, Mat afterPoints, Mat& possibleSolutions, Mat pointsMask = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_10(IntPtr rotations_mat_nativeObj, IntPtr normals_mat_nativeObj, IntPtr beforePoints_nativeObj, IntPtr afterPoints_nativeObj, IntPtr possibleSolutions_nativeObj, IntPtr pointsMask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_filterHomographyDecompByVisibleRefpoints_11(IntPtr rotations_mat_nativeObj, IntPtr normals_mat_nativeObj, IntPtr beforePoints_nativeObj, IntPtr afterPoints_nativeObj, IntPtr possibleSolutions_nativeObj);

        // C++:  void cv::undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistort_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr newCameraMatrix_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistort_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  void cv::initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_initUndistortRectifyMap_10(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr newCameraMatrix_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);

        // C++:  void cv::initInverseRectificationMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_initInverseRectificationMap_10(IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr newCameraMatrix_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);

        // C++:  Mat cv::getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getDefaultNewCameraMatrix_10(IntPtr cameraMatrix_nativeObj, double imgsize_width, double imgsize_height, [MarshalAs(UnmanagedType.U1)] bool centerPrincipalPoint);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getDefaultNewCameraMatrix_11(IntPtr cameraMatrix_nativeObj, double imgsize_width, double imgsize_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_Calib3d_getDefaultNewCameraMatrix_12(IntPtr cameraMatrix_nativeObj);

        // C++:  void cv::undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPoints_10(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPoints_11(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPoints_12(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  void cv::undistortPoints(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P, TermCriteria criteria)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortPointsIter_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon);

        // C++:  void cv::undistortImagePoints(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, TermCriteria arg1 = TermCriteria(TermCriteria::MAX_ITER + TermCriteria::EPS, 5, 0.01))
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortImagePoints_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, int arg1_type, int arg1_maxCount, double arg1_epsilon);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_undistortImagePoints_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);

        // C++:  void cv::fisheye::projectPoints(Mat objectPoints, Mat& imagePoints, Mat rvec, Mat tvec, Mat K, Mat D, double alpha = 0, Mat& jacobian = Mat())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1projectPoints_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, double alpha, IntPtr jacobian_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1projectPoints_11(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, double alpha);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1projectPoints_12(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::distortPoints(Mat undistorted, Mat& distorted, Mat K, Mat D, double alpha = 0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1distortPoints_10(IntPtr undistorted_nativeObj, IntPtr distorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, double alpha);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1distortPoints_11(IntPtr undistorted_nativeObj, IntPtr distorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::undistortPoints(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat R = Mat(), Mat P = Mat(), TermCriteria criteria = TermCriteria(TermCriteria::MAX_ITER + TermCriteria::EPS, 10, 1e-8))
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_10(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_11(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_12(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortPoints_13(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::initUndistortRectifyMap(Mat K, Mat D, Mat R, Mat P, Size size, int m1type, Mat& map1, Mat& map2)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1initUndistortRectifyMap_10(IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);

        // C++:  void cv::fisheye::undistortImage(Mat distorted, Mat& undistorted, Mat K, Mat D, Mat Knew = cv::Mat(), Size new_size = Size())
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortImage_10(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr Knew_nativeObj, double new_size_width, double new_size_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortImage_11(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr Knew_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1undistortImage_12(IntPtr distorted_nativeObj, IntPtr undistorted_nativeObj, IntPtr K_nativeObj, IntPtr D_nativeObj);

        // C++:  void cv::fisheye::estimateNewCameraMatrixForUndistortRectify(Mat K, Mat D, Size image_size, Mat R, Mat& P, double balance = 0.0, Size new_size = Size(), double fov_scale = 1.0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_10(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj, double balance, double new_size_width, double new_size_height, double fov_scale);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_11(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj, double balance, double new_size_width, double new_size_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_12(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj, double balance);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1estimateNewCameraMatrixForUndistortRectify_13(IntPtr K_nativeObj, IntPtr D_nativeObj, double image_size_width, double image_size_height, IntPtr R_nativeObj, IntPtr P_nativeObj);

        // C++:  double cv::fisheye::calibrate(vector_Mat objectPoints, vector_Mat imagePoints, Size image_size, Mat& K, Mat& D, vector_Mat& rvecs, vector_Mat& tvecs, int flags = 0, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1calibrate_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double image_size_width, double image_size_height, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1calibrate_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double image_size_width, double image_size_height, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1calibrate_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints_mat_nativeObj, double image_size_width, double image_size_height, IntPtr K_nativeObj, IntPtr D_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);

        // C++:  void cv::fisheye::stereoRectify(Mat K1, Mat D1, Mat K2, Mat D2, Size imageSize, Mat R, Mat tvec, Mat& R1, Mat& R2, Mat& P1, Mat& P2, Mat& Q, int flags, Size newImageSize = Size(), double balance = 0.0, double fov_scale = 1.0)
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_10(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double newImageSize_width, double newImageSize_height, double balance, double fov_scale);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_11(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double newImageSize_width, double newImageSize_height, double balance);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_12(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags, double newImageSize_width, double newImageSize_height);
        [DllImport(LIBNAME)]
        private static extern void calib3d_Calib3d_fisheye_1stereoRectify_13(IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr tvec_nativeObj, IntPtr R1_nativeObj, IntPtr R2_nativeObj, IntPtr P1_nativeObj, IntPtr P2_nativeObj, IntPtr Q_nativeObj, int flags);

        // C++:  double cv::fisheye::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& K1, Mat& D1, Mat& K2, Mat& D2, Size imageSize, Mat& R, Mat& T, vector_Mat& rvecs, vector_Mat& tvecs, int flags = fisheye::CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_10(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_11(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_12(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, IntPtr rvecs_mat_nativeObj, IntPtr tvecs_mat_nativeObj);

        // C++:  double cv::fisheye::stereoCalibrate(vector_Mat objectPoints, vector_Mat imagePoints1, vector_Mat imagePoints2, Mat& K1, Mat& D1, Mat& K2, Mat& D2, Size imageSize, Mat& R, Mat& T, int flags = fisheye::CALIB_FIX_INTRINSIC, TermCriteria criteria = TermCriteria(TermCriteria::COUNT + TermCriteria::EPS, 100, DBL_EPSILON))
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_13(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_14(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double calib3d_Calib3d_fisheye_1stereoCalibrate_15(IntPtr objectPoints_mat_nativeObj, IntPtr imagePoints1_mat_nativeObj, IntPtr imagePoints2_mat_nativeObj, IntPtr K1_nativeObj, IntPtr D1_nativeObj, IntPtr K2_nativeObj, IntPtr D2_nativeObj, double imageSize_width, double imageSize_height, IntPtr R_nativeObj, IntPtr T_nativeObj);

        // C++:  bool cv::fisheye::solvePnP(Mat objectPoints, Mat imagePoints, Mat cameraMatrix, Mat distCoeffs, Mat& rvec, Mat& tvec, bool useExtrinsicGuess = false, int flags = SOLVEPNP_ITERATIVE, TermCriteria criteria = TermCriteria(TermCriteria::MAX_ITER + TermCriteria::EPS, 10, 1e-8))
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_fisheye_1solvePnP_10(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags, int criteria_type, int criteria_maxCount, double criteria_epsilon);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_fisheye_1solvePnP_11(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_fisheye_1solvePnP_12(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_Calib3d_fisheye_1solvePnP_13(IntPtr objectPoints_nativeObj, IntPtr imagePoints_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr rvec_nativeObj, IntPtr tvec_nativeObj);

    }
}
