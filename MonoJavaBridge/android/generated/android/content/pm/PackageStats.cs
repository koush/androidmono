namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageStats : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3966;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._toString3966.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._toString3966 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._toString3966) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3967;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._writeToParcel3967.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._writeToParcel3967 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._writeToParcel3967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3968;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._describeContents3968.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._describeContents3968 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._describeContents3968);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats3969;
		public PackageStats(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._PackageStats3969.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._PackageStats3969 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats3969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats3970;
		public PackageStats(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._PackageStats3970.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._PackageStats3970 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats3970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats3971;
		public PackageStats(android.content.pm.PackageStats arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._PackageStats3971.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._PackageStats3971 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/content/pm/PackageStats;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats3971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName3972;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3972)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _codeSize3973;
		public long codeSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _codeSize3973);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataSize3974;
		public long dataSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _dataSize3974);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _cacheSize3975;
		public long cacheSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _cacheSize3975);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3976;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PackageStats.staticClass, _CREATOR3976)) as android.os.Parcelable_Creator;
			}
		}
		static PackageStats()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageStats"));
			global::android.content.pm.PackageStats._packageName3972 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageStats._codeSize3973 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "codeSize", "J");
			global::android.content.pm.PackageStats._dataSize3974 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "dataSize", "J");
			global::android.content.pm.PackageStats._cacheSize3975 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "cacheSize", "J");
			global::android.content.pm.PackageStats._CREATOR3976 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
