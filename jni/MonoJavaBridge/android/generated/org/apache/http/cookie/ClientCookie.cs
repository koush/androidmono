namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.ClientCookie_))]
	public interface ClientCookie : Cookie
	{
		global::java.lang.String getAttribute(java.lang.String arg0);
		bool containsAttribute(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.ClientCookie))]
	public sealed partial class ClientCookie_ : java.lang.Object, ClientCookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ClientCookie_()
		{
			InitJNI();
		}
		internal ClientCookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute32249;
		 global::java.lang.String org.apache.http.cookie.ClientCookie.getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getAttribute32249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getAttribute32249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _containsAttribute32250;
		 bool org.apache.http.cookie.ClientCookie.containsAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._containsAttribute32250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._containsAttribute32250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32251;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getName32251)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getName32251)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32252;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getValue32252)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getValue32252)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32253;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getPath32253)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getPath32253)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32254;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getComment32254)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getComment32254)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32255;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getVersion32255);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getVersion32255);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32256;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getDomain32256)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getDomain32256)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32257;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isPersistent32257);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isPersistent32257);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32258;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isSecure32258);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isSecure32258);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32259;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getCommentURL32259)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getCommentURL32259)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32260;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getExpiryDate32260)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getExpiryDate32260)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32261;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getPorts32261)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getPorts32261)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32262;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isExpired32262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isExpired32262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.ClientCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/ClientCookie"));
			global::org.apache.http.cookie.ClientCookie_._getAttribute32249 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._containsAttribute32250 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "containsAttribute", "(Ljava/lang/String;)Z");
			global::org.apache.http.cookie.ClientCookie_._getName32251 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getValue32252 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getPath32253 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getComment32254 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getVersion32255 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.ClientCookie_._getDomain32256 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._isPersistent32257 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.ClientCookie_._isSecure32258 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.ClientCookie_._getCommentURL32259 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getExpiryDate32260 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.ClientCookie_._getPorts32261 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.ClientCookie_._isExpired32262 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
