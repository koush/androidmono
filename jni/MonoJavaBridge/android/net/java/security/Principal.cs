namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Principal 
	{ 
		int hashCode(); 
		bool equals(java.lang.Object arg0); 
		java.lang.String toString(); 
		java.lang.String getName(); 
	} 

	public partial class Principal_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Principal.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Principal : java.lang.Object, Principal
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Principal() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.__Principal), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.security.__Principal(@__env); 
			} 
		} 
		internal __Principal(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12456; 
		 int java.security.Principal.hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.__Principal)) 
				return @__env.CallIntMethod(this, _hashCode12456); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.security.__Principal.staticClass, _hashCode12456); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals12457; 
		 bool java.security.Principal.equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.__Principal)) 
				return @__env.CallBooleanMethod(this, _equals12457, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.security.__Principal.staticClass, _equals12457, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString12458; 
		 java.lang.String java.security.Principal.toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.__Principal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12458)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.__Principal.staticClass, _toString12458)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName12459; 
		 java.lang.String java.security.Principal.getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.__Principal)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName12459)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.__Principal.staticClass, _getName12459)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.__Principal.staticClass = @__class; 
			global::java.security.__Principal._hashCode12456 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.hashCode", "()I"); 
			global::java.security.__Principal._equals12457 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.__Principal._toString12458 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.toString", "()Ljava/lang/String;"); 
			global::java.security.__Principal._getName12459 = @__env.GetMethodID(global::java.security.__Principal.staticClass, "java.security.Principal.getName", "()Ljava/lang/String;"); 
		} 
	} 
} 
