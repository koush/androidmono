namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass(typeof(global::junit.framework.TestCase_))]
	public abstract partial class TestCase : junit.framework.Assert, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestCase()
		{
			InitJNI();
		}
		protected TestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31376;
		public virtual global::junit.framework.TestResult run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._run31376)) as junit.framework.TestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._run31376)) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _run31377;
		public virtual void run(junit.framework.TestResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._run31377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._run31377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31378;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._toString31378)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._toString31378)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName31379;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._getName31379)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._getName31379)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName31380;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._setName31380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._setName31380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUp31381;
		protected virtual void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._setUp31381);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._setUp31381);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown31382;
		protected virtual void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._tearDown31382);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._tearDown31382);
		}
		internal static global::MonoJavaBridge.MethodId _runTest31383;
		protected virtual void runTest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._runTest31383);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._runTest31383);
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases31384;
		public virtual int countTestCases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestCase._countTestCases31384);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._countTestCases31384);
		}
		internal static global::MonoJavaBridge.MethodId _createResult31385;
		protected virtual global::junit.framework.TestResult createResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._createResult31385)) as junit.framework.TestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._createResult31385)) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _runBare31386;
		public virtual void runBare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._runBare31386);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._runBare31386);
		}
		internal static global::MonoJavaBridge.MethodId _TestCase31387;
		public TestCase(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._TestCase31387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestCase31388;
		public TestCase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._TestCase31388);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestCase"));
			global::junit.framework.TestCase._run31376 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "run", "()Ljunit/framework/TestResult;");
			global::junit.framework.TestCase._run31377 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::junit.framework.TestCase._toString31378 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "toString", "()Ljava/lang/String;");
			global::junit.framework.TestCase._getName31379 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "getName", "()Ljava/lang/String;");
			global::junit.framework.TestCase._setName31380 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "setName", "(Ljava/lang/String;)V");
			global::junit.framework.TestCase._setUp31381 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "setUp", "()V");
			global::junit.framework.TestCase._tearDown31382 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "tearDown", "()V");
			global::junit.framework.TestCase._runTest31383 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "runTest", "()V");
			global::junit.framework.TestCase._countTestCases31384 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "countTestCases", "()I");
			global::junit.framework.TestCase._createResult31385 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "createResult", "()Ljunit/framework/TestResult;");
			global::junit.framework.TestCase._runBare31386 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "runBare", "()V");
			global::junit.framework.TestCase._TestCase31387 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::junit.framework.TestCase._TestCase31388 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.TestCase))]
	internal sealed partial class TestCase_ : junit.framework.TestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestCase_()
		{
			InitJNI();
		}
		internal TestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestCase"));
		}
	}
}
