namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackgroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackgroundColorSpan()
		{
			InitJNI();
		}
		protected BackgroundColorSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8763;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._writeToParcel8763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._writeToParcel8763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8764;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._describeContents8764);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._describeContents8764);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8765;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._getSpanTypeId8765);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._getSpanTypeId8765);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8766;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._updateDrawState8766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._updateDrawState8766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BackgroundColor
		{
			get
			{
				return getBackgroundColor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBackgroundColor8767;
		public virtual int getBackgroundColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan._getBackgroundColor8767);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._getBackgroundColor8767);
		}
		internal static global::MonoJavaBridge.MethodId _BackgroundColorSpan8768;
		public BackgroundColorSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._BackgroundColorSpan8768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BackgroundColorSpan8769;
		public BackgroundColorSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._BackgroundColorSpan8769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.BackgroundColorSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/BackgroundColorSpan"));
			global::android.text.style.BackgroundColorSpan._writeToParcel8763 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.BackgroundColorSpan._describeContents8764 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "describeContents", "()I");
			global::android.text.style.BackgroundColorSpan._getSpanTypeId8765 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.BackgroundColorSpan._updateDrawState8766 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.BackgroundColorSpan._getBackgroundColor8767 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "getBackgroundColor", "()I");
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan8768 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan8769 = @__env.GetMethodIDNoThrow(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
