namespace junit.runner
{
	[global::MonoJavaBridge.JavaClass(typeof(global::junit.runner.BaseTestRunner_))]
	public abstract partial class BaseTestRunner : java.lang.Object, junit.framework.TestListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BaseTestRunner(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::junit.runner.TestSuiteLoader getLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.runner.TestSuiteLoader>(this, global::junit.runner.BaseTestRunner.staticClass, "getLoader", "()Ljunit/runner/TestSuiteLoader;", ref global::junit.runner.BaseTestRunner._m0) as junit.runner.TestSuiteLoader;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String truncate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m1.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m1 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "truncate", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected static global::java.util.Properties getPreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m2.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m2 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreferences", "()Ljava/util/Properties;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m2)) as java.util.Properties;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V", ref global::junit.runner.BaseTestRunner._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int getPreference(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m4.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m4 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;I)I");
			return @__env.CallStaticIntMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.lang.String getPreference(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m5.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m5 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getPreference", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V", ref global::junit.runner.BaseTestRunner._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void endTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "endTest", "(Ljunit/framework/Test;)V", ref global::junit.runner.BaseTestRunner._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void startTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "startTest", "(Ljunit/framework/Test;)V", ref global::junit.runner.BaseTestRunner._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::java.lang.Class loadSuiteClass(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::junit.runner.BaseTestRunner.staticClass, "loadSuiteClass", "(Ljava/lang/String;)Ljava/lang/Class;", ref global::junit.runner.BaseTestRunner._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public abstract void testStarted(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract void testEnded(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2);
		private static global::MonoJavaBridge.MethodId _m13;
		protected abstract void runFailed(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		protected static void setPreferences(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m14.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m14 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "setPreferences", "(Ljava/util/Properties;)V");
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void savePreferences()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m15.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m15 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "savePreferences", "()V");
			@__env.CallStaticVoidMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setPreference(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "setPreference", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::junit.runner.BaseTestRunner._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::junit.framework.Test getTest(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<junit.framework.Test>(this, global::junit.runner.BaseTestRunner.staticClass, "getTest", "(Ljava/lang/String;)Ljunit/framework/Test;", ref global::junit.runner.BaseTestRunner._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as junit.framework.Test;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String elapsedTimeAsString(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.runner.BaseTestRunner.staticClass, "elapsedTimeAsString", "(J)Ljava/lang/String;", ref global::junit.runner.BaseTestRunner._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual global::java.lang.String processArguments(java.lang.String[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.runner.BaseTestRunner.staticClass, "processArguments", "([Ljava/lang/String;)Ljava/lang/String;", ref global::junit.runner.BaseTestRunner._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setLoading(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "setLoading", "(Z)V", ref global::junit.runner.BaseTestRunner._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::java.lang.String extractClassName(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::junit.runner.BaseTestRunner.staticClass, "extractClassName", "(Ljava/lang/String;)Ljava/lang/String;", ref global::junit.runner.BaseTestRunner._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		protected virtual void clearStatus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner.staticClass, "clearStatus", "()V", ref global::junit.runner.BaseTestRunner._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual bool useReloadingTestSuiteLoader()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::junit.runner.BaseTestRunner.staticClass, "useReloadingTestSuiteLoader", "()Z", ref global::junit.runner.BaseTestRunner._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static bool inVAJava()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m24.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m24 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "inVAJava", "()Z");
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static global::java.lang.String getFilteredTrace(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m25.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m25 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/Throwable;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static global::java.lang.String getFilteredTrace(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m26.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m26 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "getFilteredTrace", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		protected static bool showStackRaw()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m27.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m27 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "showStackRaw", "()Z");
			return @__env.CallStaticBooleanMethod(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public BaseTestRunner() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.BaseTestRunner._m28.native == global::System.IntPtr.Zero)
				global::junit.runner.BaseTestRunner._m28 = @__env.GetMethodIDNoThrow(global::junit.runner.BaseTestRunner.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.runner.BaseTestRunner.staticClass, global::junit.runner.BaseTestRunner._m28);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override void testStarted(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner_.staticClass, "testStarted", "(Ljava/lang/String;)V", ref global::junit.runner.BaseTestRunner_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void testEnded(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner_.staticClass, "testEnded", "(Ljava/lang/String;)V", ref global::junit.runner.BaseTestRunner_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void testFailed(int arg0, junit.framework.Test arg1, java.lang.Throwable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner_.staticClass, "testFailed", "(ILjunit/framework/Test;Ljava/lang/Throwable;)V", ref global::junit.runner.BaseTestRunner_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void runFailed(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::junit.runner.BaseTestRunner_.staticClass, "runFailed", "(Ljava/lang/String;)V", ref global::junit.runner.BaseTestRunner_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
