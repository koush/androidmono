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
		internal static global::MonoJavaBridge.MethodId _toString2104;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PackageStats._toString2104)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._toString2104)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2105;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PackageStats._writeToParcel2105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._writeToParcel2105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2106;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PackageStats._describeContents2106);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._describeContents2106);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats2107;
		public PackageStats(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats2107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats2108;
		public PackageStats(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats2108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PackageStats2109;
		public PackageStats(android.content.pm.PackageStats arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats2109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _packageName2110;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _codeSize2111;
		public long codeSize
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dataSize2112;
		public long dataSize
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _cacheSize2113;
		public long cacheSize
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2114;
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
			global::android.content.pm.PackageStats.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PackageStats"));
			global::android.content.pm.PackageStats._toString2104 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PackageStats._writeToParcel2105 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageStats._describeContents2106 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "describeContents", "()I");
			global::android.content.pm.PackageStats._PackageStats2107 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageStats._PackageStats2108 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.PackageStats._PackageStats2109 = @__env.GetMethodIDNoThrow(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/content/pm/PackageStats;)V");
		}
	}
}
