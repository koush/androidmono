namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PackageStats : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static PackageStats()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PackageStats), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.PackageStats(@__env);
			}
		}
		protected PackageStats(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1950;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PackageStats._toString1950));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._toString1950));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1951;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PackageStats._writeToParcel1951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._writeToParcel1951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1952;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.PackageStats._describeContents1952);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._describeContents1952);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageStats1953;
		public PackageStats(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats1953, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageStats1954;
		public PackageStats(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats1954, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageStats1955;
		public PackageStats(android.content.pm.PackageStats arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageStats.staticClass, global::android.content.pm.PackageStats._PackageStats1955, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _packageName1956;
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
		internal static global::net.sf.jni4net.jni.FieldId _codeSize1957;
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
		internal static global::net.sf.jni4net.jni.FieldId _dataSize1958;
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
		internal static global::net.sf.jni4net.jni.FieldId _cacheSize1959;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1960;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.PackageStats.staticClass = @__class;
			global::android.content.pm.PackageStats._toString1950 = @__env.GetMethodID(global::android.content.pm.PackageStats.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PackageStats._writeToParcel1951 = @__env.GetMethodID(global::android.content.pm.PackageStats.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageStats._describeContents1952 = @__env.GetMethodID(global::android.content.pm.PackageStats.staticClass, "describeContents", "()I");
			global::android.content.pm.PackageStats._PackageStats1953 = @__env.GetMethodID(global::android.content.pm.PackageStats.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.content.pm.PackageStats._PackageStats1954 = @__env.GetMethodID(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.content.pm.PackageStats._PackageStats1955 = @__env.GetMethodID(global::android.content.pm.PackageStats.staticClass, "<init>", "(Landroid/content/pm/PackageStats;)V");
		}
	}
}
