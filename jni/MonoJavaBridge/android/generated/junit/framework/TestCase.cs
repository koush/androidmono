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
		internal static global::MonoJavaBridge.MethodId _run24770;
		public virtual global::junit.framework.TestResult run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._run24770)) as junit.framework.TestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._run24770)) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _run24771;
		public virtual void run(junit.framework.TestResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._run24771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._run24771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString24772;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._toString24772)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._toString24772)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getName24773;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._getName24773)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._getName24773)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName24774;
		public virtual void setName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._setName24774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._setName24774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUp24775;
		protected virtual void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._setUp24775);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._setUp24775);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown24776;
		protected virtual void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._tearDown24776);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._tearDown24776);
		}
		internal static global::MonoJavaBridge.MethodId _runTest24777;
		protected virtual void runTest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._runTest24777);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._runTest24777);
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases24778;
		public virtual int countTestCases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestCase._countTestCases24778);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._countTestCases24778);
		}
		internal static global::MonoJavaBridge.MethodId _createResult24779;
		protected virtual global::junit.framework.TestResult createResult() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestCase._createResult24779)) as junit.framework.TestResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._createResult24779)) as junit.framework.TestResult;
		}
		internal static global::MonoJavaBridge.MethodId _runBare24780;
		public virtual void runBare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestCase._runBare24780);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestCase.staticClass, global::junit.framework.TestCase._runBare24780);
		}
		internal static global::MonoJavaBridge.MethodId _TestCase24781;
		public TestCase(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._TestCase24781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestCase24782;
		public TestCase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestCase.staticClass, global::junit.framework.TestCase._TestCase24782);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestCase"));
			global::junit.framework.TestCase._run24770 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "run", "()Ljunit/framework/TestResult;");
			global::junit.framework.TestCase._run24771 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::junit.framework.TestCase._toString24772 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "toString", "()Ljava/lang/String;");
			global::junit.framework.TestCase._getName24773 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "getName", "()Ljava/lang/String;");
			global::junit.framework.TestCase._setName24774 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "setName", "(Ljava/lang/String;)V");
			global::junit.framework.TestCase._setUp24775 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "setUp", "()V");
			global::junit.framework.TestCase._tearDown24776 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "tearDown", "()V");
			global::junit.framework.TestCase._runTest24777 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "runTest", "()V");
			global::junit.framework.TestCase._countTestCases24778 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "countTestCases", "()I");
			global::junit.framework.TestCase._createResult24779 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "createResult", "()Ljunit/framework/TestResult;");
			global::junit.framework.TestCase._runBare24780 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "runBare", "()V");
			global::junit.framework.TestCase._TestCase24781 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::junit.framework.TestCase._TestCase24782 = @__env.GetMethodIDNoThrow(global::junit.framework.TestCase.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.TestCase))]
	public sealed partial class TestCase_ : junit.framework.TestCase
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
