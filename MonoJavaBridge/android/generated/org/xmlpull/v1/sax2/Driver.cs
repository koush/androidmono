namespace org.xmlpull.v1.sax2
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Driver : java.lang.Object, org.xml.sax.Locator, org.xml.sax.XMLReader, org.xml.sax.Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Driver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty35408;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._setProperty35408.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._setProperty35408 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setProperty35408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty35409;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getProperty35409.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getProperty35409 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getProperty35409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength35410;
		public virtual int getLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getLength35410.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getLength35410 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLength", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLength35410);
		}
		internal static global::MonoJavaBridge.MethodId _getValue35411;
		public virtual global::java.lang.String getValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getValue35411.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getValue35411 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue35411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35412;
		public virtual global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getValue35412.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getValue35412 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue35412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue35413;
		public virtual global::java.lang.String getValue(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getValue35413.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getValue35413 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue35413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35414;
		public virtual global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getType35414.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getType35414 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType35414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35415;
		public virtual global::java.lang.String getType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getType35415.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getType35415 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType35415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType35416;
		public virtual global::java.lang.String getType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getType35416.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getType35416 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType35416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber35417;
		public virtual int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getLineNumber35417.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getLineNumber35417 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLineNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLineNumber35417);
		}
		internal static global::MonoJavaBridge.MethodId _parse35418;
		public virtual void parse(org.xml.sax.InputSource arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._parse35418.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._parse35418 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parse35418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse35419;
		public virtual void parse(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._parse35419.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._parse35419 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parse", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parse35419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35420;
		public virtual int getIndex(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getIndex35420.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getIndex35420 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getIndex", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getIndex35420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex35421;
		public virtual int getIndex(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getIndex35421.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getIndex35421 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getIndex35421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.xml.sax.ContentHandler ContentHandler
		{
			get
			{
				return getContentHandler();
			}
			set
			{
				setContentHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentHandler35422;
		public virtual global::org.xml.sax.ContentHandler getContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getContentHandler35422.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getContentHandler35422 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getContentHandler35422) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _startElement35423;
		protected virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._startElement35423.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._startElement35423 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._startElement35423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId35424;
		public virtual global::java.lang.String getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getPublicId35424.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getPublicId35424 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getPublicId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getPublicId35424) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId35425;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getSystemId35425.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getSystemId35425 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getSystemId35425) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQName35426;
		public virtual global::java.lang.String getQName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getQName35426.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getQName35426 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getQName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getQName35426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName35427;
		public virtual global::java.lang.String getLocalName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getLocalName35427.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getLocalName35427 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLocalName35427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI35428;
		public virtual global::java.lang.String getURI(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getURI35428.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getURI35428 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getURI", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getURI35428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35429;
		public virtual int getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getColumnNumber35429.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getColumnNumber35429 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getColumnNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getColumnNumber35429);
		}
		internal static global::MonoJavaBridge.MethodId _setFeature35430;
		public virtual void setFeature(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._setFeature35430.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._setFeature35430 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setFeature35430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature35431;
		public virtual bool getFeature(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getFeature35431.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getFeature35431 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getFeature35431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver35432;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._setEntityResolver35432.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._setEntityResolver35432 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setEntityResolver35432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.EntityResolver EntityResolver
		{
			get
			{
				return getEntityResolver();
			}
			set
			{
				setEntityResolver(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEntityResolver35433;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getEntityResolver35433.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getEntityResolver35433 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.EntityResolver>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getEntityResolver35433) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler35434;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._setDTDHandler35434.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._setDTDHandler35434 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setDTDHandler35434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.DTDHandler DTDHandler
		{
			get
			{
				return getDTDHandler();
			}
			set
			{
				setDTDHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDTDHandler35435;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getDTDHandler35435.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getDTDHandler35435 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.DTDHandler>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getDTDHandler35435) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler35436;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._setContentHandler35436.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._setContentHandler35436 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setContentHandler35436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler35437;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._setErrorHandler35437.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._setErrorHandler35437 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setErrorHandler35437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.xml.sax.ErrorHandler ErrorHandler
		{
			get
			{
				return getErrorHandler();
			}
			set
			{
				setErrorHandler(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorHandler35438;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._getErrorHandler35438.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._getErrorHandler35438 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ErrorHandler>(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getErrorHandler35438) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _parseSubTree35439;
		public virtual void parseSubTree(org.xmlpull.v1.XmlPullParser arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._parseSubTree35439.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._parseSubTree35439 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parseSubTree", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parseSubTree35439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Driver35440;
		public Driver(org.xmlpull.v1.XmlPullParser arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._Driver35440.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._Driver35440 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "<init>", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._Driver35440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Driver35441;
		public Driver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xmlpull.v1.sax2.Driver._Driver35441.native == global::System.IntPtr.Zero)
				global::org.xmlpull.v1.sax2.Driver._Driver35441 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._Driver35441);
			Init(@__env, handle);
		}
		static Driver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.sax2.Driver.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/sax2/Driver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
