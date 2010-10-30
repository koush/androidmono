namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.IntentService_))]
	public abstract partial class IntentService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IntentService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBind1910;
		public override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onBind1910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1911;
		public override void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onCreate1911);
		}
		internal static global::MonoJavaBridge.MethodId _onStart1912;
		public override void onStart(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onStart1912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onStartCommand1913;
		public override int onStartCommand(android.content.Intent arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onStartCommand1913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy1914;
		public override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onDestroy1914);
		}
		internal static global::MonoJavaBridge.MethodId _setIntentRedelivery1915;
		public virtual void setIntentRedelivery(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._setIntentRedelivery1915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onHandleIntent1916;
		protected abstract void onHandleIntent(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _IntentService1917;
		public IntentService(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.IntentService.staticClass, global::android.app.IntentService._IntentService1917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IntentService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.IntentService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/IntentService"));
			global::android.app.IntentService._onBind1910 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.app.IntentService._onCreate1911 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onCreate", "()V");
			global::android.app.IntentService._onStart1912 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onStart", "(Landroid/content/Intent;I)V");
			global::android.app.IntentService._onStartCommand1913 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I");
			global::android.app.IntentService._onDestroy1914 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onDestroy", "()V");
			global::android.app.IntentService._setIntentRedelivery1915 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "setIntentRedelivery", "(Z)V");
			global::android.app.IntentService._onHandleIntent1916 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V");
			global::android.app.IntentService._IntentService1917 = @__env.GetMethodIDNoThrow(global::android.app.IntentService.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.IntentService))]
	internal sealed partial class IntentService_ : android.app.IntentService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal IntentService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onHandleIntent1918;
		protected override void onHandleIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.app.IntentService_._onHandleIntent1918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static IntentService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.IntentService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/IntentService"));
			global::android.app.IntentService_._onHandleIntent1918 = @__env.GetMethodIDNoThrow(global::android.app.IntentService_.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
