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
		internal static global::MonoJavaBridge.MethodId _equals17521;
		 bool java.security.Principal.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Principal_._equals17521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._equals17521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString17522;
		 global::java.lang.String java.security.Principal.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Principal_._toString17522)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._toString17522)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode17523;
		 int java.security.Principal.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.Principal_._hashCode17523);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._hashCode17523);
		}
		internal static global::MonoJavaBridge.MethodId _getName17524;
		 global::java.lang.String java.security.Principal.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Principal_._getName17524)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Principal_.staticClass, global::java.security.Principal_._getName17524)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Principal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Principal"));
			global::java.security.Principal_._equals17521 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.security.Principal_._toString17522 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Principal_._hashCode17523 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "hashCode", "()I");
			global::java.security.Principal_._getName17524 = @__env.GetMethodIDNoThrow(global::java.security.Principal_.staticClass, "getName", "()Ljava/lang/String;");
		}
	}
}
