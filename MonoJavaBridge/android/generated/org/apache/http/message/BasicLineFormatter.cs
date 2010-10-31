namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicLineFormatter : java.lang.Object, LineFormatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicLineFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String formatHeader(org.apache.http.Header arg0, org.apache.http.message.LineFormatter arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineFormatter._m0.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineFormatter._m0 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatHeader", "(Lorg/apache/http/Header;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "formatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicLineFormatter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.apache.http.util.CharArrayBuffer appendProtocolVersion(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.ProtocolVersion arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "appendProtocolVersion", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/ProtocolVersion;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicLineFormatter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.String formatRequestLine(org.apache.http.RequestLine arg0, org.apache.http.message.LineFormatter arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineFormatter._m3.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineFormatter._m3 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatRequestLine", "(Lorg/apache/http/RequestLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::org.apache.http.util.CharArrayBuffer formatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "formatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicLineFormatter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.util.CharArrayBuffer formatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "formatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicLineFormatter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String formatStatusLine(org.apache.http.StatusLine arg0, org.apache.http.message.LineFormatter arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineFormatter._m6.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineFormatter._m6 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatStatusLine", "(Lorg/apache/http/StatusLine;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual global::org.apache.http.util.CharArrayBuffer initBuffer(org.apache.http.util.CharArrayBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "initBuffer", "(Lorg/apache/http/util/CharArrayBuffer;)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicLineFormatter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String formatProtocolVersion(org.apache.http.ProtocolVersion arg0, org.apache.http.message.LineFormatter arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineFormatter._m8.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineFormatter._m8 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "formatProtocolVersion", "(Lorg/apache/http/ProtocolVersion;Lorg/apache/http/message/LineFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual int estimateProtocolVersionLen(org.apache.http.ProtocolVersion arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "estimateProtocolVersionLen", "(Lorg/apache/http/ProtocolVersion;)I", ref global::org.apache.http.message.BasicLineFormatter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void doFormatRequestLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.RequestLine arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatRequestLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/RequestLine;)V", ref global::org.apache.http.message.BasicLineFormatter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void doFormatStatusLine(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.StatusLine arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatStatusLine", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/StatusLine;)V", ref global::org.apache.http.message.BasicLineFormatter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void doFormatHeader(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.Header arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicLineFormatter.staticClass, "doFormatHeader", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/Header;)V", ref global::org.apache.http.message.BasicLineFormatter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public BasicLineFormatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicLineFormatter._m13.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicLineFormatter._m13 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicLineFormatter.staticClass, global::org.apache.http.message.BasicLineFormatter._m13);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT7513;
		public static global::org.apache.http.message.BasicLineFormatter DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicLineFormatter.staticClass, _DEFAULT7513)) as org.apache.http.message.BasicLineFormatter;
			}
		}
		static BasicLineFormatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicLineFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicLineFormatter"));
			global::org.apache.http.message.BasicLineFormatter._DEFAULT7513 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicLineFormatter.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicLineFormatter;");
		}
	}
}
