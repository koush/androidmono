namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class URL : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URL(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URL.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.net.URL._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.URL._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URL.staticClass, "hashCode", "()I", ref global::java.net.URL._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.io.InputStream openStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "openStream", "()Ljava/io/InputStream;", ref global::java.net.URL._m3) as java.io.InputStream;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getPath", "()Ljava/lang/String;", ref global::java.net.URL._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.net.URI toURI()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::java.net.URL.staticClass, "toURI", "()Ljava/net/URI;", ref global::java.net.URL._m5) as java.net.URI;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::java.lang.String getAuthority()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getAuthority", "()Ljava/lang/String;", ref global::java.net.URL._m6) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public global::java.lang.String getQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getQuery", "()Ljava/lang/String;", ref global::java.net.URL._m7) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public global::java.lang.String getUserInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getUserInfo", "()Ljava/lang/String;", ref global::java.net.URL._m8) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URL.staticClass, "getPort", "()I", ref global::java.net.URL._m9);
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int getDefaultPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URL.staticClass, "getDefaultPort", "()I", ref global::java.net.URL._m10);
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.String getProtocol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getProtocol", "()Ljava/lang/String;", ref global::java.net.URL._m11) as java.lang.String;
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getHost", "()Ljava/lang/String;", ref global::java.net.URL._m12) as java.lang.String;
		}
		public new global::java.lang.String File
		{
			get
			{
				return getFile();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getFile", "()Ljava/lang/String;", ref global::java.net.URL._m13) as java.lang.String;
		}
		public new global::java.lang.String Ref
		{
			get
			{
				return getRef();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.String getRef()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "getRef", "()Ljava/lang/String;", ref global::java.net.URL._m14) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public bool sameFile(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URL.staticClass, "sameFile", "(Ljava/net/URL;)Z", ref global::java.net.URL._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.lang.String toExternalForm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URL.staticClass, "toExternalForm", "()Ljava/lang/String;", ref global::java.net.URL._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.net.URLConnection openConnection(java.net.Proxy arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;", ref global::java.net.URL._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URLConnection;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::java.net.URLConnection openConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "openConnection", "()Ljava/net/URLConnection;", ref global::java.net.URL._m18) as java.net.URLConnection;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public global::java.lang.Object getContent(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", ref global::java.net.URL._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		public new global::java.lang.Object Content
		{
			get
			{
				return getContent();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.lang.Object getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URL.staticClass, "getContent", "()Ljava/lang/Object;", ref global::java.net.URL._m20) as java.lang.Object;
		}
		public static global::java.net.URLStreamHandlerFactory URLStreamHandlerFactory
		{
			set
			{
				setURLStreamHandlerFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m21.native == global::System.IntPtr.Zero)
				global::java.net.URL._m21 = @__env.GetStaticMethodIDNoThrow(global::java.net.URL.staticClass, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V");
			@__env.CallStaticVoidMethod(java.net.URL.staticClass, global::java.net.URL._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m22.native == global::System.IntPtr.Zero)
				global::java.net.URL._m22 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public URL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m23.native == global::System.IntPtr.Zero)
				global::java.net.URL._m23 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.net.URLStreamHandler arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m24.native == global::System.IntPtr.Zero)
				global::java.net.URL._m24 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public URL(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m25.native == global::System.IntPtr.Zero)
				global::java.net.URL._m25 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public URL(java.net.URL arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m26.native == global::System.IntPtr.Zero)
				global::java.net.URL._m26 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public URL(java.net.URL arg0, java.lang.String arg1, java.net.URLStreamHandler arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URL._m27.native == global::System.IntPtr.Zero)
				global::java.net.URL._m27 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static URL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URL"));
		}
	}
}
