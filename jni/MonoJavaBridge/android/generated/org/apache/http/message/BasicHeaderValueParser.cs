namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderValueParser : java.lang.Object, HeaderValueParser
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHeaderValueParser()
		{
			InitJNI();
		}
		protected BasicHeaderValueParser(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseElements26807;
		public virtual global::org.apache.http.HeaderElement[] parseElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseElements26807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseElements26807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseElements26808;
		public static global::org.apache.http.HeaderElement[] parseElements(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseElements26808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement26809;
		public virtual global::org.apache.http.HeaderElement parseHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement26809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement26809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement26810;
		public static global::org.apache.http.HeaderElement parseHeaderElement(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement26810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters26811;
		public static global::org.apache.http.NameValuePair[] parseParameters(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseParameters26811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters26812;
		public virtual global::org.apache.http.NameValuePair[] parseParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseParameters26812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseParameters26812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair26813;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1, char[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair26814;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair26815;
		public static global::org.apache.http.NameValuePair parseNameValuePair(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _createHeaderElement26816;
		protected virtual global::org.apache.http.HeaderElement createHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement26816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement26816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _createNameValuePair26817;
		protected virtual global::org.apache.http.NameValuePair createNameValuePair(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair26817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair26817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderValueParser26818;
		public BasicHeaderValueParser()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser26818);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT26819;
		public static global::org.apache.http.message.BasicHeaderValueParser DEFAULT
		{
			get
			{
				return default(global::org.apache.http.message.BasicHeaderValueParser);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderValueParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderValueParser"));
			global::org.apache.http.message.BasicHeaderValueParser._parseElements26807 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseElements26808 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement26809 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement26810 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseParameters26811 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseParameters26812 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26813 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;[C)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26814 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair26815 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement26816 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createHeaderElement", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair26817 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createNameValuePair", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser26818 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "<init>", "()V");
		}
	}
}
