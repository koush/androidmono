namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthScope : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthScope(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.AuthScope.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.auth.AuthScope._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScope.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthScope._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.AuthScope.staticClass, "hashCode", "()I", ref global::org.apache.http.auth.AuthScope._m2);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScope.staticClass, "getScheme", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthScope._m3) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.AuthScope.staticClass, "getPort", "()I", ref global::org.apache.http.auth.AuthScope._m4);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScope.staticClass, "getHost", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthScope._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int match(org.apache.http.auth.AuthScope arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.AuthScope.staticClass, "match", "(Lorg/apache/http/auth/AuthScope;)I", ref global::org.apache.http.auth.AuthScope._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScope.staticClass, "getRealm", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthScope._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.AuthScope._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.AuthScope._m8 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.AuthScope._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.AuthScope._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public AuthScope(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.AuthScope._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.AuthScope._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public AuthScope(org.apache.http.auth.AuthScope arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.AuthScope._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.AuthScope._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Lorg/apache/http/auth/AuthScope;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ANY_HOST7409;
		public static global::java.lang.String ANY_HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_HOST7409)) as java.lang.String;
			}
		}
		public static int ANY_PORT
		{
			get
			{
				return -1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_REALM7411;
		public static global::java.lang.String ANY_REALM
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_REALM7411)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_SCHEME7412;
		public static global::java.lang.String ANY_SCHEME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_SCHEME7412)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY7413;
		public static global::org.apache.http.auth.AuthScope ANY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY7413)) as org.apache.http.auth.AuthScope;
			}
		}
		static AuthScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScope"));
			global::org.apache.http.auth.AuthScope._ANY_HOST7409 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_HOST", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY_REALM7411 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_REALM", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY_SCHEME7412 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_SCHEME", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY7413 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY", "Lorg/apache/http/auth/AuthScope;");
		}
	}
}
