namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RelativeSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RelativeSizeSpan()
		{
			InitJNI();
		}
		protected RelativeSizeSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8317;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan._writeToParcel8317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._writeToParcel8317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8318;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan._describeContents8318);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._describeContents8318);
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8319;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan._getSpanTypeId8319);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._getSpanTypeId8319);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8320;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan._updateDrawState8320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._updateDrawState8320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8321;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan._updateMeasureState8321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._updateMeasureState8321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSizeChange8322;
		public virtual float getSizeChange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan._getSizeChange8322);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._getSizeChange8322);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeSizeSpan8323;
		public RelativeSizeSpan(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeSizeSpan8324;
		public RelativeSizeSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.RelativeSizeSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/RelativeSizeSpan"));
			global::android.text.style.RelativeSizeSpan._writeToParcel8317 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.RelativeSizeSpan._describeContents8318 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "describeContents", "()I");
			global::android.text.style.RelativeSizeSpan._getSpanTypeId8319 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.RelativeSizeSpan._updateDrawState8320 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.RelativeSizeSpan._updateMeasureState8321 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.RelativeSizeSpan._getSizeChange8322 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "getSizeChange", "()F");
			global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8323 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(F)V");
			global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8324 = @__env.GetMethodIDNoThrow(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
