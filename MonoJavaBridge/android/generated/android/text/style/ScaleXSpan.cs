namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleXSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScaleXSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.ScaleXSpan._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, "describeContents", "()I", ref global::android.text.style.ScaleXSpan._m1);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.ScaleXSpan._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ScaleXSpan._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ScaleXSpan._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float ScaleX
		{
			get
			{
				return getScaleX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual float getScaleX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.style.ScaleXSpan.staticClass, "getScaleX", "()F", ref global::android.text.style.ScaleXSpan._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public ScaleXSpan(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ScaleXSpan._m6.native == global::System.IntPtr.Zero)
				global::android.text.style.ScaleXSpan._m6 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ScaleXSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ScaleXSpan._m7.native == global::System.IntPtr.Zero)
				global::android.text.style.ScaleXSpan._m7 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ScaleXSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ScaleXSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ScaleXSpan"));
		}
	}
}
