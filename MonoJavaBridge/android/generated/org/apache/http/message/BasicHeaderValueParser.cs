namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderValueParser : java.lang.Object, HeaderValueParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderValueParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.HeaderElement[] parseElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderValueParser._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HeaderElement[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::org.apache.http.HeaderElement[] parseElements(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/HeaderElement;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.HeaderElement parseHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderValueParser._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.HeaderElement;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::org.apache.http.HeaderElement parseHeaderElement(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/HeaderElement;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::org.apache.http.NameValuePair[] parseParameters(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/NameValuePair;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.NameValuePair[] parseParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.NameValuePair[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1, char[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;[C)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.NameValuePair;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.NameValuePair;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::org.apache.http.NameValuePair parseNameValuePair(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/NameValuePair;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual global::org.apache.http.HeaderElement createHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createHeaderElement", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)Lorg/apache/http/HeaderElement;", ref global::org.apache.http.message.BasicHeaderValueParser._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.HeaderElement;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::org.apache.http.NameValuePair createNameValuePair(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.NameValuePair>(this, global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createNameValuePair", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/NameValuePair;", ref global::org.apache.http.message.BasicHeaderValueParser._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.NameValuePair;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public BasicHeaderValueParser() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueParser._m11.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueParser._m11 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._m11);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT7512;
		public static global::org.apache.http.message.BasicHeaderValueParser DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicHeaderValueParser.staticClass, _DEFAULT7512)) as org.apache.http.message.BasicHeaderValueParser;
			}
		}
		static BasicHeaderValueParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderValueParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderValueParser"));
			global::org.apache.http.message.BasicHeaderValueParser._DEFAULT7512 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicHeaderValueParser;");
		}
		internal static void InitJNI()
		{
		}
	}
}
