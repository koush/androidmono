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
	public sealed partial class SetCookie2_ : java.lang.Object, SetCookie2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SetCookie2_()
		{
			InitJNI();
		}
		internal SetCookie2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setCommentURL32340;
		 void org.apache.http.cookie.SetCookie2.setCommentURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setCommentURL32340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setCommentURL32340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPorts32341;
		 void org.apache.http.cookie.SetCookie2.setPorts(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPorts32341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setPorts32341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDiscard32342;
		 void org.apache.http.cookie.SetCookie2.setDiscard(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDiscard32342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setDiscard32342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValue32343;
		 void org.apache.http.cookie.SetCookie.setValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setValue32343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setValue32343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment32344;
		 void org.apache.http.cookie.SetCookie.setComment(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setComment32344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setComment32344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVersion32345;
		 void org.apache.http.cookie.SetCookie.setVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setVersion32345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setVersion32345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPath32346;
		 void org.apache.http.cookie.SetCookie.setPath(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setPath32346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setPath32346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpiryDate32347;
		 void org.apache.http.cookie.SetCookie.setExpiryDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setExpiryDate32347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setExpiryDate32347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDomain32348;
		 void org.apache.http.cookie.SetCookie.setDomain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setDomain32348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setDomain32348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecure32349;
		 void org.apache.http.cookie.SetCookie.setSecure(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._setSecure32349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._setSecure32349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName32350;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getName32350)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getName32350)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32351;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getValue32351)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getValue32351)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32352;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPath32352)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getPath32352)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32353;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getComment32353)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getComment32353)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32354;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getVersion32354);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getVersion32354);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32355;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getDomain32355)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getDomain32355)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32356;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isPersistent32356);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isPersistent32356);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32357;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isSecure32357);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isSecure32357);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32358;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getCommentURL32358)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getCommentURL32358)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32359;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getExpiryDate32359)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getExpiryDate32359)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32360;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._getPorts32360)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._getPorts32360)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32361;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_._isExpired32361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.SetCookie2_.staticClass, global::org.apache.http.cookie.SetCookie2_._isExpired32361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SetCookie2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SetCookie2"));
			global::org.apache.http.cookie.SetCookie2_._setCommentURL32340 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setCommentURL", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setPorts32341 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPorts", "([I)V");
			global::org.apache.http.cookie.SetCookie2_._setDiscard32342 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDiscard", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._setValue32343 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setValue", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setComment32344 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setVersion32345 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setVersion", "(I)V");
			global::org.apache.http.cookie.SetCookie2_._setPath32346 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setPath", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setExpiryDate32347 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setExpiryDate", "(Ljava/util/Date;)V");
			global::org.apache.http.cookie.SetCookie2_._setDomain32348 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setDomain", "(Ljava/lang/String;)V");
			global::org.apache.http.cookie.SetCookie2_._setSecure32349 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "setSecure", "(Z)V");
			global::org.apache.http.cookie.SetCookie2_._getName32350 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getValue32351 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getPath32352 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getComment32353 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getVersion32354 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.SetCookie2_._getDomain32355 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._isPersistent32356 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.SetCookie2_._isSecure32357 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.SetCookie2_._getCommentURL32358 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.SetCookie2_._getExpiryDate32359 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.SetCookie2_._getPorts32360 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.SetCookie2_._isExpired32361 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.SetCookie2_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
