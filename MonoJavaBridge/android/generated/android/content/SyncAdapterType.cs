namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncAdapterType : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncAdapterType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.content.SyncAdapterType._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SyncAdapterType.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.SyncAdapterType._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncAdapterType.staticClass, "hashCode", "()I", ref global::android.content.SyncAdapterType._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool supportsUploading()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, "supportsUploading", "()Z", ref global::android.content.SyncAdapterType._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SyncAdapterType.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.SyncAdapterType._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SyncAdapterType.staticClass, "describeContents", "()I", ref global::android.content.SyncAdapterType._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.content.SyncAdapterType newKey(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._m6.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._m6 = @__env.GetStaticMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SyncAdapterType;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool isUserVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, "isUserVisible", "()Z", ref global::android.content.SyncAdapterType._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public SyncAdapterType(java.lang.String arg0, java.lang.String arg1, bool arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._m8.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._m8 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public SyncAdapterType(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.SyncAdapterType._m9.native == global::System.IntPtr.Zero)
				global::android.content.SyncAdapterType._m9 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority1878;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority1878)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountType1879;
		public global::java.lang.String accountType
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _accountType1879)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _isKey1880;
		public bool isKey
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetBooleanField(this.JvmHandle, _isKey1880);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1881;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.SyncAdapterType.staticClass, _CREATOR1881)) as android.os.Parcelable_Creator;
			}
		}
		static SyncAdapterType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncAdapterType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncAdapterType"));
			global::android.content.SyncAdapterType._authority1878 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.SyncAdapterType._accountType1879 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "accountType", "Ljava/lang/String;");
			global::android.content.SyncAdapterType._isKey1880 = @__env.GetFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "isKey", "Z");
			global::android.content.SyncAdapterType._CREATOR1881 = @__env.GetStaticFieldIDNoThrow(global::android.content.SyncAdapterType.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
