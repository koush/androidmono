namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StrikethroughSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StrikethroughSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13568;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.StrikethroughSpan._writeToParcel13568.native == global::System.IntPtr.Zero)
				global::android.text.style.StrikethroughSpan._writeToParcel13568 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._writeToParcel13568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13569;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.StrikethroughSpan._describeContents13569.native == global::System.IntPtr.Zero)
				global::android.text.style.StrikethroughSpan._describeContents13569 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._describeContents13569);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13570;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.StrikethroughSpan._getSpanTypeId13570.native == global::System.IntPtr.Zero)
				global::android.text.style.StrikethroughSpan._getSpanTypeId13570 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "getSpanTypeId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._getSpanTypeId13570);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13571;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.StrikethroughSpan._updateDrawState13571.native == global::System.IntPtr.Zero)
				global::android.text.style.StrikethroughSpan._updateDrawState13571 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._updateDrawState13571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StrikethroughSpan13572;
		public StrikethroughSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.StrikethroughSpan._StrikethroughSpan13572.native == global::System.IntPtr.Zero)
				global::android.text.style.StrikethroughSpan._StrikethroughSpan13572 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._StrikethroughSpan13572);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StrikethroughSpan13573;
		public StrikethroughSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.StrikethroughSpan._StrikethroughSpan13573.native == global::System.IntPtr.Zero)
				global::android.text.style.StrikethroughSpan._StrikethroughSpan13573 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._StrikethroughSpan13573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StrikethroughSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.StrikethroughSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/StrikethroughSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
