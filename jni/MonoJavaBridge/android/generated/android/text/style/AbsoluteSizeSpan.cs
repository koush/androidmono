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
		public new int Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize8746;
		public virtual int getSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._getSize8746);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSize8746);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8747;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._writeToParcel8747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._writeToParcel8747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8748;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._describeContents8748);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._describeContents8748);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8749;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId8749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId8749);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8750;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._updateDrawState8750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateDrawState8750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Dip
		{
			get
			{
				return getDip();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDip8751;
		public virtual bool getDip() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._getDip8751);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getDip8751);
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8752;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan._updateMeasureState8752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateMeasureState8752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan8753;
		public AbsoluteSizeSpan(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan8754;
		public AbsoluteSizeSpan(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan8755;
		public AbsoluteSizeSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AbsoluteSizeSpan"));
			global::android.text.style.AbsoluteSizeSpan._getSize8746 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I");
			global::android.text.style.AbsoluteSizeSpan._writeToParcel8747 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.AbsoluteSizeSpan._describeContents8748 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I");
			global::android.text.style.AbsoluteSizeSpan._getSpanTypeId8749 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.AbsoluteSizeSpan._updateDrawState8750 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._getDip8751 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z");
			global::android.text.style.AbsoluteSizeSpan._updateMeasureState8752 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8753 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8754 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan8755 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
