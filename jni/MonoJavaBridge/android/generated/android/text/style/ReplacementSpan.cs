namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ReplacementSpan : android.text.style.MetricAffectingSpan
	{
		internal new static global::java.lang.Class staticClass;
		static ReplacementSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.ReplacementSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ReplacementSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSize7394;
		public abstract int getSize(android.graphics.Paint arg0, java.lang.CharSequence arg1, int arg2, int arg3, android.graphics.Paint.FontMetricsInt arg4);
		internal static global::net.sf.jni4net.jni.MethodId _draw7395;
		public abstract void draw(android.graphics.Canvas arg0, java.lang.CharSequence arg1, int arg2, int arg3, float arg4, int arg5, int arg6, int arg7, android.graphics.Paint arg8);
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7396;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ReplacementSpan._updateDrawState7396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ReplacementSpan.staticClass, global::android.text.style.ReplacementSpan._updateDrawState7396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7397;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ReplacementSpan._updateMeasureState7397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ReplacementSpan.staticClass, global::android.text.style.ReplacementSpan._updateMeasureState7397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ReplacementSpan7398;
		public ReplacementSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.ReplacementSpan.staticClass, global::android.text.style.ReplacementSpan._ReplacementSpan7398, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.ReplacementSpan.staticClass = @__class;
			global::android.text.style.ReplacementSpan._getSize7394 = @__env.GetMethodID(global::android.text.style.ReplacementSpan.staticClass, "getSize", "(Landroid/graphics/Paint;Ljava/lang/CharSequence;IILandroid/graphics/Paint$FontMetricsInt;)I");
			global::android.text.style.ReplacementSpan._draw7395 = @__env.GetMethodID(global::android.text.style.ReplacementSpan.staticClass, "draw", "(Landroid/graphics/Canvas;Ljava/lang/CharSequence;IIFIIILandroid/graphics/Paint;)V");
			global::android.text.style.ReplacementSpan._updateDrawState7396 = @__env.GetMethodID(global::android.text.style.ReplacementSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ReplacementSpan._updateMeasureState7397 = @__env.GetMethodID(global::android.text.style.ReplacementSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ReplacementSpan._ReplacementSpan7398 = @__env.GetMethodID(global::android.text.style.ReplacementSpan.staticClass, "<init>", "()V");
		}
	}
}
