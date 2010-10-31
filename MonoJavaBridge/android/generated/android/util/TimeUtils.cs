namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TimeUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimeUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.util.TimeZone getTimeZone(int arg0, bool arg1, long arg2, java.lang.String arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TimeUtils._m0.native == global::System.IntPtr.Zero)
				global::android.util.TimeUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.TimeUtils.staticClass, "getTimeZone", "(IZJLjava/lang/String;)Ljava/util/TimeZone;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.TimeUtils.staticClass, global::android.util.TimeUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.TimeZone;
		}
		public static global::java.lang.String TimeZoneDatabaseVersion
		{
			get
			{
				return getTimeZoneDatabaseVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String getTimeZoneDatabaseVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TimeUtils._m1.native == global::System.IntPtr.Zero)
				global::android.util.TimeUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.TimeUtils.staticClass, "getTimeZoneDatabaseVersion", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.TimeUtils.staticClass, global::android.util.TimeUtils._m1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public TimeUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.TimeUtils._m2.native == global::System.IntPtr.Zero)
				global::android.util.TimeUtils._m2 = @__env.GetMethodIDNoThrow(global::android.util.TimeUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.TimeUtils.staticClass, global::android.util.TimeUtils._m2);
			Init(@__env, handle);
		}
		static TimeUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.TimeUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/TimeUtils"));
		}
	}
}
