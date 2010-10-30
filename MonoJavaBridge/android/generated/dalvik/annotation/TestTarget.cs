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
		internal static global::MonoJavaBridge.MethodId _methodName18337;
		global::java.lang.String dalvik.annotation.TestTarget.methodName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTarget_.staticClass, "methodName", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTarget_._methodName18337) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _conceptName18338;
		global::java.lang.String dalvik.annotation.TestTarget.conceptName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTarget_.staticClass, "conceptName", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTarget_._conceptName18338) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _methodArgs18339;
		global::java.lang.Class[] dalvik.annotation.TestTarget.methodArgs()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Class>(this, global::dalvik.annotation.TestTarget_.staticClass, "methodArgs", "()[Ljava/lang/Class;", ref global::dalvik.annotation.TestTarget_._methodArgs18339) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _equals18340;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::dalvik.annotation.TestTarget_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::dalvik.annotation.TestTarget_._equals18340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18341;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTarget_.staticClass, "toString", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTarget_._toString18341) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18342;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::dalvik.annotation.TestTarget_.staticClass, "hashCode", "()I", ref global::dalvik.annotation.TestTarget_._hashCode18342);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType18343;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.annotation.TestTarget_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::dalvik.annotation.TestTarget_._annotationType18343) as java.lang.Class;
		}
		static TestTarget_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.annotation.TestTarget_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/annotation/TestTarget"));
		}
		internal static void InitJNI()
		{
		}
	}
}
