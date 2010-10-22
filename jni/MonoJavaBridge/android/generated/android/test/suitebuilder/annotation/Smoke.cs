namespace android.test.suitebuilder.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.test.suitebuilder.annotation.Smoke_))]
	public partial interface Smoke : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.suitebuilder.annotation.Smoke))]
	public sealed partial class Smoke_ : java.lang.Object, Smoke
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Smoke_()
		{
			InitJNI();
		}
		internal Smoke_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals12601;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._equals12601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_.staticClass, global::android.test.suitebuilder.annotation.Smoke_._equals12601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString12602;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._toString12602)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_.staticClass, global::android.test.suitebuilder.annotation.Smoke_._toString12602)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode12603;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._hashCode12603);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_.staticClass, global::android.test.suitebuilder.annotation.Smoke_._hashCode12603);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType12604;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_._annotationType12604)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.suitebuilder.annotation.Smoke_.staticClass, global::android.test.suitebuilder.annotation.Smoke_._annotationType12604)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.suitebuilder.annotation.Smoke_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/suitebuilder/annotation/Smoke"));
			global::android.test.suitebuilder.annotation.Smoke_._equals12601 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.test.suitebuilder.annotation.Smoke_._toString12602 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.test.suitebuilder.annotation.Smoke_._hashCode12603 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "hashCode", "()I");
			global::android.test.suitebuilder.annotation.Smoke_._annotationType12604 = @__env.GetMethodIDNoThrow(global::android.test.suitebuilder.annotation.Smoke_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
