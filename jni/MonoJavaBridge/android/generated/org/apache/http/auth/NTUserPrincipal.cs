namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NTUserPrincipal : java.lang.Object, java.security.Principal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NTUserPrincipal()
		{
			InitJNI();
		}
		protected NTUserPrincipal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31843;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal._equals31843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._equals31843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31844;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal._toString31844)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._toString31844)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31845;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal._hashCode31845);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._hashCode31845);
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName31846;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal._getName31846)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._getName31846)) as java.lang.String;
		}
		public new global::java.lang.String Domain
		{
			get
			{
				return getDomain();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDomain31847;
		public virtual global::java.lang.String getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal._getDomain31847)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._getDomain31847)) as java.lang.String;
		}
		public new global::java.lang.String Username
		{
			get
			{
				return getUsername();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUsername31848;
		public virtual global::java.lang.String getUsername() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal._getUsername31848)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._getUsername31848)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _NTUserPrincipal31849;
		public NTUserPrincipal(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.NTUserPrincipal.staticClass, global::org.apache.http.auth.NTUserPrincipal._NTUserPrincipal31849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.NTUserPrincipal.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/NTUserPrincipal"));
			global::org.apache.http.auth.NTUserPrincipal._equals31843 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.NTUserPrincipal._toString31844 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTUserPrincipal._hashCode31845 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.NTUserPrincipal._getName31846 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTUserPrincipal._getDomain31847 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTUserPrincipal._getUsername31848 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "getUsername", "()Ljava/lang/String;");
			global::org.apache.http.auth.NTUserPrincipal._NTUserPrincipal31849 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.NTUserPrincipal.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
