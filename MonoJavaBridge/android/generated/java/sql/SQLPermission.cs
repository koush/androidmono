namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SQLPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SQLPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLPermission25031;
		public SQLPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLPermission._SQLPermission25031.native == global::System.IntPtr.Zero)
				global::java.sql.SQLPermission._SQLPermission25031 = @__env.GetMethodIDNoThrow(global::java.sql.SQLPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLPermission.staticClass, global::java.sql.SQLPermission._SQLPermission25031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLPermission25032;
		public SQLPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.SQLPermission._SQLPermission25032.native == global::System.IntPtr.Zero)
				global::java.sql.SQLPermission._SQLPermission25032 = @__env.GetMethodIDNoThrow(global::java.sql.SQLPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLPermission.staticClass, global::java.sql.SQLPermission._SQLPermission25032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SQLPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLPermission"));
		}
		internal static void InitJNI()
		{
		}
	}
}
