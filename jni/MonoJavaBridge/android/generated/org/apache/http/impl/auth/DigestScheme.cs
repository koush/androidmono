namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DigestScheme : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DigestScheme()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getSchemeName32608;
		public override global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme._getSchemeName32608)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._getSchemeName32608)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge32609;
		public override void processChallenge(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme._processChallenge32609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._processChallenge32609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32610;
		public override bool isConnectionBased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme._isConnectionBased32610);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._isConnectionBased32610);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32611;
		public override bool isComplete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme._isComplete32611);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._isComplete32611);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32612;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme._authenticate32612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._authenticate32612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _overrideParamter32613;
		public virtual void overrideParamter(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme._overrideParamter32613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._overrideParamter32613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createCnonce32614;
		public static global::java.lang.String createCnonce() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._createCnonce32614)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _DigestScheme32615;
		public DigestScheme()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.DigestScheme.staticClass, global::org.apache.http.impl.auth.DigestScheme._DigestScheme32615);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.DigestScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/DigestScheme"));
			global::org.apache.http.impl.auth.DigestScheme._getSchemeName32608 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.DigestScheme._processChallenge32609 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.impl.auth.DigestScheme._isConnectionBased32610 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.DigestScheme._isComplete32611 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.DigestScheme._authenticate32612 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.DigestScheme._overrideParamter32613 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "overrideParamter", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.apache.http.impl.auth.DigestScheme._createCnonce32614 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "createCnonce", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.DigestScheme._DigestScheme32615 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.DigestScheme.staticClass, "<init>", "()V");
		}
	}
}
