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
		internal static global::MonoJavaBridge.MethodId _run24811;
		public virtual void run(junit.framework.TestResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._run24811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._run24811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString24812;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._toString24812)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._toString24812)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getName24813;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._getName24813)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._getName24813)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName24814;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._setName24814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._setName24814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runTest24815;
		public virtual void runTest(junit.framework.Test arg0, junit.framework.TestResult arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._runTest24815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._runTest24815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases24816;
		public virtual int countTestCases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestSuite._countTestCases24816);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._countTestCases24816);
		}
		internal static global::MonoJavaBridge.MethodId _addTest24817;
		public virtual void addTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._addTest24817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._addTest24817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addTestSuite24818;
		public virtual void addTestSuite(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestSuite._addTestSuite24818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._addTestSuite24818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTest24819;
		public static global::junit.framework.Test createTest(java.lang.Class arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._createTest24819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _getTestConstructor24820;
		public static global::java.lang.reflect.Constructor getTestConstructor(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._getTestConstructor24820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.reflect.Constructor;
		}
		internal static global::MonoJavaBridge.MethodId _testAt24821;
		public virtual global::junit.framework.Test testAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._testAt24821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._testAt24821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _testCount24822;
		public virtual int testCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestSuite._testCount24822);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._testCount24822);
		}
		internal static global::MonoJavaBridge.MethodId _tests24823;
		public virtual global::java.util.Enumeration tests() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestSuite._tests24823)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._tests24823)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite24824;
		public TestSuite(java.lang.Class arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite24824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite24825;
		public TestSuite(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite24825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite24826;
		public TestSuite(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite24826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuite24827;
		public TestSuite()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestSuite.staticClass, global::junit.framework.TestSuite._TestSuite24827);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestSuite.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestSuite"));
			global::junit.framework.TestSuite._run24811 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::junit.framework.TestSuite._toString24812 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "toString", "()Ljava/lang/String;");
			global::junit.framework.TestSuite._getName24813 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getName", "()Ljava/lang/String;");
			global::junit.framework.TestSuite._setName24814 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "setName", "(Ljava/lang/String;)V");
			global::junit.framework.TestSuite._runTest24815 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "runTest", "(Ljunit/framework/Test;Ljunit/framework/TestResult;)V");
			global::junit.framework.TestSuite._countTestCases24816 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "countTestCases", "()I");
			global::junit.framework.TestSuite._addTest24817 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "addTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestSuite._addTestSuite24818 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "addTestSuite", "(Ljava/lang/Class;)V");
			global::junit.framework.TestSuite._createTest24819 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "createTest", "(Ljava/lang/Class;Ljava/lang/String;)Ljunit/framework/Test;");
			global::junit.framework.TestSuite._getTestConstructor24820 = @__env.GetStaticMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "getTestConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;");
			global::junit.framework.TestSuite._testAt24821 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "testAt", "(I)Ljunit/framework/Test;");
			global::junit.framework.TestSuite._testCount24822 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "testCount", "()I");
			global::junit.framework.TestSuite._tests24823 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "tests", "()Ljava/util/Enumeration;");
			global::junit.framework.TestSuite._TestSuite24824 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
			global::junit.framework.TestSuite._TestSuite24825 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::junit.framework.TestSuite._TestSuite24826 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::junit.framework.TestSuite._TestSuite24827 = @__env.GetMethodIDNoThrow(global::junit.framework.TestSuite.staticClass, "<init>", "()V");
		}
	}
}
