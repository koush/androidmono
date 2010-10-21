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
		internal static global::MonoJavaBridge.MethodId _onCreate2032;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._onCreate2032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onCreate2032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart2033;
		public virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._onStart2033);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStart2033);
		}
		internal static global::MonoJavaBridge.MethodId _onStop2034;
		protected override void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._onStop2034);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStop2034);
		}
		internal static global::MonoJavaBridge.MethodId _setProgress2035;
		public virtual void setProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setProgress2035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgress2035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress2036;
		public virtual void setSecondaryProgress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setSecondaryProgress2036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setSecondaryProgress2036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show2037;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _show2038;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _show2039;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _show2040;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.ProgressDialog;
		}
		internal static global::MonoJavaBridge.MethodId _setMessage2041;
		public override void setMessage(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setMessage2041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMessage2041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setMessage(string arg0)
		{
			setMessage((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new int Progress
		{
			get
			{
				return getProgress();
			}
			set
			{
				setProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProgress2042;
		public virtual int getProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ProgressDialog._getProgress2042);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getProgress2042);
		}
		public new int SecondaryProgress
		{
			get
			{
				return getSecondaryProgress();
			}
			set
			{
				setSecondaryProgress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSecondaryProgress2043;
		public virtual int getSecondaryProgress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ProgressDialog._getSecondaryProgress2043);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getSecondaryProgress2043);
		}
		public new int Max
		{
			get
			{
				return getMax();
			}
			set
			{
				setMax(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMax2044;
		public virtual int getMax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.ProgressDialog._getMax2044);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getMax2044);
		}
		internal static global::MonoJavaBridge.MethodId _setMax2045;
		public virtual void setMax(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setMax2045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMax2045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementProgressBy2046;
		public virtual void incrementProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._incrementProgressBy2046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementProgressBy2046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementSecondaryProgressBy2047;
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._incrementSecondaryProgressBy2047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementSecondaryProgressBy2047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProgressDrawable2048;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setProgressDrawable2048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressDrawable2048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminateDrawable2049;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setIndeterminateDrawable2049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminateDrawable2049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminate2050;
		public virtual void setIndeterminate(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setIndeterminate2050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminate2050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIndeterminate2051;
		public virtual bool isIndeterminate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.ProgressDialog._isIndeterminate2051);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._isIndeterminate2051);
		}
		internal static global::MonoJavaBridge.MethodId _setProgressStyle2052;
		public virtual void setProgressStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.ProgressDialog._setProgressStyle2052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressStyle2052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ProgressDialog2053;
		public ProgressDialog(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog2053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressDialog2054;
		public ProgressDialog(android.content.Context arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog2054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::android.app.ProgressDialog._onCreate2032 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ProgressDialog._onStart2033 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onStart", "()V");
			global::android.app.ProgressDialog._onStop2034 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onStop", "()V");
			global::android.app.ProgressDialog._setProgress2035 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V");
			global::android.app.ProgressDialog._setSecondaryProgress2036 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.ProgressDialog._show2037 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show2038 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show2039 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show2040 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._setMessage2041 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.ProgressDialog._getProgress2042 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getProgress", "()I");
			global::android.app.ProgressDialog._getSecondaryProgress2043 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I");
			global::android.app.ProgressDialog._getMax2044 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getMax", "()I");
			global::android.app.ProgressDialog._setMax2045 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setMax", "(I)V");
			global::android.app.ProgressDialog._incrementProgressBy2046 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V");
			global::android.app.ProgressDialog._incrementSecondaryProgressBy2047 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.app.ProgressDialog._setProgressDrawable2048 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminateDrawable2049 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminate2050 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V");
			global::android.app.ProgressDialog._isIndeterminate2051 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z");
			global::android.app.ProgressDialog._setProgressStyle2052 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V");
			global::android.app.ProgressDialog._ProgressDialog2053 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.ProgressDialog._ProgressDialog2054 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
	}
}
