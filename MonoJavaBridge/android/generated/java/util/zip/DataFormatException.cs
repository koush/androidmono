namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataFormatException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public DataFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DataFormatException._m0.native == global::System.IntPtr.Zero)
				global::java.util.zip.DataFormatException._m0 = @__env.GetMethodIDNoThrow(global::java.util.zip.DataFormatException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DataFormatException.staticClass, global::java.util.zip.DataFormatException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public DataFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.DataFormatException._m1.native == global::System.IntPtr.Zero)
				global::java.util.zip.DataFormatException._m1 = @__env.GetMethodIDNoThrow(global::java.util.zip.DataFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.DataFormatException.staticClass, global::java.util.zip.DataFormatException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DataFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.DataFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/DataFormatException"));
		}
	}
}
