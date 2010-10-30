namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SweepGradient : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SweepGradient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SweepGradient(float arg0, float arg1, int[] arg2, float[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.SweepGradient._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.SweepGradient._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.SweepGradient.staticClass, "<init>", "(FF[I[F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.SweepGradient.staticClass, global::android.graphics.SweepGradient._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SweepGradient(float arg0, float arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.SweepGradient._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.SweepGradient._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.SweepGradient.staticClass, "<init>", "(FFII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.SweepGradient.staticClass, global::android.graphics.SweepGradient._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SweepGradient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.SweepGradient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/SweepGradient"));
		}
		internal static void InitJNI()
		{
		}
	}
}
