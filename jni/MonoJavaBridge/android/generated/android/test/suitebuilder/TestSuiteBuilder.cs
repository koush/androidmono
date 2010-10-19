namespace android.test.suitebuilder
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestSuiteBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestSuiteBuilder()
		{
			InitJNI();
		}
		protected TestSuiteBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FailedToCreateTests : junit.framework.TestCase
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FailedToCreateTests()
			{
				InitJNI();
			}
			protected FailedToCreateTests(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _testSuiteConstructionFailed8099;
			public virtual void testSuiteConstructionFailed() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._testSuiteConstructionFailed8099);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._testSuiteConstructionFailed8099);
			}
			internal static global::MonoJavaBridge.MethodId _FailedToCreateTests8100;
			public FailedToCreateTests(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._FailedToCreateTests8100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/TestSuiteBuilder$FailedToCreateTests"));
				global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._testSuiteConstructionFailed8099 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, "testSuiteConstructionFailed", "()V");
				global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests._FailedToCreateTests8100 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.FailedToCreateTests.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _build8101;
		public virtual global::junit.framework.TestSuite build() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._build8101)) as junit.framework.TestSuite;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._build8101)) as junit.framework.TestSuite;
		}
		internal static global::MonoJavaBridge.MethodId _includePackages8102;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder includePackages(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._includePackages8102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._includePackages8102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _excludePackages8103;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder excludePackages(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._excludePackages8103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._excludePackages8103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRequirements8104;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder addRequirements(com.android.@internal.util.Predicate[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._addRequirements8104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._addRequirements8104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _addRequirements8105;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder addRequirements(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._addRequirements8105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._addRequirements8105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _includeAllPackagesUnderHere8106;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder includeAllPackagesUnderHere() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._includeAllPackagesUnderHere8106)) as android.test.suitebuilder.TestSuiteBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._includeAllPackagesUnderHere8106)) as android.test.suitebuilder.TestSuiteBuilder;
		}
		internal static global::MonoJavaBridge.MethodId _named8107;
		public virtual global::android.test.suitebuilder.TestSuiteBuilder named(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._named8107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._named8107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.test.suitebuilder.TestSuiteBuilder;
		}
		protected new global::java.lang.String SuiteName
		{
			get
			{
				return getSuiteName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSuiteName8108;
		protected virtual global::java.lang.String getSuiteName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder._getSuiteName8108)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._getSuiteName8108)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TestSuiteBuilder8109;
		public TestSuiteBuilder(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder8109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TestSuiteBuilder8110;
		public TestSuiteBuilder(java.lang.String arg0, java.lang.ClassLoader arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.suitebuilder.TestSuiteBuilder.staticClass, global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder8110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.TestSuiteBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/TestSuiteBuilder"));
			global::android.test.suitebuilder.TestSuiteBuilder._build8101 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "build", "()Ljunit/framework/TestSuite;");
			global::android.test.suitebuilder.TestSuiteBuilder._includePackages8102 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "includePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;");
			global::android.test.suitebuilder.TestSuiteBuilder._excludePackages8103 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "excludePackages", "([Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;");
			global::android.test.suitebuilder.TestSuiteBuilder._addRequirements8104 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "addRequirements", "([Lcom/android/@internal/util/Predicate;)Landroid/test/suitebuilder/TestSuiteBuilder;");
			global::android.test.suitebuilder.TestSuiteBuilder._addRequirements8105 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "addRequirements", "(Ljava/util/List;)Landroid/test/suitebuilder/TestSuiteBuilder;");
			global::android.test.suitebuilder.TestSuiteBuilder._includeAllPackagesUnderHere8106 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "includeAllPackagesUnderHere", "()Landroid/test/suitebuilder/TestSuiteBuilder;");
			global::android.test.suitebuilder.TestSuiteBuilder._named8107 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "named", "(Ljava/lang/String;)Landroid/test/suitebuilder/TestSuiteBuilder;");
			global::android.test.suitebuilder.TestSuiteBuilder._getSuiteName8108 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "getSuiteName", "()Ljava/lang/String;");
			global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder8109 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::android.test.suitebuilder.TestSuiteBuilder._TestSuiteBuilder8110 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.TestSuiteBuilder.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;)V");
		}
	}
}
