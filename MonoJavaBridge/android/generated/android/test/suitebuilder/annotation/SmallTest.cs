namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.SmallTest_))]
	public partial interface SmallTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.SmallTest))]
	internal sealed partial class SmallTest_ : java.lang.Object, SmallTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SmallTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12655;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.test.suitebuilder.annotation.SmallTest_._equals12655, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12656;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.test.suitebuilder.annotation.SmallTest_._toString12656) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12657;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "hashCode", "()I", ref global::android.test.suitebuilder.annotation.SmallTest_._hashCode12657);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12658;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.test.suitebuilder.annotation.SmallTest_._annotationType12658) as java.lang.Class;
		}
		static SmallTest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.SmallTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/SmallTest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
