namespace junit.framework
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TestResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestResult()
		{
			InitJNI();
		}
		protected TestResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31400;
		protected virtual void run(junit.framework.TestCase arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._run31400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._run31400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop31401;
		public virtual void stop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._stop31401);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._stop31401);
		}
		internal static global::MonoJavaBridge.MethodId _errors31402;
		public virtual global::java.util.Enumeration errors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestResult._errors31402)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errors31402)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addError31403;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addError31403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addError31403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFailure31404;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addFailure31404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addFailure31404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addListener31405;
		public virtual void addListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addListener31405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addListener31405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeListener31406;
		public virtual void removeListener(junit.framework.TestListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._removeListener31406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._removeListener31406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endTest31407;
		public virtual void endTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._endTest31407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._endTest31407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _errorCount31408;
		public virtual int errorCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._errorCount31408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errorCount31408);
		}
		internal static global::MonoJavaBridge.MethodId _failureCount31409;
		public virtual int failureCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._failureCount31409);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failureCount31409);
		}
		internal static global::MonoJavaBridge.MethodId _failures31410;
		public virtual global::java.util.Enumeration failures()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestResult._failures31410)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failures31410)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _runCount31411;
		public virtual int runCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._runCount31411);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runCount31411);
		}
		internal static global::MonoJavaBridge.MethodId _runProtected31412;
		public virtual void runProtected(junit.framework.Test arg0, junit.framework.Protectable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._runProtected31412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runProtected31412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldStop31413;
		public virtual bool shouldStop()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestResult._shouldStop31413);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._shouldStop31413);
		}
		internal static global::MonoJavaBridge.MethodId _startTest31414;
		public virtual void startTest(junit.framework.Test arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._startTest31414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._startTest31414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _wasSuccessful31415;
		public virtual bool wasSuccessful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestResult._wasSuccessful31415);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._wasSuccessful31415);
		}
		internal static global::MonoJavaBridge.MethodId _TestResult31416;
		public TestResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestResult.staticClass, global::junit.framework.TestResult._TestResult31416);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestResult"));
			global::junit.framework.TestResult._run31400 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "run", "(Ljunit/framework/TestCase;)V");
			global::junit.framework.TestResult._stop31401 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "stop", "()V");
			global::junit.framework.TestResult._errors31402 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errors", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._addError31403 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.framework.TestResult._addFailure31404 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.framework.TestResult._addListener31405 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._removeListener31406 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "removeListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._endTest31407 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._errorCount31408 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errorCount", "()I");
			global::junit.framework.TestResult._failureCount31409 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failureCount", "()I");
			global::junit.framework.TestResult._failures31410 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failures", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._runCount31411 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runCount", "()I");
			global::junit.framework.TestResult._runProtected31412 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V");
			global::junit.framework.TestResult._shouldStop31413 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "shouldStop", "()Z");
			global::junit.framework.TestResult._startTest31414 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._wasSuccessful31415 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "wasSuccessful", "()Z");
			global::junit.framework.TestResult._TestResult31416 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "<init>", "()V");
		}
	}
}
