namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RelativeSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RelativeSizeSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13545;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.RelativeSizeSpan._writeToParcel13545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13546;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, "describeContents", "()I", ref global::android.text.style.RelativeSizeSpan._describeContents13546);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13547;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.RelativeSizeSpan._getSpanTypeId13547);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13548;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.RelativeSizeSpan._updateDrawState13548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13549;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.RelativeSizeSpan._updateMeasureState13549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float SizeChange
		{
			get
			{
				return getSizeChange();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSizeChange13550;
		public virtual float getSizeChange()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, "getSizeChange", "()F", ref global::android.text.style.RelativeSizeSpan._getSizeChange13550);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeSizeSpan13551;
		public RelativeSizeSpan(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.RelativeSizeSpan._RelativeSizeSpan13551.native == global::System.IntPtr.Zero)
				global::android.text.style.RelativeSizeSpan._RelativeSizeSpan13551 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._RelativeSizeSpan13551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeSizeSpan13552;
		public RelativeSizeSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.RelativeSizeSpan._RelativeSizeSpan13552.native == global::System.IntPtr.Zero)
				global::android.text.style.RelativeSizeSpan._RelativeSizeSpan13552 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._RelativeSizeSpan13552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RelativeSizeSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.RelativeSizeSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/RelativeSizeSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
