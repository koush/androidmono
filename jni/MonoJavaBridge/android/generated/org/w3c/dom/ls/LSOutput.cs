namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSOutput_))]
	public partial interface LSOutput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getEncoding();
		void setEncoding(java.lang.String arg0);
		global::java.lang.String getSystemId();
		global::java.io.Writer getCharacterStream();
		void setCharacterStream(java.io.Writer arg0);
		void setSystemId(java.lang.String arg0);
		void setByteStream(java.io.OutputStream arg0);
		global::java.io.OutputStream getByteStream();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSOutput))]
	internal sealed partial class LSOutput_ : java.lang.Object, LSOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LSOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding34908;
		global::java.lang.String org.w3c.dom.ls.LSOutput.getEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getEncoding34908)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getEncoding34908)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding34909;
		void org.w3c.dom.ls.LSOutput.setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setEncoding34909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setEncoding34909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId34910;
		global::java.lang.String org.w3c.dom.ls.LSOutput.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getSystemId34910)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getSystemId34910)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream34911;
		global::java.io.Writer org.w3c.dom.ls.LSOutput.getCharacterStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getCharacterStream34911)) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getCharacterStream34911)) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream34912;
		void org.w3c.dom.ls.LSOutput.setCharacterStream(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setCharacterStream34912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setCharacterStream34912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId34913;
		void org.w3c.dom.ls.LSOutput.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setSystemId34913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setSystemId34913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream34914;
		void org.w3c.dom.ls.LSOutput.setByteStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setByteStream34914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setByteStream34914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByteStream34915;
		global::java.io.OutputStream org.w3c.dom.ls.LSOutput.getByteStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getByteStream34915)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getByteStream34915)) as java.io.OutputStream;
		}
		static LSOutput_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSOutput"));
			global::org.w3c.dom.ls.LSOutput_._getEncoding34908 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSOutput_._setEncoding34909 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSOutput_._getSystemId34910 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSOutput_._getCharacterStream34911 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getCharacterStream", "()Ljava/io/Writer;");
			global::org.w3c.dom.ls.LSOutput_._setCharacterStream34912 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setCharacterStream", "(Ljava/io/Writer;)V");
			global::org.w3c.dom.ls.LSOutput_._setSystemId34913 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSOutput_._setByteStream34914 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setByteStream", "(Ljava/io/OutputStream;)V");
			global::org.w3c.dom.ls.LSOutput_._getByteStream34915 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getByteStream", "()Ljava/io/OutputStream;");
		}
		internal static void InitJNI()
		{
		}
	}
}
