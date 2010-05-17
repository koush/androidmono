namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PackageInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static PackageInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PackageInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString1626; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1626)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PackageInfo.staticClass, _toString1626)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1627; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PackageInfo.staticClass, _writeToParcel1627, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1628; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PackageInfo)) 
				return @__env.CallIntMethod(this, _describeContents1628); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.PackageInfo.staticClass, _describeContents1628); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PackageInfo1629; 
		public PackageInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PackageInfo.staticClass, _PackageInfo1629, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _packageName1630; 
		public java.lang.String packageName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _versionCode1631; 
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
		internal static global::net.sf.jni4net.jni.FieldId _versionName1632; 
		public java.lang.String versionName
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sharedUserId1633; 
		public java.lang.String sharedUserId
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sharedUserLabel1634; 
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
		internal static global::net.sf.jni4net.jni.FieldId _applicationInfo1635; 
		public android.content.pm.ApplicationInfo applicationInfo
		{ 
			get 
			{ 
				return default(android.content.pm.ApplicationInfo); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _gids1636; 
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
		internal static global::net.sf.jni4net.jni.FieldId _activities1637; 
		public android.content.pm.ActivityInfo[] activities
		{ 
			get 
			{ 
				return default(android.content.pm.ActivityInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _receivers1638; 
		public android.content.pm.ActivityInfo[] receivers
		{ 
			get 
			{ 
				return default(android.content.pm.ActivityInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _services1639; 
		public android.content.pm.ServiceInfo[] services
		{ 
			get 
			{ 
				return default(android.content.pm.ServiceInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _providers1640; 
		public android.content.pm.ProviderInfo[] providers
		{ 
			get 
			{ 
				return default(android.content.pm.ProviderInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _instrumentation1641; 
		public android.content.pm.InstrumentationInfo[] instrumentation
		{ 
			get 
			{ 
				return default(android.content.pm.InstrumentationInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _permissions1642; 
		public android.content.pm.PermissionInfo[] permissions
		{ 
			get 
			{ 
				return default(android.content.pm.PermissionInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _requestedPermissions1643; 
		public java.lang.String[] requestedPermissions
		{ 
			get 
			{ 
				return default(java.lang.String[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _signatures1644; 
		public android.content.pm.Signature[] signatures
		{ 
			get 
			{ 
				return default(android.content.pm.Signature[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _configPreferences1645; 
		public android.content.pm.ConfigurationInfo[] configPreferences
		{ 
			get 
			{ 
				return default(android.content.pm.ConfigurationInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _reqFeatures1646; 
		public android.content.pm.FeatureInfo[] reqFeatures
		{ 
			get 
			{ 
				return default(android.content.pm.FeatureInfo[]); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1647; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.PackageInfo.staticClass = @__class; 
			global::android.content.pm.PackageInfo._toString1626 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.PackageInfo._writeToParcel1627 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.PackageInfo._describeContents1628 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.PackageInfo._PackageInfo1629 = @__env.GetMethodID(global::android.content.pm.PackageInfo.staticClass, "<init>", "()V"); 
		} 
	} 
} 
