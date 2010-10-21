namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SQLPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLPermission()
		{
			InitJNI();
		}
		internal SQLPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SQLPermission24912;
		public SQLPermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLPermission.staticClass, global::java.sql.SQLPermission._SQLPermission24912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SQLPermission24913;
		public SQLPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.SQLPermission.staticClass, global::java.sql.SQLPermission._SQLPermission24913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.SQLPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/SQLPermission"));
			global::java.sql.SQLPermission._SQLPermission24912 = @__env.GetMethodIDNoThrow(global::java.sql.SQLPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.sql.SQLPermission._SQLPermission24913 = @__env.GetMethodIDNoThrow(global::java.sql.SQLPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
