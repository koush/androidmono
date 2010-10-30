namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DateUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DateUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.util.Date parseDate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "parseDate", "(Ljava/lang/String;)Ljava/util/Date;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.Date parseDate(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateUtils._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "parseDate", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/Date;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.util.Date parseDate(java.lang.String arg0, java.lang.String[] arg1, java.util.Date arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateUtils._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "parseDate", "(Ljava/lang/String;[Ljava/lang/String;Ljava/util/Date;)Ljava/util/Date;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Date;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String formatDate(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateUtils._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "formatDate", "(Ljava/util/Date;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.String formatDate(java.util.Date arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.DateUtils._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.DateUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "formatDate", "(Ljava/util/Date;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.DateUtils.staticClass, global::org.apache.http.impl.cookie.DateUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
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
		internal static global::MonoJavaBridge.FieldId _GMT7507;
		public static global::java.util.TimeZone GMT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.impl.cookie.DateUtils.staticClass, _GMT7507)) as java.util.TimeZone;
			}
		}
		static DateUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.DateUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/DateUtils"));
			global::org.apache.http.impl.cookie.DateUtils._GMT7507 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.impl.cookie.DateUtils.staticClass, "GMT", "Ljava/util/TimeZone;");
		}
		internal static void InitJNI()
		{
		}
	}
}
