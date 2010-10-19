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
		internal static global::MonoJavaBridge.MethodId _getAttribute25648;
		 global::java.lang.String org.apache.http.cookie.ClientCookie.getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getAttribute25648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getAttribute25648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _containsAttribute25649;
		 bool org.apache.http.cookie.ClientCookie.containsAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._containsAttribute25649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._containsAttribute25649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName25650;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getName25650)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getName25650)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue25651;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getValue25651)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getValue25651)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath25652;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getPath25652)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getPath25652)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment25653;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getComment25653)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getComment25653)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion25654;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getVersion25654);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getVersion25654);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain25655;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getDomain25655)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getDomain25655)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent25656;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isPersistent25656);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isPersistent25656);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25657;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isSecure25657);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isSecure25657);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL25658;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getCommentURL25658)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getCommentURL25658)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate25659;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getExpiryDate25659)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getExpiryDate25659)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts25660;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._getPorts25660)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._getPorts25660)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired25661;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_._isExpired25661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.ClientCookie_.staticClass, global::org.apache.http.cookie.ClientCookie_._isExpired25661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.ClientCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/ClientCookie"));
			global::org.apache.http.cookie.ClientCookie_._getAttribute25648 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._containsAttribute25649 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "containsAttribute", "(Ljava/lang/String;)Z");
			global::org.apache.http.cookie.ClientCookie_._getName25650 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getValue25651 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getPath25652 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getComment25653 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getVersion25654 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.ClientCookie_._getDomain25655 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._isPersistent25656 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.ClientCookie_._isSecure25657 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.ClientCookie_._getCommentURL25658 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.ClientCookie_._getExpiryDate25659 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.ClientCookie_._getPorts25660 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.ClientCookie_._isExpired25661 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.ClientCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
