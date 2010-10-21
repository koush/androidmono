namespace java.lang
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.SuppressWarnings_))]
	public interface SuppressWarnings : java.lang.annotation.Annotation
	{
		global::java.lang.String[] value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.SuppressWarnings))]
	public sealed partial class SuppressWarnings_ : java.lang.Object, SuppressWarnings
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SuppressWarnings_()
		{
			InitJNI();
		}
		internal SuppressWarnings_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value20660;
		 global::java.lang.String[] java.lang.SuppressWarnings.value() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._value20660)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_.staticClass, global::java.lang.SuppressWarnings_._value20660)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _equals20661;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._equals20661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.SuppressWarnings_.staticClass, global::java.lang.SuppressWarnings_._equals20661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20662;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._toString20662)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_.staticClass, global::java.lang.SuppressWarnings_._toString20662)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20663;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._hashCode20663);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.SuppressWarnings_.staticClass, global::java.lang.SuppressWarnings_._hashCode20663);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20664;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_._annotationType20664)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.SuppressWarnings_.staticClass, global::java.lang.SuppressWarnings_._annotationType20664)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.SuppressWarnings_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/SuppressWarnings"));
			global::java.lang.SuppressWarnings_._value20660 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "value", "()[Ljava/lang/String;");
			global::java.lang.SuppressWarnings_._equals20661 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.SuppressWarnings_._toString20662 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.SuppressWarnings_._hashCode20663 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "hashCode", "()I");
			global::java.lang.SuppressWarnings_._annotationType20664 = @__env.GetMethodIDNoThrow(global::java.lang.SuppressWarnings_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
