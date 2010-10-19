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
		internal static global::MonoJavaBridge.MethodId _writeToParcel8907;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._writeToParcel8907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._writeToParcel8907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8908;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._describeContents8908);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._describeContents8908);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8909;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._getSpanTypeId8909);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._getSpanTypeId8909);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8910;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._updateDrawState8910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateDrawState8910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8911;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan._updateMeasureState8911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateMeasureState8911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SuperscriptSpan8912;
		public SuperscriptSpan()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan8912);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SuperscriptSpan8913;
		public SuperscriptSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan8913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.SuperscriptSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/SuperscriptSpan"));
			global::android.text.style.SuperscriptSpan._writeToParcel8907 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.SuperscriptSpan._describeContents8908 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "describeContents", "()I");
			global::android.text.style.SuperscriptSpan._getSpanTypeId8909 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.SuperscriptSpan._updateDrawState8910 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._updateMeasureState8911 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan8912 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "()V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan8913 = @__env.GetMethodIDNoThrow(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
