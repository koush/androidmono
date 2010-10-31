namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Visibility : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Visibility(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static int visibilityTest(float[] arg0, int arg1, float[] arg2, int arg3, char[] arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Visibility._m0.native == global::System.IntPtr.Zero)
				global::android.opengl.Visibility._m0 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "visibilityTest", "([FI[FI[CII)I");
			return @__env.CallStaticIntMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int frustumCullSpheres(float[] arg0, int arg1, float[] arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Visibility._m1.native == global::System.IntPtr.Zero)
				global::android.opengl.Visibility._m1 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "frustumCullSpheres", "([FI[FII[III)I");
			return @__env.CallStaticIntMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void computeBoundingSphere(float[] arg0, int arg1, int arg2, float[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Visibility._m2.native == global::System.IntPtr.Zero)
				global::android.opengl.Visibility._m2 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "computeBoundingSphere", "([FII[FI)V");
			@__env.CallStaticVoidMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Visibility() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.Visibility._m3.native == global::System.IntPtr.Zero)
				global::android.opengl.Visibility._m3 = @__env.GetMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._m3);
			Init(@__env, handle);
		}
		static Visibility()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.Visibility.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/Visibility"));
		}
	}
}
