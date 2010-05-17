namespace android.preference 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class PreferenceScreen : android.preference.PreferenceGroup, android.widget.AdapterView.OnItemClickListener, android.content.DialogInterface_OnDismissListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PreferenceScreen() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.preference.PreferenceScreen), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onDismiss5827; 
		public void onDismiss(android.content.DialogInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceScreen)) 
				@__env.CallVoidMethod(this, _onDismiss5827, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceScreen.staticClass, _onDismiss5827, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bind5828; 
		public void bind(android.widget.ListView arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceScreen)) 
				@__env.CallVoidMethod(this, _bind5828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceScreen.staticClass, _bind5828, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDialog5829; 
		public android.app.Dialog getDialog() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceScreen)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallObjectMethodPtr(this, _getDialog5829)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.Dialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceScreen.staticClass, _getDialog5829)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRootAdapter5830; 
		public android.widget.ListAdapter getRootAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceScreen)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getRootAdapter5830)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.preference.PreferenceScreen.staticClass, _getRootAdapter5830)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onItemClick5831; 
		public void onItemClick(android.widget.AdapterView arg0, android.view.View arg1, int arg2, long arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.preference.PreferenceScreen)) 
				@__env.CallVoidMethod(this, _onItemClick5831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.preference.PreferenceScreen.staticClass, _onItemClick5831, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.preference.PreferenceScreen.staticClass = @__class; 
			global::android.preference.PreferenceScreen._onDismiss5827 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "onDismiss", "(Landroid/content/DialogInterface;)V"); 
			global::android.preference.PreferenceScreen._bind5828 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "bind", "(Landroid/widget/ListView;)V"); 
			global::android.preference.PreferenceScreen._getDialog5829 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "getDialog", "()Landroid/app/Dialog;"); 
			global::android.preference.PreferenceScreen._getRootAdapter5830 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "getRootAdapter", "()Landroid/widget/ListAdapter;"); 
			global::android.preference.PreferenceScreen._onItemClick5831 = @__env.GetMethodID(global::android.preference.PreferenceScreen.staticClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"); 
		} 
	} 
} 
