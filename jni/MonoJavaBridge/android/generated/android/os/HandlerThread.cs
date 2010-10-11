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
		internal static global::MonoJavaBridge.MethodId _run6454;
		public override void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.HandlerThread._run6454);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._run6454);
		}
		internal static global::MonoJavaBridge.MethodId _quit6455;
		public virtual bool quit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.HandlerThread._quit6455);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._quit6455);
		}
		internal static global::MonoJavaBridge.MethodId _getLooper6456;
		public virtual global::android.os.Looper getLooper() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.HandlerThread._getLooper6456)) as android.os.Looper;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._getLooper6456)) as android.os.Looper;
		}
		internal static global::MonoJavaBridge.MethodId _onLooperPrepared6457;
		protected virtual void onLooperPrepared() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.HandlerThread._onLooperPrepared6457);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._onLooperPrepared6457);
		}
		internal static global::MonoJavaBridge.MethodId _getThreadId6458;
		public virtual int getThreadId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.HandlerThread._getThreadId6458);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.HandlerThread.staticClass, global::android.os.HandlerThread._getThreadId6458);
		}
		internal static global::MonoJavaBridge.MethodId _HandlerThread6459;
		public HandlerThread(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._HandlerThread6459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HandlerThread6460;
		public HandlerThread(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.HandlerThread.staticClass, global::android.os.HandlerThread._HandlerThread6460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.HandlerThread.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/HandlerThread"));
			global::android.os.HandlerThread._run6454 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "run", "()V");
			global::android.os.HandlerThread._quit6455 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "quit", "()Z");
			global::android.os.HandlerThread._getLooper6456 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "getLooper", "()Landroid/os/Looper;");
			global::android.os.HandlerThread._onLooperPrepared6457 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "onLooperPrepared", "()V");
			global::android.os.HandlerThread._getThreadId6458 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "getThreadId", "()I");
			global::android.os.HandlerThread._HandlerThread6459 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.os.HandlerThread._HandlerThread6460 = @__env.GetMethodIDNoThrow(global::android.os.HandlerThread.staticClass, "<init>", "(Ljava/lang/String;I)V");
		}
	}
}
