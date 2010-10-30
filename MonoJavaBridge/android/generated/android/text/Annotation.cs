namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Annotation : java.lang.Object, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Annotation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.Annotation.staticClass, "getValue", "()Ljava/lang/String;", ref global::android.text.Annotation._m0) as java.lang.String;
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.Annotation.staticClass, "getKey", "()Ljava/lang/String;", ref global::android.text.Annotation._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Annotation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.Annotation._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Annotation.staticClass, "describeContents", "()I", ref global::android.text.Annotation._m3);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Annotation.staticClass, "getSpanTypeId", "()I", ref global::android.text.Annotation._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Annotation(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Annotation._m5.native == global::System.IntPtr.Zero)
				global::android.text.Annotation._m5 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public Annotation(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Annotation._m6.native == global::System.IntPtr.Zero)
				global::android.text.Annotation._m6 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Annotation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Annotation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Annotation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
