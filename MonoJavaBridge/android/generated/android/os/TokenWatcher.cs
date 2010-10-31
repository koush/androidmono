namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.TokenWatcher_))]
	public abstract partial class TokenWatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TokenWatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void cleanup(android.os.IBinder arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.TokenWatcher.staticClass, "cleanup", "(Landroid/os/IBinder;Z)V", ref global::android.os.TokenWatcher._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void acquire(android.os.IBinder arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.TokenWatcher.staticClass, "acquire", "(Landroid/os/IBinder;Ljava/lang/String;)V", ref global::android.os.TokenWatcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void release(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.TokenWatcher.staticClass, "release", "(Landroid/os/IBinder;)V", ref global::android.os.TokenWatcher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void dump()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.TokenWatcher.staticClass, "dump", "()V", ref global::android.os.TokenWatcher._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract void acquired();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void released();
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isAcquired()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.TokenWatcher.staticClass, "isAcquired", "()Z", ref global::android.os.TokenWatcher._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public TokenWatcher(android.os.Handler arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.TokenWatcher._m7.native == global::System.IntPtr.Zero)
				global::android.os.TokenWatcher._m7 = @__env.GetMethodIDNoThrow(global::android.os.TokenWatcher.staticClass, "<init>", "(Landroid/os/Handler;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TokenWatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.TokenWatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/TokenWatcher"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.TokenWatcher))]
	internal sealed partial class TokenWatcher_ : android.os.TokenWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TokenWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void acquired()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.TokenWatcher_.staticClass, "acquired", "()V", ref global::android.os.TokenWatcher_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void released()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.TokenWatcher_.staticClass, "released", "()V", ref global::android.os.TokenWatcher_._m1);
		}
		static TokenWatcher_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.TokenWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/TokenWatcher"));
		}
	}
}
