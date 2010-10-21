namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputSource : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputSource()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getEncoding34883;
		public virtual global::java.lang.String getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getEncoding34883)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getEncoding34883)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding34884;
		public virtual void setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setEncoding34884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setEncoding34884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPublicId34885;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getPublicId34885)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getPublicId34885)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getSystemId34886;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getSystemId34886)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getSystemId34886)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getCharacterStream34887;
		public virtual global::java.io.Reader getCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getCharacterStream34887)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getCharacterStream34887)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream34888;
		public virtual void setCharacterStream(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setCharacterStream34888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setCharacterStream34888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId34889;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setSystemId34889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setSystemId34889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId34890;
		public virtual void setPublicId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setPublicId34890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setPublicId34890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream34891;
		public virtual void setByteStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setByteStream34891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setByteStream34891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getByteStream34892;
		public virtual global::java.io.InputStream getByteStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getByteStream34892)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getByteStream34892)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _InputSource34893;
		public InputSource(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource34893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource34894;
		public InputSource(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource34894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource34895;
		public InputSource(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource34895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource34896;
		public InputSource()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource34896);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.InputSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/InputSource"));
			global::org.xml.sax.InputSource._getEncoding34883 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._setEncoding34884 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._getPublicId34885 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._getSystemId34886 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._getCharacterStream34887 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::org.xml.sax.InputSource._setCharacterStream34888 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V");
			global::org.xml.sax.InputSource._setSystemId34889 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._setPublicId34890 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._setByteStream34891 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V");
			global::org.xml.sax.InputSource._getByteStream34892 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;");
			global::org.xml.sax.InputSource._InputSource34893 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::org.xml.sax.InputSource._InputSource34894 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._InputSource34895 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::org.xml.sax.InputSource._InputSource34896 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "()V");
		}
	}
}
