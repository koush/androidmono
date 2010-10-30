namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderValueFormatter : java.lang.Object, HeaderValueFormatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeaderValueFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.apache.http.util.CharArrayBuffer formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicHeaderValueFormatter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String formatElements(org.apache.http.HeaderElement[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueFormatter._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueFormatter._m1 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "([Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected virtual int estimateElementsLen(org.apache.http.HeaderElement[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateElementsLen", "([Lorg/apache/http/HeaderElement;)I", ref global::org.apache.http.message.BasicHeaderValueFormatter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicHeaderValueFormatter._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.lang.String formatHeaderElement(org.apache.http.HeaderElement arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueFormatter._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueFormatter._m4 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int estimateHeaderElementLen(org.apache.http.HeaderElement arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateHeaderElementLen", "(Lorg/apache/http/HeaderElement;)I", ref global::org.apache.http.message.BasicHeaderValueFormatter._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::org.apache.http.util.CharArrayBuffer formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicHeaderValueFormatter._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.String formatParameters(org.apache.http.NameValuePair[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueFormatter._m7.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueFormatter._m7 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "([Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual int estimateParametersLen(org.apache.http.NameValuePair[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateParametersLen", "([Lorg/apache/http/NameValuePair;)I", ref global::org.apache.http.message.BasicHeaderValueFormatter._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::org.apache.http.util.CharArrayBuffer formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.util.CharArrayBuffer>(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;", ref global::org.apache.http.message.BasicHeaderValueFormatter._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as org.apache.http.util.CharArrayBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.String formatNameValuePair(org.apache.http.NameValuePair arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueFormatter._m10.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueFormatter._m10 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual int estimateNameValuePairLen(org.apache.http.NameValuePair arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateNameValuePairLen", "(Lorg/apache/http/NameValuePair;)I", ref global::org.apache.http.message.BasicHeaderValueFormatter._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual void doFormatValue(org.apache.http.util.CharArrayBuffer arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "doFormatValue", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Z)V", ref global::org.apache.http.message.BasicHeaderValueFormatter._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual bool isSeparator(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isSeparator", "(C)Z", ref global::org.apache.http.message.BasicHeaderValueFormatter._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual bool isUnsafe(char arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isUnsafe", "(C)Z", ref global::org.apache.http.message.BasicHeaderValueFormatter._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public BasicHeaderValueFormatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeaderValueFormatter._m15.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeaderValueFormatter._m15 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._m15);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT7509;
		public static global::org.apache.http.message.BasicHeaderValueFormatter DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, _DEFAULT7509)) as org.apache.http.message.BasicHeaderValueFormatter;
			}
		}
		public static global::java.lang.String SEPARATORS
		{
			get
			{
				return " ;,:@()<>\\\"/[]?={}	";
			}
		}
		public static global::java.lang.String UNSAFE_CHARS
		{
			get
			{
				return "\"\\";
			}
		}
		static BasicHeaderValueFormatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderValueFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderValueFormatter"));
			global::org.apache.http.message.BasicHeaderValueFormatter._DEFAULT7509 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicHeaderValueFormatter;");
		}
		internal static void InitJNI()
		{
		}
	}
}
