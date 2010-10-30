namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DOMSource : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId31057;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._getSystemId31057)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getNode31058;
		public virtual global::org.w3c.dom.Node getNode()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._getNode31058)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31059;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._setSystemId31059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNode31060;
		public virtual void setNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._setNode31060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource31061;
		public DOMSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource31061);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource31062;
		public DOMSource(org.w3c.dom.Node arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource31062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource31063;
		public DOMSource(org.w3c.dom.Node arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource31063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.dom.DOMSource/feature";
			}
		}
		static DOMSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMSource"));
			global::javax.xml.transform.dom.DOMSource._getSystemId31057 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMSource._getNode31058 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "getNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMSource._setSystemId31059 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMSource._setNode31060 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMSource._DOMSource31061 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "()V");
			global::javax.xml.transform.dom.DOMSource._DOMSource31062 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMSource._DOMSource31063 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
