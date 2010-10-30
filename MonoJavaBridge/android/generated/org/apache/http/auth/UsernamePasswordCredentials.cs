namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UsernamePasswordCredentials : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UsernamePasswordCredentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.auth.UsernamePasswordCredentials._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.auth.UsernamePasswordCredentials._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "hashCode", "()I", ref global::org.apache.http.auth.UsernamePasswordCredentials._m2);
		}
		public new global::java.lang.String Password
		{
			get
			{
				return getPassword();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getPassword", "()Ljava/lang/String;", ref global::org.apache.http.auth.UsernamePasswordCredentials._m3) as java.lang.String;
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getUserName", "()Ljava/lang/String;", ref global::org.apache.http.auth.UsernamePasswordCredentials._m4) as java.lang.String;
		}
		public new global::java.security.Principal UserPrincipal
		{
			get
			{
				return getUserPrincipal();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.Principal getUserPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getUserPrincipal", "()Ljava/security/Principal;", ref global::org.apache.http.auth.UsernamePasswordCredentials._m5) as java.security.Principal;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public UsernamePasswordCredentials(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.UsernamePasswordCredentials._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.UsernamePasswordCredentials._m6 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public UsernamePasswordCredentials(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.UsernamePasswordCredentials._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.UsernamePasswordCredentials._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UsernamePasswordCredentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.UsernamePasswordCredentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/UsernamePasswordCredentials"));
		}
		internal static void InitJNI()
		{
		}
	}
}
