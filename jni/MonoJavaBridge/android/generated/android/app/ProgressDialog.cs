namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressDialog : android.app.AlertDialog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProgressDialog()
		{
			InitJNI();
		}
		protected ProgressDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate730;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._onCreate730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onCreate730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart731;
		public virtual new void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._onStart731);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStart731);
		}
		internal static global::MonoJavaBridge.MethodId _onStop732;
		protected override void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._onStop732);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStop732);
		}
		internal static global::MonoJavaBridge.MethodId _setProgress733;
		public virtual void setProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setProgress733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgress733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress734;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setSecondaryProgress734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setSecondaryProgress734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show735;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _show736;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _show737;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _show738;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _setMessage739;
		public override void setMessage(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setMessage739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMessage739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getProgress740;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ProgressDialog._getProgress740);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getProgress740);
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryProgress741;
		public virtual int getSecondaryProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ProgressDialog._getSecondaryProgress741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getSecondaryProgress741);
		}
		internal static global::MonoJavaBridge.MethodId _getMax742;
		public virtual int getMax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ProgressDialog._getMax742);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getMax742);
		}
		internal static global::MonoJavaBridge.MethodId _setMax743;
		public virtual void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setMax743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMax743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementProgressBy744;
		public virtual void incrementProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._incrementProgressBy744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementProgressBy744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementSecondaryProgressBy745;
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._incrementSecondaryProgressBy745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementSecondaryProgressBy745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressDrawable746;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setProgressDrawable746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressDrawable746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminateDrawable747;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setIndeterminateDrawable747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminateDrawable747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminate748;
		public virtual void setIndeterminate(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setIndeterminate748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminate748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIndeterminate749;
		public virtual bool isIndeterminate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.ProgressDialog._isIndeterminate749);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._isIndeterminate749);
		}
		internal static global::MonoJavaBridge.MethodId _setProgressStyle750;
		public virtual void setProgressStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setProgressStyle750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressStyle750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ProgressDialog751;
		public ProgressDialog(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressDialog752;
		public ProgressDialog(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ProgressDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ProgressDialog"));
			global::android.app.ProgressDialog._onCreate730 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ProgressDialog._onStart731 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onStart", "()V");
			global::android.app.ProgressDialog._onStop732 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onStop", "()V");
			global::android.app.ProgressDialog._setProgress733 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V");
			global::android.app.ProgressDialog._setSecondaryProgress734 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.ProgressDialog._show735 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show736 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show737 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show738 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._setMessage739 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.ProgressDialog._getProgress740 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getProgress", "()I");
			global::android.app.ProgressDialog._getSecondaryProgress741 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I");
			global::android.app.ProgressDialog._getMax742 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getMax", "()I");
			global::android.app.ProgressDialog._setMax743 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setMax", "(I)V");
			global::android.app.ProgressDialog._incrementProgressBy744 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V");
			global::android.app.ProgressDialog._incrementSecondaryProgressBy745 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.app.ProgressDialog._setProgressDrawable746 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminateDrawable747 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminate748 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V");
			global::android.app.ProgressDialog._isIndeterminate749 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z");
			global::android.app.ProgressDialog._setProgressStyle750 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V");
			global::android.app.ProgressDialog._ProgressDialog751 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.ProgressDialog._ProgressDialog752 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
