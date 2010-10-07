namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface DialogInterface_OnShowListener 
	{
		void onShow(android.content.DialogInterface arg0);
	}

	public partial class DialogInterface_OnShowListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __DialogInterface_OnShowListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __DialogInterface_OnShowListener : java.lang.Object, DialogInterface_OnShowListener
	{
		internal static global::java.lang.Class staticClass;
		static __DialogInterface_OnShowListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__DialogInterface_OnShowListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.__DialogInterface_OnShowListener(@__env);
			}
		}
		internal __DialogInterface_OnShowListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onShow1420;
		 void android.content.DialogInterface_OnShowListener.onShow(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__DialogInterface_OnShowListener._onShow1420, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__DialogInterface_OnShowListener.staticClass, global::android.content.__DialogInterface_OnShowListener._onShow1420, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.__DialogInterface_OnShowListener.staticClass = @__class;
			global::android.content.__DialogInterface_OnShowListener._onShow1420 = @__env.GetMethodID(global::android.content.__DialogInterface_OnShowListener.staticClass, "android.content.DialogInterface_OnShowListener.onShow", "(Landroid/content/DialogInterface;)V");
		}
	}
}
