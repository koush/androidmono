namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.Override_))]
	public interface Override : java.lang.annotation.Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.Override))]
	public sealed partial class Override_ : java.lang.Object, Override
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Override_()
		{
			InitJNI();
		}
		internal Override_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20263;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Override_._equals20263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._equals20263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20264;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Override_._toString20264)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._toString20264)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20265;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Override_._hashCode20265);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._hashCode20265);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20266;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Override_._annotationType20266)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._annotationType20266)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Override_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Override"));
			global::java.lang.Override_._equals20263 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Override_._toString20264 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Override_._hashCode20265 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "hashCode", "()I");
			global::java.lang.Override_._annotationType20266 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
