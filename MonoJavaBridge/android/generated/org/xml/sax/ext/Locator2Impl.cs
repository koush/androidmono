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
		internal static global::MonoJavaBridge.MethodId _getEncoding35143;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2Impl._getEncoding35143) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding35144;
		public virtual void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.Locator2Impl._setEncoding35144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getXMLVersion35145;
		public virtual global::java.lang.String getXMLVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "getXMLVersion", "()Ljava/lang/String;", ref global::org.xml.sax.ext.Locator2Impl._getXMLVersion35145) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setXMLVersion35146;
		public virtual void setXMLVersion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.ext.Locator2Impl.staticClass, "setXMLVersion", "(Ljava/lang/String;)V", ref global::org.xml.sax.ext.Locator2Impl._setXMLVersion35146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Locator2Impl35147;
		public Locator2Impl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Locator2Impl._Locator2Impl35147.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Locator2Impl._Locator2Impl35147 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2Impl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Locator2Impl.staticClass, global::org.xml.sax.ext.Locator2Impl._Locator2Impl35147);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locator2Impl35148;
		public Locator2Impl(org.xml.sax.Locator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.ext.Locator2Impl._Locator2Impl35148.native == global::System.IntPtr.Zero)
				global::org.xml.sax.ext.Locator2Impl._Locator2Impl35148 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ext.Locator2Impl.staticClass, "<init>", "(Lorg/xml/sax/Locator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.ext.Locator2Impl.staticClass, global::org.xml.sax.ext.Locator2Impl._Locator2Impl35148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
