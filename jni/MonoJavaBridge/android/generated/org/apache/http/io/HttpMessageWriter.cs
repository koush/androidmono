namespace org.apache.http.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.io.HttpMessageWriter_))]
	public partial interface HttpMessageWriter  : global::MonoJavaBridge.IJavaObject 
	{
		void write(org.apache.http.HttpMessage arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.io.HttpMessageWriter))]
	internal sealed partial class HttpMessageWriter_ : java.lang.Object, HttpMessageWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpMessageWriter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33468;
		void org.apache.http.io.HttpMessageWriter.write(org.apache.http.HttpMessage arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.io.HttpMessageWriter_._write33468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.io.HttpMessageWriter_.staticClass, global::org.apache.http.io.HttpMessageWriter_._write33468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static HttpMessageWriter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.io.HttpMessageWriter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/io/HttpMessageWriter"));
			global::org.apache.http.io.HttpMessageWriter_._write33468 = @__env.GetMethodIDNoThrow(global::org.apache.http.io.HttpMessageWriter_.staticClass, "write", "(Lorg/apache/http/HttpMessage;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
