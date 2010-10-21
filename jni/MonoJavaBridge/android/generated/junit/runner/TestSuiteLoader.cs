namespace junit.runner
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::junit.runner.TestSuiteLoader_))]
	public interface TestSuiteLoader  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Class load(java.lang.String arg0);
		global::java.lang.Class reload(java.lang.Class arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::junit.runner.TestSuiteLoader))]
	public sealed partial class TestSuiteLoader_ : java.lang.Object, TestSuiteLoader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestSuiteLoader_()
		{
			InitJNI();
		}
		internal TestSuiteLoader_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _load31350;
		 global::java.lang.Class junit.runner.TestSuiteLoader.load(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.TestSuiteLoader_._load31350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.TestSuiteLoader_.staticClass, global::junit.runner.TestSuiteLoader_._load31350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _reload31351;
		 global::java.lang.Class junit.runner.TestSuiteLoader.reload(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::junit.runner.TestSuiteLoader_._reload31351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::junit.runner.TestSuiteLoader_.staticClass, global::junit.runner.TestSuiteLoader_._reload31351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.TestSuiteLoader_.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/TestSuiteLoader"));
			global::junit.runner.TestSuiteLoader_._load31350 = @__env.GetMethodIDNoThrow(global::junit.runner.TestSuiteLoader_.staticClass, "load", "(Ljava/lang/String;)Ljava/lang/Class;");
			global::junit.runner.TestSuiteLoader_._reload31351 = @__env.GetMethodIDNoThrow(global::junit.runner.TestSuiteLoader_.staticClass, "reload", "(Ljava/lang/Class;)Ljava/lang/Class;");
		}
	}
}
