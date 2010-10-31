namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Permission_))]
	public abstract partial class Permission : java.lang.Object, Guard, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Permission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract bool equals(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Permission.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Permission._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract int hashCode();
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Permission.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.Permission._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool implies(java.security.Permission arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.String getActions();
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.PermissionCollection newPermissionCollection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Permission.staticClass, "newPermissionCollection", "()Ljava/security/PermissionCollection;", ref global::java.security.Permission._m6) as java.security.PermissionCollection;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void checkGuard(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Permission.staticClass, "checkGuard", "(Ljava/lang/Object;)V", ref global::java.security.Permission._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public Permission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Permission._m8.native == global::System.IntPtr.Zero)
				global::java.security.Permission._m8 = @__env.GetMethodIDNoThrow(global::java.security.Permission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Permission.staticClass, global::java.security.Permission._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Permission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permission"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Permission))]
	internal sealed partial class Permission_ : java.security.Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Permission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Permission_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.Permission_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Permission_.staticClass, "hashCode", "()I", ref global::java.security.Permission_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Permission_.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.Permission_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String getActions()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Permission_.staticClass, "getActions", "()Ljava/lang/String;", ref global::java.security.Permission_._m3) as java.lang.String;
		}
		static Permission_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Permission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Permission"));
		}
	}
}
