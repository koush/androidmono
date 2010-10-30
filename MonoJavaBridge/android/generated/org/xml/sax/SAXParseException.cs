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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.SAXParseException.staticClass, "getLineNumber", "()I", ref global::org.xml.sax.SAXParseException._m0);
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.SAXParseException.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.xml.sax.SAXParseException._m1) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.SAXParseException.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.xml.sax.SAXParseException._m2) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.SAXParseException.staticClass, "getColumnNumber", "()I", ref global::org.xml.sax.SAXParseException._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._m4.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._m4 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SAXParseException(java.lang.String arg0, org.xml.sax.Locator arg1, java.lang.Exception arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._m5.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._m5 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Lorg/xml/sax/Locator;Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._m6.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._m6 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SAXParseException(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, int arg4, java.lang.Exception arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXParseException._m7.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXParseException._m7 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXParseException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXParseException.staticClass, global::org.xml.sax.SAXParseException._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
