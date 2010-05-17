namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class FeatureInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static FeatureInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.FeatureInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.FeatureInfo(@__env); 
			} 
		} 
		protected FeatureInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1591; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.FeatureInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1591)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.FeatureInfo.staticClass, _toString1591)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1592; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.FeatureInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.FeatureInfo.staticClass, _writeToParcel1592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1593; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.FeatureInfo)) 
				return @__env.CallIntMethod(this, _describeContents1593); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.FeatureInfo.staticClass, _describeContents1593); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGlEsVersion1594; 
		public virtual java.lang.String getGlEsVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.FeatureInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getGlEsVersion1594)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.FeatureInfo.staticClass, _getGlEsVersion1594)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FeatureInfo1595; 
		public FeatureInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.FeatureInfo.staticClass, _FeatureInfo1595, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _FeatureInfo1596; 
		public FeatureInfo(android.content.pm.FeatureInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.FeatureInfo.staticClass, _FeatureInfo1596, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _name1597; 
		public java.lang.String name
		{ 
			get 
			{ 
				return default(java.lang.String); 
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
		internal static global::net.sf.jni4net.jni.FieldId _reqGlEsVersion1598; 
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
		public static int FLAG_REQUIRED
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _flags1599; 
		public int flags
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1600; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.FeatureInfo.staticClass = @__class; 
			global::android.content.pm.FeatureInfo._toString1591 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.FeatureInfo._writeToParcel1592 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.FeatureInfo._describeContents1593 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.FeatureInfo._getGlEsVersion1594 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "getGlEsVersion", "()Ljava/lang/String;"); 
			global::android.content.pm.FeatureInfo._FeatureInfo1595 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.FeatureInfo._FeatureInfo1596 = @__env.GetMethodID(global::android.content.pm.FeatureInfo.staticClass, "<init>", "(Landroid/content/pm/FeatureInfo;)V"); 
		} 
	} 
} 
