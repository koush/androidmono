namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXParseException : org.xml.sax.SAXException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getLineNumber35039;
		public virtual int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._getLineNumber35039.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._getLineNumber35039 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getLineNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getLineNumber35039);
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId35040;
		public virtual global::java.lang.String getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._getPublicId35040.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._getPublicId35040 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getPublicId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getPublicId35040) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId35041;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._getSystemId35041.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._getSystemId35041 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getSystemId35041) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35042;
		public virtual int getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._getColumnNumber35042.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._getColumnNumber35042 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "getColumnNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._getColumnNumber35042);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException35043;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._SAXParseException35043.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._SAXParseException35043 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException35043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException35044;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1, java.lang.Exception arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._SAXParseException35044.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._SAXParseException35044 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException35044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException35045;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._SAXParseException35045.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._SAXParseException35045 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException35045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXParseException35046;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, java.lang.Exception arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._SAXParseException35046.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._SAXParseException35046 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._SAXParseException35046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static SAXParseException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXParseException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXParseException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
