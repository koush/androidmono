namespace android.content.pm
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PermissionInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PermissionInfo()
		{
			InitJNI();
		}
		protected PermissionInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2130;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PermissionInfo._toString2130)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._toString2130)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2131;
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.pm.PermissionInfo._writeToParcel2131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._writeToParcel2131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2132;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.pm.PermissionInfo._describeContents2132);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._describeContents2132);
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription2133;
		public virtual global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.pm.PermissionInfo._loadDescription2133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._loadDescription2133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _PermissionInfo2134;
		public PermissionInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._PermissionInfo2134);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PermissionInfo2135;
		public PermissionInfo(android.content.pm.PermissionInfo arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.pm.PermissionInfo.staticClass, global::android.content.pm.PermissionInfo._PermissionInfo2135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _group2136;
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
		internal static global::MonoJavaBridge.FieldId _descriptionRes2137;
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
		internal static global::MonoJavaBridge.FieldId _nonLocalizedDescription2138;
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
		internal static global::MonoJavaBridge.FieldId _protectionLevel2139;
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
		internal static global::MonoJavaBridge.FieldId _CREATOR2140;
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
			global::android.content.pm.PermissionInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/pm/PermissionInfo"));
			global::android.content.pm.PermissionInfo._toString2130 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.pm.PermissionInfo._writeToParcel2131 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.pm.PermissionInfo._describeContents2132 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "describeContents", "()I");
			global::android.content.pm.PermissionInfo._loadDescription2133 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.content.pm.PermissionInfo._PermissionInfo2134 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "<init>", "()V");
			global::android.content.pm.PermissionInfo._PermissionInfo2135 = @__env.GetMethodIDNoThrow(global::android.content.pm.PermissionInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionInfo;)V");
		}
	}
}
