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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;", ref global::org.xml.sax.InputSource._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V", ref global::org.xml.sax.InputSource._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getPublicId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::org.xml.sax.InputSource._m2) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getSystemId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::org.xml.sax.InputSource._m3) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.io.Reader getCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;", ref global::org.xml.sax.InputSource._m4) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setCharacterStream(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V", ref global::org.xml.sax.InputSource._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::org.xml.sax.InputSource._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V", ref global::org.xml.sax.InputSource._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setByteStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V", ref global::org.xml.sax.InputSource._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.io.InputStream getByteStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;", ref global::org.xml.sax.InputSource._m9) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public InputSource(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._m10.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._m10 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public InputSource(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._m11.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._m11 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public InputSource(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._m12.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._m12 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public InputSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.InputSource._m13.native == global::System.IntPtr.Zero)
				global::org.xml.sax.InputSource._m13 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._m13);
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
