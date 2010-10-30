namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTCredentials : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NTCredentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31834;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.NTCredentials.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.auth.NTCredentials._equals31834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31835;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._toString31835) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31836;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.NTCredentials.staticClass, "hashCode", "()I", ref global::org.apache.http.auth.NTCredentials._hashCode31836);
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomain31837;
		public virtual global::java.lang.String getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._getDomain31837) as java.lang.String;
		}
		public new global::java.lang.String Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword31838;
		public virtual global::java.lang.String getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getPassword", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._getPassword31838) as java.lang.String;
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserName31839;
		public virtual global::java.lang.String getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getUserName", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._getUserName31839) as java.lang.String;
		}
		public new global::java.security.Principal UserPrincipal
		{
			get
			{
				return getUserPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserPrincipal31840;
		public virtual global::java.security.Principal getUserPrincipal()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Principal>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getUserPrincipal", "()Ljava/security/Principal;", ref global::org.apache.http.auth.NTCredentials._getUserPrincipal31840) as java.security.Principal;
		}
		public new global::java.lang.String Workstation
		{
			get
			{
				return getWorkstation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWorkstation31841;
		public virtual global::java.lang.String getWorkstation()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTCredentials.staticClass, "getWorkstation", "()Ljava/lang/String;", ref global::org.apache.http.auth.NTCredentials._getWorkstation31841) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _NTCredentials31842;
		public NTCredentials(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTCredentials._NTCredentials31842.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTCredentials._NTCredentials31842 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._NTCredentials31842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NTCredentials31843;
		public NTCredentials(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTCredentials._NTCredentials31843.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTCredentials._NTCredentials31843 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._NTCredentials31843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
