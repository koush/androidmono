namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestSuite : java.lang.Object, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestSuite()
		{
			InitJNI();
		}
		protected TestSuite(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31417;
		public virtual void run(junit.framework.TestResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._run31417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._run31417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31418;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._toString31418)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._toString31418)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getName31419;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._getName31419)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._getName31419)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName31420;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._setName31420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._setName31420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runTest31421;
		public virtual void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._runTest31421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._runTest31421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases31422;
		public virtual int countTestCases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestSuite._countTestCases31422);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._countTestCases31422);
		}
		internal static global::MonoJavaBridge.MethodId _addTest31423;
		public virtual void addTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._addTest31423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._addTest31423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTestSuite31424;
		public virtual void addTestSuite(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._addTestSuite31424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._addTestSuite31424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTest31425;
		public static global::junit.framework.Test createTest(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._createTest31425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _getTestConstructor31426;
		public static global::java.lang.reflect.Constructor getTestConstructor(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.reflect.Constructor>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._getTestConstructor31426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _testAt31427;
		public virtual global::junit.framework.Test testAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._testAt31427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._testAt31427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _testCount31428;
		public virtual int testCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestSuite._testCount31428);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._testCount31428);
		}
		internal static global::MonoJavaBridge.MethodId _tests31429;
		public virtual global::java.util.Enumeration tests() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._tests31429)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._tests31429)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31430;
		public TestSuite(java.lang.Class arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31431;
		public TestSuite(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31432;
		public TestSuite(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite31433;
		public TestSuite()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite31433);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestSuite.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestSuite"));
			global::junit.framework.TestSuite._run31417 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::junit.framework.TestSuite._toString31418 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "toString", "()Ljava/lang/String;");
			global::junit.framework.TestSuite._getName31419 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getName", "()Ljava/lang/String;");
			global::junit.framework.TestSuite._setName31420 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "setName", "(Ljava/lang/String;)V");
			global::junit.framework.TestSuite._runTest31421 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V");
			global::junit.framework.TestSuite._countTestCases31422 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "countTestCases", "()I");
			global::junit.framework.TestSuite._addTest31423 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "addTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestSuite._addTestSuite31424 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V");
			global::junit.framework.TestSuite._createTest31425 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "createTest", "(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;");
			global::junit.framework.TestSuite._getTestConstructor31426 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getTestConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::junit.framework.TestSuite._testAt31427 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "testAt", "(I)Ljunit/framework/Test;");
			global::junit.framework.TestSuite._testCount31428 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "testCount", "()I");
			global::junit.framework.TestSuite._tests31429 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "tests", "()Ljava/util/Enumeration;");
			global::junit.framework.TestSuite._TestSuite31430 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::junit.framework.TestSuite._TestSuite31431 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::junit.framework.TestSuite._TestSuite31432 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::junit.framework.TestSuite._TestSuite31433 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "()V");
		}
	}
}
