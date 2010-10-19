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
		internal static global::MonoJavaBridge.MethodId _formatElements26790;
		public virtual global::org.apache.http.util.CharArrayBuffer formatElements(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement[] arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements26790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements26790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatElements26791;
		public static global::java.lang.String formatElements(org.apache.http.HeaderElement[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatElements26791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateElementsLen26792;
		protected virtual int estimateElementsLen(org.apache.http.HeaderElement[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen26792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen26792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement26793;
		public virtual global::org.apache.http.util.CharArrayBuffer formatHeaderElement(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.HeaderElement arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement26793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement26793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatHeaderElement26794;
		public static global::java.lang.String formatHeaderElement(org.apache.http.HeaderElement arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement26794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateHeaderElementLen26795;
		protected virtual int estimateHeaderElementLen(org.apache.http.HeaderElement arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen26795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen26795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters26796;
		public virtual global::org.apache.http.util.CharArrayBuffer formatParameters(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair[] arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters26796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters26796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatParameters26797;
		public static global::java.lang.String formatParameters(org.apache.http.NameValuePair[] arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters26797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateParametersLen26798;
		protected virtual int estimateParametersLen(org.apache.http.NameValuePair[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen26798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen26798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair26799;
		public virtual global::org.apache.http.util.CharArrayBuffer formatNameValuePair(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.NameValuePair arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair26799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair26799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as org.apache.http.util.CharArrayBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _formatNameValuePair26800;
		public static global::java.lang.String formatNameValuePair(org.apache.http.NameValuePair arg0, bool arg1, org.apache.http.message.HeaderValueFormatter arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair26800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _estimateNameValuePairLen26801;
		protected virtual int estimateNameValuePairLen(org.apache.http.NameValuePair arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen26801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen26801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _doFormatValue26802;
		protected virtual void doFormatValue(org.apache.http.util.CharArrayBuffer arg0, java.lang.String arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue26802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue26802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSeparator26803;
		protected virtual bool isSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator26803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator26803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isUnsafe26804;
		protected virtual bool isUnsafe(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe26804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe26804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeaderValueFormatter26805;
		public BasicHeaderValueFormatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeaderValueFormatter.staticClass, global::org.apache.http.message.BasicHeaderValueFormatter._BasicHeaderValueFormatter26805);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT26806;
		public static global::org.apache.http.message.BasicHeaderValueFormatter DEFAULT
		{
			get
			{
				return default(global::org.apache.http.message.BasicHeaderValueFormatter);
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
			global::org.apache.http.message.BasicHeaderValueFormatter._formatElements26790 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatElements26791 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatElements", "([Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateElementsLen26792 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateElementsLen", "([Lorg/apache/http/HeaderElement;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement26793 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/HeaderElement;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatHeaderElement26794 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatHeaderElement", "(Lorg/apache/http/HeaderElement;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateHeaderElementLen26795 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateHeaderElementLen", "(Lorg/apache/http/HeaderElement;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters26796 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "(Lorg/apache/http/util/CharArrayBuffer;[Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatParameters26797 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatParameters", "([Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateParametersLen26798 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateParametersLen", "([Lorg/apache/http/NameValuePair;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair26799 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/NameValuePair;Z)Lorg/apache/http/util/CharArrayBuffer;");
			global::org.apache.http.message.BasicHeaderValueFormatter._formatNameValuePair26800 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "formatNameValuePair", "(Lorg/apache/http/NameValuePair;ZLorg/apache/http/message/HeaderValueFormatter;)Ljava/lang/String;");
			global::org.apache.http.message.BasicHeaderValueFormatter._estimateNameValuePairLen26801 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "estimateNameValuePairLen", "(Lorg/apache/http/NameValuePair;)I");
			global::org.apache.http.message.BasicHeaderValueFormatter._doFormatValue26802 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "doFormatValue", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Z)V");
			global::org.apache.http.message.BasicHeaderValueFormatter._isSeparator26803 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isSeparator", "(C)Z");
			global::org.apache.http.message.BasicHeaderValueFormatter._isUnsafe26804 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "isUnsafe", "(C)Z");
			global::org.apache.http.message.BasicHeaderValueFormatter._BasicHeaderValueFormatter26805 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeaderValueFormatter.staticClass, "<init>", "()V");
		}
	}
}
