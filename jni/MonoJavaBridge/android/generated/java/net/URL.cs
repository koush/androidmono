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
		internal static global::MonoJavaBridge.MethodId _equals16167;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URL._equals16167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._equals16167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString16168;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toString16168)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toString16168)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode16169;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._hashCode16169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._hashCode16169);
		}
		internal static global::MonoJavaBridge.MethodId _openStream16170;
		public global::java.io.InputStream openStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openStream16170)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openStream16170)) as java.io.InputStream;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath16171;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getPath16171)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getPath16171)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI16172;
		public global::java.net.URI toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toURI16172)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toURI16172)) as java.net.URI;
		}
		public new global::java.lang.String Authority
		{
			get
			{
				return getAuthority();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority16173;
		public global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getAuthority16173)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getAuthority16173)) as java.lang.String;
		}
		public new global::java.lang.String Query
		{
			get
			{
				return getQuery();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getQuery16174;
		public global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getQuery16174)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getQuery16174)) as java.lang.String;
		}
		public new global::java.lang.String UserInfo
		{
			get
			{
				return getUserInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo16175;
		public global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getUserInfo16175)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getUserInfo16175)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort16176;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._getPort16176);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getPort16176);
		}
		public new int DefaultPort
		{
			get
			{
				return getDefaultPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort16177;
		public int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._getDefaultPort16177);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getDefaultPort16177);
		}
		public new global::java.lang.String Protocol
		{
			get
			{
				return getProtocol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol16178;
		public global::java.lang.String getProtocol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getProtocol16178)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getProtocol16178)) as java.lang.String;
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost16179;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getHost16179)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getHost16179)) as java.lang.String;
		}
		public new global::java.lang.String File
		{
			get
			{
				return getFile();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFile16180;
		public global::java.lang.String getFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getFile16180)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getFile16180)) as java.lang.String;
		}
		public new global::java.lang.String Ref
		{
			get
			{
				return getRef();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRef16181;
		public global::java.lang.String getRef() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getRef16181)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getRef16181)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _sameFile16182;
		public bool sameFile(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URL._sameFile16182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._sameFile16182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toExternalForm16183;
		public global::java.lang.String toExternalForm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toExternalForm16183)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toExternalForm16183)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection16184;
		public global::java.net.URLConnection openConnection(java.net.Proxy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openConnection16184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openConnection16184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection16185;
		public global::java.net.URLConnection openConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openConnection16185)) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openConnection16185)) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _getContent16186;
		public global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getContent16186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getContent16186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		public new global::java.lang.Object Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent16187;
		public global::java.lang.Object getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getContent16187)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getContent16187)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setURLStreamHandlerFactory16188;
		public static void setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URL.staticClass, global::java.net.URL._setURLStreamHandlerFactory16188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URL16189;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL16189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL16190;
		public URL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL16190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL16191;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.net.URLStreamHandler arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL16191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL16192;
		public URL(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL16192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL16193;
		public URL(java.net.URL arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL16193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL16194;
		public URL(java.net.URL arg0, java.lang.String arg1, java.net.URLStreamHandler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL16194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URL"));
			global::java.net.URL._equals16167 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URL._toString16168 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URL._hashCode16169 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "hashCode", "()I");
			global::java.net.URL._openStream16170 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openStream", "()Ljava/io/InputStream;");
			global::java.net.URL._getPath16171 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URL._toURI16172 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.net.URL._getAuthority16173 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URL._getQuery16174 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URL._getUserInfo16175 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URL._getPort16176 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getPort", "()I");
			global::java.net.URL._getDefaultPort16177 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getDefaultPort", "()I");
			global::java.net.URL._getProtocol16178 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::java.net.URL._getHost16179 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URL._getFile16180 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getFile", "()Ljava/lang/String;");
			global::java.net.URL._getRef16181 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getRef", "()Ljava/lang/String;");
			global::java.net.URL._sameFile16182 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "sameFile", "(Ljava/net/URL;)Z");
			global::java.net.URL._toExternalForm16183 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toExternalForm", "()Ljava/lang/String;");
			global::java.net.URL._openConnection16184 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;");
			global::java.net.URL._openConnection16185 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openConnection", "()Ljava/net/URLConnection;");
			global::java.net.URL._getContent16186 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URL._getContent16187 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URL._setURLStreamHandlerFactory16188 = @__env.GetStaticMethodIDNoThrow(global::java.net.URL.staticClass, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V");
			global::java.net.URL._URL16189 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			global::java.net.URL._URL16190 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URL._URL16191 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::java.net.URL._URL16192 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.URL._URL16193 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
			global::java.net.URL._URL16194 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V");
		}
	}
}
