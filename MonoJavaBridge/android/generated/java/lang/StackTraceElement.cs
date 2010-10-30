namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StackTraceElement : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal StackTraceElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.StackTraceElement.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.StackTraceElement._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StackTraceElement.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.StackTraceElement._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StackTraceElement.staticClass, "hashCode", "()I", ref global::java.lang.StackTraceElement._m2);
		}
		public new global::java.lang.String FileName
		{
			get
			{
				return getFileName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getFileName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StackTraceElement.staticClass, "getFileName", "()Ljava/lang/String;", ref global::java.lang.StackTraceElement._m3) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.StackTraceElement.staticClass, "getLineNumber", "()I", ref global::java.lang.StackTraceElement._m4);
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.String getClassName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StackTraceElement.staticClass, "getClassName", "()Ljava/lang/String;", ref global::java.lang.StackTraceElement._m5) as java.lang.String;
		}
		public new global::java.lang.String MethodName
		{
			get
			{
				return getMethodName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getMethodName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.StackTraceElement.staticClass, "getMethodName", "()Ljava/lang/String;", ref global::java.lang.StackTraceElement._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool isNativeMethod()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.StackTraceElement.staticClass, "isNativeMethod", "()Z", ref global::java.lang.StackTraceElement._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public StackTraceElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.StackTraceElement._m8.native == global::System.IntPtr.Zero)
				global::java.lang.StackTraceElement._m8 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static StackTraceElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackTraceElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackTraceElement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
