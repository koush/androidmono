namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthScope : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthScope(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals31791;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._equals31791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString31792;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._toString31792)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode31793;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._hashCode31793);
		}
		public new global::java.lang.String Scheme
		{
			get
			{
				return getScheme();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScheme31794;
		public virtual global::java.lang.String getScheme()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getScheme31794)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort31795;
		public virtual int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getPort31795);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost31796;
		public virtual global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getHost31796)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _match31797;
		public virtual int match(org.apache.http.auth.AuthScope arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._match31797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Realm
		{
			get
			{
				return getRealm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRealm31798;
		public virtual global::java.lang.String getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._getRealm31798)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31799;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31800;
		public AuthScope(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31801;
		public AuthScope(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthScope31802;
		public AuthScope(org.apache.http.auth.AuthScope arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthScope.staticClass, global::org.apache.http.auth.AuthScope._AuthScope31802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ANY_HOST31803;
		public static global::java.lang.String ANY_HOST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_HOST31803)) as java.lang.String;
			}
		}
		public static int ANY_PORT
		{
			get
			{
				return -1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_REALM31805;
		public static global::java.lang.String ANY_REALM
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_REALM31805)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY_SCHEME31806;
		public static global::java.lang.String ANY_SCHEME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY_SCHEME31806)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ANY31807;
		public static global::org.apache.http.auth.AuthScope ANY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.auth.AuthScope.staticClass, _ANY31807)) as org.apache.http.auth.AuthScope;
			}
		}
		static AuthScope()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScope.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScope"));
			global::org.apache.http.auth.AuthScope._equals31791 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::org.apache.http.auth.AuthScope._toString31792 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._hashCode31793 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "hashCode", "()I");
			global::org.apache.http.auth.AuthScope._getScheme31794 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getScheme", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._getPort31795 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getPort", "()I");
			global::org.apache.http.auth.AuthScope._getHost31796 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getHost", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._match31797 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "match", "(Lorg/apache/http/auth/AuthScope;)I");
			global::org.apache.http.auth.AuthScope._getRealm31798 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._AuthScope31799 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.auth.AuthScope._AuthScope31800 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::org.apache.http.auth.AuthScope._AuthScope31801 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::org.apache.http.auth.AuthScope._AuthScope31802 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "<init>", "(Lorg/apache/http/auth/AuthScope;)V");
			global::org.apache.http.auth.AuthScope._ANY_HOST31803 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_HOST", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY_REALM31805 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_REALM", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY_SCHEME31806 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY_SCHEME", "Ljava/lang/String;");
			global::org.apache.http.auth.AuthScope._ANY31807 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.auth.AuthScope.staticClass, "ANY", "Lorg/apache/http/auth/AuthScope;");
		}
		internal static void InitJNI()
		{
		}
	}
}
