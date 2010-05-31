namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface LineHeightSpan_WithDensity : LineHeightSpan
	{ 
		void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5, android.text.TextPaint arg6); 
	} 

	public partial class LineHeightSpan_WithDensity_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __LineHeightSpan_WithDensity.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __LineHeightSpan_WithDensity : java.lang.Object, LineHeightSpan_WithDensity
	{ 
		internal static global::java.lang.Class staticClass; 
		static __LineHeightSpan_WithDensity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.__LineHeightSpan_WithDensity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.__LineHeightSpan_WithDensity(@__env); 
			} 
		} 
		internal __LineHeightSpan_WithDensity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _chooseHeight7365; 
		 void android.text.style.LineHeightSpan_WithDensity.chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5, android.text.TextPaint arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.style.__LineHeightSpan_WithDensity._chooseHeight7365, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.__LineHeightSpan_WithDensity.staticClass, global::android.text.style.__LineHeightSpan_WithDensity._chooseHeight7365, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _chooseHeight7366; 
		 void android.text.style.LineHeightSpan.chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.text.style.__LineHeightSpan_WithDensity._chooseHeight7366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.__LineHeightSpan_WithDensity.staticClass, global::android.text.style.__LineHeightSpan_WithDensity._chooseHeight7366, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.__LineHeightSpan_WithDensity.staticClass = @__class; 
			global::android.text.style.__LineHeightSpan_WithDensity._chooseHeight7365 = @__env.GetMethodID(global::android.text.style.__LineHeightSpan_WithDensity.staticClass, "android.text.style.LineHeightSpan_WithDensity.chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;Landroid/text/TextPaint;)V"); 
			global::android.text.style.__LineHeightSpan_WithDensity._chooseHeight7366 = @__env.GetMethodID(global::android.text.style.__LineHeightSpan_WithDensity.staticClass, "android.text.style.LineHeightSpan.chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V"); 
		} 
	} 
} 
