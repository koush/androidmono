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
		internal static global::MonoJavaBridge.MethodId _comment34993;
		public virtual void comment(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._comment34993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._comment34993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startCDATA34994;
		public virtual void startCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._startCDATA34994);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._startCDATA34994);
		}
		internal static global::MonoJavaBridge.MethodId _endCDATA34995;
		public virtual void endCDATA() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._endCDATA34995);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._endCDATA34995);
		}
		internal static global::MonoJavaBridge.MethodId _startEntity34996;
		public virtual void startEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._startEntity34996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._startEntity34996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endEntity34997;
		public virtual void endEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._endEntity34997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._endEntity34997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startDTD34998;
		public virtual void startDTD(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._startDTD34998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._startDTD34998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endDTD34999;
		public virtual void endDTD() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._endDTD34999);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._endDTD34999);
		}
		internal static global::MonoJavaBridge.MethodId _elementDecl35000;
		public virtual void elementDecl(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._elementDecl35000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._elementDecl35000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attributeDecl35001;
		public virtual void attributeDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._attributeDecl35001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._attributeDecl35001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _internalEntityDecl35002;
		public virtual void internalEntityDecl(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl35002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl35002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _externalEntityDecl35003;
		public virtual void externalEntityDecl(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl35003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl35003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity35004;
		public virtual global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._resolveEntity35004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._resolveEntity35004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _resolveEntity35005;
		public override global::org.xml.sax.InputSource resolveEntity(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._resolveEntity35005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._resolveEntity35005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _getExternalSubset35006;
		public virtual global::org.xml.sax.InputSource getExternalSubset(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2._getExternalSubset35006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._getExternalSubset35006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.xml.sax.InputSource;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHandler235007;
		public DefaultHandler2()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.DefaultHandler2.staticClass, global::org.xml.sax.ext.DefaultHandler2._DefaultHandler235007);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.DefaultHandler2.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/DefaultHandler2"));
			global::org.xml.sax.ext.DefaultHandler2._comment34993 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "comment", "([CII)V");
			global::org.xml.sax.ext.DefaultHandler2._startCDATA34994 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "startCDATA", "()V");
			global::org.xml.sax.ext.DefaultHandler2._endCDATA34995 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "endCDATA", "()V");
			global::org.xml.sax.ext.DefaultHandler2._startEntity34996 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "startEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._endEntity34997 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "endEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._startDTD34998 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "startDTD", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._endDTD34999 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "endDTD", "()V");
			global::org.xml.sax.ext.DefaultHandler2._elementDecl35000 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "elementDecl", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._attributeDecl35001 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "attributeDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._internalEntityDecl35002 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "internalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._externalEntityDecl35003 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "externalEntityDecl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ext.DefaultHandler2._resolveEntity35004 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.DefaultHandler2._resolveEntity35005 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "resolveEntity", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.DefaultHandler2._getExternalSubset35006 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "getExternalSubset", "(Ljava/lang/String;Ljava/lang/String;)Lorg/xml/sax/InputSource;");
			global::org.xml.sax.ext.DefaultHandler2._DefaultHandler235007 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.DefaultHandler2.staticClass, "<init>", "()V");
		}
	}
}
