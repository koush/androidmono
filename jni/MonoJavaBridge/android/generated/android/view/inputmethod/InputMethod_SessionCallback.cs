namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface InputMethod_SessionCallback 
	{
		void sessionCreated(android.view.inputmethod.InputMethodSession arg0);
	}

	public partial class InputMethod_SessionCallback_
	{
		public static global::java.lang.Class _class
		{
			get { return __InputMethod_SessionCallback.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __InputMethod_SessionCallback : java.lang.Object, InputMethod_SessionCallback
	{
		internal static global::java.lang.Class staticClass;
		static __InputMethod_SessionCallback()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.__InputMethod_SessionCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.__InputMethod_SessionCallback(@__env);
			}
		}
		internal __InputMethod_SessionCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _sessionCreated9144;
		 void android.view.inputmethod.InputMethod_SessionCallback.sessionCreated(android.view.inputmethod.InputMethodSession arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethod_SessionCallback._sessionCreated9144, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethod_SessionCallback.staticClass, global::android.view.inputmethod.__InputMethod_SessionCallback._sessionCreated9144, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.__InputMethod_SessionCallback.staticClass = @__class;
			global::android.view.inputmethod.__InputMethod_SessionCallback._sessionCreated9144 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethod_SessionCallback.staticClass, "android.view.inputmethod.InputMethod_SessionCallback.sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V");
		}
	}
}
