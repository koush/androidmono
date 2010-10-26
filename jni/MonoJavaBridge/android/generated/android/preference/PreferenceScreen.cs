namespace android.preference
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PreferenceScreen : android.preference.PreferenceGroup, android.widget.AdapterView.OnItemClickListener, android.content.DialogInterface_OnDismissListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreferenceScreen()
		{
			InitJNI();
		}
		internal PreferenceScreen(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onDismiss10450;
		public void onDismiss(android.content.DialogInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceScreen._onDismiss10450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._onDismiss10450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _bind10451;
		public void bind(android.widget.ListView arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceScreen._bind10451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._bind10451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceScreen._getDialog10452)) as android.app.Dialog;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._getDialog10452)) as android.app.Dialog;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.preference.PreferenceScreen._getRootAdapter10453)) as android.widget.ListAdapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.ListAdapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._getRootAdapter10453)) as android.widget.ListAdapter;
		}
		internal static global::MonoJavaBridge.MethodId _onItemClick10454;
		public void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.preference.PreferenceScreen._onItemClick10454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.preference.PreferenceScreen.staticClass, global::android.preference.PreferenceScreen._onItemClick10454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.preference.PreferenceScreen.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/preference/PreferenceScreen"));
			global::android.preference.PreferenceScreen._onDismiss10450 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceScreen.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V");
			global::android.preference.PreferenceScreen._bind10451 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceScreen.staticClass, "bind", "(Landroid/widget/ListView;)V");
			global::android.preference.PreferenceScreen._getDialog10452 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceScreen.staticClass, "getDialog", "()Landroid/app/Dialog;");
			global::android.preference.PreferenceScreen._getRootAdapter10453 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceScreen.staticClass, "getRootAdapter", "()Landroid/widget/ListAdapter;");
			global::android.preference.PreferenceScreen._onItemClick10454 = @__env.GetMethodIDNoThrow(global::android.preference.PreferenceScreen.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
		}
	}
}
