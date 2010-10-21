namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.HttpTransportMetrics_))]
	public interface HttpTransportMetrics  : global::MonoJavaBridge.IJavaObject 
	{
		void reset();
		long getBytesTransferred();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.HttpTransportMetrics))]
	public sealed partial class HttpTransportMetrics_ : java.lang.Object, HttpTransportMetrics
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpTransportMetrics_()
		{
			InitJNI();
		}
		internal HttpTransportMetrics_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset33350;
		 void org.apache.http.io.HttpTransportMetrics.reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.HttpTransportMetrics_._reset33350);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.HttpTransportMetrics_.staticClass, global::org.apache.http.io.HttpTransportMetrics_._reset33350);
		}
		internal static global::MonoJavaBridge.MethodId _getBytesTransferred33351;
		 long org.apache.http.io.HttpTransportMetrics.getBytesTransferred() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.io.HttpTransportMetrics_._getBytesTransferred33351);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.io.HttpTransportMetrics_.staticClass, global::org.apache.http.io.HttpTransportMetrics_._getBytesTransferred33351);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.HttpTransportMetrics_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/HttpTransportMetrics"));
			global::org.apache.http.io.HttpTransportMetrics_._reset33350 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.HttpTransportMetrics_.staticClass, "reset", "()V");
			global::org.apache.http.io.HttpTransportMetrics_._getBytesTransferred33351 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.HttpTransportMetrics_.staticClass, "getBytesTransferred", "()J");
		}
	}
}
