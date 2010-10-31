namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.IntentService_))]
	public abstract partial class IntentService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntentService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.app.IntentService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.app.IntentService._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, "onCreate", "()V", ref global::android.app.IntentService._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void onStart(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, "onStart", "(Landroid/content/Intent;I)V", ref global::android.app.IntentService._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int onStartCommand(android.content.Intent arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.IntentService.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I", ref global::android.app.IntentService._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, "onDestroy", "()V", ref global::android.app.IntentService._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setIntentRedelivery(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, "setIntentRedelivery", "(Z)V", ref global::android.app.IntentService._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract void onHandleIntent(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public IntentService(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.IntentService._m7.native == global::System.IntPtr.Zero)
				global::android.app.IntentService._m7 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.IntentService.staticClass, global::android.app.IntentService._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IntentService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.IntentService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/IntentService"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.IntentService))]
	internal sealed partial class IntentService_ : android.app.IntentService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IntentService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onHandleIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService_.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V", ref global::android.app.IntentService_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static IntentService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.IntentService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/IntentService"));
		}
	}
}
