namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SerializablePermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SerializablePermission()
		{
			InitJNI();
		}
		internal SerializablePermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SerializablePermission19573;
		public SerializablePermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SerializablePermission.staticClass, global::java.io.SerializablePermission._SerializablePermission19573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SerializablePermission19574;
		public SerializablePermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SerializablePermission.staticClass, global::java.io.SerializablePermission._SerializablePermission19574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.SerializablePermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/SerializablePermission"));
			global::java.io.SerializablePermission._SerializablePermission19573 = @__env.GetMethodIDNoThrow(global::java.io.SerializablePermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.io.SerializablePermission._SerializablePermission19574 = @__env.GetMethodIDNoThrow(global::java.io.SerializablePermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
