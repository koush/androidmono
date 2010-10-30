namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.CookieSpec_))]
	public partial interface CookieSpec  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1);
		bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		int getVersion();
		void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		global::java.util.List formatCookies(java.util.List arg0);
		global::org.apache.http.Header getVersionHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.CookieSpec))]
	internal sealed partial class CookieSpec_ : java.lang.Object, CookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse32419;
		global::java.util.List org.apache.http.cookie.CookieSpec.parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._parse32419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match32420;
		bool org.apache.http.cookie.CookieSpec.match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._match32420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32421;
		int org.apache.http.cookie.CookieSpec.getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._getVersion32421);
		}
		internal static global::MonoJavaBridge.MethodId _validate32422;
		void org.apache.http.cookie.CookieSpec.validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._validate32422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies32423;
		global::java.util.List org.apache.http.cookie.CookieSpec.formatCookies(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._formatCookies32423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader32424;
		global::org.apache.http.Header org.apache.http.cookie.CookieSpec.getVersionHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._getVersionHeader32424)) as org.apache.http.Header;
		}
		static CookieSpec_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpec"));
			global::org.apache.http.cookie.CookieSpec_._parse32419 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.cookie.CookieSpec_._match32420 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.cookie.CookieSpec_._getVersion32421 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.CookieSpec_._validate32422 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.cookie.CookieSpec_._formatCookies32423 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.cookie.CookieSpec_._getVersionHeader32424 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
		}
		internal static void InitJNI()
		{
		}
	}
}
