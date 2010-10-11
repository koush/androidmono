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
		internal static global::MonoJavaBridge.MethodId _getEncoding16505;
		public virtual global::java.lang.String getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getEncoding16505)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getEncoding16505)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding16506;
		public virtual void setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setEncoding16506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setEncoding16506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId16507;
		public virtual global::java.lang.String getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getPublicId16507)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getPublicId16507)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId16508;
		public virtual global::java.lang.String getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getSystemId16508)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getSystemId16508)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream16509;
		public virtual global::java.io.Reader getCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getCharacterStream16509)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getCharacterStream16509)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream16510;
		public virtual void setCharacterStream(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setCharacterStream16510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setCharacterStream16510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId16511;
		public virtual void setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setSystemId16511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setSystemId16511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId16512;
		public virtual void setPublicId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setPublicId16512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setPublicId16512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream16513;
		public virtual void setByteStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource._setByteStream16513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._setByteStream16513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByteStream16514;
		public virtual global::java.io.InputStream getByteStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource._getByteStream16514)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._getByteStream16514)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _InputSource16515;
		public InputSource(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource16515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource16516;
		public InputSource(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource16516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource16517;
		public InputSource(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource16517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _InputSource16518;
		public InputSource()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.InputSource.staticClass, global::org.xml.sax.InputSource._InputSource16518);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.InputSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/InputSource"));
			global::org.xml.sax.InputSource._getEncoding16505 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._setEncoding16506 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._getPublicId16507 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._getSystemId16508 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.xml.sax.InputSource._getCharacterStream16509 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::org.xml.sax.InputSource._setCharacterStream16510 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V");
			global::org.xml.sax.InputSource._setSystemId16511 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._setPublicId16512 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._setByteStream16513 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "setByteStream", "(Ljava/io/InputStream;)V");
			global::org.xml.sax.InputSource._getByteStream16514 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "getByteStream", "()Ljava/io/InputStream;");
			global::org.xml.sax.InputSource._InputSource16515 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/Reader;)V");
			global::org.xml.sax.InputSource._InputSource16516 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xml.sax.InputSource._InputSource16517 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::org.xml.sax.InputSource._InputSource16518 = @__env.GetMethodIDNoThrow(global::org.xml.sax.InputSource.staticClass, "<init>", "()V");
		}
	}
}
