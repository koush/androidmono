namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ProgressDialog : android.app.AlertDialog
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ProgressDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ProgressDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.ProgressDialog(@__env); 
			} 
		} 
		protected ProgressDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate710; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._onCreate710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onCreate710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart711; 
		public virtual new void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._onStart711); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStart711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop712; 
		protected override void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._onStop712); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStop712); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgress713; 
		public virtual void setProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setProgress713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgress713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress714; 
		public virtual void setSecondaryProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setSecondaryProgress714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setSecondaryProgress714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show715; 
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show716; 
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show717; 
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show718; 
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMessage719; 
		public override void setMessage(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setMessage719, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMessage719, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress720; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.app.ProgressDialog._getProgress720); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getProgress720); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryProgress721; 
		public virtual int getSecondaryProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.app.ProgressDialog._getSecondaryProgress721); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getSecondaryProgress721); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMax722; 
		public virtual int getMax() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.app.ProgressDialog._getMax722); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getMax722); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax723; 
		public virtual void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setMax723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMax723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementProgressBy724; 
		public virtual void incrementProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._incrementProgressBy724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementProgressBy724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementSecondaryProgressBy725; 
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._incrementSecondaryProgressBy725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementSecondaryProgressBy725, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressDrawable726; 
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setProgressDrawable726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressDrawable726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminateDrawable727; 
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setIndeterminateDrawable727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminateDrawable727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminate728; 
		public virtual void setIndeterminate(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setIndeterminate728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminate728, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIndeterminate729; 
		public virtual bool isIndeterminate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.ProgressDialog._isIndeterminate729); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._isIndeterminate729); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressStyle730; 
		public virtual void setProgressStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setProgressStyle730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressStyle730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressDialog731; 
		public ProgressDialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog731, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressDialog732; 
		public ProgressDialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog732, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		public static int STYLE_SPINNER
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int STYLE_HORIZONTAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ProgressDialog.staticClass = @__class; 
			global::android.app.ProgressDialog._onCreate710 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.ProgressDialog._onStart711 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onStart", "()V"); 
			global::android.app.ProgressDialog._onStop712 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onStop", "()V"); 
			global::android.app.ProgressDialog._setProgress713 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V"); 
			global::android.app.ProgressDialog._setSecondaryProgress714 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V"); 
			global::android.app.ProgressDialog._show715 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._show716 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._show717 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._show718 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._setMessage719 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.ProgressDialog._getProgress720 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getProgress", "()I"); 
			global::android.app.ProgressDialog._getSecondaryProgress721 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I"); 
			global::android.app.ProgressDialog._getMax722 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getMax", "()I"); 
			global::android.app.ProgressDialog._setMax723 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setMax", "(I)V"); 
			global::android.app.ProgressDialog._incrementProgressBy724 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V"); 
			global::android.app.ProgressDialog._incrementSecondaryProgressBy725 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V"); 
			global::android.app.ProgressDialog._setProgressDrawable726 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.app.ProgressDialog._setIndeterminateDrawable727 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.app.ProgressDialog._setIndeterminate728 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V"); 
			global::android.app.ProgressDialog._isIndeterminate729 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z"); 
			global::android.app.ProgressDialog._setProgressStyle730 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V"); 
			global::android.app.ProgressDialog._ProgressDialog731 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.app.ProgressDialog._ProgressDialog732 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
