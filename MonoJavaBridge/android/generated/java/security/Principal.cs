namespace java.security
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.Principal_))]
	public partial interface Principal  : global::MonoJavaBridge.IJavaObject 
	{
		bool equals(java.lang.Object arg0);
		global::java.lang.String toString();
		int hashCode();
		global::java.lang.String getName();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Principal))]
	internal sealed partial class Principal_ : java.lang.Object, Principal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Principal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23239;
		bool java.security.Principal.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Principal_._equals23239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString23240;
		global::java.lang.String java.security.Principal.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Principal_._toString23240)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23241;
		int java.security.Principal.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.security.Principal_._hashCode23241);
		}
		internal static global::MonoJavaBridge.MethodId _getName23242;
		global::java.lang.String java.security.Principal.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Principal_._getName23242)) as java.lang.String;
		}
		static Principal_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Principal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Principal"));
			global::java.security.Principal_._equals23239 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Principal_._toString23240 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Principal_._hashCode23241 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "hashCode", "()I");
			global::java.security.Principal_._getName23242 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "getName", "()Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
