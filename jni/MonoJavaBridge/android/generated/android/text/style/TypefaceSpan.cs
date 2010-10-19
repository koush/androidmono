namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypefaceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypefaceSpan()
		{
			InitJNI();
		}
		protected TypefaceSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel8931;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._writeToParcel8931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._writeToParcel8931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents8932;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._describeContents8932);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._describeContents8932);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId8933;
		public virtual int getSpanTypeId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._getSpanTypeId8933);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._getSpanTypeId8933);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState8934;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._updateDrawState8934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._updateDrawState8934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState8935;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._updateMeasureState8935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._updateMeasureState8935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Family
		{
			get
			{
				return getFamily();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFamily8936;
		public virtual global::java.lang.String getFamily() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.style.TypefaceSpan._getFamily8936)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._getFamily8936)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TypefaceSpan8937;
		public TypefaceSpan(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._TypefaceSpan8937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TypefaceSpan8938;
		public TypefaceSpan(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._TypefaceSpan8938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TypefaceSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TypefaceSpan"));
			global::android.text.style.TypefaceSpan._writeToParcel8931 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.TypefaceSpan._describeContents8932 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "describeContents", "()I");
			global::android.text.style.TypefaceSpan._getSpanTypeId8933 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.TypefaceSpan._updateDrawState8934 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TypefaceSpan._updateMeasureState8935 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TypefaceSpan._getFamily8936 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "getFamily", "()Ljava/lang/String;");
			global::android.text.style.TypefaceSpan._TypefaceSpan8937 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.style.TypefaceSpan._TypefaceSpan8938 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
