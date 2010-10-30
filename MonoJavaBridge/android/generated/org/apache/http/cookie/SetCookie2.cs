namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SetCookie2_))]
	public partial interface SetCookie2 : SetCookie
	{
		void setCommentURL(java.lang.String arg0);
		void setPorts(int[] arg0);
		void setDiscard(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SetCookie2))]
	internal sealed partial class SetCookie2_ : java.lang.Object, SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SetCookie2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCommentURL32459;
		void org.apache.http.cookie.SetCookie2.setCommentURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setCommentURL32459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPorts32460;
		void org.apache.http.cookie.SetCookie2.setPorts(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPorts32460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDiscard32461;
		void org.apache.http.cookie.SetCookie2.setDiscard(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDiscard32461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValue32462;
		void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setValue32462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment32463;
		void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setComment32463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion32464;
		void org.apache.http.cookie.SetCookie.setVersion(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setVersion32464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath32465;
		void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPath32465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate32466;
		void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setExpiryDate32466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain32467;
		void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDomain32467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure32468;
		void org.apache.http.cookie.SetCookie.setSecure(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setSecure32468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32469;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getName32469)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32470;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getValue32470)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32471;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPath32471)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32472;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getComment32472)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32473;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getVersion32473);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32474;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getDomain32474)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32475;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isPersistent32475);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32476;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isSecure32476);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32477;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getCommentURL32477)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32478;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getExpiryDate32478)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32479;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPorts32479)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32480;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isExpired32480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SetCookie2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie2"));
			global::org.apache.http.cookie.SetCookie2_._setCommentURL32459 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setCommentURL", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setPorts32460 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPorts", "([I)V");
			global::org.apache.http.cookie.SetCookie2_._setDiscard32461 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDiscard", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._setValue32462 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setComment32463 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setVersion32464 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie2_._setPath32465 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setExpiryDate32466 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie2_._setDomain32467 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setSecure32468 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._getName32469 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getValue32470 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getPath32471 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getComment32472 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getVersion32473 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie2_._getDomain32474 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._isPersistent32475 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie2_._isSecure32476 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie2_._getCommentURL32477 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getExpiryDate32478 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie2_._getPorts32479 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie2_._isExpired32480 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
