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
		internal static global::MonoJavaBridge.MethodId _getAttribute32368;
		global::java.lang.String org.apache.http.cookie.ClientCookie.getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getAttribute32368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _containsAttribute32369;
		bool org.apache.http.cookie.ClientCookie.containsAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "containsAttribute", "(Ljava/lang/String;)Z", ref global::org.apache.http.cookie.ClientCookie_._containsAttribute32369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32370;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getName32370) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32371;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getValue32371) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32372;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getPath32372) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32373;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getComment32373) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32374;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.ClientCookie_._getVersion32374);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32375;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getDomain32375) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32376;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "isPersistent", "()Z", ref global::org.apache.http.cookie.ClientCookie_._isPersistent32376);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32377;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.ClientCookie_._isSecure32377);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32378;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.cookie.ClientCookie_._getCommentURL32378) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32379;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.cookie.ClientCookie_._getExpiryDate32379) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32380;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "getPorts", "()[I", ref global::org.apache.http.cookie.ClientCookie_._getPorts32380) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32381;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.ClientCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.cookie.ClientCookie_._isExpired32381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
