namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Spinner : android.widget.AbsSpinner, android.content.DialogInterface_OnClickListener
	{
		internal new static global::java.lang.Class staticClass;
		static Spinner()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.Spinner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.Spinner(@__env);
			}
		}
		protected Spinner(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onClick10889;
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Spinner._onClick10889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onClick10889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10890;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Spinner._onDetachedFromWindow10890);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onDetachedFromWindow10890);
		}
		internal static global::net.sf.jni4net.jni.MethodId _performClick10891;
		public override bool performClick() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.Spinner._performClick10891);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._performClick10891);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10892;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Spinner._onLayout10892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._onLayout10892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10893;
		public override int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.Spinner._getBaseline10893);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._getBaseline10893);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener10894;
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Spinner._setOnItemClickListener10894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setOnItemClickListener10894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPrompt10895;
		public virtual void setPrompt(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Spinner._setPrompt10895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setPrompt10895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setPrompt(string arg0)
		{
			setPrompt((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPromptId10896;
		public virtual void setPromptId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.Spinner._setPromptId10896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._setPromptId10896, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPrompt10897;
		public virtual global::java.lang.CharSequence getPrompt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.Spinner._getPrompt10897));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.Spinner.staticClass, global::android.widget.Spinner._getPrompt10897));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Spinner10898;
		public Spinner(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner10898, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Spinner10899;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner10899, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Spinner10900;
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.Spinner.staticClass, global::android.widget.Spinner._Spinner10900, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.Spinner.staticClass = @__class;
			global::android.widget.Spinner._onClick10889 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V");
			global::android.widget.Spinner._onDetachedFromWindow10890 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "onDetachedFromWindow", "()V");
			global::android.widget.Spinner._performClick10891 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "performClick", "()Z");
			global::android.widget.Spinner._onLayout10892 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.Spinner._getBaseline10893 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "getBaseline", "()I");
			global::android.widget.Spinner._setOnItemClickListener10894 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V");
			global::android.widget.Spinner._setPrompt10895 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "setPrompt", "(Ljava/lang/CharSequence;)V");
			global::android.widget.Spinner._setPromptId10896 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "setPromptId", "(I)V");
			global::android.widget.Spinner._getPrompt10897 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "getPrompt", "()Ljava/lang/CharSequence;");
			global::android.widget.Spinner._Spinner10898 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.Spinner._Spinner10899 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.Spinner._Spinner10900 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
