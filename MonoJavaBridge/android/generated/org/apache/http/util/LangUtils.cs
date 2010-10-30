namespace org.apache.http.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class LangUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LangUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals34015;
		public static bool equals(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._equals34015.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._equals34015 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._equals34015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _equals34016;
		public static bool equals(java.lang.Object[] arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._equals34016.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._equals34016 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "equals", "([Ljava/lang/Object;[Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._equals34016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34017;
		public static int hashCode(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._hashCode34017.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._hashCode34017 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(II)I");
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._hashCode34017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34018;
		public static int hashCode(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._hashCode34018.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._hashCode34018 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(IZ)I");
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._hashCode34018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode34019;
		public static int hashCode(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.util.LangUtils._hashCode34019.native == global::System.IntPtr.Zero)
				global::org.apache.http.util.LangUtils._hashCode34019 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.util.LangUtils.staticClass, "hashCode", "(ILjava/lang/Object;)I");
			return @__env.CallStaticIntMethod(org.apache.http.util.LangUtils.staticClass, global::org.apache.http.util.LangUtils._hashCode34019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static void InitJNI()
		{
		}
	}
}
