namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HandlerThread : java.lang.Thread
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HandlerThread()
		{
			InitJNI();
		}
		protected HandlerThread(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run9845;
		public override void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.HandlerThread._run9845);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._run9845);
		}
		internal static global::MonoJavaBridge.MethodId _quit9846;
		public virtual bool quit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.HandlerThread._quit9846);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._quit9846);
		}
		public new global::android.os.Looper Looper
		{
			get
			{
				return getLooper();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLooper9847;
		public virtual global::android.os.Looper getLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.HandlerThread._getLooper9847)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._getLooper9847)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _onLooperPrepared9848;
		protected virtual void onLooperPrepared() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.HandlerThread._onLooperPrepared9848);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._onLooperPrepared9848);
		}
		public new int ThreadId
		{
			get
			{
				return getThreadId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThreadId9849;
		public virtual int getThreadId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.HandlerThread._getThreadId9849);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._getThreadId9849);
		}
		internal static global::MonoJavaBridge.MethodId _HandlerThread9850;
		public HandlerThread(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._HandlerThread9850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HandlerThread9851;
		public HandlerThread(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._HandlerThread9851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.HandlerThread.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/HandlerThread"));
			global::android.os.HandlerThread._run9845 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "run", "()V");
			global::android.os.HandlerThread._quit9846 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "quit", "()Z");
			global::android.os.HandlerThread._getLooper9847 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "getLooper", "()Landroid/os/Looper;");
			global::android.os.HandlerThread._onLooperPrepared9848 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "onLooperPrepared", "()V");
			global::android.os.HandlerThread._getThreadId9849 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "getThreadId", "()I");
			global::android.os.HandlerThread._HandlerThread9850 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.HandlerThread._HandlerThread9851 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
