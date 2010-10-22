namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTCredentials : java.lang.Object, Credentials
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NTCredentials()
		{
			InitJNI();
		}
		protected NTCredentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31715;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._equals31715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._equals31715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31716;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._toString31716)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._toString31716)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31717;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._hashCode31717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._hashCode31717);
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomain31718;
		public virtual global::java.lang.String getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._getDomain31718)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._getDomain31718)) as java.lang.String;
		}
		public new global::java.lang.String Password
		{
			get
			{
				return getPassword();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPassword31719;
		public virtual global::java.lang.String getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._getPassword31719)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._getPassword31719)) as java.lang.String;
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserName31720;
		public virtual global::java.lang.String getUserName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._getUserName31720)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._getUserName31720)) as java.lang.String;
		}
		public new global::java.security.Principal UserPrincipal
		{
			get
			{
				return getUserPrincipal();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserPrincipal31721;
		public virtual global::java.security.Principal getUserPrincipal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._getUserPrincipal31721)) as java.security.Principal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Principal>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._getUserPrincipal31721)) as java.security.Principal;
		}
		public new global::java.lang.String Workstation
		{
			get
			{
				return getWorkstation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWorkstation31722;
		public virtual global::java.lang.String getWorkstation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials._getWorkstation31722)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._getWorkstation31722)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _NTCredentials31723;
		public NTCredentials(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._NTCredentials31723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NTCredentials31724;
		public NTCredentials(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTCredentials.staticClass, global::org.apache.http.auth.NTCredentials._NTCredentials31724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.NTCredentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/NTCredentials"));
			global::org.apache.http.auth.NTCredentials._equals31715 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.NTCredentials._toString31716 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTCredentials._hashCode31717 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.NTCredentials._getDomain31718 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTCredentials._getPassword31719 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "getPassword", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTCredentials._getUserName31720 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "getUserName", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTCredentials._getUserPrincipal31721 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "getUserPrincipal", "()Ljava/security/Principal;");
			global::org.apache.http.auth.NTCredentials._getWorkstation31722 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "getWorkstation", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTCredentials._NTCredentials31723 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.auth.NTCredentials._NTCredentials31724 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTCredentials.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
