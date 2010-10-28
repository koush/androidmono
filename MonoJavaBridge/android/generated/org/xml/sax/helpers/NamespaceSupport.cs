namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NamespaceSupport : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NamespaceSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset35213;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._reset35213);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._reset35213);
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix35214;
		public virtual global::java.lang.String getPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getPrefix35214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getPrefix35214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI35215;
		public virtual global::java.lang.String getURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getURI35215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getURI35215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pushContext35216;
		public virtual void pushContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._pushContext35216);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._pushContext35216);
		}
		internal static global::MonoJavaBridge.MethodId _declarePrefix35217;
		public virtual bool declarePrefix(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._declarePrefix35217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._declarePrefix35217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _popContext35218;
		public virtual void popContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._popContext35218);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._popContext35218);
		}
		internal static global::MonoJavaBridge.MethodId _processName35219;
		public virtual global::java.lang.String[] processName(java.lang.String arg0, java.lang.String[] arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._processName35219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._processName35219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String[];
		}
		public new global::java.util.Enumeration Prefixes
		{
			get
			{
				return getPrefixes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes35220;
		public virtual global::java.util.Enumeration getPrefixes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35220)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35220)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes35221;
		public virtual global::java.util.Enumeration getPrefixes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		public new global::java.util.Enumeration DeclaredPrefixes
		{
			get
			{
				return getDeclaredPrefixes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredPrefixes35222;
		public virtual global::java.util.Enumeration getDeclaredPrefixes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes35222)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes35222)) as java.util.Enumeration;
		}
		public new bool NamespaceDeclUris
		{
			set
			{
				setNamespaceDeclUris(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceDeclUris35223;
		public virtual void setNamespaceDeclUris(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris35223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris35223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceDeclUris35224;
		public virtual bool isNamespaceDeclUris()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris35224);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris35224);
		}
		internal static global::MonoJavaBridge.MethodId _NamespaceSupport35225;
		public NamespaceSupport() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport35225);
			Init(@__env, handle);
		}
		public static global::java.lang.String XMLNS
		{
			get
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
		}
		public static global::java.lang.String NSDECL
		{
			get
			{
				return "http://www.w3.org/xmlns/2000/";
			}
		}
		static NamespaceSupport()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.NamespaceSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/NamespaceSupport"));
			global::org.xml.sax.helpers.NamespaceSupport._reset35213 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "reset", "()V");
			global::org.xml.sax.helpers.NamespaceSupport._getPrefix35214 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.NamespaceSupport._getURI35215 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.NamespaceSupport._pushContext35216 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "pushContext", "()V");
			global::org.xml.sax.helpers.NamespaceSupport._declarePrefix35217 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "declarePrefix", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.helpers.NamespaceSupport._popContext35218 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "popContext", "()V");
			global::org.xml.sax.helpers.NamespaceSupport._processName35219 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "processName", "(Ljava/lang/String;[Ljava/lang/String;Z)[Ljava/lang/String;");
			global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35220 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefixes", "()Ljava/util/Enumeration;");
			global::org.xml.sax.helpers.NamespaceSupport._getPrefixes35221 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefixes", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes35222 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getDeclaredPrefixes", "()Ljava/util/Enumeration;");
			global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris35223 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "setNamespaceDeclUris", "(Z)V");
			global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris35224 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "isNamespaceDeclUris", "()Z");
			global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport35225 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
