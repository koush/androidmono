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
		internal static global::MonoJavaBridge.MethodId _toString21801;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._toString21801)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._toString21801)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURL21802;
		public virtual global::java.net.URL getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getURL21802)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getURL21802)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21803;
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent21803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent21803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21804;
		public virtual global::java.lang.Object getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent21804)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent21804)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21805;
		public virtual global::java.io.InputStream getInputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getInputStream21805)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getInputStream21805)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getPermission21806;
		public virtual global::java.security.Permission getPermission() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getPermission21806)) as java.security.Permission;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getPermission21806)) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _connect21807;
		public abstract void connect();
		internal static global::MonoJavaBridge.MethodId _setRequestProperty21808;
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setRequestProperty21808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setRequestProperty21808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDate21809;
		public virtual long getDate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getDate21809);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDate21809);
		}
		internal static global::MonoJavaBridge.MethodId _getContentType21810;
		public virtual global::java.lang.String getContentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentType21810)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentType21810)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength21811;
		public virtual int getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getContentLength21811);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentLength21811);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21812;
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField21812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField21812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21813;
		public virtual global::java.lang.String getHeaderField(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField21813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField21813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey21814;
		public virtual global::java.lang.String getHeaderFieldKey(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldKey21814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldKey21814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLastModified21815;
		public virtual long getLastModified() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getLastModified21815);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getLastModified21815);
		}
		internal static global::MonoJavaBridge.MethodId _getFileNameMap21816;
		public static global::java.net.FileNameMap getFileNameMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.net.FileNameMap>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getFileNameMap21816)) as java.net.FileNameMap;
		}
		internal static global::MonoJavaBridge.MethodId _addRequestProperty21817;
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._addRequestProperty21817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._addRequestProperty21817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperty21818;
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperty21818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperty21818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperties21819;
		public virtual global::java.util.Map getRequestProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperties21819)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperties21819)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromStream21820;
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromStream21820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromName21821;
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromName21821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileNameMap21822;
		public static void setFileNameMap(java.net.FileNameMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setFileNameMap21822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectTimeout21823;
		public virtual void setConnectTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setConnectTimeout21823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setConnectTimeout21823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectTimeout21824;
		public virtual int getConnectTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getConnectTimeout21824);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getConnectTimeout21824);
		}
		internal static global::MonoJavaBridge.MethodId _setReadTimeout21825;
		public virtual void setReadTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setReadTimeout21825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setReadTimeout21825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadTimeout21826;
		public virtual int getReadTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getReadTimeout21826);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getReadTimeout21826);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding21827;
		public virtual global::java.lang.String getContentEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentEncoding21827)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentEncoding21827)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiration21828;
		public virtual long getExpiration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getExpiration21828);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getExpiration21828);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFields21829;
		public virtual global::java.util.Map getHeaderFields() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFields21829)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFields21829)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldInt21830;
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldInt21830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldInt21830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate21831;
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldDate21831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldDate21831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21832;
		public virtual global::java.io.OutputStream getOutputStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getOutputStream21832)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getOutputStream21832)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setDoInput21833;
		public virtual void setDoInput(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoInput21833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoInput21833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoInput21834;
		public virtual bool getDoInput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoInput21834);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoInput21834);
		}
		internal static global::MonoJavaBridge.MethodId _setDoOutput21835;
		public virtual void setDoOutput(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoOutput21835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoOutput21835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoOutput21836;
		public virtual bool getDoOutput() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoOutput21836);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoOutput21836);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUserInteraction21837;
		public virtual void setAllowUserInteraction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setAllowUserInteraction21837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setAllowUserInteraction21837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowUserInteraction21838;
		public virtual bool getAllowUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getAllowUserInteraction21838);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getAllowUserInteraction21838);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAllowUserInteraction21839;
		public static void setDefaultAllowUserInteraction(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultAllowUserInteraction21839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAllowUserInteraction21840;
		public static bool getDefaultAllowUserInteraction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultAllowUserInteraction21840);
		}
		internal static global::MonoJavaBridge.MethodId _setUseCaches21841;
		public virtual void setUseCaches(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setUseCaches21841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setUseCaches21841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseCaches21842;
		public virtual bool getUseCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getUseCaches21842);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getUseCaches21842);
		}
		internal static global::MonoJavaBridge.MethodId _setIfModifiedSince21843;
		public virtual void setIfModifiedSince(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setIfModifiedSince21843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setIfModifiedSince21843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIfModifiedSince21844;
		public virtual long getIfModifiedSince() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getIfModifiedSince21844);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getIfModifiedSince21844);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUseCaches21845;
		public virtual bool getDefaultUseCaches() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDefaultUseCaches21845);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultUseCaches21845);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUseCaches21846;
		public virtual void setDefaultUseCaches(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDefaultUseCaches21846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultUseCaches21846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultRequestProperty21847;
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultRequestProperty21847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultRequestProperty21848;
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultRequestProperty21848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandlerFactory21849;
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setContentHandlerFactory21849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URLConnection21850;
		protected URLConnection(java.net.URL arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._URLConnection21850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection._toString21801 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URLConnection._getURL21802 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;");
			global::java.net.URLConnection._getContent21803 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URLConnection._getContent21804 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URLConnection._getInputStream21805 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.URLConnection._getPermission21806 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;");
			global::java.net.URLConnection._connect21807 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "connect", "()V");
			global::java.net.URLConnection._setRequestProperty21808 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDate21809 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDate", "()J");
			global::java.net.URLConnection._getContentType21810 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;");
			global::java.net.URLConnection._getContentLength21811 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentLength", "()I");
			global::java.net.URLConnection._getHeaderField21812 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderField21813 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderFieldKey21814 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getLastModified21815 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getLastModified", "()J");
			global::java.net.URLConnection._getFileNameMap21816 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;");
			global::java.net.URLConnection._addRequestProperty21817 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getRequestProperty21818 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getRequestProperties21819 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;");
			global::java.net.URLConnection._guessContentTypeFromStream21820 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			global::java.net.URLConnection._guessContentTypeFromName21821 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setFileNameMap21822 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V");
			global::java.net.URLConnection._setConnectTimeout21823 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V");
			global::java.net.URLConnection._getConnectTimeout21824 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I");
			global::java.net.URLConnection._setReadTimeout21825 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V");
			global::java.net.URLConnection._getReadTimeout21826 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getReadTimeout", "()I");
			global::java.net.URLConnection._getContentEncoding21827 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;");
			global::java.net.URLConnection._getExpiration21828 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getExpiration", "()J");
			global::java.net.URLConnection._getHeaderFields21829 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;");
			global::java.net.URLConnection._getHeaderFieldInt21830 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I");
			global::java.net.URLConnection._getHeaderFieldDate21831 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J");
			global::java.net.URLConnection._getOutputStream21832 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.URLConnection._setDoInput21833 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V");
			global::java.net.URLConnection._getDoInput21834 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoInput", "()Z");
			global::java.net.URLConnection._setDoOutput21835 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V");
			global::java.net.URLConnection._getDoOutput21836 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoOutput", "()Z");
			global::java.net.URLConnection._setAllowUserInteraction21837 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getAllowUserInteraction21838 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setDefaultAllowUserInteraction21839 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getDefaultAllowUserInteraction21840 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setUseCaches21841 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V");
			global::java.net.URLConnection._getUseCaches21842 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getUseCaches", "()Z");
			global::java.net.URLConnection._setIfModifiedSince21843 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V");
			global::java.net.URLConnection._getIfModifiedSince21844 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J");
			global::java.net.URLConnection._getDefaultUseCaches21845 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z");
			global::java.net.URLConnection._setDefaultUseCaches21846 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V");
			global::java.net.URLConnection._setDefaultRequestProperty21847 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDefaultRequestProperty21848 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setContentHandlerFactory21849 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V");
			global::java.net.URLConnection._URLConnection21850 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
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
		internal static global::MonoJavaBridge.MethodId _connect21851;
		public override void connect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection_._connect21851);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection_.staticClass, global::java.net.URLConnection_._connect21851);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection_._connect21851 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection_.staticClass, "connect", "()V");
		}
	}
}
