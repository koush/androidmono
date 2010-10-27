namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeaderValueFormatter : java.lang.Object, HeaderValueFormatter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHeaderValueFormatter()
		{
			InitJNI();
		}
		protected BasicHeaderValueFormatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _formatElements33535;
		public virtual global::org.apache.http.util.CharArrayBuffer formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatElements33536;
		public static global::java.lang.String formatElements(org.apache.http.HeaderElement[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateElementsLen33537;
		protected virtual int estimateElementsLen(org.apache.http.HeaderElement[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen33537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen33537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement33538;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement33539;
		public static global::java.lang.String formatHeaderElement(org.apache.http.HeaderElement arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateHeaderElementLen33540;
		protected virtual int estimateHeaderElementLen(org.apache.http.HeaderElement arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen33540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen33540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters33541;
		public virtual global::org.apache.http.util.CharArrayBuffer formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters33542;
		public static global::java.lang.String formatParameters(org.apache.http.NameValuePair[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateParametersLen33543;
		protected virtual int estimateParametersLen(org.apache.http.NameValuePair[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen33543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen33543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair33544;
		public virtual global::org.apache.http.util.CharArrayBuffer formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair33545;
		public static global::java.lang.String formatNameValuePair(org.apache.http.NameValuePair arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateNameValuePairLen33546;
		protected virtual int estimateNameValuePairLen(org.apache.http.NameValuePair arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen33546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen33546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatValue33547;
		protected virtual void doFormatValue(org.apache.http.util.CharArrayBuffer arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue33547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue33547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSeparator33548;
		protected virtual bool isSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator33548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator33548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnsafe33549;
		protected virtual bool isUnsafe(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe33549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe33549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderValueFormatter33550;
		public BasicHeaderValueFormatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._BasicHeaderValueFormatter33550);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT33551;
		public static global::org.apache.http.message.BasicHeaderValueFormatter DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, _DEFAULT33551)) as org.apache.http.message.BasicHeaderValueFormatter;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeaderValueFormatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeaderValueFormatter"));
			global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33535 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33536 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "([Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen33537 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateElementsLen", "([Lorg/apache/http/HeaderElement;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33538 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33539 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen33540 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateHeaderElementLen", "(Lorg/apache/http/HeaderElement;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33541 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33542 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "([Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen33543 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateParametersLen", "([Lorg/apache/http/NameValuePair;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33544 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33545 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen33546 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateNameValuePairLen", "(Lorg/apache/http/NameValuePair;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue33547 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "doFormatValue", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Z)V");
			global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator33548 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isSeparator", "(C)Z");
			global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe33549 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isUnsafe", "(C)Z");
			global::org.apache.http.message.BasicHeaderValueFormatter._BasicHeaderValueFormatter33550 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "<init>", "()V");
			global::org.apache.http.message.BasicHeaderValueFormatter._DEFAULT33551 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicHeaderValueFormatter;");
		}
	}
}
