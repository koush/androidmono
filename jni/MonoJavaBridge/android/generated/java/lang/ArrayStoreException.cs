namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayStoreException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrayStoreException()
		{
			InitJNI();
		}
		protected ArrayStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ArrayStoreException19597;
		public ArrayStoreException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayStoreException.staticClass, global::java.lang.ArrayStoreException._ArrayStoreException19597);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayStoreException19598;
		public ArrayStoreException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayStoreException.staticClass, global::java.lang.ArrayStoreException._ArrayStoreException19598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ArrayStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ArrayStoreException"));
			global::java.lang.ArrayStoreException._ArrayStoreException19597 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayStoreException.staticClass, "<init>", "()V");
			global::java.lang.ArrayStoreException._ArrayStoreException19598 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
