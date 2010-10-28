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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setValue32440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setValue32440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment32441;
		void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setComment32441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setComment32441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion32442;
		void org.apache.http.cookie.SetCookie.setVersion(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setVersion32442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setVersion32442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath32443;
		void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setPath32443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setPath32443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate32444;
		void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setExpiryDate32444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setExpiryDate32444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain32445;
		void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setDomain32445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setDomain32445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure32446;
		void org.apache.http.cookie.SetCookie.setSecure(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setSecure32446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setSecure32446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32447;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getName32447)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getName32447)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32448;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getValue32448)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getValue32448)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32449;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getPath32449)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getPath32449)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32450;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getComment32450)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getComment32450)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32451;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getVersion32451);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getVersion32451);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32452;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getDomain32452)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getDomain32452)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32453;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isPersistent32453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isPersistent32453);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32454;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isSecure32454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isSecure32454);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32455;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getCommentURL32455)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getCommentURL32455)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32456;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getExpiryDate32456)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getExpiryDate32456)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32457;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getPorts32457)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getPorts32457)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32458;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isExpired32458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isExpired32458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SetCookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie"));
			global::org.apache.http.cookie.SetCookie_._setValue32440 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setComment32441 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setVersion32442 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie_._setPath32443 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setExpiryDate32444 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie_._setDomain32445 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setSecure32446 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie_._getName32447 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getValue32448 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getPath32449 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getComment32450 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getVersion32451 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie_._getDomain32452 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._isPersistent32453 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie_._isSecure32454 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie_._getCommentURL32455 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getExpiryDate32456 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie_._getPorts32457 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie_._isExpired32458 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
