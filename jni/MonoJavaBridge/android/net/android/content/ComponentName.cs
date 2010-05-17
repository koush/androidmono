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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode943; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _hashCode943); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _hashCode943); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals944; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallBooleanMethod(this, _equals944, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.ComponentName.staticClass, _equals944, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo945; 
		public int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _compareTo945, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _compareTo945, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo946; 
		public int compareTo(android.content.ComponentName arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _compareTo946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _compareTo946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString947; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString947)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _toString947)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getClassName948; 
		public java.lang.String getClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getClassName948)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _getClassName948)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPackageName949; 
		public java.lang.String getPackageName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPackageName949)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _getPackageName949)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel950; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				@__env.CallVoidMethod(this, _writeToParcel950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ComponentName.staticClass, _writeToParcel950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel951; 
		public static void writeToParcel(android.content.ComponentName arg0, android.os.Parcel arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.content.ComponentName.staticClass, _writeToParcel951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents952; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return @__env.CallIntMethod(this, _describeContents952); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.ComponentName.staticClass, _describeContents952); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel953; 
		public static android.content.ComponentName readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ComponentName.staticClass, _readFromParcel953, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShortClassName954; 
		public java.lang.String getShortClassName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getShortClassName954)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _getShortClassName954)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flattenToString955; 
		public java.lang.String flattenToString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _flattenToString955)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _flattenToString955)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flattenToShortString956; 
		public java.lang.String flattenToShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _flattenToShortString956)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _flattenToShortString956)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unflattenFromString957; 
		public static android.content.ComponentName unflattenFromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ComponentName>(@__env, @__env.CallStaticObjectMethodPtr(android.content.ComponentName.staticClass, _unflattenFromString957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toShortString958; 
		public java.lang.String toShortString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ComponentName)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toShortString958)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ComponentName.staticClass, _toShortString958)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName959; 
		public ComponentName(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName959, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName960; 
		public ComponentName(android.content.Context arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName960, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName961; 
		public ComponentName(android.content.Context arg0, java.lang.Class arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName961, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ComponentName962; 
		public ComponentName(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ComponentName.staticClass, _ComponentName962, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR963; 
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
			global::android.content.ComponentName._hashCode943 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "hashCode", "()I"); 
			global::android.content.ComponentName._equals944 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.content.ComponentName._compareTo945 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::android.content.ComponentName._compareTo946 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "compareTo", "(Landroid/content/ComponentName;)I"); 
			global::android.content.ComponentName._toString947 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._getClassName948 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getClassName", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._getPackageName949 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getPackageName", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._writeToParcel950 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.ComponentName._writeToParcel951 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V"); 
			global::android.content.ComponentName._describeContents952 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "describeContents", "()I"); 
			global::android.content.ComponentName._readFromParcel953 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;"); 
			global::android.content.ComponentName._getShortClassName954 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "getShortClassName", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._flattenToString955 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "flattenToString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._flattenToShortString956 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "flattenToShortString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._unflattenFromString957 = @__env.GetStaticMethodID(global::android.content.ComponentName.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;"); 
			global::android.content.ComponentName._toShortString958 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "toShortString", "()Ljava/lang/String;"); 
			global::android.content.ComponentName._ComponentName959 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.ComponentName._ComponentName960 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V"); 
			global::android.content.ComponentName._ComponentName961 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V"); 
			global::android.content.ComponentName._ComponentName962 = @__env.GetMethodID(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
