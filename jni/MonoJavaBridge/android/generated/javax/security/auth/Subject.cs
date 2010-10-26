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
		internal static global::MonoJavaBridge.MethodId _equals30176;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject._equals30176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._equals30176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30177;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._toString30177)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._toString30177)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30178;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.security.auth.Subject._hashCode30178);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._hashCode30178);
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30179;
		public global::java.util.Set getPrincipals(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrincipals30179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrincipals30179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		public new global::java.util.Set Principals
		{
			get
			{
				return getPrincipals();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrincipals30180;
		public global::java.util.Set getPrincipals() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrincipals30180)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrincipals30180)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly30181;
		public void setReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.security.auth.Subject._setReadOnly30181);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._setReadOnly30181);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly30182;
		public bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject._isReadOnly30182);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._isReadOnly30182);
		}
		internal static global::MonoJavaBridge.MethodId _getSubject30183;
		public static global::javax.security.auth.Subject getSubject(java.security.AccessControlContext arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.security.auth.Subject>(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getSubject30183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.security.auth.Subject;
		}
		internal static global::MonoJavaBridge.MethodId _doAs30184;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAs30184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAs30185;
		public static global::java.lang.Object doAs(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAs30185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAsPrivileged30186;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedAction arg1, java.security.AccessControlContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAsPrivileged30186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _doAsPrivileged30187;
		public static global::java.lang.Object doAsPrivileged(javax.security.auth.Subject arg0, java.security.PrivilegedExceptionAction arg1, java.security.AccessControlContext arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._doAsPrivileged30187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		public new global::java.util.Set PublicCredentials
		{
			get
			{
				return getPublicCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicCredentials30188;
		public global::java.util.Set getPublicCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPublicCredentials30188)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPublicCredentials30188)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getPublicCredentials30189;
		public global::java.util.Set getPublicCredentials(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPublicCredentials30189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPublicCredentials30189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		public new global::java.util.Set PrivateCredentials
		{
			get
			{
				return getPrivateCredentials();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateCredentials30190;
		public global::java.util.Set getPrivateCredentials() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrivateCredentials30190)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrivateCredentials30190)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateCredentials30191;
		public global::java.util.Set getPrivateCredentials(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::javax.security.auth.Subject._getPrivateCredentials30191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._getPrivateCredentials30191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _Subject30192;
		public Subject(bool arg0, java.util.Set arg1, java.util.Set arg2, java.util.Set arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._Subject30192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Subject30193;
		public Subject()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.Subject.staticClass, global::javax.security.auth.Subject._Subject30193);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.Subject.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/Subject"));
			global::javax.security.auth.Subject._equals30176 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.security.auth.Subject._toString30177 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.security.auth.Subject._hashCode30178 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "hashCode", "()I");
			global::javax.security.auth.Subject._getPrincipals30179 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrincipals", "(Ljava/lang/Class;)Ljava/util/Set;");
			global::javax.security.auth.Subject._getPrincipals30180 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrincipals", "()Ljava/util/Set;");
			global::javax.security.auth.Subject._setReadOnly30181 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "setReadOnly", "()V");
			global::javax.security.auth.Subject._isReadOnly30182 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "isReadOnly", "()Z");
			global::javax.security.auth.Subject._getSubject30183 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getSubject", "(Ljava/security/AccessControlContext;)Ljavax/security/auth/Subject;");
			global::javax.security.auth.Subject._doAs30184 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._doAs30185 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAs", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._doAsPrivileged30186 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._doAsPrivileged30187 = @__env.GetStaticMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "doAsPrivileged", "(Ljavax/security/auth/Subject;Ljava/security/PrivilegedExceptionAction;Ljava/security/AccessControlContext;)Ljava/lang/Object;");
			global::javax.security.auth.Subject._getPublicCredentials30188 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "()Ljava/util/Set;");
			global::javax.security.auth.Subject._getPublicCredentials30189 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPublicCredentials", "(Ljava/lang/Class;)Ljava/util/Set;");
			global::javax.security.auth.Subject._getPrivateCredentials30190 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "()Ljava/util/Set;");
			global::javax.security.auth.Subject._getPrivateCredentials30191 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "getPrivateCredentials", "(Ljava/lang/Class;)Ljava/util/Set;");
			global::javax.security.auth.Subject._Subject30192 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "(ZLjava/util/Set;Ljava/util/Set;Ljava/util/Set;)V");
			global::javax.security.auth.Subject._Subject30193 = @__env.GetMethodIDNoThrow(global::javax.security.auth.Subject.staticClass, "<init>", "()V");
		}
	}
}
