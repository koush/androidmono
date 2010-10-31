namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ProgressDialog : android.app.AlertDialog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProgressDialog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCreate(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V", ref global::android.app.ProgressDialog._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onStart()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "onStart", "()V", ref global::android.app.ProgressDialog._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onStop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "onStop", "()V", ref global::android.app.ProgressDialog._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V", ref global::android.app.ProgressDialog._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setSecondaryProgress(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V", ref global::android.app.ProgressDialog._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ProgressDialog._m5.native == global::System.IntPtr.Zero)
				global::android.app.ProgressDialog._m5 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ProgressDialog._m6.native == global::System.IntPtr.Zero)
				global::android.app.ProgressDialog._m6 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2, bool arg3, bool arg4)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ProgressDialog._m7.native == global::System.IntPtr.Zero)
				global::android.app.ProgressDialog._m7 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.app.ProgressDialog;
		}
		public static android.app.ProgressDialog show(android.content.Context arg0, string arg1, string arg2, bool arg3, bool arg4, global::android.content.DialogInterface_OnCancelListenerDelegate arg5)
		{
			return show(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, (global::java.lang.CharSequence)(global::java.lang.String)arg2, arg3, arg4, (global::android.content.DialogInterface_OnCancelListenerDelegateWrapper)arg5);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ProgressDialog._m8.native == global::System.IntPtr.Zero)
				global::android.app.ProgressDialog._m8 = @__env.GetStaticMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.app.ProgressDialog;
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
		private static global::MonoJavaBridge.MethodId _m9;
		public override void setMessage(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V", ref global::android.app.ProgressDialog._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ProgressDialog.staticClass, "getProgress", "()I", ref global::android.app.ProgressDialog._m10);
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
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getSecondaryProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I", ref global::android.app.ProgressDialog._m11);
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
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getMax()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.ProgressDialog.staticClass, "getMax", "()I", ref global::android.app.ProgressDialog._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setMax(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setMax", "(I)V", ref global::android.app.ProgressDialog._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void incrementProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V", ref global::android.app.ProgressDialog._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void incrementSecondaryProgressBy(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V", ref global::android.app.ProgressDialog._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable ProgressDrawable
		{
			set
			{
				setProgressDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.app.ProgressDialog._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable IndeterminateDrawable
		{
			set
			{
				setIndeterminateDrawable(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.app.ProgressDialog._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Indeterminate
		{
			set
			{
				setIndeterminate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setIndeterminate(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V", ref global::android.app.ProgressDialog._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual bool isIndeterminate()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z", ref global::android.app.ProgressDialog._m19);
		}
		public new int ProgressStyle
		{
			set
			{
				setProgressStyle(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setProgressStyle(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V", ref global::android.app.ProgressDialog._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public ProgressDialog(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ProgressDialog._m21.native == global::System.IntPtr.Zero)
				global::android.app.ProgressDialog._m21 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ProgressDialog(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.ProgressDialog._m22.native == global::System.IntPtr.Zero)
				global::android.app.ProgressDialog._m22 = @__env.GetMethodIDNoThrow(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.ProgressDialog.staticClass, global::android.app.ProgressDialog._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		}
	}
}
