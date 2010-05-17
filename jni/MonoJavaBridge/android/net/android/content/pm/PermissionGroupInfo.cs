namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PermissionGroupInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PermissionGroupInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.PermissionGroupInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.PermissionGroupInfo(@__env); 
			} 
		} 
		protected PermissionGroupInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1744; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionGroupInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1744)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PermissionGroupInfo.staticClass, _toString1744)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1745; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionGroupInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.PermissionGroupInfo.staticClass, _writeToParcel1745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1746; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionGroupInfo)) 
				return @__env.CallIntMethod(this, _describeContents1746); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.PermissionGroupInfo.staticClass, _describeContents1746); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadDescription1747; 
		public virtual java.lang.CharSequence loadDescription(android.content.pm.PackageManager arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.PermissionGroupInfo)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _loadDescription1747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.PermissionGroupInfo.staticClass, _loadDescription1747, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PermissionGroupInfo1748; 
		public PermissionGroupInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, _PermissionGroupInfo1748, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PermissionGroupInfo1749; 
		public PermissionGroupInfo(android.content.pm.PermissionGroupInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.PermissionGroupInfo.staticClass, _PermissionGroupInfo1749, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _descriptionRes1750; 
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
		internal static global::net.sf.jni4net.jni.FieldId _nonLocalizedDescription1751; 
		public java.lang.CharSequence nonLocalizedDescription
		{ 
			get 
			{ 
				return default(java.lang.CharSequence); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1752; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.PermissionGroupInfo.staticClass = @__class; 
			global::android.content.pm.PermissionGroupInfo._toString1744 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.PermissionGroupInfo._writeToParcel1745 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.PermissionGroupInfo._describeContents1746 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.PermissionGroupInfo._loadDescription1747 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "loadDescription", "(Landroid/content/pm/PackageManager;)Ljava/lang/CharSequence;"); 
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo1748 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.PermissionGroupInfo._PermissionGroupInfo1749 = @__env.GetMethodID(global::android.content.pm.PermissionGroupInfo.staticClass, "<init>", "(Landroid/content/pm/PermissionGroupInfo;)V"); 
		} 
	} 
} 
