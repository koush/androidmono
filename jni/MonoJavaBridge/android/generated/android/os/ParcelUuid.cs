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
		internal static global::MonoJavaBridge.MethodId _equals6651;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.ParcelUuid._equals6651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._equals6651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString6652;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.ParcelUuid._toString6652)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._toString6652)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode6653;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ParcelUuid._hashCode6653);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._hashCode6653);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6654;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelUuid._writeToParcel6654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._writeToParcel6654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6655;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ParcelUuid._describeContents6655);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._describeContents6655);
		}
		internal static global::MonoJavaBridge.MethodId _fromString6656;
		public static global::android.os.ParcelUuid fromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._fromString6656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.ParcelUuid;
		}
		public new global::java.util.UUID Uuid
		{
			get
			{
				return getUuid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUuid6657;
		public global::java.util.UUID getUuid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.ParcelUuid._getUuid6657)) as java.util.UUID;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._getUuid6657)) as java.util.UUID;
		}
		internal static global::MonoJavaBridge.MethodId _ParcelUuid6658;
		public ParcelUuid(java.util.UUID arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelUuid.staticClass, global::android.os.ParcelUuid._ParcelUuid6658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6659;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelUuid.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelUuid"));
			global::android.os.ParcelUuid._equals6651 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.os.ParcelUuid._toString6652 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.ParcelUuid._hashCode6653 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "hashCode", "()I");
			global::android.os.ParcelUuid._writeToParcel6654 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ParcelUuid._describeContents6655 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "describeContents", "()I");
			global::android.os.ParcelUuid._fromString6656 = @__env.GetStaticMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;");
			global::android.os.ParcelUuid._getUuid6657 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "getUuid", "()Ljava/util/UUID;");
			global::android.os.ParcelUuid._ParcelUuid6658 = @__env.GetMethodIDNoThrow(global::android.os.ParcelUuid.staticClass, "<init>", "(Ljava/util/UUID;)V");
		}
	}
}
