namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Application : android.content.ContextWrapper, android.content.ComponentCallbacks
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Application() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.Application), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onCreate429; 
		public virtual void onCreate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Application._onCreate429); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onCreate429); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged430; 
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Application._onConfigurationChanged430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onConfigurationChanged430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory431; 
		public virtual void onLowMemory() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Application._onLowMemory431); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onLowMemory431); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTerminate432; 
		public virtual void onTerminate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.Application._onTerminate432); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onTerminate432); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Application433; 
		public Application()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.Application.staticClass, global::android.app.Application._Application433, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.Application.staticClass = @__class; 
			global::android.app.Application._onCreate429 = @__env.GetMethodID(global::android.app.Application.staticClass, "onCreate", "()V"); 
			global::android.app.Application._onConfigurationChanged430 = @__env.GetMethodID(global::android.app.Application.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"); 
			global::android.app.Application._onLowMemory431 = @__env.GetMethodID(global::android.app.Application.staticClass, "onLowMemory", "()V"); 
			global::android.app.Application._onTerminate432 = @__env.GetMethodID(global::android.app.Application.staticClass, "onTerminate", "()V"); 
			global::android.app.Application._Application433 = @__env.GetMethodID(global::android.app.Application.staticClass, "<init>", "()V"); 
		} 
	} 
} 
