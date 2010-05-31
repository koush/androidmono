namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class URLConnection : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static URLConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.URLConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected URLConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11932; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._toString11932)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._toString11932)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getURL11933; 
		public virtual global::java.net.URL getURL() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getURL11933)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getURL11933)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContent11934; 
		public virtual global::java.lang.Object getContent(java.lang.Class[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getContent11934, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent11934, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContent11935; 
		public virtual global::java.lang.Object getContent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getContent11935)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContent11935)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream11936; 
		public virtual global::java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getInputStream11936)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getInputStream11936)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPermission11937; 
		public virtual global::java.security.Permission getPermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Permission>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getPermission11937)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Permission>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getPermission11937)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11938; 
		public abstract void connect(); 
		internal static global::net.sf.jni4net.jni.MethodId _setRequestProperty11939; 
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setRequestProperty11939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setRequestProperty11939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDate11940; 
		public virtual long getDate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.net.URLConnection._getDate11940); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDate11940); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentType11941; 
		public virtual global::java.lang.String getContentType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getContentType11941)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentType11941)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentLength11942; 
		public virtual int getContentLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.URLConnection._getContentLength11942); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentLength11942); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderField11943; 
		public virtual global::java.lang.String getHeaderField(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getHeaderField11943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField11943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderField11944; 
		public virtual global::java.lang.String getHeaderField(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getHeaderField11944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderField11944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFieldKey11945; 
		public virtual global::java.lang.String getHeaderFieldKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getHeaderFieldKey11945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldKey11945, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLastModified11946; 
		public virtual long getLastModified() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.net.URLConnection._getLastModified11946); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getLastModified11946); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileNameMap11947; 
		public static global::java.net.FileNameMap getFileNameMap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.net.FileNameMap>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, global::java.net.URLConnection._getFileNameMap11947)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRequestProperty11948; 
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._addRequestProperty11948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._addRequestProperty11948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRequestProperty11949; 
		public virtual global::java.lang.String getRequestProperty(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getRequestProperty11949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperty11949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRequestProperties11950; 
		public virtual global::java.util.Map getRequestProperties() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getRequestProperties11950)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getRequestProperties11950)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _guessContentTypeFromStream11951; 
		public static global::java.lang.String guessContentTypeFromStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromStream11951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _guessContentTypeFromName11952; 
		public static global::java.lang.String guessContentTypeFromName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, global::java.net.URLConnection._guessContentTypeFromName11952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFileNameMap11953; 
		public static void setFileNameMap(java.net.FileNameMap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setFileNameMap11953, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConnectTimeout11954; 
		public virtual void setConnectTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setConnectTimeout11954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setConnectTimeout11954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnectTimeout11955; 
		public virtual int getConnectTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.URLConnection._getConnectTimeout11955); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getConnectTimeout11955); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReadTimeout11956; 
		public virtual void setReadTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setReadTimeout11956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setReadTimeout11956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReadTimeout11957; 
		public virtual int getReadTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.URLConnection._getReadTimeout11957); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getReadTimeout11957); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentEncoding11958; 
		public virtual global::java.lang.String getContentEncoding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getContentEncoding11958)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getContentEncoding11958)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpiration11959; 
		public virtual long getExpiration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.net.URLConnection._getExpiration11959); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getExpiration11959); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFields11960; 
		public virtual global::java.util.Map getHeaderFields() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getHeaderFields11960)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFields11960)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFieldInt11961; 
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.URLConnection._getHeaderFieldInt11961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldInt11961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFieldDate11962; 
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.net.URLConnection._getHeaderFieldDate11962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getHeaderFieldDate11962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream11963; 
		public virtual global::java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.URLConnection._getOutputStream11963)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getOutputStream11963)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDoInput11964; 
		public virtual void setDoInput(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setDoInput11964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoInput11964, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoInput11965; 
		public virtual bool getDoInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.URLConnection._getDoInput11965); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoInput11965); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDoOutput11966; 
		public virtual void setDoOutput(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setDoOutput11966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDoOutput11966, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoOutput11967; 
		public virtual bool getDoOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.URLConnection._getDoOutput11967); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDoOutput11967); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllowUserInteraction11968; 
		public virtual void setAllowUserInteraction(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setAllowUserInteraction11968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setAllowUserInteraction11968, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowUserInteraction11969; 
		public virtual bool getAllowUserInteraction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.URLConnection._getAllowUserInteraction11969); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getAllowUserInteraction11969); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultAllowUserInteraction11970; 
		public static void setDefaultAllowUserInteraction(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultAllowUserInteraction11970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultAllowUserInteraction11971; 
		public static bool getDefaultAllowUserInteraction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultAllowUserInteraction11971); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUseCaches11972; 
		public virtual void setUseCaches(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setUseCaches11972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setUseCaches11972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUseCaches11973; 
		public virtual bool getUseCaches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.URLConnection._getUseCaches11973); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getUseCaches11973); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIfModifiedSince11974; 
		public virtual void setIfModifiedSince(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setIfModifiedSince11974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setIfModifiedSince11974, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIfModifiedSince11975; 
		public virtual long getIfModifiedSince() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::java.net.URLConnection._getIfModifiedSince11975); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getIfModifiedSince11975); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUseCaches11976; 
		public virtual bool getDefaultUseCaches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::java.net.URLConnection._getDefaultUseCaches11976); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultUseCaches11976); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultUseCaches11977; 
		public virtual void setDefaultUseCaches(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.URLConnection._setDefaultUseCaches11977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultUseCaches11977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultRequestProperty11978; 
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setDefaultRequestProperty11978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultRequestProperty11979; 
		public static global::java.lang.String getDefaultRequestProperty(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, global::java.net.URLConnection._getDefaultRequestProperty11979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentHandlerFactory11980; 
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, global::java.net.URLConnection._setContentHandlerFactory11980, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URLConnection11981; 
		protected URLConnection(java.net.URL arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URLConnection.staticClass, global::java.net.URLConnection._URLConnection11981, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.URLConnection.staticClass = @__class; 
			global::java.net.URLConnection._toString11932 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.URLConnection._getURL11933 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;"); 
			global::java.net.URLConnection._getContent11934 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;"); 
			global::java.net.URLConnection._getContent11935 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;"); 
			global::java.net.URLConnection._getInputStream11936 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::java.net.URLConnection._getPermission11937 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;"); 
			global::java.net.URLConnection._connect11938 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "connect", "()V"); 
			global::java.net.URLConnection._setRequestProperty11939 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLConnection._getDate11940 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDate", "()J"); 
			global::java.net.URLConnection._getContentType11941 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;"); 
			global::java.net.URLConnection._getContentLength11942 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContentLength", "()I"); 
			global::java.net.URLConnection._getHeaderField11943 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._getHeaderField11944 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;"); 
			global::java.net.URLConnection._getHeaderFieldKey11945 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;"); 
			global::java.net.URLConnection._getLastModified11946 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getLastModified", "()J"); 
			global::java.net.URLConnection._getFileNameMap11947 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;"); 
			global::java.net.URLConnection._addRequestProperty11948 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLConnection._getRequestProperty11949 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._getRequestProperties11950 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;"); 
			global::java.net.URLConnection._guessContentTypeFromStream11951 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;"); 
			global::java.net.URLConnection._guessContentTypeFromName11952 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._setFileNameMap11953 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V"); 
			global::java.net.URLConnection._setConnectTimeout11954 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V"); 
			global::java.net.URLConnection._getConnectTimeout11955 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I"); 
			global::java.net.URLConnection._setReadTimeout11956 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V"); 
			global::java.net.URLConnection._getReadTimeout11957 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getReadTimeout", "()I"); 
			global::java.net.URLConnection._getContentEncoding11958 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;"); 
			global::java.net.URLConnection._getExpiration11959 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getExpiration", "()J"); 
			global::java.net.URLConnection._getHeaderFields11960 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;"); 
			global::java.net.URLConnection._getHeaderFieldInt11961 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I"); 
			global::java.net.URLConnection._getHeaderFieldDate11962 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J"); 
			global::java.net.URLConnection._getOutputStream11963 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::java.net.URLConnection._setDoInput11964 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V"); 
			global::java.net.URLConnection._getDoInput11965 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDoInput", "()Z"); 
			global::java.net.URLConnection._setDoOutput11966 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V"); 
			global::java.net.URLConnection._getDoOutput11967 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDoOutput", "()Z"); 
			global::java.net.URLConnection._setAllowUserInteraction11968 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V"); 
			global::java.net.URLConnection._getAllowUserInteraction11969 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z"); 
			global::java.net.URLConnection._setDefaultAllowUserInteraction11970 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V"); 
			global::java.net.URLConnection._getDefaultAllowUserInteraction11971 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z"); 
			global::java.net.URLConnection._setUseCaches11972 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V"); 
			global::java.net.URLConnection._getUseCaches11973 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getUseCaches", "()Z"); 
			global::java.net.URLConnection._setIfModifiedSince11974 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V"); 
			global::java.net.URLConnection._getIfModifiedSince11975 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J"); 
			global::java.net.URLConnection._getDefaultUseCaches11976 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z"); 
			global::java.net.URLConnection._setDefaultUseCaches11977 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V"); 
			global::java.net.URLConnection._setDefaultRequestProperty11978 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLConnection._getDefaultRequestProperty11979 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._setContentHandlerFactory11980 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V"); 
			global::java.net.URLConnection._URLConnection11981 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V"); 
		} 
	} 
} 
