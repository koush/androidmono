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
		internal static global::MonoJavaBridge.MethodId _run24794;
		protected virtual void run(junit.framework.TestCase arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._run24794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._run24794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stop24795;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._stop24795);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._stop24795);
		}
		internal static global::MonoJavaBridge.MethodId _errors24796;
		public virtual global::java.util.Enumeration errors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestResult._errors24796)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errors24796)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _addError24797;
		public virtual void addError(junit.framework.Test arg0, java.lang.Throwable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addError24797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addError24797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFailure24798;
		public virtual void addFailure(junit.framework.Test arg0, junit.framework.AssertionFailedError arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addFailure24798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addFailure24798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addListener24799;
		public virtual void addListener(junit.framework.TestListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._addListener24799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._addListener24799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeListener24800;
		public virtual void removeListener(junit.framework.TestListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._removeListener24800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._removeListener24800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endTest24801;
		public virtual void endTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._endTest24801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._endTest24801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _errorCount24802;
		public virtual int errorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._errorCount24802);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._errorCount24802);
		}
		internal static global::MonoJavaBridge.MethodId _failureCount24803;
		public virtual int failureCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._failureCount24803);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failureCount24803);
		}
		internal static global::MonoJavaBridge.MethodId _failures24804;
		public virtual global::java.util.Enumeration failures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::junit.framework.TestResult._failures24804)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._failures24804)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _runCount24805;
		public virtual int runCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.TestResult._runCount24805);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runCount24805);
		}
		internal static global::MonoJavaBridge.MethodId _runProtected24806;
		public virtual void runProtected(junit.framework.Test arg0, junit.framework.Protectable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._runProtected24806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._runProtected24806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldStop24807;
		public virtual bool shouldStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestResult._shouldStop24807);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._shouldStop24807);
		}
		internal static global::MonoJavaBridge.MethodId _startTest24808;
		public virtual void startTest(junit.framework.Test arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.TestResult._startTest24808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._startTest24808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _wasSuccessful24809;
		public virtual bool wasSuccessful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::junit.framework.TestResult._wasSuccessful24809);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::junit.framework.TestResult.staticClass, global::junit.framework.TestResult._wasSuccessful24809);
		}
		internal static global::MonoJavaBridge.MethodId _TestResult24810;
		public TestResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(junit.framework.TestResult.staticClass, global::junit.framework.TestResult._TestResult24810);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.TestResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/TestResult"));
			global::junit.framework.TestResult._run24794 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "run", "(Ljunit/framework/TestCase;)V");
			global::junit.framework.TestResult._stop24795 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "stop", "()V");
			global::junit.framework.TestResult._errors24796 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errors", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._addError24797 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addError", "(Ljunit/framework/Test;Ljava/lang/Throwable;)V");
			global::junit.framework.TestResult._addFailure24798 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addFailure", "(Ljunit/framework/Test;Ljunit/framework/AssertionFailedError;)V");
			global::junit.framework.TestResult._addListener24799 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "addListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._removeListener24800 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "removeListener", "(Ljunit/framework/TestListener;)V");
			global::junit.framework.TestResult._endTest24801 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "endTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._errorCount24802 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "errorCount", "()I");
			global::junit.framework.TestResult._failureCount24803 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failureCount", "()I");
			global::junit.framework.TestResult._failures24804 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "failures", "()Ljava/util/Enumeration;");
			global::junit.framework.TestResult._runCount24805 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runCount", "()I");
			global::junit.framework.TestResult._runProtected24806 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "runProtected", "(Ljunit/framework/Test;Ljunit/framework/Protectable;)V");
			global::junit.framework.TestResult._shouldStop24807 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "shouldStop", "()Z");
			global::junit.framework.TestResult._startTest24808 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "startTest", "(Ljunit/framework/Test;)V");
			global::junit.framework.TestResult._wasSuccessful24809 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "wasSuccessful", "()Z");
			global::junit.framework.TestResult._TestResult24810 = @__env.GetMethodIDNoThrow(global::junit.framework.TestResult.staticClass, "<init>", "()V");
		}
	}
}
