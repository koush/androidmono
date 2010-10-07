namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class CharacterStyle : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CharacterStyle()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.CharacterStyle), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected CharacterStyle(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _wrap7936;
		public static global::android.text.style.CharacterStyle wrap(android.text.style.CharacterStyle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.CharacterStyle>(@__env, @__env.CallStaticObjectMethodPtr(android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._wrap7936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7937;
		public abstract void updateDrawState(android.text.TextPaint arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getUnderlying7938;
		public virtual global::android.text.style.CharacterStyle getUnderlying() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.CharacterStyle>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.CharacterStyle._getUnderlying7938));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.CharacterStyle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._getUnderlying7938));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CharacterStyle7939;
		public CharacterStyle()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._CharacterStyle7939, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.CharacterStyle.staticClass = @__class;
			global::android.text.style.CharacterStyle._wrap7936 = @__env.GetStaticMethodID(global::android.text.style.CharacterStyle.staticClass, "wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;");
			global::android.text.style.CharacterStyle._updateDrawState7937 = @__env.GetMethodID(global::android.text.style.CharacterStyle.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.CharacterStyle._getUnderlying7938 = @__env.GetMethodID(global::android.text.style.CharacterStyle.staticClass, "getUnderlying", "()Landroid/text/style/CharacterStyle;");
			global::android.text.style.CharacterStyle._CharacterStyle7939 = @__env.GetMethodID(global::android.text.style.CharacterStyle.staticClass, "<init>", "()V");
		}
	}
}
