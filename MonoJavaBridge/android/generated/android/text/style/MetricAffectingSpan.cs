namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.MetricAffectingSpan_))]
	public abstract partial class MetricAffectingSpan : android.text.style.CharacterStyle, UpdateLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MetricAffectingSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.text.style.MetricAffectingSpan getUnderlying()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.style.MetricAffectingSpan.staticClass, "getUnderlying", "()Landroid/text/style/MetricAffectingSpan;", ref global::android.text.style.MetricAffectingSpan._m0) as android.text.style.MetricAffectingSpan;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void updateMeasureState(android.text.TextPaint arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public MetricAffectingSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.MetricAffectingSpan._m2.native == global::System.IntPtr.Zero)
				global::android.text.style.MetricAffectingSpan._m2 = @__env.GetMethodIDNoThrow(global::android.text.style.MetricAffectingSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.MetricAffectingSpan.staticClass, global::android.text.style.MetricAffectingSpan._m2);
			Init(@__env, handle);
		}
		static MetricAffectingSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.MetricAffectingSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/MetricAffectingSpan"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.MetricAffectingSpan))]
	internal sealed partial class MetricAffectingSpan_ : android.text.style.MetricAffectingSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MetricAffectingSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.MetricAffectingSpan_.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.MetricAffectingSpan_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.MetricAffectingSpan_.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.MetricAffectingSpan_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static MetricAffectingSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.MetricAffectingSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/MetricAffectingSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
