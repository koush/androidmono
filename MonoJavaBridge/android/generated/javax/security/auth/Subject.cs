namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Subject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Subject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals30177;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._equals30177.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._equals30177 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._equals30177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30178;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._toString30178.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._toString30178 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._toString30178)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30179;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._hashCode30179.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._hashCode30179 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "hashCode", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._hashCode30179);
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30180;
		public global::java.util.Set getPrincipals(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getPrincipals30180.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getPrincipals30180 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrincipals", "(Ljava/lang/Class;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrincipals30180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		public new global::java.util.Set Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30181;
		public global::java.util.Set getPrincipals()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getPrincipals30181.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getPrincipals30181 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrincipals", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrincipals30181)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly30182;
		public void setReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._setReadOnly30182.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._setReadOnly30182 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "setReadOnly", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._setReadOnly30182);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30183;
		public bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._isReadOnly30183.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._isReadOnly30183 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "isReadOnly", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._isReadOnly30183);
		}
		internal static global::MonoJavaBridge.MethodId _getSubject30184;
		public static global::javax.security.auth.Subject getSubject(java.security.AccessControlContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getSubject30184.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getSubject30184 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getSubject", "(Ljava/security/AccessControlContext;)Ljavax/security/auth/Subject;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.Subject>(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getSubject30184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.auth.Subject;
		}
		internal static global::MonoJavaBridge.MethodId _doAs30185;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._doAs30185.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._doAs30185 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAs30185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAs30186;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._doAs30186.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._doAs30186 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAs30186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAsPrivileged30187;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1, java.security.AccessControlContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._doAsPrivileged30187.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._doAsPrivileged30187 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAsPrivileged30187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAsPrivileged30188;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1, java.security.AccessControlContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._doAsPrivileged30188.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._doAsPrivileged30188 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAsPrivileged30188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		public new global::java.util.Set PublicCredentials
		{
			get
			{
				return getPublicCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicCredentials30189;
		public global::java.util.Set getPublicCredentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getPublicCredentials30189.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getPublicCredentials30189 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPublicCredentials30189)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicCredentials30190;
		public global::java.util.Set getPublicCredentials(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getPublicCredentials30190.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getPublicCredentials30190 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "(Ljava/lang/Class;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPublicCredentials30190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		public new global::java.util.Set PrivateCredentials
		{
			get
			{
				return getPrivateCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateCredentials30191;
		public global::java.util.Set getPrivateCredentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getPrivateCredentials30191.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getPrivateCredentials30191 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrivateCredentials30191)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateCredentials30192;
		public global::java.util.Set getPrivateCredentials(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._getPrivateCredentials30192.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._getPrivateCredentials30192 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "(Ljava/lang/Class;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrivateCredentials30192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _Subject30193;
		public Subject(bool arg0, java.util.Set arg1, java.util.Set arg2, java.util.Set arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._Subject30193.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._Subject30193 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "(ZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._Subject30193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Subject30194;
		public Subject() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._Subject30194.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._Subject30194 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._Subject30194);
			Init(@__env, handle);
		}
		static Subject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.Subject.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/Subject"));
		}
		internal static void InitJNI()
		{
		}
	}
}
