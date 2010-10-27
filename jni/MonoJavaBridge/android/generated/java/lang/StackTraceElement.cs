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
		internal static global::MonoJavaBridge.MethodId _equals20532;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement._equals20532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._equals20532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20533;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._toString20533)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._toString20533)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20534;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StackTraceElement._hashCode20534);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._hashCode20534);
		}
		public new global::java.lang.String FileName
		{
			get
			{
				return getFileName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileName20535;
		public global::java.lang.String getFileName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getFileName20535)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getFileName20535)) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber20536;
		public int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.StackTraceElement._getLineNumber20536);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getLineNumber20536);
		}
		public new global::java.lang.String ClassName
		{
			get
			{
				return getClassName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getClassName20537;
		public global::java.lang.String getClassName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getClassName20537)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getClassName20537)) as java.lang.String;
		}
		public new global::java.lang.String MethodName
		{
			get
			{
				return getMethodName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMethodName20538;
		public global::java.lang.String getMethodName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement._getMethodName20538)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._getMethodName20538)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNativeMethod20539;
		public bool isNativeMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement._isNativeMethod20539);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._isNativeMethod20539);
		}
		internal static global::MonoJavaBridge.MethodId _StackTraceElement20540;
		public StackTraceElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement._StackTraceElement20540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.StackTraceElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/StackTraceElement"));
			global::java.lang.StackTraceElement._equals20532 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.StackTraceElement._toString20533 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._hashCode20534 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "hashCode", "()I");
			global::java.lang.StackTraceElement._getFileName20535 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getFileName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._getLineNumber20536 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getLineNumber", "()I");
			global::java.lang.StackTraceElement._getClassName20537 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getClassName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._getMethodName20538 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "getMethodName", "()Ljava/lang/String;");
			global::java.lang.StackTraceElement._isNativeMethod20539 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "isNativeMethod", "()Z");
			global::java.lang.StackTraceElement._StackTraceElement20540 = @__env.GetMethodIDNoThrow(global::java.lang.StackTraceElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
		}
	}
}
