namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RadialGradient : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RadialGradient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public RadialGradient(float arg0, float arg1, float arg2, int[] arg3, float[] arg4, android.graphics.Shader.TileMode arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RadialGradient._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.RadialGradient._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.RadialGradient.staticClass, "<init>", "(FFF[I[FLandroid/graphics/Shader$TileMode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RadialGradient.staticClass, global::android.graphics.RadialGradient._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RadialGradient(float arg0, float arg1, float arg2, int arg3, int arg4, android.graphics.Shader.TileMode arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.RadialGradient._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.RadialGradient._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.RadialGradient.staticClass, "<init>", "(FFFIILandroid/graphics/Shader$TileMode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.RadialGradient.staticClass, global::android.graphics.RadialGradient._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static RadialGradient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.RadialGradient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/RadialGradient"));
		}
	}
}
