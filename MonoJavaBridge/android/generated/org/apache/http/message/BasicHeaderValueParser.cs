namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderValueParser : java.lang.Object, HeaderValueParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderValueParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseElements33555;
		public virtual global::org.apache.http.HeaderElement[] parseElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderValueParser._parseElements33555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseElements33556;
		public static global::org.apache.http.HeaderElement[] parseElements(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._parseElements33556.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._parseElements33556 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/HeaderElement;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseElements33556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement33557;
		public virtual global::org.apache.http.HeaderElement parseHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement33558;
		public static global::org.apache.http.HeaderElement parseHeaderElement(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33558.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33558 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/HeaderElement;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters33559;
		public static global::org.apache.http.NameValuePair[] parseParameters(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._parseParameters33559.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._parseParameters33559 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/NameValuePair;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseParameters33559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters33560;
		public virtual global::org.apache.http.NameValuePair[] parseParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._parseParameters33560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33561;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1, char[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;[C)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33562;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33563;
		public static global::org.apache.http.NameValuePair parseNameValuePair(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33563.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33563 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/NameValuePair;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _createHeaderElement33564;
		protected virtual global::org.apache.http.HeaderElement createHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createHeaderElement", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement33564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _createNameValuePair33565;
		protected virtual global::org.apache.http.NameValuePair createNameValuePair(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createNameValuePair", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair33565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderValueParser33566;
		public BasicHeaderValueParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser33566.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser33566 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser33566);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT33567;
		public static global::org.apache.http.message.BasicHeaderValueParser DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicHeaderValueParser.staticClass, _DEFAULT33567)) as org.apache.http.message.BasicHeaderValueParser;
			}
		}
		static BasicHeaderValueParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderValueParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderValueParser"));
			global::org.apache.http.message.BasicHeaderValueParser._DEFAULT33567 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicHeaderValueParser;");
		}
		internal static void InitJNI()
		{
		}
	}
}
