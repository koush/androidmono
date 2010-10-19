namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Annotation_))]
	public interface Annotation  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
		int hashCode();
		global::java.lang.Class annotationType();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Annotation))]
	public sealed partial class Annotation_ : java.lang.Object, Annotation
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Annotation_()
		{
			InitJNI();
		}
		internal Annotation_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals15297;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._equals15297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.annotation.Annotation_.staticClass, global::java.lang.annotation.Annotation_._equals15297, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15298;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._toString15298)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Annotation_.staticClass, global::java.lang.annotation.Annotation_._toString15298)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15299;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._hashCode15299);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.annotation.Annotation_.staticClass, global::java.lang.annotation.Annotation_._hashCode15299);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType15300;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Annotation_._annotationType15300)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Annotation_.staticClass, global::java.lang.annotation.Annotation_._annotationType15300)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Annotation_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Annotation"));
			global::java.lang.annotation.Annotation_._equals15297 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.annotation.Annotation_._toString15298 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.annotation.Annotation_._hashCode15299 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "hashCode", "()I");
			global::java.lang.annotation.Annotation_._annotationType15300 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Annotation_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
