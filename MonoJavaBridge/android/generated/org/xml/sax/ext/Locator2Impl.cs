namespace org.xml.sax.ext
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Locator2Impl : org.xml.sax.helpers.LocatorImpl, Locator2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Locator2Impl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Encoding
		{
			get
			{
				return getEncoding();
			}
			set
			{
				setEncoding(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2Impl._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.Locator2Impl._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String XMLVersion
		{
			get
			{
				return getXMLVersion();
			}
			set
			{
				setXMLVersion(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getXMLVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "getXMLVersion", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2Impl._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setXMLVersion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "setXMLVersion", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.Locator2Impl._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public Locator2Impl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Locator2Impl._m4.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Locator2Impl._m4 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2Impl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Locator2Impl.staticClass, global::org.xml.sax.ext.Locator2Impl._m4);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public Locator2Impl(org.xml.sax.Locator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Locator2Impl._m5.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Locator2Impl._m5 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2Impl.staticClass, "<init>", "(Lorg/xml/sax/Locator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Locator2Impl.staticClass, global::org.xml.sax.ext.Locator2Impl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Locator2Impl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ext.Locator2Impl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ext/Locator2Impl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
