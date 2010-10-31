namespace org.apache.http.@params
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpParams : org.apache.http.@params.AbstractHttpParams, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BasicHttpParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.@params.BasicHttpParams._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "clear", "()V", ref global::org.apache.http.@params.BasicHttpParams._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::org.apache.http.@params.HttpParams copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "copy", "()Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.BasicHttpParams._m2) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override global::org.apache.http.@params.HttpParams setParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.@params.HttpParams>(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "setParameter", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/apache/http/params/HttpParams;", ref global::org.apache.http.@params.BasicHttpParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.@params.HttpParams;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public sealed override global::java.lang.Object getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::org.apache.http.@params.BasicHttpParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void setParameters(java.lang.String[] arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "setParameters", "([Ljava/lang/String;Ljava/lang/Object;)V", ref global::org.apache.http.@params.BasicHttpParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public sealed override bool removeParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "removeParameter", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.BasicHttpParams._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool isParameterSet(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "isParameterSet", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.BasicHttpParams._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public bool isParameterSetLocally(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.@params.BasicHttpParams.staticClass, "isParameterSetLocally", "(Ljava/lang/String;)Z", ref global::org.apache.http.@params.BasicHttpParams._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public BasicHttpParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.@params.BasicHttpParams._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.@params.BasicHttpParams._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.@params.BasicHttpParams.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.@params.BasicHttpParams.staticClass, global::org.apache.http.@params.BasicHttpParams._m9);
			Init(@__env, handle);
		}
		static BasicHttpParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.@params.BasicHttpParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/params/BasicHttpParams"));
		}
	}
}
