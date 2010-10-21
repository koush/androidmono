namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UTFDataFormatException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UTFDataFormatException()
		{
			InitJNI();
		}
		protected UTFDataFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UTFDataFormatException19513;
		public UTFDataFormatException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UTFDataFormatException.staticClass, global::java.io.UTFDataFormatException._UTFDataFormatException19513);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UTFDataFormatException19514;
		public UTFDataFormatException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UTFDataFormatException.staticClass, global::java.io.UTFDataFormatException._UTFDataFormatException19514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.UTFDataFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/UTFDataFormatException"));
			global::java.io.UTFDataFormatException._UTFDataFormatException19513 = @__env.GetMethodIDNoThrow(global::java.io.UTFDataFormatException.staticClass, "<init>", "()V");
			global::java.io.UTFDataFormatException._UTFDataFormatException19514 = @__env.GetMethodIDNoThrow(global::java.io.UTFDataFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
