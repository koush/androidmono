namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ForegroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ForegroundColorSpan()
		{
			InitJNI();
		}
		protected ForegroundColorSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13420;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan._writeToParcel13420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._writeToParcel13420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13421;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan._describeContents13421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._describeContents13421);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13422;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan._getSpanTypeId13422);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._getSpanTypeId13422);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13423;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan._updateDrawState13423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._updateDrawState13423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ForegroundColor
		{
			get
			{
				return getForegroundColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getForegroundColor13424;
		public virtual int getForegroundColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan._getForegroundColor13424);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._getForegroundColor13424);
		}
		internal static global::MonoJavaBridge.MethodId _ForegroundColorSpan13425;
		public ForegroundColorSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ForegroundColorSpan13426;
		public ForegroundColorSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ForegroundColorSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ForegroundColorSpan"));
			global::android.text.style.ForegroundColorSpan._writeToParcel13420 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.ForegroundColorSpan._describeContents13421 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "describeContents", "()I");
			global::android.text.style.ForegroundColorSpan._getSpanTypeId13422 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.ForegroundColorSpan._updateDrawState13423 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ForegroundColorSpan._getForegroundColor13424 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "getForegroundColor", "()I");
			global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13425 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.ForegroundColorSpan._ForegroundColorSpan13426 = @__env.GetMethodIDNoThrow(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
