namespace javax.xml.transform.stream
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamSource : java.lang.Object, Source
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
			set
			{
				setInputStream(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream31163;
		public virtual global::java.io.InputStream getInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._getInputStream31163.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._getInputStream31163 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getInputStream31163) as java.io.InputStream;
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
		internal static global::MonoJavaBridge.MethodId _getPublicId31164;
		public virtual global::java.lang.String getPublicId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._getPublicId31164.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._getPublicId31164 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getPublicId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getPublicId31164) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId31165;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._getSystemId31165.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._getSystemId31165 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getSystemId31165) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setInputStream31166;
		public virtual void setInputStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._setInputStream31166.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._setInputStream31166 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setInputStream", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setInputStream31166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31167;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._setSystemId31167.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._setSystemId31167 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setSystemId31167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31168;
		public virtual void setSystemId(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._setSystemId31168.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._setSystemId31168 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setSystemId", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setSystemId31168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId31169;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._setPublicId31169.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._setPublicId31169 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setPublicId31169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.io.Reader Reader
		{
			get
			{
				return getReader();
			}
			set
			{
				setReader(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReader31170;
		public virtual global::java.io.Reader getReader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._getReader31170.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._getReader31170 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "getReader", "()Ljava/io/Reader;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._getReader31170) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setReader31171;
		public virtual void setReader(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._setReader31171.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._setReader31171 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "setReader", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._setReader31171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31172;
		public StreamSource(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31172.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31172 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31173;
		public StreamSource(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31173.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31173 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31174;
		public StreamSource(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31174.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31174 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31175;
		public StreamSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31175.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31175 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31175);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31176;
		public StreamSource(java.io.Reader arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31176.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31176 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/Reader;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31177;
		public StreamSource(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31177.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31177 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamSource31178;
		public StreamSource(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._StreamSource31178.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._StreamSource31178 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._StreamSource31178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.stream.StreamSource/feature";
			}
		}
		static StreamSource()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.stream.StreamSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/stream/StreamSource"));
		}
		internal static void InitJNI()
		{
		}
	}
}
