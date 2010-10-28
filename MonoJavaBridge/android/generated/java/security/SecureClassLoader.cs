namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SecureClassLoader : java.lang.ClassLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecureClassLoader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _defineClass23299;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, java.nio.ByteBuffer arg1, java.security.CodeSource arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SecureClassLoader._defineClass23299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SecureClassLoader.staticClass, global::java.security.SecureClassLoader._defineClass23299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _defineClass23300;
		protected virtual global::java.lang.Class defineClass(java.lang.String arg0, byte[] arg1, int arg2, int arg3, java.security.CodeSource arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SecureClassLoader._defineClass23300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SecureClassLoader.staticClass, global::java.security.SecureClassLoader._defineClass23300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getPermissions23301;
		protected virtual global::java.security.PermissionCollection getPermissions(java.security.CodeSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SecureClassLoader._getPermissions23301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SecureClassLoader.staticClass, global::java.security.SecureClassLoader._getPermissions23301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PermissionCollection;
		}
		internal static global::MonoJavaBridge.MethodId _SecureClassLoader23302;
		protected SecureClassLoader(java.lang.ClassLoader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureClassLoader.staticClass, global::java.security.SecureClassLoader._SecureClassLoader23302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecureClassLoader23303;
		protected SecureClassLoader() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecureClassLoader.staticClass, global::java.security.SecureClassLoader._SecureClassLoader23303);
			Init(@__env, handle);
		}
		static SecureClassLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecureClassLoader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecureClassLoader"));
			global::java.security.SecureClassLoader._defineClass23299 = @__env.GetMethodIDNoThrow(global::java.security.SecureClassLoader.staticClass, "defineClass", "(Ljava/lang/String;Ljava/nio/ByteBuffer;Ljava/security/CodeSource;)Ljava/lang/Class;");
			global::java.security.SecureClassLoader._defineClass23300 = @__env.GetMethodIDNoThrow(global::java.security.SecureClassLoader.staticClass, "defineClass", "(Ljava/lang/String;[BIILjava/security/CodeSource;)Ljava/lang/Class;");
			global::java.security.SecureClassLoader._getPermissions23301 = @__env.GetMethodIDNoThrow(global::java.security.SecureClassLoader.staticClass, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;");
			global::java.security.SecureClassLoader._SecureClassLoader23302 = @__env.GetMethodIDNoThrow(global::java.security.SecureClassLoader.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::java.security.SecureClassLoader._SecureClassLoader23303 = @__env.GetMethodIDNoThrow(global::java.security.SecureClassLoader.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
