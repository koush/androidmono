namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass(typeof(global::junit.framework.TestCase_))]
	public abstract partial class TestCase : junit.framework.Assert, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::junit.framework.TestResult run()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestCase.staticClass, "run", "()Ljunit/framework/TestResult;", ref global::junit.framework.TestCase._m0) as junit.framework.TestResult;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void run(junit.framework.TestResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, "run", "(Ljunit/framework/TestResult;)V", ref global::junit.framework.TestCase._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestCase.staticClass, "toString", "()Ljava/lang/String;", ref global::junit.framework.TestCase._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestCase.staticClass, "getName", "()Ljava/lang/String;", ref global::junit.framework.TestCase._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, "setName", "(Ljava/lang/String;)V", ref global::junit.framework.TestCase._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, "setUp", "()V", ref global::junit.framework.TestCase._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void tearDown()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, "tearDown", "()V", ref global::junit.framework.TestCase._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void runTest()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, "runTest", "()V", ref global::junit.framework.TestCase._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int countTestCases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestCase.staticClass, "countTestCases", "()I", ref global::junit.framework.TestCase._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::junit.framework.TestResult createResult()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestCase.staticClass, "createResult", "()Ljunit/framework/TestResult;", ref global::junit.framework.TestCase._m9) as junit.framework.TestResult;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void runBare()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, "runBare", "()V", ref global::junit.framework.TestCase._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public TestCase(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._m11.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._m11 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public TestCase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._m12.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._m12 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._m12);
			Init(@__env, handle);
		}
		static TestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestCase"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.TestCase))]
	internal sealed partial class TestCase_ : junit.framework.TestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static TestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestCase"));
		}
	}
}
