namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ParcelUuid : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ParcelUuid()
		{
			InitJNI();
		}
		internal ParcelUuid(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals10102;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.ParcelUuid._equals10102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._equals10102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString10103;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.ParcelUuid._toString10103)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._toString10103)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode10104;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ParcelUuid._hashCode10104);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._hashCode10104);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10105;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelUuid._writeToParcel10105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._writeToParcel10105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10106;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ParcelUuid._describeContents10106);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._describeContents10106);
		}
		internal static global::MonoJavaBridge.MethodId _fromString10107;
		public static global::android.os.ParcelUuid fromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.ParcelUuid._getUuid10108)) as java.util.UUID;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.UUID>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._getUuid10108)) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _ParcelUuid10109;
		public ParcelUuid(java.util.UUID arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelUuid.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelUuid"));
			global::android.os.ParcelUuid._equals10102 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.os.ParcelUuid._toString10103 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.ParcelUuid._hashCode10104 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "hashCode", "()I");
			global::android.os.ParcelUuid._writeToParcel10105 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ParcelUuid._describeContents10106 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "describeContents", "()I");
			global::android.os.ParcelUuid._fromString10107 = @__env.GetStaticMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;");
			global::android.os.ParcelUuid._getUuid10108 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "getUuid", "()Ljava/util/UUID;");
			global::android.os.ParcelUuid._ParcelUuid10109 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "<init>", "(Ljava/util/UUID;)V");
			global::android.os.ParcelUuid._CREATOR10110 = @__env.GetStaticFieldIDNoThrow(global::android.os.ParcelUuid.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
