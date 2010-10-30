namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.ReasonPhraseCatalog_))]
	public partial interface ReasonPhraseCatalog  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getReason(int arg0, java.util.Locale arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.ReasonPhraseCatalog))]
	internal sealed partial class ReasonPhraseCatalog_ : java.lang.Object, ReasonPhraseCatalog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ReasonPhraseCatalog_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.ReasonPhraseCatalog.getReason(int arg0, java.util.Locale arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.ReasonPhraseCatalog_.staticClass, "getReason", "(ILjava/util/Locale;)Ljava/lang/String;", ref global::org.apache.http.ReasonPhraseCatalog_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		static ReasonPhraseCatalog_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ReasonPhraseCatalog_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ReasonPhraseCatalog"));
		}
		internal static void InitJNI()
		{
		}
	}
}
