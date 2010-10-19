namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.CookieSpec_))]
	public interface CookieSpec  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1);
		bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		int getVersion();
		void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		global::java.util.List formatCookies(java.util.List arg0);
		global::org.apache.http.Header getVersionHeader();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.CookieSpec))]
	public sealed partial class CookieSpec_ : java.lang.Object, CookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieSpec_()
		{
			InitJNI();
		}
		internal CookieSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse25689;
		 global::java.util.List org.apache.http.cookie.CookieSpec.parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._parse25689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_.staticClass, global::org.apache.http.cookie.CookieSpec_._parse25689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match25690;
		 bool org.apache.http.cookie.CookieSpec.match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._match25690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_.staticClass, global::org.apache.http.cookie.CookieSpec_._match25690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion25691;
		 int org.apache.http.cookie.CookieSpec.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._getVersion25691);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_.staticClass, global::org.apache.http.cookie.CookieSpec_._getVersion25691);
		}
		internal static global::MonoJavaBridge.MethodId _validate25692;
		 void org.apache.http.cookie.CookieSpec.validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._validate25692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_.staticClass, global::org.apache.http.cookie.CookieSpec_._validate25692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies25693;
		 global::java.util.List org.apache.http.cookie.CookieSpec.formatCookies(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._formatCookies25693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_.staticClass, global::org.apache.http.cookie.CookieSpec_._formatCookies25693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader25694;
		 global::org.apache.http.Header org.apache.http.cookie.CookieSpec.getVersionHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_._getVersionHeader25694)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieSpec_.staticClass, global::org.apache.http.cookie.CookieSpec_._getVersionHeader25694)) as org.apache.http.Header;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieSpec"));
			global::org.apache.http.cookie.CookieSpec_._parse25689 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.cookie.CookieSpec_._match25690 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.cookie.CookieSpec_._getVersion25691 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.CookieSpec_._validate25692 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.cookie.CookieSpec_._formatCookies25693 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.cookie.CookieSpec_._getVersionHeader25694 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieSpec_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
		}
	}
}
