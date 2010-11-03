namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UnknownFormatFlagsException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UnknownFormatFlagsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.UnknownFormatFlagsException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.UnknownFormatFlagsException._m0) as java.lang.String;
		}
		public new global::java.lang.String Flags
		{
			get
			{
				return getFlags();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.UnknownFormatFlagsException.staticClass, "getFlags", "()Ljava/lang/String;", ref global::java.util.UnknownFormatFlagsException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public UnknownFormatFlagsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.UnknownFormatFlagsException._m2.native == global::System.IntPtr.Zero)
				global::java.util.UnknownFormatFlagsException._m2 = @__env.GetMethodIDNoThrow(global::java.util.UnknownFormatFlagsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.UnknownFormatFlagsException.staticClass, global::java.util.UnknownFormatFlagsException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UnknownFormatFlagsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.UnknownFormatFlagsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/UnknownFormatFlagsException"));
		}
	}
}
