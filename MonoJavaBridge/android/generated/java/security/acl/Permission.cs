namespace java.security.acl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.acl.Permission_))]
	public partial interface Permission  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.acl.Permission))]
	internal sealed partial class Permission_ : java.lang.Object, Permission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Permission_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23465;
		bool java.security.acl.Permission.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Permission_._equals23465.native == global::System.IntPtr.Zero)
				global::java.security.acl.Permission_._equals23465 = @__env.GetMethodIDNoThrow(global::java.security.acl.Permission_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.acl.Permission_._equals23465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23466;
		global::java.lang.String java.security.acl.Permission.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.acl.Permission_._toString23466.native == global::System.IntPtr.Zero)
				global::java.security.acl.Permission_._toString23466 = @__env.GetMethodIDNoThrow(global::java.security.acl.Permission_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.acl.Permission_._toString23466)) as java.lang.String;
		}
		static Permission_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.acl.Permission_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/acl/Permission"));
		}
		internal static void InitJNI()
		{
		}
	}
}
