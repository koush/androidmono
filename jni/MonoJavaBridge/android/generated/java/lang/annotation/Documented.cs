namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Documented_))]
	public partial interface Documented : Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Documented))]
	internal sealed partial class Documented_ : java.lang.Object, Documented
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Documented_()
		{
			InitJNI();
		}
		internal Documented_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20947;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Documented_._equals20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._equals20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20948;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_._toString20948)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._toString20948)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20949;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Documented_._hashCode20949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._hashCode20949);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20950;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_._annotationType20950)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Documented_.staticClass, global::java.lang.annotation.Documented_._annotationType20950)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Documented_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Documented"));
			global::java.lang.annotation.Documented_._equals20947 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.annotation.Documented_._toString20948 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.annotation.Documented_._hashCode20949 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "hashCode", "()I");
			global::java.lang.annotation.Documented_._annotationType20950 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Documented_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
