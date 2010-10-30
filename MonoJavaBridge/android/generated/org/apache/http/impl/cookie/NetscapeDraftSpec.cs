namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDraftSpec : org.apache.http.impl.cookie.CookieSpecBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetscapeDraftSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33313;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._parse33313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33314;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersion33314);
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33315;
		public override global::java.util.List formatCookies(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._formatCookies33315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33316;
		public override global::org.apache.http.Header getVersionHeader()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersionHeader33316)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftSpec33317;
		public NetscapeDraftSpec(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec33317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftSpec33318;
		public NetscapeDraftSpec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec33318);
			Init(@__env, handle);
		}
		static NetscapeDraftSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDraftSpec"));
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._parse33313 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersion33314 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._formatCookies33315 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersionHeader33316 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec33317 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec33318 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
