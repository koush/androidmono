namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.MetricAffectingSpan_))]
	public abstract partial class MetricAffectingSpan : android.text.style.CharacterStyle, UpdateLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MetricAffectingSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getUnderlying13528;
		public virtual global::android.text.style.MetricAffectingSpan getUnderlying()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.MetricAffectingSpan._getUnderlying13528)) as android.text.style.MetricAffectingSpan;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.MetricAffectingSpan.staticClass, global::android.text.style.MetricAffectingSpan._getUnderlying13528)) as android.text.style.MetricAffectingSpan;
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13529;
		public abstract void updateMeasureState(android.text.TextPaint arg0);
		internal static global::MonoJavaBridge.MethodId _MetricAffectingSpan13530;
		public MetricAffectingSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.MetricAffectingSpan.staticClass, global::android.text.style.MetricAffectingSpan._MetricAffectingSpan13530);
			Init(@__env, handle);
		}
		static MetricAffectingSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.MetricAffectingSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/MetricAffectingSpan"));
			global::android.text.style.MetricAffectingSpan._getUnderlying13528 = @__env.GetMethodIDNoThrow(global::android.text.style.MetricAffectingSpan.staticClass, "getUnderlying", "()Landroid/text/style/MetricAffectingSpan;");
			global::android.text.style.MetricAffectingSpan._updateMeasureState13529 = @__env.GetMethodIDNoThrow(global::android.text.style.MetricAffectingSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.MetricAffectingSpan._MetricAffectingSpan13530 = @__env.GetMethodIDNoThrow(global::android.text.style.MetricAffectingSpan.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13531;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.MetricAffectingSpan_._updateMeasureState13531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.MetricAffectingSpan_.staticClass, global::android.text.style.MetricAffectingSpan_._updateMeasureState13531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13532;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.MetricAffectingSpan_._updateDrawState13532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.MetricAffectingSpan_.staticClass, global::android.text.style.MetricAffectingSpan_._updateDrawState13532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static MetricAffectingSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.MetricAffectingSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/MetricAffectingSpan"));
			global::android.text.style.MetricAffectingSpan_._updateMeasureState13531 = @__env.GetMethodIDNoThrow(global::android.text.style.MetricAffectingSpan_.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.MetricAffectingSpan_._updateDrawState13532 = @__env.GetMethodIDNoThrow(global::android.text.style.MetricAffectingSpan_.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
