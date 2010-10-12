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
		internal static global::MonoJavaBridge.MethodId _toString13914;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._toString13914)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._toString13914)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURL13915;
		public virtual global::java.net.URL getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getURL13915)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getURL13915)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getContent13916;
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent13916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent13916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContent13917;
		public virtual global::java.lang.Object getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent13917)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent13917)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream13918;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getInputStream13918)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getInputStream13918)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getPermission13919;
		public virtual global::java.security.Permission getPermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getPermission13919)) as java.security.Permission;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getPermission13919)) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _connect13920;
		public abstract void connect();
		internal static global::MonoJavaBridge.MethodId _setRequestProperty13921;
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setRequestProperty13921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setRequestProperty13921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDate13922;
		public virtual long getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getDate13922);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDate13922);
		}
		internal static global::MonoJavaBridge.MethodId _getContentType13923;
		public virtual global::java.lang.String getContentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentType13923)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentType13923)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength13924;
		public virtual int getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getContentLength13924);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentLength13924);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField13925;
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField13925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField13925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField13926;
		public virtual global::java.lang.String getHeaderField(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField13926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField13926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey13927;
		public virtual global::java.lang.String getHeaderFieldKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldKey13927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldKey13927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLastModified13928;
		public virtual long getLastModified() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getLastModified13928);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getLastModified13928);
		}
		internal static global::MonoJavaBridge.MethodId _getFileNameMap13929;
		public static global::java.net.FileNameMap getFileNameMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.net.FileNameMap>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getFileNameMap13929)) as java.net.FileNameMap;
		}
		internal static global::MonoJavaBridge.MethodId _addRequestProperty13930;
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._addRequestProperty13930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._addRequestProperty13930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperty13931;
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperty13931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperty13931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperties13932;
		public virtual global::java.util.Map getRequestProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperties13932)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperties13932)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromStream13933;
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromStream13933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromName13934;
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromName13934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileNameMap13935;
		public static void setFileNameMap(java.net.FileNameMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setFileNameMap13935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectTimeout13936;
		public virtual void setConnectTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setConnectTimeout13936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setConnectTimeout13936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectTimeout13937;
		public virtual int getConnectTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getConnectTimeout13937);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getConnectTimeout13937);
		}
		internal static global::MonoJavaBridge.MethodId _setReadTimeout13938;
		public virtual void setReadTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setReadTimeout13938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setReadTimeout13938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadTimeout13939;
		public virtual int getReadTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getReadTimeout13939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getReadTimeout13939);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding13940;
		public virtual global::java.lang.String getContentEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentEncoding13940)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentEncoding13940)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiration13941;
		public virtual long getExpiration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getExpiration13941);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getExpiration13941);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFields13942;
		public virtual global::java.util.Map getHeaderFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFields13942)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFields13942)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldInt13943;
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldInt13943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldInt13943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate13944;
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldDate13944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldDate13944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream13945;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getOutputStream13945)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getOutputStream13945)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setDoInput13946;
		public virtual void setDoInput(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoInput13946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoInput13946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoInput13947;
		public virtual bool getDoInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoInput13947);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoInput13947);
		}
		internal static global::MonoJavaBridge.MethodId _setDoOutput13948;
		public virtual void setDoOutput(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoOutput13948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoOutput13948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoOutput13949;
		public virtual bool getDoOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoOutput13949);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoOutput13949);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUserInteraction13950;
		public virtual void setAllowUserInteraction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setAllowUserInteraction13950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setAllowUserInteraction13950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowUserInteraction13951;
		public virtual bool getAllowUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getAllowUserInteraction13951);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getAllowUserInteraction13951);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAllowUserInteraction13952;
		public static void setDefaultAllowUserInteraction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultAllowUserInteraction13952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAllowUserInteraction13953;
		public static bool getDefaultAllowUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultAllowUserInteraction13953);
		}
		internal static global::MonoJavaBridge.MethodId _setUseCaches13954;
		public virtual void setUseCaches(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setUseCaches13954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setUseCaches13954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseCaches13955;
		public virtual bool getUseCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getUseCaches13955);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getUseCaches13955);
		}
		internal static global::MonoJavaBridge.MethodId _setIfModifiedSince13956;
		public virtual void setIfModifiedSince(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setIfModifiedSince13956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setIfModifiedSince13956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIfModifiedSince13957;
		public virtual long getIfModifiedSince() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getIfModifiedSince13957);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getIfModifiedSince13957);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUseCaches13958;
		public virtual bool getDefaultUseCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDefaultUseCaches13958);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultUseCaches13958);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUseCaches13959;
		public virtual void setDefaultUseCaches(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDefaultUseCaches13959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultUseCaches13959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultRequestProperty13960;
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultRequestProperty13960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultRequestProperty13961;
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultRequestProperty13961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandlerFactory13962;
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setContentHandlerFactory13962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URLConnection13963;
		protected URLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._URLConnection13963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection._toString13914 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URLConnection._getURL13915 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;");
			global::java.net.URLConnection._getContent13916 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URLConnection._getContent13917 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URLConnection._getInputStream13918 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.URLConnection._getPermission13919 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;");
			global::java.net.URLConnection._connect13920 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "connect", "()V");
			global::java.net.URLConnection._setRequestProperty13921 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDate13922 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDate", "()J");
			global::java.net.URLConnection._getContentType13923 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;");
			global::java.net.URLConnection._getContentLength13924 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentLength", "()I");
			global::java.net.URLConnection._getHeaderField13925 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderField13926 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderFieldKey13927 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getLastModified13928 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getLastModified", "()J");
			global::java.net.URLConnection._getFileNameMap13929 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;");
			global::java.net.URLConnection._addRequestProperty13930 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getRequestProperty13931 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getRequestProperties13932 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;");
			global::java.net.URLConnection._guessContentTypeFromStream13933 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			global::java.net.URLConnection._guessContentTypeFromName13934 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setFileNameMap13935 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V");
			global::java.net.URLConnection._setConnectTimeout13936 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V");
			global::java.net.URLConnection._getConnectTimeout13937 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I");
			global::java.net.URLConnection._setReadTimeout13938 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V");
			global::java.net.URLConnection._getReadTimeout13939 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getReadTimeout", "()I");
			global::java.net.URLConnection._getContentEncoding13940 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;");
			global::java.net.URLConnection._getExpiration13941 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getExpiration", "()J");
			global::java.net.URLConnection._getHeaderFields13942 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;");
			global::java.net.URLConnection._getHeaderFieldInt13943 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I");
			global::java.net.URLConnection._getHeaderFieldDate13944 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J");
			global::java.net.URLConnection._getOutputStream13945 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.URLConnection._setDoInput13946 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V");
			global::java.net.URLConnection._getDoInput13947 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoInput", "()Z");
			global::java.net.URLConnection._setDoOutput13948 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V");
			global::java.net.URLConnection._getDoOutput13949 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoOutput", "()Z");
			global::java.net.URLConnection._setAllowUserInteraction13950 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getAllowUserInteraction13951 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setDefaultAllowUserInteraction13952 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getDefaultAllowUserInteraction13953 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setUseCaches13954 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V");
			global::java.net.URLConnection._getUseCaches13955 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getUseCaches", "()Z");
			global::java.net.URLConnection._setIfModifiedSince13956 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V");
			global::java.net.URLConnection._getIfModifiedSince13957 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J");
			global::java.net.URLConnection._getDefaultUseCaches13958 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z");
			global::java.net.URLConnection._setDefaultUseCaches13959 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V");
			global::java.net.URLConnection._setDefaultRequestProperty13960 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDefaultRequestProperty13961 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setContentHandlerFactory13962 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V");
			global::java.net.URLConnection._URLConnection13963 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
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
		internal static global::MonoJavaBridge.MethodId _connect13964;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection_._connect13964);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection_.staticClass, global::java.net.URLConnection_._connect13964);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection_._connect13964 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection_.staticClass, "connect", "()V");
		}
	}
}
