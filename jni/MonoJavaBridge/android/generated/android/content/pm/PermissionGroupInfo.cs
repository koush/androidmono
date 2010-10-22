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
		internal static global::MonoJavaBridge.MethodId _toString3966;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._toString3966)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._toString3966)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3967;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._writeToParcel3967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._writeToParcel3967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3968;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._describeContents3968);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._describeContents3968);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription3969;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo._loadDescription3969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._loadDescription3969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _PermissionGroupInfo3970;
		public PermissionGroupInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3970);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionGroupInfo3971;
		public PermissionGroupInfo(android.content.pm.PermissionGroupInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _descriptionRes3972;
		public int descriptionRes
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _descriptionRes3972);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription3973;
		public global::java.lang.CharSequence nonLocalizedDescription
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.GetObjectField(this.JvmHandle, _nonLocalizedDescription3973)) as java.lang.CharSequence;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3974;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.content.pm.PermissionGroupInfo.staticClass, _CREATOR3974)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.pm.PermissionGroupInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionGroupInfo"));
			global::android.content.pm.PermissionGroupInfo._toString3966 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PermissionGroupInfo._writeToParcel3967 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PermissionGroupInfo._describeContents3968 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PermissionGroupInfo._loadDescription3969 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3970 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo3971 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionGroupInfo;)V");
			global::android.content.pm.PermissionGroupInfo._descriptionRes3972 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "descriptionRes", "I");
			global::android.content.pm.PermissionGroupInfo._nonLocalizedDescription3973 = @__env.GetFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "nonLocalizedDescription", "Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionGroupInfo._CREATOR3974 = @__env.GetStaticFieldIDNoThrow(global::android.content.pm.PermissionGroupInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
