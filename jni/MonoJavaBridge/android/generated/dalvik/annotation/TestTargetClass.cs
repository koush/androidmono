namespace dalvik.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.annotation.TestTargetClass_))]
	public interface TestTargetClass : java.lang.annotation.Annotation
	{
		global::java.lang.Class value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.annotation.TestTargetClass))]
	public sealed partial class TestTargetClass_ : java.lang.Object, TestTargetClass
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TestTargetClass_()
		{
			InitJNI();
		}
		internal TestTargetClass_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value13037;
		 global::java.lang.Class dalvik.annotation.TestTargetClass.value() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_._value13037)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_.staticClass, global::dalvik.annotation.TestTargetClass_._value13037)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _equals13038;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_._equals13038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_.staticClass, global::dalvik.annotation.TestTargetClass_._equals13038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13039;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_._toString13039)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_.staticClass, global::dalvik.annotation.TestTargetClass_._toString13039)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13040;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_._hashCode13040);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_.staticClass, global::dalvik.annotation.TestTargetClass_._hashCode13040);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType13041;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_._annotationType13041)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTargetClass_.staticClass, global::dalvik.annotation.TestTargetClass_._annotationType13041)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.annotation.TestTargetClass_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/annotation/TestTargetClass"));
			global::dalvik.annotation.TestTargetClass_._value13037 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTargetClass_.staticClass, "value", "()Ljava/lang/Class;");
			global::dalvik.annotation.TestTargetClass_._equals13038 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTargetClass_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::dalvik.annotation.TestTargetClass_._toString13039 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTargetClass_.staticClass, "toString", "()Ljava/lang/String;");
			global::dalvik.annotation.TestTargetClass_._hashCode13040 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTargetClass_.staticClass, "hashCode", "()I");
			global::dalvik.annotation.TestTargetClass_._annotationType13041 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTargetClass_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
