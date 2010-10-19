namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicLineParser : java.lang.Object, LineParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicLineParser()
		{
			InitJNI();
		}
		protected BasicLineParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseHeader26861;
		public static global::org.apache.http.Header parseHeader(java.lang.String arg0, org.apache.http.message.LineParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseHeader26861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseHeader26862;
		public virtual global::org.apache.http.Header parseHeader(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._parseHeader26862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseHeader26862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseProtocolVersion26863;
		public virtual global::org.apache.http.ProtocolVersion parseProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._parseProtocolVersion26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseProtocolVersion26863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _parseProtocolVersion26864;
		public static global::org.apache.http.ProtocolVersion parseProtocolVersion(java.lang.String arg0, org.apache.http.message.LineParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseProtocolVersion26864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _hasProtocolVersion26865;
		public virtual bool hasProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._hasProtocolVersion26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._hasProtocolVersion26865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parseRequestLine26866;
		public virtual global::org.apache.http.RequestLine parseRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._parseRequestLine26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseRequestLine26866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _parseRequestLine26867;
		public static global::org.apache.http.RequestLine parseRequestLine(java.lang.String arg0, org.apache.http.message.LineParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseRequestLine26867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _parseStatusLine26868;
		public virtual global::org.apache.http.StatusLine parseStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._parseStatusLine26868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.StatusLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseStatusLine26868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.StatusLine;
		}
		internal static global::MonoJavaBridge.MethodId _parseStatusLine26869;
		public static global::org.apache.http.StatusLine parseStatusLine(java.lang.String arg0, org.apache.http.message.LineParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._parseStatusLine26869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.StatusLine;
		}
		internal static global::MonoJavaBridge.MethodId _createProtocolVersion26870;
		protected virtual global::org.apache.http.ProtocolVersion createProtocolVersion(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._createProtocolVersion26870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._createProtocolVersion26870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _createRequestLine26871;
		protected virtual global::org.apache.http.RequestLine createRequestLine(java.lang.String arg0, java.lang.String arg1, org.apache.http.ProtocolVersion arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._createRequestLine26871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.RequestLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.RequestLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._createRequestLine26871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _createStatusLine26872;
		protected virtual global::org.apache.http.StatusLine createStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._createStatusLine26872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.StatusLine;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._createStatusLine26872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.StatusLine;
		}
		internal static global::MonoJavaBridge.MethodId _skipWhitespace26873;
		protected virtual void skipWhitespace(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser._skipWhitespace26873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._skipWhitespace26873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicLineParser26874;
		public BasicLineParser(org.apache.http.ProtocolVersion arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._BasicLineParser26874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _BasicLineParser26875;
		public BasicLineParser()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineParser.staticClass, global::org.apache.http.message.BasicLineParser._BasicLineParser26875);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT26876;
		public static global::org.apache.http.message.BasicLineParser DEFAULT
		{
			get
			{
				return default(global::org.apache.http.message.BasicLineParser);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicLineParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicLineParser"));
			global::org.apache.http.message.BasicLineParser._parseHeader26861 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseHeader", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/Header;");
			global::org.apache.http.message.BasicLineParser._parseHeader26862 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseHeader", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/Header;");
			global::org.apache.http.message.BasicLineParser._parseProtocolVersion26863 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicLineParser._parseProtocolVersion26864 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseProtocolVersion", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicLineParser._hasProtocolVersion26865 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "hasProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Z");
			global::org.apache.http.message.BasicLineParser._parseRequestLine26866 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/RequestLine;");
			global::org.apache.http.message.BasicLineParser._parseRequestLine26867 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseRequestLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/RequestLine;");
			global::org.apache.http.message.BasicLineParser._parseStatusLine26868 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/StatusLine;");
			global::org.apache.http.message.BasicLineParser._parseStatusLine26869 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "parseStatusLine", "(Ljava/lang/String;Lorg/apache/http/message/LineParser;)Lorg/apache/http/StatusLine;");
			global::org.apache.http.message.BasicLineParser._createProtocolVersion26870 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "createProtocolVersion", "(II)Lorg/apache/http/ProtocolVersion;");
			global::org.apache.http.message.BasicLineParser._createRequestLine26871 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "createRequestLine", "(Ljava/lang/String;Ljava/lang/String;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/RequestLine;");
			global::org.apache.http.message.BasicLineParser._createStatusLine26872 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "createStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)Lorg/apache/http/StatusLine;");
			global::org.apache.http.message.BasicLineParser._skipWhitespace26873 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "skipWhitespace", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)V");
			global::org.apache.http.message.BasicLineParser._BasicLineParser26874 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;)V");
			global::org.apache.http.message.BasicLineParser._BasicLineParser26875 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineParser.staticClass, "<init>", "()V");
		}
	}
}
