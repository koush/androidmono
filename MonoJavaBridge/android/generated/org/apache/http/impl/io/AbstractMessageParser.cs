namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractMessageParser_))]
	public abstract partial class AbstractMessageParser : java.lang.Object, org.apache.http.io.HttpMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractMessageParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33380;
		public virtual global::org.apache.http.HttpMessage parse()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractMessageParser._parse33380)) as org.apache.http.HttpMessage;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractMessageParser.staticClass, global::org.apache.http.impl.io.AbstractMessageParser._parse33380)) as org.apache.http.HttpMessage;
		}
		internal static global::MonoJavaBridge.MethodId _parseHead33381;
		protected abstract global::org.apache.http.HttpMessage parseHead(org.apache.http.io.SessionInputBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _parseHeaders33382;
		public static global::org.apache.http.Header[] parseHeaders(org.apache.http.io.SessionInputBuffer arg0, int arg1, int arg2, org.apache.http.message.LineParser arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallStaticObjectMethod(org.apache.http.impl.io.AbstractMessageParser.staticClass, global::org.apache.http.impl.io.AbstractMessageParser._parseHeaders33382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _AbstractMessageParser33383;
		public AbstractMessageParser(org.apache.http.io.SessionInputBuffer arg0, org.apache.http.message.LineParser arg1, org.apache.http.@params.HttpParams arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractMessageParser.staticClass, global::org.apache.http.impl.io.AbstractMessageParser._AbstractMessageParser33383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AbstractMessageParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractMessageParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractMessageParser"));
			global::org.apache.http.impl.io.AbstractMessageParser._parse33380 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageParser.staticClass, "parse", "()Lorg/apache/http/HttpMessage;");
			global::org.apache.http.impl.io.AbstractMessageParser._parseHead33381 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageParser.staticClass, "parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;");
			global::org.apache.http.impl.io.AbstractMessageParser._parseHeaders33382 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageParser.staticClass, "parseHeaders", "(Lorg/apache/http/io/SessionInputBuffer;IILorg/apache/http/message/LineParser;)[Lorg/apache/http/Header;");
			global::org.apache.http.impl.io.AbstractMessageParser._AbstractMessageParser33383 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageParser.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;Lorg/apache/http/message/LineParser;Lorg/apache/http/params/HttpParams;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractMessageParser))]
	internal sealed partial class AbstractMessageParser_ : org.apache.http.impl.io.AbstractMessageParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractMessageParser_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHead33384;
		protected override global::org.apache.http.HttpMessage parseHead(org.apache.http.io.SessionInputBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractMessageParser_._parseHead33384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpMessage;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpMessage>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.io.AbstractMessageParser_.staticClass, global::org.apache.http.impl.io.AbstractMessageParser_._parseHead33384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpMessage;
		}
		static AbstractMessageParser_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractMessageParser_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractMessageParser"));
			global::org.apache.http.impl.io.AbstractMessageParser_._parseHead33384 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractMessageParser_.staticClass, "parseHead", "(Lorg/apache/http/io/SessionInputBuffer;)Lorg/apache/http/HttpMessage;");
		}
		internal static void InitJNI()
		{
		}
	}
}
