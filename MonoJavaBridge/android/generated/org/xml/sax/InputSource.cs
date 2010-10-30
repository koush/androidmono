namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputSource : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InputSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
		internal static global::MonoJavaBridge.MethodId _getEncoding35002;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.xml.sax.InputSource._getEncoding35002) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding35003;
		public virtual void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::org.xml.sax.InputSource._setEncoding35003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPublicId35004;
		public virtual global::java.lang.String getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.xml.sax.InputSource._getPublicId35004) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId35005;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.xml.sax.InputSource._getSystemId35005) as java.lang.String;
		}
		public new global::java.io.Reader CharacterStream
		{
			get
			{
				return getCharacterStream();
			}
			set
			{
				setCharacterStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream35006;
		public virtual global::java.io.Reader getCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;", ref global::org.xml.sax.InputSource._getCharacterStream35006) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream35007;
		public virtual void setCharacterStream(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V", ref global::org.xml.sax.InputSource._setCharacterStream35007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId35008;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::org.xml.sax.InputSource._setSystemId35008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId35009;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V", ref global::org.xml.sax.InputSource._setPublicId35009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream35010;
		public virtual void setByteStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V", ref global::org.xml.sax.InputSource._setByteStream35010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.InputStream ByteStream
		{
			get
			{
				return getByteStream();
			}
			set
			{
				setByteStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getByteStream35011;
		public virtual global::java.io.InputStream getByteStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;", ref global::org.xml.sax.InputSource._getByteStream35011) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _InputSource35012;
		public InputSource(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._InputSource35012.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._InputSource35012 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource35012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource35013;
		public InputSource(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._InputSource35013.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._InputSource35013 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource35013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource35014;
		public InputSource(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._InputSource35014.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._InputSource35014 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource35014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource35015;
		public InputSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._InputSource35015.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._InputSource35015 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource35015);
			Init(@__env, handle);
		}
		static InputSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.InputSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/InputSource"));
		}
		internal static void InitJNI()
		{
		}
	}
}
