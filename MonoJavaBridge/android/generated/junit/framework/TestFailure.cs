namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestFailure : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestFailure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestFailure.staticClass, "toString", "()Ljava/lang/String;", ref global::junit.framework.TestFailure._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String trace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestFailure.staticClass, "trace", "()Ljava/lang/String;", ref global::junit.framework.TestFailure._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::junit.framework.Test failedTest()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.framework.Test>(this, global::junit.framework.TestFailure.staticClass, "failedTest", "()Ljunit/framework/Test;", ref global::junit.framework.TestFailure._m2) as junit.framework.Test;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Throwable thrownException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestFailure.staticClass, "thrownException", "()Ljava/lang/Throwable;", ref global::junit.framework.TestFailure._m3) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String exceptionMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestFailure.staticClass, "exceptionMessage", "()Ljava/lang/String;", ref global::junit.framework.TestFailure._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isFailure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.framework.TestFailure.staticClass, "isFailure", "()Z", ref global::junit.framework.TestFailure._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public TestFailure(junit.framework.Test arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestFailure._m6.native == global::System.IntPtr.Zero)
				global::junit.framework.TestFailure._m6 = @__env.GetMethodIDNoThrow(global::junit.framework.TestFailure.staticClass, "<init>", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestFailure.staticClass, global::junit.framework.TestFailure._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
