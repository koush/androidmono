namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncAdapterType : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncAdapterType()
		{
			InitJNI();
		}
		protected SyncAdapterType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals3516;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType._equals3516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._equals3516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString3517;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncAdapterType._toString3517)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._toString3517)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode3518;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncAdapterType._hashCode3518);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._hashCode3518);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUploading3519;
		public virtual bool supportsUploading() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType._supportsUploading3519);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._supportsUploading3519);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3520;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncAdapterType._writeToParcel3520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._writeToParcel3520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3521;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncAdapterType._describeContents3521);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._describeContents3521);
		}
		internal static global::MonoJavaBridge.MethodId _newKey3522;
		public static global::android.content.SyncAdapterType newKey(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._newKey3522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SyncAdapterType;
		}
		internal static global::MonoJavaBridge.MethodId _isUserVisible3523;
		public virtual bool isUserVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType._isUserVisible3523);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._isUserVisible3523);
		}
		internal static global::MonoJavaBridge.MethodId _SyncAdapterType3524;
		public SyncAdapterType(java.lang.String arg0, java.lang.String arg1, bool arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType3524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SyncAdapterType3525;
		public SyncAdapterType(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType3525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority3526;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _authority3526)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountType3527;
		public global::java.lang.String accountType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _accountType3527)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _isKey3528;
		public bool isKey
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isKey3528);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3529;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncAdapterType.staticClass, _CREATOR3529)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncAdapterType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncAdapterType"));
			global::android.content.SyncAdapterType._equals3516 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.SyncAdapterType._toString3517 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncAdapterType._hashCode3518 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "hashCode", "()I");
			global::android.content.SyncAdapterType._supportsUploading3519 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "supportsUploading", "()Z");
			global::android.content.SyncAdapterType._writeToParcel3520 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncAdapterType._describeContents3521 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "describeContents", "()I");
			global::android.content.SyncAdapterType._newKey3522 = @__env.GetStaticMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;");
			global::android.content.SyncAdapterType._isUserVisible3523 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "isUserVisible", "()Z");
			global::android.content.SyncAdapterType._SyncAdapterType3524 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V");
			global::android.content.SyncAdapterType._SyncAdapterType3525 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.SyncAdapterType._authority3526 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.SyncAdapterType._accountType3527 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "accountType", "Ljava/lang/String;");
			global::android.content.SyncAdapterType._isKey3528 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "isKey", "Z");
			global::android.content.SyncAdapterType._CREATOR3529 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
