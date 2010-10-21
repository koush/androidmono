namespace junit.framework
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.framework.Test_))]
	public interface Test  : global::MonoJavaBridge.IJavaObject 
	{
		void run(junit.framework.TestResult arg0);
		int countTestCases();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.framework.Test))]
	public sealed partial class Test_ : java.lang.Object, Test
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Test_()
		{
			InitJNI();
		}
		internal Test_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run31256;
		 void junit.framework.Test.run(junit.framework.TestResult arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::junit.framework.Test_._run31256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::junit.framework.Test_.staticClass, global::junit.framework.Test_._run31256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _countTestCases31257;
		 int junit.framework.Test.countTestCases() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::junit.framework.Test_._countTestCases31257);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::junit.framework.Test_.staticClass, global::junit.framework.Test_._countTestCases31257);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.framework.Test_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/framework/Test"));
			global::junit.framework.Test_._run31256 = @__env.GetMethodIDNoThrow(global::junit.framework.Test_.staticClass, "run", "(Ljunit/framework/TestResult;)V");
			global::junit.framework.Test_._countTestCases31257 = @__env.GetMethodIDNoThrow(global::junit.framework.Test_.staticClass, "countTestCases", "()I");
		}
	}
}
