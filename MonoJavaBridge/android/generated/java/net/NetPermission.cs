namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class NetPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NetPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _NetPermission21629;
		public NetPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NetPermission.staticClass, global::java.net.NetPermission._NetPermission21629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NetPermission21630;
		public NetPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.NetPermission.staticClass, global::java.net.NetPermission._NetPermission21630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static NetPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.NetPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/NetPermission"));
			global::java.net.NetPermission._NetPermission21629 = @__env.GetMethodIDNoThrow(global::java.net.NetPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.NetPermission._NetPermission21630 = @__env.GetMethodIDNoThrow(global::java.net.NetPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
