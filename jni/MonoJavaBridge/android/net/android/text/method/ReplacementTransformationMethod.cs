namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ReplacementTransformationMethod : java.lang.Object, TransformationMethod
	{ 
		internal static global::java.lang.Class staticClass; 
		static ReplacementTransformationMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.ReplacementTransformationMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ReplacementTransformationMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged6856; 
		public virtual void onFocusChanged(android.view.View arg0, java.lang.CharSequence arg1, bool arg2, int arg3, android.graphics.Rect arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ReplacementTransformationMethod)) 
				@__env.CallVoidMethod(this, _onFocusChanged6856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.ReplacementTransformationMethod.staticClass, _onFocusChanged6856, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation6857; 
		public virtual java.lang.CharSequence getTransformation(java.lang.CharSequence arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.ReplacementTransformationMethod)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _getTransformation6857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.ReplacementTransformationMethod.staticClass, _getTransformation6857, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginal6858; 
		protected abstract char[] getOriginal(); 
		internal static global::net.sf.jni4net.jni.MethodId _getReplacement6859; 
		protected abstract char[] getReplacement(); 
		internal static global::net.sf.jni4net.jni.MethodId _ReplacementTransformationMethod6860; 
		public ReplacementTransformationMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.ReplacementTransformationMethod.staticClass, _ReplacementTransformationMethod6860, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.ReplacementTransformationMethod.staticClass = @__class; 
			global::android.text.method.ReplacementTransformationMethod._onFocusChanged6856 = @__env.GetMethodID(global::android.text.method.ReplacementTransformationMethod.staticClass, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V"); 
			global::android.text.method.ReplacementTransformationMethod._getTransformation6857 = @__env.GetMethodID(global::android.text.method.ReplacementTransformationMethod.staticClass, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;"); 
			global::android.text.method.ReplacementTransformationMethod._getOriginal6858 = @__env.GetMethodID(global::android.text.method.ReplacementTransformationMethod.staticClass, "getOriginal", "()[C"); 
			global::android.text.method.ReplacementTransformationMethod._getReplacement6859 = @__env.GetMethodID(global::android.text.method.ReplacementTransformationMethod.staticClass, "getReplacement", "()[C"); 
			global::android.text.method.ReplacementTransformationMethod._ReplacementTransformationMethod6860 = @__env.GetMethodID(global::android.text.method.ReplacementTransformationMethod.staticClass, "<init>", "()V"); 
		} 
	} 
} 
