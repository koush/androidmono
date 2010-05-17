namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ParcelUuid : java.lang.Object, Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ParcelUuid() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.ParcelUuid), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.ParcelUuid(@__env); 
			} 
		} 
		internal ParcelUuid(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode5536; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ParcelUuid)) 
				return @__env.CallIntMethod(this, _hashCode5536); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.ParcelUuid.staticClass, _hashCode5536); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals5537; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ParcelUuid)) 
				return @__env.CallBooleanMethod(this, _equals5537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.ParcelUuid.staticClass, _equals5537, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString5538; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ParcelUuid)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5538)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.ParcelUuid.staticClass, _toString5538)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5539; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ParcelUuid)) 
				@__env.CallVoidMethod(this, _writeToParcel5539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.ParcelUuid.staticClass, _writeToParcel5539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5540; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ParcelUuid)) 
				return @__env.CallIntMethod(this, _describeContents5540); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.ParcelUuid.staticClass, _describeContents5540); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromString5541; 
		public static android.os.ParcelUuid fromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelUuid>(@__env, @__env.CallStaticObjectMethodPtr(android.os.ParcelUuid.staticClass, _fromString5541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUuid5542; 
		public java.util.UUID getUuid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.ParcelUuid)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallObjectMethodPtr(this, _getUuid5542)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.ParcelUuid.staticClass, _getUuid5542)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ParcelUuid5543; 
		public ParcelUuid(java.util.UUID arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.ParcelUuid.staticClass, _ParcelUuid5543, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5544; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.ParcelUuid.staticClass = @__class; 
			global::android.os.ParcelUuid._hashCode5536 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "hashCode", "()I"); 
			global::android.os.ParcelUuid._equals5537 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.os.ParcelUuid._toString5538 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.ParcelUuid._writeToParcel5539 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.ParcelUuid._describeContents5540 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "describeContents", "()I"); 
			global::android.os.ParcelUuid._fromString5541 = @__env.GetStaticMethodID(global::android.os.ParcelUuid.staticClass, "fromString", "(Ljava/lang/String;)Landroid/os/ParcelUuid;"); 
			global::android.os.ParcelUuid._getUuid5542 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "getUuid", "()Ljava/util/UUID;"); 
			global::android.os.ParcelUuid._ParcelUuid5543 = @__env.GetMethodID(global::android.os.ParcelUuid.staticClass, "<init>", "(Ljava/util/UUID;)V"); 
		} 
	} 
} 
