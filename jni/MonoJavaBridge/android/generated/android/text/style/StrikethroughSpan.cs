namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StrikethroughSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StrikethroughSpan()
		{
			InitJNI();
		}
		protected StrikethroughSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8886;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan._writeToParcel8886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._writeToParcel8886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8887;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan._describeContents8887);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._describeContents8887);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8888;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan._getSpanTypeId8888);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._getSpanTypeId8888);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8889;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan._updateDrawState8889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._updateDrawState8889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StrikethroughSpan8890;
		public StrikethroughSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._StrikethroughSpan8890);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StrikethroughSpan8891;
		public StrikethroughSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._StrikethroughSpan8891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.StrikethroughSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/StrikethroughSpan"));
			global::android.text.style.StrikethroughSpan._writeToParcel8886 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.StrikethroughSpan._describeContents8887 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "describeContents", "()I");
			global::android.text.style.StrikethroughSpan._getSpanTypeId8888 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.StrikethroughSpan._updateDrawState8889 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.StrikethroughSpan._StrikethroughSpan8890 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "()V");
			global::android.text.style.StrikethroughSpan._StrikethroughSpan8891 = @__env.GetMethodIDNoThrow(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
