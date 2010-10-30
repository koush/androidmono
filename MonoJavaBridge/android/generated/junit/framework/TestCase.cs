namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass(typeof(global::junit.framework.TestCase_))]
	public abstract partial class TestCase : junit.framework.Assert, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31377;
		public virtual global::junit.framework.TestResult run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._run31377.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._run31377 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "run", "()Ljunit/framework/TestResult;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._run31377) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _run31378;
		public virtual void run(junit.framework.TestResult arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._run31378.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._run31378 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._run31378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31379;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._toString31379.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._toString31379 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._toString31379) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName31380;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._getName31380.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._getName31380 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._getName31380) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName31381;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._setName31381.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._setName31381 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "setName", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._setName31381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUp31382;
		protected virtual void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._setUp31382.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._setUp31382 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "setUp", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._setUp31382);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown31383;
		protected virtual void tearDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._tearDown31383.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._tearDown31383 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "tearDown", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._tearDown31383);
		}
		internal static global::MonoJavaBridge.MethodId _runTest31384;
		protected virtual void runTest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._runTest31384.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._runTest31384 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "runTest", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._runTest31384);
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases31385;
		public virtual int countTestCases()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._countTestCases31385.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._countTestCases31385 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "countTestCases", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._countTestCases31385);
		}
		internal static global::MonoJavaBridge.MethodId _createResult31386;
		protected virtual global::junit.framework.TestResult createResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._createResult31386.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._createResult31386 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "createResult", "()Ljunit/framework/TestResult;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._createResult31386) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _runBare31387;
		public virtual void runBare()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._runBare31387.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._runBare31387 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "runBare", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._runBare31387);
		}
		internal static global::MonoJavaBridge.MethodId _TestCase31388;
		public TestCase(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._TestCase31388.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._TestCase31388 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._TestCase31388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestCase31389;
		public TestCase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestCase._TestCase31389.native == global::System.IntPtr.Zero)
				global::junit.framework.TestCase._TestCase31389 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._TestCase31389);
			Init(@__env, handle);
		}
		static TestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestCase"));
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
