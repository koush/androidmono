namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class WallpaperInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static WallpaperInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.WallpaperInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.WallpaperInfo(@__env);
			}
		}
		internal WallpaperInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString826;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._toString826));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._toString826));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName827;
		public global::java.lang.String getPackageName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._getPackageName827));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getPackageName827));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getComponent828;
		public global::android.content.ComponentName getComponent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._getComponent828));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getComponent828));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump829;
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperInfo._dump829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._dump829, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel830;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.WallpaperInfo._writeToParcel830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._writeToParcel830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents831;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.WallpaperInfo._describeContents831);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._describeContents831);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceInfo832;
		public global::android.content.pm.ServiceInfo getServiceInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._getServiceInfo832));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getServiceInfo832));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription833;
		public global::java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._loadDescription833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadDescription833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel834;
		public global::java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._loadLabel834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadLabel834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon835;
		public global::android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._loadIcon835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadIcon835, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServiceName836;
		public global::java.lang.String getServiceName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._getServiceName836));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getServiceName836));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadThumbnail837;
		public global::android.graphics.drawable.Drawable loadThumbnail(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._loadThumbnail837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadThumbnail837, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadAuthor838;
		public global::java.lang.CharSequence loadAuthor(android.content.pm.PackageManager arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._loadAuthor838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._loadAuthor838, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSettingsActivity839;
		public global::java.lang.String getSettingsActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.WallpaperInfo._getSettingsActivity839));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._getSettingsActivity839));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WallpaperInfo840;
		public WallpaperInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.WallpaperInfo.staticClass, global::android.app.WallpaperInfo._WallpaperInfo840, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR841;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.WallpaperInfo.staticClass = @__class;
			global::android.app.WallpaperInfo._toString826 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._getPackageName827 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._getComponent828 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;");
			global::android.app.WallpaperInfo._dump829 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.app.WallpaperInfo._writeToParcel830 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.app.WallpaperInfo._describeContents831 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "describeContents", "()I");
			global::android.app.WallpaperInfo._getServiceInfo832 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;");
			global::android.app.WallpaperInfo._loadDescription833 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.WallpaperInfo._loadLabel834 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.WallpaperInfo._loadIcon835 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperInfo._getServiceName836 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getServiceName", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._loadThumbnail837 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadThumbnail", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;");
			global::android.app.WallpaperInfo._loadAuthor838 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadAuthor", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;");
			global::android.app.WallpaperInfo._getSettingsActivity839 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;");
			global::android.app.WallpaperInfo._WallpaperInfo840 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V");
		}
	}
}
