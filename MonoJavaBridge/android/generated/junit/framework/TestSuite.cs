namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestSuite : java.lang.Object, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestSuite(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void run(junit.framework.TestResult arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, "run", "(Ljunit/framework/TestResult;)V", ref global::junit.framework.TestSuite._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestSuite.staticClass, "toString", "()Ljava/lang/String;", ref global::junit.framework.TestSuite._m1) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.framework.TestSuite.staticClass, "getName", "()Ljava/lang/String;", ref global::junit.framework.TestSuite._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, "setName", "(Ljava/lang/String;)V", ref global::junit.framework.TestSuite._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V", ref global::junit.framework.TestSuite._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int countTestCases()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestSuite.staticClass, "countTestCases", "()I", ref global::junit.framework.TestSuite._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void addTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, "addTest", "(Ljunit/framework/Test;)V", ref global::junit.framework.TestSuite._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void addTestSuite(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.framework.TestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V", ref global::junit.framework.TestSuite._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::junit.framework.Test createTest(java.lang.Class arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._m8.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._m8 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "createTest", "(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as junit.framework.Test;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.reflect.Constructor getTestConstructor(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._m9.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._m9 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getTestConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::junit.framework.Test testAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.framework.Test>(this, global::junit.framework.TestSuite.staticClass, "testAt", "(I)Ljunit/framework/Test;", ref global::junit.framework.TestSuite._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as junit.framework.Test;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int testCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::junit.framework.TestSuite.staticClass, "testCount", "()I", ref global::junit.framework.TestSuite._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.util.Enumeration tests()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::junit.framework.TestSuite.staticClass, "tests", "()Ljava/util/Enumeration;", ref global::junit.framework.TestSuite._m12) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public TestSuite(java.lang.Class arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._m13.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._m13 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public TestSuite(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._m14.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._m14 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public TestSuite(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._m15.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._m15 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public TestSuite() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.framework.TestSuite._m16.native == global::System.IntPtr.Zero)
				global::junit.framework.TestSuite._m16 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._m16);
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
