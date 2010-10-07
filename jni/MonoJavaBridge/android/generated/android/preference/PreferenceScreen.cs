namespace android.preference
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class PreferenceScreen : android.preference.PreferenceGroup, android.widget.AdapterView.OnItemClickListener, android.content.DialogInterface_OnDismissListener
	{
		internal new static global::java.lang.Class staticClass;
		static PreferenceScreen()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.preference.PreferenceScreen), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.preference.PreferenceScreen(@__env);
			}
		}
		internal PreferenceScreen(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss6685;
		public void onDismiss(android.content.DialogInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceScreen._onDismiss6685, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._onDismiss6685, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bind6686;
		public void bind(android.widget.ListView arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceScreen._bind6686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._bind6686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDialog6687;
		public global::android.app.Dialog getDialog() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceScreen._getDialog6687));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._getDialog6687));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRootAdapter6688;
		public global::android.widget.ListAdapter getRootAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.preference.PreferenceScreen._getRootAdapter6688));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._getRootAdapter6688));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onItemClick6689;
		public void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.preference.PreferenceScreen._onItemClick6689, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._onItemClick6689, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.preference.PreferenceScreen.staticClass = @__class;
			global::android.preference.PreferenceScreen._onDismiss6685 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.preference.PreferenceScreen._bind6686 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "bind", "(Landroid/widget/ListView;)V");
			global::android.preference.PreferenceScreen._getDialog6687 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "getDialog", "()Landroid/app/Dialog;");
			global::android.preference.PreferenceScreen._getRootAdapter6688 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "getRootAdapter", "()Landroid/widget/ListAdapter;");
			global::android.preference.PreferenceScreen._onItemClick6689 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
		}
	}
}
