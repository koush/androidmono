namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.FlakyTest_))]
	public partial interface FlakyTest : java.lang.annotation.Annotation
	{
		int tolerance();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.FlakyTest))]
	internal sealed partial class FlakyTest_ : java.lang.Object, FlakyTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FlakyTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _tolerance12181;
		int android.test.FlakyTest.tolerance()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.FlakyTest_.staticClass, "tolerance", "()I", ref global::android.test.FlakyTest_._tolerance12181);
		}
		internal static global::MonoJavaBridge.MethodId _equals12182;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.FlakyTest_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.test.FlakyTest_._equals12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12183;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.FlakyTest_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.test.FlakyTest_._toString12183) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12184;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.FlakyTest_.staticClass, "hashCode", "()I", ref global::android.test.FlakyTest_._hashCode12184);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12185;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.FlakyTest_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.test.FlakyTest_._annotationType12185) as java.lang.Class;
		}
		static FlakyTest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.FlakyTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/FlakyTest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
