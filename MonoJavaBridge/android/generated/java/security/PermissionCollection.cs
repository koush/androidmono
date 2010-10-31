namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.PermissionCollection_))]
	public abstract partial class PermissionCollection : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PermissionCollection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void add(java.security.Permission arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.PermissionCollection.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.PermissionCollection._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool implies(java.security.Permission arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setReadOnly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.PermissionCollection.staticClass, "setReadOnly", "()V", ref global::java.security.PermissionCollection._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.util.Enumeration elements();
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.PermissionCollection.staticClass, "isReadOnly", "()Z", ref global::java.security.PermissionCollection._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PermissionCollection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.PermissionCollection._m6.native == global::System.IntPtr.Zero)
				global::java.security.PermissionCollection._m6 = @__env.GetMethodIDNoThrow(global::java.security.PermissionCollection.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.PermissionCollection.staticClass, global::java.security.PermissionCollection._m6);
			Init(@__env, handle);
		}
		static PermissionCollection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.PermissionCollection))]
	internal sealed partial class PermissionCollection_ : java.security.PermissionCollection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PermissionCollection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(java.security.Permission arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.PermissionCollection_.staticClass, "add", "(Ljava/security/Permission;)V", ref global::java.security.PermissionCollection_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool implies(java.security.Permission arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.PermissionCollection_.staticClass, "implies", "(Ljava/security/Permission;)Z", ref global::java.security.PermissionCollection_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.PermissionCollection_.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.security.PermissionCollection_._m2) as java.util.Enumeration;
		}
		static PermissionCollection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.PermissionCollection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/PermissionCollection"));
		}
	}
}
