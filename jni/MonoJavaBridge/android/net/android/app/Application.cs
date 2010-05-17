namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Application : android.content.ContextWrapper, android.content.ComponentCallbacks
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Application() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.Application), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.Application(@__env); 
			} 
		} 
		protected Application(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate422; 
		public virtual void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Application)) 
				@__env.CallVoidMethod(this, _onCreate422); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Application.staticClass, _onCreate422); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged423; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Application)) 
				@__env.CallVoidMethod(this, _onConfigurationChanged423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Application.staticClass, _onConfigurationChanged423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory424; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Application)) 
				@__env.CallVoidMethod(this, _onLowMemory424); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Application.staticClass, _onLowMemory424); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTerminate425; 
		public virtual void onTerminate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.Application)) 
				@__env.CallVoidMethod(this, _onTerminate425); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.Application.staticClass, _onTerminate425); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Application426; 
		public Application()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Application.staticClass, _Application426, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Application.staticClass = @__class; 
			global::android.app.Application._onCreate422 = @__env.GetMethodID(global::android.app.Application.staticClass, "onCreate", "()V"); 
			global::android.app.Application._onConfigurationChanged423 = @__env.GetMethodID(global::android.app.Application.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.app.Application._onLowMemory424 = @__env.GetMethodID(global::android.app.Application.staticClass, "onLowMemory", "()V"); 
			global::android.app.Application._onTerminate425 = @__env.GetMethodID(global::android.app.Application.staticClass, "onTerminate", "()V"); 
			global::android.app.Application._Application426 = @__env.GetMethodID(global::android.app.Application.staticClass, "<init>", "()V"); 
		} 
	} 
} 
