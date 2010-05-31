namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface DialogInterface_OnCancelListener 
	{
		void onCancel(android.content.DialogInterface arg0);
	}

	public partial class DialogInterface_OnCancelListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __DialogInterface_OnCancelListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __DialogInterface_OnCancelListener : java.lang.Object, DialogInterface_OnCancelListener
	{
		internal static global::java.lang.Class staticClass;
		static __DialogInterface_OnCancelListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__DialogInterface_OnCancelListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.__DialogInterface_OnCancelListener(@__env);
			}
		}
		internal __DialogInterface_OnCancelListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCancel1272;
		 void android.content.DialogInterface_OnCancelListener.onCancel(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__DialogInterface_OnCancelListener._onCancel1272, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__DialogInterface_OnCancelListener.staticClass, global::android.content.__DialogInterface_OnCancelListener._onCancel1272, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.__DialogInterface_OnCancelListener.staticClass = @__class;
			global::android.content.__DialogInterface_OnCancelListener._onCancel1272 = @__env.GetMethodID(global::android.content.__DialogInterface_OnCancelListener.staticClass, "android.content.DialogInterface_OnCancelListener.onCancel", "(Landroid/content/DialogInterface;)V");
		}
	}
}
