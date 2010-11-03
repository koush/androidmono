namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.SuppressWarnings_))]
	public partial interface SuppressWarnings : java.lang.annotation.Annotation
	{
		global::java.lang.String[] value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.SuppressWarnings))]
	internal sealed partial class SuppressWarnings_ : java.lang.Object, SuppressWarnings
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SuppressWarnings_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String[] java.lang.SuppressWarnings.value()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.lang.SuppressWarnings_.staticClass, "value", "()[Ljava/lang/String;", ref global::java.lang.SuppressWarnings_._m0) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SuppressWarnings_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.SuppressWarnings_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.SuppressWarnings_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.SuppressWarnings_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.SuppressWarnings_.staticClass, "hashCode", "()I", ref global::java.lang.SuppressWarnings_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.SuppressWarnings_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::java.lang.SuppressWarnings_._m4) as java.lang.Class;
		}
		static SuppressWarnings_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SuppressWarnings_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SuppressWarnings"));
		}
	}
}
