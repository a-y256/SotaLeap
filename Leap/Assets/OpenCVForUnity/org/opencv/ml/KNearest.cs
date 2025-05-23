
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class KNearest
    /// <summary>
    ///  The class implements K-Nearest Neighbors model
    /// </summary>
    /// <remarks>
    ///  @sa @ref ml_intro_knn
    /// </remarks>
    public class KNearest : StatModel
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        ml_KNearest_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal KNearest(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new KNearest __fromPtr__(IntPtr addr) { return new KNearest(addr); }

        // C++: enum cv.ml.KNearest.Types
        public const int BRUTE_FORCE = 1;
        public const int KDTREE = 2;
        //
        // C++:  int cv::ml::KNearest::getDefaultK()
        //

        /// <remarks>
        ///  @see setDefaultK
        /// </remarks>
        public int getDefaultK()
        {
            ThrowIfDisposed();

            return ml_KNearest_getDefaultK_10(nativeObj);


        }


        //
        // C++:  void cv::ml::KNearest::setDefaultK(int val)
        //

        /// <remarks>
        ///  @copybrief getDefaultK @see getDefaultK
        /// </remarks>
        public void setDefaultK(int val)
        {
            ThrowIfDisposed();

            ml_KNearest_setDefaultK_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::KNearest::getIsClassifier()
        //

        /// <remarks>
        ///  @see setIsClassifier
        /// </remarks>
        public bool getIsClassifier()
        {
            ThrowIfDisposed();

            return ml_KNearest_getIsClassifier_10(nativeObj);


        }


        //
        // C++:  void cv::ml::KNearest::setIsClassifier(bool val)
        //

        /// <remarks>
        ///  @copybrief getIsClassifier @see getIsClassifier
        /// </remarks>
        public void setIsClassifier(bool val)
        {
            ThrowIfDisposed();

            ml_KNearest_setIsClassifier_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::KNearest::getEmax()
        //

        /// <remarks>
        ///  @see setEmax
        /// </remarks>
        public int getEmax()
        {
            ThrowIfDisposed();

            return ml_KNearest_getEmax_10(nativeObj);


        }


        //
        // C++:  void cv::ml::KNearest::setEmax(int val)
        //

        /// <remarks>
        ///  @copybrief getEmax @see getEmax
        /// </remarks>
        public void setEmax(int val)
        {
            ThrowIfDisposed();

            ml_KNearest_setEmax_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::KNearest::getAlgorithmType()
        //

        /// <remarks>
        ///  @see setAlgorithmType
        /// </remarks>
        public int getAlgorithmType()
        {
            ThrowIfDisposed();

            return ml_KNearest_getAlgorithmType_10(nativeObj);


        }


        //
        // C++:  void cv::ml::KNearest::setAlgorithmType(int val)
        //

        /// <remarks>
        ///  @copybrief getAlgorithmType @see getAlgorithmType
        /// </remarks>
        public void setAlgorithmType(int val)
        {
            ThrowIfDisposed();

            ml_KNearest_setAlgorithmType_10(nativeObj, val);


        }


        //
        // C++:  float cv::ml::KNearest::findNearest(Mat samples, int k, Mat& results, Mat& neighborResponses = Mat(), Mat& dist = Mat())
        //

        /// <summary>
        ///  Finds the neighbors and predicts responses for input vectors.
        /// </summary>
        /// <param name="samples">
        /// Input samples stored by rows. It is a single-precision floating-point matrix of
        ///          `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <param name="k">
        /// Number of used nearest neighbors. Should be greater than 1.
        /// </param>
        /// <param name="results">
        /// Vector with results of prediction (regression or classification) for each input
        ///          sample. It is a single-precision floating-point vector with `&lt;number_of_samples&gt;` elements.
        /// </param>
        /// <param name="neighborResponses">
        /// Optional output values for corresponding neighbors. It is a single-
        ///          precision floating-point matrix of `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <param name="dist">
        /// Optional output distances from the input vectors to the corresponding neighbors. It
        ///          is a single-precision floating-point matrix of `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <remarks>
        ///      For each input vector (a row of the matrix samples), the method finds the k nearest neighbors.
        ///      In case of regression, the predicted result is a mean value of the particular vector's neighbor
        ///      responses. In case of classification, the class is determined by voting.
        ///  
        ///      For each input vector, the neighbors are sorted by their distances to the vector.
        ///  
        ///      In case of C++ interface you can use output pointers to empty matrices and the function will
        ///      allocate memory itself.
        ///  
        ///      If only a single input vector is passed, all output matrices are optional and the predicted
        ///      value is returned by the method.
        ///  
        ///      The function is parallelized with the TBB library.
        /// </remarks>
        public float findNearest(Mat samples, int k, Mat results, Mat neighborResponses, Mat dist)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
            if (neighborResponses != null) neighborResponses.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();

            return ml_KNearest_findNearest_10(nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj, dist.nativeObj);


        }

        /// <summary>
        ///  Finds the neighbors and predicts responses for input vectors.
        /// </summary>
        /// <param name="samples">
        /// Input samples stored by rows. It is a single-precision floating-point matrix of
        ///          `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <param name="k">
        /// Number of used nearest neighbors. Should be greater than 1.
        /// </param>
        /// <param name="results">
        /// Vector with results of prediction (regression or classification) for each input
        ///          sample. It is a single-precision floating-point vector with `&lt;number_of_samples&gt;` elements.
        /// </param>
        /// <param name="neighborResponses">
        /// Optional output values for corresponding neighbors. It is a single-
        ///          precision floating-point matrix of `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <param name="dist">
        /// Optional output distances from the input vectors to the corresponding neighbors. It
        ///          is a single-precision floating-point matrix of `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <remarks>
        ///      For each input vector (a row of the matrix samples), the method finds the k nearest neighbors.
        ///      In case of regression, the predicted result is a mean value of the particular vector's neighbor
        ///      responses. In case of classification, the class is determined by voting.
        ///  
        ///      For each input vector, the neighbors are sorted by their distances to the vector.
        ///  
        ///      In case of C++ interface you can use output pointers to empty matrices and the function will
        ///      allocate memory itself.
        ///  
        ///      If only a single input vector is passed, all output matrices are optional and the predicted
        ///      value is returned by the method.
        ///  
        ///      The function is parallelized with the TBB library.
        /// </remarks>
        public float findNearest(Mat samples, int k, Mat results, Mat neighborResponses)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();
            if (neighborResponses != null) neighborResponses.ThrowIfDisposed();

            return ml_KNearest_findNearest_11(nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj);


        }

        /// <summary>
        ///  Finds the neighbors and predicts responses for input vectors.
        /// </summary>
        /// <param name="samples">
        /// Input samples stored by rows. It is a single-precision floating-point matrix of
        ///          `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <param name="k">
        /// Number of used nearest neighbors. Should be greater than 1.
        /// </param>
        /// <param name="results">
        /// Vector with results of prediction (regression or classification) for each input
        ///          sample. It is a single-precision floating-point vector with `&lt;number_of_samples&gt;` elements.
        /// </param>
        /// <param name="neighborResponses">
        /// Optional output values for corresponding neighbors. It is a single-
        ///          precision floating-point matrix of `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <param name="dist">
        /// Optional output distances from the input vectors to the corresponding neighbors. It
        ///          is a single-precision floating-point matrix of `&lt;number_of_samples&gt; * k` size.
        /// </param>
        /// <remarks>
        ///      For each input vector (a row of the matrix samples), the method finds the k nearest neighbors.
        ///      In case of regression, the predicted result is a mean value of the particular vector's neighbor
        ///      responses. In case of classification, the class is determined by voting.
        ///  
        ///      For each input vector, the neighbors are sorted by their distances to the vector.
        ///  
        ///      In case of C++ interface you can use output pointers to empty matrices and the function will
        ///      allocate memory itself.
        ///  
        ///      If only a single input vector is passed, all output matrices are optional and the predicted
        ///      value is returned by the method.
        ///  
        ///      The function is parallelized with the TBB library.
        /// </remarks>
        public float findNearest(Mat samples, int k, Mat results)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();

            return ml_KNearest_findNearest_12(nativeObj, samples.nativeObj, k, results.nativeObj);


        }


        //
        // C++: static Ptr_KNearest cv::ml::KNearest::create()
        //

        /// <summary>
        ///  Creates the empty model
        /// </summary>
        /// <remarks>
        ///      The static method creates empty %KNearest classifier. It should be then trained using StatModel::train method.
        /// </remarks>
        public static KNearest create()
        {


            return KNearest.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_KNearest_create_10()));


        }


        //
        // C++: static Ptr_KNearest cv::ml::KNearest::load(String filepath)
        //

        /// <summary>
        ///  Loads and creates a serialized knearest from a file
        /// </summary>
        /// <remarks>
        ///         Use KNearest::save to serialize and store an KNearest to disk.
        ///         Load the KNearest from this file again, by calling this function with the path to the file.
        /// </remarks>
        /// <param name="filepath">
        /// path to serialized KNearest
        /// </param>
        public static KNearest load(string filepath)
        {


            return KNearest.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_KNearest_load_10(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ml::KNearest::getDefaultK()
        [DllImport(LIBNAME)]
        private static extern int ml_KNearest_getDefaultK_10(IntPtr nativeObj);

        // C++:  void cv::ml::KNearest::setDefaultK(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setDefaultK_10(IntPtr nativeObj, int val);

        // C++:  bool cv::ml::KNearest::getIsClassifier()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_KNearest_getIsClassifier_10(IntPtr nativeObj);

        // C++:  void cv::ml::KNearest::setIsClassifier(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setIsClassifier_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  int cv::ml::KNearest::getEmax()
        [DllImport(LIBNAME)]
        private static extern int ml_KNearest_getEmax_10(IntPtr nativeObj);

        // C++:  void cv::ml::KNearest::setEmax(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setEmax_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::KNearest::getAlgorithmType()
        [DllImport(LIBNAME)]
        private static extern int ml_KNearest_getAlgorithmType_10(IntPtr nativeObj);

        // C++:  void cv::ml::KNearest::setAlgorithmType(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_setAlgorithmType_10(IntPtr nativeObj, int val);

        // C++:  float cv::ml::KNearest::findNearest(Mat samples, int k, Mat& results, Mat& neighborResponses = Mat(), Mat& dist = Mat())
        [DllImport(LIBNAME)]
        private static extern float ml_KNearest_findNearest_10(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj, IntPtr dist_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_KNearest_findNearest_11(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_KNearest_findNearest_12(IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj);

        // C++: static Ptr_KNearest cv::ml::KNearest::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_KNearest_create_10();

        // C++: static Ptr_KNearest cv::ml::KNearest::load(String filepath)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_KNearest_load_10(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_KNearest_delete(IntPtr nativeObj);

    }
}
