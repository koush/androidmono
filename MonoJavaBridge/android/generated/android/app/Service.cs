namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.Service_))]
	public abstract partial class Service : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Service(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "finalize", "()V", ref global::android.app.Service._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::android.os.IBinder onBind(android.content.Intent arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.app.Application getApplication()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.Service.staticClass, "getApplication", "()Landroid/app/Application;", ref global::android.app.Service._m2) as android.app.Application;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onCreate", "()V", ref global::android.app.Service._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onStart(android.content.Intent arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onStart", "(Landroid/content/Intent;I)V", ref global::android.app.Service._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int onStartCommand(android.content.Intent arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.Service.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I", ref global::android.app.Service._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onDestroy", "()V", ref global::android.app.Service._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V", ref global::android.app.Service._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onLowMemory()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onLowMemory", "()V", ref global::android.app.Service._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool onUnbind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Service.staticClass, "onUnbind", "(Landroid/content/Intent;)Z", ref global::android.app.Service._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void onRebind(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "onRebind", "(Landroid/content/Intent;)V", ref global::android.app.Service._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void stopSelf()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "stopSelf", "()V", ref global::android.app.Service._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void stopSelf(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "stopSelf", "(I)V", ref global::android.app.Service._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool stopSelfResult(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.Service.staticClass, "stopSelfResult", "(I)Z", ref global::android.app.Service._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setForeground(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "setForeground", "(Z)V", ref global::android.app.Service._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void startForeground(int arg0, android.app.Notification arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "startForeground", "(ILandroid/app/Notification;)V", ref global::android.app.Service._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void stopForeground(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "stopForeground", "(Z)V", ref global::android.app.Service._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.Service.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", ref global::android.app.Service._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public Service() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.Service._m18.native == global::System.IntPtr.Zero)
				global::android.app.Service._m18 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Service.staticClass, global::android.app.Service._m18);
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
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.Service))]
	internal sealed partial class Service_ : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Service_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.app.Service_.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.app.Service_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		static Service_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Service_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Service"));
		}
	}
}
