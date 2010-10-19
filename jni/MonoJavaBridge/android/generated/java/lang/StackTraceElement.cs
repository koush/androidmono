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
		internal static global::MonoJavaBridge.MethodId _equals14897;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement._equals14897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._equals14897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14898;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._toString14898)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._toString14898)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14899;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StackTraceElement._hashCode14899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._hashCode14899);
		}
		public new global::java.lang.String FileName
		{
			get
			{
				return getFileName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileName14900;
		public global::java.lang.String getFileName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getFileName14900)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getFileName14900)) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber14901;
		public int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StackTraceElement._getLineNumber14901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getLineNumber14901);
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName14902;
		public global::java.lang.String getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getClassName14902)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getClassName14902)) as java.lang.String;
		}
		public new global::java.lang.String MethodName
		{
			get
			{
				return getMethodName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethodName14903;
		public global::java.lang.String getMethodName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getMethodName14903)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getMethodName14903)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNativeMethod14904;
		public bool isNativeMethod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement._isNativeMethod14904);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._isNativeMethod14904);
		}
		internal static global::MonoJavaBridge.MethodId _StackTraceElement14905;
		public StackTraceElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._StackTraceElement14905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackTraceElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackTraceElement"));
			global::java.lang.StackTraceElement._equals14897 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.StackTraceElement._toString14898 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._hashCode14899 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "hashCode", "()I");
			global::java.lang.StackTraceElement._getFileName14900 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getFileName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._getLineNumber14901 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getLineNumber", "()I");
			global::java.lang.StackTraceElement._getClassName14902 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getClassName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._getMethodName14903 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getMethodName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._isNativeMethod14904 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "isNativeMethod", "()Z");
			global::java.lang.StackTraceElement._StackTraceElement14905 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
		}
	}
}
