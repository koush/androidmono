namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Xfermode : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Xfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Xfermode.staticClass, "finalize", "()V", ref global::android.graphics.Xfermode._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public Xfermode() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Xfermode._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.Xfermode._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.Xfermode.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Xfermode.staticClass, global::android.graphics.Xfermode._m1);
			Init(@__env, handle);
		}
		static Xfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Xfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Xfermode"));
		}
	}
}
