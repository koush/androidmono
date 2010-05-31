namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface ValueCallback 
	{
		void onReceiveValue(java.lang.Object arg0);
	}

	public partial class ValueCallback_
	{
		public static global::java.lang.Class _class
		{
			get { return __ValueCallback.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __ValueCallback : java.lang.Object, ValueCallback
	{
		internal static global::java.lang.Class staticClass;
		static __ValueCallback()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.__ValueCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.__ValueCallback(@__env);
			}
		}
		internal __ValueCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onReceiveValue9363;
		 void android.webkit.ValueCallback.onReceiveValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.__ValueCallback._onReceiveValue9363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.__ValueCallback.staticClass, global::android.webkit.__ValueCallback._onReceiveValue9363, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.__ValueCallback.staticClass = @__class;
			global::android.webkit.__ValueCallback._onReceiveValue9363 = @__env.GetMethodID(global::android.webkit.__ValueCallback.staticClass, "android.webkit.ValueCallback.onReceiveValue", "(Ljava/lang/Object;)V");
		}
	}
}
