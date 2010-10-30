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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.dom.DOMSource.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.dom.DOMSource._m0) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::org.w3c.dom.Node getNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::javax.xml.transform.dom.DOMSource.staticClass, "getNode", "()Lorg/w3c/dom/Node;", ref global::javax.xml.transform.dom.DOMSource._m1) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMSource.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.dom.DOMSource._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMSource.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V", ref global::javax.xml.transform.dom.DOMSource._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public DOMSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMSource._m4.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMSource._m4 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public DOMSource(org.w3c.dom.Node arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMSource._m5.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMSource._m5 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public DOMSource(org.w3c.dom.Node arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMSource._m6.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMSource._m6 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMSource.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMSource.staticClass, global::javax.xml.transform.dom.DOMSource._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
		}
		internal static void InitJNI()
		{
		}
	}
}
