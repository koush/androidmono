namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypefaceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypefaceSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.TypefaceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.TypefaceSpan._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TypefaceSpan.staticClass, "describeContents", "()I", ref global::android.text.style.TypefaceSpan._m1);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.TypefaceSpan.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.TypefaceSpan._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.TypefaceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.TypefaceSpan._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.TypefaceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V", ref global::android.text.style.TypefaceSpan._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Family
		{
			get
			{
				return getFamily();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getFamily()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.style.TypefaceSpan.staticClass, "getFamily", "()Ljava/lang/String;", ref global::android.text.style.TypefaceSpan._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public TypefaceSpan(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TypefaceSpan._m6.native == global::System.IntPtr.Zero)
				global::android.text.style.TypefaceSpan._m6 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public TypefaceSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.TypefaceSpan._m7.native == global::System.IntPtr.Zero)
				global::android.text.style.TypefaceSpan._m7 = @__env.GetMethodIDNoThrow(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TypefaceSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.TypefaceSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/TypefaceSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
