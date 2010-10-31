namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandlerThread : java.lang.Thread
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HandlerThread(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.HandlerThread.staticClass, "run", "()V", ref global::android.os.HandlerThread._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool quit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.HandlerThread.staticClass, "quit", "()Z", ref global::android.os.HandlerThread._m1);
		}
		public new global::android.os.Looper Looper
		{
			get
			{
				return getLooper();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.os.Looper getLooper()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.HandlerThread.staticClass, "getLooper", "()Landroid/os/Looper;", ref global::android.os.HandlerThread._m2) as android.os.Looper;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void onLooperPrepared()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.HandlerThread.staticClass, "onLooperPrepared", "()V", ref global::android.os.HandlerThread._m3);
		}
		public new int ThreadId
		{
			get
			{
				return getThreadId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getThreadId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.HandlerThread.staticClass, "getThreadId", "()I", ref global::android.os.HandlerThread._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public HandlerThread(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.HandlerThread._m5.native == global::System.IntPtr.Zero)
				global::android.os.HandlerThread._m5 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public HandlerThread(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.HandlerThread._m6.native == global::System.IntPtr.Zero)
				global::android.os.HandlerThread._m6 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static HandlerThread()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.HandlerThread.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/HandlerThread"));
		}
	}
}
