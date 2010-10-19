namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DOMSource : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DOMSource()
		{
			InitJNI();
		}
		protected DOMSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
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
		internal static global::MonoJavaBridge.MethodId _getSystemId24460;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._getSystemId24460)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._getSystemId24460)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getNode24461;
		public virtual global::org.w3c.dom.Node getNode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._getNode24461)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._getNode24461)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId24462;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._setSystemId24462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._setSystemId24462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNode24463;
		public virtual void setNode(org.w3c.dom.Node arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._setNode24463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._setNode24463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource24464;
		public DOMSource()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource24464);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource24465;
		public DOMSource(org.w3c.dom.Node arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource24465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource24466;
		public DOMSource(org.w3c.dom.Node arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource24466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.dom.DOMSource/feature";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMSource"));
			global::javax.xml.transform.dom.DOMSource._getSystemId24460 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMSource._getNode24461 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "getNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMSource._setSystemId24462 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMSource._setNode24463 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMSource._DOMSource24464 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "()V");
			global::javax.xml.transform.dom.DOMSource._DOMSource24465 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMSource._DOMSource24466 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
		}
	}
}
