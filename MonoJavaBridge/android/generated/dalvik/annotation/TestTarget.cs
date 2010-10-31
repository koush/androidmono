namespace dalvik.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.annotation.TestTarget_))]
	public partial interface TestTarget : java.lang.annotation.Annotation
	{
		global::java.lang.String methodName();
		global::java.lang.String conceptName();
		global::java.lang.Class[] methodArgs();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.annotation.TestTarget))]
	internal sealed partial class TestTarget_ : java.lang.Object, TestTarget
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestTarget_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String dalvik.annotation.TestTarget.methodName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTarget_.staticClass, "methodName", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTarget_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String dalvik.annotation.TestTarget.conceptName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTarget_.staticClass, "conceptName", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTarget_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Class[] dalvik.annotation.TestTarget.methodArgs()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::dalvik.annotation.TestTarget_.staticClass, "methodArgs", "()[Ljava/lang/Class;", ref global::dalvik.annotation.TestTarget_._m2) as java.lang.Class[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::dalvik.annotation.TestTarget_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::dalvik.annotation.TestTarget_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTarget_.staticClass, "toString", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTarget_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::dalvik.annotation.TestTarget_.staticClass, "hashCode", "()I", ref global::dalvik.annotation.TestTarget_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.annotation.TestTarget_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::dalvik.annotation.TestTarget_._m6) as java.lang.Class;
		}
		static TestTarget_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.annotation.TestTarget_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/annotation/TestTarget"));
		}
	}
}
