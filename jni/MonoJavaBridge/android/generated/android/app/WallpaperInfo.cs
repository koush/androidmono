namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class WallpaperInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WallpaperInfo()
		{
			InitJNI();
		}
		internal WallpaperInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString2188;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._toString2188)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._toString2188)) as java.lang.String;
		}
		public new global::java.lang.String PackageName
		{
			get
			{
				return getPackageName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName2189;
		public global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._getPackageName2189)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getPackageName2189)) as java.lang.String;
		}
		public new global::android.content.ComponentName Component
		{
			get
			{
				return getComponent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComponent2190;
		public global::android.content.ComponentName getComponent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._getComponent2190)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ComponentName>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getComponent2190)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _dump2191;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperInfo._dump2191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._dump2191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2192;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.WallpaperInfo._writeToParcel2192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._writeToParcel2192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2193;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.WallpaperInfo._describeContents2193);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._describeContents2193);
		}
		public new global::android.content.pm.ServiceInfo ServiceInfo
		{
			get
			{
				return getServiceInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceInfo2194;
		public global::android.content.pm.ServiceInfo getServiceInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._getServiceInfo2194)) as android.content.pm.ServiceInfo;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getServiceInfo2194)) as android.content.pm.ServiceInfo;
		}
		internal static global::MonoJavaBridge.MethodId _loadDescription2195;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._loadDescription2195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadDescription2195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadLabel2196;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._loadLabel2196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadLabel2196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _loadIcon2197;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._loadIcon2197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadIcon2197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		public new global::java.lang.String ServiceName
		{
			get
			{
				return getServiceName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getServiceName2198;
		public global::java.lang.String getServiceName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._getServiceName2198)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getServiceName2198)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _loadThumbnail2199;
		public global::android.graphics.drawable.Drawable loadThumbnail(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._loadThumbnail2199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadThumbnail2199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _loadAuthor2200;
		public global::java.lang.CharSequence loadAuthor(android.content.pm.PackageManager arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._loadAuthor2200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadAuthor2200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		public new global::java.lang.String SettingsActivity
		{
			get
			{
				return getSettingsActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSettingsActivity2201;
		public global::java.lang.String getSettingsActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo._getSettingsActivity2201)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getSettingsActivity2201)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _WallpaperInfo2202;
		public WallpaperInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._WallpaperInfo2202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2203;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.app.WallpaperInfo.staticClass, _CREATOR2203)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.WallpaperInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/WallpaperInfo"));
			global::android.app.WallpaperInfo._toString2188 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._getPackageName2189 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._getComponent2190 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.app.WallpaperInfo._dump2191 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.app.WallpaperInfo._writeToParcel2192 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.WallpaperInfo._describeContents2193 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "describeContents", "()I");
			global::android.app.WallpaperInfo._getServiceInfo2194 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
			global::android.app.WallpaperInfo._loadDescription2195 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.WallpaperInfo._loadLabel2196 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.WallpaperInfo._loadIcon2197 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperInfo._getServiceName2198 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "getServiceName", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._loadThumbnail2199 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "loadThumbnail", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperInfo._loadAuthor2200 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "loadAuthor", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.WallpaperInfo._getSettingsActivity2201 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._WallpaperInfo2202 = @__env.GetMethodIDNoThrow(global::android.app.WallpaperInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
			global::android.app.WallpaperInfo._CREATOR2203 = @__env.GetStaticFieldIDNoThrow(global::android.app.WallpaperInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
