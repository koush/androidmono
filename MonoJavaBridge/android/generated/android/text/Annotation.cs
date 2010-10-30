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
		internal static global::MonoJavaBridge.MethodId _getValue12685;
		public virtual global::java.lang.String getValue()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._getValue12685)) as java.lang.String;
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey12686;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._getKey12686)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel12687;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._writeToParcel12687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents12688;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._describeContents12688);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId12689;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.Annotation.staticClass, global::android.text.Annotation._getSpanTypeId12689);
		}
		internal static global::MonoJavaBridge.MethodId _Annotation12690;
		public Annotation(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._Annotation12690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Annotation12691;
		public Annotation(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.Annotation.staticClass, global::android.text.Annotation._Annotation12691, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Annotation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Annotation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Annotation"));
			global::android.text.Annotation._getValue12685 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "getValue", "()Ljava/lang/String;");
			global::android.text.Annotation._getKey12686 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.text.Annotation._writeToParcel12687 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.Annotation._describeContents12688 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "describeContents", "()I");
			global::android.text.Annotation._getSpanTypeId12689 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "getSpanTypeId", "()I");
			global::android.text.Annotation._Annotation12690 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.text.Annotation._Annotation12691 = @__env.GetMethodIDNoThrow(global::android.text.Annotation.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
