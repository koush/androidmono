namespace javax.xml.transform.stream
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamResult : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StreamResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
			set
			{
				setOutputStream(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.stream.StreamResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::javax.xml.transform.stream.StreamResult._m0) as java.io.OutputStream;
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.stream.StreamResult.staticClass, "getSystemId", "()Ljava/lang/String;", ref global::javax.xml.transform.stream.StreamResult._m1) as java.lang.String;
		}
		public new global::java.io.Writer Writer
		{
			get
			{
				return getWriter();
			}
			set
			{
				setWriter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.io.Writer getWriter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.stream.StreamResult.staticClass, "getWriter", "()Ljava/io/Writer;", ref global::javax.xml.transform.stream.StreamResult._m2) as java.io.Writer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setOutputStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamResult.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V", ref global::javax.xml.transform.stream.StreamResult._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamResult.staticClass, "setSystemId", "(Ljava/lang/String;)V", ref global::javax.xml.transform.stream.StreamResult._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setSystemId(java.io.File arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamResult.staticClass, "setSystemId", "(Ljava/io/File;)V", ref global::javax.xml.transform.stream.StreamResult._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setWriter(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.stream.StreamResult.staticClass, "setWriter", "(Ljava/io/Writer;)V", ref global::javax.xml.transform.stream.StreamResult._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public StreamResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamResult._m7.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamResult._m7 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._m7);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public StreamResult(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamResult._m8.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamResult._m8 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public StreamResult(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamResult._m9.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamResult._m9 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public StreamResult(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamResult._m10.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamResult._m10 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public StreamResult(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.stream.StreamResult._m11.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.stream.StreamResult._m11 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/File;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.stream.StreamResult/feature";
			}
		}
		static StreamResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.stream.StreamResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/stream/StreamResult"));
		}
	}
}
