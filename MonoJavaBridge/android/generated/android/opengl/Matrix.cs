namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Matrix : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Matrix(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length9472;
		public static float length(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._length9472.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._length9472 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "length", "(FFF)F");
			return @__env.CallStaticFloatMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._length9472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _multiplyMM9473;
		public static void multiplyMM(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._multiplyMM9473.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._multiplyMM9473 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "multiplyMM", "([FI[FI[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._multiplyMM9473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _multiplyMV9474;
		public static void multiplyMV(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._multiplyMV9474.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._multiplyMV9474 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "multiplyMV", "([FI[FI[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._multiplyMV9474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _transposeM9475;
		public static void transposeM(float[] arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._transposeM9475.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._transposeM9475 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "transposeM", "([FI[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._transposeM9475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _invertM9476;
		public static bool invertM(float[] arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._invertM9476.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._invertM9476 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "invertM", "([FI[FI)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._invertM9476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _orthoM9477;
		public static void orthoM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._orthoM9477.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._orthoM9477 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "orthoM", "([FIFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._orthoM9477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _frustumM9478;
		public static void frustumM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._frustumM9478.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._frustumM9478 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "frustumM", "([FIFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._frustumM9478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _setIdentityM9479;
		public static void setIdentityM(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._setIdentityM9479.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._setIdentityM9479 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setIdentityM", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setIdentityM9479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _scaleM9480;
		public static void scaleM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._scaleM9480.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._scaleM9480 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "scaleM", "([FI[FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._scaleM9480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _scaleM9481;
		public static void scaleM(float[] arg0, int arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._scaleM9481.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._scaleM9481 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "scaleM", "([FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._scaleM9481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _translateM9482;
		public static void translateM(float[] arg0, int arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._translateM9482.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._translateM9482 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "translateM", "([FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._translateM9482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _translateM9483;
		public static void translateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._translateM9483.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._translateM9483 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "translateM", "([FI[FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._translateM9483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _rotateM9484;
		public static void rotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._rotateM9484.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._rotateM9484 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "rotateM", "([FIFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._rotateM9484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _rotateM9485;
		public static void rotateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6, float arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._rotateM9485.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._rotateM9485 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "rotateM", "([FI[FIFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._rotateM9485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _setRotateM9486;
		public static void setRotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._setRotateM9486.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._setRotateM9486 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setRotateM", "([FIFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setRotateM9486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setRotateEulerM9487;
		public static void setRotateEulerM(float[] arg0, int arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._setRotateEulerM9487.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._setRotateEulerM9487 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setRotateEulerM", "([FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setRotateEulerM9487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setLookAtM9488;
		public static void setLookAtM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9, float arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._setLookAtM9488.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._setLookAtM9488 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setLookAtM", "([FIFFFFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._setLookAtM9488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		internal static global::MonoJavaBridge.MethodId _Matrix9489;
		public Matrix() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._Matrix9489.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._Matrix9489 = @__env.GetMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._Matrix9489);
			Init(@__env, handle);
		}
		static Matrix()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.Matrix.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/Matrix"));
		}
		internal static void InitJNI()
		{
		}
	}
}
