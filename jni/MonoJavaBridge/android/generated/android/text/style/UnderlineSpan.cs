namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnderlineSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UnderlineSpan()
		{
			InitJNI();
		}
		protected UnderlineSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8946;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.UnderlineSpan._writeToParcel8946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._writeToParcel8946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8947;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.UnderlineSpan._describeContents8947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._describeContents8947);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8948;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.UnderlineSpan._getSpanTypeId8948);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._getSpanTypeId8948);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8949;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.UnderlineSpan._updateDrawState8949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._updateDrawState8949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _UnderlineSpan8950;
		public UnderlineSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._UnderlineSpan8950);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UnderlineSpan8951;
		public UnderlineSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._UnderlineSpan8951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.UnderlineSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/UnderlineSpan"));
			global::android.text.style.UnderlineSpan._writeToParcel8946 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.UnderlineSpan._describeContents8947 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "describeContents", "()I");
			global::android.text.style.UnderlineSpan._getSpanTypeId8948 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.UnderlineSpan._updateDrawState8949 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.UnderlineSpan._UnderlineSpan8950 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "<init>", "()V");
			global::android.text.style.UnderlineSpan._UnderlineSpan8951 = @__env.GetMethodIDNoThrow(global::android.text.style.UnderlineSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
