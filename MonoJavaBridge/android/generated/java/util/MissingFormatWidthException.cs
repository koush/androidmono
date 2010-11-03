namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MissingFormatWidthException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MissingFormatWidthException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingFormatWidthException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.MissingFormatWidthException._m0) as java.lang.String;
		}
		public new global::java.lang.String FormatSpecifier
		{
			get
			{
				return getFormatSpecifier();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getFormatSpecifier()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.MissingFormatWidthException.staticClass, "getFormatSpecifier", "()Ljava/lang/String;", ref global::java.util.MissingFormatWidthException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public MissingFormatWidthException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.MissingFormatWidthException._m2.native == global::System.IntPtr.Zero)
				global::java.util.MissingFormatWidthException._m2 = @__env.GetMethodIDNoThrow(global::java.util.MissingFormatWidthException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.MissingFormatWidthException.staticClass, global::java.util.MissingFormatWidthException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MissingFormatWidthException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.MissingFormatWidthException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/MissingFormatWidthException"));
		}
	}
}
