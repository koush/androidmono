namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SubscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SubscriptSpan()
		{
			InitJNI();
		}
		protected SubscriptSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13520;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SubscriptSpan._writeToParcel13520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._writeToParcel13520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13521;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.SubscriptSpan._describeContents13521);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._describeContents13521);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13522;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.SubscriptSpan._getSpanTypeId13522);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._getSpanTypeId13522);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13523;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SubscriptSpan._updateDrawState13523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._updateDrawState13523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13524;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SubscriptSpan._updateMeasureState13524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._updateMeasureState13524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SubscriptSpan13525;
		public SubscriptSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._SubscriptSpan13525);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SubscriptSpan13526;
		public SubscriptSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._SubscriptSpan13526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.SubscriptSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/SubscriptSpan"));
			global::android.text.style.SubscriptSpan._writeToParcel13520 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.SubscriptSpan._describeContents13521 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "describeContents", "()I");
			global::android.text.style.SubscriptSpan._getSpanTypeId13522 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.SubscriptSpan._updateDrawState13523 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SubscriptSpan._updateMeasureState13524 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SubscriptSpan._SubscriptSpan13525 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "<init>", "()V");
			global::android.text.style.SubscriptSpan._SubscriptSpan13526 = @__env.GetMethodIDNoThrow(global::android.text.style.SubscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
