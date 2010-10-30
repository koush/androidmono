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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.xml.sax.ContentHandler getHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::javax.xml.transform.sax.SAXResult.staticClass, "getHandler", "()Lorg/xml/sax/ContentHandler;", ref global::javax.xml.transform.sax.SAXResult._m0) as org.xml.sax.ContentHandler;
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
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.sax.SAXResult.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.sax.SAXResult._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXResult.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.sax.SAXResult._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXResult.staticClass, "setHandler", "(Lorg/xml/sax/ContentHandler;)V", ref global::javax.xml.transform.sax.SAXResult._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setLexicalHandler(org.xml.sax.ext.LexicalHandler arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.sax.SAXResult.staticClass, "setLexicalHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V", ref global::javax.xml.transform.sax.SAXResult._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.xml.sax.ext.LexicalHandler getLexicalHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ext.LexicalHandler>(this, global::javax.xml.transform.sax.SAXResult.staticClass, "getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;", ref global::javax.xml.transform.sax.SAXResult._m5) as org.xml.sax.ext.LexicalHandler;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SAXResult(org.xml.sax.ContentHandler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._m6.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._m6 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "<init>", "(Lorg/xml/sax/ContentHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SAXResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.sax.SAXResult._m7.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.sax.SAXResult._m7 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._m7);
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
