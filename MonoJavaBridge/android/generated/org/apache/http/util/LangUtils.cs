namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class LangUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LangUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool equals(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int hashCode(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._m2.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(II)I");
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int hashCode(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(IZ)I");
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int hashCode(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(ILjava/lang/Object;)I");
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int HASH_SEED
		{
			get
			{
				return 17;
			}
		}
		public static int HASH_OFFSET
		{
			get
			{
				return 37;
			}
		}
		static LangUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.LangUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/LangUtils"));
		}
	}
}
