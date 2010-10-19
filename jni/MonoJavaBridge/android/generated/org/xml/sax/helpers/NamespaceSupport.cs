namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NamespaceSupport : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NamespaceSupport()
		{
			InitJNI();
		}
		protected NamespaceSupport(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _reset28343;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._reset28343);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._reset28343);
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix28344;
		public virtual global::java.lang.String getPrefix(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getPrefix28344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getPrefix28344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURI28345;
		public virtual global::java.lang.String getURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getURI28345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getURI28345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _pushContext28346;
		public virtual void pushContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._pushContext28346);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._pushContext28346);
		}
		internal static global::MonoJavaBridge.MethodId _declarePrefix28347;
		public virtual bool declarePrefix(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._declarePrefix28347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._declarePrefix28347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _popContext28348;
		public virtual void popContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._popContext28348);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._popContext28348);
		}
		internal static global::MonoJavaBridge.MethodId _processName28349;
		public virtual global::java.lang.String[] processName(java.lang.String arg0, java.lang.String[] arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._processName28349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._processName28349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String[];
		}
		public new global::java.util.Enumeration Prefixes
		{
			get
			{
				return getPrefixes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes28350;
		public virtual global::java.util.Enumeration getPrefixes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes28350)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes28350)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes28351;
		public virtual global::java.util.Enumeration getPrefixes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes28351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getPrefixes28351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		public new global::java.util.Enumeration DeclaredPrefixes
		{
			get
			{
				return getDeclaredPrefixes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredPrefixes28352;
		public virtual global::java.util.Enumeration getDeclaredPrefixes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes28352)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes28352)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _setNamespaceDeclUris28353;
		public virtual void setNamespaceDeclUris(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris28353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris28353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNamespaceDeclUris28354;
		public virtual bool isNamespaceDeclUris() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris28354);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris28354);
		}
		internal static global::MonoJavaBridge.MethodId _NamespaceSupport28355;
		public NamespaceSupport()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.NamespaceSupport.staticClass, global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport28355);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.NamespaceSupport.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/NamespaceSupport"));
			global::org.xml.sax.helpers.NamespaceSupport._reset28343 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "reset", "()V");
			global::org.xml.sax.helpers.NamespaceSupport._getPrefix28344 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.NamespaceSupport._getURI28345 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getURI", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.xml.sax.helpers.NamespaceSupport._pushContext28346 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "pushContext", "()V");
			global::org.xml.sax.helpers.NamespaceSupport._declarePrefix28347 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "declarePrefix", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.xml.sax.helpers.NamespaceSupport._popContext28348 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "popContext", "()V");
			global::org.xml.sax.helpers.NamespaceSupport._processName28349 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "processName", "(Ljava/lang/String;[Ljava/lang/String;Z)[Ljava/lang/String;");
			global::org.xml.sax.helpers.NamespaceSupport._getPrefixes28350 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefixes", "()Ljava/util/Enumeration;");
			global::org.xml.sax.helpers.NamespaceSupport._getPrefixes28351 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getPrefixes", "(Ljava/lang/String;)Ljava/util/Enumeration;");
			global::org.xml.sax.helpers.NamespaceSupport._getDeclaredPrefixes28352 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "getDeclaredPrefixes", "()Ljava/util/Enumeration;");
			global::org.xml.sax.helpers.NamespaceSupport._setNamespaceDeclUris28353 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "setNamespaceDeclUris", "(Z)V");
			global::org.xml.sax.helpers.NamespaceSupport._isNamespaceDeclUris28354 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "isNamespaceDeclUris", "()Z");
			global::org.xml.sax.helpers.NamespaceSupport._NamespaceSupport28355 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.NamespaceSupport.staticClass, "<init>", "()V");
		}
	}
}
