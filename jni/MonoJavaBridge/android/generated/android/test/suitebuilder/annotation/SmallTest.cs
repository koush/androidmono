namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.SmallTest_))]
	public interface SmallTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.SmallTest))]
	public sealed partial class SmallTest_ : java.lang.Object, SmallTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SmallTest_()
		{
			InitJNI();
		}
		internal SmallTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12597;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_._equals12597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, global::android.test.suitebuilder.annotation.SmallTest_._equals12597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12598;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_._toString12598)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, global::android.test.suitebuilder.annotation.SmallTest_._toString12598)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12599;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_._hashCode12599);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, global::android.test.suitebuilder.annotation.SmallTest_._hashCode12599);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12600;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_._annotationType12600)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.SmallTest_.staticClass, global::android.test.suitebuilder.annotation.SmallTest_._annotationType12600)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.SmallTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/SmallTest"));
			global::android.test.suitebuilder.annotation.SmallTest_._equals12597 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.annotation.SmallTest_._toString12598 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.annotation.SmallTest_._hashCode12599 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.annotation.SmallTest_._annotationType12600 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.SmallTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
