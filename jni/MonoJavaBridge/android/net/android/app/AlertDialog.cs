namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AlertDialog : android.app.Dialog, android.content.DialogInterface
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AlertDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.AlertDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.AlertDialog.Builder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _create370; 
			public virtual android.app.AlertDialog create() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallObjectMethodPtr(this, _create370)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _create370)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTitle371; 
			public virtual android.app.AlertDialog.Builder setTitle(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setTitle371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setTitle371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTitle372; 
			public virtual android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setTitle372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setTitle372, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener373; 
			public virtual android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setOnKeyListener373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setOnKeyListener373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIcon374; 
			public virtual android.app.AlertDialog.Builder setIcon(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setIcon374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setIcon374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIcon375; 
			public virtual android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setIcon375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setIcon375, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _show376; 
			public virtual android.app.AlertDialog show() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallObjectMethodPtr(this, _show376)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _show376)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setCancelable377; 
			public virtual android.app.AlertDialog.Builder setCancelable(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setCancelable377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setCancelable377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener378; 
			public virtual android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setOnCancelListener378, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setOnCancelListener378, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setCustomTitle379; 
			public virtual android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setCustomTitle379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setCustomTitle379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMessage380; 
			public virtual android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMessage380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMessage380, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMessage381; 
			public virtual android.app.AlertDialog.Builder setMessage(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMessage381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMessage381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPositiveButton382; 
			public virtual android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setPositiveButton382, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setPositiveButton382, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPositiveButton383; 
			public virtual android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setPositiveButton383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setPositiveButton383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNegativeButton384; 
			public virtual android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNegativeButton384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNegativeButton384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNegativeButton385; 
			public virtual android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNegativeButton385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNegativeButton385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNeutralButton386; 
			public virtual android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNeutralButton386, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNeutralButton386, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNeutralButton387; 
			public virtual android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNeutralButton387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNeutralButton387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setItems388; 
			public virtual android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setItems388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setItems388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setItems389; 
			public virtual android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setItems389, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setItems389, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setAdapter390; 
			public virtual android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setAdapter390, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setAdapter390, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setCursor391; 
			public virtual android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setCursor391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setCursor391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems392; 
			public virtual android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMultiChoiceItems392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMultiChoiceItems392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems393; 
			public virtual android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMultiChoiceItems393, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMultiChoiceItems393, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems394; 
			public virtual android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMultiChoiceItems394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMultiChoiceItems394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems395; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems396; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems396, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems396, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems397; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems397, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems397, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems398; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems398, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems398, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener399; 
			public virtual android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setOnItemSelectedListener399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setOnItemSelectedListener399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setView400; 
			public virtual android.app.AlertDialog.Builder setView(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setView400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setView400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setInverseBackgroundForced401; 
			public virtual android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setInverseBackgroundForced401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setInverseBackgroundForced401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Builder402; 
			public Builder(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.AlertDialog.Builder.staticClass, _Builder402, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.AlertDialog.Builder.staticClass = @__class; 
				global::android.app.AlertDialog.Builder._create370 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;"); 
				global::android.app.AlertDialog.Builder._setTitle371 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setTitle372 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setOnKeyListener373 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setIcon374 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setIcon375 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._show376 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;"); 
				global::android.app.AlertDialog.Builder._setCancelable377 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setOnCancelListener378 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setCustomTitle379 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMessage380 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMessage381 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setPositiveButton382 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setPositiveButton383 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNegativeButton384 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNegativeButton385 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNeutralButton386 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNeutralButton387 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setItems388 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setItems389 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setAdapter390 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setCursor391 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMultiChoiceItems392 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMultiChoiceItems393 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMultiChoiceItems394 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems395 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems396 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems397 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems398 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setOnItemSelectedListener399 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setView400 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setInverseBackgroundForced401 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._Builder402 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate403; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _onCreate403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _onCreate403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown404; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return @__env.CallBooleanMethod(this, _onKeyDown404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.AlertDialog.staticClass, _onKeyDown404, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp405; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return @__env.CallBooleanMethod(this, _onKeyUp405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.AlertDialog.staticClass, _onKeyUp405, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle406; 
		public override void setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setTitle406, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setTitle406, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIcon407; 
		public virtual void setIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setIcon407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setIcon407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIcon408; 
		public virtual void setIcon(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setIcon408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setIcon408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCustomTitle409; 
		public virtual void setCustomTitle(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setCustomTitle409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setCustomTitle409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMessage410; 
		public virtual void setMessage(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setMessage410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setMessage410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setView411; 
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setView411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setView411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setView412; 
		public virtual void setView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setView412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setView412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInverseBackgroundForced413; 
		public virtual void setInverseBackgroundForced(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setInverseBackgroundForced413, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setInverseBackgroundForced413, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getButton414; 
		public virtual android.widget.Button getButton(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Button>(@__env, @__env.CallObjectMethodPtr(this, _getButton414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Button>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.staticClass, _getButton414, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListView415; 
		public virtual android.widget.ListView getListView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallObjectMethodPtr(this, _getListView415)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.staticClass, _getListView415)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton416; 
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton417; 
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton417, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton417, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton418; 
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton418, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton419; 
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton419, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton2420; 
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton2420, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton2420, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton2421; 
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton2421, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton2421, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton3422; 
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton3422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton3422, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton3423; 
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton3423, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton3423, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog424; 
		protected AlertDialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AlertDialog.staticClass, _AlertDialog424, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog425; 
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AlertDialog.staticClass, _AlertDialog425, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog426; 
		protected AlertDialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AlertDialog.staticClass, _AlertDialog426, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.AlertDialog.staticClass = @__class; 
			global::android.app.AlertDialog._onCreate403 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.AlertDialog._onKeyDown404 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.AlertDialog._onKeyUp405 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.AlertDialog._setTitle406 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.AlertDialog._setIcon407 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setIcon", "(I)V"); 
			global::android.app.AlertDialog._setIcon408 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.app.AlertDialog._setCustomTitle409 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V"); 
			global::android.app.AlertDialog._setMessage410 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.AlertDialog._setView411 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V"); 
			global::android.app.AlertDialog._setView412 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V"); 
			global::android.app.AlertDialog._setInverseBackgroundForced413 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V"); 
			global::android.app.AlertDialog._getButton414 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;"); 
			global::android.app.AlertDialog._getListView415 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;"); 
			global::android.app.AlertDialog._setButton416 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton417 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._setButton418 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton419 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._setButton2420 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton2421 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._setButton3422 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton3423 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._AlertDialog424 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.app.AlertDialog._AlertDialog425 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V"); 
			global::android.app.AlertDialog._AlertDialog426 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
