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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getCharsetName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.charset.IllegalCharsetNameException.staticClass, "getCharsetName", "()Ljava/lang/String;", ref global::java.nio.charset.IllegalCharsetNameException._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public IllegalCharsetNameException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.charset.IllegalCharsetNameException._m1.native == global::System.IntPtr.Zero)
				global::java.nio.charset.IllegalCharsetNameException._m1 = @__env.GetMethodIDNoThrow(global::java.nio.charset.IllegalCharsetNameException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.IllegalCharsetNameException.staticClass, global::java.nio.charset.IllegalCharsetNameException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalCharsetNameException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.IllegalCharsetNameException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/IllegalCharsetNameException"));
		}
	}
}
