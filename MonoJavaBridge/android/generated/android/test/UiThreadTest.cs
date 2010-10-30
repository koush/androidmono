namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.UiThreadTest_))]
	public partial interface UiThreadTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.UiThreadTest))]
	internal sealed partial class UiThreadTest_ : java.lang.Object, UiThreadTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal UiThreadTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12357;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.UiThreadTest_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.test.UiThreadTest_._equals12357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12358;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.UiThreadTest_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.test.UiThreadTest_._toString12358) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12359;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.UiThreadTest_.staticClass, "hashCode", "()I", ref global::android.test.UiThreadTest_._hashCode12359);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12360;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.UiThreadTest_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.test.UiThreadTest_._annotationType12360) as java.lang.Class;
		}
		static UiThreadTest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.UiThreadTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/UiThreadTest"));
		}
		internal static void InitJNI()
		{
		}
	}
}
