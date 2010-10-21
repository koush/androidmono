namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DateUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DateUtils()
		{
			InitJNI();
		}
		internal DateUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseDate33179;
		public static global::java.util.Date parseDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._parseDate33179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _parseDate33180;
		public static global::java.util.Date parseDate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._parseDate33180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _parseDate33181;
		public static global::java.util.Date parseDate(java.lang.String arg0, java.lang.String[] arg1, java.util.Date arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._parseDate33181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Date;
		}
		internal static global::MonoJavaBridge.MethodId _formatDate33182;
		public static global::java.lang.String formatDate(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._formatDate33182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatDate33183;
		public static global::java.lang.String formatDate(java.util.Date arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._formatDate33183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		public static global::java.lang.String PATTERN_RFC1123
		{
			get
			{
				return "EEE, dd MMM yyyy HH:mm:ss zzz";
			}
		}
		public static global::java.lang.String PATTERN_RFC1036
		{
			get
			{
				return "EEEE, dd-MMM-yy HH:mm:ss zzz";
			}
		}
		public static global::java.lang.String PATTERN_ASCTIME
		{
			get
			{
				return "EEE MMM d HH:mm:ss yyyy";
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMT33187;
		public static global::java.util.TimeZone GMT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.impl.cookie.DateUtils.staticClass, _GMT33187)) as java.util.TimeZone;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.DateUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/DateUtils"));
			global::org.apache.http.impl.cookie.DateUtils._parseDate33179 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "parseDate", "(Ljava/lang/String;)Ljava/util/Date;");
			global::org.apache.http.impl.cookie.DateUtils._parseDate33180 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "parseDate", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;");
			global::org.apache.http.impl.cookie.DateUtils._parseDate33181 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "parseDate", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Date;)Ljava/util/Date;");
			global::org.apache.http.impl.cookie.DateUtils._formatDate33182 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "formatDate", "(Ljava/util/Date;)Ljava/lang/String;");
			global::org.apache.http.impl.cookie.DateUtils._formatDate33183 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "formatDate", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.impl.cookie.DateUtils._GMT33187 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "GMT", "Ljava/util/TimeZone;");
		}
	}
}
