namespace javax.xml.transform.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXResult : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXResult()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getHandler31064;
		public virtual global::org.xml.sax.ContentHandler getHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult._getHandler31064)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._getHandler31064)) as org.xml.sax.ContentHandler;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId31065;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult._getSystemId31065)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._getSystemId31065)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31066;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult._setSystemId31066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._setSystemId31066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHandler31067;
		public virtual void setHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult._setHandler31067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._setHandler31067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLexicalHandler31068;
		public virtual void setLexicalHandler(org.xml.sax.ext.LexicalHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult._setLexicalHandler31068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._setLexicalHandler31068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getLexicalHandler31069;
		public virtual global::org.xml.sax.ext.LexicalHandler getLexicalHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ext.LexicalHandler>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult._getLexicalHandler31069)) as org.xml.sax.ext.LexicalHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ext.LexicalHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._getLexicalHandler31069)) as org.xml.sax.ext.LexicalHandler;
		}
		internal static global::MonoJavaBridge.MethodId _SAXResult31070;
		public SAXResult(org.xml.sax.ContentHandler arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._SAXResult31070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXResult31071;
		public SAXResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.sax.SAXResult.staticClass, global::javax.xml.transform.sax.SAXResult._SAXResult31071);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.sax.SAXResult/feature";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.sax.SAXResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/sax/SAXResult"));
			global::javax.xml.transform.sax.SAXResult._getHandler31064 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "getHandler", "()Lorg/xml/sax/ContentHandler;");
			global::javax.xml.transform.sax.SAXResult._getSystemId31065 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.sax.SAXResult._setSystemId31066 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.sax.SAXResult._setHandler31067 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "setHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.transform.sax.SAXResult._setLexicalHandler31068 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "setLexicalHandler", "(Lorg/xml/sax/ext/LexicalHandler;)V");
			global::javax.xml.transform.sax.SAXResult._getLexicalHandler31069 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "getLexicalHandler", "()Lorg/xml/sax/ext/LexicalHandler;");
			global::javax.xml.transform.sax.SAXResult._SAXResult31070 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "<init>", "(Lorg/xml/sax/ContentHandler;)V");
			global::javax.xml.transform.sax.SAXResult._SAXResult31071 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.sax.SAXResult.staticClass, "<init>", "()V");
		}
	}
}
