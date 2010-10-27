namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimeUtils()
		{
			InitJNI();
		}
		protected TimeUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone13887;
		public static global::java.util.TimeZone getTimeZone(int arg0, bool arg1, long arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.TimeUtils.staticClass, global::android.util.TimeUtils._getTimeZone13887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.TimeZone;
		}
		public static global::java.lang.String TimeZoneDatabaseVersion
		{
			get
			{
				return getTimeZoneDatabaseVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZoneDatabaseVersion13888;
		public static global::java.lang.String getTimeZoneDatabaseVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.TimeUtils.staticClass, global::android.util.TimeUtils._getTimeZoneDatabaseVersion13888)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TimeUtils13889;
		public TimeUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimeUtils.staticClass, global::android.util.TimeUtils._TimeUtils13889);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimeUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimeUtils"));
			global::android.util.TimeUtils._getTimeZone13887 = @__env.GetStaticMethodIDNoThrow(global::android.util.TimeUtils.staticClass, "getTimeZone", "(IZJLjava/lang/String;)Ljava/util/TimeZone;");
			global::android.util.TimeUtils._getTimeZoneDatabaseVersion13888 = @__env.GetStaticMethodIDNoThrow(global::android.util.TimeUtils.staticClass, "getTimeZoneDatabaseVersion", "()Ljava/lang/String;");
			global::android.util.TimeUtils._TimeUtils13889 = @__env.GetMethodIDNoThrow(global::android.util.TimeUtils.staticClass, "<init>", "()V");
		}
	}
}
