namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressDialog : android.app.AlertDialog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProgressDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate2037;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onCreate2037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart2038;
		public virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStart2038);
		}
		internal static global::MonoJavaBridge.MethodId _onStop2039;
		protected override void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._onStop2039);
		}
		internal static global::MonoJavaBridge.MethodId _setProgress2040;
		public virtual void setProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgress2040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecondaryProgress2041;
		public virtual void setSecondaryProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setSecondaryProgress2041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _show2042;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		internal static global::MonoJavaBridge.MethodId _show2043;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2, bool arg3, bool arg4)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _show2044;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2, bool arg3, bool arg4, global::android.content.DialogInterface_OnCancelListenerDelegate arg5)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4, (global::android.content.DialogInterface_OnCancelListenerDelegateWrapper)arg5);
		}
		internal static global::MonoJavaBridge.MethodId _show2045;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._show2045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2, bool arg3)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3);
		}
		public new global::java.lang.CharSequence Message
		{
			set
			{
				setMessage(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMessage2046;
		public override void setMessage(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMessage2046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getProgress2047;
		public virtual int getProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getProgress2047);
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
		internal static global::MonoJavaBridge.MethodId _getSecondaryProgress2048;
		public virtual int getSecondaryProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getSecondaryProgress2048);
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
		internal static global::MonoJavaBridge.MethodId _getMax2049;
		public virtual int getMax()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._getMax2049);
		}
		internal static global::MonoJavaBridge.MethodId _setMax2050;
		public virtual void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setMax2050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementProgressBy2051;
		public virtual void incrementProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementProgressBy2051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementSecondaryProgressBy2052;
		public virtual void incrementSecondaryProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._incrementSecondaryProgressBy2052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ProgressDrawable
		{
			set
			{
				setProgressDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProgressDrawable2053;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressDrawable2053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable IndeterminateDrawable
		{
			set
			{
				setIndeterminateDrawable(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminateDrawable2054;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminateDrawable2054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Indeterminate
		{
			set
			{
				setIndeterminate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIndeterminate2055;
		public virtual void setIndeterminate(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setIndeterminate2055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIndeterminate2056;
		public virtual bool isIndeterminate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._isIndeterminate2056);
		}
		public new int ProgressStyle
		{
			set
			{
				setProgressStyle(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProgressStyle2057;
		public virtual void setProgressStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._setProgressStyle2057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ProgressDialog2058;
		public ProgressDialog(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog2058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ProgressDialog2059;
		public ProgressDialog(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._ProgressDialog2059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		static ProgressDialog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.ProgressDialog.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/ProgressDialog"));
			global::android.app.ProgressDialog._onCreate2037 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.app.ProgressDialog._onStart2038 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onStart", "()V");
			global::android.app.ProgressDialog._onStop2039 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "onStop", "()V");
			global::android.app.ProgressDialog._setProgress2040 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V");
			global::android.app.ProgressDialog._setSecondaryProgress2041 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V");
			global::android.app.ProgressDialog._show2042 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show2043 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show2044 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._show2045 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;");
			global::android.app.ProgressDialog._setMessage2046 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V");
			global::android.app.ProgressDialog._getProgress2047 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getProgress", "()I");
			global::android.app.ProgressDialog._getSecondaryProgress2048 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I");
			global::android.app.ProgressDialog._getMax2049 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "getMax", "()I");
			global::android.app.ProgressDialog._setMax2050 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setMax", "(I)V");
			global::android.app.ProgressDialog._incrementProgressBy2051 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V");
			global::android.app.ProgressDialog._incrementSecondaryProgressBy2052 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V");
			global::android.app.ProgressDialog._setProgressDrawable2053 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminateDrawable2054 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.app.ProgressDialog._setIndeterminate2055 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V");
			global::android.app.ProgressDialog._isIndeterminate2056 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z");
			global::android.app.ProgressDialog._setProgressStyle2057 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V");
			global::android.app.ProgressDialog._ProgressDialog2058 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.app.ProgressDialog._ProgressDialog2059 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
