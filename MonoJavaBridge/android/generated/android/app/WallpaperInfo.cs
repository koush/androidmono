namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class WallpaperInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal WallpaperInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.WallpaperInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.app.WallpaperInfo._m0) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.WallpaperInfo.staticClass, "getPackageName", "()Ljava/lang/String;", ref global::android.app.WallpaperInfo._m1) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.ComponentName>(this, global::android.app.WallpaperInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;", ref global::android.app.WallpaperInfo._m2) as android.content.ComponentName;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void dump(android.util.Printer arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V", ref global::android.app.WallpaperInfo._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void dump(global::android.util.PrinterDelegate arg0, java.lang.String arg1)
		{
			dump((global::android.util.PrinterDelegateWrapper)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.WallpaperInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.app.WallpaperInfo._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.WallpaperInfo.staticClass, "describeContents", "()I", ref global::android.app.WallpaperInfo._m5);
		}
		public new global::android.content.pm.ServiceInfo ServiceInfo
		{
			get
			{
				return getServiceInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::android.content.pm.ServiceInfo getServiceInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;", ref global::android.app.WallpaperInfo._m6) as android.content.pm.ServiceInfo;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.WallpaperInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.app.WallpaperInfo._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.WallpaperInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.app.WallpaperInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperInfo._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String ServiceName
		{
			get
			{
				return getServiceName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.lang.String getServiceName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.WallpaperInfo.staticClass, "getServiceName", "()Ljava/lang/String;", ref global::android.app.WallpaperInfo._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::android.graphics.drawable.Drawable loadThumbnail(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.app.WallpaperInfo.staticClass, "loadThumbnail", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;", ref global::android.app.WallpaperInfo._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.CharSequence loadAuthor(android.content.pm.PackageManager arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.app.WallpaperInfo.staticClass, "loadAuthor", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;", ref global::android.app.WallpaperInfo._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		public new global::java.lang.String SettingsActivity
		{
			get
			{
				return getSettingsActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getSettingsActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.WallpaperInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;", ref global::android.app.WallpaperInfo._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public WallpaperInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.WallpaperInfo._m14.native == global::System.IntPtr.Zero)
				global::android.app.WallpaperInfo._m14 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1447;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.WallpaperInfo.staticClass, _CREATOR1447)) as android.os.Parcelable_Creator;
			}
		}
		static WallpaperInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.WallpaperInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/WallpaperInfo"));
			global::android.app.WallpaperInfo._CREATOR1447 = @__env.GetStaticFieldIDNoThrow(global::android.app.WallpaperInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
