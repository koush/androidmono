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
		internal static global::MonoJavaBridge.MethodId _getLineNumber35203;
		public virtual int getLineNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._getLineNumber35203.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._getLineNumber35203 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getLineNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getLineNumber35203);
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
		internal static global::MonoJavaBridge.MethodId _getPublicId35204;
		public virtual global::java.lang.String getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._getPublicId35204.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._getPublicId35204 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getPublicId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getPublicId35204) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId35205;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._getSystemId35205.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._getSystemId35205 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getSystemId35205) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getColumnNumber35206;
		public virtual int getColumnNumber()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._getColumnNumber35206.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._getColumnNumber35206 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "getColumnNumber", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._getColumnNumber35206);
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber35207;
		public virtual void setLineNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._setLineNumber35207.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._setLineNumber35207 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setLineNumber", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setLineNumber35207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId35208;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._setSystemId35208.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._setSystemId35208 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setSystemId35208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId35209;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._setPublicId35209.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._setPublicId35209 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setPublicId35209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnNumber35210;
		public virtual void setColumnNumber(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._setColumnNumber35210.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._setColumnNumber35210 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "setColumnNumber", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._setColumnNumber35210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LocatorImpl35211;
		public LocatorImpl() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35211.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35211 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35211);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LocatorImpl35212;
		public LocatorImpl(org.xml.sax.Locator arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35212.native == global::System.IntPtr.Zero)
				global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35212 = @__env.GetMethodIDNoThrow(global::org.xml.sax.helpers.LocatorImpl.staticClass, "<init>", "(Lorg/xml/sax/Locator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.helpers.LocatorImpl.staticClass, global::org.xml.sax.helpers.LocatorImpl._LocatorImpl35212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
