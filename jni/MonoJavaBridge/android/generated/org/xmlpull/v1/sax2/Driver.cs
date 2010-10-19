namespace org.xmlpull.v1.sax2
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Driver : java.lang.Object, org.xml.sax.Locator, org.xml.sax.XMLReader, org.xml.sax.Attributes
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Driver()
		{
			InitJNI();
		}
		protected Driver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setProperty28520;
		public virtual void setProperty(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setProperty28520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setProperty28520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getProperty28521;
		public virtual global::java.lang.Object getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getProperty28521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getProperty28521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength28522;
		public virtual int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getLength28522);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLength28522);
		}
		internal static global::MonoJavaBridge.MethodId _getValue28523;
		public virtual global::java.lang.String getValue(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getValue28523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue28523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28524;
		public virtual global::java.lang.String getValue(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getValue28524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue28524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getValue28525;
		public virtual global::java.lang.String getValue(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getValue28525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getValue28525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28526;
		public virtual global::java.lang.String getType(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getType28526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType28526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28527;
		public virtual global::java.lang.String getType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getType28527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType28527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getType28528;
		public virtual global::java.lang.String getType(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getType28528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getType28528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber28529;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getLineNumber28529);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLineNumber28529);
		}
		internal static global::MonoJavaBridge.MethodId _parse28530;
		public virtual void parse(org.xml.sax.InputSource arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._parse28530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parse28530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parse28531;
		public virtual void parse(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._parse28531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parse28531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28532;
		public virtual int getIndex(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getIndex28532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getIndex28532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIndex28533;
		public virtual int getIndex(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getIndex28533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getIndex28533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		internal static global::MonoJavaBridge.MethodId _getContentHandler28534;
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getContentHandler28534)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getContentHandler28534)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _startElement28535;
		protected virtual void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._startElement28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._startElement28535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId28536;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getPublicId28536)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getPublicId28536)) as java.lang.String;
		}
		public new global::java.lang.String SystemId
		{
			get
			{
				return getSystemId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId28537;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getSystemId28537)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getSystemId28537)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQName28538;
		public virtual global::java.lang.String getQName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getQName28538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getQName28538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalName28539;
		public virtual global::java.lang.String getLocalName(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getLocalName28539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getLocalName28539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI28540;
		public virtual global::java.lang.String getURI(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getURI28540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getURI28540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNumber28541;
		public virtual int getColumnNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getColumnNumber28541);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getColumnNumber28541);
		}
		internal static global::MonoJavaBridge.MethodId _setFeature28542;
		public virtual void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setFeature28542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setFeature28542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature28543;
		public virtual bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getFeature28543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getFeature28543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEntityResolver28544;
		public virtual void setEntityResolver(org.xml.sax.EntityResolver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setEntityResolver28544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setEntityResolver28544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getEntityResolver28545;
		public virtual global::org.xml.sax.EntityResolver getEntityResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getEntityResolver28545)) as org.xml.sax.EntityResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.EntityResolver>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getEntityResolver28545)) as org.xml.sax.EntityResolver;
		}
		internal static global::MonoJavaBridge.MethodId _setDTDHandler28546;
		public virtual void setDTDHandler(org.xml.sax.DTDHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setDTDHandler28546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setDTDHandler28546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getDTDHandler28547;
		public virtual global::org.xml.sax.DTDHandler getDTDHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getDTDHandler28547)) as org.xml.sax.DTDHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.DTDHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getDTDHandler28547)) as org.xml.sax.DTDHandler;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandler28548;
		public virtual void setContentHandler(org.xml.sax.ContentHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setContentHandler28548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setContentHandler28548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorHandler28549;
		public virtual void setErrorHandler(org.xml.sax.ErrorHandler arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._setErrorHandler28549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._setErrorHandler28549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getErrorHandler28550;
		public virtual global::org.xml.sax.ErrorHandler getErrorHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._getErrorHandler28550)) as org.xml.sax.ErrorHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ErrorHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._getErrorHandler28550)) as org.xml.sax.ErrorHandler;
		}
		internal static global::MonoJavaBridge.MethodId _parseSubTree28551;
		public virtual void parseSubTree(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver._parseSubTree28551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._parseSubTree28551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Driver28552;
		public Driver(org.xmlpull.v1.XmlPullParser arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._Driver28552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Driver28553;
		public Driver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xmlpull.v1.sax2.Driver.staticClass, global::org.xmlpull.v1.sax2.Driver._Driver28553);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xmlpull.v1.sax2.Driver.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xmlpull/v1/sax2/Driver"));
			global::org.xmlpull.v1.sax2.Driver._setProperty28520 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::org.xmlpull.v1.sax2.Driver._getProperty28521 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::org.xmlpull.v1.sax2.Driver._getLength28522 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLength", "()I");
			global::org.xmlpull.v1.sax2.Driver._getValue28523 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getValue28524 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getValue28525 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getValue", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getType28526 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getType28527 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getType28528 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getType", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getLineNumber28529 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLineNumber", "()I");
			global::org.xmlpull.v1.sax2.Driver._parse28530 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parse", "(Lorg/xml/sax/InputSource;)V");
			global::org.xmlpull.v1.sax2.Driver._parse28531 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parse", "(Ljava/lang/String;)V");
			global::org.xmlpull.v1.sax2.Driver._getIndex28532 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getIndex", "(Ljava/lang/String;)I");
			global::org.xmlpull.v1.sax2.Driver._getIndex28533 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getIndex", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::org.xmlpull.v1.sax2.Driver._getContentHandler28534 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::org.xmlpull.v1.sax2.Driver._startElement28535 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xmlpull.v1.sax2.Driver._getPublicId28536 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getSystemId28537 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getQName28538 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getQName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getLocalName28539 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getLocalName", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getURI28540 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getURI", "(I)Ljava/lang/String;");
			global::org.xmlpull.v1.sax2.Driver._getColumnNumber28541 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getColumnNumber", "()I");
			global::org.xmlpull.v1.sax2.Driver._setFeature28542 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::org.xmlpull.v1.sax2.Driver._getFeature28543 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::org.xmlpull.v1.sax2.Driver._setEntityResolver28544 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setEntityResolver", "(Lorg/xml/sax/EntityResolver;)V");
			global::org.xmlpull.v1.sax2.Driver._getEntityResolver28545 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getEntityResolver", "()Lorg/xml/sax/EntityResolver;");
			global::org.xmlpull.v1.sax2.Driver._setDTDHandler28546 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setDTDHandler", "(Lorg/xml/sax/DTDHandler;)V");
			global::org.xmlpull.v1.sax2.Driver._getDTDHandler28547 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getDTDHandler", "()Lorg/xml/sax/DTDHandler;");
			global::org.xmlpull.v1.sax2.Driver._setContentHandler28548 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setContentHandler", "(Lorg/xml/sax/ContentHandler;)V");
			global::org.xmlpull.v1.sax2.Driver._setErrorHandler28549 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "setErrorHandler", "(Lorg/xml/sax/ErrorHandler;)V");
			global::org.xmlpull.v1.sax2.Driver._getErrorHandler28550 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "getErrorHandler", "()Lorg/xml/sax/ErrorHandler;");
			global::org.xmlpull.v1.sax2.Driver._parseSubTree28551 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "parseSubTree", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::org.xmlpull.v1.sax2.Driver._Driver28552 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "<init>", "(Lorg/xmlpull/v1/XmlPullParser;)V");
			global::org.xmlpull.v1.sax2.Driver._Driver28553 = @__env.GetMethodIDNoThrow(global::org.xmlpull.v1.sax2.Driver.staticClass, "<init>", "()V");
		}
	}
}
