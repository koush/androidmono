namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Spinner : android.widget.AbsSpinner, android.content.DialogInterface_OnClickListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static Spinner() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.Spinner), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onClick10099; 
		public virtual void onClick(android.content.DialogInterface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				@__env.CallVoidMethod(this, _onClick10099, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Spinner.staticClass, _onClick10099, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow10100; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow10100); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Spinner.staticClass, _onDetachedFromWindow10100); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _performClick10101; 
		public override bool performClick() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				return @__env.CallBooleanMethod(this, _performClick10101); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.Spinner.staticClass, _performClick10101); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10102; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				@__env.CallVoidMethod(this, _onLayout10102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Spinner.staticClass, _onLayout10102, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10103; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				return @__env.CallIntMethod(this, _getBaseline10103); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.Spinner.staticClass, _getBaseline10103); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnItemClickListener10104; 
		public override void setOnItemClickListener(android.widget.AdapterView.OnItemClickListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				@__env.CallVoidMethod(this, _setOnItemClickListener10104, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Spinner.staticClass, _setOnItemClickListener10104, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPrompt10105; 
		public virtual void setPrompt(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				@__env.CallVoidMethod(this, _setPrompt10105, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Spinner.staticClass, _setPrompt10105, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPromptId10106; 
		public virtual void setPromptId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				@__env.CallVoidMethod(this, _setPromptId10106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.Spinner.staticClass, _setPromptId10106, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPrompt10107; 
		public virtual java.lang.CharSequence getPrompt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.Spinner)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getPrompt10107)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.Spinner.staticClass, _getPrompt10107)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Spinner10108; 
		public Spinner(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Spinner.staticClass, _Spinner10108, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Spinner10109; 
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Spinner.staticClass, _Spinner10109, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Spinner10110; 
		public Spinner(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.Spinner.staticClass, _Spinner10110, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.Spinner.staticClass = @__class; 
			global::android.widget.Spinner._onClick10099 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "onClick", "(Landroid/content/DialogInterface;I)V"); 
			global::android.widget.Spinner._onDetachedFromWindow10100 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.widget.Spinner._performClick10101 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "performClick", "()Z"); 
			global::android.widget.Spinner._onLayout10102 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.Spinner._getBaseline10103 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "getBaseline", "()I"); 
			global::android.widget.Spinner._setOnItemClickListener10104 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "setOnItemClickListener", "(Landroid/widget/AdapterView$OnItemClickListener;)V"); 
			global::android.widget.Spinner._setPrompt10105 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "setPrompt", "(Ljava/lang/CharSequence;)V"); 
			global::android.widget.Spinner._setPromptId10106 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "setPromptId", "(I)V"); 
			global::android.widget.Spinner._getPrompt10107 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "getPrompt", "()Ljava/lang/CharSequence;"); 
			global::android.widget.Spinner._Spinner10108 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.Spinner._Spinner10109 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.Spinner._Spinner10110 = @__env.GetMethodID(global::android.widget.Spinner.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
