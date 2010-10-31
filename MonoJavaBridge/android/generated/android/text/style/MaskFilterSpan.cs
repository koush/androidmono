namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MaskFilterSpan : android.text.style.CharacterStyle, UpdateAppearance
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.graphics.MaskFilter getMaskFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.MaskFilterSpan.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;", ref global::android.text.style.MaskFilterSpan._m0) as android.graphics.MaskFilter;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.MaskFilterSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.MaskFilterSpan._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public MaskFilterSpan(android.graphics.MaskFilter arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.MaskFilterSpan._m2.native == global::System.IntPtr.Zero)
				global::android.text.style.MaskFilterSpan._m2 = @__env.GetMethodIDNoThrow(global::android.text.style.MaskFilterSpan.staticClass, "<init>", "(Landroid/graphics/MaskFilter;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.MaskFilterSpan.staticClass, global::android.text.style.MaskFilterSpan._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MaskFilterSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.MaskFilterSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/MaskFilterSpan"));
		}
	}
}
