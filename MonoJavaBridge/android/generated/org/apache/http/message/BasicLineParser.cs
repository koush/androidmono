namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicLineParser : java.lang.Object, LineParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicLineParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::org.apache.http.Header parseHeader(java.lang.String arg0, org.apache.http.message.LineParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineParser._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineParser._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseHeader", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.Header parseHeader(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.message.BasicLineParser.staticClass, "parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;", ref global::org.apache.http.message.BasicLineParser._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.ProtocolVersion parseProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicLineParser.staticClass, "parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicLineParser._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::org.apache.http.ProtocolVersion parseProtocolVersion(java.lang.String arg0, org.apache.http.message.LineParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineParser._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineParser._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseProtocolVersion", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool hasProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicLineParser.staticClass, "hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z", ref global::org.apache.http.message.BasicLineParser._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.RequestLine parseRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.message.BasicLineParser.staticClass, "parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/RequestLine;", ref global::org.apache.http.message.BasicLineParser._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.RequestLine;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::org.apache.http.RequestLine parseRequestLine(java.lang.String arg0, org.apache.http.message.LineParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineParser._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineParser._m6 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseRequestLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/RequestLine;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.RequestLine;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.StatusLine parseStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.StatusLine>(this, global::org.apache.http.message.BasicLineParser.staticClass, "parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/StatusLine;", ref global::org.apache.http.message.BasicLineParser._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.StatusLine;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::org.apache.http.StatusLine parseStatusLine(java.lang.String arg0, org.apache.http.message.LineParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineParser._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineParser._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseStatusLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/StatusLine;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.StatusLine;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::org.apache.http.ProtocolVersion createProtocolVersion(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicLineParser.staticClass, "createProtocolVersion", "(II)Lorg/apache/http/ProtocolVersion;", ref global::org.apache.http.message.BasicLineParser._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.ProtocolVersion;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::org.apache.http.RequestLine createRequestLine(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.message.BasicLineParser.staticClass, "createRequestLine", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/RequestLine;", ref global::org.apache.http.message.BasicLineParser._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.RequestLine;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual global::org.apache.http.StatusLine createStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.StatusLine>(this, global::org.apache.http.message.BasicLineParser.staticClass, "createStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)Lorg/apache/http/StatusLine;", ref global::org.apache.http.message.BasicLineParser._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.StatusLine;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void skipWhitespace(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicLineParser.staticClass, "skipWhitespace", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)V", ref global::org.apache.http.message.BasicLineParser._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public BasicLineParser(org.apache.http.ProtocolVersion arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineParser._m13.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineParser._m13 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public BasicLineParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineParser._m14.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineParser._m14 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._m14);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT7514;
		public static global::org.apache.http.message.BasicLineParser DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicLineParser.staticClass, _DEFAULT7514)) as org.apache.http.message.BasicLineParser;
			}
		}
		static BasicLineParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicLineParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicLineParser"));
			global::org.apache.http.message.BasicLineParser._DEFAULT7514 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicLineParser;");
		}
	}
}
