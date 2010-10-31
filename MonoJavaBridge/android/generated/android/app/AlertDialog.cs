namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlertDialog : android.app.Dialog, android.content.DialogInterface
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlertDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Builder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Builder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::android.app.AlertDialog create()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;", ref global::android.app.AlertDialog.Builder._m0) as android.app.AlertDialog;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::android.app.AlertDialog.Builder setTitle(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
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
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setOnKeyListener(global::android.content.DialogInterface_OnKeyListenerDelegate arg0)
			{
				return setOnKeyListener((global::android.content.DialogInterface_OnKeyListenerDelegateWrapper)arg0);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual global::android.app.AlertDialog.Builder setIcon(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::android.app.AlertDialog show()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;", ref global::android.app.AlertDialog.Builder._m6) as android.app.AlertDialog;
			}
			public new bool Cancelable
			{
				set
				{
					setCancelable(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual global::android.app.AlertDialog.Builder setCancelable(bool arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			public new global::android.content.DialogInterface_OnCancelListener OnCancelListener
			{
				set
				{
					setOnCancelListener(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual global::android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
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
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual global::android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public virtual global::android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMessage(string arg0)
			{
				return setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public virtual global::android.app.AlertDialog.Builder setMessage(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setPositiveButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setPositiveButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public virtual global::android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setPositiveButton(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setPositiveButton(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNegativeButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNegativeButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public virtual global::android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNegativeButton(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNegativeButton(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m16;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNeutralButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNeutralButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m17;
			public virtual global::android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setNeutralButton(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setNeutralButton(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m18;
			public virtual global::android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setItems(int arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setItems(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m19;
			public virtual global::android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setItems(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m20;
			public virtual global::android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
			{
				return setAdapter(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
			}
			private static global::MonoJavaBridge.MethodId _m21;
			public virtual global::android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1, java.lang.String arg2)
			{
				return setCursor(arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1, arg2);
			}
			private static global::MonoJavaBridge.MethodId _m22;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegate arg3)
			{
				return setMultiChoiceItems(arg0, arg1, arg2, (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper)arg3);
			}
			private static global::MonoJavaBridge.MethodId _m23;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegate arg2)
			{
				return setMultiChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m24;
			public virtual global::android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegate arg2)
			{
				return setMultiChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnMultiChoiceClickListenerDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m25;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
			{
				return setSingleChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m26;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
			{
				return setSingleChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m27;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.app.AlertDialog.Builder;
			}
			public android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
			{
				return setSingleChoiceItems(arg0, arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
			}
			private static global::MonoJavaBridge.MethodId _m28;
			public virtual global::android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.app.AlertDialog.Builder;
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
			private static global::MonoJavaBridge.MethodId _m29;
			public virtual global::android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			public new global::android.view.View View
			{
				set
				{
					setView(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m30;
			public virtual global::android.app.AlertDialog.Builder setView(android.view.View arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			public new bool InverseBackgroundForced
			{
				set
				{
					setInverseBackgroundForced(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m31;
			public virtual global::android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;", ref global::android.app.AlertDialog.Builder._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.app.AlertDialog.Builder;
			}
			private static global::MonoJavaBridge.MethodId _m32;
			public Builder(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.app.AlertDialog.Builder._m32.native == global::System.IntPtr.Zero)
					global::android.app.AlertDialog.Builder._m32 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.Builder.staticClass, global::android.app.AlertDialog.Builder._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static Builder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.app.AlertDialog.Builder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog$Builder"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.AlertDialog._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.AlertDialog._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.app.AlertDialog._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.CharSequence Title
		{
			set
			{
				setTitle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V", ref global::android.app.AlertDialog._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setIcon(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setIcon", "(I)V", ref global::android.app.AlertDialog._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setIcon(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.app.AlertDialog._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.View CustomTitle
		{
			set
			{
				setCustomTitle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setCustomTitle(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V", ref global::android.app.AlertDialog._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.CharSequence Message
		{
			set
			{
				setMessage(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setMessage(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V", ref global::android.app.AlertDialog._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V", ref global::android.app.AlertDialog._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new global::android.view.View View
		{
			set
			{
				setView(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V", ref global::android.app.AlertDialog._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool InverseBackgroundForced
		{
			set
			{
				setInverseBackgroundForced(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setInverseBackgroundForced(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V", ref global::android.app.AlertDialog._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::android.widget.Button getButton(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;", ref global::android.app.AlertDialog._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.Button;
		}
		public new global::android.widget.ListView ListView
		{
			get
			{
				return getListView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.widget.ListView getListView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;", ref global::android.app.AlertDialog._m12) as android.widget.ListView;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", ref global::android.app.AlertDialog._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V", ref global::android.app.AlertDialog._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton(string arg0, android.os.Message arg1)
		{
			setButton((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", ref global::android.app.AlertDialog._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, global::android.content.DialogInterface_OnClickListenerDelegate arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V", ref global::android.app.AlertDialog._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void setButton(int arg0, string arg1, android.os.Message arg2)
		{
			setButton(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", ref global::android.app.AlertDialog._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V", ref global::android.app.AlertDialog._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton2(string arg0, android.os.Message arg1)
		{
			setButton2((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V", ref global::android.app.AlertDialog._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, global::android.content.DialogInterface_OnClickListenerDelegate arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, (global::android.content.DialogInterface_OnClickListenerDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V", ref global::android.app.AlertDialog._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void setButton3(string arg0, android.os.Message arg1)
		{
			setButton3((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		protected AlertDialog(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.AlertDialog._m21.native == global::System.IntPtr.Zero)
				global::android.app.AlertDialog._m21 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.AlertDialog._m22.native == global::System.IntPtr.Zero)
				global::android.app.AlertDialog._m22 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected AlertDialog(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.AlertDialog._m23.native == global::System.IntPtr.Zero)
				global::android.app.AlertDialog._m23 = @__env.GetMethodIDNoThrow(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.AlertDialog.staticClass, global::android.app.AlertDialog._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AlertDialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.AlertDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/AlertDialog"));
		}
	}
}
