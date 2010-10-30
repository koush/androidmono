namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestSuite : java.lang.Object, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestSuite(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31418;
		public virtual void run(junit.framework.TestResult arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._run31418.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._run31418 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._run31418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31419;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._toString31419.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._toString31419 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._toString31419) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
			set
			{
				setName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName31420;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._getName31420.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._getName31420 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._getName31420) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName31421;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._setName31421.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._setName31421 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "setName", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._setName31421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runTest31422;
		public virtual void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._runTest31422.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._runTest31422 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._runTest31422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases31423;
		public virtual int countTestCases()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._countTestCases31423.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._countTestCases31423 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "countTestCases", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._countTestCases31423);
		}
		internal static global::MonoJavaBridge.MethodId _addTest31424;
		public virtual void addTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._addTest31424.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._addTest31424 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "addTest", "(Ljunit/framework/Test;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._addTest31424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTestSuite31425;
		public virtual void addTestSuite(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._addTestSuite31425.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._addTestSuite31425 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._addTestSuite31425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTest31426;
		public static global::junit.framework.Test createTest(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._createTest31426.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._createTest31426 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "createTest", "(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._createTest31426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _getTestConstructor31427;
		public static global::java.lang.reflect.Constructor getTestConstructor(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._getTestConstructor31427.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._getTestConstructor31427 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getTestConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._getTestConstructor31427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _testAt31428;
		public virtual global::junit.framework.Test testAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._testAt31428.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._testAt31428 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "testAt", "(I)Ljunit/framework/Test;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.framework.Test>(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._testAt31428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _testCount31429;
		public virtual int testCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._testCount31429.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._testCount31429 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "testCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._testCount31429);
		}
		internal static global::MonoJavaBridge.MethodId _tests31430;
		public virtual global::java.util.Enumeration tests()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._tests31430.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._tests31430 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "tests", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._tests31430) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31431;
		public TestSuite(java.lang.Class arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._TestSuite31431.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._TestSuite31431 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31432;
		public TestSuite(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._TestSuite31432.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._TestSuite31432 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31433;
		public TestSuite(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._TestSuite31433.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._TestSuite31433 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31434;
		public TestSuite() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._TestSuite31434.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._TestSuite31434 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31434);
			Init(@__env, handle);
		}
		static TestSuite()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestSuite.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestSuite"));
		}
		internal static void InitJNI()
		{
		}
	}
}
