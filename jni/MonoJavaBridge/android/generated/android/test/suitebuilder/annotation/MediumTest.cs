namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.MediumTest_))]
	public interface MediumTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.MediumTest))]
	public sealed partial class MediumTest_ : java.lang.Object, MediumTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MediumTest_()
		{
			InitJNI();
		}
		internal MediumTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12593;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._equals12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_.staticClass, global::android.test.suitebuilder.annotation.MediumTest_._equals12593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12594;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._toString12594)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_.staticClass, global::android.test.suitebuilder.annotation.MediumTest_._toString12594)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12595;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._hashCode12595);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_.staticClass, global::android.test.suitebuilder.annotation.MediumTest_._hashCode12595);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12596;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_._annotationType12596)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.MediumTest_.staticClass, global::android.test.suitebuilder.annotation.MediumTest_._annotationType12596)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.MediumTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/MediumTest"));
			global::android.test.suitebuilder.annotation.MediumTest_._equals12593 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.annotation.MediumTest_._toString12594 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.annotation.MediumTest_._hashCode12595 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.annotation.MediumTest_._annotationType12596 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.MediumTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
