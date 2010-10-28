namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Void : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Void(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _TYPE20937;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Void.staticClass, _TYPE20937)) as java.lang.Class;
			}
		}
		static Void()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Void.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Void"));
			global::java.lang.Void._TYPE20937 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Void.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
