namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.CharacterStyle_))]
	public abstract partial class CharacterStyle : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharacterStyle()
		{
			InitJNI();
		}
		protected CharacterStyle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap8779;
		public static global::android.text.style.CharacterStyle wrap(android.text.style.CharacterStyle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._wrap8779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.style.CharacterStyle;
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8780;
		public abstract void updateDrawState(android.text.TextPaint arg0);
		internal static global::MonoJavaBridge.MethodId _getUnderlying8781;
		public virtual global::android.text.style.CharacterStyle getUnderlying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.CharacterStyle._getUnderlying8781)) as android.text.style.CharacterStyle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._getUnderlying8781)) as android.text.style.CharacterStyle;
		}
		internal static global::MonoJavaBridge.MethodId _CharacterStyle8782;
		public CharacterStyle()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.CharacterStyle.staticClass, global::android.text.style.CharacterStyle._CharacterStyle8782);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.CharacterStyle.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/CharacterStyle"));
			global::android.text.style.CharacterStyle._wrap8779 = @__env.GetStaticMethodIDNoThrow(global::android.text.style.CharacterStyle.staticClass, "wrap", "(Landroid/text/style/CharacterStyle;)Landroid/text/style/CharacterStyle;");
			global::android.text.style.CharacterStyle._updateDrawState8780 = @__env.GetMethodIDNoThrow(global::android.text.style.CharacterStyle.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.CharacterStyle._getUnderlying8781 = @__env.GetMethodIDNoThrow(global::android.text.style.CharacterStyle.staticClass, "getUnderlying", "()Landroid/text/style/CharacterStyle;");
			global::android.text.style.CharacterStyle._CharacterStyle8782 = @__env.GetMethodIDNoThrow(global::android.text.style.CharacterStyle.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.CharacterStyle))]
	public sealed partial class CharacterStyle_ : android.text.style.CharacterStyle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharacterStyle_()
		{
			InitJNI();
		}
		internal CharacterStyle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8783;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.CharacterStyle_._updateDrawState8783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.CharacterStyle_.staticClass, global::android.text.style.CharacterStyle_._updateDrawState8783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.CharacterStyle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/CharacterStyle"));
			global::android.text.style.CharacterStyle_._updateDrawState8783 = @__env.GetMethodIDNoThrow(global::android.text.style.CharacterStyle_.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
		}
	}
}
