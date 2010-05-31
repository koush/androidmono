namespace android.opengl
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Matrix : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Matrix()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.opengl.Matrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.opengl.Matrix(@__env);
			}
		}
		protected Matrix(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _length5310;
		public static float length(float arg0, float arg1, float arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._length5310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _multiplyMM5311;
		public static void multiplyMM(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._multiplyMM5311, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _multiplyMV5312;
		public static void multiplyMV(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._multiplyMV5312, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _transposeM5313;
		public static void transposeM(float[] arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._transposeM5313, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invertM5314;
		public static bool invertM(float[] arg0, int arg1, float[] arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._invertM5314, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _orthoM5315;
		public static void orthoM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._orthoM5315, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _frustumM5316;
		public static void frustumM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._frustumM5316, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIdentityM5317;
		public static void setIdentityM(float[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setIdentityM5317, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scaleM5318;
		public static void scaleM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._scaleM5318, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scaleM5319;
		public static void scaleM(float[] arg0, int arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._scaleM5319, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translateM5320;
		public static void translateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._translateM5320, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _translateM5321;
		public static void translateM(float[] arg0, int arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._translateM5321, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotateM5322;
		public static void rotateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6, float arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._rotateM5322, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rotateM5323;
		public static void rotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._rotateM5323, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRotateM5324;
		public static void setRotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setRotateM5324, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRotateEulerM5325;
		public static void setRotateEulerM(float[] arg0, int arg1, float arg2, float arg3, float arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setRotateEulerM5325, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Matrix5326;
		public Matrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._Matrix5326, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.opengl.Matrix.staticClass = @__class;
			global::android.opengl.Matrix._length5310 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "length", "(FFF)F");
			global::android.opengl.Matrix._multiplyMM5311 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "multiplyMM", "([FI[FI[FI)V");
			global::android.opengl.Matrix._multiplyMV5312 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "multiplyMV", "([FI[FI[FI)V");
			global::android.opengl.Matrix._transposeM5313 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "transposeM", "([FI[FI)V");
			global::android.opengl.Matrix._invertM5314 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "invertM", "([FI[FI)Z");
			global::android.opengl.Matrix._orthoM5315 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "orthoM", "([FIFFFFFF)V");
			global::android.opengl.Matrix._frustumM5316 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "frustumM", "([FIFFFFFF)V");
			global::android.opengl.Matrix._setIdentityM5317 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "setIdentityM", "([FI)V");
			global::android.opengl.Matrix._scaleM5318 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "scaleM", "([FI[FIFFF)V");
			global::android.opengl.Matrix._scaleM5319 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "scaleM", "([FIFFF)V");
			global::android.opengl.Matrix._translateM5320 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "translateM", "([FI[FIFFF)V");
			global::android.opengl.Matrix._translateM5321 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "translateM", "([FIFFF)V");
			global::android.opengl.Matrix._rotateM5322 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "rotateM", "([FI[FIFFFF)V");
			global::android.opengl.Matrix._rotateM5323 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "rotateM", "([FIFFFF)V");
			global::android.opengl.Matrix._setRotateM5324 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "setRotateM", "([FIFFFF)V");
			global::android.opengl.Matrix._setRotateEulerM5325 = @__env.GetStaticMethodID(global::android.opengl.Matrix.staticClass, "setRotateEulerM", "([FIFFF)V");
			global::android.opengl.Matrix._Matrix5326 = @__env.GetMethodID(global::android.opengl.Matrix.staticClass, "<init>", "()V");
		}
	}
}
