namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class ComponentName : java.lang.Object, android.os.Parcelable, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static ComponentName() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ComponentName), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ComponentName(@__env); 
			} 
		} 
		internal ComponentName(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode958; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _hashCode958); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _hashCode958); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals959; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallBooleanMethod(this, _equals959, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ComponentName.staticClass, _equals959, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo960; 
		public int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _compareTo960, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _compareTo960, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo961; 
		public int compareTo(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _compareTo961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _compareTo961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString962; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString962)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _toString962)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassName963; 
		public java.lang.String getClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getClassName963)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _getClassName963)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName964; 
		public java.lang.String getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageName964)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _getPackageName964)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel965; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				@__env.CallVoidMethod(this, _writeToParcel965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ComponentName.staticClass, _writeToParcel965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel966; 
		public static void writeToParcel(android.content.ComponentName arg0, android.os.Parcel arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ComponentName.staticClass, _writeToParcel966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents967; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _describeContents967); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _describeContents967); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel968; 
		public static android.content.ComponentName readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ComponentName.staticClass, _readFromParcel968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShortClassName969; 
		public java.lang.String getShortClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getShortClassName969)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _getShortClassName969)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flattenToString970; 
		public java.lang.String flattenToString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _flattenToString970)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _flattenToString970)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flattenToShortString971; 
		public java.lang.String flattenToShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _flattenToShortString971)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _flattenToShortString971)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unflattenFromString972; 
		public static android.content.ComponentName unflattenFromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ComponentName.staticClass, _unflattenFromString972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString973; 
		public java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toShortString973)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _toShortString973)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName974; 
		public ComponentName(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName974, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName975; 
		public ComponentName(android.content.Context arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName975, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName976; 
		public ComponentName(android.content.Context arg0, java.lang.Class arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName976, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName977; 
		public ComponentName(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName977, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR978; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ComponentName.staticClass = @__class; 
			global::android.content.ComponentName._hashCode958 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "hashCode", "()I"); 
			global::android.content.ComponentName._equals959 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.ComponentName._compareTo960 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::android.content.ComponentName._compareTo961 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "compareTo", "(Landroid/content/ComponentName;)I"); 
			global::android.content.ComponentName._toString962 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._getClassName963 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getClassName", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._getPackageName964 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._writeToParcel965 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.ComponentName._writeToParcel966 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V"); 
			global::android.content.ComponentName._describeContents967 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "describeContents", "()I"); 
			global::android.content.ComponentName._readFromParcel968 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;"); 
			global::android.content.ComponentName._getShortClassName969 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getShortClassName", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._flattenToString970 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "flattenToString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._flattenToShortString971 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "flattenToShortString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._unflattenFromString972 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;"); 
			global::android.content.ComponentName._toShortString973 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._ComponentName974 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.ComponentName._ComponentName975 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V"); 
			global::android.content.ComponentName._ComponentName976 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V"); 
			global::android.content.ComponentName._ComponentName977 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
