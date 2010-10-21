namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DOMResult : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMResult()
		{
			InitJNI();
		}
		protected DOMResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.w3c.dom.Node NextSibling
		{
			get
			{
				return getNextSibling();
			}
			set
			{
				setNextSibling(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextSibling30926;
		public virtual global::org.w3c.dom.Node getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getNextSibling30926)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getNextSibling30926)) as org.w3c.dom.Node;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId30927;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getSystemId30927)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getSystemId30927)) as java.lang.String;
		}
		public new global::org.w3c.dom.Node Node
		{
			get
			{
				return getNode();
			}
			set
			{
				setNode(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNode30928;
		public virtual global::org.w3c.dom.Node getNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getNode30928)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getNode30928)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId30929;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setSystemId30929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setSystemId30929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNode30930;
		public virtual void setNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setNode30930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setNode30930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNextSibling30931;
		public virtual void setNextSibling(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setNextSibling30931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setNextSibling30931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult30932;
		public DOMResult(org.w3c.dom.Node arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult30932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult30933;
		public DOMResult(org.w3c.dom.Node arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult30933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult30934;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult30934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult30935;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult30935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult30936;
		public DOMResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult30936);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.dom.DOMResult/feature";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMResult"));
			global::javax.xml.transform.dom.DOMResult._getNextSibling30926 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMResult._getSystemId30927 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMResult._getNode30928 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMResult._setSystemId30929 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._setNode30930 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._setNextSibling30931 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setNextSibling", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult30932 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult30933 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult30934 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult30935 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult30936 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "()V");
		}
	}
}
