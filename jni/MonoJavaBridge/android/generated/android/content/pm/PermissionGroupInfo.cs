namespace android.content.pm
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PermissionGroupInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static PermissionGroupInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.pm.PermissionGroupInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.pm.PermissionGroupInfo(@__env);
			}
		}
		protected PermissionGroupInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1967;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PermissionGroupInfo._toString1967));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._toString1967));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1968;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.pm.PermissionGroupInfo._writeToParcel1968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._writeToParcel1968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1969;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.pm.PermissionGroupInfo._describeContents1969);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._describeContents1969);
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription1970;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.pm.PermissionGroupInfo._loadDescription1970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._loadDescription1970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PermissionGroupInfo1971;
		public PermissionGroupInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo1971, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _PermissionGroupInfo1972;
		public PermissionGroupInfo(android.content.pm.PermissionGroupInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo1972, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1973;
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
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedDescription1974;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1975;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.pm.PermissionGroupInfo.staticClass = @__class;
			global::android.content.pm.PermissionGroupInfo._toString1967 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PermissionGroupInfo._writeToParcel1968 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PermissionGroupInfo._describeContents1969 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PermissionGroupInfo._loadDescription1970 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo1971 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo1972 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionGroupInfo;)V");
		}
	}
}
