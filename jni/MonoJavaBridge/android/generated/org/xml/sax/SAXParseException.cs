namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXParseException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXParseException()
		{
			InitJNI();
		}
		protected SAXParseException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber16531;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getLineNumber16531);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getLineNumber16531);
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId16532;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getPublicId16532)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getPublicId16532)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId16533;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getSystemId16533)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getSystemId16533)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber16534;
		public virtual int getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getColumnNumber16534);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getColumnNumber16534);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException16535;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException16535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException16536;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1, java.lang.Exception arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException16536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException16537;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException16537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException16538;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, java.lang.Exception arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException16538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXParseException"));
			global::org.xml.sax.SAXParseException._getLineNumber16531 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getLineNumber", "()I");
			global::org.xml.sax.SAXParseException._getPublicId16532 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.SAXParseException._getSystemId16533 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.SAXParseException._getColumnNumber16534 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getColumnNumber", "()I");
			global::org.xml.sax.SAXParseException._SAXParseException16535 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.SAXParseException._SAXParseException16536 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V");
			global::org.xml.sax.SAXParseException._SAXParseException16537 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V");
			global::org.xml.sax.SAXParseException._SAXParseException16538 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V");
		}
	}
}
