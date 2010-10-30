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
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.security.Principal.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Principal_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.security.Principal_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.security.Principal.toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Principal_.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Principal_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		int java.security.Principal.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.Principal_.staticClass, "hashCode", "()I", ref global::java.security.Principal_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String java.security.Principal.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Principal_.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.Principal_._m3) as java.lang.String;
		}
		static Principal_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Principal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Principal"));
		}
		internal static void InitJNI()
		{
		}
	}
}
