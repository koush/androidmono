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
		internal Retention_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value20969;
		global::java.lang.annotation.RetentionPolicy java.lang.annotation.Retention.value()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.annotation.RetentionPolicy>(this, global::java.lang.annotation.Retention_.staticClass, "value", "()Ljava/lang/annotation/RetentionPolicy;", ref global::java.lang.annotation.Retention_._value20969) as java.lang.annotation.RetentionPolicy;
		}
		internal static global::MonoJavaBridge.MethodId _equals20970;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.annotation.Retention_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.annotation.Retention_._equals20970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20971;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.annotation.Retention_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.annotation.Retention_._toString20971) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20972;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.annotation.Retention_.staticClass, "hashCode", "()I", ref global::java.lang.annotation.Retention_._hashCode20972);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20973;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.annotation.Retention_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::java.lang.annotation.Retention_._annotationType20973) as java.lang.Class;
		}
		static Retention_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Retention_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Retention"));
		}
		internal static void InitJNI()
		{
		}
	}
}
