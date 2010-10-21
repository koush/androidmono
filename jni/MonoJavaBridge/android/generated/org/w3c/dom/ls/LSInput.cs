namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.w3c.dom.ls.LSInput_))]
	public interface LSInput  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getEncoding();
		void setEncoding(java.lang.String arg0);
		global::java.lang.String getPublicId();
		global::java.lang.String getSystemId();
		global::java.io.Reader getCharacterStream();
		void setCharacterStream(java.io.Reader arg0);
		void setSystemId(java.lang.String arg0);
		global::java.lang.String getBaseURI();
		void setPublicId(java.lang.String arg0);
		void setByteStream(java.io.InputStream arg0);
		global::java.io.InputStream getByteStream();
		global::java.lang.String getStringData();
		void setStringData(java.lang.String arg0);
		void setBaseURI(java.lang.String arg0);
		bool getCertifiedText();
		void setCertifiedText(bool arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.w3c.dom.ls.LSInput))]
	public sealed partial class LSInput_ : java.lang.Object, LSInput
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSInput_()
		{
			InitJNI();
		}
		internal LSInput_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getEncoding34773;
		 global::java.lang.String org.w3c.dom.ls.LSInput.getEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getEncoding34773)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getEncoding34773)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding34774;
		 void org.w3c.dom.ls.LSInput.setEncoding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setEncoding34774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setEncoding34774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPublicId34775;
		 global::java.lang.String org.w3c.dom.ls.LSInput.getPublicId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getPublicId34775)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getPublicId34775)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemId34776;
		 global::java.lang.String org.w3c.dom.ls.LSInput.getSystemId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getSystemId34776)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getSystemId34776)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream34777;
		 global::java.io.Reader org.w3c.dom.ls.LSInput.getCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getCharacterStream34777)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getCharacterStream34777)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream34778;
		 void org.w3c.dom.ls.LSInput.setCharacterStream(java.io.Reader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setCharacterStream34778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setCharacterStream34778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSystemId34779;
		 void org.w3c.dom.ls.LSInput.setSystemId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setSystemId34779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setSystemId34779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBaseURI34780;
		 global::java.lang.String org.w3c.dom.ls.LSInput.getBaseURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getBaseURI34780)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getBaseURI34780)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setPublicId34781;
		 void org.w3c.dom.ls.LSInput.setPublicId(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setPublicId34781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setPublicId34781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setByteStream34782;
		 void org.w3c.dom.ls.LSInput.setByteStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setByteStream34782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setByteStream34782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByteStream34783;
		 global::java.io.InputStream org.w3c.dom.ls.LSInput.getByteStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getByteStream34783)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getByteStream34783)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getStringData34784;
		 global::java.lang.String org.w3c.dom.ls.LSInput.getStringData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getStringData34784)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getStringData34784)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setStringData34785;
		 void org.w3c.dom.ls.LSInput.setStringData(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setStringData34785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setStringData34785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBaseURI34786;
		 void org.w3c.dom.ls.LSInput.setBaseURI(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setBaseURI34786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setBaseURI34786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCertifiedText34787;
		 bool org.w3c.dom.ls.LSInput.getCertifiedText() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._getCertifiedText34787);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._getCertifiedText34787);
		}
		internal static global::MonoJavaBridge.MethodId _setCertifiedText34788;
		 void org.w3c.dom.ls.LSInput.setCertifiedText(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_._setCertifiedText34788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.w3c.dom.ls.LSInput_.staticClass, global::org.w3c.dom.ls.LSInput_._setCertifiedText34788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSInput_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSInput"));
			global::org.w3c.dom.ls.LSInput_._getEncoding34773 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSInput_._setEncoding34774 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSInput_._getPublicId34775 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getPublicId", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSInput_._getSystemId34776 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getSystemId", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSInput_._getCharacterStream34777 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::org.w3c.dom.ls.LSInput_._setCharacterStream34778 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setCharacterStream", "(Ljava/io/Reader;)V");
			global::org.w3c.dom.ls.LSInput_._setSystemId34779 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setSystemId", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSInput_._getBaseURI34780 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getBaseURI", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSInput_._setPublicId34781 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setPublicId", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSInput_._setByteStream34782 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setByteStream", "(Ljava/io/InputStream;)V");
			global::org.w3c.dom.ls.LSInput_._getByteStream34783 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getByteStream", "()Ljava/io/InputStream;");
			global::org.w3c.dom.ls.LSInput_._getStringData34784 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getStringData", "()Ljava/lang/String;");
			global::org.w3c.dom.ls.LSInput_._setStringData34785 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setStringData", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSInput_._setBaseURI34786 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setBaseURI", "(Ljava/lang/String;)V");
			global::org.w3c.dom.ls.LSInput_._getCertifiedText34787 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "getCertifiedText", "()Z");
			global::org.w3c.dom.ls.LSInput_._setCertifiedText34788 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSInput_.staticClass, "setCertifiedText", "(Z)V");
		}
	}
}
