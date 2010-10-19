namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpProcessor : java.lang.Object, HttpProcessor, HttpRequestInterceptorList, HttpResponseInterceptorList, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpProcessor()
		{
			InitJNI();
		}
		internal BasicHttpProcessor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone27055;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clone27055)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clone27055)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _copy27056;
		public global::org.apache.http.protocol.BasicHttpProcessor copy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._copy27056)) as org.apache.http.protocol.BasicHttpProcessor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._copy27056)) as org.apache.http.protocol.BasicHttpProcessor;
		}
		internal static global::MonoJavaBridge.MethodId _process27057;
		public void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._process27057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._process27057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _process27058;
		public void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._process27058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._process27058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor27059;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor27059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor27059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addResponseInterceptor27060;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor27060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor27060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptor27061;
		public global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor27061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpResponseInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor27061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpResponseInterceptor;
		}
		public new int ResponseInterceptorCount
		{
			get
			{
				return getResponseInterceptorCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResponseInterceptorCount27062;
		public int getResponseInterceptorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount27062);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount27062);
		}
		internal static global::MonoJavaBridge.MethodId _clearResponseInterceptors27063;
		public void clearResponseInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors27063);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors27063);
		}
		internal static global::MonoJavaBridge.MethodId _removeResponseInterceptorByClass27064;
		public void removeResponseInterceptorByClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass27064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass27064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor27065;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor27065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor27065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addRequestInterceptor27066;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor27066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor27066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptor27067;
		public global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpRequestInterceptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor27067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HttpRequestInterceptor;
		}
		public new int RequestInterceptorCount
		{
			get
			{
				return getRequestInterceptorCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRequestInterceptorCount27068;
		public int getRequestInterceptorCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount27068);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount27068);
		}
		internal static global::MonoJavaBridge.MethodId _clearRequestInterceptors27069;
		public void clearRequestInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors27069);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors27069);
		}
		internal static global::MonoJavaBridge.MethodId _removeRequestInterceptorByClass27070;
		public void removeRequestInterceptorByClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass27070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor27071;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor27072;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor27073;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addInterceptor27074;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setInterceptors27075;
		public void setInterceptors(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors27075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors27075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearInterceptors27076;
		public void clearInterceptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors27076);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors27076);
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpProcessor27077;
		public BasicHttpProcessor()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor27077);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.BasicHttpProcessor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/BasicHttpProcessor"));
			global::org.apache.http.protocol.BasicHttpProcessor._clone27055 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.protocol.BasicHttpProcessor._copy27056 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "copy", "()Lorg/apache/http/protocol/BasicHttpProcessor;");
			global::org.apache.http.protocol.BasicHttpProcessor._process27057 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._process27058 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor27059 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addResponseInterceptor27060 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptor27061 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;");
			global::org.apache.http.protocol.BasicHttpProcessor._getResponseInterceptorCount27062 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptorCount", "()I");
			global::org.apache.http.protocol.BasicHttpProcessor._clearResponseInterceptors27063 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearResponseInterceptors", "()V");
			global::org.apache.http.protocol.BasicHttpProcessor._removeResponseInterceptorByClass27064 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor27065 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addRequestInterceptor27066 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptor27067 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;");
			global::org.apache.http.protocol.BasicHttpProcessor._getRequestInterceptorCount27068 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptorCount", "()I");
			global::org.apache.http.protocol.BasicHttpProcessor._clearRequestInterceptors27069 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearRequestInterceptors", "()V");
			global::org.apache.http.protocol.BasicHttpProcessor._removeRequestInterceptorByClass27070 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27071 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27072 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27073 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._addInterceptor27074 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._setInterceptors27075 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "setInterceptors", "(Ljava/util/List;)V");
			global::org.apache.http.protocol.BasicHttpProcessor._clearInterceptors27076 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearInterceptors", "()V");
			global::org.apache.http.protocol.BasicHttpProcessor._BasicHttpProcessor27077 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "<init>", "()V");
		}
	}
}
