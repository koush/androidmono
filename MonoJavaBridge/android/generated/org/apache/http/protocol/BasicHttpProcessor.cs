namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BasicHttpProcessor : java.lang.Object, HttpProcessor, HttpRequestInterceptorList, HttpResponseInterceptorList, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BasicHttpProcessor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clone", "()Ljava/lang/Object;", ref global::org.apache.http.protocol.BasicHttpProcessor._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::org.apache.http.protocol.BasicHttpProcessor copy()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<org.apache.http.protocol.BasicHttpProcessor>(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "copy", "()Lorg/apache/http/protocol/BasicHttpProcessor;", ref global::org.apache.http.protocol.BasicHttpProcessor._m1) as org.apache.http.protocol.BasicHttpProcessor;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void process(org.apache.http.HttpRequest arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpRequest;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void process(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "process", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void addResponseInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addResponseInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public global::org.apache.http.HttpResponseInterceptor getResponseInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpResponseInterceptor>(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptor", "(I)Lorg/apache/http/HttpResponseInterceptor;", ref global::org.apache.http.protocol.BasicHttpProcessor._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpResponseInterceptor;
		}
		public new int ResponseInterceptorCount
		{
			get
			{
				return getResponseInterceptorCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public int getResponseInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getResponseInterceptorCount", "()I", ref global::org.apache.http.protocol.BasicHttpProcessor._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void clearResponseInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearResponseInterceptors", "()V", ref global::org.apache.http.protocol.BasicHttpProcessor._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void removeResponseInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeResponseInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void addRequestInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addRequestInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::org.apache.http.HttpRequestInterceptor getRequestInterceptor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.HttpRequestInterceptor>(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptor", "(I)Lorg/apache/http/HttpRequestInterceptor;", ref global::org.apache.http.protocol.BasicHttpProcessor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.HttpRequestInterceptor;
		}
		public new int RequestInterceptorCount
		{
			get
			{
				return getRequestInterceptorCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public int getRequestInterceptorCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "getRequestInterceptorCount", "()I", ref global::org.apache.http.protocol.BasicHttpProcessor._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public void clearRequestInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearRequestInterceptors", "()V", ref global::org.apache.http.protocol.BasicHttpProcessor._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public void removeRequestInterceptorByClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "removeRequestInterceptorByClass", "(Ljava/lang/Class;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;I)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public void addInterceptor(org.apache.http.HttpRequestInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpRequestInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void addInterceptor(org.apache.http.HttpResponseInterceptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "addInterceptor", "(Lorg/apache/http/HttpResponseInterceptor;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.List Interceptors
		{
			set
			{
				setInterceptors(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public void setInterceptors(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "setInterceptors", "(Ljava/util/List;)V", ref global::org.apache.http.protocol.BasicHttpProcessor._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public void clearInterceptors()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "clearInterceptors", "()V", ref global::org.apache.http.protocol.BasicHttpProcessor._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public BasicHttpProcessor() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.BasicHttpProcessor._m22.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.BasicHttpProcessor._m22 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.BasicHttpProcessor.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.BasicHttpProcessor.staticClass, global::org.apache.http.protocol.BasicHttpProcessor._m22);
			Init(@__env, handle);
		}
		static BasicHttpProcessor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.BasicHttpProcessor.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/BasicHttpProcessor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
