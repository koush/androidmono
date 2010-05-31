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
		internal static global::net.sf.jni4net.jni.MethodId _onBind742; 
		public abstract global::android.os.IBinder onBind(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplication743; 
		public virtual global::android.app.Application getApplication() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.Service._getApplication743)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.Service.staticClass, global::android.app.Service._getApplication743)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate744; 
		public virtual void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._onCreate744); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onCreate744); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart745; 
		public virtual void onStart(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._onStart745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onStart745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartCommand746; 
		public virtual int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.app.Service._onStartCommand746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onStartCommand746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy747; 
		public virtual void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._onDestroy747); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onDestroy747); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged748; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._onConfigurationChanged748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onConfigurationChanged748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory749; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._onLowMemory749); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onLowMemory749); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnbind750; 
		public virtual bool onUnbind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Service._onUnbind750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onUnbind750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRebind751; 
		public virtual void onRebind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._onRebind751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._onRebind751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSelf752; 
		public virtual void stopSelf() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._stopSelf752); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopSelf752); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSelf753; 
		public virtual void stopSelf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._stopSelf753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopSelf753, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSelfResult754; 
		public virtual bool stopSelfResult(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.Service._stopSelfResult754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopSelfResult754, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setForeground755; 
		public virtual void setForeground(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._setForeground755, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._setForeground755, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startForeground756; 
		public virtual void startForeground(int arg0, android.app.Notification arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._startForeground756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._startForeground756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopForeground757; 
		public virtual void stopForeground(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._stopForeground757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._stopForeground757, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump758; 
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Service._dump758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Service.staticClass, global::android.app.Service._dump758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Service759; 
		public Service()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Service.staticClass, global::android.app.Service._Service759, this); 
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
			global::android.app.Service._onBind742 = @__env.GetMethodID(global::android.app.Service.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.app.Service._getApplication743 = @__env.GetMethodID(global::android.app.Service.staticClass, "getApplication", "()Landroid/app/Application;"); 
			global::android.app.Service._onCreate744 = @__env.GetMethodID(global::android.app.Service.staticClass, "onCreate", "()V"); 
			global::android.app.Service._onStart745 = @__env.GetMethodID(global::android.app.Service.staticClass, "onStart", "(Landroid/content/Intent;I)V"); 
			global::android.app.Service._onStartCommand746 = @__env.GetMethodID(global::android.app.Service.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I"); 
			global::android.app.Service._onDestroy747 = @__env.GetMethodID(global::android.app.Service.staticClass, "onDestroy", "()V"); 
			global::android.app.Service._onConfigurationChanged748 = @__env.GetMethodID(global::android.app.Service.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.app.Service._onLowMemory749 = @__env.GetMethodID(global::android.app.Service.staticClass, "onLowMemory", "()V"); 
			global::android.app.Service._onUnbind750 = @__env.GetMethodID(global::android.app.Service.staticClass, "onUnbind", "(Landroid/content/Intent;)Z"); 
			global::android.app.Service._onRebind751 = @__env.GetMethodID(global::android.app.Service.staticClass, "onRebind", "(Landroid/content/Intent;)V"); 
			global::android.app.Service._stopSelf752 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelf", "()V"); 
			global::android.app.Service._stopSelf753 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelf", "(I)V"); 
			global::android.app.Service._stopSelfResult754 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelfResult", "(I)Z"); 
			global::android.app.Service._setForeground755 = @__env.GetMethodID(global::android.app.Service.staticClass, "setForeground", "(Z)V"); 
			global::android.app.Service._startForeground756 = @__env.GetMethodID(global::android.app.Service.staticClass, "startForeground", "(ILandroid/app/Notification;)V"); 
			global::android.app.Service._stopForeground757 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopForeground", "(Z)V"); 
			global::android.app.Service._dump758 = @__env.GetMethodID(global::android.app.Service.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V"); 
			global::android.app.Service._Service759 = @__env.GetMethodID(global::android.app.Service.staticClass, "<init>", "()V"); 
		} 
	} 
} 
