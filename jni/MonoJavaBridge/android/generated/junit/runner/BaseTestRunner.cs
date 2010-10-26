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
		internal static global::MonoJavaBridge.MethodId _getLoader31434;
		public virtual global::junit.runner.TestSuiteLoader getLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.runner.TestSuiteLoader>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._getLoader31434)) as junit.runner.TestSuiteLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.runner.TestSuiteLoader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getLoader31434)) as junit.runner.TestSuiteLoader;
		}
		internal static global::MonoJavaBridge.MethodId _truncate31435;
		public static global::java.lang.String truncate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._truncate31435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences31436;
		protected static global::java.util.Properties getPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreferences31436)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _addError31437;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._addError31437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addError31437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference31438;
		public static int getPreference(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference31438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference31439;
		public static global::java.lang.String getPreference(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference31439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addFailure31440;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._addFailure31440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addFailure31440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endTest31441;
		public virtual void endTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._endTest31441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._endTest31441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTest31442;
		public virtual void startTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._startTest31442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._startTest31442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadSuiteClass31443;
		protected virtual global::java.lang.Class loadSuiteClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._loadSuiteClass31443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._loadSuiteClass31443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _testStarted31444;
		public abstract void testStarted(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testEnded31445;
		public abstract void testEnded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testFailed31446;
		public abstract void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2);
		internal static global::MonoJavaBridge.MethodId _runFailed31447;
		protected abstract void runFailed(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setPreferences31448;
		protected static void setPreferences(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreferences31448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePreferences31449;
		public static void savePreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._savePreferences31449);
		}
		internal static global::MonoJavaBridge.MethodId _setPreference31450;
		public virtual void setPreference(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._setPreference31450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreference31450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTest31451;
		public virtual global::junit.framework.Test getTest(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._getTest31451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getTest31451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _elapsedTimeAsString31452;
		public virtual global::java.lang.String elapsedTimeAsString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._elapsedTimeAsString31452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._elapsedTimeAsString31452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processArguments31453;
		protected virtual global::java.lang.String processArguments(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._processArguments31453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._processArguments31453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLoading31454;
		public virtual void setLoading(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._setLoading31454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setLoading31454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extractClassName31455;
		public virtual global::java.lang.String extractClassName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._extractClassName31455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._extractClassName31455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearStatus31456;
		protected virtual void clearStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._clearStatus31456);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._clearStatus31456);
		}
		internal static global::MonoJavaBridge.MethodId _useReloadingTestSuiteLoader31457;
		protected virtual bool useReloadingTestSuiteLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31457);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31457);
		}
		internal static global::MonoJavaBridge.MethodId _inVAJava31458;
		public static bool inVAJava() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._inVAJava31458);
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace31459;
		public static global::java.lang.String getFilteredTrace(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace31459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace31460;
		public static global::java.lang.String getFilteredTrace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace31460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _showStackRaw31461;
		protected static bool showStackRaw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._showStackRaw31461);
		}
		internal static global::MonoJavaBridge.MethodId _BaseTestRunner31462;
		public BaseTestRunner()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._BaseTestRunner31462);
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
			global::junit.runner.BaseTestRunner._getLoader31434 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getLoader", "()Ljunit/runner/TestSuiteLoader;");
			global::junit.runner.BaseTestRunner._truncate31435 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "truncate", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._getPreferences31436 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreferences", "()Ljava/util/Properties;");
			global::junit.runner.BaseTestRunner._addError31437 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner._getPreference31438 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;I)I");
			global::junit.runner.BaseTestRunner._getPreference31439 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._addFailure31440 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.runner.BaseTestRunner._endTest31441 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.runner.BaseTestRunner._startTest31442 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.runner.BaseTestRunner._loadSuiteClass31443 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::junit.runner.BaseTestRunner._testStarted31444 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._testEnded31445 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._testFailed31446 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner._runFailed31447 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "runFailed", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._setPreferences31448 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreferences", "(Ljava/util/Properties;)V");
			global::junit.runner.BaseTestRunner._savePreferences31449 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "savePreferences", "()V");
			global::junit.runner.BaseTestRunner._setPreference31450 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreference", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._getTest31451 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getTest", "(Ljava/lang/String;)Ljunit/framework/Test;");
			global::junit.runner.BaseTestRunner._elapsedTimeAsString31452 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "elapsedTimeAsString", "(J)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._processArguments31453 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "processArguments", "([Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._setLoading31454 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setLoading", "(Z)V");
			global::junit.runner.BaseTestRunner._extractClassName31455 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "extractClassName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._clearStatus31456 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "clearStatus", "()V");
			global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader31457 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "useReloadingTestSuiteLoader", "()Z");
			global::junit.runner.BaseTestRunner._inVAJava31458 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "inVAJava", "()Z");
			global::junit.runner.BaseTestRunner._getFilteredTrace31459 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._getFilteredTrace31460 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._showStackRaw31461 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "showStackRaw", "()Z");
			global::junit.runner.BaseTestRunner._BaseTestRunner31462 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.runner.BaseTestRunner))]
	internal sealed partial class BaseTestRunner_ : junit.runner.BaseTestRunner
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BaseTestRunner_()
		{
			InitJNI();
		}
		internal BaseTestRunner_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _testStarted31464;
		public override void testStarted(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testStarted31464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testStarted31464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testEnded31465;
		public override void testEnded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testEnded31465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testEnded31465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testFailed31466;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testFailed31466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testFailed31466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _runFailed31467;
		protected override void runFailed(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._runFailed31467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._runFailed31467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.BaseTestRunner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/BaseTestRunner"));
			global::junit.runner.BaseTestRunner_._testStarted31464 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner_._testEnded31465 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner_._testFailed31466 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner_._runFailed31467 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "runFailed", "(Ljava/lang/String;)V");
		}
	}
}
