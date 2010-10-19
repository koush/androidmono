namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypeNotPresentException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TypeNotPresentException()
		{
			InitJNI();
		}
		protected TypeNotPresentException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _typeName15280;
		public virtual global::java.lang.String typeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.TypeNotPresentException._typeName15280)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.TypeNotPresentException.staticClass, global::java.lang.TypeNotPresentException._typeName15280)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TypeNotPresentException15281;
		public TypeNotPresentException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.TypeNotPresentException.staticClass, global::java.lang.TypeNotPresentException._TypeNotPresentException15281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.TypeNotPresentException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/TypeNotPresentException"));
			global::java.lang.TypeNotPresentException._typeName15280 = @__env.GetMethodIDNoThrow(global::java.lang.TypeNotPresentException.staticClass, "typeName", "()Ljava/lang/String;");
			global::java.lang.TypeNotPresentException._TypeNotPresentException15281 = @__env.GetMethodIDNoThrow(global::java.lang.TypeNotPresentException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
