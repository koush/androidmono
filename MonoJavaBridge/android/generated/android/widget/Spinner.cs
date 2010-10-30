namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Spinner : android.widget.AbsSpinner, android.content.DialogInterface_OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Spinner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick17833;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._onClick17833.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._onClick17833 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onClick17833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17834;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._onDetachedFromWindow17834.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._onDetachedFromWindow17834 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "onDetachedFromWindow", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onDetachedFromWindow17834);
		}
		internal static global::MonoJavaBridge.MethodId _performClick17835;
		public override bool performClick()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._performClick17835.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._performClick17835 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "performClick", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._performClick17835);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17836;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._onLayout17836.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._onLayout17836 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "onLayout", "(ZIIII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onLayout17836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17837;
		public override int getBaseline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._getBaseline17837.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._getBaseline17837 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "getBaseline", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._getBaseline17837);
		}
		public new global::android.widget.AdapterView.OnItemClickListener OnItemClickListener
		{
			set
			{
				setOnItemClickListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener17838;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._setOnItemClickListener17838.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._setOnItemClickListener17838 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setOnItemClickListener17838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnItemClickListener(global::android.widget.AdapterView.OnItemClickListenerDelegate arg0)
		{
			setOnItemClickListener((global::android.widget.AdapterView.OnItemClickListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPrompt17839;
		public virtual void setPrompt(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._setPrompt17839.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._setPrompt17839 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "setPrompt", "(Ljava/lang/CharSequence;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setPrompt17839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _setPromptId17840;
		public virtual void setPromptId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._setPromptId17840.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._setPromptId17840 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "setPromptId", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setPromptId17840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPrompt17841;
		public virtual global::java.lang.CharSequence getPrompt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._getPrompt17841.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._getPrompt17841 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "getPrompt", "()Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._getPrompt17841) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _Spinner17842;
		public Spinner(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._Spinner17842.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._Spinner17842 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner17842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Spinner17843;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._Spinner17843.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._Spinner17843 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner17843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Spinner17844;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.Spinner._Spinner17844.native == global::System.IntPtr.Zero)
				global::android.widget.Spinner._Spinner17844 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner17844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
