namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestScheme : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DigestScheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32727;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.DigestScheme.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.DigestScheme._getSchemeName32727) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge32728;
		public override void processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.DigestScheme.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.impl.auth.DigestScheme._processChallenge32728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32729;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.DigestScheme.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.impl.auth.DigestScheme._isConnectionBased32729);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32730;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.DigestScheme.staticClass, "isComplete", "()Z", ref global::org.apache.http.impl.auth.DigestScheme._isComplete32730);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32731;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.auth.DigestScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.impl.auth.DigestScheme._authenticate32731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _overrideParamter32732;
		public virtual void overrideParamter(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.DigestScheme.staticClass, "overrideParamter", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.apache.http.impl.auth.DigestScheme._overrideParamter32732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createCnonce32733;
		public static global::java.lang.String createCnonce()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.DigestScheme._createCnonce32733.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.DigestScheme._createCnonce32733 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "createCnonce", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._createCnonce32733)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DigestScheme32734;
		public DigestScheme() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.DigestScheme._DigestScheme32734.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.DigestScheme._DigestScheme32734 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._DigestScheme32734);
			Init(@__env, handle);
		}
		static DigestScheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.DigestScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/DigestScheme"));
		}
		internal static void InitJNI()
		{
		}
	}
}
