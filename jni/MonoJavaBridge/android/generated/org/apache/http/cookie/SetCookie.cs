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
		static SetCookie_()
		{
			InitJNI();
		}
		internal SetCookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setValue32439;
		 void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setValue32439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setValue32439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment32440;
		 void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setComment32440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setComment32440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion32441;
		 void org.apache.http.cookie.SetCookie.setVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setVersion32441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setVersion32441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath32442;
		 void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setPath32442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setPath32442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate32443;
		 void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setExpiryDate32443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setExpiryDate32443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain32444;
		 void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setDomain32444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setDomain32444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure32445;
		 void org.apache.http.cookie.SetCookie.setSecure(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setSecure32445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setSecure32445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32446;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getName32446)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getName32446)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32447;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getValue32447)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getValue32447)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32448;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getPath32448)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getPath32448)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32449;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getComment32449)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getComment32449)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32450;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getVersion32450);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getVersion32450);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32451;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getDomain32451)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getDomain32451)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32452;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isPersistent32452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isPersistent32452);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32453;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isSecure32453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isSecure32453);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32454;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getCommentURL32454)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getCommentURL32454)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32455;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getExpiryDate32455)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getExpiryDate32455)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32456;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getPorts32456)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getPorts32456)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32457;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isExpired32457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isExpired32457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie"));
			global::org.apache.http.cookie.SetCookie_._setValue32439 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setComment32440 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setVersion32441 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie_._setPath32442 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setExpiryDate32443 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie_._setDomain32444 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setSecure32445 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie_._getName32446 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getValue32447 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getPath32448 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getComment32449 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getVersion32450 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie_._getDomain32451 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._isPersistent32452 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie_._isSecure32453 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie_._getCommentURL32454 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getExpiryDate32455 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie_._getPorts32456 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie_._isExpired32457 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
