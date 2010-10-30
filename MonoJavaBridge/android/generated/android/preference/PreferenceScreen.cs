namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PreferenceScreen : android.preference.PreferenceGroup, android.widget.AdapterView.OnItemClickListener, android.content.DialogInterface_OnDismissListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreferenceScreen(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss10450;
		public void onDismiss(android.content.DialogInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceScreen.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V", ref global::android.preference.PreferenceScreen._onDismiss10450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind10451;
		public void bind(android.widget.ListView arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceScreen.staticClass, "bind", "(Landroid/widget/ListView;)V", ref global::android.preference.PreferenceScreen._bind10451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.app.Dialog Dialog
		{
			get
			{
				return getDialog();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDialog10452;
		public global::android.app.Dialog getDialog()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.preference.PreferenceScreen.staticClass, "getDialog", "()Landroid/app/Dialog;", ref global::android.preference.PreferenceScreen._getDialog10452) as android.app.Dialog;
		}
		public new global::android.widget.ListAdapter RootAdapter
		{
			get
			{
				return getRootAdapter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRootAdapter10453;
		public global::android.widget.ListAdapter getRootAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.ListAdapter>(this, global::android.preference.PreferenceScreen.staticClass, "getRootAdapter", "()Landroid/widget/ListAdapter;", ref global::android.preference.PreferenceScreen._getRootAdapter10453) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _onItemClick10454;
		public void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.preference.PreferenceScreen.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", ref global::android.preference.PreferenceScreen._onItemClick10454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		static PreferenceScreen()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceScreen.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceScreen"));
		}
		internal static void InitJNI()
		{
		}
	}
}
