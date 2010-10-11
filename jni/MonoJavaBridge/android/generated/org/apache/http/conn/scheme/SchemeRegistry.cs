namespace org.apache.http.conn.scheme
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SchemeRegistry : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SchemeRegistry()
		{
			InitJNI();
		}
		internal SchemeRegistry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get16409;
		public global::org.apache.http.conn.scheme.Scheme get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._get16409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._get16409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _register16410;
		public global::org.apache.http.conn.scheme.Scheme register(org.apache.http.conn.scheme.Scheme arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._register16410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._register16410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme16411;
		public global::org.apache.http.conn.scheme.Scheme getScheme(org.apache.http.HttpHost arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme16411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme16411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _getScheme16412;
		public global::org.apache.http.conn.scheme.Scheme getScheme(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getScheme16412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _setItems16413;
		public void setItems(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._setItems16413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._setItems16413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregister16414;
		public global::org.apache.http.conn.scheme.Scheme unregister(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._unregister16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._unregister16414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.conn.scheme.Scheme;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeNames16415;
		public global::java.util.List getSchemeNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames16415)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames16415)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _SchemeRegistry16416;
		public SchemeRegistry()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.scheme.SchemeRegistry.staticClass, global::org.apache.http.conn.scheme.SchemeRegistry._SchemeRegistry16416);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.scheme.SchemeRegistry.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/scheme/SchemeRegistry"));
			global::org.apache.http.conn.scheme.SchemeRegistry._get16409 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "get", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._register16410 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "register", "(Lorg/apache/http/conn/scheme/Scheme;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getScheme16411 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Lorg/apache/http/HttpHost;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getScheme16412 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getScheme", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._setItems16413 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "setItems", "(Ljava/util/Map;)V");
			global::org.apache.http.conn.scheme.SchemeRegistry._unregister16414 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "unregister", "(Ljava/lang/String;)Lorg/apache/http/conn/scheme/Scheme;");
			global::org.apache.http.conn.scheme.SchemeRegistry._getSchemeNames16415 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "getSchemeNames", "()Ljava/util/List;");
			global::org.apache.http.conn.scheme.SchemeRegistry._SchemeRegistry16416 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.scheme.SchemeRegistry.staticClass, "<init>", "()V");
		}
	}
}
