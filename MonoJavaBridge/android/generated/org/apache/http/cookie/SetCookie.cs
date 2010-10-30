namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SetCookie_))]
	public partial interface SetCookie : Cookie
	{
		void setValue(java.lang.String arg0);
		void setComment(java.lang.String arg0);
		void setVersion(int arg0);
		void setPath(java.lang.String arg0);
		void setExpiryDate(java.util.Date arg0);
		void setDomain(java.lang.String arg0);
		void setSecure(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SetCookie))]
	internal sealed partial class SetCookie_ : java.lang.Object, SetCookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SetCookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setValue32440;
		void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setValue", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._setValue32440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment32441;
		void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setComment", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._setComment32441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion32442;
		void org.apache.http.cookie.SetCookie.setVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setVersion", "(I)V", ref global::org.apache.http.cookie.SetCookie_._setVersion32442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath32443;
		void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setPath", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._setPath32443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate32444;
		void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V", ref global::org.apache.http.cookie.SetCookie_._setExpiryDate32444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain32445;
		void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setDomain", "(Ljava/lang/String;)V", ref global::org.apache.http.cookie.SetCookie_._setDomain32445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure32446;
		void org.apache.http.cookie.SetCookie.setSecure(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "setSecure", "(Z)V", ref global::org.apache.http.cookie.SetCookie_._setSecure32446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32447;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._getName32447) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32448;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._getValue32448) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32449;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._getPath32449) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32450;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._getComment32450) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32451;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.SetCookie_._getVersion32451);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32452;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._getDomain32452) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32453;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "isPersistent", "()Z", ref global::org.apache.http.cookie.SetCookie_._isPersistent32453);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32454;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.SetCookie_._isSecure32454);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32455;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.cookie.SetCookie_._getCommentURL32455) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32456;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.cookie.SetCookie_._getExpiryDate32456) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32457;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.cookie.SetCookie_.staticClass, "getPorts", "()[I", ref global::org.apache.http.cookie.SetCookie_._getPorts32457) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32458;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.SetCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.cookie.SetCookie_._isExpired32458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SetCookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie"));
		}
		internal static void InitJNI()
		{
		}
	}
}
