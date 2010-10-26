namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.LineBackgroundSpan_))]
	public partial interface LineBackgroundSpan : ParagraphStyle
	{
		void drawBackground(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, int arg10);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.LineBackgroundSpan))]
	internal sealed partial class LineBackgroundSpan_ : java.lang.Object, LineBackgroundSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LineBackgroundSpan_()
		{
			InitJNI();
		}
		internal LineBackgroundSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _drawBackground13521;
		 void android.text.style.LineBackgroundSpan.drawBackground(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, int arg10) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LineBackgroundSpan_._drawBackground13521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.LineBackgroundSpan_.staticClass, global::android.text.style.LineBackgroundSpan_._drawBackground13521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LineBackgroundSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LineBackgroundSpan"));
			global::android.text.style.LineBackgroundSpan_._drawBackground13521 = @__env.GetMethodIDNoThrow(global::android.text.style.LineBackgroundSpan_.staticClass, "drawBackground", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;III)V");
		}
	}
}
