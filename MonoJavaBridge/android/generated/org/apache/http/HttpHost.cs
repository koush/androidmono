namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HttpHost : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.HttpHost.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::org.apache.http.HttpHost._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HttpHost.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.HttpHost._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpHost.staticClass, "hashCode", "()I", ref global::org.apache.http.HttpHost._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.HttpHost.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.HttpHost._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String toURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HttpHost.staticClass, "toURI", "()Ljava/lang/String;", ref global::org.apache.http.HttpHost._m4) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.HttpHost.staticClass, "getPort", "()I", ref global::org.apache.http.HttpHost._m5);
		}
		public new global::java.lang.String HostName
		{
			get
			{
				return getHostName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getHostName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HttpHost.staticClass, "getHostName", "()Ljava/lang/String;", ref global::org.apache.http.HttpHost._m6) as java.lang.String;
		}
		public new global::java.lang.String SchemeName
		{
			get
			{
				return getSchemeName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HttpHost.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.HttpHost._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.String toHostString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.HttpHost.staticClass, "toHostString", "()Ljava/lang/String;", ref global::org.apache.http.HttpHost._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public HttpHost(org.apache.http.HttpHost arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Lorg/apache/http/HttpHost;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public HttpHost(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._m10 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public HttpHost(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public HttpHost(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpHost._m12.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpHost._m12 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpHost.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpHost.staticClass, global::org.apache.http.HttpHost._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static global::java.lang.String DEFAULT_SCHEME_NAME
		{
			get
			{
				return "http";
			}
		}
		static HttpHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpHost"));
		}
		internal static void InitJNI()
		{
		}
	}
}
