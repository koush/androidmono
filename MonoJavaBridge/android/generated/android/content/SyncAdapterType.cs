namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncAdapterType : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncAdapterType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3532;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._equals3532.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._equals3532 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._equals3532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString3533;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._toString3533.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._toString3533 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._toString3533) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode3534;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._hashCode3534.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._hashCode3534 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._hashCode3534);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUploading3535;
		public virtual bool supportsUploading()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._supportsUploading3535.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._supportsUploading3535 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "supportsUploading", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._supportsUploading3535);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3536;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._writeToParcel3536.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._writeToParcel3536 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._writeToParcel3536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3537;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._describeContents3537.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._describeContents3537 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._describeContents3537);
		}
		internal static global::MonoJavaBridge.MethodId _newKey3538;
		public static global::android.content.SyncAdapterType newKey(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._newKey3538.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._newKey3538 = @__env.GetStaticMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._newKey3538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SyncAdapterType;
		}
		internal static global::MonoJavaBridge.MethodId _isUserVisible3539;
		public virtual bool isUserVisible()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._isUserVisible3539.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._isUserVisible3539 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "isUserVisible", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._isUserVisible3539);
		}
		internal static global::MonoJavaBridge.MethodId _SyncAdapterType3540;
		public SyncAdapterType(java.lang.String arg0, java.lang.String arg1, bool arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._SyncAdapterType3540.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._SyncAdapterType3540 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType3540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SyncAdapterType3541;
		public SyncAdapterType(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._SyncAdapterType3541.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._SyncAdapterType3541 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType3541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority3542;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority3542)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountType3543;
		public global::java.lang.String accountType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _accountType3543)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _isKey3544;
		public bool isKey
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isKey3544);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3545;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncAdapterType.staticClass, _CREATOR3545)) as android.os.Parcelable_Creator;
			}
		}
		static SyncAdapterType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncAdapterType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncAdapterType"));
			global::android.content.SyncAdapterType._authority3542 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.SyncAdapterType._accountType3543 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "accountType", "Ljava/lang/String;");
			global::android.content.SyncAdapterType._isKey3544 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "isKey", "Z");
			global::android.content.SyncAdapterType._CREATOR3545 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
