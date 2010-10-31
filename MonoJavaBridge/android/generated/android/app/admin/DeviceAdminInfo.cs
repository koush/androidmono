namespace android.app.admin
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DeviceAdminInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DeviceAdminInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.app.admin.DeviceAdminInfo._m0) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.String getPackageName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.app.admin.DeviceAdminInfo._m1) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::android.content.ComponentName getComponent()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;", ref global::android.app.admin.DeviceAdminInfo._m2) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.app.admin.DeviceAdminInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.admin.DeviceAdminInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "describeContents", "()I", ref global::android.app.admin.DeviceAdminInfo._m5);
		}
		public new global::android.content.pm.ActivityInfo ActivityInfo
		{
			get
			{
				return getActivityInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::android.content.pm.ActivityInfo getActivityInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "getActivityInfo", "()Landroid/content/pm/ActivityInfo;", ref global::android.app.admin.DeviceAdminInfo._m6) as android.content.pm.ActivityInfo;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.app.admin.DeviceAdminInfo._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.app.admin.DeviceAdminInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.app.admin.DeviceAdminInfo._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public bool isVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "isVisible", "()Z", ref global::android.app.admin.DeviceAdminInfo._m10);
		}
		public new global::java.lang.String ReceiverName
		{
			get
			{
				return getReceiverName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.String getReceiverName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "getReceiverName", "()Ljava/lang/String;", ref global::android.app.admin.DeviceAdminInfo._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public bool usesPolicy(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.admin.DeviceAdminInfo.staticClass, "usesPolicy", "(I)Z", ref global::android.app.admin.DeviceAdminInfo._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getTagForPolicy(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.admin.DeviceAdminInfo.staticClass, "getTagForPolicy", "(I)Ljava/lang/String;", ref global::android.app.admin.DeviceAdminInfo._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public DeviceAdminInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.admin.DeviceAdminInfo._m14.native == global::System.IntPtr.Zero)
				global::android.app.admin.DeviceAdminInfo._m14 = @__env.GetMethodIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.admin.DeviceAdminInfo.staticClass, global::android.app.admin.DeviceAdminInfo._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR1456;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.admin.DeviceAdminInfo.staticClass, _CREATOR1456)) as android.os.Parcelable_Creator;
			}
		}
		static DeviceAdminInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.admin.DeviceAdminInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/admin/DeviceAdminInfo"));
			global::android.app.admin.DeviceAdminInfo._CREATOR1456 = @__env.GetStaticFieldIDNoThrow(global::android.app.admin.DeviceAdminInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
