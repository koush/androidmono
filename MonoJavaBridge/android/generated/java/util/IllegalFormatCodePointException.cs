namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatCodePointException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalFormatCodePointException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.IllegalFormatCodePointException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.IllegalFormatCodePointException._m0) as java.lang.String;
		}
		public new int CodePoint
		{
			get
			{
				return getCodePoint();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getCodePoint()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.IllegalFormatCodePointException.staticClass, "getCodePoint", "()I", ref global::java.util.IllegalFormatCodePointException._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public IllegalFormatCodePointException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.IllegalFormatCodePointException._m2.native == global::System.IntPtr.Zero)
				global::java.util.IllegalFormatCodePointException._m2 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatCodePointException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatCodePointException.staticClass, global::java.util.IllegalFormatCodePointException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalFormatCodePointException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatCodePointException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatCodePointException"));
		}
	}
}
