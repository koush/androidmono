namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Void : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Void()
		{
			InitJNI();
		}
		internal Void(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _TYPE20818;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.lang.Void.staticClass, _TYPE20818)) as java.lang.Class;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Void.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Void"));
			global::java.lang.Void._TYPE20818 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Void.staticClass, "TYPE", "Ljava/lang/Class;");
		}
	}
}
