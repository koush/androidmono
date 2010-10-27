namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CharConversionException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CharConversionException()
		{
			InitJNI();
		}
		protected CharConversionException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CharConversionException18881;
		public CharConversionException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharConversionException.staticClass, global::java.io.CharConversionException._CharConversionException18881);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CharConversionException18882;
		public CharConversionException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.CharConversionException.staticClass, global::java.io.CharConversionException._CharConversionException18882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.CharConversionException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/CharConversionException"));
			global::java.io.CharConversionException._CharConversionException18881 = @__env.GetMethodIDNoThrow(global::java.io.CharConversionException.staticClass, "<init>", "()V");
			global::java.io.CharConversionException._CharConversionException18882 = @__env.GetMethodIDNoThrow(global::java.io.CharConversionException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
