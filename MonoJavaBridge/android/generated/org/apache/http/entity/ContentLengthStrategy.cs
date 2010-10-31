namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.entity.ContentLengthStrategy_))]
	public partial interface ContentLengthStrategy  : global::MonoJavaBridge.IJavaObject 
	{
		long determineLength(org.apache.http.HttpMessage arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.ContentLengthStrategy))]
	internal sealed partial class ContentLengthStrategy_ : java.lang.Object, ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentLengthStrategy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		long org.apache.http.entity.ContentLengthStrategy.determineLength(org.apache.http.HttpMessage arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.ContentLengthStrategy_.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J", ref global::org.apache.http.entity.ContentLengthStrategy_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ContentLengthStrategy_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ContentLengthStrategy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ContentLengthStrategy"));
		}
	}
}
