namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SuperscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SuperscriptSpan()
		{
			InitJNI();
		}
		protected SuperscriptSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13527;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._writeToParcel13527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._writeToParcel13527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13528;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._describeContents13528);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._describeContents13528);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13529;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._getSpanTypeId13529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._getSpanTypeId13529);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13530;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._updateDrawState13530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateDrawState13530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13531;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._updateMeasureState13531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateMeasureState13531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SuperscriptSpan13532;
		public SuperscriptSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan13532);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SuperscriptSpan13533;
		public SuperscriptSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan13533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.SuperscriptSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/SuperscriptSpan"));
			global::android.text.style.SuperscriptSpan._writeToParcel13527 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.SuperscriptSpan._describeContents13528 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "describeContents", "()I");
			global::android.text.style.SuperscriptSpan._getSpanTypeId13529 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.SuperscriptSpan._updateDrawState13530 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._updateMeasureState13531 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan13532 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "()V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan13533 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
