namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Subject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Subject()
		{
			InitJNI();
		}
		internal Subject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30058;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject._equals30058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._equals30058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30059;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._toString30059)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._toString30059)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30060;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.auth.Subject._hashCode30060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._hashCode30060);
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30061;
		public global::java.util.Set getPrincipals(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrincipals30061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrincipals30061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		public new global::java.util.Set Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30062;
		public global::java.util.Set getPrincipals() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrincipals30062)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrincipals30062)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly30063;
		public void setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.Subject._setReadOnly30063);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._setReadOnly30063);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30064;
		public bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject._isReadOnly30064);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._isReadOnly30064);
		}
		internal static global::MonoJavaBridge.MethodId _getSubject30065;
		public static global::javax.security.auth.Subject getSubject(java.security.AccessControlContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getSubject30065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.auth.Subject;
		}
		internal static global::MonoJavaBridge.MethodId _doAs30066;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAs30066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAs30067;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAs30067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAsPrivileged30068;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1, java.security.AccessControlContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAsPrivileged30068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAsPrivileged30069;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1, java.security.AccessControlContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAsPrivileged30069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		public new global::java.util.Set PublicCredentials
		{
			get
			{
				return getPublicCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicCredentials30070;
		public global::java.util.Set getPublicCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPublicCredentials30070)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPublicCredentials30070)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicCredentials30071;
		public global::java.util.Set getPublicCredentials(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPublicCredentials30071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPublicCredentials30071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		public new global::java.util.Set PrivateCredentials
		{
			get
			{
				return getPrivateCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateCredentials30072;
		public global::java.util.Set getPrivateCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrivateCredentials30072)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrivateCredentials30072)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateCredentials30073;
		public global::java.util.Set getPrivateCredentials(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrivateCredentials30073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrivateCredentials30073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _Subject30074;
		public Subject(bool arg0, java.util.Set arg1, java.util.Set arg2, java.util.Set arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._Subject30074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Subject30075;
		public Subject()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._Subject30075);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.Subject.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/Subject"));
			global::javax.security.auth.Subject._equals30058 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.auth.Subject._toString30059 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.auth.Subject._hashCode30060 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "hashCode", "()I");
			global::javax.security.auth.Subject._getPrincipals30061 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrincipals", "(Ljava/lang/Class;)Ljava/util/Set;");
			global::javax.security.auth.Subject._getPrincipals30062 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrincipals", "()Ljava/util/Set;");
			global::javax.security.auth.Subject._setReadOnly30063 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "setReadOnly", "()V");
			global::javax.security.auth.Subject._isReadOnly30064 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "isReadOnly", "()Z");
			global::javax.security.auth.Subject._getSubject30065 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getSubject", "(Ljava/security/AccessControlContext;)Ljavax/security/auth/Subject;");
			global::javax.security.auth.Subject._doAs30066 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._doAs30067 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._doAsPrivileged30068 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._doAsPrivileged30069 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._getPublicCredentials30070 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "()Ljava/util/Set;");
			global::javax.security.auth.Subject._getPublicCredentials30071 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "(Ljava/lang/Class;)Ljava/util/Set;");
			global::javax.security.auth.Subject._getPrivateCredentials30072 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "()Ljava/util/Set;");
			global::javax.security.auth.Subject._getPrivateCredentials30073 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "(Ljava/lang/Class;)Ljava/util/Set;");
			global::javax.security.auth.Subject._Subject30074 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "(ZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;)V");
			global::javax.security.auth.Subject._Subject30075 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "()V");
		}
	}
}
