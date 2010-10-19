namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SM_))]
	public interface SM  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SM))]
	public sealed partial class SM_ : java.lang.Object, SM
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SM_()
		{
			InitJNI();
		}
		internal SM_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SM_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SM"));
		}
	}
}
