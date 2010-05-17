namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class PluginData : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PluginData() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.PluginData), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.PluginData(@__env); 
			} 
		} 
		internal PluginData(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream8636; 
		public java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, _getInputStream8636)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.PluginData.staticClass, _getInputStream8636)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentLength8637; 
		public long getContentLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return @__env.CallLongMethod(this, _getContentLength8637); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.webkit.PluginData.staticClass, _getContentLength8637); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders8638; 
		public java.util.Map getHeaders() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getHeaders8638)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.PluginData.staticClass, _getHeaders8638)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusCode8639; 
		public int getStatusCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return @__env.CallIntMethod(this, _getStatusCode8639); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.webkit.PluginData.staticClass, _getStatusCode8639); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PluginData8640; 
		public PluginData(java.io.InputStream arg0, long arg1, java.util.Map arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.PluginData.staticClass, _PluginData8640, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.PluginData.staticClass = @__class; 
			global::android.webkit.PluginData._getInputStream8636 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.webkit.PluginData._getContentLength8637 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getContentLength", "()J"); 
			global::android.webkit.PluginData._getHeaders8638 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getHeaders", "()Ljava/util/Map;"); 
			global::android.webkit.PluginData._getStatusCode8639 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getStatusCode", "()I"); 
			global::android.webkit.PluginData._PluginData8640 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "<init>", "(Ljava/io/InputStream;JLjava/util/Map;I)V"); 
		} 
	} 
} 
