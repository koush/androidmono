namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHandler2 : org.xml.sax.helpers.DefaultHandler, LexicalHandler, DeclHandler, EntityResolver2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHandler2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _comment35112;
		public virtual void comment(char[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "comment", "([CII)V", ref global::org.xml.sax.ext.DefaultHandler2._comment35112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA35113;
		public virtual void startCDATA()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "startCDATA", "()V", ref global::org.xml.sax.ext.DefaultHandler2._startCDATA35113);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA35114;
		public virtual void endCDATA()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "endCDATA", "()V", ref global::org.xml.sax.ext.DefaultHandler2._endCDATA35114);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity35115;
		public virtual void startEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "startEntity", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._startEntity35115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity35116;
		public virtual void endEntity(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "endEntity", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._endEntity35116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD35117;
		public virtual void startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._startDTD35117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD35118;
		public virtual void endDTD()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "endDTD", "()V", ref global::org.xml.sax.ext.DefaultHandler2._endDTD35118);
		}
		internal static global::MonoJavaBridge.MethodId _elementDecl35119;
		public virtual void elementDecl(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._elementDecl35119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attributeDecl35120;
		public virtual void attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._attributeDecl35120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _internalEntityDecl35121;
		public virtual void internalEntityDecl(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl35121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _externalEntityDecl35122;
		public virtual void externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl35122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity35123;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.ext.DefaultHandler2._resolveEntity35123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity35124;
		public override global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.ext.DefaultHandler2._resolveEntity35124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalSubset35125;
		public virtual global::org.xml.sax.InputSource getExternalSubset(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.ext.DefaultHandler2.staticClass, "getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;", ref global::org.xml.sax.ext.DefaultHandler2._getExternalSubset35125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHandler235126;
		public DefaultHandler2() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.DefaultHandler2._DefaultHandler235126.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.DefaultHandler2._DefaultHandler235126 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._DefaultHandler235126);
			Init(@__env, handle);
		}
		static DefaultHandler2()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.DefaultHandler2.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/DefaultHandler2"));
		}
		internal static void InitJNI()
		{
		}
	}
}
