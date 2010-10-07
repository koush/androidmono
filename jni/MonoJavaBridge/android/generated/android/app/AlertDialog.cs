namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AlertDialog : android.app.Dialog, android.content.DialogInterface
	{
		internal new static global::java.lang.Class staticClass;
		static AlertDialog()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.AlertDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.AlertDialog(@__env);
			}
		}
		protected AlertDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Builder : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Builder()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.AlertDialog.Builder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.app.AlertDialog.Builder(@__env);
				}
			}
			protected Builder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _create378;
			public virtual global::android.app.AlertDialog create() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._create378));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._create378));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setTitle379;
			public virtual global::android.app.AlertDialog.Builder setTitle(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setTitle379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setTitle380;
			public virtual global::android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setTitle380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			public android.app.AlertDialog.Builder setTitle(string arg0)
			{
				return setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener381;
			public virtual global::android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setOnKeyListener381, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnKeyListener381, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setIcon382;
			public virtual global::android.app.AlertDialog.Builder setIcon(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setIcon382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setIcon383;
			public virtual global::android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setIcon383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon383, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _show384;
			public virtual global::android.app.AlertDialog show() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._show384));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._show384));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setCancelable385;
			public virtual global::android.app.AlertDialog.Builder setCancelable(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setCancelable385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCancelable385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener386;
			public virtual global::android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setOnCancelListener386, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnCancelListener386, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setCustomTitle387;
			public virtual global::android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setCustomTitle387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCustomTitle387, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setMessage388;
			public virtual global::android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setMessage388, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage388, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			public android.app.AlertDialog.Builder setMessage(string arg0)
			{
				return setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setMessage389;
			public virtual global::android.app.AlertDialog.Builder setMessage(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setMessage389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage389, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPositiveButton390;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setPositiveButton390, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton390, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			public android.app.AlertDialog.Builder setPositiveButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setPositiveButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPositiveButton391;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setPositiveButton391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setNegativeButton392;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setNegativeButton392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			public android.app.AlertDialog.Builder setNegativeButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setNegativeButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setNegativeButton393;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setNegativeButton393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setNeutralButton394;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setNeutralButton394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton394, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			public android.app.AlertDialog.Builder setNeutralButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setNeutralButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setNeutralButton395;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setNeutralButton395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setItems396;
			public virtual global::android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setItems396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setItems397;
			public virtual global::android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setItems397, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems397, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setAdapter398;
			public virtual global::android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setAdapter398, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setAdapter398, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setCursor399;
			public virtual global::android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setCursor399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCursor399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems400;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setMultiChoiceItems400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems400, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems401;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setMultiChoiceItems401, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems401, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems402;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setMultiChoiceItems402, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems402, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems403;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setSingleChoiceItems403, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems403, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems404;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setSingleChoiceItems404, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems404, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems405;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setSingleChoiceItems405, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems405, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems406;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setSingleChoiceItems406, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems406, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener407;
			public virtual global::android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setOnItemSelectedListener407, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnItemSelectedListener407, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setView408;
			public virtual global::android.app.AlertDialog.Builder setView(android.view.View arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setView408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setView408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setInverseBackgroundForced409;
			public virtual global::android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog.Builder._setInverseBackgroundForced409, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setInverseBackgroundForced409, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Builder410;
			public Builder(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._Builder410, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.app.AlertDialog.Builder.staticClass = @__class;
				global::android.app.AlertDialog.Builder._create378 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setTitle379 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setTitle380 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnKeyListener381 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon382 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon383 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._show384 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setCancelable385 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnCancelListener386 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCustomTitle387 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage388 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage389 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton390 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton391 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton392 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton393 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton394 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton395 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems396 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems397 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setAdapter398 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCursor399 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems400 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems401 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems402 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems403 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems404 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems405 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems406 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnItemSelectedListener407 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setView408 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setInverseBackgroundForced409 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._Builder410 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate411;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._onCreate411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onCreate411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown412;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.AlertDialog._onKeyDown412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyDown412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp413;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.AlertDialog._onKeyUp413, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyUp413, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle414;
		public override void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setTitle414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setTitle414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon415;
		public virtual void setIcon(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setIcon415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIcon416;
		public virtual void setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setIcon416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCustomTitle417;
		public virtual void setCustomTitle(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setCustomTitle417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setCustomTitle417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMessage418;
		public virtual void setMessage(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setMessage418, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setMessage418, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setView419;
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setView419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setView420;
		public virtual void setView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setView420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setInverseBackgroundForced421;
		public virtual void setInverseBackgroundForced(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setInverseBackgroundForced421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setInverseBackgroundForced421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getButton422;
		public virtual global::android.widget.Button getButton(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Button>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog._getButton422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Button>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getButton422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getListView423;
		public virtual global::android.widget.ListView getListView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.AlertDialog._getListView423));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getListView423));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton424;
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton424, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton424, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		public void setButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton425;
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton425, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton425, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setButton(string arg0, android.os.Message arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton426;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton426, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton426, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		public void setButton(int arg0, string arg1, android.content.DialogInterface_OnClickListener arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton427;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton427, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton427, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		public void setButton(int arg0, string arg1, android.os.Message arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton2428;
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton2428, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton2428, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		public void setButton2(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton2429;
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton2429, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton2429, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setButton2(string arg0, android.os.Message arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton3430;
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton3430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton3430, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		public void setButton3(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setButton3431;
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.AlertDialog._setButton3431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton3431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		public void setButton3(string arg0, android.os.Message arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog432;
		protected AlertDialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog432, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog433;
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog433, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog434;
		protected AlertDialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog434, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.AlertDialog.staticClass = @__class;
			global::android.app.AlertDialog._onCreate411 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.AlertDialog._onKeyDown412 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._onKeyUp413 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._setTitle414 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setIcon415 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setIcon", "(I)V");
			global::android.app.AlertDialog._setIcon416 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.AlertDialog._setCustomTitle417 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setMessage418 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setView419 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V");
			global::android.app.AlertDialog._setView420 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setInverseBackgroundForced421 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V");
			global::android.app.AlertDialog._getButton422 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;");
			global::android.app.AlertDialog._getListView423 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.AlertDialog._setButton424 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton425 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton426 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton427 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton2428 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton2429 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton3430 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton3431 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._AlertDialog432 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.AlertDialog._AlertDialog433 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.AlertDialog._AlertDialog434 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
