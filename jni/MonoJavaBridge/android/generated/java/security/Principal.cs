namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Principal_))]
	public interface Principal  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
		int hashCode();
		global::java.lang.String getName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Principal))]
	public sealed partial class Principal_ : java.lang.Object, Principal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Principal_()
		{
			InitJNI();
		}
		internal Principal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals14871;
		 bool java.security.Principal.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Principal_._equals14871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._equals14871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString14872;
		 global::java.lang.String java.security.Principal.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Principal_._toString14872)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._toString14872)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode14873;
		 int java.security.Principal.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Principal_._hashCode14873);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._hashCode14873);
		}
		internal static global::MonoJavaBridge.MethodId _getName14874;
		 global::java.lang.String java.security.Principal.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Principal_._getName14874)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._getName14874)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Principal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Principal"));
			global::java.security.Principal_._equals14871 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Principal_._toString14872 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Principal_._hashCode14873 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "hashCode", "()I");
			global::java.security.Principal_._getName14874 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "getName", "()Ljava/lang/String;");
		}
	}
}
