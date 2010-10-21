namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PorterDuffXfermode : android.graphics.Xfermode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PorterDuffXfermode()
		{
			InitJNI();
		}
		protected PorterDuffXfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PorterDuffXfermode5644;
		public PorterDuffXfermode(android.graphics.PorterDuff.Mode arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PorterDuffXfermode.staticClass, global::android.graphics.PorterDuffXfermode._PorterDuffXfermode5644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PorterDuffXfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PorterDuffXfermode"));
			global::android.graphics.PorterDuffXfermode._PorterDuffXfermode5644 = @__env.GetMethodIDNoThrow(global::android.graphics.PorterDuffXfermode.staticClass, "<init>", "(Landroid/graphics/PorterDuff$Mode;)V");
		}
	}
}
