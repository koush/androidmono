namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypeNotPresentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypeNotPresentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _typeName20921;
		public virtual global::java.lang.String typeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.TypeNotPresentException._typeName20921)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.TypeNotPresentException.staticClass, global::java.lang.TypeNotPresentException._typeName20921)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TypeNotPresentException20922;
		public TypeNotPresentException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.TypeNotPresentException.staticClass, global::java.lang.TypeNotPresentException._TypeNotPresentException20922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TypeNotPresentException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.TypeNotPresentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/TypeNotPresentException"));
			global::java.lang.TypeNotPresentException._typeName20921 = @__env.GetMethodIDNoThrow(global::java.lang.TypeNotPresentException.staticClass, "typeName", "()Ljava/lang/String;");
			global::java.lang.TypeNotPresentException._TypeNotPresentException20922 = @__env.GetMethodIDNoThrow(global::java.lang.TypeNotPresentException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
