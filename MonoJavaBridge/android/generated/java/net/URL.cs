namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URL : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21880;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URL.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.URL._equals21880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21881;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.URL._toString21881) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21882;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URL.staticClass, "hashCode", "()I", ref global::java.net.URL._hashCode21882);
		}
		internal static global::MonoJavaBridge.MethodId _openStream21883;
		public global::java.io.InputStream openStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "openStream", "()Ljava/io/InputStream;", ref global::java.net.URL._openStream21883) as java.io.InputStream;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath21884;
		public global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getPath", "()Ljava/lang/String;", ref global::java.net.URL._getPath21884) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI21885;
		public global::java.net.URI toURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URL.staticClass, "toURI", "()Ljava/net/URI;", ref global::java.net.URL._toURI21885) as java.net.URI;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority21886;
		public global::java.lang.String getAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getAuthority", "()Ljava/lang/String;", ref global::java.net.URL._getAuthority21886) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQuery21887;
		public global::java.lang.String getQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getQuery", "()Ljava/lang/String;", ref global::java.net.URL._getQuery21887) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo21888;
		public global::java.lang.String getUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getUserInfo", "()Ljava/lang/String;", ref global::java.net.URL._getUserInfo21888) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21889;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URL.staticClass, "getPort", "()I", ref global::java.net.URL._getPort21889);
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort21890;
		public int getDefaultPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URL.staticClass, "getDefaultPort", "()I", ref global::java.net.URL._getDefaultPort21890);
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol21891;
		public global::java.lang.String getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::java.net.URL._getProtocol21891) as java.lang.String;
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost21892;
		public global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getHost", "()Ljava/lang/String;", ref global::java.net.URL._getHost21892) as java.lang.String;
		}
		public new global::java.lang.String File
		{
			get
			{
				return getFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFile21893;
		public global::java.lang.String getFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getFile", "()Ljava/lang/String;", ref global::java.net.URL._getFile21893) as java.lang.String;
		}
		public new global::java.lang.String Ref
		{
			get
			{
				return getRef();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRef21894;
		public global::java.lang.String getRef()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getRef", "()Ljava/lang/String;", ref global::java.net.URL._getRef21894) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _sameFile21895;
		public bool sameFile(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URL.staticClass, "sameFile", "(Ljava/net/URL;)Z", ref global::java.net.URL._sameFile21895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toExternalForm21896;
		public global::java.lang.String toExternalForm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "toExternalForm", "()Ljava/lang/String;", ref global::java.net.URL._toExternalForm21896) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21897;
		public global::java.net.URLConnection openConnection(java.net.Proxy arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;", ref global::java.net.URL._openConnection21897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21898;
		public global::java.net.URLConnection openConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "openConnection", "()Ljava/net/URLConnection;", ref global::java.net.URL._openConnection21898) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21899;
		public global::java.lang.Object getContent(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", ref global::java.net.URL._getContent21899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		public new global::java.lang.Object Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent21900;
		public global::java.lang.Object getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "getContent", "()Ljava/lang/Object;", ref global::java.net.URL._getContent21900) as java.lang.Object;
		}
		public static global::java.net.URLStreamHandlerFactory URLStreamHandlerFactory
		{
			set
			{
				setURLStreamHandlerFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setURLStreamHandlerFactory21901;
		public static void setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._setURLStreamHandlerFactory21901.native == global::System.IntPtr.Zero)
				global::java.net.URL._setURLStreamHandlerFactory21901 = @__env.GetStaticMethodIDNoThrow(global::java.net.URL.staticClass, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V");
			@__env.CallStaticVoidMethod(java.net.URL.staticClass, global::java.net.URL._setURLStreamHandlerFactory21901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URL21902;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._URL21902.native == global::System.IntPtr.Zero)
				global::java.net.URL._URL21902 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21903;
		public URL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._URL21903.native == global::System.IntPtr.Zero)
				global::java.net.URL._URL21903 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21904;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.net.URLStreamHandler arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._URL21904.native == global::System.IntPtr.Zero)
				global::java.net.URL._URL21904 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21905;
		public URL(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._URL21905.native == global::System.IntPtr.Zero)
				global::java.net.URL._URL21905 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21906;
		public URL(java.net.URL arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._URL21906.native == global::System.IntPtr.Zero)
				global::java.net.URL._URL21906 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL21907;
		public URL(java.net.URL arg0, java.lang.String arg1, java.net.URLStreamHandler arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._URL21907.native == global::System.IntPtr.Zero)
				global::java.net.URL._URL21907 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL21907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static URL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URL"));
		}
		internal static void InitJNI()
		{
		}
	}
}
