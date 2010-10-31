namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComposeShader : android.graphics.Shader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComposeShader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ComposeShader(android.graphics.Shader arg0, android.graphics.Shader arg1, android.graphics.Xfermode arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ComposeShader._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.ComposeShader._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.ComposeShader.staticClass, "<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/Xfermode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ComposeShader.staticClass, global::android.graphics.ComposeShader._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ComposeShader(android.graphics.Shader arg0, android.graphics.Shader arg1, android.graphics.PorterDuff.Mode arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.ComposeShader._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.ComposeShader._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.ComposeShader.staticClass, "<init>", "(Landroid/graphics/Shader;Landroid/graphics/Shader;Landroid/graphics/PorterDuff$Mode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ComposeShader.staticClass, global::android.graphics.ComposeShader._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ComposeShader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ComposeShader.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ComposeShader"));
		}
	}
}
