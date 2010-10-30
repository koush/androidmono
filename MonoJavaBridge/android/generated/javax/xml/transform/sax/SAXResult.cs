namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXResult : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.xml.sax.ContentHandler Handler
		{
			get
			{
				return getHandler();
			}
			set
			{
				setHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHandler31065;
		public virtual global::org.xml.sax.ContentHandler getHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._getHandler31065.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._getHandler31065 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "getHandler", "()Lorg/xml/sax/ContentHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._getHandler31065) as org.xml.sax.ContentHandler;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
			set
			{
				setSystemId(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId31066;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._getSystemId31066.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._getSystemId31066 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._getSystemId31066) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31067;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._setSystemId31067.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._setSystemId31067 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._setSystemId31067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandler31068;
		public virtual void setHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._setHandler31068.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._setHandler31068 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "setHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._setHandler31068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLexicalHandler31069;
		public virtual void setLexicalHandler(org.xml.sax.ext.LexicalHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._setLexicalHandler31069.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._setLexicalHandler31069 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "setLexicalHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._setLexicalHandler31069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.ext.LexicalHandler LexicalHandler
		{
			get
			{
				return getLexicalHandler();
			}
			set
			{
				setLexicalHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLexicalHandler31070;
		public virtual global::org.xml.sax.ext.LexicalHandler getLexicalHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._getLexicalHandler31070.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._getLexicalHandler31070 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ext.LexicalHandler>(this, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._getLexicalHandler31070) as org.xml.sax.ext.LexicalHandler;
		}
		internal static global::MonoJavaBridge.MethodId _SAXResult31071;
		public SAXResult(org.xml.sax.ContentHandler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._SAXResult31071.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._SAXResult31071 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "<init>", "(Lorg/xml/sax/ContentHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._SAXResult31071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXResult31072;
		public SAXResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._SAXResult31072.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._SAXResult31072 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._SAXResult31072);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXResult/feature";
			}
		}
		static SAXResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXResult"));
		}
		internal static void InitJNI()
		{
		}
	}
}
