namespace junit.runner
{
	[global::MonoJavaBridge.JavaClass(typeof(global::junit.runner.BaseTestRunner_))]
	public abstract partial class BaseTestRunner : java.lang.Object, junit.framework.TestListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseTestRunner()
		{
			InitJNI();
		}
		protected BaseTestRunner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLoader31316;
		public virtual global::junit.runner.TestSuiteLoader getLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.runner.TestSuiteLoader>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._getLoader31316)) as junit.runner.TestSuiteLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.runner.TestSuiteLoader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getLoader31316)) as junit.runner.TestSuiteLoader;
		}
		internal static global::MonoJavaBridge.MethodId _truncate31317;
		public static global::java.lang.String truncate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._truncate31317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences31318;
		protected static global::java.util.Properties getPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreferences31318)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _addError31319;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._addError31319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addError31319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference31320;
		public static int getPreference(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference31320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference31321;
		public static global::java.lang.String getPreference(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference31321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addFailure31322;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._addFailure31322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addFailure31322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endTest31323;
		public virtual void endTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._endTest31323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._endTest31323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTest31324;
		public virtual void startTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._startTest31324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._startTest31324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadSuiteClass31325;
		protected virtual global::java.lang.Class loadSuiteClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._loadSuiteClass31325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._loadSuiteClass31325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _testStarted31326;
		public abstract void testStarted(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testEnded31327;
		public abstract void testEnded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testFailed31328;
		public abstract void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2);
		internal static global::MonoJavaBridge.MethodId _runFailed31329;
		protected abstract void runFailed(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setPreferences31330;
		protected static void setPreferences(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreferences31330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePreferences31331;
		public static void savePreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._savePreferences31331);
		}
		internal static global::MonoJavaBridge.MethodId _setPreference31332;
		public virtual void setPreference(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._setPreference31332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreference31332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTest31333;
		public virtual global::junit.framework.Test getTest(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._getTest31333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getTest31333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _elapsedTimeAsString31334;
		public virtual global::java.lang.String elapsedTimeAsString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._elapsedTimeAsString31334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._elapsedTimeAsString31334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processArguments31335;
		protected virtual global::java.lang.String processArguments(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._processArguments31335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._processArguments31335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLoading31336;
		public virtual void setLoading(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._setLoading31336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setLoading31336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extractClassName31337;
		public virtual global::java.lang.String extractClassName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._extractClassName31337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._extractClassName31337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearStatus31338;
		protected virtual void clearStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._clearStatus31338);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._clearStatus31338);
		}
		internal static global::MonoJavaBridge.MethodId _useReloadingTestSuiteLoader31339;
		protected virtual bool useReloadingTestSuiteLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31339);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31339);
		}
		internal static global::MonoJavaBridge.MethodId _inVAJava31340;
		public static bool inVAJava() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._inVAJava31340);
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace31341;
		public static global::java.lang.String getFilteredTrace(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace31341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace31342;
		public static global::java.lang.String getFilteredTrace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace31342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _showStackRaw31343;
		protected static bool showStackRaw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._showStackRaw31343);
		}
		internal static global::MonoJavaBridge.MethodId _BaseTestRunner31344;
		public BaseTestRunner()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._BaseTestRunner31344);
			Init(@__env, handle);
		}
		public static global::java.lang.String SUITE_METHODNAME
		{
			get
			{
				return "suite";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.BaseTestRunner.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/BaseTestRunner"));
			global::junit.runner.BaseTestRunner._getLoader31316 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getLoader", "()Ljunit/runner/TestSuiteLoader;");
			global::junit.runner.BaseTestRunner._truncate31317 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "truncate", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._getPreferences31318 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreferences", "()Ljava/util/Properties;");
			global::junit.runner.BaseTestRunner._addError31319 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner._getPreference31320 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;I)I");
			global::junit.runner.BaseTestRunner._getPreference31321 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._addFailure31322 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.runner.BaseTestRunner._endTest31323 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.runner.BaseTestRunner._startTest31324 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.runner.BaseTestRunner._loadSuiteClass31325 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::junit.runner.BaseTestRunner._testStarted31326 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._testEnded31327 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._testFailed31328 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner._runFailed31329 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "runFailed", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._setPreferences31330 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreferences", "(Ljava/util/Properties;)V");
			global::junit.runner.BaseTestRunner._savePreferences31331 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "savePreferences", "()V");
			global::junit.runner.BaseTestRunner._setPreference31332 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreference", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._getTest31333 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getTest", "(Ljava/lang/String;)Ljunit/framework/Test;");
			global::junit.runner.BaseTestRunner._elapsedTimeAsString31334 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "elapsedTimeAsString", "(J)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._processArguments31335 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "processArguments", "([Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._setLoading31336 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setLoading", "(Z)V");
			global::junit.runner.BaseTestRunner._extractClassName31337 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "extractClassName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._clearStatus31338 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "clearStatus", "()V");
			global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31339 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "useReloadingTestSuiteLoader", "()Z");
			global::junit.runner.BaseTestRunner._inVAJava31340 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "inVAJava", "()Z");
			global::junit.runner.BaseTestRunner._getFilteredTrace31341 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._getFilteredTrace31342 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._showStackRaw31343 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "showStackRaw", "()Z");
			global::junit.runner.BaseTestRunner._BaseTestRunner31344 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.runner.BaseTestRunner))]
	public sealed partial class BaseTestRunner_ : junit.runner.BaseTestRunner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseTestRunner_()
		{
			InitJNI();
		}
		internal BaseTestRunner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _testStarted31346;
		public override void testStarted(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testStarted31346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testStarted31346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testEnded31347;
		public override void testEnded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testEnded31347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testEnded31347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testFailed31348;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testFailed31348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testFailed31348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _runFailed31349;
		protected override void runFailed(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._runFailed31349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._runFailed31349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.BaseTestRunner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/BaseTestRunner"));
			global::junit.runner.BaseTestRunner_._testStarted31346 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner_._testEnded31347 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner_._testFailed31348 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner_._runFailed31349 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "runFailed", "(Ljava/lang/String;)V");
		}
	}
}
