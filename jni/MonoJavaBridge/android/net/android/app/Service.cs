namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Service : android.content.ContextWrapper, android.content.ComponentCallbacks
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Service() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Service), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Service(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBind730; 
		public abstract android.os.IBinder onBind(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getApplication731; 
		public virtual android.app.Application getApplication() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallObjectMethodPtr(this, _getApplication731)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Application>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.Service.staticClass, _getApplication731)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate732; 
		public virtual void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _onCreate732); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _onCreate732); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart733; 
		public virtual void onStart(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _onStart733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _onStart733, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartCommand734; 
		public virtual int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				return @__env.CallIntMethod(this, _onStartCommand734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.Service.staticClass, _onStartCommand734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy735; 
		public virtual void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _onDestroy735); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _onDestroy735); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged736; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _onConfigurationChanged736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _onConfigurationChanged736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory737; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _onLowMemory737); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _onLowMemory737); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUnbind738; 
		public virtual bool onUnbind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				return @__env.CallBooleanMethod(this, _onUnbind738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Service.staticClass, _onUnbind738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRebind739; 
		public virtual void onRebind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _onRebind739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _onRebind739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSelf740; 
		public virtual void stopSelf() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _stopSelf740); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _stopSelf740); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSelf741; 
		public virtual void stopSelf(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _stopSelf741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _stopSelf741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopSelfResult742; 
		public virtual bool stopSelfResult(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				return @__env.CallBooleanMethod(this, _stopSelfResult742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.Service.staticClass, _stopSelfResult742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setForeground743; 
		public virtual void setForeground(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _setForeground743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _setForeground743, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startForeground744; 
		public virtual void startForeground(int arg0, android.app.Notification arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _startForeground744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _startForeground744, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopForeground745; 
		public virtual void stopForeground(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _stopForeground745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _stopForeground745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump746; 
		protected virtual void dump(java.io.FileDescriptor arg0, java.io.PrintWriter arg1, java.lang.String[] arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Service)) 
				@__env.CallVoidMethod(this, _dump746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Service.staticClass, _dump746, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Service747; 
		public Service()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Service.staticClass, _Service747, this); 
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
			global::android.app.Service._onBind730 = @__env.GetMethodID(global::android.app.Service.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.app.Service._getApplication731 = @__env.GetMethodID(global::android.app.Service.staticClass, "getApplication", "()Landroid/app/Application;"); 
			global::android.app.Service._onCreate732 = @__env.GetMethodID(global::android.app.Service.staticClass, "onCreate", "()V"); 
			global::android.app.Service._onStart733 = @__env.GetMethodID(global::android.app.Service.staticClass, "onStart", "(Landroid/content/Intent;I)V"); 
			global::android.app.Service._onStartCommand734 = @__env.GetMethodID(global::android.app.Service.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I"); 
			global::android.app.Service._onDestroy735 = @__env.GetMethodID(global::android.app.Service.staticClass, "onDestroy", "()V"); 
			global::android.app.Service._onConfigurationChanged736 = @__env.GetMethodID(global::android.app.Service.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.app.Service._onLowMemory737 = @__env.GetMethodID(global::android.app.Service.staticClass, "onLowMemory", "()V"); 
			global::android.app.Service._onUnbind738 = @__env.GetMethodID(global::android.app.Service.staticClass, "onUnbind", "(Landroid/content/Intent;)Z"); 
			global::android.app.Service._onRebind739 = @__env.GetMethodID(global::android.app.Service.staticClass, "onRebind", "(Landroid/content/Intent;)V"); 
			global::android.app.Service._stopSelf740 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelf", "()V"); 
			global::android.app.Service._stopSelf741 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelf", "(I)V"); 
			global::android.app.Service._stopSelfResult742 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopSelfResult", "(I)Z"); 
			global::android.app.Service._setForeground743 = @__env.GetMethodID(global::android.app.Service.staticClass, "setForeground", "(Z)V"); 
			global::android.app.Service._startForeground744 = @__env.GetMethodID(global::android.app.Service.staticClass, "startForeground", "(ILandroid/app/Notification;)V"); 
			global::android.app.Service._stopForeground745 = @__env.GetMethodID(global::android.app.Service.staticClass, "stopForeground", "(Z)V"); 
			global::android.app.Service._dump746 = @__env.GetMethodID(global::android.app.Service.staticClass, "dump", "(Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V"); 
			global::android.app.Service._Service747 = @__env.GetMethodID(global::android.app.Service.staticClass, "<init>", "()V"); 
		} 
	} 
} 
