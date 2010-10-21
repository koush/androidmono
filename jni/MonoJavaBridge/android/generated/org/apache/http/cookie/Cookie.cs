namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.Cookie_))]
	public interface Cookie  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class Cookie_ : java.lang.Object, Cookie
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Cookie_()
		{
			InitJNI();
		}
		internal Cookie_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getName32273;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getName32273)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getName32273)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32274;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getValue32274)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getValue32274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32275;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getPath32275)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getPath32275)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32276;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getComment32276)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getComment32276)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32277;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getVersion32277);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getVersion32277);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32278;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getDomain32278)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getDomain32278)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32279;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isPersistent32279);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isPersistent32279);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32280;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isSecure32280);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isSecure32280);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32281;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getCommentURL32281)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getCommentURL32281)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32282;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getExpiryDate32282)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getExpiryDate32282)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32283;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getPorts32283)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getPorts32283)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32284;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isExpired32284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isExpired32284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.Cookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/Cookie"));
			global::org.apache.http.cookie.Cookie_._getName32273 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getValue32274 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getPath32275 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getComment32276 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getVersion32277 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.Cookie_._getDomain32278 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._isPersistent32279 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.Cookie_._isSecure32280 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.Cookie_._getCommentURL32281 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getExpiryDate32282 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.Cookie_._getPorts32283 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.Cookie_._isExpired32284 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
