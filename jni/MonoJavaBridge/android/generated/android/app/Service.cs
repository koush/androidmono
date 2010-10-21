namespace android.app
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.Service_))]
	public abstract partial class Service : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Service()
		{
			InitJNI();
		}
		protected Service(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize2129;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._finalize2129);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._finalize2129);
		}
		internal static global::MonoJavaBridge.MethodId _onBind2130;
		public abstract global::android.os.IBinder onBind(android.content.Intent arg0);
		internal static global::MonoJavaBridge.MethodId _getApplication2131;
		public virtual global::android.app.Application getApplication() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Service._getApplication2131)) as android.app.Application;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._getApplication2131)) as android.app.Application;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate2132;
		public virtual void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._onCreate2132);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onCreate2132);
		}
		internal static global::MonoJavaBridge.MethodId _onStart2133;
		public virtual void onStart(android.content.Intent arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._onStart2133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onStart2133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onStartCommand2134;
		public virtual int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.Service._onStartCommand2134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onStartCommand2134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy2135;
		public virtual void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._onDestroy2135);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onDestroy2135);
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged2136;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._onConfigurationChanged2136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onConfigurationChanged2136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLowMemory2137;
		public virtual void onLowMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._onLowMemory2137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onLowMemory2137);
		}
		internal static global::MonoJavaBridge.MethodId _onUnbind2138;
		public virtual bool onUnbind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Service._onUnbind2138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onUnbind2138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onRebind2139;
		public virtual void onRebind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._onRebind2139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._onRebind2139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSelf2140;
		public virtual void stopSelf() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._stopSelf2140);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._stopSelf2140);
		}
		internal static global::MonoJavaBridge.MethodId _stopSelf2141;
		public virtual void stopSelf(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._stopSelf2141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._stopSelf2141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSelfResult2142;
		public virtual bool stopSelfResult(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.Service._stopSelfResult2142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._stopSelfResult2142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setForeground2143;
		public virtual void setForeground(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._setForeground2143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._setForeground2143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startForeground2144;
		public virtual void startForeground(int arg0, android.app.Notification arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._startForeground2144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._startForeground2144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stopForeground2145;
		public virtual void stopForeground(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._stopForeground2145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._stopForeground2145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dump2146;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.Service._dump2146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.Service.staticClass, global::android.app.Service._dump2146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Service2147;
		public Service()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.Service.staticClass, global::android.app.Service._Service2147);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Service"));
			global::android.app.Service._finalize2129 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "finalize", "()V");
			global::android.app.Service._onBind2130 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.app.Service._getApplication2131 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Service._onCreate2132 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onCreate", "()V");
			global::android.app.Service._onStart2133 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onStart", "(Landroid/content/Intent;I)V");
			global::android.app.Service._onStartCommand2134 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I");
			global::android.app.Service._onDestroy2135 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onDestroy", "()V");
			global::android.app.Service._onConfigurationChanged2136 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Service._onLowMemory2137 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onLowMemory", "()V");
			global::android.app.Service._onUnbind2138 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onUnbind", "(Landroid/content/Intent;)Z");
			global::android.app.Service._onRebind2139 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "onRebind", "(Landroid/content/Intent;)V");
			global::android.app.Service._stopSelf2140 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "stopSelf", "()V");
			global::android.app.Service._stopSelf2141 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "stopSelf", "(I)V");
			global::android.app.Service._stopSelfResult2142 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "stopSelfResult", "(I)Z");
			global::android.app.Service._setForeground2143 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "setForeground", "(Z)V");
			global::android.app.Service._startForeground2144 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "startForeground", "(ILandroid/app/Notification;)V");
			global::android.app.Service._stopForeground2145 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "stopForeground", "(Z)V");
			global::android.app.Service._dump2146 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.app.Service._Service2147 = @__env.GetMethodIDNoThrow(global::android.app.Service.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.Service))]
	public sealed partial class Service_ : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Service_()
		{
			InitJNI();
		}
		internal Service_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBind2155;
		public override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.Service_._onBind2155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.Service_.staticClass, global::android.app.Service_._onBind2155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.IBinder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.Service_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/Service"));
			global::android.app.Service_._onBind2155 = @__env.GetMethodIDNoThrow(global::android.app.Service_.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
		}
	}
}
