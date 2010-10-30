namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AsyncPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AsyncPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AsyncPlayer.staticClass, "stop", "()V", ref global::android.media.AsyncPlayer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void play(android.content.Context arg0, android.net.Uri arg1, bool arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AsyncPlayer.staticClass, "play", "(Landroid/content/Context;Landroid/net/Uri;ZI)V", ref global::android.media.AsyncPlayer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public AsyncPlayer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AsyncPlayer._m2.native == global::System.IntPtr.Zero)
				global::android.media.AsyncPlayer._m2 = @__env.GetMethodIDNoThrow(global::android.media.AsyncPlayer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AsyncPlayer.staticClass, global::android.media.AsyncPlayer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AsyncPlayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AsyncPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AsyncPlayer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
