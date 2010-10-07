namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PackageInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static PackageInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PackageInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.PackageInfo(@__env);
			}
		}
		protected PackageInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1846;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PackageInfo._toString1846));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._toString1846));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1847;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PackageInfo._writeToParcel1847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._writeToParcel1847, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1848;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.PackageInfo._describeContents1848);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._describeContents1848);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PackageInfo1849;
		public PackageInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PackageInfo.staticClass, global::android.content.pm.PackageInfo._PackageInfo1849, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _packageName1850;
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
		internal static global::net.sf.jni4net.jni.FieldId _versionCode1851;
		public int versionCode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _versionName1852;
		public global::java.lang.String versionName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _sharedUserId1853;
		public global::java.lang.String sharedUserId
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _sharedUserLabel1854;
		public int sharedUserLabel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _applicationInfo1855;
		public global::android.content.pm.ApplicationInfo applicationInfo
		{
			get
			{
				return default(global::android.content.pm.ApplicationInfo);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _gids1856;
		public int[] gids
		{
			get
			{
				return default(int[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _activities1857;
		public global::android.content.pm.ActivityInfo[] activities
		{
			get
			{
				return default(global::android.content.pm.ActivityInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _receivers1858;
		public global::android.content.pm.ActivityInfo[] receivers
		{
			get
			{
				return default(global::android.content.pm.ActivityInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _services1859;
		public global::android.content.pm.ServiceInfo[] services
		{
			get
			{
				return default(global::android.content.pm.ServiceInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _providers1860;
		public global::android.content.pm.ProviderInfo[] providers
		{
			get
			{
				return default(global::android.content.pm.ProviderInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _instrumentation1861;
		public global::android.content.pm.InstrumentationInfo[] instrumentation
		{
			get
			{
				return default(global::android.content.pm.InstrumentationInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _permissions1862;
		public global::android.content.pm.PermissionInfo[] permissions
		{
			get
			{
				return default(global::android.content.pm.PermissionInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _requestedPermissions1863;
		public global::java.lang.String[] requestedPermissions
		{
			get
			{
				return default(global::java.lang.String[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _signatures1864;
		public global::android.content.pm.Signature[] signatures
		{
			get
			{
				return default(global::android.content.pm.Signature[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _configPreferences1865;
		public global::android.content.pm.ConfigurationInfo[] configPreferences
		{
			get
			{
				return default(global::android.content.pm.ConfigurationInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _reqFeatures1866;
		public global::android.content.pm.FeatureInfo[] reqFeatures
		{
			get
			{
				return default(global::android.content.pm.FeatureInfo[]);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1867;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.PackageInfo.staticClass = @__class;
			global::android.content.pm.PackageInfo._toString1846 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PackageInfo._writeToParcel1847 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PackageInfo._describeContents1848 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PackageInfo._PackageInfo1849 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "<init>", "()V");
		}
	}
}
