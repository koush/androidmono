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
		internal static global::MonoJavaBridge.MethodId _toString21920;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._toString21920)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._toString21920)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getURL21921;
		public virtual global::java.net.URL getURL()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getURL21921)) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getURL21921)) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21922;
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent21922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent21922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getContent21923;
		public virtual global::java.lang.Object getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContent21923)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent21923)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream21924;
		public virtual global::java.io.InputStream getInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getInputStream21924)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getInputStream21924)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getPermission21925;
		public virtual global::java.security.Permission getPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getPermission21925)) as java.security.Permission;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getPermission21925)) as java.security.Permission;
		}
		internal static global::MonoJavaBridge.MethodId _connect21926;
		public abstract void connect();
		internal static global::MonoJavaBridge.MethodId _setRequestProperty21927;
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setRequestProperty21927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setRequestProperty21927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDate21928;
		public virtual long getDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getDate21928);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDate21928);
		}
		internal static global::MonoJavaBridge.MethodId _getContentType21929;
		public virtual global::java.lang.String getContentType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentType21929)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentType21929)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength21930;
		public virtual int getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getContentLength21930);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentLength21930);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21931;
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField21931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField21931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderField21932;
		public virtual global::java.lang.String getHeaderField(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderField21932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField21932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldKey21933;
		public virtual global::java.lang.String getHeaderFieldKey(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldKey21933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldKey21933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLastModified21934;
		public virtual long getLastModified()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getLastModified21934);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getLastModified21934);
		}
		internal static global::MonoJavaBridge.MethodId _getFileNameMap21935;
		public static global::java.net.FileNameMap getFileNameMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.net.FileNameMap>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getFileNameMap21935)) as java.net.FileNameMap;
		}
		internal static global::MonoJavaBridge.MethodId _addRequestProperty21936;
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._addRequestProperty21936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._addRequestProperty21936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperty21937;
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperty21937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperty21937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRequestProperties21938;
		public virtual global::java.util.Map getRequestProperties()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getRequestProperties21938)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperties21938)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromStream21939;
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromStream21939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _guessContentTypeFromName21940;
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromName21940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setFileNameMap21941;
		public static void setFileNameMap(java.net.FileNameMap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setFileNameMap21941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setConnectTimeout21942;
		public virtual void setConnectTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setConnectTimeout21942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setConnectTimeout21942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnectTimeout21943;
		public virtual int getConnectTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getConnectTimeout21943);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getConnectTimeout21943);
		}
		internal static global::MonoJavaBridge.MethodId _setReadTimeout21944;
		public virtual void setReadTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setReadTimeout21944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setReadTimeout21944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getReadTimeout21945;
		public virtual int getReadTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getReadTimeout21945);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getReadTimeout21945);
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding21946;
		public virtual global::java.lang.String getContentEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getContentEncoding21946)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentEncoding21946)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExpiration21947;
		public virtual long getExpiration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getExpiration21947);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getExpiration21947);
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFields21948;
		public virtual global::java.util.Map getHeaderFields()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFields21948)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFields21948)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldInt21949;
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldInt21949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldInt21949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaderFieldDate21950;
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getHeaderFieldDate21950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldDate21950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream21951;
		public virtual global::java.io.OutputStream getOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.URLConnection._getOutputStream21951)) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getOutputStream21951)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setDoInput21952;
		public virtual void setDoInput(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoInput21952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoInput21952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoInput21953;
		public virtual bool getDoInput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoInput21953);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoInput21953);
		}
		internal static global::MonoJavaBridge.MethodId _setDoOutput21954;
		public virtual void setDoOutput(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDoOutput21954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoOutput21954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDoOutput21955;
		public virtual bool getDoOutput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDoOutput21955);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoOutput21955);
		}
		internal static global::MonoJavaBridge.MethodId _setAllowUserInteraction21956;
		public virtual void setAllowUserInteraction(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setAllowUserInteraction21956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setAllowUserInteraction21956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAllowUserInteraction21957;
		public virtual bool getAllowUserInteraction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getAllowUserInteraction21957);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getAllowUserInteraction21957);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultAllowUserInteraction21958;
		public static void setDefaultAllowUserInteraction(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultAllowUserInteraction21958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultAllowUserInteraction21959;
		public static bool getDefaultAllowUserInteraction()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultAllowUserInteraction21959);
		}
		internal static global::MonoJavaBridge.MethodId _setUseCaches21960;
		public virtual void setUseCaches(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setUseCaches21960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setUseCaches21960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUseCaches21961;
		public virtual bool getUseCaches()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getUseCaches21961);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getUseCaches21961);
		}
		internal static global::MonoJavaBridge.MethodId _setIfModifiedSince21962;
		public virtual void setIfModifiedSince(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setIfModifiedSince21962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setIfModifiedSince21962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getIfModifiedSince21963;
		public virtual long getIfModifiedSince()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.net.URLConnection._getIfModifiedSince21963);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getIfModifiedSince21963);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultUseCaches21964;
		public virtual bool getDefaultUseCaches()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.net.URLConnection._getDefaultUseCaches21964);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultUseCaches21964);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultUseCaches21965;
		public virtual void setDefaultUseCaches(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection._setDefaultUseCaches21965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultUseCaches21965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultRequestProperty21966;
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultRequestProperty21966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultRequestProperty21967;
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultRequestProperty21967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setContentHandlerFactory21968;
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setContentHandlerFactory21968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _URLConnection21969;
		protected URLConnection(java.net.URL arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._URLConnection21969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection._toString21920 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;");
			global::java.net.URLConnection._getURL21921 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;");
			global::java.net.URLConnection._getContent21922 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.URLConnection._getContent21923 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;");
			global::java.net.URLConnection._getInputStream21924 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			global::java.net.URLConnection._getPermission21925 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;");
			global::java.net.URLConnection._connect21926 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "connect", "()V");
			global::java.net.URLConnection._setRequestProperty21927 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDate21928 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDate", "()J");
			global::java.net.URLConnection._getContentType21929 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;");
			global::java.net.URLConnection._getContentLength21930 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentLength", "()I");
			global::java.net.URLConnection._getHeaderField21931 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderField21932 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getHeaderFieldKey21933 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;");
			global::java.net.URLConnection._getLastModified21934 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getLastModified", "()J");
			global::java.net.URLConnection._getFileNameMap21935 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;");
			global::java.net.URLConnection._addRequestProperty21936 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getRequestProperty21937 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._getRequestProperties21938 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;");
			global::java.net.URLConnection._guessContentTypeFromStream21939 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			global::java.net.URLConnection._guessContentTypeFromName21940 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setFileNameMap21941 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V");
			global::java.net.URLConnection._setConnectTimeout21942 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V");
			global::java.net.URLConnection._getConnectTimeout21943 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I");
			global::java.net.URLConnection._setReadTimeout21944 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V");
			global::java.net.URLConnection._getReadTimeout21945 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getReadTimeout", "()I");
			global::java.net.URLConnection._getContentEncoding21946 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;");
			global::java.net.URLConnection._getExpiration21947 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getExpiration", "()J");
			global::java.net.URLConnection._getHeaderFields21948 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;");
			global::java.net.URLConnection._getHeaderFieldInt21949 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I");
			global::java.net.URLConnection._getHeaderFieldDate21950 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J");
			global::java.net.URLConnection._getOutputStream21951 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			global::java.net.URLConnection._setDoInput21952 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V");
			global::java.net.URLConnection._getDoInput21953 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoInput", "()Z");
			global::java.net.URLConnection._setDoOutput21954 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V");
			global::java.net.URLConnection._getDoOutput21955 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDoOutput", "()Z");
			global::java.net.URLConnection._setAllowUserInteraction21956 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getAllowUserInteraction21957 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setDefaultAllowUserInteraction21958 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V");
			global::java.net.URLConnection._getDefaultAllowUserInteraction21959 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z");
			global::java.net.URLConnection._setUseCaches21960 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V");
			global::java.net.URLConnection._getUseCaches21961 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getUseCaches", "()Z");
			global::java.net.URLConnection._setIfModifiedSince21962 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V");
			global::java.net.URLConnection._getIfModifiedSince21963 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J");
			global::java.net.URLConnection._getDefaultUseCaches21964 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z");
			global::java.net.URLConnection._setDefaultUseCaches21965 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V");
			global::java.net.URLConnection._setDefaultRequestProperty21966 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.net.URLConnection._getDefaultRequestProperty21967 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.net.URLConnection._setContentHandlerFactory21968 = @__env.GetStaticMethodIDNoThrow(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V");
			global::java.net.URLConnection._URLConnection21969 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.URLConnection))]
	internal sealed partial class URLConnection_ : java.net.URLConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static URLConnection_()
		{
			InitJNI();
		}
		internal URLConnection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _connect21970;
		public override void connect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.URLConnection_._connect21970);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.URLConnection_.staticClass, global::java.net.URLConnection_._connect21970);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URLConnection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URLConnection"));
			global::java.net.URLConnection_._connect21970 = @__env.GetMethodIDNoThrow(global::java.net.URLConnection_.staticClass, "connect", "()V");
		}
	}
}
