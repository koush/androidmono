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
		internal static global::MonoJavaBridge.MethodId _formatElements33417;
		public virtual global::org.apache.http.util.CharArrayBuffer formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatElements33418;
		public static global::java.lang.String formatElements(org.apache.http.HeaderElement[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateElementsLen33419;
		protected virtual int estimateElementsLen(org.apache.http.HeaderElement[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen33419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen33419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement33420;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement33421;
		public static global::java.lang.String formatHeaderElement(org.apache.http.HeaderElement arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateHeaderElementLen33422;
		protected virtual int estimateHeaderElementLen(org.apache.http.HeaderElement arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen33422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen33422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters33423;
		public virtual global::org.apache.http.util.CharArrayBuffer formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters33424;
		public static global::java.lang.String formatParameters(org.apache.http.NameValuePair[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateParametersLen33425;
		protected virtual int estimateParametersLen(org.apache.http.NameValuePair[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen33425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen33425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair33426;
		public virtual global::org.apache.http.util.CharArrayBuffer formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<org.apache.http.util.CharArrayBuffer>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair33427;
		public static global::java.lang.String formatNameValuePair(org.apache.http.NameValuePair arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateNameValuePairLen33428;
		protected virtual int estimateNameValuePairLen(org.apache.http.NameValuePair arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen33428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen33428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatValue33429;
		protected virtual void doFormatValue(org.apache.http.util.CharArrayBuffer arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue33429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue33429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSeparator33430;
		protected virtual bool isSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator33430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator33430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnsafe33431;
		protected virtual bool isUnsafe(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe33431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe33431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderValueFormatter33432;
		public BasicHeaderValueFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._BasicHeaderValueFormatter33432);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT33433;
		public static global::org.apache.http.message.BasicHeaderValueFormatter DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, _DEFAULT33433)) as org.apache.http.message.BasicHeaderValueFormatter;
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
			global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33417 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatElements33418 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "([Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen33419 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateElementsLen", "([Lorg/apache/http/HeaderElement;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33420 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement33421 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen33422 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateHeaderElementLen", "(Lorg/apache/http/HeaderElement;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33423 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters33424 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "([Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen33425 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateParametersLen", "([Lorg/apache/http/NameValuePair;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33426 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair33427 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen33428 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateNameValuePairLen", "(Lorg/apache/http/NameValuePair;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue33429 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "doFormatValue", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Z)V");
			global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator33430 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isSeparator", "(C)Z");
			global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe33431 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isUnsafe", "(C)Z");
			global::org.apache.http.message.BasicHeaderValueFormatter._BasicHeaderValueFormatter33432 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "<init>", "()V");
			global::org.apache.http.message.BasicHeaderValueFormatter._DEFAULT33433 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "DEFAULT", "Lorg/apache/http/message/BasicHeaderValueFormatter;");
		}
	}
}
