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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getName", "()Ljava/lang/String;", ref global::org.apache.http.cookie.Cookie_._getName32392) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue32393;
		global::java.lang.String org.apache.http.cookie.Cookie.getValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getValue", "()Ljava/lang/String;", ref global::org.apache.http.cookie.Cookie_._getValue32393) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPath32394;
		global::java.lang.String org.apache.http.cookie.Cookie.getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.Cookie_._getPath32394) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getComment32395;
		global::java.lang.String org.apache.http.cookie.Cookie.getComment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getComment", "()Ljava/lang/String;", ref global::org.apache.http.cookie.Cookie_._getComment32395) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion32396;
		int org.apache.http.cookie.Cookie.getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.Cookie_.staticClass, "getVersion", "()I", ref global::org.apache.http.cookie.Cookie_._getVersion32396);
		}
		internal static global::MonoJavaBridge.MethodId _getDomain32397;
		global::java.lang.String org.apache.http.cookie.Cookie.getDomain()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getDomain", "()Ljava/lang/String;", ref global::org.apache.http.cookie.Cookie_._getDomain32397) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isPersistent32398;
		bool org.apache.http.cookie.Cookie.isPersistent()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.Cookie_.staticClass, "isPersistent", "()Z", ref global::org.apache.http.cookie.Cookie_._isPersistent32398);
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32399;
		bool org.apache.http.cookie.Cookie.isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.Cookie_.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.Cookie_._isSecure32399);
		}
		internal static global::MonoJavaBridge.MethodId _getCommentURL32400;
		global::java.lang.String org.apache.http.cookie.Cookie.getCommentURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getCommentURL", "()Ljava/lang/String;", ref global::org.apache.http.cookie.Cookie_._getCommentURL32400) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiryDate32401;
		global::java.util.Date org.apache.http.cookie.Cookie.getExpiryDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.cookie.Cookie_.staticClass, "getExpiryDate", "()Ljava/util/Date;", ref global::org.apache.http.cookie.Cookie_._getExpiryDate32401) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getPorts32402;
		int[] org.apache.http.cookie.Cookie.getPorts()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::org.apache.http.cookie.Cookie_.staticClass, "getPorts", "()[I", ref global::org.apache.http.cookie.Cookie_._getPorts32402) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _isExpired32403;
		bool org.apache.http.cookie.Cookie.isExpired(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.Cookie_.staticClass, "isExpired", "(Ljava/util/Date;)Z", ref global::org.apache.http.cookie.Cookie_._isExpired32403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Cookie_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.Cookie_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/Cookie"));
		}
		internal static void InitJNI()
		{
		}
	}
}
