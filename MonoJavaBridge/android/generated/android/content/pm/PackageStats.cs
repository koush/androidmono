namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageStats : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PackageStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.pm.PackageStats.staticClass, "toString", "()Ljava/lang/String;", ref global::android.content.pm.PackageStats._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.pm.PackageStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.content.pm.PackageStats._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.pm.PackageStats.staticClass, "describeContents", "()I", ref global::android.content.pm.PackageStats._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PackageStats(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._m3.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._m3 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PackageStats(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._m4.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._m4 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PackageStats(android.content.pm.PackageStats arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.pm.PackageStats._m5.native == global::System.IntPtr.Zero)
				global::android.content.pm.PackageStats._m5 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/content/pm/PackageStats;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName2085;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName2085)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _codeSize2086;
		public long codeSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _codeSize2086);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataSize2087;
		public long dataSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _dataSize2087);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _cacheSize2088;
		public long cacheSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _cacheSize2088);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2089;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PackageStats.staticClass, _CREATOR2089)) as android.os.Parcelable_Creator;
			}
		}
		static PackageStats()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageStats"));
			global::android.content.pm.PackageStats._packageName2085 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageStats._codeSize2086 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "codeSize", "J");
			global::android.content.pm.PackageStats._dataSize2087 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "dataSize", "J");
			global::android.content.pm.PackageStats._cacheSize2088 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "cacheSize", "J");
			global::android.content.pm.PackageStats._CREATOR2089 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
