namespace javax.xml.transform.stream
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StreamResult : java.lang.Object, Result
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StreamResult()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getOutputStream24548;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._getOutputStream24548)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._getOutputStream24548)) as java.io.OutputStream;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId24549;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._getSystemId24549)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._getSystemId24549)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getWriter24550;
		public virtual global::java.io.Writer getWriter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._getWriter24550)) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._getWriter24550)) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _setOutputStream24551;
		public virtual void setOutputStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setOutputStream24551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setOutputStream24551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId24552;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setSystemId24552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setSystemId24552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId24553;
		public virtual void setSystemId(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setSystemId24553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setSystemId24553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWriter24554;
		public virtual void setWriter(java.io.Writer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setWriter24554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setWriter24554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult24555;
		public StreamResult()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult24555);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult24556;
		public StreamResult(java.io.OutputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult24556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult24557;
		public StreamResult(java.io.Writer arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult24557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult24558;
		public StreamResult(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult24558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult24559;
		public StreamResult(java.io.File arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult24559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String FEATURE
		{
			get
			{
				return "http://javax.xml.transform.stream.StreamResult/feature";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.stream.StreamResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/stream/StreamResult"));
			global::javax.xml.transform.stream.StreamResult._getOutputStream24548 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::javax.xml.transform.stream.StreamResult._getSystemId24549 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.stream.StreamResult._getWriter24550 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "getWriter", "()Ljava/io/Writer;");
			global::javax.xml.transform.stream.StreamResult._setOutputStream24551 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V");
			global::javax.xml.transform.stream.StreamResult._setSystemId24552 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamResult._setSystemId24553 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setSystemId", "(Ljava/io/File;)V");
			global::javax.xml.transform.stream.StreamResult._setWriter24554 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setWriter", "(Ljava/io/Writer;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult24555 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "()V");
			global::javax.xml.transform.stream.StreamResult._StreamResult24556 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult24557 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult24558 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult24559 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/File;)V");
		}
	}
}
