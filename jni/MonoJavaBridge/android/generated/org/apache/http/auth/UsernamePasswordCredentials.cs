namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UsernamePasswordCredentials : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UsernamePasswordCredentials()
		{
			InitJNI();
		}
		protected UsernamePasswordCredentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31850;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials._equals31850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._equals31850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31851;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials._toString31851)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._toString31851)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31852;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials._hashCode31852);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._hashCode31852);
		}
		public new global::java.lang.String Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword31853;
		public virtual global::java.lang.String getPassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials._getPassword31853)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._getPassword31853)) as java.lang.String;
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserName31854;
		public virtual global::java.lang.String getUserName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials._getUserName31854)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._getUserName31854)) as java.lang.String;
		}
		public new global::java.security.Principal UserPrincipal
		{
			get
			{
				return getUserPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserPrincipal31855;
		public virtual global::java.security.Principal getUserPrincipal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials._getUserPrincipal31855)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._getUserPrincipal31855)) as java.security.Principal;
		}
		internal static global::MonoJavaBridge.MethodId _UsernamePasswordCredentials31856;
		public UsernamePasswordCredentials(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UsernamePasswordCredentials31857;
		public UsernamePasswordCredentials(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.UsernamePasswordCredentials.staticClass, global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.UsernamePasswordCredentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/UsernamePasswordCredentials"));
			global::org.apache.http.auth.UsernamePasswordCredentials._equals31850 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.UsernamePasswordCredentials._toString31851 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.UsernamePasswordCredentials._hashCode31852 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.UsernamePasswordCredentials._getPassword31853 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getPassword", "()Ljava/lang/String;");
			global::org.apache.http.auth.UsernamePasswordCredentials._getUserName31854 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getUserName", "()Ljava/lang/String;");
			global::org.apache.http.auth.UsernamePasswordCredentials._getUserPrincipal31855 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "getUserPrincipal", "()Ljava/security/Principal;");
			global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31856 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.auth.UsernamePasswordCredentials._UsernamePasswordCredentials31857 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.UsernamePasswordCredentials.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
