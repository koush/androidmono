namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PackageStats : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PackageStats()
		{
			InitJNI();
		}
		protected PackageStats(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3949;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageStats._toString3949)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._toString3949)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3950;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageStats._writeToParcel3950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._writeToParcel3950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3951;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageStats._describeContents3951);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._describeContents3951);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats3952;
		public PackageStats(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats3952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats3953;
		public PackageStats(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats3953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats3954;
		public PackageStats(android.content.pm.PackageStats arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats3954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName3955;
		public global::java.lang.String packageName
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _packageName3955)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _codeSize3956;
		public long codeSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _codeSize3956);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataSize3957;
		public long dataSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _dataSize3957);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _cacheSize3958;
		public long cacheSize
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _cacheSize3958);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3959;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PackageStats.staticClass, _CREATOR3959)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PackageStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageStats"));
			global::android.content.pm.PackageStats._toString3949 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PackageStats._writeToParcel3950 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageStats._describeContents3951 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "describeContents", "()I");
			global::android.content.pm.PackageStats._PackageStats3952 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageStats._PackageStats3953 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.PackageStats._PackageStats3954 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/content/pm/PackageStats;)V");
			global::android.content.pm.PackageStats._packageName3955 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "packageName", "Ljava/lang/String;");
			global::android.content.pm.PackageStats._codeSize3956 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "codeSize", "J");
			global::android.content.pm.PackageStats._dataSize3957 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "dataSize", "J");
			global::android.content.pm.PackageStats._cacheSize3958 = @__env.GetFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "cacheSize", "J");
			global::android.content.pm.PackageStats._CREATOR3959 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PackageStats.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
