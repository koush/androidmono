namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CharacterStyle : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CharacterStyle() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.CharacterStyle), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CharacterStyle(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _wrap6939; 
		public static android.text.style.CharacterStyle wrap(android.text.style.CharacterStyle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.CharacterStyle>(@__env, @__env.CallStaticObjectMethodPtr(android.text.style.CharacterStyle.staticClass, _wrap6939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState6940; 
		public abstract void updateDrawState(android.text.TextPaint arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getUnderlying6941; 
		public virtual android.text.style.CharacterStyle getUnderlying() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.CharacterStyle)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.CharacterStyle>(@__env, @__env.CallObjectMethodPtr(this, _getUnderlying6941)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.CharacterStyle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.CharacterStyle.staticClass, _getUnderlying6941)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CharacterStyle6942; 
		public CharacterStyle()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.CharacterStyle.staticClass, _CharacterStyle6942, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.CharacterStyle.staticClass = @__class; 
			global::android.text.style.CharacterStyle._wrap6939 = @__env.GetStaticMethodID(global::android.text.style.CharacterStyle.staticClass, "wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;"); 
			global::android.text.style.CharacterStyle._updateDrawState6940 = @__env.GetMethodID(global::android.text.style.CharacterStyle.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.CharacterStyle._getUnderlying6941 = @__env.GetMethodID(global::android.text.style.CharacterStyle.staticClass, "getUnderlying", "()Landroid/text/style/CharacterStyle;"); 
			global::android.text.style.CharacterStyle._CharacterStyle6942 = @__env.GetMethodID(global::android.text.style.CharacterStyle.staticClass, "<init>", "()V"); 
		} 
	} 
} 
