namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlertDialog : android.app.Dialog, android.content.DialogInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlertDialog()
		{
			InitJNI();
		}
		protected AlertDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Builder()
			{
				InitJNI();
			}
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _create387;
			public virtual global::android.app.AlertDialog create() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._create387)) as android.app.AlertDialog;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._create387)) as android.app.AlertDialog;
			}
			internal static global::MonoJavaBridge.MethodId _setTitle388;
			public virtual global::android.app.AlertDialog.Builder setTitle(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setTitle388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setTitle389;
			public virtual global::android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setTitle389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setTitle(string arg0)
			{
				return setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setOnKeyListener390;
			public virtual global::android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnKeyListener390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnKeyListener390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setIcon391;
			public virtual global::android.app.AlertDialog.Builder setIcon(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setIcon391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setIcon392;
			public virtual global::android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setIcon392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _show393;
			public virtual global::android.app.AlertDialog show() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._show393)) as android.app.AlertDialog;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._show393)) as android.app.AlertDialog;
			}
			internal static global::MonoJavaBridge.MethodId _setCancelable394;
			public virtual global::android.app.AlertDialog.Builder setCancelable(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCancelable394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCancelable394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setOnCancelListener395;
			public virtual global::android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnCancelListener395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnCancelListener395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setCustomTitle396;
			public virtual global::android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCustomTitle396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCustomTitle396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMessage397;
			public virtual global::android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMessage397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMessage(string arg0)
			{
				return setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setMessage398;
			public virtual global::android.app.AlertDialog.Builder setMessage(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMessage398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setPositiveButton399;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setPositiveButton399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setPositiveButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setPositiveButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setPositiveButton400;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setPositiveButton400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setNegativeButton401;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNegativeButton401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNegativeButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setNegativeButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNegativeButton402;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNegativeButton402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setNeutralButton403;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNeutralButton403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNeutralButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setNeutralButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNeutralButton404;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNeutralButton404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setItems405;
			public virtual global::android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setItems405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setItems406;
			public virtual global::android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setItems406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setAdapter407;
			public virtual global::android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setAdapter407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setAdapter407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setCursor408;
			public virtual global::android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCursor408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCursor408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems409;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems410;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems411;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems412;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems413;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems414;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems415;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener416;
			public virtual global::android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnItemSelectedListener416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnItemSelectedListener416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setView417;
			public virtual global::android.app.AlertDialog.Builder setView(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setView417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setView417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setInverseBackgroundForced418;
			public virtual global::android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setInverseBackgroundForced418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setInverseBackgroundForced418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _Builder419;
			public Builder(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._Builder419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.AlertDialog.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog$Builder"));
				global::android.app.AlertDialog.Builder._create387 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setTitle388 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setTitle389 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnKeyListener390 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon391 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon392 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._show393 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setCancelable394 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnCancelListener395 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCustomTitle396 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage397 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage398 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton399 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton400 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton401 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton402 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton403 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton404 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems405 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems406 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setAdapter407 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCursor408 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems409 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems410 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems411 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems412 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems413 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems414 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems415 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnItemSelectedListener416 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setView417 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setInverseBackgroundForced418 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._Builder419 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onCreate420;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._onCreate420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onCreate420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown421;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.AlertDialog._onKeyDown421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyDown421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp422;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.AlertDialog._onKeyUp422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyUp422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle423;
		public override void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setTitle423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setTitle423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setIcon424;
		public virtual void setIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setIcon424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIcon425;
		public virtual void setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setIcon425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCustomTitle426;
		public virtual void setCustomTitle(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setCustomTitle426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setCustomTitle426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMessage427;
		public virtual void setMessage(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setMessage427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setMessage427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setView428;
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setView428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setView429;
		public virtual void setView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setView429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInverseBackgroundForced430;
		public virtual void setInverseBackgroundForced(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setInverseBackgroundForced430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setInverseBackgroundForced430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getButton431;
		public virtual global::android.widget.Button getButton(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog._getButton431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Button;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getButton431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Button;
		}
		internal static global::MonoJavaBridge.MethodId _getListView432;
		public virtual global::android.widget.ListView getListView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog._getListView432)) as android.widget.ListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getListView432)) as android.widget.ListView;
		}
		internal static global::MonoJavaBridge.MethodId _setButton433;
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton434;
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, android.os.Message arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton435;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, android.content.DialogInterface_OnClickListener arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setButton436;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, android.os.Message arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setButton2437;
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton2437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton2437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton2438;
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton2438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton2438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, android.os.Message arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton3439;
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton3439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton3439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton3440;
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton3440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton3440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, android.os.Message arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog441;
		protected AlertDialog(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog442;
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog443;
		protected AlertDialog(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AlertDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog"));
			global::android.app.AlertDialog._onCreate420 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.AlertDialog._onKeyDown421 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._onKeyUp422 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._setTitle423 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setIcon424 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setIcon", "(I)V");
			global::android.app.AlertDialog._setIcon425 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.AlertDialog._setCustomTitle426 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setMessage427 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setView428 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V");
			global::android.app.AlertDialog._setView429 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setInverseBackgroundForced430 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V");
			global::android.app.AlertDialog._getButton431 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;");
			global::android.app.AlertDialog._getListView432 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.AlertDialog._setButton433 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton434 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton435 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton436 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton2437 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton2438 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton3439 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton3440 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._AlertDialog441 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.AlertDialog._AlertDialog442 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.AlertDialog._AlertDialog443 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
