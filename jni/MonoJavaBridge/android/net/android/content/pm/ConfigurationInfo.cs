namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ConfigurationInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ConfigurationInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ConfigurationInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.ConfigurationInfo(@__env); 
			} 
		} 
		protected ConfigurationInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1624; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ConfigurationInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1624)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ConfigurationInfo.staticClass, _toString1624)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1625; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ConfigurationInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1625, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ConfigurationInfo.staticClass, _writeToParcel1625, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1626; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ConfigurationInfo)) 
				return @__env.CallIntMethod(this, _describeContents1626); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ConfigurationInfo.staticClass, _describeContents1626); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlEsVersion1627; 
		public virtual java.lang.String getGlEsVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ConfigurationInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getGlEsVersion1627)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ConfigurationInfo.staticClass, _getGlEsVersion1627)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ConfigurationInfo1628; 
		public ConfigurationInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, _ConfigurationInfo1628, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ConfigurationInfo1629; 
		public ConfigurationInfo(android.content.pm.ConfigurationInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ConfigurationInfo.staticClass, _ConfigurationInfo1629, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _reqTouchScreen1630; 
		public int reqTouchScreen
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _reqKeyboardType1631; 
		public int reqKeyboardType
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _reqNavigation1632; 
		public int reqNavigation
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		public static int INPUT_FEATURE_HARD_KEYBOARD
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int INPUT_FEATURE_FIVE_WAY_NAV
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _reqInputFeatures1633; 
		public int reqInputFeatures
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		public static int GL_ES_VERSION_UNDEFINED
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _reqGlEsVersion1634; 
		public int reqGlEsVersion
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1635; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.ConfigurationInfo.staticClass = @__class; 
			global::android.content.pm.ConfigurationInfo._toString1624 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.ConfigurationInfo._writeToParcel1625 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.ConfigurationInfo._describeContents1626 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.ConfigurationInfo._getGlEsVersion1627 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;"); 
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo1628 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.ConfigurationInfo._ConfigurationInfo1629 = @__env.GetMethodID(global::android.content.pm.ConfigurationInfo.staticClass, "<init>", "(Landroid/content/pm/ConfigurationInfo;)V"); 
		} 
	} 
} 
