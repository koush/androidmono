namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTCredentials : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NTCredentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.NTCredentials.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.auth.NTCredentials._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.NTCredentials.staticClass, "hashCode", "()I", ref global::org.apache.http.auth.NTCredentials._m2);
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._m3) as java.lang.String;
		}
		public new global::java.lang.String Password
		{
			get
			{
				return getPassword();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getPassword", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._m4) as java.lang.String;
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getUserName", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._m5) as java.lang.String;
		}
		public new global::java.security.Principal UserPrincipal
		{
			get
			{
				return getUserPrincipal();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.security.Principal getUserPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getUserPrincipal", "()Ljava/security/Principal;", ref global::org.apache.http.auth.NTCredentials._m6) as java.security.Principal;
		}
		public new global::java.lang.String Workstation
		{
			get
			{
				return getWorkstation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getWorkstation()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getWorkstation", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public NTCredentials(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTCredentials._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTCredentials._m8 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public NTCredentials(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTCredentials._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTCredentials._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NTCredentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.NTCredentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/NTCredentials"));
		}
		internal static void InitJNI()
		{
		}
	}
}
