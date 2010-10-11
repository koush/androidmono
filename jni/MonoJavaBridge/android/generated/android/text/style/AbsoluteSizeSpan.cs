namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AbsoluteSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsoluteSizeSpan()
		{
			InitJNI();
		}
		protected AbsoluteSizeSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSize8200;
		public virtual int getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._getSize8200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSize8200);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8201;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._writeToParcel8201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._writeToParcel8201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8202;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._describeContents8202);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._describeContents8202);
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8203;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId8203);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId8203);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8204;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._updateDrawState8204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateDrawState8204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDip8205;
		public virtual bool getDip() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._getDip8205);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getDip8205);
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8206;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._updateMeasureState8206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateMeasureState8206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan8207;
		public AbsoluteSizeSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan8208;
		public AbsoluteSizeSpan(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan8209;
		public AbsoluteSizeSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AbsoluteSizeSpan"));
			global::android.text.style.AbsoluteSizeSpan._getSize8200 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I");
			global::android.text.style.AbsoluteSizeSpan._writeToParcel8201 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.AbsoluteSizeSpan._describeContents8202 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I");
			global::android.text.style.AbsoluteSizeSpan._getSpanTypeId8203 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.AbsoluteSizeSpan._updateDrawState8204 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._getDip8205 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z");
			global::android.text.style.AbsoluteSizeSpan._updateMeasureState8206 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8207 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8208 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8209 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
