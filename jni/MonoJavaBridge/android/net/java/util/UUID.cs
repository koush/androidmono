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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13017; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _hashCode13017); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _hashCode13017); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals13018; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallBooleanMethod(this, _equals13018, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.UUID.staticClass, _equals13018, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13019; 
		public int compareTo(java.util.UUID arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _compareTo13019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _compareTo13019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo13020; 
		public int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _compareTo13020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _compareTo13020, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString13021; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString13021)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.UUID.staticClass, _toString13021)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _timestamp13022; 
		public long timestamp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _timestamp13022); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _timestamp13022); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _variant13023; 
		public int variant() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _variant13023); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _variant13023); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _version13024; 
		public int version() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _version13024); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _version13024); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _node13025; 
		public long node() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _node13025); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _node13025); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _randomUUID13026; 
		public static java.util.UUID randomUUID() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, _randomUUID13026)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _nameUUIDFromBytes13027; 
		public static java.util.UUID nameUUIDFromBytes(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, _nameUUIDFromBytes13027, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fromString13028; 
		public static java.util.UUID fromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.UUID>(@__env, @__env.CallStaticObjectMethodPtr(java.util.UUID.staticClass, _fromString13028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLeastSignificantBits13029; 
		public long getLeastSignificantBits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _getLeastSignificantBits13029); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _getLeastSignificantBits13029); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMostSignificantBits13030; 
		public long getMostSignificantBits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallLongMethod(this, _getMostSignificantBits13030); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.util.UUID.staticClass, _getMostSignificantBits13030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clockSequence13031; 
		public int clockSequence() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.UUID)) 
				return @__env.CallIntMethod(this, _clockSequence13031); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.UUID.staticClass, _clockSequence13031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _UUID13032; 
		public UUID(long arg0, long arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.UUID.staticClass, _UUID13032, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.UUID.staticClass = @__class; 
			global::java.util.UUID._hashCode13017 = @__env.GetMethodID(global::java.util.UUID.staticClass, "hashCode", "()I"); 
			global::java.util.UUID._equals13018 = @__env.GetMethodID(global::java.util.UUID.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.UUID._compareTo13019 = @__env.GetMethodID(global::java.util.UUID.staticClass, "compareTo", "(Ljava/util/UUID;)I"); 
			global::java.util.UUID._compareTo13020 = @__env.GetMethodID(global::java.util.UUID.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.util.UUID._toString13021 = @__env.GetMethodID(global::java.util.UUID.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.UUID._timestamp13022 = @__env.GetMethodID(global::java.util.UUID.staticClass, "timestamp", "()J"); 
			global::java.util.UUID._variant13023 = @__env.GetMethodID(global::java.util.UUID.staticClass, "variant", "()I"); 
			global::java.util.UUID._version13024 = @__env.GetMethodID(global::java.util.UUID.staticClass, "version", "()I"); 
			global::java.util.UUID._node13025 = @__env.GetMethodID(global::java.util.UUID.staticClass, "node", "()J"); 
			global::java.util.UUID._randomUUID13026 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "randomUUID", "()Ljava/util/UUID;"); 
			global::java.util.UUID._nameUUIDFromBytes13027 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "nameUUIDFromBytes", "([B)Ljava/util/UUID;"); 
			global::java.util.UUID._fromString13028 = @__env.GetStaticMethodID(global::java.util.UUID.staticClass, "fromString", "(Ljava/lang/String;)Ljava/util/UUID;"); 
			global::java.util.UUID._getLeastSignificantBits13029 = @__env.GetMethodID(global::java.util.UUID.staticClass, "getLeastSignificantBits", "()J"); 
			global::java.util.UUID._getMostSignificantBits13030 = @__env.GetMethodID(global::java.util.UUID.staticClass, "getMostSignificantBits", "()J"); 
			global::java.util.UUID._clockSequence13031 = @__env.GetMethodID(global::java.util.UUID.staticClass, "clockSequence", "()I"); 
			global::java.util.UUID._UUID13032 = @__env.GetMethodID(global::java.util.UUID.staticClass, "<init>", "(JJ)V"); 
		} 
	} 
} 
