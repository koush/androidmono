namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClassNotFoundException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClassNotFoundException()
		{
			InitJNI();
		}
		protected ClassNotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause20071;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassNotFoundException._getCause20071)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._getCause20071)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException20072;
		public virtual global::java.lang.Throwable getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.ClassNotFoundException._getException20072)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._getException20072)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _ClassNotFoundException20073;
		public ClassNotFoundException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._ClassNotFoundException20073);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassNotFoundException20074;
		public ClassNotFoundException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._ClassNotFoundException20074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ClassNotFoundException20075;
		public ClassNotFoundException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException._ClassNotFoundException20075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ClassNotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ClassNotFoundException"));
			global::java.lang.ClassNotFoundException._getCause20071 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.ClassNotFoundException._getException20072 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "getException", "()Ljava/lang/Throwable;");
			global::java.lang.ClassNotFoundException._ClassNotFoundException20073 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "<init>", "()V");
			global::java.lang.ClassNotFoundException._ClassNotFoundException20074 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.ClassNotFoundException._ClassNotFoundException20075 = @__env.GetMethodIDNoThrow(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
