namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.Suppress_))]
	public partial interface Suppress : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.Suppress))]
	internal sealed partial class Suppress_ : java.lang.Object, Suppress
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Suppress_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12663;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Suppress_._equals12663.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Suppress_._equals12663 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._equals12663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12664;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Suppress_._toString12664.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Suppress_._toString12664 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._toString12664)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12665;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Suppress_._hashCode12665.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Suppress_._hashCode12665 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._hashCode12665);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12666;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Suppress_._annotationType12666.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Suppress_._annotationType12666 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Suppress_.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Suppress_._annotationType12666)) as java.lang.Class;
		}
		static Suppress_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.Suppress_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/Suppress"));
		}
		internal static void InitJNI()
		{
		}
	}
}
