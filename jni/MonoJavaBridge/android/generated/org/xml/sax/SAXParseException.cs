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
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber28169;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getLineNumber28169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getLineNumber28169);
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId28170;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getPublicId28170)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getPublicId28170)) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId28171;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getSystemId28171)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getSystemId28171)) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber28172;
		public virtual int getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException._getColumnNumber28172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getColumnNumber28172);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException28173;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException28173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException28174;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1, java.lang.Exception arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException28174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException28175;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException28175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException28176;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, java.lang.Exception arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException28176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXParseException"));
			global::org.xml.sax.SAXParseException._getLineNumber28169 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getLineNumber", "()I");
			global::org.xml.sax.SAXParseException._getPublicId28170 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.SAXParseException._getSystemId28171 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.SAXParseException._getColumnNumber28172 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getColumnNumber", "()I");
			global::org.xml.sax.SAXParseException._SAXParseException28173 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.SAXParseException._SAXParseException28174 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V");
			global::org.xml.sax.SAXParseException._SAXParseException28175 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V");
			global::org.xml.sax.SAXParseException._SAXParseException28176 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V");
		}
	}
}
