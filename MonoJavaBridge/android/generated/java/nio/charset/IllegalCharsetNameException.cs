namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalCharsetNameException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalCharsetNameException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String CharsetName
		{
			get
			{
				return getCharsetName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCharsetName22813;
		public virtual global::java.lang.String getCharsetName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.IllegalCharsetNameException._getCharsetName22813.native == global::System.IntPtr.Zero)
				global::java.nio.charset.IllegalCharsetNameException._getCharsetName22813 = @__env.GetMethodIDNoThrow(global::java.nio.charset.IllegalCharsetNameException.staticClass, "getCharsetName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.IllegalCharsetNameException.staticClass, global::java.nio.charset.IllegalCharsetNameException._getCharsetName22813) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _IllegalCharsetNameException22814;
		public IllegalCharsetNameException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.IllegalCharsetNameException._IllegalCharsetNameException22814.native == global::System.IntPtr.Zero)
				global::java.nio.charset.IllegalCharsetNameException._IllegalCharsetNameException22814 = @__env.GetMethodIDNoThrow(global::java.nio.charset.IllegalCharsetNameException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.IllegalCharsetNameException.staticClass, global::java.nio.charset.IllegalCharsetNameException._IllegalCharsetNameException22814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalCharsetNameException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.IllegalCharsetNameException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/IllegalCharsetNameException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
