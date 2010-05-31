namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SslErrorHandler : android.os.Handler
	{
		internal new static global::java.lang.Class staticClass;
		static SslErrorHandler()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.SslErrorHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.SslErrorHandler(@__env);
			}
		}
		protected SslErrorHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel9334;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.SslErrorHandler._cancel9334);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, global::android.webkit.SslErrorHandler._cancel9334);
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage9335;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.SslErrorHandler._handleMessage9335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, global::android.webkit.SslErrorHandler._handleMessage9335, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _proceed9336;
		public virtual void proceed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.SslErrorHandler._proceed9336);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.SslErrorHandler.staticClass, global::android.webkit.SslErrorHandler._proceed9336);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.SslErrorHandler.staticClass = @__class;
			global::android.webkit.SslErrorHandler._cancel9334 = @__env.GetMethodID(global::android.webkit.SslErrorHandler.staticClass, "cancel", "()V");
			global::android.webkit.SslErrorHandler._handleMessage9335 = @__env.GetMethodID(global::android.webkit.SslErrorHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.webkit.SslErrorHandler._proceed9336 = @__env.GetMethodID(global::android.webkit.SslErrorHandler.staticClass, "proceed", "()V");
		}
	}
}
