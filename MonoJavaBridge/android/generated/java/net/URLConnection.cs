namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.URLConnection_))]
	public abstract partial class URLConnection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString21920;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.URLConnection._toString21920) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURL21921;
		public virtual global::java.net.URL getURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;", ref global::java.net.URLConnection._getURL21921) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21922;
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", ref global::java.net.URLConnection._getContent21922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21923;
		public virtual global::java.lang.Object getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;", ref global::java.net.URLConnection._getContent21923) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21924;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.net.URLConnection._getInputStream21924) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getPermission21925;
		public virtual global::java.security.Permission getPermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;", ref global::java.net.URLConnection._getPermission21925) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _connect21926;
		public abstract void connect();
		internal static global::MonoJavaBridge.MethodId _setRequestProperty21927;
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.net.URLConnection._setRequestProperty21927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDate21928;
		public virtual long getDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getDate", "()J", ref global::java.net.URLConnection._getDate21928);
		}
		internal static global::MonoJavaBridge.MethodId _getContentType21929;
		public virtual global::java.lang.String getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;", ref global::java.net.URLConnection._getContentType21929) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength21930;
		public virtual int getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getContentLength", "()I", ref global::java.net.URLConnection._getContentLength21930);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21931;
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.net.URLConnection._getHeaderField21931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21932;
		public virtual global::java.lang.String getHeaderField(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;", ref global::java.net.URLConnection._getHeaderField21932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey21933;
		public virtual global::java.lang.String getHeaderFieldKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;", ref global::java.net.URLConnection._getHeaderFieldKey21933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLastModified21934;
		public virtual long getLastModified()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getLastModified", "()J", ref global::java.net.URLConnection._getLastModified21934);
		}
		internal static global::MonoJavaBridge.MethodId _getFileNameMap21935;
		public static global::java.net.FileNameMap getFileNameMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._getFileNameMap21935.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._getFileNameMap21935 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.net.FileNameMap>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getFileNameMap21935)) as java.net.FileNameMap;
		}
		internal static global::MonoJavaBridge.MethodId _addRequestProperty21936;
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.net.URLConnection._addRequestProperty21936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperty21937;
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.net.URLConnection._getRequestProperty21937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperties21938;
		public virtual global::java.util.Map getRequestProperties()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;", ref global::java.net.URLConnection._getRequestProperties21938) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromStream21939;
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._guessContentTypeFromStream21939.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._guessContentTypeFromStream21939 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromStream21939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromName21940;
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._guessContentTypeFromName21940.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._guessContentTypeFromName21940 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromName21940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileNameMap21941;
		public static void setFileNameMap(java.net.FileNameMap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._setFileNameMap21941.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._setFileNameMap21941 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setFileNameMap21941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectTimeout21942;
		public virtual void setConnectTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V", ref global::java.net.URLConnection._setConnectTimeout21942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectTimeout21943;
		public virtual int getConnectTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I", ref global::java.net.URLConnection._getConnectTimeout21943);
		}
		internal static global::MonoJavaBridge.MethodId _setReadTimeout21944;
		public virtual void setReadTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V", ref global::java.net.URLConnection._setReadTimeout21944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadTimeout21945;
		public virtual int getReadTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getReadTimeout", "()I", ref global::java.net.URLConnection._getReadTimeout21945);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding21946;
		public virtual global::java.lang.String getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;", ref global::java.net.URLConnection._getContentEncoding21946) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiration21947;
		public virtual long getExpiration()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getExpiration", "()J", ref global::java.net.URLConnection._getExpiration21947);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFields21948;
		public virtual global::java.util.Map getHeaderFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;", ref global::java.net.URLConnection._getHeaderFields21948) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldInt21949;
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I", ref global::java.net.URLConnection._getHeaderFieldInt21949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate21950;
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J", ref global::java.net.URLConnection._getHeaderFieldDate21950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21951;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.net.URLConnection._getOutputStream21951) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setDoInput21952;
		public virtual void setDoInput(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V", ref global::java.net.URLConnection._setDoInput21952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoInput21953;
		public virtual bool getDoInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getDoInput", "()Z", ref global::java.net.URLConnection._getDoInput21953);
		}
		internal static global::MonoJavaBridge.MethodId _setDoOutput21954;
		public virtual void setDoOutput(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V", ref global::java.net.URLConnection._setDoOutput21954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoOutput21955;
		public virtual bool getDoOutput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getDoOutput", "()Z", ref global::java.net.URLConnection._getDoOutput21955);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUserInteraction21956;
		public virtual void setAllowUserInteraction(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V", ref global::java.net.URLConnection._setAllowUserInteraction21956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowUserInteraction21957;
		public virtual bool getAllowUserInteraction()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z", ref global::java.net.URLConnection._getAllowUserInteraction21957);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAllowUserInteraction21958;
		public static void setDefaultAllowUserInteraction(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._setDefaultAllowUserInteraction21958.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._setDefaultAllowUserInteraction21958 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultAllowUserInteraction21958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAllowUserInteraction21959;
		public static bool getDefaultAllowUserInteraction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._getDefaultAllowUserInteraction21959.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._getDefaultAllowUserInteraction21959 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z");
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultAllowUserInteraction21959);
		}
		internal static global::MonoJavaBridge.MethodId _setUseCaches21960;
		public virtual void setUseCaches(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V", ref global::java.net.URLConnection._setUseCaches21960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseCaches21961;
		public virtual bool getUseCaches()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getUseCaches", "()Z", ref global::java.net.URLConnection._getUseCaches21961);
		}
		internal static global::MonoJavaBridge.MethodId _setIfModifiedSince21962;
		public virtual void setIfModifiedSince(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V", ref global::java.net.URLConnection._setIfModifiedSince21962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIfModifiedSince21963;
		public virtual long getIfModifiedSince()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J", ref global::java.net.URLConnection._getIfModifiedSince21963);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUseCaches21964;
		public virtual bool getDefaultUseCaches()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z", ref global::java.net.URLConnection._getDefaultUseCaches21964);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUseCaches21965;
		public virtual void setDefaultUseCaches(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V", ref global::java.net.URLConnection._setDefaultUseCaches21965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultRequestProperty21966;
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._setDefaultRequestProperty21966.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._setDefaultRequestProperty21966 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultRequestProperty21966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultRequestProperty21967;
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._getDefaultRequestProperty21967.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._getDefaultRequestProperty21967 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultRequestProperty21967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandlerFactory21968;
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._setContentHandlerFactory21968.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._setContentHandlerFactory21968 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setContentHandlerFactory21968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URLConnection21969;
		protected URLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._URLConnection21969.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._URLConnection21969 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._URLConnection21969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static URLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLConnection))]
	internal sealed partial class URLConnection_ : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _connect21970;
		public override void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection_.staticClass, "connect", "()V", ref global::java.net.URLConnection_._connect21970);
		}
		static URLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
