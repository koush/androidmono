namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidPropertiesFormatException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidPropertiesFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public InvalidPropertiesFormatException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.InvalidPropertiesFormatException._m0.native == global::System.IntPtr.Zero)
				global::java.util.InvalidPropertiesFormatException._m0 = @__env.GetMethodIDNoThrow(global::java.util.InvalidPropertiesFormatException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InvalidPropertiesFormatException.staticClass, global::java.util.InvalidPropertiesFormatException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InvalidPropertiesFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.InvalidPropertiesFormatException._m1.native == global::System.IntPtr.Zero)
				global::java.util.InvalidPropertiesFormatException._m1 = @__env.GetMethodIDNoThrow(global::java.util.InvalidPropertiesFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.InvalidPropertiesFormatException.staticClass, global::java.util.InvalidPropertiesFormatException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static InvalidPropertiesFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.InvalidPropertiesFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/InvalidPropertiesFormatException"));
		}
	}
}
