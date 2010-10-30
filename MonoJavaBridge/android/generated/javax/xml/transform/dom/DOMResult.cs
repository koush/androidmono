namespace javax.xml.transform.dom
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DOMResult : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.w3c.dom.Node getNextSibling()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::javax.xml.transform.dom.DOMResult.staticClass, "getNextSibling", "()Lorg/w3c/dom/Node;", ref global::javax.xml.transform.dom.DOMResult._m0) as org.w3c.dom.Node;
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
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.dom.DOMResult.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.dom.DOMResult._m1) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::org.w3c.dom.Node getNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.w3c.dom.Node>(this, global::javax.xml.transform.dom.DOMResult.staticClass, "getNode", "()Lorg/w3c/dom/Node;", ref global::javax.xml.transform.dom.DOMResult._m2) as org.w3c.dom.Node;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMResult.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.dom.DOMResult._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setNode(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMResult.staticClass, "setNode", "(Lorg/w3c/dom/Node;)V", ref global::javax.xml.transform.dom.DOMResult._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setNextSibling(org.w3c.dom.Node arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.dom.DOMResult.staticClass, "setNextSibling", "(Lorg/w3c/dom/Node;)V", ref global::javax.xml.transform.dom.DOMResult._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public DOMResult(org.w3c.dom.Node arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMResult._m6.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMResult._m6 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public DOMResult(org.w3c.dom.Node arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMResult._m7.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMResult._m7 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMResult._m8.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMResult._m8 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public DOMResult(org.w3c.dom.Node arg0, org.w3c.dom.Node arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMResult._m9.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMResult._m9 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public DOMResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.dom.DOMResult._m10.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.dom.DOMResult._m10 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.dom.DOMResult.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.dom.DOMResult.staticClass, global::javax.xml.transform.dom.DOMResult._m10);
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.dom.DOMResult/feature";
			}
		}
		static DOMResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.dom.DOMResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/dom/DOMResult"));
		}
		internal static void InitJNI()
		{
		}
	}
}
