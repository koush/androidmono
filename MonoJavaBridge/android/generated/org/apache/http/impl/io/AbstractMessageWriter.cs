namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractMessageWriter_))]
	public abstract partial class AbstractMessageWriter : java.lang.Object, org.apache.http.io.HttpMessageWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractMessageWriter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33385;
		public virtual void write(org.apache.http.HttpMessage arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractMessageWriter.staticClass, global::org.apache.http.impl.io.AbstractMessageWriter._write33385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeHeadLine33386;
		protected abstract void writeHeadLine(org.apache.http.HttpMessage arg0);
		internal static global::MonoJavaBridge.MethodId _AbstractMessageWriter33387;
		public AbstractMessageWriter(org.apache.http.io.SessionOutputBuffer arg0, org.apache.http.message.LineFormatter arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractMessageWriter.staticClass, global::org.apache.http.impl.io.AbstractMessageWriter._AbstractMessageWriter33387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AbstractMessageWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractMessageWriter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractMessageWriter"));
			global::org.apache.http.impl.io.AbstractMessageWriter._write33385 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageWriter.staticClass, "write", "(Lorg/apache/http/HttpMessage;)V");
			global::org.apache.http.impl.io.AbstractMessageWriter._writeHeadLine33386 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageWriter.staticClass, "writeHeadLine", "(Lorg/apache/http/HttpMessage;)V");
			global::org.apache.http.impl.io.AbstractMessageWriter._AbstractMessageWriter33387 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageWriter.staticClass, "<init>", "(Lorg/apache/http/io/SessionOutputBuffer;Lorg/apache/http/message/LineFormatter;Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractMessageWriter))]
	internal sealed partial class AbstractMessageWriter_ : org.apache.http.impl.io.AbstractMessageWriter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractMessageWriter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeHeadLine33388;
		protected override void writeHeadLine(org.apache.http.HttpMessage arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractMessageWriter_._writeHeadLine33388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AbstractMessageWriter_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractMessageWriter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractMessageWriter"));
			global::org.apache.http.impl.io.AbstractMessageWriter_._writeHeadLine33388 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageWriter_.staticClass, "writeHeadLine", "(Lorg/apache/http/HttpMessage;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
