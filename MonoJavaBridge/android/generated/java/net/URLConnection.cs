namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.URLConnection_))]
	public abstract partial class URLConnection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;", ref global::java.net.URLConnection._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.net.URL getURL()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;", ref global::java.net.URLConnection._m1) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", ref global::java.net.URLConnection._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;", ref global::java.net.URLConnection._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.io.InputStream getInputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::java.net.URLConnection._m4) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.Permission getPermission()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;", ref global::java.net.URLConnection._m5) as java.security.Permission;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract void connect();
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.net.URLConnection._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long getDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getDate", "()J", ref global::java.net.URLConnection._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;", ref global::java.net.URLConnection._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getContentLength", "()I", ref global::java.net.URLConnection._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.net.URLConnection._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String getHeaderField(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;", ref global::java.net.URLConnection._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getHeaderFieldKey(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;", ref global::java.net.URLConnection._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual long getLastModified()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getLastModified", "()J", ref global::java.net.URLConnection._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::java.net.FileNameMap getFileNameMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m15.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m15 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.net.FileNameMap>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m15)) as java.net.FileNameMap;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.net.URLConnection._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.net.URLConnection._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.util.Map getRequestProperties()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;", ref global::java.net.URLConnection._m18) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m19.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m19 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m20.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m20 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void setFileNameMap(java.net.FileNameMap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m21.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m21 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setConnectTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V", ref global::java.net.URLConnection._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getConnectTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I", ref global::java.net.URLConnection._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setReadTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V", ref global::java.net.URLConnection._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual int getReadTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getReadTimeout", "()I", ref global::java.net.URLConnection._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.lang.String getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;", ref global::java.net.URLConnection._m26) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual long getExpiration()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getExpiration", "()J", ref global::java.net.URLConnection._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.util.Map getHeaderFields()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;", ref global::java.net.URLConnection._m28) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I", ref global::java.net.URLConnection._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J", ref global::java.net.URLConnection._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;", ref global::java.net.URLConnection._m31) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setDoInput(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V", ref global::java.net.URLConnection._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual bool getDoInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getDoInput", "()Z", ref global::java.net.URLConnection._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setDoOutput(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V", ref global::java.net.URLConnection._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual bool getDoOutput()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getDoOutput", "()Z", ref global::java.net.URLConnection._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setAllowUserInteraction(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V", ref global::java.net.URLConnection._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual bool getAllowUserInteraction()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z", ref global::java.net.URLConnection._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static void setDefaultAllowUserInteraction(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m38.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m38 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static bool getDefaultAllowUserInteraction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m39.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m39 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z");
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m39);
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void setUseCaches(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V", ref global::java.net.URLConnection._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual bool getUseCaches()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getUseCaches", "()Z", ref global::java.net.URLConnection._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void setIfModifiedSince(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V", ref global::java.net.URLConnection._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual long getIfModifiedSince()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J", ref global::java.net.URLConnection._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool getDefaultUseCaches()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z", ref global::java.net.URLConnection._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual void setDefaultUseCaches(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V", ref global::java.net.URLConnection._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m46.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m46 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m47.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m47 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m48.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m48 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V");
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		protected URLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URLConnection._m49.native == global::System.IntPtr.Zero)
				global::java.net.URLConnection._m49 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static URLConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLConnection))]
	internal sealed partial class URLConnection_ : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal URLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void connect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.URLConnection_.staticClass, "connect", "()V", ref global::java.net.URLConnection_._m0);
		}
		static URLConnection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
		}
	}
}
