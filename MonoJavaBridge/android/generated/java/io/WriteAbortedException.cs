namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WriteAbortedException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WriteAbortedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.io.WriteAbortedException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::java.io.WriteAbortedException._m0) as java.lang.Throwable;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.io.WriteAbortedException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.io.WriteAbortedException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public WriteAbortedException(java.lang.String arg0, java.lang.Exception arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.WriteAbortedException._m2.native == global::System.IntPtr.Zero)
				global::java.io.WriteAbortedException._m2 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _detail6240;
		public global::java.lang.Exception detail
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _detail6240)) as java.lang.Exception;
			}
			set
			{
			}
		}
		static WriteAbortedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.WriteAbortedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/WriteAbortedException"));
			global::java.io.WriteAbortedException._detail6240 = @__env.GetFieldIDNoThrow(global::java.io.WriteAbortedException.staticClass, "detail", "Ljava/lang/Exception;");
		}
	}
}
