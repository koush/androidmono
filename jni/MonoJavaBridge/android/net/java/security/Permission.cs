namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Permission : java.lang.Object, Guard, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Permission() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.security.Permission), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Permission(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11572; 
		public abstract new int hashCode(); 
		internal static global::net.sf.jni4net.jni.MethodId _equals11573; 
		public abstract new bool equals(java.lang.Object arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _toString11574; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11574)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Permission.staticClass, _toString11574)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName11575; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName11575)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Permission.staticClass, _getName11575)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies11576; 
		public abstract bool implies(java.security.Permission arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getActions11577; 
		public abstract java.lang.String getActions(); 
		internal static global::net.sf.jni4net.jni.MethodId _newPermissionCollection11578; 
		public virtual java.security.PermissionCollection newPermissionCollection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallObjectMethodPtr(this, _newPermissionCollection11578)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Permission.staticClass, _newPermissionCollection11578)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkGuard11579; 
		public virtual void checkGuard(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				@__env.CallVoidMethod(this, _checkGuard11579, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.security.Permission.staticClass, _checkGuard11579, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Permission11580; 
		public Permission(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.Permission.staticClass, _Permission11580, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.Permission.staticClass = @__class; 
			global::java.security.Permission._hashCode11572 = @__env.GetMethodID(global::java.security.Permission.staticClass, "hashCode", "()I"); 
			global::java.security.Permission._equals11573 = @__env.GetMethodID(global::java.security.Permission.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.Permission._toString11574 = @__env.GetMethodID(global::java.security.Permission.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.Permission._getName11575 = @__env.GetMethodID(global::java.security.Permission.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.security.Permission._implies11576 = @__env.GetMethodID(global::java.security.Permission.staticClass, "implies", "(Ljava/security/Permission;)Z"); 
			global::java.security.Permission._getActions11577 = @__env.GetMethodID(global::java.security.Permission.staticClass, "getActions", "()Ljava/lang/String;"); 
			global::java.security.Permission._newPermissionCollection11578 = @__env.GetMethodID(global::java.security.Permission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;"); 
			global::java.security.Permission._checkGuard11579 = @__env.GetMethodID(global::java.security.Permission.staticClass, "checkGuard", "(Ljava/lang/Object;)V"); 
			global::java.security.Permission._Permission11580 = @__env.GetMethodID(global::java.security.Permission.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
