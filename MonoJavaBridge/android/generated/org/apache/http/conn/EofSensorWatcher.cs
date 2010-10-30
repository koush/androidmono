namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.conn.EofSensorWatcher_))]
	public partial interface EofSensorWatcher  : global::MonoJavaBridge.IJavaObject 
	{
		bool eofDetected(java.io.InputStream arg0);
		bool streamClosed(java.io.InputStream arg0);
		bool streamAbort(java.io.InputStream arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.conn.EofSensorWatcher))]
	internal sealed partial class EofSensorWatcher_ : java.lang.Object, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EofSensorWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool org.apache.http.conn.EofSensorWatcher.eofDetected(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.EofSensorWatcher_.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.EofSensorWatcher_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool org.apache.http.conn.EofSensorWatcher.streamClosed(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.EofSensorWatcher_.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.EofSensorWatcher_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool org.apache.http.conn.EofSensorWatcher.streamAbort(java.io.InputStream arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.conn.EofSensorWatcher_.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z", ref global::org.apache.http.conn.EofSensorWatcher_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static EofSensorWatcher_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.EofSensorWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/EofSensorWatcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
