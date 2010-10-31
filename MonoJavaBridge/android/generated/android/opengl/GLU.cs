namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLU : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLU(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String gluErrorString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluErrorString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void gluLookAt(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, float arg9)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluLookAt", "(Ljavax/microedition/khronos/opengles/GL10;FFFFFFFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void gluOrtho2D(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluOrtho2D", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void gluPerspective(javax.microedition.khronos.opengles.GL10 arg0, float arg1, float arg2, float arg3, float arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m3 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluPerspective", "(Ljavax/microedition/khronos/opengles/GL10;FFFF)V");
			@__env.CallStaticVoidMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int gluProject(float arg0, float arg1, float arg2, float[] arg3, int arg4, float[] arg5, int arg6, int[] arg7, int arg8, float[] arg9, int arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m4.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m4 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluProject", "(FFF[FI[FI[II[FI)I");
			return @__env.CallStaticIntMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int gluUnProject(float arg0, float arg1, float arg2, float[] arg3, int arg4, float[] arg5, int arg6, int[] arg7, int arg8, float[] arg9, int arg10)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m5.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m5 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLU.staticClass, "gluUnProject", "(FFF[FI[FI[II[FI)I");
			return @__env.CallStaticIntMethod(android.opengl.GLU.staticClass, global::android.opengl.GLU._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public GLU() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLU._m6.native == global::System.IntPtr.Zero)
				global::android.opengl.GLU._m6 = @__env.GetMethodIDNoThrow(global::android.opengl.GLU.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLU.staticClass, global::android.opengl.GLU._m6);
			Init(@__env, handle);
		}
		static GLU()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLU.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLU"));
		}
	}
}
