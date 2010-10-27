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
		static SetCookie2_()
		{
			InitJNI();
		}
		internal SetCookie2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCommentURL32458;
		void org.apache.http.cookie.SetCookie2.setCommentURL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setCommentURL32458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setCommentURL32458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPorts32459;
		void org.apache.http.cookie.SetCookie2.setPorts(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPorts32459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setPorts32459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDiscard32460;
		void org.apache.http.cookie.SetCookie2.setDiscard(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDiscard32460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setDiscard32460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValue32461;
		void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setValue32461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setValue32461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment32462;
		void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setComment32462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setComment32462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion32463;
		void org.apache.http.cookie.SetCookie.setVersion(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setVersion32463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setVersion32463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath32464;
		void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPath32464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setPath32464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate32465;
		void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setExpiryDate32465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setExpiryDate32465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain32466;
		void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDomain32466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setDomain32466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure32467;
		void org.apache.http.cookie.SetCookie.setSecure(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setSecure32467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setSecure32467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32468;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getName32468)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getName32468)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32469;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getValue32469)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getValue32469)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32470;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPath32470)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getPath32470)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32471;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getComment32471)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getComment32471)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32472;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getVersion32472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getVersion32472);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32473;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getDomain32473)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getDomain32473)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32474;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isPersistent32474);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isPersistent32474);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32475;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isSecure32475);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isSecure32475);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32476;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getCommentURL32476)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getCommentURL32476)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32477;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getExpiryDate32477)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getExpiryDate32477)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32478;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPorts32478)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getPorts32478)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32479;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isExpired32479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isExpired32479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie2"));
			global::org.apache.http.cookie.SetCookie2_._setCommentURL32458 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setCommentURL", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setPorts32459 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPorts", "([I)V");
			global::org.apache.http.cookie.SetCookie2_._setDiscard32460 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDiscard", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._setValue32461 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setComment32462 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setVersion32463 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie2_._setPath32464 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setExpiryDate32465 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie2_._setDomain32466 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setSecure32467 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._getName32468 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getValue32469 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getPath32470 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getComment32471 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getVersion32472 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie2_._getDomain32473 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._isPersistent32474 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie2_._isSecure32475 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie2_._getCommentURL32476 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getExpiryDate32477 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie2_._getPorts32478 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie2_._isExpired32479 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
