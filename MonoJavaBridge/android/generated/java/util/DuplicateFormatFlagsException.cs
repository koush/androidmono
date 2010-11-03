namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DuplicateFormatFlagsException : java.util.IllegalFormatException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DuplicateFormatFlagsException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.DuplicateFormatFlagsException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.DuplicateFormatFlagsException._m0) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.DuplicateFormatFlagsException.staticClass, "getFlags", "()Ljava/lang/String;", ref global::java.util.DuplicateFormatFlagsException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DuplicateFormatFlagsException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.DuplicateFormatFlagsException._m2.native == global::System.IntPtr.Zero)
				global::java.util.DuplicateFormatFlagsException._m2 = @__env.GetMethodIDNoThrow(global::java.util.DuplicateFormatFlagsException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.DuplicateFormatFlagsException.staticClass, global::java.util.DuplicateFormatFlagsException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DuplicateFormatFlagsException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.DuplicateFormatFlagsException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/DuplicateFormatFlagsException"));
		}
	}
}
