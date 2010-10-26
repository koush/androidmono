namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicScheme : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicScheme()
		{
			InitJNI();
		}
		protected BasicScheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32717;
		public override global::java.lang.String getSchemeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme._getSchemeName32717)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._getSchemeName32717)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge32718;
		public override void processChallenge(org.apache.http.Header arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme._processChallenge32718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._processChallenge32718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32719;
		public override bool isConnectionBased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme._isConnectionBased32719);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._isConnectionBased32719);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32720;
		public override bool isComplete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme._isComplete32720);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._isComplete32720);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32721;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme._authenticate32721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._authenticate32721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32722;
		public static global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallStaticObjectMethod(org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._authenticate32722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _BasicScheme32723;
		public BasicScheme()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.BasicScheme.staticClass, global::org.apache.http.impl.auth.BasicScheme._BasicScheme32723);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.BasicScheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/BasicScheme"));
			global::org.apache.http.impl.auth.BasicScheme._getSchemeName32717 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.impl.auth.BasicScheme._processChallenge32718 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.impl.auth.BasicScheme._isConnectionBased32719 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.impl.auth.BasicScheme._isComplete32720 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "isComplete", "()Z");
			global::org.apache.http.impl.auth.BasicScheme._authenticate32721 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.BasicScheme._authenticate32722 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Ljava/lang/String;Z)Lorg/apache/http/Header;");
			global::org.apache.http.impl.auth.BasicScheme._BasicScheme32723 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.BasicScheme.staticClass, "<init>", "()V");
		}
	}
}
