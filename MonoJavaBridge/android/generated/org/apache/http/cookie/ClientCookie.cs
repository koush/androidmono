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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getAttribute32368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getAttribute32368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _containsAttribute32369;
		bool org.apache.http.cookie.ClientCookie.containsAttribute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._containsAttribute32369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._containsAttribute32369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32370;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getName32370)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getName32370)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32371;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getValue32371)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getValue32371)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32372;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getPath32372)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getPath32372)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32373;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getComment32373)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getComment32373)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32374;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getVersion32374);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getVersion32374);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32375;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getDomain32375)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getDomain32375)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32376;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isPersistent32376);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isPersistent32376);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32377;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isSecure32377);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isSecure32377);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32378;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getCommentURL32378)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getCommentURL32378)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32379;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getExpiryDate32379)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getExpiryDate32379)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32380;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getPorts32380)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getPorts32380)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32381;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isExpired32381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isExpired32381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ClientCookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.ClientCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/ClientCookie"));
			global::org.apache.http.cookie.ClientCookie_._getAttribute32368 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._containsAttribute32369 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "containsAttribute", "(Ljava/lang/String;)Z");
			global::org.apache.http.cookie.ClientCookie_._getName32370 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getValue32371 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getPath32372 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getComment32373 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getVersion32374 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.ClientCookie_._getDomain32375 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._isPersistent32376 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.ClientCookie_._isSecure32377 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.ClientCookie_._getCommentURL32378 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getExpiryDate32379 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.ClientCookie_._getPorts32380 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.ClientCookie_._isExpired32381 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
