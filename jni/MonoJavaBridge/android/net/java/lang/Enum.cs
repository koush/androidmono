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
		internal static global::net.sf.jni4net.jni.MethodId _name10656; 
		public virtual java.lang.String name() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _name10656)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Enum.staticClass, _name10656)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode10657; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _hashCode10657); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _hashCode10657); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals10658; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallBooleanMethod(this, _equals10658, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.lang.Enum.staticClass, _equals10658, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo10659; 
		public virtual int compareTo(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _compareTo10659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _compareTo10659, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compareTo10660; 
		public virtual int compareTo(java.lang.Enum arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _compareTo10660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _compareTo10660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10661; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10661)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Enum.staticClass, _toString10661)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _valueOf10662; 
		public static java.lang.Enum valueOf(java.lang.Class arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Enum>(@__env, @__env.CallStaticObjectMethodPtr(java.lang.Enum.staticClass, _valueOf10662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeclaringClass10663; 
		public virtual java.lang.Class getDeclaringClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, _getDeclaringClass10663)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.lang.Enum.staticClass, _getDeclaringClass10663)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ordinal10664; 
		public virtual int ordinal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.lang.Enum)) 
				return @__env.CallIntMethod(this, _ordinal10664); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.lang.Enum.staticClass, _ordinal10664); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Enum10665; 
		protected Enum(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.lang.Enum.staticClass, _Enum10665, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.lang.Enum.staticClass = @__class; 
			global::java.lang.Enum._name10656 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "name", "()Ljava/lang/String;"); 
			global::java.lang.Enum._hashCode10657 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "hashCode", "()I"); 
			global::java.lang.Enum._equals10658 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.lang.Enum._compareTo10659 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Object;)I"); 
			global::java.lang.Enum._compareTo10660 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "compareTo", "(Ljava/lang/Enum;)I"); 
			global::java.lang.Enum._toString10661 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.lang.Enum._valueOf10662 = @__env.GetStaticMethodID(global::java.lang.Enum.staticClass, "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;"); 
			global::java.lang.Enum._getDeclaringClass10663 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "getDeclaringClass", "()Ljava/lang/Class;"); 
			global::java.lang.Enum._ordinal10664 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "ordinal", "()I"); 
			global::java.lang.Enum._Enum10665 = @__env.GetMethodID(global::java.lang.Enum.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
		} 
	} 
} 
