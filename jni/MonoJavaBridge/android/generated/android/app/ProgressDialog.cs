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
		internal static global::net.sf.jni4net.jni.MethodId _onCreate720;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._onCreate720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onCreate720, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStart721;
		public virtual new void onStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._onStart721);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStart721);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStop722;
		protected override void onStop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._onStop722);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStop722);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgress723;
		public virtual void setProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setProgress723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgress723, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress724;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setSecondaryProgress724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setSecondaryProgress724, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _show725;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show725, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _show726;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _show727;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _show728;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMessage729;
		public override void setMessage(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setMessage729, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMessage729, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProgress730;
		public virtual int getProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.ProgressDialog._getProgress730);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getProgress730);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryProgress731;
		public virtual int getSecondaryProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.ProgressDialog._getSecondaryProgress731);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getSecondaryProgress731);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMax732;
		public virtual int getMax() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.ProgressDialog._getMax732);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getMax732);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMax733;
		public virtual void setMax(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setMax733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMax733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _incrementProgressBy734;
		public virtual void incrementProgressBy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._incrementProgressBy734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementProgressBy734, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _incrementSecondaryProgressBy735;
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._incrementSecondaryProgressBy735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementSecondaryProgressBy735, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressDrawable736;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setProgressDrawable736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressDrawable736, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminateDrawable737;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setIndeterminateDrawable737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminateDrawable737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminate738;
		public virtual void setIndeterminate(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setIndeterminate738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminate738, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isIndeterminate739;
		public virtual bool isIndeterminate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.ProgressDialog._isIndeterminate739);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._isIndeterminate739);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProgressStyle740;
		public virtual void setProgressStyle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ProgressDialog._setProgressStyle740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressStyle740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProgressDialog741;
		public ProgressDialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog741, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ProgressDialog742;
		public ProgressDialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog742, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
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
			global::android.app.ProgressDialog._onCreate720 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ProgressDialog._onStart721 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onStart", "()V");
			global::android.app.ProgressDialog._onStop722 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onStop", "()V");
			global::android.app.ProgressDialog._setProgress723 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V");
			global::android.app.ProgressDialog._setSecondaryProgress724 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.ProgressDialog._show725 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show726 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show727 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show728 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._setMessage729 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.ProgressDialog._getProgress730 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getProgress", "()I");
			global::android.app.ProgressDialog._getSecondaryProgress731 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I");
			global::android.app.ProgressDialog._getMax732 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getMax", "()I");
			global::android.app.ProgressDialog._setMax733 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setMax", "(I)V");
			global::android.app.ProgressDialog._incrementProgressBy734 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V");
			global::android.app.ProgressDialog._incrementSecondaryProgressBy735 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.app.ProgressDialog._setProgressDrawable736 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminateDrawable737 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminate738 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V");
			global::android.app.ProgressDialog._isIndeterminate739 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z");
			global::android.app.ProgressDialog._setProgressStyle740 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V");
			global::android.app.ProgressDialog._ProgressDialog741 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.ProgressDialog._ProgressDialog742 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
