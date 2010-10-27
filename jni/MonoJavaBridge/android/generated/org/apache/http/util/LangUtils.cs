namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class LangUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LangUtils()
		{
			InitJNI();
		}
		internal LangUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals34014;
		public static bool equals(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._equals34014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals34015;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._equals34015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34016;
		public static int hashCode(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._hashCode34016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34017;
		public static int hashCode(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._hashCode34017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34018;
		public static int hashCode(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._hashCode34018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.util.LangUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/util/LangUtils"));
			global::org.apache.http.util.LangUtils._equals34014 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::org.apache.http.util.LangUtils._equals34015 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			global::org.apache.http.util.LangUtils._hashCode34016 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(II)I");
			global::org.apache.http.util.LangUtils._hashCode34017 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(IZ)I");
			global::org.apache.http.util.LangUtils._hashCode34018 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(ILjava/lang/Object;)I");
		}
	}
}
