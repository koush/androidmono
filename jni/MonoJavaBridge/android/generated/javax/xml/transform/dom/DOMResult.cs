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
		internal static global::MonoJavaBridge.MethodId _getNextSibling24449;
		public virtual global::org.w3c.dom.Node getNextSibling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getNextSibling24449)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getNextSibling24449)) as org.w3c.dom.Node;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId24450;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getSystemId24450)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getSystemId24450)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getNode24451;
		public virtual global::org.w3c.dom.Node getNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._getNode24451)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._getNode24451)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId24452;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setSystemId24452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setSystemId24452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNode24453;
		public virtual void setNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setNode24453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setNode24453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNextSibling24454;
		public virtual void setNextSibling(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult._setNextSibling24454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._setNextSibling24454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult24455;
		public DOMResult(org.w3c.dom.Node arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult24455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult24456;
		public DOMResult(org.w3c.dom.Node arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult24456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult24457;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult24457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult24458;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult24458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMResult24459;
		public DOMResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._DOMResult24459);
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
			global::javax.xml.transform.dom.DOMResult._getNextSibling24449 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMResult._getSystemId24450 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMResult._getNode24451 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "getNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMResult._setSystemId24452 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._setNode24453 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._setNextSibling24454 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "setNextSibling", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult24455 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult24456 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult24457 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult24458 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMResult._DOMResult24459 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "()V");
		}
	}
}
