namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface DialogInterface_OnKeyListener 
	{
		bool onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2);
	}

	public partial class DialogInterface_OnKeyListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __DialogInterface_OnKeyListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __DialogInterface_OnKeyListener : java.lang.Object, DialogInterface_OnKeyListener
	{
		internal static global::java.lang.Class staticClass;
		static __DialogInterface_OnKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__DialogInterface_OnKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.__DialogInterface_OnKeyListener(@__env);
			}
		}
		internal __DialogInterface_OnKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKey1275;
		 bool android.content.DialogInterface_OnKeyListener.onKey(android.content.DialogInterface arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.__DialogInterface_OnKeyListener._onKey1275, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.__DialogInterface_OnKeyListener.staticClass, global::android.content.__DialogInterface_OnKeyListener._onKey1275, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.__DialogInterface_OnKeyListener.staticClass = @__class;
			global::android.content.__DialogInterface_OnKeyListener._onKey1275 = @__env.GetMethodID(global::android.content.__DialogInterface_OnKeyListener.staticClass, "android.content.DialogInterface_OnKeyListener.onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z");
		}
	}
}
