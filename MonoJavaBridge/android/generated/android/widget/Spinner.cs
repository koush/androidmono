namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Spinner : android.widget.AbsSpinner, android.content.DialogInterface_OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Spinner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V", ref global::android.widget.Spinner._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, "onDetachedFromWindow", "()V", ref global::android.widget.Spinner._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool performClick()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Spinner.staticClass, "performClick", "()Z", ref global::android.widget.Spinner._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.Spinner._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int getBaseline()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Spinner.staticClass, "getBaseline", "()I", ref global::android.widget.Spinner._m4);
		}
		public new global::android.widget.AdapterView.OnItemClickListener OnItemClickListener
		{
			set
			{
				setOnItemClickListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V", ref global::android.widget.Spinner._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemClickListener(global::android.widget.AdapterView.OnItemClickListenerDelegate arg0)
		{
			setOnItemClickListener((global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setPrompt(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, "setPrompt", "(Ljava/lang/CharSequence;)V", ref global::android.widget.Spinner._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPrompt(string arg0)
		{
			setPrompt((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new int PromptId
		{
			set
			{
				setPromptId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setPromptId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, "setPromptId", "(I)V", ref global::android.widget.Spinner._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new string Prompt
		{
			get
			{
				return getPrompt().toString();
			}
			set
			{
				setPrompt((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.CharSequence getPrompt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.Spinner.staticClass, "getPrompt", "()Ljava/lang/CharSequence;", ref global::android.widget.Spinner._m8) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Spinner(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._m9.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._m9 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._m10.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._m10 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._m11.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._m11 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Spinner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Spinner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Spinner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
