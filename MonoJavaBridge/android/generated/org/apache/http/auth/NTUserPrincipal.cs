namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTUserPrincipal : java.lang.Object, java.security.Principal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NTUserPrincipal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31844;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._equals31844.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._equals31844 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._equals31844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31845;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._toString31845.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._toString31845 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._toString31845) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31846;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._hashCode31846.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._hashCode31846 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._hashCode31846);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName31847;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._getName31847.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._getName31847 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._getName31847) as java.lang.String;
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomain31848;
		public virtual global::java.lang.String getDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._getDomain31848.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._getDomain31848 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "getDomain", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._getDomain31848) as java.lang.String;
		}
		public new global::java.lang.String Username
		{
			get
			{
				return getUsername();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUsername31849;
		public virtual global::java.lang.String getUsername()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._getUsername31849.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._getUsername31849 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "getUsername", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._getUsername31849) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _NTUserPrincipal31850;
		public NTUserPrincipal(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.NTUserPrincipal._NTUserPrincipal31850.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.NTUserPrincipal._NTUserPrincipal31850 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._NTUserPrincipal31850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static NTUserPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.NTUserPrincipal.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/NTUserPrincipal"));
		}
		internal static void InitJNI()
		{
		}
	}
}
