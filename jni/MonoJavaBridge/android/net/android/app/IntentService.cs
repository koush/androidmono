namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class IntentService : android.app.Service
	{ 
		internal new static global::java.lang.Class staticClass; 
		static IntentService() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.IntentService), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected IntentService(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBind595; 
		public override android.os.IBinder onBind(android.content.Intent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _onBind595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.IntentService.staticClass, _onBind595, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate596; 
		public override void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, _onCreate596); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.IntentService.staticClass, _onCreate596); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart597; 
		public override void onStart(android.content.Intent arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, _onStart597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.IntentService.staticClass, _onStart597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStartCommand598; 
		public override int onStartCommand(android.content.Intent arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				return @__env.CallIntMethod(this, _onStartCommand598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.IntentService.staticClass, _onStartCommand598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy599; 
		public override void onDestroy() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, _onDestroy599); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.IntentService.staticClass, _onDestroy599); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIntentRedelivery600; 
		public virtual void setIntentRedelivery(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.IntentService)) 
				@__env.CallVoidMethod(this, _setIntentRedelivery600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.IntentService.staticClass, _setIntentRedelivery600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onHandleIntent601; 
		protected abstract void onHandleIntent(android.content.Intent arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _IntentService602; 
		public IntentService(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.IntentService.staticClass, _IntentService602, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.IntentService.staticClass = @__class; 
			global::android.app.IntentService._onBind595 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"); 
			global::android.app.IntentService._onCreate596 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onCreate", "()V"); 
			global::android.app.IntentService._onStart597 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onStart", "(Landroid/content/Intent;I)V"); 
			global::android.app.IntentService._onStartCommand598 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onStartCommand", "(Landroid/content/Intent;II)I"); 
			global::android.app.IntentService._onDestroy599 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onDestroy", "()V"); 
			global::android.app.IntentService._setIntentRedelivery600 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "setIntentRedelivery", "(Z)V"); 
			global::android.app.IntentService._onHandleIntent601 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "onHandleIntent", "(Landroid/content/Intent;)V"); 
			global::android.app.IntentService._IntentService602 = @__env.GetMethodID(global::android.app.IntentService.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
