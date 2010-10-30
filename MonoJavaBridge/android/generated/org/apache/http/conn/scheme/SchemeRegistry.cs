namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SchemeRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SchemeRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::org.apache.http.conn.scheme.Scheme get(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.Scheme>(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "get", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", ref global::org.apache.http.conn.scheme.SchemeRegistry._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.scheme.Scheme;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::org.apache.http.conn.scheme.Scheme register(org.apache.http.conn.scheme.Scheme arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.Scheme>(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "register", "(Lorg/apache/http/conn/scheme/Scheme;)Lorg/apache/http/conn/scheme/Scheme;", ref global::org.apache.http.conn.scheme.SchemeRegistry._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.scheme.Scheme;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::org.apache.http.conn.scheme.Scheme getScheme(org.apache.http.HttpHost arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.Scheme>(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Lorg/apache/http/HttpHost;)Lorg/apache/http/conn/scheme/Scheme;", ref global::org.apache.http.conn.scheme.SchemeRegistry._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.scheme.Scheme;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::org.apache.http.conn.scheme.Scheme getScheme(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.Scheme>(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", ref global::org.apache.http.conn.scheme.SchemeRegistry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.scheme.Scheme;
		}
		public new global::java.util.Map Items
		{
			set
			{
				setItems(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void setItems(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V", ref global::org.apache.http.conn.scheme.SchemeRegistry._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::org.apache.http.conn.scheme.Scheme unregister(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.conn.scheme.Scheme>(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;", ref global::org.apache.http.conn.scheme.SchemeRegistry._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.conn.scheme.Scheme;
		}
		public new global::java.util.List SchemeNames
		{
			get
			{
				return getSchemeNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.util.List getSchemeNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;", ref global::org.apache.http.conn.scheme.SchemeRegistry._m6) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SchemeRegistry() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.conn.scheme.SchemeRegistry._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.conn.scheme.SchemeRegistry._m7 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._m7);
			Init(@__env, handle);
		}
		static SchemeRegistry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.SchemeRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/SchemeRegistry"));
		}
		internal static void InitJNI()
		{
		}
	}
}
