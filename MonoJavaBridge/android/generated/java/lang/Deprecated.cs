namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Deprecated_))]
	public partial interface Deprecated : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Deprecated))]
	internal sealed partial class Deprecated_ : java.lang.Object, Deprecated
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Deprecated_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Deprecated_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Deprecated_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Deprecated_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Deprecated_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Deprecated_.staticClass, "hashCode", "()I", ref global::java.lang.Deprecated_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.Deprecated_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::java.lang.Deprecated_._m3) as java.lang.Class;
		}
		static Deprecated_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Deprecated_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Deprecated"));
		}
	}
}
