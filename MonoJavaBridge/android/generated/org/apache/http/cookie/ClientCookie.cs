namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.ClientCookie_))]
	public partial interface ClientCookie : Cookie
	{
		global::java.lang.String getAttribute(java.lang.String arg0);
		bool containsAttribute(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.ClientCookie))]
	internal sealed partial class ClientCookie_ : java.lang.Object, ClientCookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ClientCookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.cookie.ClientCookie.getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool org.apache.http.cookie.ClientCookie.containsAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "containsAttribute", "(Ljava/lang/String;)Z", ref global::org.apache.http.cookie.ClientCookie_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m5) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.ClientCookie_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "isPersistent", "()Z", ref global::org.apache.http.cookie.ClientCookie_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.ClientCookie_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.cookie.ClientCookie_._m11) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getPorts", "()[I", ref global::org.apache.http.cookie.ClientCookie_._m12) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.cookie.ClientCookie_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ClientCookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.ClientCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/ClientCookie"));
		}
		internal static void InitJNI()
		{
		}
	}
}
