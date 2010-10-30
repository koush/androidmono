namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.LineHeightSpan_WithDensity_))]
	public partial interface LineHeightSpan_WithDensity : LineHeightSpan
	{
		void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5, android.text.TextPaint arg6);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.LineHeightSpan_WithDensity))]
	internal sealed partial class LineHeightSpan_WithDensity_ : java.lang.Object, LineHeightSpan_WithDensity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LineHeightSpan_WithDensity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _chooseHeight13522;
		void android.text.style.LineHeightSpan_WithDensity.chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5, android.text.TextPaint arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LineHeightSpan_WithDensity_._chooseHeight13522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _chooseHeight13523;
		void android.text.style.LineHeightSpan.chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LineHeightSpan_WithDensity_._chooseHeight13523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		static LineHeightSpan_WithDensity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LineHeightSpan_WithDensity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LineHeightSpan$WithDensity"));
			global::android.text.style.LineHeightSpan_WithDensity_._chooseHeight13522 = @__env.GetMethodIDNoThrow(global::android.text.style.LineHeightSpan_WithDensity_.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;Landroid/text/TextPaint;)V");
			global::android.text.style.LineHeightSpan_WithDensity_._chooseHeight13523 = @__env.GetMethodIDNoThrow(global::android.text.style.LineHeightSpan_WithDensity_.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
