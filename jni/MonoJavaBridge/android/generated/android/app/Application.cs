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
		internal static global::net.sf.jni4net.jni.MethodId _onCreate437;
		public virtual void onCreate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Application._onCreate437);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onCreate437);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onConfigurationChanged438;
		public virtual void onConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Application._onConfigurationChanged438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onConfigurationChanged438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLowMemory439;
		public virtual void onLowMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Application._onLowMemory439);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onLowMemory439);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTerminate440;
		public virtual void onTerminate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.Application._onTerminate440);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.Application.staticClass, global::android.app.Application._onTerminate440);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Application441;
		public Application()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.Application.staticClass, global::android.app.Application._Application441, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.Application.staticClass = @__class;
			global::android.app.Application._onCreate437 = @__env.GetMethodID(global::android.app.Application.staticClass, "onCreate", "()V");
			global::android.app.Application._onConfigurationChanged438 = @__env.GetMethodID(global::android.app.Application.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.app.Application._onLowMemory439 = @__env.GetMethodID(global::android.app.Application.staticClass, "onLowMemory", "()V");
			global::android.app.Application._onTerminate440 = @__env.GetMethodID(global::android.app.Application.staticClass, "onTerminate", "()V");
			global::android.app.Application._Application441 = @__env.GetMethodID(global::android.app.Application.staticClass, "<init>", "()V");
		}
	}
}
