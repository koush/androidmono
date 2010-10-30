namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnderlineSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnderlineSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13628;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.UnderlineSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.UnderlineSpan._writeToParcel13628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13629;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.UnderlineSpan.staticClass, "describeContents", "()I", ref global::android.text.style.UnderlineSpan._describeContents13629);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13630;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.UnderlineSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.UnderlineSpan._getSpanTypeId13630);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13631;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.UnderlineSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.UnderlineSpan._updateDrawState13631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _UnderlineSpan13632;
		public UnderlineSpan() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.UnderlineSpan._UnderlineSpan13632.native == global::System.IntPtr.Zero)
				global::android.text.style.UnderlineSpan._UnderlineSpan13632 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._UnderlineSpan13632);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnderlineSpan13633;
		public UnderlineSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.UnderlineSpan._UnderlineSpan13633.native == global::System.IntPtr.Zero)
				global::android.text.style.UnderlineSpan._UnderlineSpan13633 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._UnderlineSpan13633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnderlineSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.UnderlineSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/UnderlineSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
