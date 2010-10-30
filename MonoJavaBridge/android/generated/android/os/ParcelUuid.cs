namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ParcelUuid : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParcelUuid(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.ParcelUuid.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.os.ParcelUuid._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.ParcelUuid.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.ParcelUuid._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.ParcelUuid.staticClass, "hashCode", "()I", ref global::android.os.ParcelUuid._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ParcelUuid.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.ParcelUuid._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.ParcelUuid.staticClass, "describeContents", "()I", ref global::android.os.ParcelUuid._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.os.ParcelUuid fromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelUuid._m5.native == global::System.IntPtr.Zero)
				global::android.os.ParcelUuid._m5 = @__env.GetStaticMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.ParcelUuid>(@__env.CallStaticObjectMethod(android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.ParcelUuid;
		}
		public new global::java.util.UUID Uuid
		{
			get
			{
				return getUuid();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.util.UUID getUuid()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.UUID>(this, global::android.os.ParcelUuid.staticClass, "getUuid", "()Ljava/util/UUID;", ref global::android.os.ParcelUuid._m6) as java.util.UUID;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public ParcelUuid(java.util.UUID arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelUuid._m7.native == global::System.IntPtr.Zero)
				global::android.os.ParcelUuid._m7 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "<init>", "(Ljava/util/UUID;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR4020;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.ParcelUuid.staticClass, _CREATOR4020)) as android.os.Parcelable_Creator;
			}
		}
		static ParcelUuid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelUuid.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelUuid"));
			global::android.os.ParcelUuid._CREATOR4020 = @__env.GetStaticFieldIDNoThrow(global::android.os.ParcelUuid.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
