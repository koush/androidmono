namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayIndexOutOfBoundsException : java.lang.IndexOutOfBoundsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrayIndexOutOfBoundsException()
		{
			InitJNI();
		}
		protected ArrayIndexOutOfBoundsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ArrayIndexOutOfBoundsException19712;
		public ArrayIndexOutOfBoundsException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayIndexOutOfBoundsException.staticClass, global::java.lang.ArrayIndexOutOfBoundsException._ArrayIndexOutOfBoundsException19712);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayIndexOutOfBoundsException19713;
		public ArrayIndexOutOfBoundsException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayIndexOutOfBoundsException.staticClass, global::java.lang.ArrayIndexOutOfBoundsException._ArrayIndexOutOfBoundsException19713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayIndexOutOfBoundsException19714;
		public ArrayIndexOutOfBoundsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ArrayIndexOutOfBoundsException.staticClass, global::java.lang.ArrayIndexOutOfBoundsException._ArrayIndexOutOfBoundsException19714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ArrayIndexOutOfBoundsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ArrayIndexOutOfBoundsException"));
			global::java.lang.ArrayIndexOutOfBoundsException._ArrayIndexOutOfBoundsException19712 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayIndexOutOfBoundsException.staticClass, "<init>", "()V");
			global::java.lang.ArrayIndexOutOfBoundsException._ArrayIndexOutOfBoundsException19713 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayIndexOutOfBoundsException.staticClass, "<init>", "(I)V");
			global::java.lang.ArrayIndexOutOfBoundsException._ArrayIndexOutOfBoundsException19714 = @__env.GetMethodIDNoThrow(global::java.lang.ArrayIndexOutOfBoundsException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
