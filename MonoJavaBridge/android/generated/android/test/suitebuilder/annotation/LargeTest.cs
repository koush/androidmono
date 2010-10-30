namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.LargeTest_))]
	public partial interface LargeTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.LargeTest))]
	internal sealed partial class LargeTest_ : java.lang.Object, LargeTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LargeTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12647;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.test.suitebuilder.annotation.LargeTest_._equals12647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12648;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.test.suitebuilder.annotation.LargeTest_._toString12648) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12649;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "hashCode", "()I", ref global::android.test.suitebuilder.annotation.LargeTest_._hashCode12649);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12650;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.test.suitebuilder.annotation.LargeTest_._annotationType12650) as java.lang.Class;
		}
		static LargeTest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.LargeTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/LargeTest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
