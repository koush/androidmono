namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class HttpAuthHandler : android.os.Handler
	{
		internal new static global::java.lang.Class staticClass;
		static HttpAuthHandler()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.HttpAuthHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.HttpAuthHandler(@__env);
			}
		}
		protected HttpAuthHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel9973;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.HttpAuthHandler._cancel9973);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._cancel9973);
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage9974;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.HttpAuthHandler._handleMessage9974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._handleMessage9974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _proceed9975;
		public virtual void proceed(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.HttpAuthHandler._proceed9975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._proceed9975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _useHttpAuthUsernamePassword9976;
		public virtual bool useHttpAuthUsernamePassword() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword9976);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword9976);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.HttpAuthHandler.staticClass = @__class;
			global::android.webkit.HttpAuthHandler._cancel9973 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "cancel", "()V");
			global::android.webkit.HttpAuthHandler._handleMessage9974 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.webkit.HttpAuthHandler._proceed9975 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "proceed", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword9976 = @__env.GetMethodID(global::android.webkit.HttpAuthHandler.staticClass, "useHttpAuthUsernamePassword", "()Z");
		}
	}
}
