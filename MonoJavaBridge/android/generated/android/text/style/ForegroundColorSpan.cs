namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ForegroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ForegroundColorSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13482;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._writeToParcel13482.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._writeToParcel13482 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._writeToParcel13482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13483;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._describeContents13483.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._describeContents13483 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._describeContents13483);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13484;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._getSpanTypeId13484.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._getSpanTypeId13484 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "getSpanTypeId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._getSpanTypeId13484);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13485;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._updateDrawState13485.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._updateDrawState13485 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._updateDrawState13485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ForegroundColor
		{
			get
			{
				return getForegroundColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getForegroundColor13486;
		public virtual int getForegroundColor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._getForegroundColor13486.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._getForegroundColor13486 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "getForegroundColor", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._getForegroundColor13486);
		}
		internal static global::MonoJavaBridge.MethodId _ForegroundColorSpan13487;
		public ForegroundColorSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13487.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13487 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ForegroundColorSpan13488;
		public ForegroundColorSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13488.native == global::System.IntPtr.Zero)
				global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13488 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ForegroundColorSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ForegroundColorSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ForegroundColorSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
