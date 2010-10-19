namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidPropertiesFormatException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InvalidPropertiesFormatException()
		{
			InitJNI();
		}
		protected InvalidPropertiesFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPropertiesFormatException20386;
		public InvalidPropertiesFormatException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InvalidPropertiesFormatException.staticClass, global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException20386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPropertiesFormatException20387;
		public InvalidPropertiesFormatException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InvalidPropertiesFormatException.staticClass, global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException20387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.InvalidPropertiesFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/InvalidPropertiesFormatException"));
			global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException20386 = @__env.GetMethodIDNoThrow(global::java.util.InvalidPropertiesFormatException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException20387 = @__env.GetMethodIDNoThrow(global::java.util.InvalidPropertiesFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
