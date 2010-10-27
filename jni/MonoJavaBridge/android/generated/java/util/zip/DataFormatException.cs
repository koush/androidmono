namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataFormatException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataFormatException()
		{
			InitJNI();
		}
		protected DataFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DataFormatException28351;
		public DataFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DataFormatException.staticClass, global::java.util.zip.DataFormatException._DataFormatException28351);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DataFormatException28352;
		public DataFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DataFormatException.staticClass, global::java.util.zip.DataFormatException._DataFormatException28352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.DataFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/DataFormatException"));
			global::java.util.zip.DataFormatException._DataFormatException28351 = @__env.GetMethodIDNoThrow(global::java.util.zip.DataFormatException.staticClass, "<init>", "()V");
			global::java.util.zip.DataFormatException._DataFormatException28352 = @__env.GetMethodIDNoThrow(global::java.util.zip.DataFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
