namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class PluginData : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PluginData() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.PluginData), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getInputStream9321; 
		public global::java.io.InputStream getInputStream() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.PluginData._getInputStream9321)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getInputStream9321)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getContentLength9322; 
		public long getContentLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return @__env.CallLongMethod(this, global::android.webkit.PluginData._getContentLength9322); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getContentLength9322); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeaders9323; 
		public global::java.util.Map getHeaders() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.PluginData._getHeaders9323)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getHeaders9323)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatusCode9324; 
		public int getStatusCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.PluginData)) 
				return @__env.CallIntMethod(this, global::android.webkit.PluginData._getStatusCode9324); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.webkit.PluginData.staticClass, global::android.webkit.PluginData._getStatusCode9324); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PluginData9325; 
		public PluginData(java.io.InputStream arg0, long arg1, java.util.Map arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.webkit.PluginData.staticClass, global::android.webkit.PluginData._PluginData9325, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.PluginData.staticClass = @__class; 
			global::android.webkit.PluginData._getInputStream9321 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getInputStream", "()Ljava/io/InputStream;"); 
			global::android.webkit.PluginData._getContentLength9322 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getContentLength", "()J"); 
			global::android.webkit.PluginData._getHeaders9323 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getHeaders", "()Ljava/util/Map;"); 
			global::android.webkit.PluginData._getStatusCode9324 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "getStatusCode", "()I"); 
			global::android.webkit.PluginData._PluginData9325 = @__env.GetMethodID(global::android.webkit.PluginData.staticClass, "<init>", "(Ljava/io/InputStream;JLjava/util/Map;I)V"); 
		} 
	} 
} 
