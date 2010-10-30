namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicUserPrincipal : java.lang.Object, java.security.Principal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BasicUserPrincipal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31821;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.BasicUserPrincipal.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.auth.BasicUserPrincipal._equals31821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31822;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.BasicUserPrincipal.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.auth.BasicUserPrincipal._toString31822) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31823;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.BasicUserPrincipal.staticClass, "hashCode", "()I", ref global::org.apache.http.auth.BasicUserPrincipal._hashCode31823);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName31824;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.BasicUserPrincipal.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.auth.BasicUserPrincipal._getName31824) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicUserPrincipal31825;
		public BasicUserPrincipal(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.BasicUserPrincipal._BasicUserPrincipal31825.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.BasicUserPrincipal._BasicUserPrincipal31825 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.BasicUserPrincipal.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.BasicUserPrincipal.staticClass, global::org.apache.http.auth.BasicUserPrincipal._BasicUserPrincipal31825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BasicUserPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.BasicUserPrincipal.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/BasicUserPrincipal"));
		}
		internal static void InitJNI()
		{
		}
	}
}
