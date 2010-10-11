namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DeviceAdminInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DeviceAdminInfo()
		{
			InitJNI();
		}
		internal DeviceAdminInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString871;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._toString871)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._toString871)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName872;
		public global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._getPackageName872)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getPackageName872)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComponent873;
		public global::android.content.ComponentName getComponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._getComponent873)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getComponent873)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _dump874;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._dump874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._dump874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel875;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._writeToParcel875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._writeToParcel875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents876;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._describeContents876);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._describeContents876);
		}
		internal static global::MonoJavaBridge.MethodId _getActivityInfo877;
		public global::android.content.pm.ActivityInfo getActivityInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._getActivityInfo877)) as android.content.pm.ActivityInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getActivityInfo877)) as android.content.pm.ActivityInfo;
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription878;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._loadDescription878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadDescription878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel879;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._loadLabel879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadLabel879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon880;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._loadIcon880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadIcon880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isVisible881;
		public bool isVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._isVisible881);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._isVisible881);
		}
		internal static global::MonoJavaBridge.MethodId _getReceiverName882;
		public global::java.lang.String getReceiverName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._getReceiverName882)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getReceiverName882)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _usesPolicy883;
		public bool usesPolicy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._usesPolicy883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._usesPolicy883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTagForPolicy884;
		public global::java.lang.String getTagForPolicy(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo._getTagForPolicy884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getTagForPolicy884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DeviceAdminInfo885;
		public DeviceAdminInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._DeviceAdminInfo885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int USES_POLICY_LIMIT_PASSWORD
		{
			get
			{
				return 0;
			}
		}
		public static int USES_POLICY_WATCH_LOGIN
		{
			get
			{
				return 1;
			}
		}
		public static int USES_POLICY_RESET_PASSWORD
		{
			get
			{
				return 2;
			}
		}
		public static int USES_POLICY_FORCE_LOCK
		{
			get
			{
				return 3;
			}
		}
		public static int USES_POLICY_WIPE_DATA
		{
			get
			{
				return 4;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR886;
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
			global::android.app.admin.DeviceAdminInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DeviceAdminInfo"));
			global::android.app.admin.DeviceAdminInfo._toString871 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._getPackageName872 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._getComponent873 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.app.admin.DeviceAdminInfo._dump874 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.app.admin.DeviceAdminInfo._writeToParcel875 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.admin.DeviceAdminInfo._describeContents876 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "describeContents", "()I");
			global::android.app.admin.DeviceAdminInfo._getActivityInfo877 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getActivityInfo", "()Landroid/content/pm/ActivityInfo;");
			global::android.app.admin.DeviceAdminInfo._loadDescription878 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminInfo._loadLabel879 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminInfo._loadIcon880 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.admin.DeviceAdminInfo._isVisible881 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "isVisible", "()Z");
			global::android.app.admin.DeviceAdminInfo._getReceiverName882 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getReceiverName", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._usesPolicy883 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "usesPolicy", "(I)Z");
			global::android.app.admin.DeviceAdminInfo._getTagForPolicy884 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "getTagForPolicy", "(I)Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._DeviceAdminInfo885 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
		}
	}
}
