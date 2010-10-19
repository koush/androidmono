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
		internal static global::MonoJavaBridge.MethodId _getName25662;
		 global::java.lang.String org.apache.http.cookie.Cookie.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getName25662)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getName25662)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue25663;
		 global::java.lang.String org.apache.http.cookie.Cookie.getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getValue25663)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getValue25663)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath25664;
		 global::java.lang.String org.apache.http.cookie.Cookie.getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getPath25664)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getPath25664)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment25665;
		 global::java.lang.String org.apache.http.cookie.Cookie.getComment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getComment25665)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getComment25665)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion25666;
		 int org.apache.http.cookie.Cookie.getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getVersion25666);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getVersion25666);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain25667;
		 global::java.lang.String org.apache.http.cookie.Cookie.getDomain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getDomain25667)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getDomain25667)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent25668;
		 bool org.apache.http.cookie.Cookie.isPersistent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isPersistent25668);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isPersistent25668);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25669;
		 bool org.apache.http.cookie.Cookie.isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isSecure25669);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isSecure25669);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL25670;
		 global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getCommentURL25670)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getCommentURL25670)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate25671;
		 global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getExpiryDate25671)) as java.util.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getExpiryDate25671)) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts25672;
		 int[] org.apache.http.cookie.Cookie.getPorts() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._getPorts25672)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._getPorts25672)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired25673;
		 bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_._isExpired25673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.Cookie_.staticClass, global::org.apache.http.cookie.Cookie_._isExpired25673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.Cookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/Cookie"));
			global::org.apache.http.cookie.Cookie_._getName25662 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getName", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getValue25663 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getValue", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getPath25664 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getComment25665 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getComment", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getVersion25666 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getVersion", "()I");
			global::org.apache.http.cookie.Cookie_._getDomain25667 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getDomain", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._isPersistent25668 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isPersistent", "()Z");
			global::org.apache.http.cookie.Cookie_._isSecure25669 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.Cookie_._getCommentURL25670 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getCommentURL", "()Ljava/lang/String;");
			global::org.apache.http.cookie.Cookie_._getExpiryDate25671 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;");
			global::org.apache.http.cookie.Cookie_._getPorts25672 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "getPorts", "()[I");
			global::org.apache.http.cookie.Cookie_._isExpired25673 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.Cookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z");
		}
	}
}
