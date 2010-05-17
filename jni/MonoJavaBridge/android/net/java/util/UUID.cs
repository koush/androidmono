namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class UUID : java.lang.Object, java.io.Serializable, java.lang.Comparable
	{ 
		internal static global::java.lang.Class staticClass; 
		static UUID() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.UUID), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.UUID(@__env); 
			} 
		} 
		internal UUID(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12071; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _hashCode12071); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _hashCode12071); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12072; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallBooleanMethod(this, _equals12072, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.UUID.staticClass, _equals12072, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12073; 
		public int compareTo(java.util.UUID arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _compareTo12073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _compareTo12073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo12074; 
		public int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _compareTo12074, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _compareTo12074, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12075; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12075)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.UUID.staticClass, _toString12075)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timestamp12076; 
		public long timestamp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _timestamp12076); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _timestamp12076); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _variant12077; 
		public int variant() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _variant12077); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _variant12077); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _version12078; 
		public int version() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _version12078); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _version12078); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _node12079; 
		public long node() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _node12079); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _node12079); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _randomUUID12080; 
		public static java.util.UUID randomUUID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, _randomUUID12080)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nameUUIDFromBytes12081; 
		public static java.util.UUID nameUUIDFromBytes(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, _nameUUIDFromBytes12081, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromString12082; 
		public static java.util.UUID fromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, _fromString12082, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeastSignificantBits12083; 
		public long getLeastSignificantBits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _getLeastSignificantBits12083); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _getLeastSignificantBits12083); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMostSignificantBits12084; 
		public long getMostSignificantBits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _getMostSignificantBits12084); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _getMostSignificantBits12084); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clockSequence12085; 
		public int clockSequence() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _clockSequence12085); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _clockSequence12085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UUID12086; 
		public UUID(long arg0, long arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.UUID.staticClass, _UUID12086, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.UUID.staticClass = @__class; 
			global::java.util.UUID._hashCode12071 = @__env.GetMethodID(global::java.util.UUID.staticClass, "hashCode", "()I"); 
			global::java.util.UUID._equals12072 = @__env.GetMethodID(global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.UUID._compareTo12073 = @__env.GetMethodID(global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I"); 
			global::java.util.UUID._compareTo12074 = @__env.GetMethodID(global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.util.UUID._toString12075 = @__env.GetMethodID(global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.UUID._timestamp12076 = @__env.GetMethodID(global::java.util.UUID.staticClass, "timestamp", "()J"); 
			global::java.util.UUID._variant12077 = @__env.GetMethodID(global::java.util.UUID.staticClass, "variant", "()I"); 
			global::java.util.UUID._version12078 = @__env.GetMethodID(global::java.util.UUID.staticClass, "version", "()I"); 
			global::java.util.UUID._node12079 = @__env.GetMethodID(global::java.util.UUID.staticClass, "node", "()J"); 
			global::java.util.UUID._randomUUID12080 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;"); 
			global::java.util.UUID._nameUUIDFromBytes12081 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;"); 
			global::java.util.UUID._fromString12082 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;"); 
			global::java.util.UUID._getLeastSignificantBits12083 = @__env.GetMethodID(global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J"); 
			global::java.util.UUID._getMostSignificantBits12084 = @__env.GetMethodID(global::java.util.UUID.staticClass, "getMostSignificantBits", "()J"); 
			global::java.util.UUID._clockSequence12085 = @__env.GetMethodID(global::java.util.UUID.staticClass, "clockSequence", "()I"); 
			global::java.util.UUID._UUID12086 = @__env.GetMethodID(global::java.util.UUID.staticClass, "<init>", "(JJ)V"); 
		} 
	} 
} 
