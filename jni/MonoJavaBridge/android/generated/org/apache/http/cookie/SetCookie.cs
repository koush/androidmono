namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SetCookie_))]
	public interface SetCookie : Cookie
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
	public sealed partial class SetCookie_ : java.lang.Object, SetCookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SetCookie_()
		{
			InitJNI();
		}
		internal SetCookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setValue25706;
		 void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setValue25706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setValue25706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment25707;
		 void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setComment25707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setComment25707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion25708;
		 void org.apache.http.cookie.SetCookie.setVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setVersion25708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setVersion25708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath25709;
		 void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setPath25709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setPath25709, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate25710;
		 void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setExpiryDate25710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setExpiryDate25710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain25711;
		 void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setDomain25711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setDomain25711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure25712;
		 void org.apache.http.cookie.SetCookie.setSecure(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._setSecure25712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._setSecure25712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName25713;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getName25713)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getName25713)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue25714;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getValue25714)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getValue25714)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath25715;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getPath25715)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getPath25715)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment25716;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getComment25716)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getComment25716)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion25717;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getVersion25717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getVersion25717);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain25718;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getDomain25718)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getDomain25718)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent25719;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isPersistent25719);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isPersistent25719);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25720;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isSecure25720);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isSecure25720);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL25721;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getCommentURL25721)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getCommentURL25721)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate25722;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getExpiryDate25722)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getExpiryDate25722)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts25723;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._getPorts25723)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._getPorts25723)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired25724;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_._isExpired25724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie_.staticClass, global::org.apache.http.cookie.SetCookie_._isExpired25724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie"));
			global::org.apache.http.cookie.SetCookie_._setValue25706 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setComment25707 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setVersion25708 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie_._setPath25709 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setExpiryDate25710 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie_._setDomain25711 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie_._setSecure25712 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie_._getName25713 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getValue25714 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getPath25715 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getComment25716 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getVersion25717 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie_._getDomain25718 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._isPersistent25719 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie_._isSecure25720 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie_._getCommentURL25721 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie_._getExpiryDate25722 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie_._getPorts25723 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie_._isExpired25724 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
