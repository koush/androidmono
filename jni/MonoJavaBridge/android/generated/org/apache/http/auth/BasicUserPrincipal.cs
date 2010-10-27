namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicUserPrincipal : java.lang.Object, java.security.Principal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicUserPrincipal()
		{
			InitJNI();
		}
		internal BasicUserPrincipal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31820;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal._equals31820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal.staticClass, global::org.apache.http.auth.BasicUserPrincipal._equals31820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31821;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal._toString31821)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal.staticClass, global::org.apache.http.auth.BasicUserPrincipal._toString31821)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31822;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal._hashCode31822);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal.staticClass, global::org.apache.http.auth.BasicUserPrincipal._hashCode31822);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName31823;
		public global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal._getName31823)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.BasicUserPrincipal.staticClass, global::org.apache.http.auth.BasicUserPrincipal._getName31823)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicUserPrincipal31824;
		public BasicUserPrincipal(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.BasicUserPrincipal.staticClass, global::org.apache.http.auth.BasicUserPrincipal._BasicUserPrincipal31824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.BasicUserPrincipal.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/BasicUserPrincipal"));
			global::org.apache.http.auth.BasicUserPrincipal._equals31820 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.BasicUserPrincipal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.BasicUserPrincipal._toString31821 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.BasicUserPrincipal.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.BasicUserPrincipal._hashCode31822 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.BasicUserPrincipal.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.BasicUserPrincipal._getName31823 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.BasicUserPrincipal.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.auth.BasicUserPrincipal._BasicUserPrincipal31824 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.BasicUserPrincipal.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
