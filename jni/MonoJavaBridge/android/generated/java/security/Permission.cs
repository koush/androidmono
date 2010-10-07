namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Permission : java.lang.Object, Guard, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Permission()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.Permission), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Permission(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13220;
		public abstract new bool equals(java.lang.Object arg0);
		internal static global::net.sf.jni4net.jni.MethodId _toString13221;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Permission._toString13221));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Permission.staticClass, global::java.security.Permission._toString13221));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13222;
		public abstract new int hashCode();
		internal static global::net.sf.jni4net.jni.MethodId _getName13223;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Permission._getName13223));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Permission.staticClass, global::java.security.Permission._getName13223));
		}
		internal static global::net.sf.jni4net.jni.MethodId _implies13224;
		public abstract bool implies(java.security.Permission arg0);
		internal static global::net.sf.jni4net.jni.MethodId _getActions13225;
		public abstract global::java.lang.String getActions();
		internal static global::net.sf.jni4net.jni.MethodId _newPermissionCollection13226;
		public virtual global::java.security.PermissionCollection newPermissionCollection() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Permission._newPermissionCollection13226));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.PermissionCollection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Permission.staticClass, global::java.security.Permission._newPermissionCollection13226));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkGuard13227;
		public virtual void checkGuard(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.Permission._checkGuard13227, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.Permission.staticClass, global::java.security.Permission._checkGuard13227, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Permission13228;
		public Permission(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.Permission.staticClass, global::java.security.Permission._Permission13228, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.Permission.staticClass = @__class;
			global::java.security.Permission._equals13220 = @__env.GetMethodID(global::java.security.Permission.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Permission._toString13221 = @__env.GetMethodID(global::java.security.Permission.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Permission._hashCode13222 = @__env.GetMethodID(global::java.security.Permission.staticClass, "hashCode", "()I");
			global::java.security.Permission._getName13223 = @__env.GetMethodID(global::java.security.Permission.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Permission._implies13224 = @__env.GetMethodID(global::java.security.Permission.staticClass, "implies", "(Ljava/security/Permission;)Z");
			global::java.security.Permission._getActions13225 = @__env.GetMethodID(global::java.security.Permission.staticClass, "getActions", "()Ljava/lang/String;");
			global::java.security.Permission._newPermissionCollection13226 = @__env.GetMethodID(global::java.security.Permission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;");
			global::java.security.Permission._checkGuard13227 = @__env.GetMethodID(global::java.security.Permission.staticClass, "checkGuard", "(Ljava/lang/Object;)V");
			global::java.security.Permission._Permission13228 = @__env.GetMethodID(global::java.security.Permission.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
