namespace dalvik.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.annotation.TestTargetClass_))]
	public partial interface TestTargetClass : java.lang.annotation.Annotation
	{
		global::java.lang.Class value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.annotation.TestTargetClass))]
	internal sealed partial class TestTargetClass_ : java.lang.Object, TestTargetClass
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestTargetClass_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value18344;
		global::java.lang.Class dalvik.annotation.TestTargetClass.value()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.annotation.TestTargetClass_.staticClass, "value", "()Ljava/lang/Class;", ref global::dalvik.annotation.TestTargetClass_._value18344) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _equals18345;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::dalvik.annotation.TestTargetClass_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::dalvik.annotation.TestTargetClass_._equals18345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18346;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::dalvik.annotation.TestTargetClass_.staticClass, "toString", "()Ljava/lang/String;", ref global::dalvik.annotation.TestTargetClass_._toString18346) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18347;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::dalvik.annotation.TestTargetClass_.staticClass, "hashCode", "()I", ref global::dalvik.annotation.TestTargetClass_._hashCode18347);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType18348;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::dalvik.annotation.TestTargetClass_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::dalvik.annotation.TestTargetClass_._annotationType18348) as java.lang.Class;
		}
		static TestTargetClass_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.annotation.TestTargetClass_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/annotation/TestTargetClass"));
		}
		internal static void InitJNI()
		{
		}
	}
}
