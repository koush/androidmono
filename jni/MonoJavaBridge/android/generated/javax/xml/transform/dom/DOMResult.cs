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
		internal static global::MonoJavaBridge.MethodId _getNextSibling31045;
		public virtual global::org.w3c.dom.Node getNextSibling()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getNextSibling31045)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getNextSibling31045)) as org.w3c.dom.Node;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId31046;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getSystemId31046)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getSystemId31046)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getNode31047;
		public virtual global::org.w3c.dom.Node getNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getNode31047)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getNode31047)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31048;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setSystemId31048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setSystemId31048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNode31049;
		public virtual void setNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setNode31049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setNode31049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNextSibling31050;
		public virtual void setNextSibling(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setNextSibling31050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setNextSibling31050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult31051;
		public DOMResult(org.w3c.dom.Node arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult31051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult31052;
		public DOMResult(org.w3c.dom.Node arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult31052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult31053;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult31053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult31054;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult31054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult31055;
		public DOMResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult31055);
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
			global::javax.xml.transform.dom.DOMResult._getNextSibling31045 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMResult._getSystemId31046 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMResult._getNode31047 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMResult._setSystemId31048 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._setNode31049 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._setNextSibling31050 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setNextSibling", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult31051 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult31052 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult31053 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult31054 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult31055 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "()V");
		}
	}
}
