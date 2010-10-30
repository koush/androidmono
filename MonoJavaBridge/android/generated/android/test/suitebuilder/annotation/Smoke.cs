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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Smoke_._equals12659.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Smoke_._equals12659 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._equals12659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12660;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Smoke_._toString12660.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Smoke_._toString12660 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._toString12660)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12661;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Smoke_._hashCode12661.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Smoke_._hashCode12661 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._hashCode12661);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12662;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.suitebuilder.annotation.Smoke_._annotationType12662.native == global::System.IntPtr.Zero)
				global::android.test.suitebuilder.annotation.Smoke_._annotationType12662 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._annotationType12662)) as java.lang.Class;
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
