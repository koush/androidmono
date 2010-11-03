namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IllegalFormatWidthException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IllegalFormatWidthException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.IllegalFormatWidthException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.IllegalFormatWidthException._m0) as java.lang.String;
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.IllegalFormatWidthException.staticClass, "getWidth", "()I", ref global::java.util.IllegalFormatWidthException._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public IllegalFormatWidthException(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.IllegalFormatWidthException._m2.native == global::System.IntPtr.Zero)
				global::java.util.IllegalFormatWidthException._m2 = @__env.GetMethodIDNoThrow(global::java.util.IllegalFormatWidthException.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.IllegalFormatWidthException.staticClass, global::java.util.IllegalFormatWidthException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static IllegalFormatWidthException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.IllegalFormatWidthException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/IllegalFormatWidthException"));
		}
	}
}
