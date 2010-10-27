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
		static UiThreadTest_()
		{
			InitJNI();
		}
		internal UiThreadTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12357;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.UiThreadTest_._equals12357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._equals12357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12358;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_._toString12358)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._toString12358)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12359;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.UiThreadTest_._hashCode12359);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._hashCode12359);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12360;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_._annotationType12360)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.UiThreadTest_.staticClass, global::android.test.UiThreadTest_._annotationType12360)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.UiThreadTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/UiThreadTest"));
			global::android.test.UiThreadTest_._equals12357 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.UiThreadTest_._toString12358 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.UiThreadTest_._hashCode12359 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "hashCode", "()I");
			global::android.test.UiThreadTest_._annotationType12360 = @__env.GetMethodIDNoThrow(global::android.test.UiThreadTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
