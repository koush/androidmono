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
		internal static global::MonoJavaBridge.MethodId _getCause14011;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException._getCause14011)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._getCause14011)) as java.lang.Throwable;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage14012;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException._getMessage14012)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._getMessage14012)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _WriteAbortedException14013;
		public WriteAbortedException(java.lang.String arg0, java.lang.Exception arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.WriteAbortedException.staticClass, global::java.io.WriteAbortedException._WriteAbortedException14013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _detail14014;
		public global::java.lang.Exception detail
		{
			get
			{
				return default(global::java.lang.Exception);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.WriteAbortedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/WriteAbortedException"));
			global::java.io.WriteAbortedException._getCause14011 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.io.WriteAbortedException._getMessage14012 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.io.WriteAbortedException._WriteAbortedException14013 = @__env.GetMethodIDNoThrow(global::java.io.WriteAbortedException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
		}
	}
}
