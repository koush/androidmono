namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSOutput_))]
	public interface LSOutput  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class LSOutput_ : java.lang.Object, LSOutput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSOutput_()
		{
			InitJNI();
		}
		internal LSOutput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding28047;
		 global::java.lang.String org.w3c.dom.ls.LSOutput.getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getEncoding28047)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getEncoding28047)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding28048;
		 void org.w3c.dom.ls.LSOutput.setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setEncoding28048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setEncoding28048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId28049;
		 global::java.lang.String org.w3c.dom.ls.LSOutput.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getSystemId28049)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getSystemId28049)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream28050;
		 global::java.io.Writer org.w3c.dom.ls.LSOutput.getCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getCharacterStream28050)) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getCharacterStream28050)) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream28051;
		 void org.w3c.dom.ls.LSOutput.setCharacterStream(java.io.Writer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setCharacterStream28051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setCharacterStream28051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId28052;
		 void org.w3c.dom.ls.LSOutput.setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setSystemId28052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setSystemId28052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream28053;
		 void org.w3c.dom.ls.LSOutput.setByteStream(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._setByteStream28053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._setByteStream28053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByteStream28054;
		 global::java.io.OutputStream org.w3c.dom.ls.LSOutput.getByteStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_._getByteStream28054)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSOutput_.staticClass, global::org.w3c.dom.ls.LSOutput_._getByteStream28054)) as java.io.OutputStream;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSOutput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSOutput"));
			global::org.w3c.dom.ls.LSOutput_._getEncoding28047 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSOutput_._setEncoding28048 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSOutput_._getSystemId28049 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSOutput_._getCharacterStream28050 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getCharacterStream", "()Ljava/io/Writer;");
			global::org.w3c.dom.ls.LSOutput_._setCharacterStream28051 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setCharacterStream", "(Ljava/io/Writer;)V");
			global::org.w3c.dom.ls.LSOutput_._setSystemId28052 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSOutput_._setByteStream28053 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "setByteStream", "(Ljava/io/OutputStream;)V");
			global::org.w3c.dom.ls.LSOutput_._getByteStream28054 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSOutput_.staticClass, "getByteStream", "()Ljava/io/OutputStream;");
		}
	}
}
