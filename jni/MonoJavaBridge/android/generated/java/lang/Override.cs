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
		internal static global::MonoJavaBridge.MethodId _equals14749;
		 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.Override_._equals14749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._equals14749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14750;
		 global::java.lang.String java.lang.annotation.Annotation.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Override_._toString14750)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._toString14750)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14751;
		 int java.lang.annotation.Annotation.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.Override_._hashCode14751);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._hashCode14751);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType14752;
		 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Override_._annotationType14752)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Override_.staticClass, global::java.lang.Override_._annotationType14752)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Override_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Override"));
			global::java.lang.Override_._equals14749 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.Override_._toString14750 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Override_._hashCode14751 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "hashCode", "()I");
			global::java.lang.Override_._annotationType14752 = @__env.GetMethodIDNoThrow(global::java.lang.Override_.staticClass, "annotationType", "()Ljava/lang/Class;");
		}
	}
}
