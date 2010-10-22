namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URL : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URL()
		{
			InitJNI();
		}
		internal URL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21761;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URL._equals21761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._equals21761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21762;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toString21762)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toString21762)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21763;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._hashCode21763);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._hashCode21763);
		}
		internal static global::MonoJavaBridge.MethodId _openStream21764;
		public global::java.io.InputStream openStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openStream21764)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openStream21764)) as java.io.InputStream;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath21765;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getPath21765)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getPath21765)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI21766;
		public global::java.net.URI toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toURI21766)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URI>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toURI21766)) as java.net.URI;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority21767;
		public global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getAuthority21767)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getAuthority21767)) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQuery21768;
		public global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getQuery21768)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getQuery21768)) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo21769;
		public global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getUserInfo21769)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getUserInfo21769)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21770;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._getPort21770);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getPort21770);
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort21771;
		public int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._getDefaultPort21771);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getDefaultPort21771);
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol21772;
		public global::java.lang.String getProtocol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getProtocol21772)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getProtocol21772)) as java.lang.String;
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost21773;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getHost21773)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getHost21773)) as java.lang.String;
		}
		public new global::java.lang.String File
		{
			get
			{
				return getFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFile21774;
		public global::java.lang.String getFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getFile21774)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getFile21774)) as java.lang.String;
		}
		public new global::java.lang.String Ref
		{
			get
			{
				return getRef();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRef21775;
		public global::java.lang.String getRef() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getRef21775)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getRef21775)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _sameFile21776;
		public bool sameFile(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URL._sameFile21776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._sameFile21776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toExternalForm21777;
		public global::java.lang.String toExternalForm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toExternalForm21777)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toExternalForm21777)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21778;
		public global::java.net.URLConnection openConnection(java.net.Proxy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openConnection21778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openConnection21778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21779;
		public global::java.net.URLConnection openConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openConnection21779)) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openConnection21779)) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21780;
		public global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getContent21780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getContent21780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new global::java.lang.Object Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent21781;
		public global::java.lang.Object getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getContent21781)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getContent21781)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setURLStreamHandlerFactory21782;
		public static void setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URL.staticClass, global::java.net.URL._setURLStreamHandlerFactory21782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URL21783;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21784;
		public URL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21785;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.net.URLStreamHandler arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21786;
		public URL(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21787;
		public URL(java.net.URL arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21788;
		public URL(java.net.URL arg0, java.lang.String arg1, java.net.URLStreamHandler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URL"));
			global::java.net.URL._equals21761 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URL._toString21762 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URL._hashCode21763 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "hashCode", "()I");
			global::java.net.URL._openStream21764 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openStream", "()Ljava/io/InputStream;");
			global::java.net.URL._getPath21765 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URL._toURI21766 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.net.URL._getAuthority21767 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URL._getQuery21768 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URL._getUserInfo21769 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URL._getPort21770 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getPort", "()I");
			global::java.net.URL._getDefaultPort21771 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getDefaultPort", "()I");
			global::java.net.URL._getProtocol21772 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::java.net.URL._getHost21773 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URL._getFile21774 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getFile", "()Ljava/lang/String;");
			global::java.net.URL._getRef21775 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getRef", "()Ljava/lang/String;");
			global::java.net.URL._sameFile21776 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "sameFile", "(Ljava/net/URL;)Z");
			global::java.net.URL._toExternalForm21777 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toExternalForm", "()Ljava/lang/String;");
			global::java.net.URL._openConnection21778 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;");
			global::java.net.URL._openConnection21779 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openConnection", "()Ljava/net/URLConnection;");
			global::java.net.URL._getContent21780 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URL._getContent21781 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URL._setURLStreamHandlerFactory21782 = @__env.GetStaticMethodIDNoThrow(global::java.net.URL.staticClass, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V");
			global::java.net.URL._URL21783 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			global::java.net.URL._URL21784 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URL._URL21785 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::java.net.URL._URL21786 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.URL._URL21787 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
			global::java.net.URL._URL21788 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V");
		}
	}
}
