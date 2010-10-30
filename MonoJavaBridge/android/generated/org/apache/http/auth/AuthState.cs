namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthState : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString31808;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthState.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthState._toString31808) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isValid31809;
		public virtual bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.AuthState.staticClass, "isValid", "()Z", ref global::org.apache.http.auth.AuthState._isValid31809);
		}
		internal static global::MonoJavaBridge.MethodId _invalidate31810;
		public virtual void invalidate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthState.staticClass, "invalidate", "()V", ref global::org.apache.http.auth.AuthState._invalidate31810);
		}
		public new global::org.apache.http.auth.AuthScheme AuthScheme
		{
			get
			{
				return getAuthScheme();
			}
			set
			{
				setAuthScheme(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthScheme31811;
		public virtual global::org.apache.http.auth.AuthScheme getAuthScheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.AuthScheme>(this, global::org.apache.http.auth.AuthState.staticClass, "getAuthScheme", "()Lorg/apache/http/auth/AuthScheme;", ref global::org.apache.http.auth.AuthState._getAuthScheme31811) as org.apache.http.auth.AuthScheme;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthScheme31812;
		public virtual void setAuthScheme(org.apache.http.auth.AuthScheme arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthState.staticClass, "setAuthScheme", "(Lorg/apache/http/auth/AuthScheme;)V", ref global::org.apache.http.auth.AuthState._setAuthScheme31812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.auth.Credentials Credentials
		{
			get
			{
				return getCredentials();
			}
			set
			{
				setCredentials(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCredentials31813;
		public virtual global::org.apache.http.auth.Credentials getCredentials()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.Credentials>(this, global::org.apache.http.auth.AuthState.staticClass, "getCredentials", "()Lorg/apache/http/auth/Credentials;", ref global::org.apache.http.auth.AuthState._getCredentials31813) as org.apache.http.auth.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _setCredentials31814;
		public virtual void setCredentials(org.apache.http.auth.Credentials arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthState.staticClass, "setCredentials", "(Lorg/apache/http/auth/Credentials;)V", ref global::org.apache.http.auth.AuthState._setCredentials31814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.auth.AuthScope AuthScope
		{
			get
			{
				return getAuthScope();
			}
			set
			{
				setAuthScope(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthScope31815;
		public virtual global::org.apache.http.auth.AuthScope getAuthScope()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.auth.AuthState.staticClass, "getAuthScope", "()Lorg/apache/http/auth/AuthScope;", ref global::org.apache.http.auth.AuthState._getAuthScope31815) as org.apache.http.auth.AuthScope;
		}
		internal static global::MonoJavaBridge.MethodId _setAuthScope31816;
		public virtual void setAuthScope(org.apache.http.auth.AuthScope arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthState.staticClass, "setAuthScope", "(Lorg/apache/http/auth/AuthScope;)V", ref global::org.apache.http.auth.AuthState._setAuthScope31816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AuthState31817;
		public AuthState() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.AuthState._AuthState31817.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.AuthState._AuthState31817 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthState.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.AuthState.staticClass, global::org.apache.http.auth.AuthState._AuthState31817);
			Init(@__env, handle);
		}
		static AuthState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthState.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthState"));
		}
		internal static void InitJNI()
		{
		}
	}
}
