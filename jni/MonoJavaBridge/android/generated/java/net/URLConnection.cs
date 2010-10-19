namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.URLConnection_))]
	public abstract partial class URLConnection : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLConnection()
		{
			InitJNI();
		}
		protected URLConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString16207;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._toString16207)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._toString16207)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURL16208;
		public virtual global::java.net.URL getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getURL16208)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getURL16208)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getContent16209;
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent16209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent16209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContent16210;
		public virtual global::java.lang.Object getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent16210)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent16210)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream16211;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getInputStream16211)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getInputStream16211)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getPermission16212;
		public virtual global::java.security.Permission getPermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getPermission16212)) as java.security.Permission;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getPermission16212)) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _connect16213;
		public abstract void connect();
		internal static global::MonoJavaBridge.MethodId _setRequestProperty16214;
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setRequestProperty16214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setRequestProperty16214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDate16215;
		public virtual long getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getDate16215);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDate16215);
		}
		internal static global::MonoJavaBridge.MethodId _getContentType16216;
		public virtual global::java.lang.String getContentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentType16216)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentType16216)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength16217;
		public virtual int getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getContentLength16217);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentLength16217);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField16218;
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField16218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField16218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField16219;
		public virtual global::java.lang.String getHeaderField(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField16219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField16219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey16220;
		public virtual global::java.lang.String getHeaderFieldKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldKey16220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldKey16220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLastModified16221;
		public virtual long getLastModified() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getLastModified16221);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getLastModified16221);
		}
		internal static global::MonoJavaBridge.MethodId _getFileNameMap16222;
		public static global::java.net.FileNameMap getFileNameMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.net.FileNameMap>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getFileNameMap16222)) as java.net.FileNameMap;
		}
		internal static global::MonoJavaBridge.MethodId _addRequestProperty16223;
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._addRequestProperty16223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._addRequestProperty16223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperty16224;
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperty16224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperty16224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperties16225;
		public virtual global::java.util.Map getRequestProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperties16225)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperties16225)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromStream16226;
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromStream16226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromName16227;
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromName16227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileNameMap16228;
		public static void setFileNameMap(java.net.FileNameMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setFileNameMap16228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectTimeout16229;
		public virtual void setConnectTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setConnectTimeout16229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setConnectTimeout16229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectTimeout16230;
		public virtual int getConnectTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getConnectTimeout16230);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getConnectTimeout16230);
		}
		internal static global::MonoJavaBridge.MethodId _setReadTimeout16231;
		public virtual void setReadTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setReadTimeout16231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setReadTimeout16231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadTimeout16232;
		public virtual int getReadTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getReadTimeout16232);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getReadTimeout16232);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding16233;
		public virtual global::java.lang.String getContentEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentEncoding16233)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentEncoding16233)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiration16234;
		public virtual long getExpiration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getExpiration16234);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getExpiration16234);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFields16235;
		public virtual global::java.util.Map getHeaderFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFields16235)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFields16235)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldInt16236;
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldInt16236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldInt16236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate16237;
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldDate16237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldDate16237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream16238;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getOutputStream16238)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getOutputStream16238)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setDoInput16239;
		public virtual void setDoInput(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoInput16239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoInput16239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoInput16240;
		public virtual bool getDoInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoInput16240);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoInput16240);
		}
		internal static global::MonoJavaBridge.MethodId _setDoOutput16241;
		public virtual void setDoOutput(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoOutput16241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoOutput16241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoOutput16242;
		public virtual bool getDoOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoOutput16242);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoOutput16242);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUserInteraction16243;
		public virtual void setAllowUserInteraction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setAllowUserInteraction16243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setAllowUserInteraction16243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowUserInteraction16244;
		public virtual bool getAllowUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getAllowUserInteraction16244);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getAllowUserInteraction16244);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAllowUserInteraction16245;
		public static void setDefaultAllowUserInteraction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultAllowUserInteraction16245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAllowUserInteraction16246;
		public static bool getDefaultAllowUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultAllowUserInteraction16246);
		}
		internal static global::MonoJavaBridge.MethodId _setUseCaches16247;
		public virtual void setUseCaches(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setUseCaches16247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setUseCaches16247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseCaches16248;
		public virtual bool getUseCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getUseCaches16248);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getUseCaches16248);
		}
		internal static global::MonoJavaBridge.MethodId _setIfModifiedSince16249;
		public virtual void setIfModifiedSince(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setIfModifiedSince16249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setIfModifiedSince16249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIfModifiedSince16250;
		public virtual long getIfModifiedSince() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getIfModifiedSince16250);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getIfModifiedSince16250);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUseCaches16251;
		public virtual bool getDefaultUseCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDefaultUseCaches16251);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultUseCaches16251);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUseCaches16252;
		public virtual void setDefaultUseCaches(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDefaultUseCaches16252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultUseCaches16252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultRequestProperty16253;
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultRequestProperty16253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultRequestProperty16254;
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultRequestProperty16254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandlerFactory16255;
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setContentHandlerFactory16255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URLConnection16256;
		protected URLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._URLConnection16256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection._toString16207 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URLConnection._getURL16208 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;");
			global::java.net.URLConnection._getContent16209 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URLConnection._getContent16210 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URLConnection._getInputStream16211 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.URLConnection._getPermission16212 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;");
			global::java.net.URLConnection._connect16213 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "connect", "()V");
			global::java.net.URLConnection._setRequestProperty16214 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDate16215 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDate", "()J");
			global::java.net.URLConnection._getContentType16216 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;");
			global::java.net.URLConnection._getContentLength16217 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentLength", "()I");
			global::java.net.URLConnection._getHeaderField16218 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderField16219 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderFieldKey16220 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getLastModified16221 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getLastModified", "()J");
			global::java.net.URLConnection._getFileNameMap16222 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;");
			global::java.net.URLConnection._addRequestProperty16223 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getRequestProperty16224 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getRequestProperties16225 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;");
			global::java.net.URLConnection._guessContentTypeFromStream16226 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			global::java.net.URLConnection._guessContentTypeFromName16227 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setFileNameMap16228 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V");
			global::java.net.URLConnection._setConnectTimeout16229 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V");
			global::java.net.URLConnection._getConnectTimeout16230 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I");
			global::java.net.URLConnection._setReadTimeout16231 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V");
			global::java.net.URLConnection._getReadTimeout16232 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getReadTimeout", "()I");
			global::java.net.URLConnection._getContentEncoding16233 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;");
			global::java.net.URLConnection._getExpiration16234 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getExpiration", "()J");
			global::java.net.URLConnection._getHeaderFields16235 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;");
			global::java.net.URLConnection._getHeaderFieldInt16236 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I");
			global::java.net.URLConnection._getHeaderFieldDate16237 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J");
			global::java.net.URLConnection._getOutputStream16238 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.URLConnection._setDoInput16239 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V");
			global::java.net.URLConnection._getDoInput16240 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoInput", "()Z");
			global::java.net.URLConnection._setDoOutput16241 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V");
			global::java.net.URLConnection._getDoOutput16242 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoOutput", "()Z");
			global::java.net.URLConnection._setAllowUserInteraction16243 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getAllowUserInteraction16244 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setDefaultAllowUserInteraction16245 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getDefaultAllowUserInteraction16246 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setUseCaches16247 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V");
			global::java.net.URLConnection._getUseCaches16248 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getUseCaches", "()Z");
			global::java.net.URLConnection._setIfModifiedSince16249 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V");
			global::java.net.URLConnection._getIfModifiedSince16250 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J");
			global::java.net.URLConnection._getDefaultUseCaches16251 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z");
			global::java.net.URLConnection._setDefaultUseCaches16252 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V");
			global::java.net.URLConnection._setDefaultRequestProperty16253 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDefaultRequestProperty16254 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setContentHandlerFactory16255 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V");
			global::java.net.URLConnection._URLConnection16256 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLConnection))]
	public sealed partial class URLConnection_ : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLConnection_()
		{
			InitJNI();
		}
		internal URLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _connect16257;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection_._connect16257);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection_.staticClass, global::java.net.URLConnection_._connect16257);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection_._connect16257 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection_.staticClass, "connect", "()V");
		}
	}
}
