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
			internal static global::MonoJavaBridge.MethodId _create1671;
			public virtual global::android.app.AlertDialog create() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._create1671)) as android.app.AlertDialog;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._create1671)) as android.app.AlertDialog;
			}
			internal static global::MonoJavaBridge.MethodId _setTitle1672;
			public virtual global::android.app.AlertDialog.Builder setTitle(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setTitle1672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle1672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setTitle1673;
			public virtual global::android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setTitle1673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle1673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setTitle(string arg0)
			{
				return setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setOnKeyListener1674;
			public virtual global::android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnKeyListener1674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnKeyListener1674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setIcon1675;
			public virtual global::android.app.AlertDialog.Builder setIcon(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setIcon1675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon1675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setIcon1676;
			public virtual global::android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setIcon1676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon1676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _show1677;
			public virtual global::android.app.AlertDialog show() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._show1677)) as android.app.AlertDialog;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._show1677)) as android.app.AlertDialog;
			}
			internal static global::MonoJavaBridge.MethodId _setCancelable1678;
			public virtual global::android.app.AlertDialog.Builder setCancelable(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCancelable1678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCancelable1678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setOnCancelListener1679;
			public virtual global::android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnCancelListener1679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnCancelListener1679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setCustomTitle1680;
			public virtual global::android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCustomTitle1680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCustomTitle1680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMessage1681;
			public virtual global::android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMessage1681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage1681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMessage(string arg0)
			{
				return setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setMessage1682;
			public virtual global::android.app.AlertDialog.Builder setMessage(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMessage1682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage1682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setPositiveButton1683;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setPositiveButton1683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton1683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setPositiveButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setPositiveButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setPositiveButton1684;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setPositiveButton1684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton1684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setNegativeButton1685;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNegativeButton1685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton1685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNegativeButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setNegativeButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNegativeButton1686;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNegativeButton1686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton1686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setNeutralButton1687;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNeutralButton1687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton1687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNeutralButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return setNeutralButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNeutralButton1688;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNeutralButton1688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton1688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setItems1689;
			public virtual global::android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setItems1689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems1689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setItems1690;
			public virtual global::android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setItems1690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems1690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setAdapter1691;
			public virtual global::android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setAdapter1691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setAdapter1691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setCursor1692;
			public virtual global::android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCursor1692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCursor1692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems1693;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems1693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems1693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems1694;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems1694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems1694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems1695;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems1695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems1695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1696;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1697;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1698;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1699;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener1700;
			public virtual global::android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnItemSelectedListener1700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnItemSelectedListener1700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setView1701;
			public virtual global::android.app.AlertDialog.Builder setView(android.view.View arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setView1701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setView1701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setInverseBackgroundForced1702;
			public virtual global::android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setInverseBackgroundForced1702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setInverseBackgroundForced1702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _Builder1703;
			public Builder(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._Builder1703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.AlertDialog.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog$Builder"));
				global::android.app.AlertDialog.Builder._create1671 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setTitle1672 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setTitle1673 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnKeyListener1674 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon1675 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon1676 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._show1677 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setCancelable1678 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnCancelListener1679 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCustomTitle1680 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage1681 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage1682 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton1683 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton1684 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton1685 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton1686 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton1687 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton1688 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems1689 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems1690 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setAdapter1691 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCursor1692 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems1693 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems1694 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems1695 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1696 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1697 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1698 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1699 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnItemSelectedListener1700 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setView1701 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setInverseBackgroundForced1702 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._Builder1703 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1704;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._onCreate1704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onCreate1704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown1705;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.AlertDialog._onKeyDown1705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyDown1705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp1706;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.AlertDialog._onKeyUp1706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyUp1706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1707;
		public override void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setTitle1707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setTitle1707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setIcon1708;
		public virtual void setIcon(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setIcon1708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon1708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIcon1709;
		public virtual void setIcon(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setIcon1709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon1709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCustomTitle1710;
		public virtual void setCustomTitle(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setCustomTitle1710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setCustomTitle1710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMessage1711;
		public virtual void setMessage(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setMessage1711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setMessage1711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setView1712;
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setView1712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView1712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _setView1713;
		public virtual void setView(android.view.View arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setView1713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView1713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInverseBackgroundForced1714;
		public virtual void setInverseBackgroundForced(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setInverseBackgroundForced1714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setInverseBackgroundForced1714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getButton1715;
		public virtual global::android.widget.Button getButton(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog._getButton1715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Button;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getButton1715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Button;
		}
		public new global::android.widget.ListView ListView
		{
			get
			{
				return getListView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getListView1716;
		public virtual global::android.widget.ListView getListView() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog._getListView1716)) as android.widget.ListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getListView1716)) as android.widget.ListView;
		}
		internal static global::MonoJavaBridge.MethodId _setButton1717;
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton1718;
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, android.os.Message arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton1719;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, android.content.DialogInterface_OnClickListener arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setButton1720;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, android.os.Message arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setButton21721;
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton21721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton21721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton21722;
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton21722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton21722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, android.os.Message arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton31723;
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton31723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton31723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton31724;
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton31724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton31724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, android.os.Message arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog1725;
		protected AlertDialog(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog1725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog1726;
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog1726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog1727;
		protected AlertDialog(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog1727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AlertDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog"));
			global::android.app.AlertDialog._onCreate1704 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.AlertDialog._onKeyDown1705 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._onKeyUp1706 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._setTitle1707 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setIcon1708 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setIcon", "(I)V");
			global::android.app.AlertDialog._setIcon1709 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.AlertDialog._setCustomTitle1710 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setMessage1711 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setView1712 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V");
			global::android.app.AlertDialog._setView1713 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setInverseBackgroundForced1714 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V");
			global::android.app.AlertDialog._getButton1715 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;");
			global::android.app.AlertDialog._getListView1716 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.AlertDialog._setButton1717 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton1718 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton1719 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton1720 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton21721 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton21722 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton31723 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton31724 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._AlertDialog1725 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.AlertDialog._AlertDialog1726 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.AlertDialog._AlertDialog1727 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
