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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12440; 
		public abstract new int hashCode(); 
		internal static global::net.sf.jni4net.jni.MethodId _equals12441; 
		public abstract new bool equals(java.lang.Object arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _toString12442; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12442)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Permission.staticClass, _toString12442)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName12443; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName12443)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Permission.staticClass, _getName12443)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _implies12444; 
		public abstract bool implies(java.security.Permission arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getActions12445; 
		public abstract java.lang.String getActions(); 
		internal static global::net.sf.jni4net.jni.MethodId _newPermissionCollection12446; 
		public virtual java.security.PermissionCollection newPermissionCollection() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallObjectMethodPtr(this, _newPermissionCollection12446)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.security.Permission.staticClass, _newPermissionCollection12446)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkGuard12447; 
		public virtual void checkGuard(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.security.Permission)) 
				@__env.CallVoidMethod(this, _checkGuard12447, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.security.Permission.staticClass, _checkGuard12447, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Permission12448; 
		public Permission(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.security.Permission.staticClass, _Permission12448, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.security.Permission.staticClass = @__class; 
			global::java.security.Permission._hashCode12440 = @__env.GetMethodID(global::java.security.Permission.staticClass, "hashCode", "()I"); 
			global::java.security.Permission._equals12441 = @__env.GetMethodID(global::java.security.Permission.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.security.Permission._toString12442 = @__env.GetMethodID(global::java.security.Permission.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.security.Permission._getName12443 = @__env.GetMethodID(global::java.security.Permission.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.security.Permission._implies12444 = @__env.GetMethodID(global::java.security.Permission.staticClass, "implies", "(Ljava/security/Permission;)Z"); 
			global::java.security.Permission._getActions12445 = @__env.GetMethodID(global::java.security.Permission.staticClass, "getActions", "()Ljava/lang/String;"); 
			global::java.security.Permission._newPermissionCollection12446 = @__env.GetMethodID(global::java.security.Permission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;"); 
			global::java.security.Permission._checkGuard12447 = @__env.GetMethodID(global::java.security.Permission.staticClass, "checkGuard", "(Ljava/lang/Object;)V"); 
			global::java.security.Permission._Permission12448 = @__env.GetMethodID(global::java.security.Permission.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
