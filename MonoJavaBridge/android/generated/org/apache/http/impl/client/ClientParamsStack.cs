namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ClientParamsStack : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ClientParamsStack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::org.apache.http.@params.HttpParams copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.ClientParamsStack._m0) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.ClientParamsStack._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.impl.client.ClientParamsStack._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.impl.client.ClientParamsStack._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.@params.HttpParams ApplicationParams
		{
			get
			{
				return getApplicationParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.@params.HttpParams getApplicationParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getApplicationParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.ClientParamsStack._m4) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams ClientParams
		{
			get
			{
				return getClientParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.@params.HttpParams getClientParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getClientParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.ClientParamsStack._m5) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams RequestParams
		{
			get
			{
				return getRequestParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.@params.HttpParams getRequestParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getRequestParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.ClientParamsStack._m6) as org.apache.http.@params.HttpParams;
		}
		public new global::org.apache.http.@params.HttpParams OverrideParams
		{
			get
			{
				return getOverrideParams();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.@params.HttpParams getOverrideParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.impl.client.ClientParamsStack.staticClass, "getOverrideParams", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.impl.client.ClientParamsStack._m7) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ClientParamsStack(org.apache.http.@params.HttpParams arg0, org.apache.http.@params.HttpParams arg1, org.apache.http.@params.HttpParams arg2, org.apache.http.@params.HttpParams arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.ClientParamsStack._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.ClientParamsStack._m8 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ClientParamsStack(org.apache.http.impl.client.ClientParamsStack arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.ClientParamsStack._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.ClientParamsStack._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ClientParamsStack(org.apache.http.impl.client.ClientParamsStack arg0, org.apache.http.@params.HttpParams arg1, org.apache.http.@params.HttpParams arg2, org.apache.http.@params.HttpParams arg3, org.apache.http.@params.HttpParams arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.ClientParamsStack._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.ClientParamsStack._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.ClientParamsStack.staticClass, "<init>", "(Lorg/apache/http/impl/client/ClientParamsStack;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.ClientParamsStack.staticClass, global::org.apache.http.impl.client.ClientParamsStack._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		static ClientParamsStack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.ClientParamsStack.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/ClientParamsStack"));
		}
		internal static void InitJNI()
		{
		}
	}
}
