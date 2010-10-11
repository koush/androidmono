namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class StackTraceElement : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StackTraceElement()
		{
			InitJNI();
		}
		internal StackTraceElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals13133;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement._equals13133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._equals13133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13134;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._toString13134)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._toString13134)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13135;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StackTraceElement._hashCode13135);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._hashCode13135);
		}
		internal static global::MonoJavaBridge.MethodId _getFileName13136;
		public global::java.lang.String getFileName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getFileName13136)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getFileName13136)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber13137;
		public int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StackTraceElement._getLineNumber13137);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getLineNumber13137);
		}
		internal static global::MonoJavaBridge.MethodId _getClassName13138;
		public global::java.lang.String getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getClassName13138)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getClassName13138)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMethodName13139;
		public global::java.lang.String getMethodName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getMethodName13139)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getMethodName13139)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNativeMethod13140;
		public bool isNativeMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement._isNativeMethod13140);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._isNativeMethod13140);
		}
		internal static global::MonoJavaBridge.MethodId _StackTraceElement13141;
		public StackTraceElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._StackTraceElement13141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackTraceElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackTraceElement"));
			global::java.lang.StackTraceElement._equals13133 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.StackTraceElement._toString13134 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._hashCode13135 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "hashCode", "()I");
			global::java.lang.StackTraceElement._getFileName13136 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getFileName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._getLineNumber13137 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getLineNumber", "()I");
			global::java.lang.StackTraceElement._getClassName13138 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getClassName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._getMethodName13139 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getMethodName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._isNativeMethod13140 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "isNativeMethod", "()Z");
			global::java.lang.StackTraceElement._StackTraceElement13141 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
		}
	}
}
