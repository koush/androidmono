namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.Smoke_))]
	public partial interface Smoke : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.Smoke))]
	internal sealed partial class Smoke_ : java.lang.Object, Smoke
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Smoke_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12659;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.test.suitebuilder.annotation.Smoke_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.test.suitebuilder.annotation.Smoke_._equals12659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12660;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.suitebuilder.annotation.Smoke_.staticClass, "toString", "()Ljava/lang/String;", ref global::android.test.suitebuilder.annotation.Smoke_._toString12660) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12661;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.test.suitebuilder.annotation.Smoke_.staticClass, "hashCode", "()I", ref global::android.test.suitebuilder.annotation.Smoke_._hashCode12661);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12662;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::android.test.suitebuilder.annotation.Smoke_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::android.test.suitebuilder.annotation.Smoke_._annotationType12662) as java.lang.Class;
		}
		static Smoke_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.Smoke_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/Smoke"));
		}
		internal static void InitJNI()
		{
		}
	}
}
