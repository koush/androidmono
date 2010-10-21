namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.entity.ContentLengthStrategy_))]
	public interface ContentLengthStrategy  : global::MonoJavaBridge.IJavaObject 
	{
		long determineLength(org.apache.http.HttpMessage arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.ContentLengthStrategy))]
	public sealed partial class ContentLengthStrategy_ : java.lang.Object, ContentLengthStrategy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentLengthStrategy_()
		{
			InitJNI();
		}
		internal ContentLengthStrategy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _determineLength32410;
		 long org.apache.http.entity.ContentLengthStrategy.determineLength(org.apache.http.HttpMessage arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.ContentLengthStrategy_._determineLength32410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.ContentLengthStrategy_.staticClass, global::org.apache.http.entity.ContentLengthStrategy_._determineLength32410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ContentLengthStrategy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ContentLengthStrategy"));
			global::org.apache.http.entity.ContentLengthStrategy_._determineLength32410 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ContentLengthStrategy_.staticClass, "determineLength", "(Lorg/apache/http/HttpMessage;)J");
		}
	}
}
