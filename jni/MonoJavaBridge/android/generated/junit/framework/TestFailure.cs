namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestFailure : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestFailure()
		{
			InitJNI();
		}
		protected TestFailure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString31389;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestFailure._toString31389)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._toString31389)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _trace31390;
		public virtual global::java.lang.String trace()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestFailure._trace31390)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._trace31390)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _failedTest31391;
		public virtual global::junit.framework.Test failedTest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestFailure._failedTest31391)) as junit.framework.Test;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._failedTest31391)) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _thrownException31392;
		public virtual global::java.lang.Throwable thrownException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestFailure._thrownException31392)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._thrownException31392)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _exceptionMessage31393;
		public virtual global::java.lang.String exceptionMessage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestFailure._exceptionMessage31393)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._exceptionMessage31393)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFailure31394;
		public virtual bool isFailure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestFailure._isFailure31394);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._isFailure31394);
		}
		internal static global::MonoJavaBridge.MethodId _TestFailure31395;
		public TestFailure(junit.framework.Test arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._TestFailure31395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestFailure.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestFailure"));
			global::junit.framework.TestFailure._toString31389 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "toString", "()Ljava/lang/String;");
			global::junit.framework.TestFailure._trace31390 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "trace", "()Ljava/lang/String;");
			global::junit.framework.TestFailure._failedTest31391 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "failedTest", "()Ljunit/framework/Test;");
			global::junit.framework.TestFailure._thrownException31392 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "thrownException", "()Ljava/lang/Throwable;");
			global::junit.framework.TestFailure._exceptionMessage31393 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "exceptionMessage", "()Ljava/lang/String;");
			global::junit.framework.TestFailure._isFailure31394 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "isFailure", "()Z");
			global::junit.framework.TestFailure._TestFailure31395 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "<init>", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
		}
	}
}
