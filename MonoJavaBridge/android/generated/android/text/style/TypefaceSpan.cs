namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypefaceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypefaceSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13613;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._writeToParcel13613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._writeToParcel13613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13614;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._describeContents13614);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._describeContents13614);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13615;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._getSpanTypeId13615);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._getSpanTypeId13615);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13616;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._updateDrawState13616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._updateDrawState13616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13617;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._updateMeasureState13617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._updateMeasureState13617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Family
		{
			get
			{
				return getFamily();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFamily13618;
		public virtual global::java.lang.String getFamily()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._getFamily13618)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._getFamily13618)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TypefaceSpan13619;
		public TypefaceSpan(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._TypefaceSpan13619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TypefaceSpan13620;
		public TypefaceSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._TypefaceSpan13620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TypefaceSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TypefaceSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TypefaceSpan"));
			global::android.text.style.TypefaceSpan._writeToParcel13613 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.TypefaceSpan._describeContents13614 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "describeContents", "()I");
			global::android.text.style.TypefaceSpan._getSpanTypeId13615 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.TypefaceSpan._updateDrawState13616 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TypefaceSpan._updateMeasureState13617 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TypefaceSpan._getFamily13618 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "getFamily", "()Ljava/lang/String;");
			global::android.text.style.TypefaceSpan._TypefaceSpan13619 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.style.TypefaceSpan._TypefaceSpan13620 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
