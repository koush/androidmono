namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.Cookie_))]
	public partial interface Cookie  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getName();
		global::java.lang.String getValue();
		global::java.lang.String getPath();
		global::java.lang.String getComment();
		int getVersion();
		global::java.lang.String getDomain();
		bool isPersistent();
		bool isSecure();
		global::java.lang.String getCommentURL();
		global::java.util.Date getExpiryDate();
		int[] getPorts();
		bool isExpired(java.util.Date arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.Cookie))]
	internal sealed partial class Cookie_ : java.lang.Object, Cookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Cookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName32392;
		global::java.lang.String org.apache.http.cookie.Cookie.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getName32392)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getName32392)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32393;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getValue32393)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getValue32393)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32394;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getPath32394)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getPath32394)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32395;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getComment32395)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getComment32395)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32396;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getVersion32396);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getVersion32396);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32397;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getDomain32397)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getDomain32397)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32398;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isPersistent32398);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isPersistent32398);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32399;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isSecure32399);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isSecure32399);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32400;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getCommentURL32400)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getCommentURL32400)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32401;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getExpiryDate32401)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getExpiryDate32401)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32402;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getPorts32402)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getPorts32402)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32403;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isExpired32403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isExpired32403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Cookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.Cookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/Cookie"));
			global::org.apache.http.cookie.Cookie_._getName32392 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getValue32393 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getPath32394 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getComment32395 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getVersion32396 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.Cookie_._getDomain32397 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._isPersistent32398 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.Cookie_._isSecure32399 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.Cookie_._getCommentURL32400 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getExpiryDate32401 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.Cookie_._getPorts32402 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.Cookie_._isExpired32403 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
		internal static void InitJNI()
		{
		}
	}
}
