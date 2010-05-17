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
			internal static global::net.sf.jni4net.jni.MethodId _create363; 
			public virtual android.app.AlertDialog create() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallObjectMethodPtr(this, _create363)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _create363)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTitle364; 
			public virtual android.app.AlertDialog.Builder setTitle(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setTitle364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setTitle364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setTitle365; 
			public virtual android.app.AlertDialog.Builder setTitle(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setTitle365, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setTitle365, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setOnKeyListener366; 
			public virtual android.app.AlertDialog.Builder setOnKeyListener(android.content.DialogInterface_OnKeyListener arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setOnKeyListener366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setOnKeyListener366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIcon367; 
			public virtual android.app.AlertDialog.Builder setIcon(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setIcon367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setIcon367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setIcon368; 
			public virtual android.app.AlertDialog.Builder setIcon(android.graphics.drawable.Drawable arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setIcon368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setIcon368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _show369; 
			public virtual android.app.AlertDialog show() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallObjectMethodPtr(this, _show369)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _show369)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setCancelable370; 
			public virtual android.app.AlertDialog.Builder setCancelable(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setCancelable370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setCancelable370, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setOnCancelListener371; 
			public virtual android.app.AlertDialog.Builder setOnCancelListener(android.content.DialogInterface_OnCancelListener arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setOnCancelListener371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setOnCancelListener371, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setCustomTitle372; 
			public virtual android.app.AlertDialog.Builder setCustomTitle(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setCustomTitle372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setCustomTitle372, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMessage373; 
			public virtual android.app.AlertDialog.Builder setMessage(java.lang.CharSequence arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMessage373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMessage373, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMessage374; 
			public virtual android.app.AlertDialog.Builder setMessage(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMessage374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMessage374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPositiveButton375; 
			public virtual android.app.AlertDialog.Builder setPositiveButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setPositiveButton375, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setPositiveButton375, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPositiveButton376; 
			public virtual android.app.AlertDialog.Builder setPositiveButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setPositiveButton376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setPositiveButton376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNegativeButton377; 
			public virtual android.app.AlertDialog.Builder setNegativeButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNegativeButton377, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNegativeButton377, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNegativeButton378; 
			public virtual android.app.AlertDialog.Builder setNegativeButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNegativeButton378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNegativeButton378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNeutralButton379; 
			public virtual android.app.AlertDialog.Builder setNeutralButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNeutralButton379, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNeutralButton379, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setNeutralButton380; 
			public virtual android.app.AlertDialog.Builder setNeutralButton(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setNeutralButton380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setNeutralButton380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setItems381; 
			public virtual android.app.AlertDialog.Builder setItems(int arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setItems381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setItems381, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setItems382; 
			public virtual android.app.AlertDialog.Builder setItems(java.lang.CharSequence[] arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setItems382, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setItems382, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setAdapter383; 
			public virtual android.app.AlertDialog.Builder setAdapter(android.widget.ListAdapter arg0, android.content.DialogInterface_OnClickListener arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setAdapter383, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setAdapter383, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setCursor384; 
			public virtual android.app.AlertDialog.Builder setCursor(android.database.Cursor arg0, android.content.DialogInterface_OnClickListener arg1, java.lang.String arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setCursor384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setCursor384, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems385; 
			public virtual android.app.AlertDialog.Builder setMultiChoiceItems(android.database.Cursor arg0, java.lang.String arg1, java.lang.String arg2, android.content.DialogInterface_OnMultiChoiceClickListener arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMultiChoiceItems385, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMultiChoiceItems385, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems386; 
			public virtual android.app.AlertDialog.Builder setMultiChoiceItems(java.lang.CharSequence[] arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMultiChoiceItems386, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMultiChoiceItems386, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setMultiChoiceItems387; 
			public virtual android.app.AlertDialog.Builder setMultiChoiceItems(int arg0, bool[] arg1, android.content.DialogInterface_OnMultiChoiceClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setMultiChoiceItems387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setMultiChoiceItems387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems388; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(int arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems389; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(android.widget.ListAdapter arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems390; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(java.lang.CharSequence[] arg0, int arg1, android.content.DialogInterface_OnClickListener arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems390, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems390, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSingleChoiceItems391; 
			public virtual android.app.AlertDialog.Builder setSingleChoiceItems(android.database.Cursor arg0, int arg1, java.lang.String arg2, android.content.DialogInterface_OnClickListener arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setSingleChoiceItems391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setSingleChoiceItems391, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setOnItemSelectedListener392; 
			public virtual android.app.AlertDialog.Builder setOnItemSelectedListener(android.widget.AdapterView.OnItemSelectedListener arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setOnItemSelectedListener392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setOnItemSelectedListener392, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setView393; 
			public virtual android.app.AlertDialog.Builder setView(android.view.View arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setView393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setView393, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setInverseBackgroundForced394; 
			public virtual android.app.AlertDialog.Builder setInverseBackgroundForced(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.AlertDialog.Builder)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallObjectMethodPtr(this, _setInverseBackgroundForced394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.AlertDialog.Builder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.Builder.staticClass, _setInverseBackgroundForced394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Builder395; 
			public Builder(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.app.AlertDialog.Builder.staticClass, _Builder395, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.AlertDialog.Builder.staticClass = @__class; 
				global::android.app.AlertDialog.Builder._create363 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "create", "()Landroid/app/AlertDialog;"); 
				global::android.app.AlertDialog.Builder._setTitle364 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(I)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setTitle365 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setTitle", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setOnKeyListener366 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnKeyListener", "(Landroid/content/DialogInterface$OnKeyListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setIcon367 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(I)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setIcon368 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._show369 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "show", "()Landroid/app/AlertDialog;"); 
				global::android.app.AlertDialog.Builder._setCancelable370 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCancelable", "(Z)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setOnCancelListener371 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnCancelListener", "(Landroid/content/DialogInterface$OnCancelListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setCustomTitle372 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCustomTitle", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMessage373 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(Ljava/lang/CharSequence;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMessage374 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMessage", "(I)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setPositiveButton375 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setPositiveButton376 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setPositiveButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNegativeButton377 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNegativeButton378 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNegativeButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNeutralButton379 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setNeutralButton380 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setNeutralButton", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setItems381 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setItems", "(ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setItems382 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setItems", "([Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setAdapter383 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setCursor384 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setCursor", "(Landroid/database/Cursor;Landroid/content/DialogInterface$OnClickListener;Ljava/lang/String;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMultiChoiceItems385 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(Landroid/database/Cursor;Ljava/lang/String;Ljava/lang/String;Landroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMultiChoiceItems386 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "([Ljava/lang/CharSequence;[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setMultiChoiceItems387 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setMultiChoiceItems", "(I[ZLandroid/content/DialogInterface$OnMultiChoiceClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems388 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(IILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems389 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/widget/ListAdapter;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems390 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "([Ljava/lang/CharSequence;ILandroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setSingleChoiceItems391 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setSingleChoiceItems", "(Landroid/database/Cursor;ILjava/lang/String;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setOnItemSelectedListener392 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setOnItemSelectedListener", "(Landroid/widget/AdapterView$OnItemSelectedListener;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setView393 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setView", "(Landroid/view/View;)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._setInverseBackgroundForced394 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "setInverseBackgroundForced", "(Z)Landroid/app/AlertDialog$Builder;"); 
				global::android.app.AlertDialog.Builder._Builder395 = @__env.GetMethodID(global::android.app.AlertDialog.Builder.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate396; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _onCreate396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _onCreate396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown397; 
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return @__env.CallBooleanMethod(this, _onKeyDown397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.AlertDialog.staticClass, _onKeyDown397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp398; 
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return @__env.CallBooleanMethod(this, _onKeyUp398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.AlertDialog.staticClass, _onKeyUp398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTitle399; 
		public override void setTitle(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setTitle399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setTitle399, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIcon400; 
		public virtual void setIcon(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setIcon400, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setIcon400, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIcon401; 
		public virtual void setIcon(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setIcon401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setIcon401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCustomTitle402; 
		public virtual void setCustomTitle(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setCustomTitle402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setCustomTitle402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMessage403; 
		public virtual void setMessage(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setMessage403, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setMessage403, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setView404; 
		public virtual void setView(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setView404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setView404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setView405; 
		public virtual void setView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setView405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setView405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInverseBackgroundForced406; 
		public virtual void setInverseBackgroundForced(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setInverseBackgroundForced406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setInverseBackgroundForced406, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getButton407; 
		public virtual android.widget.Button getButton(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Button>(@__env, @__env.CallObjectMethodPtr(this, _getButton407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.Button>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.staticClass, _getButton407, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getListView408; 
		public virtual android.widget.ListView getListView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallObjectMethodPtr(this, _getListView408)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.AlertDialog.staticClass, _getListView408)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton409; 
		public virtual void setButton(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton409, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton409, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton410; 
		public virtual void setButton(java.lang.CharSequence arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton410, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton411; 
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.content.DialogInterface_OnClickListener arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton412; 
		public virtual void setButton(int arg0, java.lang.CharSequence arg1, android.os.Message arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton2413; 
		public virtual void setButton2(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton2413, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton2413, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton2414; 
		public virtual void setButton2(java.lang.CharSequence arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton2414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton2414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton3415; 
		public virtual void setButton3(java.lang.CharSequence arg0, android.content.DialogInterface_OnClickListener arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton3415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton3415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setButton3416; 
		public virtual void setButton3(java.lang.CharSequence arg0, android.os.Message arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AlertDialog)) 
				@__env.CallVoidMethod(this, _setButton3416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AlertDialog.staticClass, _setButton3416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog417; 
		protected AlertDialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AlertDialog.staticClass, _AlertDialog417, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog418; 
		protected AlertDialog(android.content.Context arg0, bool arg1, android.content.DialogInterface_OnCancelListener arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AlertDialog.staticClass, _AlertDialog418, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlertDialog419; 
		protected AlertDialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AlertDialog.staticClass, _AlertDialog419, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.AlertDialog.staticClass = @__class; 
			global::android.app.AlertDialog._onCreate396 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.AlertDialog._onKeyDown397 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.AlertDialog._onKeyUp398 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z"); 
			global::android.app.AlertDialog._setTitle399 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.AlertDialog._setIcon400 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setIcon", "(I)V"); 
			global::android.app.AlertDialog._setIcon401 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.app.AlertDialog._setCustomTitle402 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setCustomTitle", "(Landroid/view/View;)V"); 
			global::android.app.AlertDialog._setMessage403 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.AlertDialog._setView404 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;IIII)V"); 
			global::android.app.AlertDialog._setView405 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setView", "(Landroid/view/View;)V"); 
			global::android.app.AlertDialog._setInverseBackgroundForced406 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setInverseBackgroundForced", "(Z)V"); 
			global::android.app.AlertDialog._getButton407 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "getButton", "(I)Landroid/widget/Button;"); 
			global::android.app.AlertDialog._getListView408 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "getListView", "()Landroid/widget/ListView;"); 
			global::android.app.AlertDialog._setButton409 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton410 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(Ljava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._setButton411 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton412 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton", "(ILjava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._setButton2413 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton2414 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton2", "(Ljava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._setButton3415 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/content/DialogInterface$OnClickListener;)V"); 
			global::android.app.AlertDialog._setButton3416 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "setButton3", "(Ljava/lang/CharSequence;Landroid/os/Message;)V"); 
			global::android.app.AlertDialog._AlertDialog417 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
			global::android.app.AlertDialog._AlertDialog418 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;ZLandroid/content/DialogInterface$OnCancelListener;)V"); 
			global::android.app.AlertDialog._AlertDialog419 = @__env.GetMethodID(global::android.app.AlertDialog.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
