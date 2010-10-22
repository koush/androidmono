namespace java.nio.charset
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalCharsetNameException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static IllegalCharsetNameException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCharsetName22694;
		public virtual global::java.lang.String getCharsetName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.IllegalCharsetNameException._getCharsetName22694)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.IllegalCharsetNameException.staticClass, global::java.nio.charset.IllegalCharsetNameException._getCharsetName22694)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _IllegalCharsetNameException22695;
		public IllegalCharsetNameException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.IllegalCharsetNameException.staticClass, global::java.nio.charset.IllegalCharsetNameException._IllegalCharsetNameException22695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.IllegalCharsetNameException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/IllegalCharsetNameException"));
			global::java.nio.charset.IllegalCharsetNameException._getCharsetName22694 = @__env.GetMethodIDNoThrow(global::java.nio.charset.IllegalCharsetNameException.staticClass, "getCharsetName", "()Ljava/lang/String;");
			global::java.nio.charset.IllegalCharsetNameException._IllegalCharsetNameException22695 = @__env.GetMethodIDNoThrow(global::java.nio.charset.IllegalCharsetNameException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
