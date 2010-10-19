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
		internal static global::MonoJavaBridge.MethodId _getLoader24828;
		public virtual global::junit.runner.TestSuiteLoader getLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.runner.TestSuiteLoader>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._getLoader24828)) as junit.runner.TestSuiteLoader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.runner.TestSuiteLoader>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getLoader24828)) as junit.runner.TestSuiteLoader;
		}
		internal static global::MonoJavaBridge.MethodId _truncate24829;
		public static global::java.lang.String truncate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._truncate24829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPreferences24830;
		protected static global::java.util.Properties getPreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreferences24830)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _addError24831;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._addError24831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addError24831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference24832;
		public static int getPreference(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference24832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPreference24833;
		public static global::java.lang.String getPreference(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getPreference24833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _addFailure24834;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._addFailure24834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._addFailure24834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _endTest24835;
		public virtual void endTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._endTest24835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._endTest24835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startTest24836;
		public virtual void startTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._startTest24836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._startTest24836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadSuiteClass24837;
		protected virtual global::java.lang.Class loadSuiteClass(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._loadSuiteClass24837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._loadSuiteClass24837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _testStarted24838;
		public abstract void testStarted(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testEnded24839;
		public abstract void testEnded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _testFailed24840;
		public abstract void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2);
		internal static global::MonoJavaBridge.MethodId _runFailed24841;
		protected abstract void runFailed(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setPreferences24842;
		protected static void setPreferences(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreferences24842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _savePreferences24843;
		public static void savePreferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._savePreferences24843);
		}
		internal static global::MonoJavaBridge.MethodId _setPreference24844;
		public virtual void setPreference(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._setPreference24844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setPreference24844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getTest24845;
		public virtual global::junit.framework.Test getTest(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._getTest24845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::junit.framework.Test>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getTest24845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as junit.framework.Test;
		}
		internal static global::MonoJavaBridge.MethodId _elapsedTimeAsString24846;
		public virtual global::java.lang.String elapsedTimeAsString(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._elapsedTimeAsString24846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._elapsedTimeAsString24846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processArguments24847;
		protected virtual global::java.lang.String processArguments(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._processArguments24847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._processArguments24847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setLoading24848;
		public virtual void setLoading(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._setLoading24848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._setLoading24848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _extractClassName24849;
		public virtual global::java.lang.String extractClassName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._extractClassName24849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._extractClassName24849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearStatus24850;
		protected virtual void clearStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._clearStatus24850);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._clearStatus24850);
		}
		internal static global::MonoJavaBridge.MethodId _useReloadingTestSuiteLoader24851;
		protected virtual bool useReloadingTestSuiteLoader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader24851);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader24851);
		}
		internal static global::MonoJavaBridge.MethodId _inVAJava24852;
		public static bool inVAJava() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._inVAJava24852);
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace24853;
		public static global::java.lang.String getFilteredTrace(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace24853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFilteredTrace24854;
		public static global::java.lang.String getFilteredTrace(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._getFilteredTrace24854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _showStackRaw24855;
		protected static bool showStackRaw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._showStackRaw24855);
		}
		internal static global::MonoJavaBridge.MethodId _BaseTestRunner24856;
		public BaseTestRunner()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._BaseTestRunner24856);
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
			global::junit.runner.BaseTestRunner._getLoader24828 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getLoader", "()Ljunit/runner/TestSuiteLoader;");
			global::junit.runner.BaseTestRunner._truncate24829 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "truncate", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._getPreferences24830 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreferences", "()Ljava/util/Properties;");
			global::junit.runner.BaseTestRunner._addError24831 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner._getPreference24832 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;I)I");
			global::junit.runner.BaseTestRunner._getPreference24833 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._addFailure24834 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.runner.BaseTestRunner._endTest24835 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.runner.BaseTestRunner._startTest24836 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.runner.BaseTestRunner._loadSuiteClass24837 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::junit.runner.BaseTestRunner._testStarted24838 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._testEnded24839 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._testFailed24840 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner._runFailed24841 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "runFailed", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._setPreferences24842 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreferences", "(Ljava/util/Properties;)V");
			global::junit.runner.BaseTestRunner._savePreferences24843 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "savePreferences", "()V");
			global::junit.runner.BaseTestRunner._setPreference24844 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreference", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner._getTest24845 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getTest", "(Ljava/lang/String;)Ljunit/framework/Test;");
			global::junit.runner.BaseTestRunner._elapsedTimeAsString24846 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "elapsedTimeAsString", "(J)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._processArguments24847 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "processArguments", "([Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._setLoading24848 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setLoading", "(Z)V");
			global::junit.runner.BaseTestRunner._extractClassName24849 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "extractClassName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._clearStatus24850 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "clearStatus", "()V");
			global::junit.runner.BaseTestRunner._useReloadingTestSuiteLoader24851 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "useReloadingTestSuiteLoader", "()Z");
			global::junit.runner.BaseTestRunner._inVAJava24852 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "inVAJava", "()Z");
			global::junit.runner.BaseTestRunner._getFilteredTrace24853 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._getFilteredTrace24854 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;");
			global::junit.runner.BaseTestRunner._showStackRaw24855 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "showStackRaw", "()Z");
			global::junit.runner.BaseTestRunner._BaseTestRunner24856 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _testStarted24857;
		public override void testStarted(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testStarted24857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testStarted24857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testEnded24858;
		public override void testEnded(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testEnded24858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testEnded24858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testFailed24859;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._testFailed24859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._testFailed24859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _runFailed24860;
		protected override void runFailed(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_._runFailed24860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.runner.BaseTestRunner_.staticClass, global::junit.runner.BaseTestRunner_._runFailed24860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.BaseTestRunner_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/BaseTestRunner"));
			global::junit.runner.BaseTestRunner_._testStarted24857 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testStarted", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner_._testEnded24858 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testEnded", "(Ljava/lang/String;)V");
			global::junit.runner.BaseTestRunner_._testFailed24859 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.runner.BaseTestRunner_._runFailed24860 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner_.staticClass, "runFailed", "(Ljava/lang/String;)V");
		}
	}
}
