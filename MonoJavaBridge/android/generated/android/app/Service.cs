namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.Service_))]
	public abstract partial class Service : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Service(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize2136;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "finalize", "()V", ref global::android.app.Service._finalize2136);
		}
		internal static global::MonoJavaBridge.MethodId _onBind2137;
		public abstract global::android.os.IBinder onBind(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _getApplication2138;
		public virtual global::android.app.Application getApplication()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Service.staticClass, "getApplication", "()Landroid/app/Application;", ref global::android.app.Service._getApplication2138) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate2139;
		public virtual void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onCreate", "()V", ref global::android.app.Service._onCreate2139);
		}
		internal static global::MonoJavaBridge.MethodId _onStart2140;
		public virtual void onStart(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onStart", "(Landroid/content/Intent;I)V", ref global::android.app.Service._onStart2140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onStartCommand2141;
		public virtual int onStartCommand(android.content.Intent arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Service.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I", ref global::android.app.Service._onStartCommand2141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy2142;
		public virtual void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onDestroy", "()V", ref global::android.app.Service._onDestroy2142);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged2143;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.app.Service._onConfigurationChanged2143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory2144;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onLowMemory", "()V", ref global::android.app.Service._onLowMemory2144);
		}
		internal static global::MonoJavaBridge.MethodId _onUnbind2145;
		public virtual bool onUnbind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Service.staticClass, "onUnbind", "(Landroid/content/Intent;)Z", ref global::android.app.Service._onUnbind2145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRebind2146;
		public virtual void onRebind(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onRebind", "(Landroid/content/Intent;)V", ref global::android.app.Service._onRebind2146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSelf2147;
		public virtual void stopSelf()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "stopSelf", "()V", ref global::android.app.Service._stopSelf2147);
		}
		internal static global::MonoJavaBridge.MethodId _stopSelf2148;
		public virtual void stopSelf(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "stopSelf", "(I)V", ref global::android.app.Service._stopSelf2148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSelfResult2149;
		public virtual bool stopSelfResult(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Service.staticClass, "stopSelfResult", "(I)Z", ref global::android.app.Service._stopSelfResult2149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setForeground2150;
		public virtual void setForeground(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "setForeground", "(Z)V", ref global::android.app.Service._setForeground2150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startForeground2151;
		public virtual void startForeground(int arg0, android.app.Notification arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "startForeground", "(ILandroid/app/Notification;)V", ref global::android.app.Service._startForeground2151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopForeground2152;
		public virtual void stopForeground(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "stopForeground", "(Z)V", ref global::android.app.Service._stopForeground2152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dump2153;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.app.Service._dump2153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Service2154;
		public Service() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Service._Service2154.native == global::System.IntPtr.Zero)
				global::android.app.Service._Service2154 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Service.staticClass, global::android.app.Service._Service2154);
			Init(@__env, handle);
		}
		public static int START_CONTINUATION_MASK
		{
			get
			{
				return 15;
			}
		}
		public static int START_STICKY_COMPATIBILITY
		{
			get
			{
				return 0;
			}
		}
		public static int START_STICKY
		{
			get
			{
				return 1;
			}
		}
		public static int START_NOT_STICKY
		{
			get
			{
				return 2;
			}
		}
		public static int START_REDELIVER_INTENT
		{
			get
			{
				return 3;
			}
		}
		public static int START_FLAG_REDELIVERY
		{
			get
			{
				return 1;
			}
		}
		public static int START_FLAG_RETRY
		{
			get
			{
				return 2;
			}
		}
		static Service()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Service"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.Service))]
	internal sealed partial class Service_ : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Service_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBind2162;
		public override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.app.Service_.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.app.Service_._onBind2162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		static Service_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Service_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Service"));
		}
		internal static void InitJNI()
		{
		}
	}
}
