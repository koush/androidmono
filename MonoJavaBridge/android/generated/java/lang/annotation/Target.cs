namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Target_))]
	public partial interface Target : Annotation
	{
		global::java.lang.annotation.ElementType[] value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Target))]
	internal sealed partial class Target_ : java.lang.Object, Target
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Target_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.annotation.ElementType[] java.lang.annotation.Target.value()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.ElementType>(this, global::java.lang.annotation.Target_.staticClass, "value", "()[Ljava/lang/annotation/ElementType;", ref global::java.lang.annotation.Target_._m0) as java.lang.annotation.ElementType[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.annotation.Target_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.annotation.Target_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.annotation.Target_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.annotation.Target_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.annotation.Target_.staticClass, "hashCode", "()I", ref global::java.lang.annotation.Target_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.annotation.Target_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::java.lang.annotation.Target_._m4) as java.lang.Class;
		}
		static Target_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Target_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Target"));
		}
	}
}
