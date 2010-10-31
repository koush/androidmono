namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PorterDuffXfermode : android.graphics.Xfermode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PorterDuffXfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public PorterDuffXfermode(android.graphics.PorterDuff.Mode arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PorterDuffXfermode._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.PorterDuffXfermode._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuffXfermode.staticClass, "<init>", "(Landroid/graphics/PorterDuff$Mode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuffXfermode.staticClass, global::android.graphics.PorterDuffXfermode._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PorterDuffXfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuffXfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuffXfermode"));
		}
	}
}
