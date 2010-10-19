namespace android.text.style
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.style.LeadingMarginSpan_))]
	public interface LeadingMarginSpan : ParagraphStyle
	{
		int getLeadingMargin(bool arg0);
		void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.LeadingMarginSpan))]
	public sealed partial class LeadingMarginSpan_ : java.lang.Object, LeadingMarginSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LeadingMarginSpan_()
		{
			InitJNI();
		}
		internal LeadingMarginSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin8837;
		 int android.text.style.LeadingMarginSpan.getLeadingMargin(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_._getLeadingMargin8837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_.staticClass, global::android.text.style.LeadingMarginSpan_._getLeadingMargin8837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin8838;
		 void android.text.style.LeadingMarginSpan.drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_._drawLeadingMargin8838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.LeadingMarginSpan_.staticClass, global::android.text.style.LeadingMarginSpan_._drawLeadingMargin8838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.LeadingMarginSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/LeadingMarginSpan"));
			global::android.text.style.LeadingMarginSpan_._getLeadingMargin8837 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_.staticClass, "getLeadingMargin", "(Z)I");
			global::android.text.style.LeadingMarginSpan_._drawLeadingMargin8838 = @__env.GetMethodIDNoThrow(global::android.text.style.LeadingMarginSpan_.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
		}
	}
}
