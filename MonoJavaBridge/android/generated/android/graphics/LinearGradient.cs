namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinearGradient : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinearGradient(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LinearGradient5296;
		public LinearGradient(float arg0, float arg1, float arg2, float arg3, int[] arg4, float[] arg5, android.graphics.Shader.TileMode arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.LinearGradient._LinearGradient5296.native == global::System.IntPtr.Zero)
				global::android.graphics.LinearGradient._LinearGradient5296 = @__env.GetMethodIDNoThrow(global::android.graphics.LinearGradient.staticClass, "<init>", "(FFFF[I[FLandroid/graphics/Shader$TileMode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.LinearGradient.staticClass, global::android.graphics.LinearGradient._LinearGradient5296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinearGradient5297;
		public LinearGradient(float arg0, float arg1, float arg2, float arg3, int arg4, int arg5, android.graphics.Shader.TileMode arg6) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.LinearGradient._LinearGradient5297.native == global::System.IntPtr.Zero)
				global::android.graphics.LinearGradient._LinearGradient5297 = @__env.GetMethodIDNoThrow(global::android.graphics.LinearGradient.staticClass, "<init>", "(FFFFIILandroid/graphics/Shader$TileMode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.LinearGradient.staticClass, global::android.graphics.LinearGradient._LinearGradient5297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		static LinearGradient()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.LinearGradient.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/LinearGradient"));
		}
		internal static void InitJNI()
		{
		}
	}
}
