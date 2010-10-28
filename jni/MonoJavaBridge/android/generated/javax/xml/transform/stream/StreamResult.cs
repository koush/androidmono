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
		internal static global::MonoJavaBridge.MethodId _getOutputStream31150;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._getOutputStream31150)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._getOutputStream31150)) as java.io.OutputStream;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId31151;
		public virtual global::java.lang.String getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._getSystemId31151)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._getSystemId31151)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getWriter31152;
		public virtual global::java.io.Writer getWriter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._getWriter31152)) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._getWriter31152)) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _setOutputStream31153;
		public virtual void setOutputStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setOutputStream31153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setOutputStream31153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31154;
		public virtual void setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setSystemId31154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setSystemId31154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId31155;
		public virtual void setSystemId(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setSystemId31155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setSystemId31155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWriter31156;
		public virtual void setWriter(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult._setWriter31156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._setWriter31156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult31157;
		public StreamResult() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult31157);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult31158;
		public StreamResult(java.io.OutputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult31158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult31159;
		public StreamResult(java.io.Writer arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult31159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult31160;
		public StreamResult(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult31160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StreamResult31161;
		public StreamResult(java.io.File arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.stream.StreamResult.staticClass, global::javax.xml.transform.stream.StreamResult._StreamResult31161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::javax.xml.transform.stream.StreamResult._getOutputStream31150 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::javax.xml.transform.stream.StreamResult._getSystemId31151 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::javax.xml.transform.stream.StreamResult._getWriter31152 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "getWriter", "()Ljava/io/Writer;");
			global::javax.xml.transform.stream.StreamResult._setOutputStream31153 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setOutputStream", "(Ljava/io/OutputStream;)V");
			global::javax.xml.transform.stream.StreamResult._setSystemId31154 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamResult._setSystemId31155 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setSystemId", "(Ljava/io/File;)V");
			global::javax.xml.transform.stream.StreamResult._setWriter31156 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "setWriter", "(Ljava/io/Writer;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult31157 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "()V");
			global::javax.xml.transform.stream.StreamResult._StreamResult31158 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult31159 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/Writer;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult31160 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.stream.StreamResult._StreamResult31161 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.stream.StreamResult.staticClass, "<init>", "(Ljava/io/File;)V");
		}
	}
}
