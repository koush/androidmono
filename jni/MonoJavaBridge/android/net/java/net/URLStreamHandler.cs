namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class URLStreamHandler : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static URLStreamHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.URLStreamHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected URLStreamHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11151; 
		protected virtual int hashCode(java.net.URL arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return @__env.CallIntMethod(this, _hashCode11151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URLStreamHandler.staticClass, _hashCode11151, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11152; 
		protected virtual bool equals(java.net.URL arg0, java.net.URL arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return @__env.CallBooleanMethod(this, _equals11152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLStreamHandler.staticClass, _equals11152, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultPort11153; 
		protected virtual int getDefaultPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return @__env.CallIntMethod(this, _getDefaultPort11153); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.URLStreamHandler.staticClass, _getDefaultPort11153); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sameFile11154; 
		protected virtual bool sameFile(java.net.URL arg0, java.net.URL arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return @__env.CallBooleanMethod(this, _sameFile11154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLStreamHandler.staticClass, _sameFile11154, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toExternalForm11155; 
		protected virtual java.lang.String toExternalForm(java.net.URL arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toExternalForm11155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLStreamHandler.staticClass, _toExternalForm11155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openConnection11156; 
		protected virtual java.net.URLConnection openConnection(java.net.URL arg0, java.net.Proxy arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URLConnection>(@__env, @__env.CallObjectMethodPtr(this, _openConnection11156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.URLConnection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLStreamHandler.staticClass, _openConnection11156, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _openConnection11157; 
		protected abstract java.net.URLConnection openConnection(java.net.URL arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _parseURL11158; 
		protected virtual void parseURL(java.net.URL arg0, java.lang.String arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				@__env.CallVoidMethod(this, _parseURL11158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLStreamHandler.staticClass, _parseURL11158, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHostAddress11159; 
		protected virtual java.net.InetAddress getHostAddress(java.net.URL arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getHostAddress11159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.URLStreamHandler.staticClass, _getHostAddress11159, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hostsEqual11160; 
		protected virtual bool hostsEqual(java.net.URL arg0, java.net.URL arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				return @__env.CallBooleanMethod(this, _hostsEqual11160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.URLStreamHandler.staticClass, _hostsEqual11160, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setURL11161; 
		protected virtual void setURL(java.net.URL arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				@__env.CallVoidMethod(this, _setURL11161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLStreamHandler.staticClass, _setURL11161, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setURL11162; 
		protected virtual void setURL(java.net.URL arg0, java.lang.String arg1, java.lang.String arg2, int arg3, java.lang.String arg4, java.lang.String arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.URLStreamHandler)) 
				@__env.CallVoidMethod(this, _setURL11162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.URLStreamHandler.staticClass, _setURL11162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _URLStreamHandler11163; 
		public URLStreamHandler()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.URLStreamHandler.staticClass, _URLStreamHandler11163, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.URLStreamHandler.staticClass = @__class; 
			global::java.net.URLStreamHandler._hashCode11151 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "hashCode", "(Ljava/net/URL;)I"); 
			global::java.net.URLStreamHandler._equals11152 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "equals", "(Ljava/net/URL;Ljava/net/URL;)Z"); 
			global::java.net.URLStreamHandler._getDefaultPort11153 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "getDefaultPort", "()I"); 
			global::java.net.URLStreamHandler._sameFile11154 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "sameFile", "(Ljava/net/URL;Ljava/net/URL;)Z"); 
			global::java.net.URLStreamHandler._toExternalForm11155 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "toExternalForm", "(Ljava/net/URL;)Ljava/lang/String;"); 
			global::java.net.URLStreamHandler._openConnection11156 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "openConnection", "(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;"); 
			global::java.net.URLStreamHandler._openConnection11157 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;"); 
			global::java.net.URLStreamHandler._parseURL11158 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "parseURL", "(Ljava/net/URL;Ljava/lang/String;II)V"); 
			global::java.net.URLStreamHandler._getHostAddress11159 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "getHostAddress", "(Ljava/net/URL;)Ljava/net/InetAddress;"); 
			global::java.net.URLStreamHandler._hostsEqual11160 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "hostsEqual", "(Ljava/net/URL;Ljava/net/URL;)Z"); 
			global::java.net.URLStreamHandler._setURL11161 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLStreamHandler._setURL11162 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "setURL", "(Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"); 
			global::java.net.URLStreamHandler._URLStreamHandler11163 = @__env.GetMethodID(global::java.net.URLStreamHandler.staticClass, "<init>", "()V"); 
		} 
	} 
} 
