namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WriteAbortedException : java.io.ObjectStreamException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WriteAbortedException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCause19635;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException._getCause19635)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._getCause19635)) as java.lang.Throwable;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage19636;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException._getMessage19636)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._getMessage19636)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _WriteAbortedException19637;
		public WriteAbortedException(java.lang.String arg0, java.lang.Exception arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._WriteAbortedException19637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _detail19638;
		public global::java.lang.Exception detail
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _detail19638)) as java.lang.Exception;
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.WriteAbortedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/WriteAbortedException"));
			global::java.io.WriteAbortedException._getCause19635 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.io.WriteAbortedException._getMessage19636 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.io.WriteAbortedException._WriteAbortedException19637 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			global::java.io.WriteAbortedException._detail19638 = @__env.GetFieldIDNoThrow(global::java.io.WriteAbortedException.staticClass, "detail", "Ljava/lang/Exception;");
		}
	}
}
