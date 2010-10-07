namespace android.app.admin
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class DeviceAdminInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static DeviceAdminInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.admin.DeviceAdminInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.admin.DeviceAdminInfo(@__env);
			}
		}
		internal DeviceAdminInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString859;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._toString859));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._toString859));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName860;
		public global::java.lang.String getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._getPackageName860));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getPackageName860));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComponent861;
		public global::android.content.ComponentName getComponent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._getComponent861));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getComponent861));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump862;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminInfo._dump862, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._dump862, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel863;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.admin.DeviceAdminInfo._writeToParcel863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._writeToParcel863, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents864;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.admin.DeviceAdminInfo._describeContents864);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._describeContents864);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getActivityInfo865;
		public global::android.content.pm.ActivityInfo getActivityInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ActivityInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._getActivityInfo865));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ActivityInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getActivityInfo865));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription866;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._loadDescription866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadDescription866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel867;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._loadLabel867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadLabel867, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon868;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._loadIcon868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._loadIcon868, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isVisible869;
		public bool isVisible() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.admin.DeviceAdminInfo._isVisible869);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._isVisible869);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getReceiverName870;
		public global::java.lang.String getReceiverName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._getReceiverName870));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getReceiverName870));
		}
		internal static global::net.sf.jni4net.jni.MethodId _usesPolicy871;
		public bool usesPolicy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.admin.DeviceAdminInfo._usesPolicy871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._usesPolicy871, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTagForPolicy872;
		public global::java.lang.String getTagForPolicy(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo._getTagForPolicy872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._getTagForPolicy872, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DeviceAdminInfo873;
		public DeviceAdminInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._DeviceAdminInfo873, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR874;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.admin.DeviceAdminInfo.staticClass = @__class;
			global::android.app.admin.DeviceAdminInfo._toString859 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._getPackageName860 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._getComponent861 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.app.admin.DeviceAdminInfo._dump862 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.app.admin.DeviceAdminInfo._writeToParcel863 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.admin.DeviceAdminInfo._describeContents864 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "describeContents", "()I");
			global::android.app.admin.DeviceAdminInfo._getActivityInfo865 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "getActivityInfo", "()Landroid/content/pm/ActivityInfo;");
			global::android.app.admin.DeviceAdminInfo._loadDescription866 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminInfo._loadLabel867 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.admin.DeviceAdminInfo._loadIcon868 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.admin.DeviceAdminInfo._isVisible869 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "isVisible", "()Z");
			global::android.app.admin.DeviceAdminInfo._getReceiverName870 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "getReceiverName", "()Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._usesPolicy871 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "usesPolicy", "(I)Z");
			global::android.app.admin.DeviceAdminInfo._getTagForPolicy872 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "getTagForPolicy", "(I)Ljava/lang/String;");
			global::android.app.admin.DeviceAdminInfo._DeviceAdminInfo873 = @__env.GetMethodID(global::android.app.admin.DeviceAdminInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
		}
	}
}
