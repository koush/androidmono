namespace android.test
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.FlakyTest_))]
	public partial interface FlakyTest : java.lang.annotation.Annotation
	{
		int tolerance();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.FlakyTest))]
	internal sealed partial class FlakyTest_ : java.lang.Object, FlakyTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FlakyTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _tolerance12181;
		int android.test.FlakyTest.tolerance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.FlakyTest_._tolerance12181);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._tolerance12181);
		}
		internal static global::MonoJavaBridge.MethodId _equals12182;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.FlakyTest_._equals12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._equals12182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12183;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.FlakyTest_._toString12183)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._toString12183)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12184;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.FlakyTest_._hashCode12184);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._hashCode12184);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12185;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.FlakyTest_._annotationType12185)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.FlakyTest_.staticClass, global::android.test.FlakyTest_._annotationType12185)) as java.lang.Class;
		}
		static FlakyTest_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.FlakyTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/FlakyTest"));
			global::android.test.FlakyTest_._tolerance12181 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "tolerance", "()I");
			global::android.test.FlakyTest_._equals12182 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.FlakyTest_._toString12183 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.FlakyTest_._hashCode12184 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "hashCode", "()I");
			global::android.test.FlakyTest_._annotationType12185 = @__env.GetMethodIDNoThrow(global::android.test.FlakyTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
