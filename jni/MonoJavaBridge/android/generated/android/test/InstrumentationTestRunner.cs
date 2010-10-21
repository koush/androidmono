namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InstrumentationTestRunner : android.app.Instrumentation, TestSuiteProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InstrumentationTestRunner()
		{
			InitJNI();
		}
		protected InstrumentationTestRunner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.ClassLoader Loader
		{
			get
			{
				return getLoader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLoader12141;
		public virtual global::java.lang.ClassLoader getLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner._getLoader12141)) as java.lang.ClassLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._getLoader12141)) as java.lang.ClassLoader;
		}
		internal static global::MonoJavaBridge.MethodId _onCreate12142;
		public override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner._onCreate12142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._onCreate12142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onStart12143;
		public override void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner._onStart12143);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._onStart12143);
		}
		protected new global::android.test.AndroidTestRunner AndroidTestRunner
		{
			get
			{
				return getAndroidTestRunner();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAndroidTestRunner12144;
		protected virtual global::android.test.AndroidTestRunner getAndroidTestRunner() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner._getAndroidTestRunner12144)) as android.test.AndroidTestRunner;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._getAndroidTestRunner12144)) as android.test.AndroidTestRunner;
		}
		public new global::junit.framework.TestSuite TestSuite
		{
			get
			{
				return getTestSuite();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTestSuite12145;
		public virtual global::junit.framework.TestSuite getTestSuite() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner._getTestSuite12145)) as junit.framework.TestSuite;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._getTestSuite12145)) as junit.framework.TestSuite;
		}
		public new global::junit.framework.TestSuite AllTests
		{
			get
			{
				return getAllTests();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAllTests12146;
		public virtual global::junit.framework.TestSuite getAllTests() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner._getAllTests12146)) as junit.framework.TestSuite;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._getAllTests12146)) as junit.framework.TestSuite;
		}
		internal static global::MonoJavaBridge.MethodId _InstrumentationTestRunner12147;
		public InstrumentationTestRunner()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.InstrumentationTestRunner.staticClass, global::android.test.InstrumentationTestRunner._InstrumentationTestRunner12147);
			Init(@__env, handle);
		}
		public static global::java.lang.String REPORT_VALUE_ID
		{
			get
			{
				return "InstrumentationTestRunner";
			}
		}
		public static global::java.lang.String REPORT_KEY_NUM_TOTAL
		{
			get
			{
				return "numtests";
			}
		}
		public static global::java.lang.String REPORT_KEY_NUM_CURRENT
		{
			get
			{
				return "current";
			}
		}
		public static global::java.lang.String REPORT_KEY_NAME_CLASS
		{
			get
			{
				return "class";
			}
		}
		public static global::java.lang.String REPORT_KEY_NAME_TEST
		{
			get
			{
				return "test";
			}
		}
		public static int REPORT_VALUE_RESULT_START
		{
			get
			{
				return 1;
			}
		}
		public static int REPORT_VALUE_RESULT_OK
		{
			get
			{
				return 0;
			}
		}
		public static int REPORT_VALUE_RESULT_ERROR
		{
			get
			{
				return -1;
			}
		}
		public static int REPORT_VALUE_RESULT_FAILURE
		{
			get
			{
				return -2;
			}
		}
		public static global::java.lang.String REPORT_KEY_STACK
		{
			get
			{
				return "stack";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.InstrumentationTestRunner.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/InstrumentationTestRunner"));
			global::android.test.InstrumentationTestRunner._getLoader12141 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "getLoader", "()Ljava/lang/ClassLoader;");
			global::android.test.InstrumentationTestRunner._onCreate12142 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.test.InstrumentationTestRunner._onStart12143 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "onStart", "()V");
			global::android.test.InstrumentationTestRunner._getAndroidTestRunner12144 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "getAndroidTestRunner", "()Landroid/test/AndroidTestRunner;");
			global::android.test.InstrumentationTestRunner._getTestSuite12145 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "getTestSuite", "()Ljunit/framework/TestSuite;");
			global::android.test.InstrumentationTestRunner._getAllTests12146 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "getAllTests", "()Ljunit/framework/TestSuite;");
			global::android.test.InstrumentationTestRunner._InstrumentationTestRunner12147 = @__env.GetMethodIDNoThrow(global::android.test.InstrumentationTestRunner.staticClass, "<init>", "()V");
		}
	}
}
