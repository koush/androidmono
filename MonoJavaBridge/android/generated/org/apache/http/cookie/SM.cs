namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.SM_))]
	public partial interface SM  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.SM))]
	internal sealed partial class SM_ : java.lang.Object, SM
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SM_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static SM_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.SM_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/SM"));
		}
	}
}
