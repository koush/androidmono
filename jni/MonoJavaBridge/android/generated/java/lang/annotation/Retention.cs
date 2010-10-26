namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Retention_))]
	public partial interface Retention : Annotation
	{
		global::java.lang.annotation.RetentionPolicy value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Retention))]
	internal sealed partial class Retention_ : java.lang.Object, Retention
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Retention_()
		{
			InitJNI();
		}
		internal Retention_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value20968;
		 global::java.lang.annotation.RetentionPolicy java.lang.annotation.Retention.value() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Retention_._value20968)) as java.lang.annotation.RetentionPolicy;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Retention_.staticClass, global::java.lang.annotation.Retention_._value20968)) as java.lang.annotation.RetentionPolicy;
		}
		internal static global::MonoJavaBridge.MethodId _equals20969;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Retention_._equals20969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.annotation.Retention_.staticClass, global::java.lang.annotation.Retention_._equals20969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20970;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Retention_._toString20970)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Retention_.staticClass, global::java.lang.annotation.Retention_._toString20970)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20971;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Retention_._hashCode20971);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.annotation.Retention_.staticClass, global::java.lang.annotation.Retention_._hashCode20971);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20972;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Retention_._annotationType20972)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Retention_.staticClass, global::java.lang.annotation.Retention_._annotationType20972)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Retention_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Retention"));
			global::java.lang.annotation.Retention_._value20968 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Retention_.staticClass, "value", "()Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.Retention_._equals20969 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Retention_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.annotation.Retention_._toString20970 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Retention_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.annotation.Retention_._hashCode20971 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Retention_.staticClass, "hashCode", "()I");
			global::java.lang.annotation.Retention_._annotationType20972 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Retention_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
