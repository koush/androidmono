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
		internal static global::MonoJavaBridge.MethodId _parseElements33436;
		public virtual global::org.apache.http.HeaderElement[] parseElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseElements33436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseElements33436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseElements33437;
		public static global::org.apache.http.HeaderElement[] parseElements(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseElements33437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement33438;
		public virtual global::org.apache.http.HeaderElement parseHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseHeaderElement33439;
		public static global::org.apache.http.HeaderElement parseHeaderElement(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters33440;
		public static global::org.apache.http.NameValuePair[] parseParameters(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseParameters33440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseParameters33441;
		public virtual global::org.apache.http.NameValuePair[] parseParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseParameters33441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseParameters33441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair[];
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33442;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1, char[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33443;
		public virtual global::org.apache.http.NameValuePair parseNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.message.ParserCursor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _parseNameValuePair33444;
		public static global::org.apache.http.NameValuePair parseNameValuePair(java.lang.String arg0, org.apache.http.message.HeaderValueParser arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _createHeaderElement33445;
		protected virtual global::org.apache.http.HeaderElement createHeaderElement(java.lang.String arg0, java.lang.String arg1, org.apache.http.NameValuePair[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement33445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HeaderElement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement33445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _createNameValuePair33446;
		protected virtual global::org.apache.http.NameValuePair createNameValuePair(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair33446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.NameValuePair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair33446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.NameValuePair;
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderValueParser33447;
		public BasicHeaderValueParser()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueParser.staticClass, global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser33447);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT33448;
		public static global::org.apache.http.message.BasicHeaderValueParser DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicHeaderValueParser.staticClass, _DEFAULT33448)) as org.apache.http.message.BasicHeaderValueParser;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderValueParser.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderValueParser"));
			global::org.apache.http.message.BasicHeaderValueParser._parseElements33436 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseElements33437 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseElements", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33438 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseHeaderElement33439 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseHeaderElement", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._parseParameters33440 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseParameters33441 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseParameters", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)[Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33442 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;[C)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33443 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/message/ParserCursor;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._parseNameValuePair33444 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "parseNameValuePair", "(Ljava/lang/String;Lorg/apache/http/message/HeaderValueParser;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._createHeaderElement33445 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createHeaderElement", "(Ljava/lang/String;Ljava/lang/String;[Lorg/apache/http/NameValuePair;)Lorg/apache/http/HeaderElement;");
			global::org.apache.http.message.BasicHeaderValueParser._createNameValuePair33446 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "createNameValuePair", "(Ljava/lang/String;Ljava/lang/String;)Lorg/apache/http/NameValuePair;");
			global::org.apache.http.message.BasicHeaderValueParser._BasicHeaderValueParser33447 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "<init>", "()V");
			global::org.apache.http.message.BasicHeaderValueParser._DEFAULT33448 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicHeaderValueParser.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicHeaderValueParser;");
		}
	}
}
