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
		internal static global::MonoJavaBridge.MethodId _run31282;
		protected virtual void run(junit.framework.TestCase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._run31282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._run31282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop31283;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._stop31283);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._stop31283);
		}
		internal static global::MonoJavaBridge.MethodId _errors31284;
		public virtual global::java.util.Enumeration errors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestResult._errors31284)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errors31284)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addError31285;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addError31285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addError31285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFailure31286;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addFailure31286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addFailure31286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addListener31287;
		public virtual void addListener(junit.framework.TestListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addListener31287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addListener31287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeListener31288;
		public virtual void removeListener(junit.framework.TestListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._removeListener31288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._removeListener31288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endTest31289;
		public virtual void endTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._endTest31289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._endTest31289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _errorCount31290;
		public virtual int errorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._errorCount31290);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errorCount31290);
		}
		internal static global::MonoJavaBridge.MethodId _failureCount31291;
		public virtual int failureCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._failureCount31291);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failureCount31291);
		}
		internal static global::MonoJavaBridge.MethodId _failures31292;
		public virtual global::java.util.Enumeration failures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestResult._failures31292)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failures31292)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _runCount31293;
		public virtual int runCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._runCount31293);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runCount31293);
		}
		internal static global::MonoJavaBridge.MethodId _runProtected31294;
		public virtual void runProtected(junit.framework.Test arg0, junit.framework.Protectable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._runProtected31294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runProtected31294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldStop31295;
		public virtual bool shouldStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestResult._shouldStop31295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._shouldStop31295);
		}
		internal static global::MonoJavaBridge.MethodId _startTest31296;
		public virtual void startTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._startTest31296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._startTest31296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _wasSuccessful31297;
		public virtual bool wasSuccessful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestResult._wasSuccessful31297);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._wasSuccessful31297);
		}
		internal static global::MonoJavaBridge.MethodId _TestResult31298;
		public TestResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestResult.staticClass, global::junit.framework.TestResult._TestResult31298);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestResult"));
			global::junit.framework.TestResult._run31282 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "run", "(Ljunit/framework/TestCase;)V");
			global::junit.framework.TestResult._stop31283 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "stop", "()V");
			global::junit.framework.TestResult._errors31284 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errors", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._addError31285 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.framework.TestResult._addFailure31286 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.framework.TestResult._addListener31287 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._removeListener31288 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "removeListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._endTest31289 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._errorCount31290 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errorCount", "()I");
			global::junit.framework.TestResult._failureCount31291 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failureCount", "()I");
			global::junit.framework.TestResult._failures31292 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failures", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._runCount31293 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runCount", "()I");
			global::junit.framework.TestResult._runProtected31294 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V");
			global::junit.framework.TestResult._shouldStop31295 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "shouldStop", "()Z");
			global::junit.framework.TestResult._startTest31296 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._wasSuccessful31297 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "wasSuccessful", "()Z");
			global::junit.framework.TestResult._TestResult31298 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "<init>", "()V");
		}
	}
}
