namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Service : android.content.ContextWrapper, android.content.ComponentCallbacks
	{
		internal new static global::java.lang.Class staticClass;
		static Service()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Service), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Service(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBind781;
		public abstract global::android.os.IBinder onBind(android.content.Intent arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getApplication782;
		public virtual global::android.app.Application getApplication() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Service._getApplication782));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Service.staticClass, global::android.app.Service._getApplication782));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate783;
		public virtual void onCreate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._onCreate783);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onCreate783);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStart784;
		public virtual void onStart(android.content.Intent arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._onStart784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onStart784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStartCommand785;
		public virtual int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.Service._onStartCommand785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onStartCommand785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy786;
		public virtual void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._onDestroy786);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onDestroy786);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged787;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._onConfigurationChanged787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onConfigurationChanged787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory788;
		public virtual void onLowMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._onLowMemory788);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onLowMemory788);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUnbind789;
		public virtual bool onUnbind(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Service._onUnbind789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onUnbind789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRebind790;
		public virtual void onRebind(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._onRebind790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onRebind790, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSelf791;
		public virtual void stopSelf() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._stopSelf791);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopSelf791);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSelf792;
		public virtual void stopSelf(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._stopSelf792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopSelf792, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSelfResult793;
		public virtual bool stopSelfResult(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.Service._stopSelfResult793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopSelfResult793, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setForeground794;
		public virtual void setForeground(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._setForeground794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._setForeground794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startForeground795;
		public virtual void startForeground(int arg0, android.app.Notification arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._startForeground795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._startForeground795, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopForeground796;
		public virtual void stopForeground(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._stopForeground796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopForeground796, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump797;
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Service._dump797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._dump797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Service798;
		public Service()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Service.staticClass, global::android.app.Service._Service798, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.Service.staticClass = @__class;
			global::android.app.Service._onBind781 = @__env.GetMethodID(global::android.app.Service.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			global::android.app.Service._getApplication782 = @__env.GetMethodID(global::android.app.Service.staticClass, "getApplication", "()Landroid/app/Application;");
			global::android.app.Service._onCreate783 = @__env.GetMethodID(global::android.app.Service.staticClass, "onCreate", "()V");
			global::android.app.Service._onStart784 = @__env.GetMethodID(global::android.app.Service.staticClass, "onStart", "(Landroid/content/Intent;I)V");
			global::android.app.Service._onStartCommand785 = @__env.GetMethodID(global::android.app.Service.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I");
			global::android.app.Service._onDestroy786 = @__env.GetMethodID(global::android.app.Service.staticClass, "onDestroy", "()V");
			global::android.app.Service._onConfigurationChanged787 = @__env.GetMethodID(global::android.app.Service.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Service._onLowMemory788 = @__env.GetMethodID(global::android.app.Service.staticClass, "onLowMemory", "()V");
			global::android.app.Service._onUnbind789 = @__env.GetMethodID(global::android.app.Service.staticClass, "onUnbind", "(Landroid/content/Intent;)Z");
			global::android.app.Service._onRebind790 = @__env.GetMethodID(global::android.app.Service.staticClass, "onRebind", "(Landroid/content/Intent;)V");
			global::android.app.Service._stopSelf791 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelf", "()V");
			global::android.app.Service._stopSelf792 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelf", "(I)V");
			global::android.app.Service._stopSelfResult793 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelfResult", "(I)Z");
			global::android.app.Service._setForeground794 = @__env.GetMethodID(global::android.app.Service.staticClass, "setForeground", "(Z)V");
			global::android.app.Service._startForeground795 = @__env.GetMethodID(global::android.app.Service.staticClass, "startForeground", "(ILandroid/app/Notification;)V");
			global::android.app.Service._stopForeground796 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopForeground", "(Z)V");
			global::android.app.Service._dump797 = @__env.GetMethodID(global::android.app.Service.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
			global::android.app.Service._Service798 = @__env.GetMethodID(global::android.app.Service.staticClass, "<init>", "()V");
		}
	}
}
