namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicLineFormatter : java.lang.Object, LineFormatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicLineFormatter()
		{
			InitJNI();
		}
		protected BasicLineFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader33475;
		public static global::java.lang.String formatHeader(org.apache.http.Header arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatHeader33475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader33476;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._formatHeader33476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatHeader33476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _appendProtocolVersion33477;
		public virtual global::org.apache.http.util.CharArrayBuffer appendProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.ProtocolVersion arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._appendProtocolVersion33477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._appendProtocolVersion33477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatRequestLine33478;
		public static global::java.lang.String formatRequestLine(org.apache.http.RequestLine arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatRequestLine33478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatRequestLine33479;
		public virtual global::org.apache.http.util.CharArrayBuffer formatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._formatRequestLine33479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatRequestLine33479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatStatusLine33480;
		public virtual global::org.apache.http.util.CharArrayBuffer formatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._formatStatusLine33480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatStatusLine33480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatStatusLine33481;
		public static global::java.lang.String formatStatusLine(org.apache.http.StatusLine arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatStatusLine33481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _initBuffer33482;
		protected virtual global::org.apache.http.util.CharArrayBuffer initBuffer(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._initBuffer33482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._initBuffer33482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatProtocolVersion33483;
		public static global::java.lang.String formatProtocolVersion(org.apache.http.ProtocolVersion arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatProtocolVersion33483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateProtocolVersionLen33484;
		protected virtual int estimateProtocolVersionLen(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._estimateProtocolVersionLen33484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._estimateProtocolVersionLen33484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatRequestLine33485;
		protected virtual void doFormatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._doFormatRequestLine33485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._doFormatRequestLine33485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatStatusLine33486;
		protected virtual void doFormatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._doFormatStatusLine33486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._doFormatStatusLine33486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatHeader33487;
		protected virtual void doFormatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._doFormatHeader33487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._doFormatHeader33487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicLineFormatter33488;
		public BasicLineFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._BasicLineFormatter33488);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT33489;
		public static global::org.apache.http.message.BasicLineFormatter DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicLineFormatter.staticClass, _DEFAULT33489)) as org.apache.http.message.BasicLineFormatter;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicLineFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicLineFormatter"));
			global::org.apache.http.message.BasicLineFormatter._formatHeader33475 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatHeader", "(Lorg/apache/http/Header;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._formatHeader33476 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._appendProtocolVersion33477 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatRequestLine33478 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatRequestLine", "(Lorg/apache/http/RequestLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._formatRequestLine33479 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatStatusLine33480 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatStatusLine33481 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatStatusLine", "(Lorg/apache/http/StatusLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._initBuffer33482 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "initBuffer", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatProtocolVersion33483 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatProtocolVersion", "(Lorg/apache/http/ProtocolVersion;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._estimateProtocolVersionLen33484 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "estimateProtocolVersionLen", "(Lorg/apache/http/ProtocolVersion;)I");
			global::org.apache.http.message.BasicLineFormatter._doFormatRequestLine33485 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)V");
			global::org.apache.http.message.BasicLineFormatter._doFormatStatusLine33486 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)V");
			global::org.apache.http.message.BasicLineFormatter._doFormatHeader33487 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)V");
			global::org.apache.http.message.BasicLineFormatter._BasicLineFormatter33488 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "<init>", "()V");
			global::org.apache.http.message.BasicLineFormatter._DEFAULT33489 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicLineFormatter;");
		}
	}
}
