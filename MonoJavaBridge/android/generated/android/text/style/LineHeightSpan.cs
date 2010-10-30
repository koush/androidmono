namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.LineHeightSpan_))]
	public partial interface LineHeightSpan : ParagraphStyle, WrapTogetherSpan
	{
		void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.LineHeightSpan))]
	internal sealed partial class LineHeightSpan_ : java.lang.Object, LineHeightSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LineHeightSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.text.style.LineHeightSpan.chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.LineHeightSpan_.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V", ref global::android.text.style.LineHeightSpan_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		static LineHeightSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LineHeightSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LineHeightSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
