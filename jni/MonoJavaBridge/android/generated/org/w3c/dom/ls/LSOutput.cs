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
		static LSOutput_()
		{
			InitJNI();
		}
		internal LSOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding34907;
		global::java.lang.String org.w3c.dom.ls.LSOutput.getEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getEncoding34907)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getEncoding34907)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding34908;
		void org.w3c.dom.ls.LSOutput.setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setEncoding34908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setEncoding34908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId34909;
		global::java.lang.String org.w3c.dom.ls.LSOutput.getSystemId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getSystemId34909)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getSystemId34909)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream34910;
		global::java.io.Writer org.w3c.dom.ls.LSOutput.getCharacterStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getCharacterStream34910)) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getCharacterStream34910)) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream34911;
		void org.w3c.dom.ls.LSOutput.setCharacterStream(java.io.Writer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setCharacterStream34911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setCharacterStream34911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId34912;
		void org.w3c.dom.ls.LSOutput.setSystemId(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setSystemId34912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setSystemId34912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream34913;
		void org.w3c.dom.ls.LSOutput.setByteStream(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setByteStream34913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setByteStream34913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByteStream34914;
		global::java.io.OutputStream org.w3c.dom.ls.LSOutput.getByteStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getByteStream34914)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getByteStream34914)) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSOutput"));
			global::org.w3c.dom.ls.LSOutput_._getEncoding34907 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSOutput_._setEncoding34908 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSOutput_._getSystemId34909 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSOutput_._getCharacterStream34910 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getCharacterStream", "()Ljava/io/Writer;");
			global::org.w3c.dom.ls.LSOutput_._setCharacterStream34911 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setCharacterStream", "(Ljava/io/Writer;)V");
			global::org.w3c.dom.ls.LSOutput_._setSystemId34912 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSOutput_._setByteStream34913 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setByteStream", "(Ljava/io/OutputStream;)V");
			global::org.w3c.dom.ls.LSOutput_._getByteStream34914 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getByteStream", "()Ljava/io/OutputStream;");
		}
	}
}
