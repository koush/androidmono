namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.LargeTest_))]
	public interface LargeTest : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.LargeTest))]
	public sealed partial class LargeTest_ : java.lang.Object, LargeTest
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LargeTest_()
		{
			InitJNI();
		}
		internal LargeTest_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals8111;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._equals8111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, global::android.test.suitebuilder.annotation.LargeTest_._equals8111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString8112;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._toString8112)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, global::android.test.suitebuilder.annotation.LargeTest_._toString8112)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode8113;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._hashCode8113);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, global::android.test.suitebuilder.annotation.LargeTest_._hashCode8113);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType8114;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_._annotationType8114)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.LargeTest_.staticClass, global::android.test.suitebuilder.annotation.LargeTest_._annotationType8114)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.LargeTest_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/LargeTest"));
			global::android.test.suitebuilder.annotation.LargeTest_._equals8111 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.annotation.LargeTest_._toString8112 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.annotation.LargeTest_._hashCode8113 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.annotation.LargeTest_._annotationType8114 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.LargeTest_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
