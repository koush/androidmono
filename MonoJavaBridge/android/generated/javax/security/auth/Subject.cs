namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Subject : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Subject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.Subject.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.security.auth.Subject._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.security.auth.Subject.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.security.auth.Subject._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.security.auth.Subject.staticClass, "hashCode", "()I", ref global::javax.security.auth.Subject._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.util.Set getPrincipals(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::javax.security.auth.Subject.staticClass, "getPrincipals", "(Ljava/lang/Class;)Ljava/util/Set;", ref global::javax.security.auth.Subject._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Set;
		}
		public new global::java.util.Set Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.util.Set getPrincipals()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::javax.security.auth.Subject.staticClass, "getPrincipals", "()Ljava/util/Set;", ref global::javax.security.auth.Subject._m4) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void setReadOnly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.security.auth.Subject.staticClass, "setReadOnly", "()V", ref global::javax.security.auth.Subject._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.security.auth.Subject.staticClass, "isReadOnly", "()Z", ref global::javax.security.auth.Subject._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::javax.security.auth.Subject getSubject(java.security.AccessControlContext arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m7.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m7 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getSubject", "(Ljava/security/AccessControlContext;)Ljavax/security/auth/Subject;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.Subject>(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.auth.Subject;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m8.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m8 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m9.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m9 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1, java.security.AccessControlContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m10.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m10 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1, java.security.AccessControlContext arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m11.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m11 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		public new global::java.util.Set PublicCredentials
		{
			get
			{
				return getPublicCredentials();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.util.Set getPublicCredentials()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "()Ljava/util/Set;", ref global::javax.security.auth.Subject._m12) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.util.Set getPublicCredentials(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "(Ljava/lang/Class;)Ljava/util/Set;", ref global::javax.security.auth.Subject._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Set;
		}
		public new global::java.util.Set PrivateCredentials
		{
			get
			{
				return getPrivateCredentials();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.util.Set getPrivateCredentials()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "()Ljava/util/Set;", ref global::javax.security.auth.Subject._m14) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.util.Set getPrivateCredentials(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "(Ljava/lang/Class;)Ljava/util/Set;", ref global::javax.security.auth.Subject._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public Subject(bool arg0, java.util.Set arg1, java.util.Set arg2, java.util.Set arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m16.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m16 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "(ZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public Subject() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.Subject._m17.native == global::System.IntPtr.Zero)
				global::javax.security.auth.Subject._m17 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._m17);
			Init(@__env, handle);
		}
		static Subject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.Subject.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/Subject"));
		}
	}
}
