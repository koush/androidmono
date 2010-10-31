namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DefaultedHttpParams : org.apache.http.@params.AbstractHttpParams
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DefaultedHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::org.apache.http.@params.HttpParams copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.DefaultedHttpParams.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.DefaultedHttpParams._m0) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.DefaultedHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.DefaultedHttpParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.DefaultedHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.@params.DefaultedHttpParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override bool removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.DefaultedHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.DefaultedHttpParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.@params.HttpParams Defaults
		{
			get
			{
				return getDefaults();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::org.apache.http.@params.HttpParams getDefaults()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.DefaultedHttpParams.staticClass, "getDefaults", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.DefaultedHttpParams._m4) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public DefaultedHttpParams(org.apache.http.@params.HttpParams arg0, org.apache.http.@params.HttpParams arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.DefaultedHttpParams._m5.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.DefaultedHttpParams._m5 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.DefaultedHttpParams.staticClass, "<init>", "(Lorg/apache/http/params/HttpParams;Lorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.DefaultedHttpParams.staticClass, global::org.apache.http.@params.DefaultedHttpParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DefaultedHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.DefaultedHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/DefaultedHttpParams"));
		}
	}
}
