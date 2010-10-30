namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnumConstantNotPresentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EnumConstantNotPresentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enumType20126;
		public virtual global::java.lang.Class enumType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.EnumConstantNotPresentException.staticClass, "enumType", "()Ljava/lang/Class;", ref global::java.lang.EnumConstantNotPresentException._enumType20126) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _constantName20127;
		public virtual global::java.lang.String constantName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.EnumConstantNotPresentException.staticClass, "constantName", "()Ljava/lang/String;", ref global::java.lang.EnumConstantNotPresentException._constantName20127) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _EnumConstantNotPresentException20128;
		public EnumConstantNotPresentException(java.lang.Class arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.EnumConstantNotPresentException._EnumConstantNotPresentException20128.native == global::System.IntPtr.Zero)
				global::java.lang.EnumConstantNotPresentException._EnumConstantNotPresentException20128 = @__env.GetMethodIDNoThrow(global::java.lang.EnumConstantNotPresentException.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.EnumConstantNotPresentException.staticClass, global::java.lang.EnumConstantNotPresentException._EnumConstantNotPresentException20128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static EnumConstantNotPresentException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.EnumConstantNotPresentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/EnumConstantNotPresentException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
