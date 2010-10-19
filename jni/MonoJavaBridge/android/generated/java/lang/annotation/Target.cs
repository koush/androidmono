namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Target_))]
	public interface Target : Annotation
	{
		global::java.lang.annotation.ElementType[] value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Target))]
	public sealed partial class Target_ : java.lang.Object, Target
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Target_()
		{
			InitJNI();
		}
		internal Target_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value15338;
		 global::java.lang.annotation.ElementType[] java.lang.annotation.Target.value() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_._value15338)) as java.lang.annotation.ElementType[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_.staticClass, global::java.lang.annotation.Target_._value15338)) as java.lang.annotation.ElementType[];
		}
		internal static global::MonoJavaBridge.MethodId _equals15339;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Target_._equals15339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.annotation.Target_.staticClass, global::java.lang.annotation.Target_._equals15339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15340;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_._toString15340)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_.staticClass, global::java.lang.annotation.Target_._toString15340)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15341;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Target_._hashCode15341);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.annotation.Target_.staticClass, global::java.lang.annotation.Target_._hashCode15341);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType15342;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_._annotationType15342)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_.staticClass, global::java.lang.annotation.Target_._annotationType15342)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Target_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Target"));
			global::java.lang.annotation.Target_._value15338 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "value", "()[Ljava/lang/annotation/ElementType;");
			global::java.lang.annotation.Target_._equals15339 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.annotation.Target_._toString15340 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.annotation.Target_._hashCode15341 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "hashCode", "()I");
			global::java.lang.annotation.Target_._annotationType15342 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
