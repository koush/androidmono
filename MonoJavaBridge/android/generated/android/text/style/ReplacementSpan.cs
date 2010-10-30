namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.style.ReplacementSpan_))]
	public abstract partial class ReplacementSpan : android.text.style.MetricAffectingSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ReplacementSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSize13553;
		public abstract int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4);
		internal static global::MonoJavaBridge.MethodId _draw13554;
		public abstract void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8);
		internal static global::MonoJavaBridge.MethodId _updateDrawState13555;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ReplacementSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ReplacementSpan._updateDrawState13555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13556;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ReplacementSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ReplacementSpan._updateMeasureState13556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ReplacementSpan13557;
		public ReplacementSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ReplacementSpan._ReplacementSpan13557.native == global::System.IntPtr.Zero)
				global::android.text.style.ReplacementSpan._ReplacementSpan13557 = @__env.GetMethodIDNoThrow(global::android.text.style.ReplacementSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ReplacementSpan.staticClass, global::android.text.style.ReplacementSpan._ReplacementSpan13557);
			Init(@__env, handle);
		}
		static ReplacementSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ReplacementSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ReplacementSpan"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.style.ReplacementSpan))]
	internal sealed partial class ReplacementSpan_ : android.text.style.ReplacementSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ReplacementSpan_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSize13558;
		public override int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ReplacementSpan_.staticClass, "getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMetricsInt;)I", ref global::android.text.style.ReplacementSpan_._getSize13558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public int getSize(android.graphics.Paint arg0, string arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4)
		{
			return getSize(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4);
		}
		internal static global::MonoJavaBridge.MethodId _draw13559;
		public override void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ReplacementSpan_.staticClass, "draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)V", ref global::android.text.style.ReplacementSpan_._draw13559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		public void draw(android.graphics.Canvas arg0, string arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8)
		{
			draw(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		}
		static ReplacementSpan_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ReplacementSpan_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ReplacementSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
