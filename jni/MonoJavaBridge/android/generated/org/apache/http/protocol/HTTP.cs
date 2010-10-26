namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class HTTP : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HTTP()
		{
			InitJNI();
		}
		internal HTTP(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isWhitespace33853;
		public static bool isWhitespace(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(org.apache.http.protocol.HTTP.staticClass, global::org.apache.http.protocol.HTTP._isWhitespace33853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int CR
		{
			get
			{
				return 13;
			}
		}
		public static int LF
		{
			get
			{
				return 10;
			}
		}
		public static int SP
		{
			get
			{
				return 32;
			}
		}
		public static int HT
		{
			get
			{
				return 9;
			}
		}
		public static global::java.lang.String TRANSFER_ENCODING
		{
			get
			{
				return "Transfer-Encoding";
			}
		}
		public static global::java.lang.String CONTENT_LEN
		{
			get
			{
				return "Content-Length";
			}
		}
		public static global::java.lang.String CONTENT_TYPE
		{
			get
			{
				return "Content-Type";
			}
		}
		public static global::java.lang.String CONTENT_ENCODING
		{
			get
			{
				return "Content-Encoding";
			}
		}
		public static global::java.lang.String EXPECT_DIRECTIVE
		{
			get
			{
				return "Expect";
			}
		}
		public static global::java.lang.String CONN_DIRECTIVE
		{
			get
			{
				return "Connection";
			}
		}
		public static global::java.lang.String TARGET_HOST
		{
			get
			{
				return "Host";
			}
		}
		public static global::java.lang.String USER_AGENT
		{
			get
			{
				return "User-Agent";
			}
		}
		public static global::java.lang.String DATE_HEADER
		{
			get
			{
				return "Date";
			}
		}
		public static global::java.lang.String SERVER_HEADER
		{
			get
			{
				return "Server";
			}
		}
		public static global::java.lang.String EXPECT_CONTINUE
		{
			get
			{
				return "100-Continue";
			}
		}
		public static global::java.lang.String CONN_CLOSE
		{
			get
			{
				return "Close";
			}
		}
		public static global::java.lang.String CONN_KEEP_ALIVE
		{
			get
			{
				return "Keep-Alive";
			}
		}
		public static global::java.lang.String CHUNK_CODING
		{
			get
			{
				return "chunked";
			}
		}
		public static global::java.lang.String IDENTITY_CODING
		{
			get
			{
				return "identity";
			}
		}
		public static global::java.lang.String UTF_8
		{
			get
			{
				return "UTF-8";
			}
		}
		public static global::java.lang.String UTF_16
		{
			get
			{
				return "UTF-16";
			}
		}
		public static global::java.lang.String US_ASCII
		{
			get
			{
				return "US-ASCII";
			}
		}
		public static global::java.lang.String ASCII
		{
			get
			{
				return "ASCII";
			}
		}
		public static global::java.lang.String ISO_8859_1
		{
			get
			{
				return "ISO-8859-1";
			}
		}
		public static global::java.lang.String DEFAULT_CONTENT_CHARSET
		{
			get
			{
				return "ISO-8859-1";
			}
		}
		public static global::java.lang.String DEFAULT_PROTOCOL_CHARSET
		{
			get
			{
				return "US-ASCII";
			}
		}
		public static global::java.lang.String OCTET_STREAM_TYPE
		{
			get
			{
				return "application/octet-stream";
			}
		}
		public static global::java.lang.String PLAIN_TEXT_TYPE
		{
			get
			{
				return "text/plain";
			}
		}
		public static global::java.lang.String CHARSET_PARAM
		{
			get
			{
				return "; charset=";
			}
		}
		public static global::java.lang.String DEFAULT_CONTENT_TYPE
		{
			get
			{
				return "application/octet-stream";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HTTP.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HTTP"));
			global::org.apache.http.protocol.HTTP._isWhitespace33853 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.protocol.HTTP.staticClass, "isWhitespace", "(C)Z");
		}
	}
}
