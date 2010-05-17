namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class URLConnection : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static URLConnection() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.URLConnection), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected URLConnection(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11101; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11101)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _toString11101)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getURL11102; 
		public virtual java.net.URL getURL() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallObjectMethodPtr(this, _getURL11102)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URL>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getURL11102)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContent11103; 
		public virtual java.lang.Object getContent(java.lang.Class[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getContent11103, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getContent11103, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContent11104; 
		public virtual java.lang.Object getContent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getContent11104)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getContent11104)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream11105; 
		public virtual java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream11105)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getInputStream11105)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPermission11106; 
		public virtual java.security.Permission getPermission() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Permission>(@__env, @__env.CallObjectMethodPtr(this, _getPermission11106)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Permission>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getPermission11106)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _connect11107; 
		public abstract void connect(); 
		internal static global::net.sf.jni4net.jni.MethodId _setRequestProperty11108; 
		public virtual void setRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setRequestProperty11108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setRequestProperty11108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDate11109; 
		public virtual long getDate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallLongMethod(this, _getDate11109); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.net.URLConnection.staticClass, _getDate11109); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentType11110; 
		public virtual java.lang.String getContentType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getContentType11110)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getContentType11110)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentLength11111; 
		public virtual int getContentLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallIntMethod(this, _getContentLength11111); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URLConnection.staticClass, _getContentLength11111); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderField11112; 
		public virtual java.lang.String getHeaderField(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHeaderField11112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getHeaderField11112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderField11113; 
		public virtual java.lang.String getHeaderField(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHeaderField11113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getHeaderField11113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFieldKey11114; 
		public virtual java.lang.String getHeaderFieldKey(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHeaderFieldKey11114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getHeaderFieldKey11114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLastModified11115; 
		public virtual long getLastModified() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallLongMethod(this, _getLastModified11115); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.net.URLConnection.staticClass, _getLastModified11115); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFileNameMap11116; 
		public static java.net.FileNameMap getFileNameMap() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.net.FileNameMap>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, _getFileNameMap11116)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addRequestProperty11117; 
		public virtual void addRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _addRequestProperty11117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _addRequestProperty11117, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRequestProperty11118; 
		public virtual java.lang.String getRequestProperty(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getRequestProperty11118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getRequestProperty11118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRequestProperties11119; 
		public virtual java.util.Map getRequestProperties() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getRequestProperties11119)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getRequestProperties11119)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _guessContentTypeFromStream11120; 
		public static java.lang.String guessContentTypeFromStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, _guessContentTypeFromStream11120, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _guessContentTypeFromName11121; 
		public static java.lang.String guessContentTypeFromName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, _guessContentTypeFromName11121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFileNameMap11122; 
		public static void setFileNameMap(java.net.FileNameMap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, _setFileNameMap11122, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConnectTimeout11123; 
		public virtual void setConnectTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setConnectTimeout11123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setConnectTimeout11123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConnectTimeout11124; 
		public virtual int getConnectTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallIntMethod(this, _getConnectTimeout11124); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URLConnection.staticClass, _getConnectTimeout11124); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setReadTimeout11125; 
		public virtual void setReadTimeout(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setReadTimeout11125, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setReadTimeout11125, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReadTimeout11126; 
		public virtual int getReadTimeout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallIntMethod(this, _getReadTimeout11126); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URLConnection.staticClass, _getReadTimeout11126); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentEncoding11127; 
		public virtual java.lang.String getContentEncoding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getContentEncoding11127)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getContentEncoding11127)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpiration11128; 
		public virtual long getExpiration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallLongMethod(this, _getExpiration11128); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.net.URLConnection.staticClass, _getExpiration11128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFields11129; 
		public virtual java.util.Map getHeaderFields() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getHeaderFields11129)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getHeaderFields11129)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFieldInt11130; 
		public virtual int getHeaderFieldInt(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallIntMethod(this, _getHeaderFieldInt11130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URLConnection.staticClass, _getHeaderFieldInt11130, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaderFieldDate11131; 
		public virtual long getHeaderFieldDate(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallLongMethod(this, _getHeaderFieldDate11131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.net.URLConnection.staticClass, _getHeaderFieldDate11131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOutputStream11132; 
		public virtual java.io.OutputStream getOutputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallObjectMethodPtr(this, _getOutputStream11132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.OutputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLConnection.staticClass, _getOutputStream11132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDoInput11133; 
		public virtual void setDoInput(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setDoInput11133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setDoInput11133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoInput11134; 
		public virtual bool getDoInput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallBooleanMethod(this, _getDoInput11134); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLConnection.staticClass, _getDoInput11134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDoOutput11135; 
		public virtual void setDoOutput(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setDoOutput11135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setDoOutput11135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDoOutput11136; 
		public virtual bool getDoOutput() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallBooleanMethod(this, _getDoOutput11136); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLConnection.staticClass, _getDoOutput11136); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAllowUserInteraction11137; 
		public virtual void setAllowUserInteraction(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setAllowUserInteraction11137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setAllowUserInteraction11137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllowUserInteraction11138; 
		public virtual bool getAllowUserInteraction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallBooleanMethod(this, _getAllowUserInteraction11138); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLConnection.staticClass, _getAllowUserInteraction11138); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultAllowUserInteraction11139; 
		public static void setDefaultAllowUserInteraction(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, _setDefaultAllowUserInteraction11139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultAllowUserInteraction11140; 
		public static bool getDefaultAllowUserInteraction() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(java.net.URLConnection.staticClass, _getDefaultAllowUserInteraction11140); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUseCaches11141; 
		public virtual void setUseCaches(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setUseCaches11141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setUseCaches11141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUseCaches11142; 
		public virtual bool getUseCaches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallBooleanMethod(this, _getUseCaches11142); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLConnection.staticClass, _getUseCaches11142); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIfModifiedSince11143; 
		public virtual void setIfModifiedSince(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setIfModifiedSince11143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setIfModifiedSince11143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIfModifiedSince11144; 
		public virtual long getIfModifiedSince() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallLongMethod(this, _getIfModifiedSince11144); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.net.URLConnection.staticClass, _getIfModifiedSince11144); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultUseCaches11145; 
		public virtual bool getDefaultUseCaches() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				return @__env.CallBooleanMethod(this, _getDefaultUseCaches11145); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLConnection.staticClass, _getDefaultUseCaches11145); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultUseCaches11146; 
		public virtual void setDefaultUseCaches(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLConnection)) 
				@__env.CallVoidMethod(this, _setDefaultUseCaches11146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLConnection.staticClass, _setDefaultUseCaches11146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefaultRequestProperty11147; 
		public static void setDefaultRequestProperty(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, _setDefaultRequestProperty11147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultRequestProperty11148; 
		public static java.lang.String getDefaultRequestProperty(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(java.net.URLConnection.staticClass, _getDefaultRequestProperty11148, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setContentHandlerFactory11149; 
		public static void setContentHandlerFactory(java.net.ContentHandlerFactory arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.net.URLConnection.staticClass, _setContentHandlerFactory11149, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URLConnection11150; 
		protected URLConnection(java.net.URL arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URLConnection.staticClass, _URLConnection11150, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.URLConnection.staticClass = @__class; 
			global::java.net.URLConnection._toString11101 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.URLConnection._getURL11102 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getURL", "()Ljava/net/URL;"); 
			global::java.net.URLConnection._getContent11103 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContent", "([Ljava/lang/Class;)Ljava/lang/Object;"); 
			global::java.net.URLConnection._getContent11104 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContent", "()Ljava/lang/Object;"); 
			global::java.net.URLConnection._getInputStream11105 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::java.net.URLConnection._getPermission11106 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getPermission", "()Ljava/security/Permission;"); 
			global::java.net.URLConnection._connect11107 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "connect", "()V"); 
			global::java.net.URLConnection._setRequestProperty11108 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLConnection._getDate11109 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDate", "()J"); 
			global::java.net.URLConnection._getContentType11110 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContentType", "()Ljava/lang/String;"); 
			global::java.net.URLConnection._getContentLength11111 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContentLength", "()I"); 
			global::java.net.URLConnection._getHeaderField11112 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._getHeaderField11113 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderField", "(I)Ljava/lang/String;"); 
			global::java.net.URLConnection._getHeaderFieldKey11114 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFieldKey", "(I)Ljava/lang/String;"); 
			global::java.net.URLConnection._getLastModified11115 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getLastModified", "()J"); 
			global::java.net.URLConnection._getFileNameMap11116 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "getFileNameMap", "()Ljava/net/FileNameMap;"); 
			global::java.net.URLConnection._addRequestProperty11117 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLConnection._getRequestProperty11118 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._getRequestProperties11119 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getRequestProperties", "()Ljava/util/Map;"); 
			global::java.net.URLConnection._guessContentTypeFromStream11120 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;"); 
			global::java.net.URLConnection._guessContentTypeFromName11121 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._setFileNameMap11122 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setFileNameMap", "(Ljava/net/FileNameMap;)V"); 
			global::java.net.URLConnection._setConnectTimeout11123 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setConnectTimeout", "(I)V"); 
			global::java.net.URLConnection._getConnectTimeout11124 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getConnectTimeout", "()I"); 
			global::java.net.URLConnection._setReadTimeout11125 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setReadTimeout", "(I)V"); 
			global::java.net.URLConnection._getReadTimeout11126 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getReadTimeout", "()I"); 
			global::java.net.URLConnection._getContentEncoding11127 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getContentEncoding", "()Ljava/lang/String;"); 
			global::java.net.URLConnection._getExpiration11128 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getExpiration", "()J"); 
			global::java.net.URLConnection._getHeaderFields11129 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFields", "()Ljava/util/Map;"); 
			global::java.net.URLConnection._getHeaderFieldInt11130 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFieldInt", "(Ljava/lang/String;I)I"); 
			global::java.net.URLConnection._getHeaderFieldDate11131 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getHeaderFieldDate", "(Ljava/lang/String;J)J"); 
			global::java.net.URLConnection._getOutputStream11132 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getOutputStream", "()Ljava/io/OutputStream;"); 
			global::java.net.URLConnection._setDoInput11133 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setDoInput", "(Z)V"); 
			global::java.net.URLConnection._getDoInput11134 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDoInput", "()Z"); 
			global::java.net.URLConnection._setDoOutput11135 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setDoOutput", "(Z)V"); 
			global::java.net.URLConnection._getDoOutput11136 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDoOutput", "()Z"); 
			global::java.net.URLConnection._setAllowUserInteraction11137 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setAllowUserInteraction", "(Z)V"); 
			global::java.net.URLConnection._getAllowUserInteraction11138 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getAllowUserInteraction", "()Z"); 
			global::java.net.URLConnection._setDefaultAllowUserInteraction11139 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setDefaultAllowUserInteraction", "(Z)V"); 
			global::java.net.URLConnection._getDefaultAllowUserInteraction11140 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "getDefaultAllowUserInteraction", "()Z"); 
			global::java.net.URLConnection._setUseCaches11141 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setUseCaches", "(Z)V"); 
			global::java.net.URLConnection._getUseCaches11142 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getUseCaches", "()Z"); 
			global::java.net.URLConnection._setIfModifiedSince11143 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setIfModifiedSince", "(J)V"); 
			global::java.net.URLConnection._getIfModifiedSince11144 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getIfModifiedSince", "()J"); 
			global::java.net.URLConnection._getDefaultUseCaches11145 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "getDefaultUseCaches", "()Z"); 
			global::java.net.URLConnection._setDefaultUseCaches11146 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "setDefaultUseCaches", "(Z)V"); 
			global::java.net.URLConnection._setDefaultRequestProperty11147 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setDefaultRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLConnection._getDefaultRequestProperty11148 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "getDefaultRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::java.net.URLConnection._setContentHandlerFactory11149 = @__env.GetStaticMethodID(global::java.net.URLConnection.staticClass, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V"); 
			global::java.net.URLConnection._URLConnection11150 = @__env.GetMethodID(global::java.net.URLConnection.staticClass, "<init>", "(Ljava/net/URL;)V"); 
		} 
	} 
} 
