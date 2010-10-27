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
		internal static global::MonoJavaBridge.MethodId _getSystemId31056;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._getSystemId31056)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._getSystemId31056)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getNode31057;
		public virtual global::org.w3c.dom.Node getNode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._getNode31057)) as org.w3c.dom.Node;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.w3c.dom.Node>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._getNode31057)) as org.w3c.dom.Node;
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31058;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._setSystemId31058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._setSystemId31058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNode31059;
		public virtual void setNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource._setNode31059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._setNode31059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource31060;
		public DOMSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource31060);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource31061;
		public DOMSource(org.w3c.dom.Node arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource31061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DOMSource31062;
		public DOMSource(org.w3c.dom.Node arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._DOMSource31062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::javax.xml.transform.dom.DOMSource._getSystemId31056 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.dom.DOMSource._getNode31057 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "getNode", "()Lorg/w3c/dom/Node;");
			global::javax.xml.transform.dom.DOMSource._setSystemId31058 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.dom.DOMSource._setNode31059 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMSource._DOMSource31060 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "()V");
			global::javax.xml.transform.dom.DOMSource._DOMSource31061 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::javax.xml.transform.dom.DOMSource._DOMSource31062 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
		}
	}
}
