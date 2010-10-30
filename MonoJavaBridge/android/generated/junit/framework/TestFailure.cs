namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestFailure : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestFailure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString31390;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestFailure.staticClass, "toString", "()Ljava/lang/String;", ref global::junit.framework.TestFailure._toString31390) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _trace31391;
		public virtual global::java.lang.String trace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestFailure.staticClass, "trace", "()Ljava/lang/String;", ref global::junit.framework.TestFailure._trace31391) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _failedTest31392;
		public virtual global::junit.framework.Test failedTest()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.framework.Test>(this, global::junit.framework.TestFailure.staticClass, "failedTest", "()Ljunit/framework/Test;", ref global::junit.framework.TestFailure._failedTest31392) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _thrownException31393;
		public virtual global::java.lang.Throwable thrownException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestFailure.staticClass, "thrownException", "()Ljava/lang/Throwable;", ref global::junit.framework.TestFailure._thrownException31393) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _exceptionMessage31394;
		public virtual global::java.lang.String exceptionMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestFailure.staticClass, "exceptionMessage", "()Ljava/lang/String;", ref global::junit.framework.TestFailure._exceptionMessage31394) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFailure31395;
		public virtual bool isFailure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.framework.TestFailure.staticClass, "isFailure", "()Z", ref global::junit.framework.TestFailure._isFailure31395);
		}
		internal static global::MonoJavaBridge.MethodId _TestFailure31396;
		public TestFailure(junit.framework.Test arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestFailure._TestFailure31396.native == global::System.IntPtr.Zero)
				global::junit.framework.TestFailure._TestFailure31396 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "<init>", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._TestFailure31396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TestFailure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestFailure.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestFailure"));
		}
		internal static void InitJNI()
		{
		}
	}
}
