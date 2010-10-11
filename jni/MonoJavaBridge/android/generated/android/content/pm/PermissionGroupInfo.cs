namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PermissionGroupInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PermissionGroupInfo()
		{
			InitJNI();
		}
		protected PermissionGroupInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2121;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._toString2121)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._toString2121)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2122;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._writeToParcel2122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._writeToParcel2122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2123;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._describeContents2123);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._describeContents2123);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription2124;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._loadDescription2124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._loadDescription2124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _PermissionGroupInfo2125;
		public PermissionGroupInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo2125);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionGroupInfo2126;
		public PermissionGroupInfo(android.content.pm.PermissionGroupInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo2126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes2127;
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
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription2128;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR2129;
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
			global::android.content.pm.PermissionGroupInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionGroupInfo"));
			global::android.content.pm.PermissionGroupInfo._toString2121 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PermissionGroupInfo._writeToParcel2122 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PermissionGroupInfo._describeContents2123 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PermissionGroupInfo._loadDescription2124 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo2125 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo2126 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionGroupInfo;)V");
		}
	}
}
