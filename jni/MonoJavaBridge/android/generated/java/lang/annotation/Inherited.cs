namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Inherited_))]
	public partial interface Inherited : Annotation
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Inherited))]
	internal sealed partial class Inherited_ : java.lang.Object, Inherited
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Inherited_()
		{
			InitJNI();
		}
		internal Inherited_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20964;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Inherited_._equals20964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.annotation.Inherited_.staticClass, global::java.lang.annotation.Inherited_._equals20964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20965;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Inherited_._toString20965)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Inherited_.staticClass, global::java.lang.annotation.Inherited_._toString20965)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20966;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Inherited_._hashCode20966);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.annotation.Inherited_.staticClass, global::java.lang.annotation.Inherited_._hashCode20966);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20967;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Inherited_._annotationType20967)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Inherited_.staticClass, global::java.lang.annotation.Inherited_._annotationType20967)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Inherited_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Inherited"));
			global::java.lang.annotation.Inherited_._equals20964 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Inherited_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.annotation.Inherited_._toString20965 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Inherited_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.annotation.Inherited_._hashCode20966 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Inherited_.staticClass, "hashCode", "()I");
			global::java.lang.annotation.Inherited_._annotationType20967 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Inherited_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
