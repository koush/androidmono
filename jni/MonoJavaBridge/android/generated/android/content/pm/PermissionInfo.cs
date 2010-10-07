namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PermissionInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static PermissionInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PermissionInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.PermissionInfo(@__env);
			}
		}
		protected PermissionInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1976;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PermissionInfo._toString1976));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._toString1976));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1977;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PermissionInfo._writeToParcel1977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._writeToParcel1977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1978;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.PermissionInfo._describeContents1978);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._describeContents1978);
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription1979;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PermissionInfo._loadDescription1979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._loadDescription1979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PermissionInfo1980;
		public PermissionInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._PermissionInfo1980, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PermissionInfo1981;
		public PermissionInfo(android.content.pm.PermissionInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._PermissionInfo1981, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int PROTECTION_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int PROTECTION_DANGEROUS
		{
			get
			{
				return 1;
			}
		}
		public static int PROTECTION_SIGNATURE
		{
			get
			{
				return 2;
			}
		}
		public static int PROTECTION_SIGNATURE_OR_SYSTEM
		{
			get
			{
				return 3;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _group1982;
		public global::java.lang.String group
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1983;
		public int descriptionRes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedDescription1984;
		public global::java.lang.CharSequence nonLocalizedDescription
		{
			get
			{
				return default(global::java.lang.CharSequence);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _protectionLevel1985;
		public int protectionLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1986;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.PermissionInfo.staticClass = @__class;
			global::android.content.pm.PermissionInfo._toString1976 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PermissionInfo._writeToParcel1977 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PermissionInfo._describeContents1978 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PermissionInfo._loadDescription1979 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionInfo._PermissionInfo1980 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PermissionInfo._PermissionInfo1981 = @__env.GetMethodID(global::android.content.pm.PermissionInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionInfo;)V");
		}
	}
}
