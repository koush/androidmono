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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._value20779)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _equals20780;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._equals20780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20781;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._toString20781)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20782;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._hashCode20782);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20783;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._annotationType20783)) as java.lang.Class;
		}
		static SuppressWarnings_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SuppressWarnings_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SuppressWarnings"));
			global::java.lang.SuppressWarnings_._value20779 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "value", "()[Ljava/lang/String;");
			global::java.lang.SuppressWarnings_._equals20780 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.SuppressWarnings_._toString20781 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.SuppressWarnings_._hashCode20782 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "hashCode", "()I");
			global::java.lang.SuppressWarnings_._annotationType20783 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
