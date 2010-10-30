namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidPropertiesFormatException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidPropertiesFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPropertiesFormatException26330;
		public InvalidPropertiesFormatException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException26330.native == global::System.IntPtr.Zero)
				global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException26330 = @__env.GetMethodIDNoThrow(global::java.util.InvalidPropertiesFormatException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InvalidPropertiesFormatException.staticClass, global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException26330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InvalidPropertiesFormatException26331;
		public InvalidPropertiesFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException26331.native == global::System.IntPtr.Zero)
				global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException26331 = @__env.GetMethodIDNoThrow(global::java.util.InvalidPropertiesFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InvalidPropertiesFormatException.staticClass, global::java.util.InvalidPropertiesFormatException._InvalidPropertiesFormatException26331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidPropertiesFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.InvalidPropertiesFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/InvalidPropertiesFormatException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
