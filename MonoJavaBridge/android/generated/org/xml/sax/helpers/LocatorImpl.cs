namespace org.xml.sax.helpers
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocatorImpl : java.lang.Object, Locator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocatorImpl(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
			set
			{
				setLineNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getLineNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "getLineNumber", "()I", ref global::org.xml.sax.helpers.LocatorImpl._m0);
		}
		public new global::java.lang.String PublicId
		{
			get
			{
				return getPublicId();
			}
			set
			{
				setPublicId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.xml.sax.helpers.LocatorImpl._m1) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.xml.sax.helpers.LocatorImpl._m2) as java.lang.String;
		}
		public new int ColumnNumber
		{
			get
			{
				return getColumnNumber();
			}
			set
			{
				setColumnNumber(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getColumnNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "getColumnNumber", "()I", ref global::org.xml.sax.helpers.LocatorImpl._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "setLineNumber", "(I)V", ref global::org.xml.sax.helpers.LocatorImpl._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.LocatorImpl._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "setPublicId", "(Ljava/lang/String;)V", ref global::org.xml.sax.helpers.LocatorImpl._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setColumnNumber(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, "setColumnNumber", "(I)V", ref global::org.xml.sax.helpers.LocatorImpl._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public LocatorImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._m8.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._m8 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._m8);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public LocatorImpl(org.xml.sax.Locator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._m9.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._m9 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "<init>", "(Lorg/xml/sax/Locator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LocatorImpl()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.helpers.LocatorImpl.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/helpers/LocatorImpl"));
		}
		internal static void InitJNI()
		{
		}
	}
}
