namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHandler2 : org.xml.sax.helpers.DefaultHandler, LexicalHandler, DeclHandler, EntityResolver2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DefaultHandler2()
		{
			InitJNI();
		}
		protected DefaultHandler2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _comment28242;
		public virtual void comment(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._comment28242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._comment28242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA28243;
		public virtual void startCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._startCDATA28243);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._startCDATA28243);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA28244;
		public virtual void endCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._endCDATA28244);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._endCDATA28244);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity28245;
		public virtual void startEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._startEntity28245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._startEntity28245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity28246;
		public virtual void endEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._endEntity28246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._endEntity28246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD28247;
		public virtual void startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._startDTD28247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._startDTD28247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD28248;
		public virtual void endDTD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._endDTD28248);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._endDTD28248);
		}
		internal static global::MonoJavaBridge.MethodId _elementDecl28249;
		public virtual void elementDecl(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._elementDecl28249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._elementDecl28249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attributeDecl28250;
		public virtual void attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._attributeDecl28250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._attributeDecl28250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _internalEntityDecl28251;
		public virtual void internalEntityDecl(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl28251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _externalEntityDecl28252;
		public virtual void externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl28252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl28252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28253;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._resolveEntity28253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._resolveEntity28253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity28254;
		public override global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._resolveEntity28254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._resolveEntity28254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalSubset28255;
		public virtual global::org.xml.sax.InputSource getExternalSubset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._getExternalSubset28255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._getExternalSubset28255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHandler228256;
		public DefaultHandler2()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._DefaultHandler228256);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.DefaultHandler2.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/DefaultHandler2"));
			global::org.xml.sax.ext.DefaultHandler2._comment28242 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "comment", "([CII)V");
			global::org.xml.sax.ext.DefaultHandler2._startCDATA28243 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "startCDATA", "()V");
			global::org.xml.sax.ext.DefaultHandler2._endCDATA28244 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "endCDATA", "()V");
			global::org.xml.sax.ext.DefaultHandler2._startEntity28245 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._endEntity28246 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._startDTD28247 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._endDTD28248 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "endDTD", "()V");
			global::org.xml.sax.ext.DefaultHandler2._elementDecl28249 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._attributeDecl28250 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl28251 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl28252 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._resolveEntity28253 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.DefaultHandler2._resolveEntity28254 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.DefaultHandler2._getExternalSubset28255 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.DefaultHandler2._DefaultHandler228256 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "<init>", "()V");
		}
	}
}
