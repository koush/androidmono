namespace junit.runner
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Version : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Version()
		{
			InitJNI();
		}
		protected Version(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _id31352;
		public static global::java.lang.String id() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.Version.staticClass, global::junit.runner.Version._id31352)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.Version.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/Version"));
			global::junit.runner.Version._id31352 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.Version.staticClass, "id", "()Ljava/lang/String;");
		}
	}
}
