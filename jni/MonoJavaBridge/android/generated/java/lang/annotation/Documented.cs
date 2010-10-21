namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Documented_))]
	public interface Documented : Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Documented))]
	public sealed partial class Documented_ : java.lang.Object, Documented
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Documented_()
		{
			InitJNI();
		}
		internal Documented_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20829;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Documented_._equals20829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._equals20829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20830;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_._toString20830)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._toString20830)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20831;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Documented_._hashCode20831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._hashCode20831);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20832;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_._annotationType20832)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._annotationType20832)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Documented_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Documented"));
			global::java.lang.annotation.Documented_._equals20829 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.annotation.Documented_._toString20830 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.annotation.Documented_._hashCode20831 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "hashCode", "()I");
			global::java.lang.annotation.Documented_._annotationType20832 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
