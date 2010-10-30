namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Matrix : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Matrix(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static float length(float arg0, float arg1, float arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "length", "(FFF)F");
			return @__env.CallStaticFloatMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void multiplyMM(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "multiplyMM", "([FI[FI[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void multiplyMV(float[] arg0, int arg1, float[] arg2, int arg3, float[] arg4, int arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "multiplyMV", "([FI[FI[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void transposeM(float[] arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "transposeM", "([FI[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool invertM(float[] arg0, int arg1, float[] arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "invertM", "([FI[FI)Z");
			return @__env.CallStaticBooleanMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static void orthoM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "orthoM", "([FIFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void frustumM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m6 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "frustumM", "([FIFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static void setIdentityM(float[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m7.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m7 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setIdentityM", "([FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void scaleM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m8.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m8 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "scaleM", "([FI[FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void scaleM(float[] arg0, int arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m9.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m9 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "scaleM", "([FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static void translateM(float[] arg0, int arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m10.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m10 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "translateM", "([FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void translateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m11.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m11 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "translateM", "([FI[FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void rotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m12.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m12 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "rotateM", "([FIFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void rotateM(float[] arg0, int arg1, float[] arg2, int arg3, float arg4, float arg5, float arg6, float arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m13.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m13 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "rotateM", "([FI[FIFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void setRotateM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m14.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m14 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setRotateM", "([FIFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void setRotateEulerM(float[] arg0, int arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m15.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m15 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setRotateEulerM", "([FIFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static void setLookAtM(float[] arg0, int arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9, float arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m16.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m16 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "setLookAtM", "([FIFFFFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public Matrix() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Matrix._m17.native == global::System.IntPtr.Zero)
				global::android.opengl.Matrix._m17 = @__env.GetMethodIDNoThrow(global::android.opengl.Matrix.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.Matrix.staticClass, global::android.opengl.Matrix._m17);
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
