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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.LargeTest_._equals12647.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.LargeTest_._equals12647 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._equals12647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12648;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.LargeTest_._toString12648.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.LargeTest_._toString12648 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._toString12648)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12649;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.LargeTest_._hashCode12649.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.LargeTest_._hashCode12649 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._hashCode12649);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12650;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.LargeTest_._annotationType12650.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.LargeTest_._annotationType12650 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._annotationType12650)) as java.lang.Class;
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
