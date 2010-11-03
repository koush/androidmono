namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidClassException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidClassException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.InvalidClassException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.io.InvalidClassException._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public InvalidClassException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InvalidClassException._m1.native == global::System.IntPtr.Zero)
				global::java.io.InvalidClassException._m1 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public InvalidClassException(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.InvalidClassException._m2.native == global::System.IntPtr.Zero)
				global::java.io.InvalidClassException._m2 = @__env.GetMethodIDNoThrow(global::java.io.InvalidClassException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.InvalidClassException.staticClass, global::java.io.InvalidClassException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _classname6200;
		public global::java.lang.String classname
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _classname6200)) as java.lang.String;
			}
			set
			{
			}
		}
		static InvalidClassException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.InvalidClassException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/InvalidClassException"));
			global::java.io.InvalidClassException._classname6200 = @__env.GetFieldIDNoThrow(global::java.io.InvalidClassException.staticClass, "classname", "Ljava/lang/String;");
		}
	}
}
