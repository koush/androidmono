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
	public sealed partial class EofSensorWatcher_ : java.lang.Object, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EofSensorWatcher_()
		{
			InitJNI();
		}
		internal EofSensorWatcher_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _eofDetected31988;
		 bool org.apache.http.conn.EofSensorWatcher.eofDetected(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorWatcher_._eofDetected31988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorWatcher_.staticClass, global::org.apache.http.conn.EofSensorWatcher_._eofDetected31988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamClosed31989;
		 bool org.apache.http.conn.EofSensorWatcher.streamClosed(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorWatcher_._streamClosed31989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorWatcher_.staticClass, global::org.apache.http.conn.EofSensorWatcher_._streamClosed31989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamAbort31990;
		 bool org.apache.http.conn.EofSensorWatcher.streamAbort(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorWatcher_._streamAbort31990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.EofSensorWatcher_.staticClass, global::org.apache.http.conn.EofSensorWatcher_._streamAbort31990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.EofSensorWatcher_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/EofSensorWatcher"));
			global::org.apache.http.conn.EofSensorWatcher_._eofDetected31988 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorWatcher_.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.EofSensorWatcher_._streamClosed31989 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorWatcher_.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.EofSensorWatcher_._streamAbort31990 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.EofSensorWatcher_.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z");
		}
	}
}
