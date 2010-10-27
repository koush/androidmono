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
			internal static global::MonoJavaBridge.MethodId _create1673;
			public virtual global::android.app.AlertDialog create()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._create1673)) as android.app.AlertDialog;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._create1673)) as android.app.AlertDialog;
			}
			internal static global::MonoJavaBridge.MethodId _setTitle1674;
			public virtual global::android.app.AlertDialog.Builder setTitle(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setTitle1674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle1674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setTitle1675;
			public virtual global::android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setTitle1675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setTitle1675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setTitle(string arg0)
			{
				return setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			public new global::android.content.DialogInterface_OnKeyListener OnKeyListener
			{
				set
				{
					setOnKeyListener(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setOnKeyListener1676;
			public virtual global::android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnKeyListener1676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnKeyListener1676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setOnKeyListener(global::android.content.DialogInterface_OnKeyListenerDelegate arg0)
			{
				return setOnKeyListener((global::android.content.DialogInterface_OnKeyListenerDelegateWrapper)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setIcon1677;
			public virtual global::android.app.AlertDialog.Builder setIcon(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setIcon1677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon1677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setIcon1678;
			public virtual global::android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setIcon1678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setIcon1678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _show1679;
			public virtual global::android.app.AlertDialog show()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._show1679)) as android.app.AlertDialog;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._show1679)) as android.app.AlertDialog;
			}
			public new bool Cancelable
			{
				set
				{
					setCancelable(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setCancelable1680;
			public virtual global::android.app.AlertDialog.Builder setCancelable(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCancelable1680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCancelable1680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public new global::android.content.DialogInterface_OnCancelListener OnCancelListener
			{
				set
				{
					setOnCancelListener(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setOnCancelListener1681;
			public virtual global::android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnCancelListener1681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnCancelListener1681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setOnCancelListener(global::android.content.DialogInterface_OnCancelListenerDelegate arg0)
			{
				return setOnCancelListener((global::android.content.DialogInterface_OnCancelListenerDelegateWrapper)arg0);
			}
			public new global::android.view.View CustomTitle
			{
				set
				{
					setCustomTitle(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setCustomTitle1682;
			public virtual global::android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCustomTitle1682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCustomTitle1682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setMessage1683;
			public virtual global::android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMessage1683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage1683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMessage(string arg0)
			{
				return setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			internal static global::MonoJavaBridge.MethodId _setMessage1684;
			public virtual global::android.app.AlertDialog.Builder setMessage(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMessage1684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMessage1684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _setPositiveButton1685;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setPositiveButton1685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton1685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setPositiveButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setPositiveButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setPositiveButton1686;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setPositiveButton1686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setPositiveButton1686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setPositiveButton(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setPositiveButton(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNegativeButton1687;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNegativeButton1687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton1687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNegativeButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNegativeButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNegativeButton1688;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNegativeButton1688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNegativeButton1688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNegativeButton(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNegativeButton(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNeutralButton1689;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNeutralButton1689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton1689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNeutralButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNeutralButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setNeutralButton1690;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setNeutralButton1690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setNeutralButton1690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNeutralButton(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNeutralButton(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setItems1691;
			public virtual global::android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setItems1691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems1691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setItems(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setItems(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setItems1692;
			public virtual global::android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setItems1692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setItems1692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setItems(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setAdapter1693;
			public virtual global::android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setAdapter1693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setAdapter1693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setAdapter(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			internal static global::MonoJavaBridge.MethodId _setCursor1694;
			public virtual global::android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setCursor1694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setCursor1694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1, java.lang.String arg2)
			{
				return setCursor(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1, arg2);
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems1695;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems1695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems1695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegate arg3)
			{
				return setMultiChoiceItems(arg0, arg1, arg2, (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper)arg3);
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems1696;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems1696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems1696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegate arg2)
			{
				return setMultiChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _setMultiChoiceItems1697;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setMultiChoiceItems1697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setMultiChoiceItems1697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegate arg2)
			{
				return setMultiChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1698;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
			{
				return setSingleChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1699;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
			{
				return setSingleChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1700;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
			{
				return setSingleChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
			}
			internal static global::MonoJavaBridge.MethodId _setSingleChoiceItems1701;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setSingleChoiceItems1701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setSingleChoiceItems1701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, global::android.content.DialogInterface_OnClickListenerDelegate arg3)
			{
				return setSingleChoiceItems(arg0, arg1, arg2, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg3);
			}
			public new global::android.widget.AdapterView.OnItemSelectedListener OnItemSelectedListener
			{
				set
				{
					setOnItemSelectedListener(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setOnItemSelectedListener1702;
			public virtual global::android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setOnItemSelectedListener1702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setOnItemSelectedListener1702, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public new global::android.view.View View
			{
				set
				{
					setView(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setView1703;
			public virtual global::android.app.AlertDialog.Builder setView(android.view.View arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setView1703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setView1703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			public new bool InverseBackgroundForced
			{
				set
				{
					setInverseBackgroundForced(value);
				}
			}
			internal static global::MonoJavaBridge.MethodId _setInverseBackgroundForced1704;
			public virtual global::android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder._setInverseBackgroundForced1704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._setInverseBackgroundForced1704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.app.AlertDialog.Builder;
			}
			internal static global::MonoJavaBridge.MethodId _Builder1705;
			public Builder(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._Builder1705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.AlertDialog.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog$Builder"));
				global::android.app.AlertDialog.Builder._create1673 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setTitle1674 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setTitle1675 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnKeyListener1676 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon1677 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setIcon1678 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._show1679 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;");
				global::android.app.AlertDialog.Builder._setCancelable1680 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnCancelListener1681 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCustomTitle1682 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage1683 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMessage1684 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton1685 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setPositiveButton1686 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton1687 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNegativeButton1688 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton1689 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setNeutralButton1690 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems1691 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setItems1692 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setAdapter1693 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setCursor1694 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems1695 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems1696 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setMultiChoiceItems1697 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1698 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1699 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1700 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setSingleChoiceItems1701 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setOnItemSelectedListener1702 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setView1703 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._setInverseBackgroundForced1704 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;");
				global::android.app.AlertDialog.Builder._Builder1705 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onCreate1706;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._onCreate1706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onCreate1706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown1707;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.AlertDialog._onKeyDown1707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyDown1707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp1708;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.AlertDialog._onKeyUp1708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._onKeyUp1708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.CharSequence Title
		{
			set
			{
				setTitle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTitle1709;
		public override void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setTitle1709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setTitle1709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setIcon1710;
		public virtual void setIcon(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setIcon1710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon1710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIcon1711;
		public virtual void setIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setIcon1711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setIcon1711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View CustomTitle
		{
			set
			{
				setCustomTitle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCustomTitle1712;
		public virtual void setCustomTitle(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setCustomTitle1712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setCustomTitle1712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.CharSequence Message
		{
			set
			{
				setMessage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMessage1713;
		public virtual void setMessage(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setMessage1713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setMessage1713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setView1714;
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setView1714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView1714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new global::android.view.View View
		{
			set
			{
				setView(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setView1715;
		public virtual void setView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setView1715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setView1715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InverseBackgroundForced
		{
			set
			{
				setInverseBackgroundForced(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setInverseBackgroundForced1716;
		public virtual void setInverseBackgroundForced(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setInverseBackgroundForced1716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setInverseBackgroundForced1716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getButton1717;
		public virtual global::android.widget.Button getButton(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog._getButton1717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Button;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getButton1717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.Button;
		}
		public new global::android.widget.ListView ListView
		{
			get
			{
				return getListView();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getListView1718;
		public virtual global::android.widget.ListView getListView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.AlertDialog._getListView1718)) as android.widget.ListView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._getListView1718)) as android.widget.ListView;
		}
		internal static global::MonoJavaBridge.MethodId _setButton1719;
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton1720;
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, android.os.Message arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton1721;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setButton1722;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton1722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton1722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, android.os.Message arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _setButton21723;
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton21723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton21723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton21724;
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton21724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton21724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, android.os.Message arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton31725;
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton31725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton31725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _setButton31726;
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.AlertDialog._setButton31726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.AlertDialog.staticClass, global::android.app.AlertDialog._setButton31726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, android.os.Message arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog1727;
		protected AlertDialog(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog1727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog1728;
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog1728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlertDialog1729;
		protected AlertDialog(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._AlertDialog1729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AlertDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog"));
			global::android.app.AlertDialog._onCreate1706 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.AlertDialog._onKeyDown1707 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._onKeyUp1708 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.app.AlertDialog._setTitle1709 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setIcon1710 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setIcon", "(I)V");
			global::android.app.AlertDialog._setIcon1711 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.AlertDialog._setCustomTitle1712 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setMessage1713 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.AlertDialog._setView1714 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V");
			global::android.app.AlertDialog._setView1715 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V");
			global::android.app.AlertDialog._setInverseBackgroundForced1716 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V");
			global::android.app.AlertDialog._getButton1717 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;");
			global::android.app.AlertDialog._getListView1718 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;");
			global::android.app.AlertDialog._setButton1719 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton1720 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton1721 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton1722 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton21723 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton21724 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._setButton31725 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V");
			global::android.app.AlertDialog._setButton31726 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V");
			global::android.app.AlertDialog._AlertDialog1727 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::android.app.AlertDialog._AlertDialog1728 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::android.app.AlertDialog._AlertDialog1729 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
