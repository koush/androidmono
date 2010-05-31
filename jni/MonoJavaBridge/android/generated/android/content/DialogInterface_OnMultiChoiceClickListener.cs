namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface DialogInterface_OnMultiChoiceClickListener 
	{
		void onClick(android.content.DialogInterface arg0, int arg1, bool arg2);
	}

	public partial class DialogInterface_OnMultiChoiceClickListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __DialogInterface_OnMultiChoiceClickListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __DialogInterface_OnMultiChoiceClickListener : java.lang.Object, DialogInterface_OnMultiChoiceClickListener
	{
		internal static global::java.lang.Class staticClass;
		static __DialogInterface_OnMultiChoiceClickListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.__DialogInterface_OnMultiChoiceClickListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.__DialogInterface_OnMultiChoiceClickListener(@__env);
			}
		}
		internal __DialogInterface_OnMultiChoiceClickListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick1276;
		 void android.content.DialogInterface_OnMultiChoiceClickListener.onClick(android.content.DialogInterface arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.__DialogInterface_OnMultiChoiceClickListener._onClick1276, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.__DialogInterface_OnMultiChoiceClickListener.staticClass, global::android.content.__DialogInterface_OnMultiChoiceClickListener._onClick1276, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.__DialogInterface_OnMultiChoiceClickListener.staticClass = @__class;
			global::android.content.__DialogInterface_OnMultiChoiceClickListener._onClick1276 = @__env.GetMethodID(global::android.content.__DialogInterface_OnMultiChoiceClickListener.staticClass, "android.content.DialogInterface_OnMultiChoiceClickListener.onClick", "(Landroid/content/DialogInterface;IZ)V");
		}
	}
}
