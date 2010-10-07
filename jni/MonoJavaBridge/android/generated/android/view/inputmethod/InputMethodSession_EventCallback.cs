namespace android.view.inputmethod
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface InputMethodSession_EventCallback 
	{
		void finishedEvent(int arg0, bool arg1);
	}

	public partial class InputMethodSession_EventCallback_
	{
		public static global::java.lang.Class _class
		{
			get { return __InputMethodSession_EventCallback.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __InputMethodSession_EventCallback : java.lang.Object, InputMethodSession_EventCallback
	{
		internal static global::java.lang.Class staticClass;
		static __InputMethodSession_EventCallback()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.inputmethod.__InputMethodSession_EventCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.inputmethod.__InputMethodSession_EventCallback(@__env);
			}
		}
		internal __InputMethodSession_EventCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _finishedEvent9904;
		 void android.view.inputmethod.InputMethodSession_EventCallback.finishedEvent(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.inputmethod.__InputMethodSession_EventCallback._finishedEvent9904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.inputmethod.__InputMethodSession_EventCallback.staticClass, global::android.view.inputmethod.__InputMethodSession_EventCallback._finishedEvent9904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.inputmethod.__InputMethodSession_EventCallback.staticClass = @__class;
			global::android.view.inputmethod.__InputMethodSession_EventCallback._finishedEvent9904 = @__env.GetMethodID(global::android.view.inputmethod.__InputMethodSession_EventCallback.staticClass, "android.view.inputmethod.InputMethodSession_EventCallback.finishedEvent", "(IZ)V");
		}
	}
}
