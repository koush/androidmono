namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleXSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScaleXSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13560;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.ScaleXSpan._writeToParcel13560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13561;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, "describeContents", "()I", ref global::android.text.style.ScaleXSpan._describeContents13561);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13562;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.ScaleXSpan._getSpanTypeId13562);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13563;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ScaleXSpan._updateDrawState13563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13564;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.ScaleXSpan._updateMeasureState13564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float ScaleX
		{
			get
			{
				return getScaleX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaleX13565;
		public virtual float getScaleX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.style.ScaleXSpan.staticClass, "getScaleX", "()F", ref global::android.text.style.ScaleXSpan._getScaleX13565);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleXSpan13566;
		public ScaleXSpan(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ScaleXSpan._ScaleXSpan13566.native == global::System.IntPtr.Zero)
				global::android.text.style.ScaleXSpan._ScaleXSpan13566 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan13566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleXSpan13567;
		public ScaleXSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ScaleXSpan._ScaleXSpan13567.native == global::System.IntPtr.Zero)
				global::android.text.style.ScaleXSpan._ScaleXSpan13567 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan13567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ScaleXSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ScaleXSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ScaleXSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
