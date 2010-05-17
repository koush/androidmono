namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SyncAdapterType : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static SyncAdapterType() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.SyncAdapterType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.SyncAdapterType(@__env); 
			} 
		} 
		protected SyncAdapterType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1468; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				return @__env.CallIntMethod(this, _hashCode1468); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SyncAdapterType.staticClass, _hashCode1468); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals1469; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				return @__env.CallBooleanMethod(this, _equals1469, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncAdapterType.staticClass, _equals1469, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1470; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1470)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.SyncAdapterType.staticClass, _toString1470)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportsUploading1471; 
		public virtual bool supportsUploading() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				return @__env.CallBooleanMethod(this, _supportsUploading1471); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncAdapterType.staticClass, _supportsUploading1471); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1472; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				@__env.CallVoidMethod(this, _writeToParcel1472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.SyncAdapterType.staticClass, _writeToParcel1472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1473; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				return @__env.CallIntMethod(this, _describeContents1473); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.SyncAdapterType.staticClass, _describeContents1473); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newKey1474; 
		public static android.content.SyncAdapterType newKey(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.SyncAdapterType>(@__env, @__env.CallStaticObjectMethodPtr(android.content.SyncAdapterType.staticClass, _newKey1474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUserVisible1475; 
		public virtual bool isUserVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.SyncAdapterType)) 
				return @__env.CallBooleanMethod(this, _isUserVisible1475); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.SyncAdapterType.staticClass, _isUserVisible1475); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncAdapterType1476; 
		public SyncAdapterType(java.lang.String arg0, java.lang.String arg1, bool arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SyncAdapterType.staticClass, _SyncAdapterType1476, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SyncAdapterType1477; 
		public SyncAdapterType(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.SyncAdapterType.staticClass, _SyncAdapterType1477, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _authority1478; 
		public java.lang.String authority
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _accountType1479; 
		public java.lang.String accountType
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _isKey1480; 
		public bool isKey
		{ 
			get 
			{ 
				return default(bool); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1481; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.SyncAdapterType.staticClass = @__class; 
			global::android.content.SyncAdapterType._hashCode1468 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "hashCode", "()I"); 
			global::android.content.SyncAdapterType._equals1469 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.SyncAdapterType._toString1470 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.SyncAdapterType._supportsUploading1471 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "supportsUploading", "()Z"); 
			global::android.content.SyncAdapterType._writeToParcel1472 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.SyncAdapterType._describeContents1473 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "describeContents", "()I"); 
			global::android.content.SyncAdapterType._newKey1474 = @__env.GetStaticMethodID(global::android.content.SyncAdapterType.staticClass, "newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;"); 
			global::android.content.SyncAdapterType._isUserVisible1475 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "isUserVisible", "()Z"); 
			global::android.content.SyncAdapterType._SyncAdapterType1476 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V"); 
			global::android.content.SyncAdapterType._SyncAdapterType1477 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
