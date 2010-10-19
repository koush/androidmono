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
		internal static global::MonoJavaBridge.MethodId _formatHeader26846;
		public static global::java.lang.String formatHeader(org.apache.http.Header arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatHeader26846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatHeader26847;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._formatHeader26847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatHeader26847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _appendProtocolVersion26848;
		public virtual global::org.apache.http.util.CharArrayBuffer appendProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.ProtocolVersion arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._appendProtocolVersion26848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._appendProtocolVersion26848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatRequestLine26849;
		public static global::java.lang.String formatRequestLine(org.apache.http.RequestLine arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatRequestLine26849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatRequestLine26850;
		public virtual global::org.apache.http.util.CharArrayBuffer formatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._formatRequestLine26850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatRequestLine26850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatStatusLine26851;
		public virtual global::org.apache.http.util.CharArrayBuffer formatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._formatStatusLine26851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatStatusLine26851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatStatusLine26852;
		public static global::java.lang.String formatStatusLine(org.apache.http.StatusLine arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatStatusLine26852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _initBuffer26853;
		protected virtual global::org.apache.http.util.CharArrayBuffer initBuffer(org.apache.http.util.CharArrayBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._initBuffer26853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._initBuffer26853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatProtocolVersion26854;
		public static global::java.lang.String formatProtocolVersion(org.apache.http.ProtocolVersion arg0, org.apache.http.message.LineFormatter arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._formatProtocolVersion26854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateProtocolVersionLen26855;
		protected virtual int estimateProtocolVersionLen(org.apache.http.ProtocolVersion arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._estimateProtocolVersionLen26855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._estimateProtocolVersionLen26855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatRequestLine26856;
		protected virtual void doFormatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._doFormatRequestLine26856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._doFormatRequestLine26856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatStatusLine26857;
		protected virtual void doFormatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._doFormatStatusLine26857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._doFormatStatusLine26857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatHeader26858;
		protected virtual void doFormatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter._doFormatHeader26858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._doFormatHeader26858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicLineFormatter26859;
		public BasicLineFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._BasicLineFormatter26859);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT26860;
		public static global::org.apache.http.message.BasicLineFormatter DEFAULT
		{
			get
			{
				return default(global::org.apache.http.message.BasicLineFormatter);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicLineFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicLineFormatter"));
			global::org.apache.http.message.BasicLineFormatter._formatHeader26846 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatHeader", "(Lorg/apache/http/Header;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._formatHeader26847 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._appendProtocolVersion26848 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatRequestLine26849 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatRequestLine", "(Lorg/apache/http/RequestLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._formatRequestLine26850 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatStatusLine26851 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatStatusLine26852 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatStatusLine", "(Lorg/apache/http/StatusLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._initBuffer26853 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "initBuffer", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicLineFormatter._formatProtocolVersion26854 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatProtocolVersion", "(Lorg/apache/http/ProtocolVersion;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicLineFormatter._estimateProtocolVersionLen26855 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "estimateProtocolVersionLen", "(Lorg/apache/http/ProtocolVersion;)I");
			global::org.apache.http.message.BasicLineFormatter._doFormatRequestLine26856 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)V");
			global::org.apache.http.message.BasicLineFormatter._doFormatStatusLine26857 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)V");
			global::org.apache.http.message.BasicLineFormatter._doFormatHeader26858 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)V");
			global::org.apache.http.message.BasicLineFormatter._BasicLineFormatter26859 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "<init>", "()V");
		}
	}
}
