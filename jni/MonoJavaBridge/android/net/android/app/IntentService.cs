namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class IntentService : android.app.Service
	{ 
		internal new static global::java.lang.Class staticClass; 
		static IntentService() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.IntentService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected IntentService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBind603; 
		public override global::android.os.IBinder onBind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.IntentService._onBind603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onBind603, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate604; 
		public override void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, global::android.app.IntentService._onCreate604); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onCreate604); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart605; 
		public override void onStart(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, global::android.app.IntentService._onStart605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onStart605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartCommand606; 
		public override int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				return @__env.CallIntMethod(this, global::android.app.IntentService._onStartCommand606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onStartCommand606, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy607; 
		public override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, global::android.app.IntentService._onDestroy607); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._onDestroy607); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntentRedelivery608; 
		public virtual void setIntentRedelivery(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, global::android.app.IntentService._setIntentRedelivery608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.IntentService.staticClass, global::android.app.IntentService._setIntentRedelivery608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onHandleIntent609; 
		protected abstract void onHandleIntent(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _IntentService610; 
		public IntentService(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.IntentService.staticClass, global::android.app.IntentService._IntentService610, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.IntentService.staticClass = @__class; 
			global::android.app.IntentService._onBind603 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.app.IntentService._onCreate604 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onCreate", "()V"); 
			global::android.app.IntentService._onStart605 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onStart", "(Landroid/content/Intent;I)V"); 
			global::android.app.IntentService._onStartCommand606 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I"); 
			global::android.app.IntentService._onDestroy607 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onDestroy", "()V"); 
			global::android.app.IntentService._setIntentRedelivery608 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "setIntentRedelivery", "(Z)V"); 
			global::android.app.IntentService._onHandleIntent609 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V"); 
			global::android.app.IntentService._IntentService610 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
