namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Spinner : android.widget.AbsSpinner, android.content.DialogInterface_OnClickListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Spinner()
		{
			InitJNI();
		}
		protected Spinner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onClick17720;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Spinner._onClick17720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onClick17720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow17721;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Spinner._onDetachedFromWindow17721);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onDetachedFromWindow17721);
		}
		internal static global::MonoJavaBridge.MethodId _performClick17722;
		public override bool performClick() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.Spinner._performClick17722);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._performClick17722);
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17723;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Spinner._onLayout17723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onLayout17723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17724;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.Spinner._getBaseline17724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._getBaseline17724);
		}
		internal static global::MonoJavaBridge.MethodId _setOnItemClickListener17725;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Spinner._setOnItemClickListener17725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setOnItemClickListener17725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPrompt17726;
		public virtual void setPrompt(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Spinner._setPrompt17726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setPrompt17726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPrompt(string arg0)
		{
			setPrompt((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setPromptId17727;
		public virtual void setPromptId(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.Spinner._setPromptId17727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setPromptId17727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPrompt17728;
		public virtual global::java.lang.CharSequence getPrompt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.Spinner._getPrompt17728)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._getPrompt17728)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _Spinner17729;
		public Spinner(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner17729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Spinner17730;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner17730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Spinner17731;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner17731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.Spinner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/Spinner"));
			global::android.widget.Spinner._onClick17720 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.widget.Spinner._onDetachedFromWindow17721 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.Spinner._performClick17722 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "performClick", "()Z");
			global::android.widget.Spinner._onLayout17723 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.Spinner._getBaseline17724 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "getBaseline", "()I");
			global::android.widget.Spinner._setOnItemClickListener17725 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.Spinner._setPrompt17726 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "setPrompt", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Spinner._setPromptId17727 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "setPromptId", "(I)V");
			global::android.widget.Spinner._getPrompt17728 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "getPrompt", "()Ljava/lang/CharSequence;");
			global::android.widget.Spinner._Spinner17729 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Spinner._Spinner17730 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.Spinner._Spinner17731 = @__env.GetMethodIDNoThrow(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
