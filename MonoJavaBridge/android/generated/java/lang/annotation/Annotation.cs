namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Annotation_))]
	public partial interface Annotation  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
		int hashCode();
		global::java.lang.Class annotationType();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Annotation))]
	internal sealed partial class Annotation_ : java.lang.Object, Annotation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Annotation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20938;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Annotation_._equals20938.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Annotation_._equals20938 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._equals20938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20939;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Annotation_._toString20939.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Annotation_._toString20939 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._toString20939)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20940;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Annotation_._hashCode20940.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Annotation_._hashCode20940 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._hashCode20940);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20941;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Annotation_._annotationType20941.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Annotation_._annotationType20941 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._annotationType20941)) as java.lang.Class;
		}
		static Annotation_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Annotation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Annotation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
