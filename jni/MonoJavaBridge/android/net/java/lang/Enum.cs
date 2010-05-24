namespace java.lang 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Enum : java.lang.Object, Comparable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Enum() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.lang.Enum), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Enum(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _name11479; 
		public virtual java.lang.String name() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _name11479)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Enum.staticClass, _name11479)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11480; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _hashCode11480); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _hashCode11480); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11481; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallBooleanMethod(this, _equals11481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Enum.staticClass, _equals11481, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11482; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _compareTo11482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _compareTo11482, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo11483; 
		public virtual int compareTo(java.lang.Enum arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _compareTo11483, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _compareTo11483, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11484; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11484)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Enum.staticClass, _toString11484)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf11485; 
		public static java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Enum>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Enum.staticClass, _valueOf11485, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass11486; 
		public virtual java.lang.Class getDeclaringClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, _getDeclaringClass11486)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Enum.staticClass, _getDeclaringClass11486)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ordinal11487; 
		public virtual int ordinal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _ordinal11487); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _ordinal11487); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Enum11488; 
		protected Enum(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Enum.staticClass, _Enum11488, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.lang.Enum.staticClass = @__class; 
			global::java.lang.Enum._name11479 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;"); 
			global::java.lang.Enum._hashCode11480 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "hashCode", "()I"); 
			global::java.lang.Enum._equals11481 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.lang.Enum._compareTo11482 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.lang.Enum._compareTo11483 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I"); 
			global::java.lang.Enum._toString11484 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.lang.Enum._valueOf11485 = @__env.GetStaticMethodID(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;"); 
			global::java.lang.Enum._getDeclaringClass11486 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;"); 
			global::java.lang.Enum._ordinal11487 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "ordinal", "()I"); 
			global::java.lang.Enum._Enum11488 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
		} 
	} 
} 
