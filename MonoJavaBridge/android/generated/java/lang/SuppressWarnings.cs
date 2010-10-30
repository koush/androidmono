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
		internal static global::MonoJavaBridge.MethodId _value20779;
		global::java.lang.String[] java.lang.SuppressWarnings.value()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.lang.SuppressWarnings_.staticClass, "value", "()[Ljava/lang/String;", ref global::java.lang.SuppressWarnings_._value20779) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _equals20780;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.SuppressWarnings_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.SuppressWarnings_._equals20780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20781;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.SuppressWarnings_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.SuppressWarnings_._toString20781) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20782;
		int java.lang.annotation.Annotation.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.SuppressWarnings_.staticClass, "hashCode", "()I", ref global::java.lang.SuppressWarnings_._hashCode20782);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20783;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.SuppressWarnings_.staticClass, "annotationType", "()Ljava/lang/Class;", ref global::java.lang.SuppressWarnings_._annotationType20783) as java.lang.Class;
		}
		static SuppressWarnings_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SuppressWarnings_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SuppressWarnings"));
		}
		internal static void InitJNI()
		{
		}
	}
}
