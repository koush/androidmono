namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetscapeDraftSpec : org.apache.http.impl.cookie.CookieSpecBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NetscapeDraftSpec()
		{
			InitJNI();
		}
		protected NetscapeDraftSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse26567;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec._parse26567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._parse26567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion26568;
		public override int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersion26568);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersion26568);
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies26569;
		public override global::java.util.List formatCookies(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec._formatCookies26569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._formatCookies26569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader26570;
		public override global::org.apache.http.Header getVersionHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersionHeader26570)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersionHeader26570)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftSpec26571;
		public NetscapeDraftSpec(java.lang.String[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec26571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NetscapeDraftSpec26572;
		public NetscapeDraftSpec()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec26572);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/NetscapeDraftSpec"));
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._parse26567 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersion26568 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._formatCookies26569 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._getVersionHeader26570 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec26571 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.NetscapeDraftSpec._NetscapeDraftSpec26572 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.NetscapeDraftSpec.staticClass, "<init>", "()V");
		}
	}
}
