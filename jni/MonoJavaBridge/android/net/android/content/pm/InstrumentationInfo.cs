namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InstrumentationInfo : android.content.pm.PackageItemInfo, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static InstrumentationInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.InstrumentationInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.InstrumentationInfo(@__env); 
			} 
		} 
		protected InstrumentationInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1601; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.InstrumentationInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1601)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.InstrumentationInfo.staticClass, _toString1601)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1602; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.InstrumentationInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.InstrumentationInfo.staticClass, _writeToParcel1602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1603; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.InstrumentationInfo)) 
				return @__env.CallIntMethod(this, _describeContents1603); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.InstrumentationInfo.staticClass, _describeContents1603); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InstrumentationInfo1604; 
		public InstrumentationInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, _InstrumentationInfo1604, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _InstrumentationInfo1605; 
		public InstrumentationInfo(android.content.pm.InstrumentationInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.InstrumentationInfo.staticClass, _InstrumentationInfo1605, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _targetPackage1606; 
		public java.lang.String targetPackage
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _sourceDir1607; 
		public java.lang.String sourceDir
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _publicSourceDir1608; 
		public java.lang.String publicSourceDir
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _dataDir1609; 
		public java.lang.String dataDir
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _handleProfiling1610; 
		public bool handleProfiling
		{ 
			get 
			{ 
				return default(bool); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _functionalTest1611; 
		public bool functionalTest
		{ 
			get 
			{ 
				return default(bool); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1612; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.InstrumentationInfo.staticClass = @__class; 
			global::android.content.pm.InstrumentationInfo._toString1601 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.InstrumentationInfo._writeToParcel1602 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.InstrumentationInfo._describeContents1603 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo1604 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.InstrumentationInfo._InstrumentationInfo1605 = @__env.GetMethodID(global::android.content.pm.InstrumentationInfo.staticClass, "<init>", "(Landroid/content/pm/InstrumentationInfo;)V"); 
		} 
	} 
} 
