namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class WallpaperInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static WallpaperInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.WallpaperInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString765; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString765)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _toString765)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName766; 
		public java.lang.String getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageName766)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _getPackageName766)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getComponent767; 
		public android.content.ComponentName getComponent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallObjectMethodPtr(this, _getComponent767)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _getComponent767)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump768; 
		public void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				@__env.CallVoidMethod(this, _dump768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperInfo.staticClass, _dump768, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel769; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.WallpaperInfo.staticClass, _writeToParcel769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents770; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return @__env.CallIntMethod(this, _describeContents770); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.WallpaperInfo.staticClass, _describeContents770); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceInfo771; 
		public android.content.pm.ServiceInfo getServiceInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallObjectMethodPtr(this, _getServiceInfo771)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.pm.ServiceInfo>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _getServiceInfo771)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription772; 
		public java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadDescription772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _loadDescription772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadLabel773; 
		public java.lang.CharSequence loadLabel(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadLabel773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _loadLabel773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadIcon774; 
		public android.graphics.drawable.Drawable loadIcon(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadIcon774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _loadIcon774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getServiceName775; 
		public java.lang.String getServiceName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getServiceName775)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _getServiceName775)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadThumbnail776; 
		public android.graphics.drawable.Drawable loadThumbnail(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _loadThumbnail776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _loadThumbnail776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadAuthor777; 
		public java.lang.CharSequence loadAuthor(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadAuthor777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _loadAuthor777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSettingsActivity778; 
		public java.lang.String getSettingsActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.WallpaperInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSettingsActivity778)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.WallpaperInfo.staticClass, _getSettingsActivity778)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _WallpaperInfo779; 
		public WallpaperInfo(android.content.Context arg0, android.content.pm.ResolveInfo arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.WallpaperInfo.staticClass, _WallpaperInfo779, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR780; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.WallpaperInfo.staticClass = @__class; 
			global::android.app.WallpaperInfo._toString765 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.app.WallpaperInfo._getPackageName766 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.app.WallpaperInfo._getComponent767 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getComponent", "()Landroid/content/ComponentName;"); 
			global::android.app.WallpaperInfo._dump768 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.app.WallpaperInfo._writeToParcel769 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.app.WallpaperInfo._describeContents770 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "describeContents", "()I"); 
			global::android.app.WallpaperInfo._getServiceInfo771 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getServiceInfo", "()Landroid/content/pm/ServiceInfo;"); 
			global::android.app.WallpaperInfo._loadDescription772 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.app.WallpaperInfo._loadLabel773 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadLabel", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.app.WallpaperInfo._loadIcon774 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadIcon", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.app.WallpaperInfo._getServiceName775 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getServiceName", "()Ljava/lang/String;"); 
			global::android.app.WallpaperInfo._loadThumbnail776 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadThumbnail", "(Landroid/content/pm/PackageManager;)Landroid/graphics/drawable/Drawable;"); 
			global::android.app.WallpaperInfo._loadAuthor777 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "loadAuthor", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.app.WallpaperInfo._getSettingsActivity778 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "getSettingsActivity", "()Ljava/lang/String;"); 
			global::android.app.WallpaperInfo._WallpaperInfo779 = @__env.GetMethodID(global::android.app.WallpaperInfo.staticClass, "<init>", "(Landroid/content/Context;Landroid/content/pm/ResolveInfo;)V"); 
		} 
	} 
} 
