namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.annotation.Target_))]
	public partial interface Target : Annotation
	{
		global::java.lang.annotation.ElementType[] value();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.annotation.Target))]
	internal sealed partial class Target_ : java.lang.Object, Target
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Target_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _value20979;
		global::java.lang.annotation.ElementType[] java.lang.annotation.Target.value()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Target_._value20979.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Target_._value20979 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "value", "()[Ljava/lang/annotation/ElementType;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.ElementType>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_._value20979)) as java.lang.annotation.ElementType[];
		}
		internal static global::MonoJavaBridge.MethodId _equals20980;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Target_._equals20980.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Target_._equals20980 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.annotation.Target_._equals20980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20981;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Target_._toString20981.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Target_._toString20981 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_._toString20981)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20982;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Target_._hashCode20982.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Target_._hashCode20982 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.lang.annotation.Target_._hashCode20982);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType20983;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.Target_._annotationType20983.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.Target_._annotationType20983 = @__env.GetMethodIDNoThrow(global::java.lang.annotation.Target_.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.annotation.Target_._annotationType20983)) as java.lang.Class;
		}
		static Target_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.Target_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/Target"));
		}
		internal static void InitJNI()
		{
		}
	}
}
