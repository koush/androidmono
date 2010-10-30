namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.URLStreamHandler_))]
	public abstract partial class URLStreamHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLStreamHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals21976;
		protected virtual bool equals(java.net.URL arg0, java.net.URL arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLStreamHandler.staticClass, "equals", "(Ljava/net/URL;Ljava/net/URL;)Z", ref global::java.net.URLStreamHandler._equals21976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21977;
		protected virtual int hashCode(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLStreamHandler.staticClass, "hashCode", "(Ljava/net/URL;)I", ref global::java.net.URLStreamHandler._hashCode21977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPort21978;
		protected virtual int getDefaultPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLStreamHandler.staticClass, "getDefaultPort", "()I", ref global::java.net.URLStreamHandler._getDefaultPort21978);
		}
		internal static global::MonoJavaBridge.MethodId _sameFile21979;
		protected virtual bool sameFile(java.net.URL arg0, java.net.URL arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLStreamHandler.staticClass, "sameFile", "(Ljava/net/URL;Ljava/net/URL;)Z", ref global::java.net.URLStreamHandler._sameFile21979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _toExternalForm21980;
		protected virtual global::java.lang.String toExternalForm(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLStreamHandler.staticClass, "toExternalForm", "(Ljava/net/URL;)Ljava/lang/String;", ref global::java.net.URLStreamHandler._toExternalForm21980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21981;
		protected virtual global::java.net.URLConnection openConnection(java.net.URL arg0, java.net.Proxy arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLStreamHandler.staticClass, "openConnection", "(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;", ref global::java.net.URLStreamHandler._openConnection21981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.net.URLConnection;
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21982;
		protected abstract global::java.net.URLConnection openConnection(java.net.URL arg0);
		internal static global::MonoJavaBridge.MethodId _parseURL21983;
		protected virtual void parseURL(java.net.URL arg0, java.lang.String arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLStreamHandler.staticClass, "parseURL", "(Ljava/net/URL;Ljava/lang/String;II)V", ref global::java.net.URLStreamHandler._parseURL21983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getHostAddress21984;
		protected virtual global::java.net.InetAddress getHostAddress(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLStreamHandler.staticClass, "getHostAddress", "(Ljava/net/URL;)Ljava/net/InetAddress;", ref global::java.net.URLStreamHandler._getHostAddress21984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _hostsEqual21985;
		protected virtual bool hostsEqual(java.net.URL arg0, java.net.URL arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLStreamHandler.staticClass, "hostsEqual", "(Ljava/net/URL;Ljava/net/URL;)Z", ref global::java.net.URLStreamHandler._hostsEqual21985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setURL21986;
		protected virtual void setURL(java.net.URL arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLStreamHandler.staticClass, "setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::java.net.URLStreamHandler._setURL21986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8));
		}
		internal static global::MonoJavaBridge.MethodId _setURL21987;
		protected virtual void setURL(java.net.URL arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLStreamHandler.staticClass, "setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", ref global::java.net.URLStreamHandler._setURL21987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _URLStreamHandler21988;
		public URLStreamHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLStreamHandler._URLStreamHandler21988.native == global::System.IntPtr.Zero)
				global::java.net.URLStreamHandler._URLStreamHandler21988 = @__env.GetMethodIDNoThrow(global::java.net.URLStreamHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLStreamHandler.staticClass, global::java.net.URLStreamHandler._URLStreamHandler21988);
			Init(@__env, handle);
		}
		static URLStreamHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLStreamHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLStreamHandler"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLStreamHandler))]
	internal sealed partial class URLStreamHandler_ : java.net.URLStreamHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URLStreamHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _openConnection21989;
		protected override global::java.net.URLConnection openConnection(java.net.URL arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLStreamHandler_.staticClass, "openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;", ref global::java.net.URLStreamHandler_._openConnection21989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URLConnection;
		}
		static URLStreamHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLStreamHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLStreamHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
