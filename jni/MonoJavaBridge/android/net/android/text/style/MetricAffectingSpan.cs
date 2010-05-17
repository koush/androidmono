namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class MetricAffectingSpan : android.text.style.CharacterStyle, UpdateLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MetricAffectingSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.MetricAffectingSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected MetricAffectingSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUnderlying6994; 
		public virtual new android.text.style.MetricAffectingSpan getUnderlying() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.MetricAffectingSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.MetricAffectingSpan>(@__env, @__env.CallObjectMethodPtr(this, _getUnderlying6994)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.style.MetricAffectingSpan>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.MetricAffectingSpan.staticClass, _getUnderlying6994)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState6995; 
		public abstract void updateMeasureState(android.text.TextPaint arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _MetricAffectingSpan6996; 
		public MetricAffectingSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.MetricAffectingSpan.staticClass, _MetricAffectingSpan6996, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.MetricAffectingSpan.staticClass = @__class; 
			global::android.text.style.MetricAffectingSpan._getUnderlying6994 = @__env.GetMethodID(global::android.text.style.MetricAffectingSpan.staticClass, "getUnderlying", "()Landroid/text/style/MetricAffectingSpan;"); 
			global::android.text.style.MetricAffectingSpan._updateMeasureState6995 = @__env.GetMethodID(global::android.text.style.MetricAffectingSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.MetricAffectingSpan._MetricAffectingSpan6996 = @__env.GetMethodID(global::android.text.style.MetricAffectingSpan.staticClass, "<init>", "()V"); 
		} 
	} 
} 
