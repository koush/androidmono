namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SubscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SubscriptSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13582;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.SubscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.SubscriptSpan._writeToParcel13582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13583;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.SubscriptSpan.staticClass, "describeContents", "()I", ref global::android.text.style.SubscriptSpan._describeContents13583);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13584;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.SubscriptSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.SubscriptSpan._getSpanTypeId13584);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13585;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.SubscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.SubscriptSpan._updateDrawState13585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13586;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.SubscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.SubscriptSpan._updateMeasureState13586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SubscriptSpan13587;
		public SubscriptSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.SubscriptSpan._SubscriptSpan13587.native == global::System.IntPtr.Zero)
				global::android.text.style.SubscriptSpan._SubscriptSpan13587 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._SubscriptSpan13587);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SubscriptSpan13588;
		public SubscriptSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.SubscriptSpan._SubscriptSpan13588.native == global::System.IntPtr.Zero)
				global::android.text.style.SubscriptSpan._SubscriptSpan13588 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._SubscriptSpan13588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SubscriptSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.SubscriptSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/SubscriptSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
