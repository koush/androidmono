namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SecurityPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecurityPermission()
		{
			InitJNI();
		}
		internal SecurityPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SecurityPermission23335;
		public SecurityPermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecurityPermission.staticClass, global::java.security.SecurityPermission._SecurityPermission23335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SecurityPermission23336;
		public SecurityPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecurityPermission.staticClass, global::java.security.SecurityPermission._SecurityPermission23336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecurityPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecurityPermission"));
			global::java.security.SecurityPermission._SecurityPermission23335 = @__env.GetMethodIDNoThrow(global::java.security.SecurityPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.SecurityPermission._SecurityPermission23336 = @__env.GetMethodIDNoThrow(global::java.security.SecurityPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
