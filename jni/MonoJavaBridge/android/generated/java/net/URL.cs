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
		internal static global::MonoJavaBridge.MethodId _equals13886;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URL._equals13886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._equals13886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13887;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toString13887)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toString13887)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13888;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._hashCode13888);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._hashCode13888);
		}
		internal static global::MonoJavaBridge.MethodId _openStream13889;
		public global::java.io.InputStream openStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openStream13889)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openStream13889)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getPath13890;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getPath13890)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getPath13890)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toURI13891;
		public global::java.net.URI toURI() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toURI13891)) as java.net.URI;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toURI13891)) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _getAuthority13892;
		public global::java.lang.String getAuthority() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getAuthority13892)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getAuthority13892)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getQuery13893;
		public global::java.lang.String getQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getQuery13893)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getQuery13893)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getUserInfo13894;
		public global::java.lang.String getUserInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getUserInfo13894)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getUserInfo13894)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPort13895;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._getPort13895);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getPort13895);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort13896;
		public int getDefaultPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URL._getDefaultPort13896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getDefaultPort13896);
		}
		internal static global::MonoJavaBridge.MethodId _getProtocol13897;
		public global::java.lang.String getProtocol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getProtocol13897)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getProtocol13897)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHost13898;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getHost13898)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getHost13898)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getFile13899;
		public global::java.lang.String getFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getFile13899)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getFile13899)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRef13900;
		public global::java.lang.String getRef() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getRef13900)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getRef13900)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _sameFile13901;
		public bool sameFile(java.net.URL arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URL._sameFile13901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._sameFile13901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toExternalForm13902;
		public global::java.lang.String toExternalForm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._toExternalForm13902)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._toExternalForm13902)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection13903;
		public global::java.net.URLConnection openConnection(java.net.Proxy arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openConnection13903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openConnection13903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection13904;
		public global::java.net.URLConnection openConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._openConnection13904)) as java.net.URLConnection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._openConnection13904)) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _getContent13905;
		public global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getContent13905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getContent13905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContent13906;
		public global::java.lang.Object getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URL._getContent13906)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URL.staticClass, global::java.net.URL._getContent13906)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _setURLStreamHandlerFactory13907;
		public static void setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URL.staticClass, global::java.net.URL._setURLStreamHandlerFactory13907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URL13908;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL13908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL13909;
		public URL(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL13909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL13910;
		public URL(java.lang.String arg0, java.lang.String arg1, int arg2, java.lang.String arg3, java.net.URLStreamHandler arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL13910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL13911;
		public URL(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL13911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL13912;
		public URL(java.net.URL arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL13912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URL13913;
		public URL(java.net.URL arg0, java.lang.String arg1, java.net.URLStreamHandler arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URL.staticClass, global::java.net.URL._URL13913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URL.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URL"));
			global::java.net.URL._equals13886 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.net.URL._toString13887 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URL._hashCode13888 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "hashCode", "()I");
			global::java.net.URL._openStream13889 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openStream", "()Ljava/io/InputStream;");
			global::java.net.URL._getPath13890 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getPath", "()Ljava/lang/String;");
			global::java.net.URL._toURI13891 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toURI", "()Ljava/net/URI;");
			global::java.net.URL._getAuthority13892 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getAuthority", "()Ljava/lang/String;");
			global::java.net.URL._getQuery13893 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getQuery", "()Ljava/lang/String;");
			global::java.net.URL._getUserInfo13894 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getUserInfo", "()Ljava/lang/String;");
			global::java.net.URL._getPort13895 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getPort", "()I");
			global::java.net.URL._getDefaultPort13896 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getDefaultPort", "()I");
			global::java.net.URL._getProtocol13897 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getProtocol", "()Ljava/lang/String;");
			global::java.net.URL._getHost13898 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getHost", "()Ljava/lang/String;");
			global::java.net.URL._getFile13899 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getFile", "()Ljava/lang/String;");
			global::java.net.URL._getRef13900 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getRef", "()Ljava/lang/String;");
			global::java.net.URL._sameFile13901 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "sameFile", "(Ljava/net/URL;)Z");
			global::java.net.URL._toExternalForm13902 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "toExternalForm", "()Ljava/lang/String;");
			global::java.net.URL._openConnection13903 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openConnection", "(Ljava/net/Proxy;)Ljava/net/URLConnection;");
			global::java.net.URL._openConnection13904 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "openConnection", "()Ljava/net/URLConnection;");
			global::java.net.URL._getContent13905 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URL._getContent13906 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URL._setURLStreamHandlerFactory13907 = @__env.GetStaticMethodIDNoThrow(global::java.net.URL.staticClass, "setURLStreamHandlerFactory", "(Ljava/net/URLStreamHandlerFactory;)V");
			global::java.net.URL._URL13908 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			global::java.net.URL._URL13909 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URL._URL13910 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/net/URLStreamHandler;)V");
			global::java.net.URL._URL13911 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.net.URL._URL13912 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;)V");
			global::java.net.URL._URL13913 = @__env.GetMethodIDNoThrow(global::java.net.URL.staticClass, "<init>", "(Ljava/net/URL;Ljava/lang/String;Ljava/net/URLStreamHandler;)V");
		}
	}
}
