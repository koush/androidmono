namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleXSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScaleXSpan()
		{
			InitJNI();
		}
		protected ScaleXSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13498;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ScaleXSpan._writeToParcel13498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._writeToParcel13498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13499;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.ScaleXSpan._describeContents13499);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._describeContents13499);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13500;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.ScaleXSpan._getSpanTypeId13500);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._getSpanTypeId13500);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13501;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ScaleXSpan._updateDrawState13501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._updateDrawState13501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13502;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.ScaleXSpan._updateMeasureState13502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._updateMeasureState13502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float ScaleX
		{
			get
			{
				return getScaleX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaleX13503;
		public virtual float getScaleX() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.text.style.ScaleXSpan._getScaleX13503);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._getScaleX13503);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleXSpan13504;
		public ScaleXSpan(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan13504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleXSpan13505;
		public ScaleXSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan13505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.ScaleXSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/ScaleXSpan"));
			global::android.text.style.ScaleXSpan._writeToParcel13498 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.ScaleXSpan._describeContents13499 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "describeContents", "()I");
			global::android.text.style.ScaleXSpan._getSpanTypeId13500 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.ScaleXSpan._updateDrawState13501 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ScaleXSpan._updateMeasureState13502 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ScaleXSpan._getScaleX13503 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "getScaleX", "()F");
			global::android.text.style.ScaleXSpan._ScaleXSpan13504 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(F)V");
			global::android.text.style.ScaleXSpan._ScaleXSpan13505 = @__env.GetMethodIDNoThrow(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
