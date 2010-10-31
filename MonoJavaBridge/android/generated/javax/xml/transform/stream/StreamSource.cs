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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::javax.xml.transform.stream.StreamSource._m0) as java.io.InputStream;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.stream.StreamSource.staticClass, "getPublicId", "()Ljava/lang/String;", ref global::javax.xml.transform.stream.StreamSource._m1) as java.lang.String;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.stream.StreamSource.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.stream.StreamSource._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setInputStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "setInputStream", "(Ljava/io/InputStream;)V", ref global::javax.xml.transform.stream.StreamSource._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.stream.StreamSource._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setSystemId(java.io.File arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "setSystemId", "(Ljava/io/File;)V", ref global::javax.xml.transform.stream.StreamSource._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setPublicId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "setPublicId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.stream.StreamSource._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.io.Reader getReader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "getReader", "()Ljava/io/Reader;", ref global::javax.xml.transform.stream.StreamSource._m7) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setReader(java.io.Reader arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamSource.staticClass, "setReader", "(Ljava/io/Reader;)V", ref global::javax.xml.transform.stream.StreamSource._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public StreamSource(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m9.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m9 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public StreamSource(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m10.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m10 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public StreamSource(java.io.InputStream arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m11.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m11 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public StreamSource() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m12.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m12 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m12);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public StreamSource(java.io.Reader arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m13.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m13 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/Reader;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public StreamSource(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m14.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m14 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public StreamSource(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamSource._m15.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamSource._m15 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamSource.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamSource.staticClass, global::javax.xml.transform.stream.StreamSource._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}
}
