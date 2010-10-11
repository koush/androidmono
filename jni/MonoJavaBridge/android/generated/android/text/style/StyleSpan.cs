namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StyleSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StyleSpan()
		{
			InitJNI();
		}
		protected StyleSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8346;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.StyleSpan._writeToParcel8346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._writeToParcel8346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8347;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.StyleSpan._describeContents8347);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._describeContents8347);
		}
		internal static global::MonoJavaBridge.MethodId _getStyle8348;
		public virtual int getStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.StyleSpan._getStyle8348);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._getStyle8348);
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8349;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.StyleSpan._getSpanTypeId8349);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._getSpanTypeId8349);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8350;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.StyleSpan._updateDrawState8350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._updateDrawState8350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8351;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.StyleSpan._updateMeasureState8351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._updateMeasureState8351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StyleSpan8352;
		public StyleSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._StyleSpan8352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StyleSpan8353;
		public StyleSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._StyleSpan8353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.StyleSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/StyleSpan"));
			global::android.text.style.StyleSpan._writeToParcel8346 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.StyleSpan._describeContents8347 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "describeContents", "()I");
			global::android.text.style.StyleSpan._getStyle8348 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "getStyle", "()I");
			global::android.text.style.StyleSpan._getSpanTypeId8349 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.StyleSpan._updateDrawState8350 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.StyleSpan._updateMeasureState8351 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.StyleSpan._StyleSpan8352 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.StyleSpan._StyleSpan8353 = @__env.GetMethodIDNoThrow(global::android.text.style.StyleSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
