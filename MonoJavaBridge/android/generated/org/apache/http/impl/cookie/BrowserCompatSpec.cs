namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BrowserCompatSpec : org.apache.http.impl.cookie.CookieSpecBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BrowserCompatSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33278;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec._parse33278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpec._parse33278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33279;
		public override int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec._getVersion33279);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpec._getVersion33279);
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33280;
		public override global::java.util.List formatCookies(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec._formatCookies33280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpec._formatCookies33280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33281;
		public override global::org.apache.http.Header getVersionHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec._getVersionHeader33281)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpec._getVersionHeader33281)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _BrowserCompatSpec33282;
		public BrowserCompatSpec(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpec._BrowserCompatSpec33282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BrowserCompatSpec33283;
		public BrowserCompatSpec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, global::org.apache.http.impl.cookie.BrowserCompatSpec._BrowserCompatSpec33283);
			Init(@__env, handle);
		}
		static BrowserCompatSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BrowserCompatSpec"));
			global::org.apache.http.impl.cookie.BrowserCompatSpec._parse33278 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.BrowserCompatSpec._getVersion33279 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.BrowserCompatSpec._formatCookies33280 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.BrowserCompatSpec._getVersionHeader33281 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.BrowserCompatSpec._BrowserCompatSpec33282 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.BrowserCompatSpec._BrowserCompatSpec33283 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BrowserCompatSpec.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
