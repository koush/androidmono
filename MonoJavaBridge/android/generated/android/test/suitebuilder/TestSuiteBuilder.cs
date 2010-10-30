namespace android.test.suitebuilder
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestSuiteBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TestSuiteBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FailedToCreateTests : junit.framework.TestCase
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FailedToCreateTests(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _testSuiteConstructionFailed12635;
			public virtual void testSuiteConstructionFailed()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, "testSuiteConstructionFailed", "()V", ref global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._testSuiteConstructionFailed12635);
			}
			internal static global::MonoJavaBridge.MethodId _FailedToCreateTests12636;
			public FailedToCreateTests(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._FailedToCreateTests12636.native == global::System.IntPtr.Zero)
					global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._FailedToCreateTests12636 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, "<init>", "(Ljava/lang/Exception;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._FailedToCreateTests12636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static FailedToCreateTests()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/TestSuiteBuilder$FailedToCreateTests"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _build12637;
		public virtual global::junit.framework.TestSuite build()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "build", "()Ljunit/framework/TestSuite;", ref global::android.test.suitebuilder.TestSuiteBuilder._build12637) as junit.framework.TestSuite;
		}
		internal static global::MonoJavaBridge.MethodId _includePackages12638;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder includePackages(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "includePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", ref global::android.test.suitebuilder.TestSuiteBuilder._includePackages12638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _excludePackages12639;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder excludePackages(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "excludePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", ref global::android.test.suitebuilder.TestSuiteBuilder._excludePackages12639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRequirements12640;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder addRequirements(com.android.@internal.util.Predicate[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "addRequirements", "([Lcom/android/@internal/util/Predicate;)Landroid/test/suitebuilder/TestSuiteBuilder;", ref global::android.test.suitebuilder.TestSuiteBuilder._addRequirements12640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRequirements12641;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder addRequirements(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "addRequirements", "(Ljava/util/List;)Landroid/test/suitebuilder/TestSuiteBuilder;", ref global::android.test.suitebuilder.TestSuiteBuilder._addRequirements12641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _includeAllPackagesUnderHere12642;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder includeAllPackagesUnderHere()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "includeAllPackagesUnderHere", "()Landroid/test/suitebuilder/TestSuiteBuilder;", ref global::android.test.suitebuilder.TestSuiteBuilder._includeAllPackagesUnderHere12642) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _named12643;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder named(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "named", "(Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;", ref global::android.test.suitebuilder.TestSuiteBuilder._named12643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.test.suitebuilder.TestSuiteBuilder;
		}
		protected new global::java.lang.String SuiteName
		{
			get
			{
				return getSuiteName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuiteName12644;
		protected virtual global::java.lang.String getSuiteName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "getSuiteName", "()Ljava/lang/String;", ref global::android.test.suitebuilder.TestSuiteBuilder._getSuiteName12644) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TestSuiteBuilder12645;
		public TestSuiteBuilder(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder12645.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder12645 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder12645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuiteBuilder12646;
		public TestSuiteBuilder(java.lang.String arg0, java.lang.ClassLoader arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder12646.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder12646 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder12646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TestSuiteBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.TestSuiteBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/TestSuiteBuilder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
