namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ParcelUuid : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ParcelUuid(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals10102;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.ParcelUuid.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.os.ParcelUuid._equals10102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString10103;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.ParcelUuid.staticClass, "toString", "()Ljava/lang/String;", ref global::android.os.ParcelUuid._toString10103) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode10104;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.ParcelUuid.staticClass, "hashCode", "()I", ref global::android.os.ParcelUuid._hashCode10104);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10105;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.ParcelUuid.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.ParcelUuid._writeToParcel10105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10106;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.ParcelUuid.staticClass, "describeContents", "()I", ref global::android.os.ParcelUuid._describeContents10106);
		}
		internal static global::MonoJavaBridge.MethodId _fromString10107;
		public static global::android.os.ParcelUuid fromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelUuid._fromString10107.native == global::System.IntPtr.Zero)
				global::android.os.ParcelUuid._fromString10107 = @__env.GetStaticMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.ParcelUuid>(@__env.CallStaticObjectMethod(android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._fromString10107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.ParcelUuid;
		}
		public new global::java.util.UUID Uuid
		{
			get
			{
				return getUuid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUuid10108;
		public global::java.util.UUID getUuid()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.UUID>(this, global::android.os.ParcelUuid.staticClass, "getUuid", "()Ljava/util/UUID;", ref global::android.os.ParcelUuid._getUuid10108) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _ParcelUuid10109;
		public ParcelUuid(java.util.UUID arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.ParcelUuid._ParcelUuid10109.native == global::System.IntPtr.Zero)
				global::android.os.ParcelUuid._ParcelUuid10109 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "<init>", "(Ljava/util/UUID;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._ParcelUuid10109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10110;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.ParcelUuid.staticClass, _CREATOR10110)) as android.os.Parcelable_Creator;
			}
		}
		static ParcelUuid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelUuid.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelUuid"));
			global::android.os.ParcelUuid._CREATOR10110 = @__env.GetStaticFieldIDNoThrow(global::android.os.ParcelUuid.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
