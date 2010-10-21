namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MaskFilterSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MaskFilterSpan()
		{
			InitJNI();
		}
		protected MaskFilterSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.graphics.MaskFilter MaskFilter
		{
			get
			{
				return getMaskFilter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaskFilter13463;
		public virtual global::android.graphics.MaskFilter getMaskFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.MaskFilterSpan._getMaskFilter13463)) as android.graphics.MaskFilter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.MaskFilterSpan.staticClass, global::android.text.style.MaskFilterSpan._getMaskFilter13463)) as android.graphics.MaskFilter;
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13464;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.MaskFilterSpan._updateDrawState13464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.MaskFilterSpan.staticClass, global::android.text.style.MaskFilterSpan._updateDrawState13464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _MaskFilterSpan13465;
		public MaskFilterSpan(android.graphics.MaskFilter arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.MaskFilterSpan.staticClass, global::android.text.style.MaskFilterSpan._MaskFilterSpan13465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.MaskFilterSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/MaskFilterSpan"));
			global::android.text.style.MaskFilterSpan._getMaskFilter13463 = @__env.GetMethodIDNoThrow(global::android.text.style.MaskFilterSpan.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;");
			global::android.text.style.MaskFilterSpan._updateDrawState13464 = @__env.GetMethodIDNoThrow(global::android.text.style.MaskFilterSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.MaskFilterSpan._MaskFilterSpan13465 = @__env.GetMethodIDNoThrow(global::android.text.style.MaskFilterSpan.staticClass, "<init>", "(Landroid/graphics/MaskFilter;)V");
		}
	}
}
