namespace junit.runner
{
	[global::MonoJavaBridge.JavaClass(typeof(global::junit.runner.BaseTestRunner_))]
	public abstract partial class BaseTestRunner : java.lang.Object, junit.framework.TestListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseTestRunner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLoader31435;
		public virtual global::junit.runner.TestSuiteLoader getLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getLoader31435.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getLoader31435 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getLoader", "()Ljunit/runner/TestSuiteLoader;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.runner.TestSuiteLoader>(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getLoader31435) as junit.runner.TestSuiteLoader;
		}
		internal static global::MonoJavaBridge.MethodId _truncate31436;
		public static global::java.lang.String truncate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._truncate31436.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._truncate31436 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "truncate", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._truncate31436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences31437;
		protected static global::java.util.Properties getPreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getPreferences31437.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getPreferences31437 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreferences", "()Ljava/util/Properties;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreferences31437)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _addError31438;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._addError31438.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._addError31438 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addError31438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference31439;
		public static int getPreference(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getPreference31439.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getPreference31439 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;I)I");
			return @__env.CallStaticIntMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference31439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference31440;
		public static global::java.lang.String getPreference(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getPreference31440.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getPreference31440 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference31440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addFailure31441;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._addFailure31441.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._addFailure31441 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addFailure31441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endTest31442;
		public virtual void endTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._endTest31442.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._endTest31442 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._endTest31442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTest31443;
		public virtual void startTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._startTest31443.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._startTest31443 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._startTest31443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadSuiteClass31444;
		protected virtual global::java.lang.Class loadSuiteClass(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._loadSuiteClass31444.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._loadSuiteClass31444 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._loadSuiteClass31444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _testStarted31445;
		public abstract void testStarted(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testEnded31446;
		public abstract void testEnded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testFailed31447;
		public abstract void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2);
		internal static global::MonoJavaBridge.MethodId _runFailed31448;
		protected abstract void runFailed(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setPreferences31449;
		protected static void setPreferences(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._setPreferences31449.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._setPreferences31449 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreferences", "(Ljava/util/Properties;)V");
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreferences31449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePreferences31450;
		public static void savePreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._savePreferences31450.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._savePreferences31450 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "savePreferences", "()V");
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._savePreferences31450);
		}
		internal static global::MonoJavaBridge.MethodId _setPreference31451;
		public virtual void setPreference(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._setPreference31451.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._setPreference31451 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreference", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreference31451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTest31452;
		public virtual global::junit.framework.Test getTest(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getTest31452.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getTest31452 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getTest", "(Ljava/lang/String;)Ljunit/framework/Test;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.framework.Test>(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getTest31452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _elapsedTimeAsString31453;
		public virtual global::java.lang.String elapsedTimeAsString(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._elapsedTimeAsString31453.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._elapsedTimeAsString31453 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "elapsedTimeAsString", "(J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._elapsedTimeAsString31453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processArguments31454;
		protected virtual global::java.lang.String processArguments(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._processArguments31454.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._processArguments31454 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "processArguments", "([Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._processArguments31454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLoading31455;
		public virtual void setLoading(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._setLoading31455.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._setLoading31455 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setLoading", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setLoading31455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extractClassName31456;
		public virtual global::java.lang.String extractClassName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._extractClassName31456.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._extractClassName31456 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "extractClassName", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._extractClassName31456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearStatus31457;
		protected virtual void clearStatus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._clearStatus31457.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._clearStatus31457 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "clearStatus", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._clearStatus31457);
		}
		internal static global::MonoJavaBridge.MethodId _useReloadingTestSuiteLoader31458;
		protected virtual bool useReloadingTestSuiteLoader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31458.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31458 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "useReloadingTestSuiteLoader", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31458);
		}
		internal static global::MonoJavaBridge.MethodId _inVAJava31459;
		public static bool inVAJava()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._inVAJava31459.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._inVAJava31459 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "inVAJava", "()Z");
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._inVAJava31459);
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace31460;
		public static global::java.lang.String getFilteredTrace(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getFilteredTrace31460.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getFilteredTrace31460 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace31460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace31461;
		public static global::java.lang.String getFilteredTrace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._getFilteredTrace31461.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._getFilteredTrace31461 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace31461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _showStackRaw31462;
		protected static bool showStackRaw()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._showStackRaw31462.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._showStackRaw31462 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "showStackRaw", "()Z");
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._showStackRaw31462);
		}
		internal static global::MonoJavaBridge.MethodId _BaseTestRunner31463;
		public BaseTestRunner() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._BaseTestRunner31463.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._BaseTestRunner31463 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._BaseTestRunner31463);
			Init(@__env, handle);
		}
		public static global::java.lang.String SUITE_METHODNAME
		{
			get
			{
				return "suite";
			}
		}
		static BaseTestRunner()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.BaseTestRunner.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/BaseTestRunner"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.runner.BaseTestRunner))]
	internal sealed partial class BaseTestRunner_ : junit.runner.BaseTestRunner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BaseTestRunner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _testStarted31465;
		public override void testStarted(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner_._testStarted31465.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner_._testStarted31465 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testStarted", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testStarted31465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testEnded31466;
		public override void testEnded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner_._testEnded31466.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner_._testEnded31466 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testEnded", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testEnded31466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testFailed31467;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner_._testFailed31467.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner_._testFailed31467 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testFailed31467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _runFailed31468;
		protected override void runFailed(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner_._runFailed31468.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner_._runFailed31468 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "runFailed", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._runFailed31468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static BaseTestRunner_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.BaseTestRunner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/BaseTestRunner"));
		}
		internal static void InitJNI()
		{
		}
	}
}
