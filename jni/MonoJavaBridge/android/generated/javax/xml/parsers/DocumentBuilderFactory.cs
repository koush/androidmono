namespace javax.xml.parsers
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.parsers.DocumentBuilderFactory_))]
	public abstract partial class DocumentBuilderFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilderFactory()
		{
			InitJNI();
		}
		protected DocumentBuilderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30735;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._newInstance30735)) as javax.xml.parsers.DocumentBuilderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30736;
		public static global::javax.xml.parsers.DocumentBuilderFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._newInstance30736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.parsers.DocumentBuilderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30737;
		public abstract global::java.lang.Object getAttribute(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setFeature30738;
		public abstract void setFeature(java.lang.String arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _getFeature30739;
		public abstract bool getFeature(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _setAttribute30740;
		public abstract void setAttribute(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isNamespaceAware30741;
		public virtual bool isNamespaceAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30741);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30741);
		}
		internal static global::MonoJavaBridge.MethodId _isValidating30742;
		public virtual bool isValidating() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isValidating30742);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isValidating30742);
		}
		internal static global::MonoJavaBridge.MethodId _getSchema30743;
		public virtual global::javax.xml.validation.Schema getSchema() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._getSchema30743)) as javax.xml.validation.Schema;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._getSchema30743)) as javax.xml.validation.Schema;
		}
		internal static global::MonoJavaBridge.MethodId _isXIncludeAware30744;
		public virtual bool isXIncludeAware() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30744);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30744);
		}
		internal static global::MonoJavaBridge.MethodId _newDocumentBuilder30745;
		public abstract global::javax.xml.parsers.DocumentBuilder newDocumentBuilder();
		internal static global::MonoJavaBridge.MethodId _setNamespaceAware30746;
		public virtual void setNamespaceAware(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setValidating30747;
		public virtual void setValidating(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setValidating30747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setValidating30747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoringElementContentWhitespace30748;
		public virtual void setIgnoringElementContentWhitespace(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setExpandEntityReferences30749;
		public virtual void setExpandEntityReferences(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoringComments30750;
		public virtual void setIgnoringComments(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCoalescing30751;
		public virtual void setCoalescing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isIgnoringElementContentWhitespace30752;
		public virtual bool isIgnoringElementContentWhitespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30752);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30752);
		}
		internal static global::MonoJavaBridge.MethodId _isExpandEntityReferences30753;
		public virtual bool isExpandEntityReferences() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30753);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30753);
		}
		internal static global::MonoJavaBridge.MethodId _isIgnoringComments30754;
		public virtual bool isIgnoringComments() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30754);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30754);
		}
		internal static global::MonoJavaBridge.MethodId _isCoalescing30755;
		public virtual bool isCoalescing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30755);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30755);
		}
		internal static global::MonoJavaBridge.MethodId _setSchema30756;
		public virtual void setSchema(javax.xml.validation.Schema arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setSchema30756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setSchema30756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setXIncludeAware30757;
		public virtual void setXIncludeAware(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DocumentBuilderFactory30758;
		protected DocumentBuilderFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.parsers.DocumentBuilderFactory.staticClass, global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30758);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilderFactory"));
			global::javax.xml.parsers.DocumentBuilderFactory._newInstance30735 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "()Ljavax/xml/parsers/DocumentBuilderFactory;");
			global::javax.xml.parsers.DocumentBuilderFactory._newInstance30736 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/parsers/DocumentBuilderFactory;");
			global::javax.xml.parsers.DocumentBuilderFactory._getAttribute30737 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.DocumentBuilderFactory._setFeature30738 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._getFeature30739 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.DocumentBuilderFactory._setAttribute30740 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.DocumentBuilderFactory._isNamespaceAware30741 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isNamespaceAware", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isValidating30742 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isValidating", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._getSchema30743 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "getSchema", "()Ljavax/xml/validation/Schema;");
			global::javax.xml.parsers.DocumentBuilderFactory._isXIncludeAware30744 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isXIncludeAware", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._newDocumentBuilder30745 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;");
			global::javax.xml.parsers.DocumentBuilderFactory._setNamespaceAware30746 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setNamespaceAware", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setValidating30747 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setValidating", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringElementContentWhitespace30748 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringElementContentWhitespace", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setExpandEntityReferences30749 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setExpandEntityReferences", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setIgnoringComments30750 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setIgnoringComments", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setCoalescing30751 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setCoalescing", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringElementContentWhitespace30752 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringElementContentWhitespace", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isExpandEntityReferences30753 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isExpandEntityReferences", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isIgnoringComments30754 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isIgnoringComments", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._isCoalescing30755 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "isCoalescing", "()Z");
			global::javax.xml.parsers.DocumentBuilderFactory._setSchema30756 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setSchema", "(Ljavax/xml/validation/Schema;)V");
			global::javax.xml.parsers.DocumentBuilderFactory._setXIncludeAware30757 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "setXIncludeAware", "(Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory._DocumentBuilderFactory30758 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.parsers.DocumentBuilderFactory))]
	public sealed partial class DocumentBuilderFactory_ : javax.xml.parsers.DocumentBuilderFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DocumentBuilderFactory_()
		{
			InitJNI();
		}
		internal DocumentBuilderFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute30759;
		public override global::java.lang.Object getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setFeature30760;
		public override void setFeature(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFeature30761;
		public override bool getFeature(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute30762;
		public override void setAttribute(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newDocumentBuilder30763;
		public override global::javax.xml.parsers.DocumentBuilder newDocumentBuilder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30763)) as javax.xml.parsers.DocumentBuilder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30763)) as javax.xml.parsers.DocumentBuilder;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.parsers.DocumentBuilderFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/parsers/DocumentBuilderFactory"));
			global::javax.xml.parsers.DocumentBuilderFactory_._getAttribute30759 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.xml.parsers.DocumentBuilderFactory_._setFeature30760 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setFeature", "(Ljava/lang/String;Z)V");
			global::javax.xml.parsers.DocumentBuilderFactory_._getFeature30761 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "getFeature", "(Ljava/lang/String;)Z");
			global::javax.xml.parsers.DocumentBuilderFactory_._setAttribute30762 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.xml.parsers.DocumentBuilderFactory_._newDocumentBuilder30763 = @__env.GetMethodIDNoThrow(global::javax.xml.parsers.DocumentBuilderFactory_.staticClass, "newDocumentBuilder", "()Ljavax/xml/parsers/DocumentBuilder;");
		}
	}
}
