namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpEntityWrapper : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpEntityWrapper()
		{
			InitJNI();
		}
		protected HttpEntityWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent25809;
		public virtual global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContent25809)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContent25809)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25810;
		public virtual void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._writeTo25810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._writeTo25810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::org.apache.http.Header ContentType
		{
			get
			{
				return getContentType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentType25811;
		public virtual global::org.apache.http.Header getContentType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContentType25811)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContentType25811)) as org.apache.http.Header;
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength25812;
		public virtual long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContentLength25812);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContentLength25812);
		}
		public new global::org.apache.http.Header ContentEncoding
		{
			get
			{
				return getContentEncoding();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding25813;
		public virtual global::org.apache.http.Header getContentEncoding() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding25813)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding25813)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25814;
		public virtual bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._isRepeatable25814);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._isRepeatable25814);
		}
		internal static global::MonoJavaBridge.MethodId _isChunked25815;
		public virtual bool isChunked() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._isChunked25815);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._isChunked25815);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25816;
		public virtual bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._isStreaming25816);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._isStreaming25816);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent25817;
		public virtual void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper._consumeContent25817);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._consumeContent25817);
		}
		internal static global::MonoJavaBridge.MethodId _HttpEntityWrapper25818;
		public HttpEntityWrapper(org.apache.http.HttpEntity arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.HttpEntityWrapper.staticClass, global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper25818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.HttpEntityWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/HttpEntityWrapper"));
			global::org.apache.http.entity.HttpEntityWrapper._getContent25809 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.HttpEntityWrapper._writeTo25810 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.HttpEntityWrapper._getContentType25811 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentType", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.HttpEntityWrapper._getContentLength25812 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.HttpEntityWrapper._getContentEncoding25813 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;");
			global::org.apache.http.entity.HttpEntityWrapper._isRepeatable25814 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.HttpEntityWrapper._isChunked25815 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isChunked", "()Z");
			global::org.apache.http.entity.HttpEntityWrapper._isStreaming25816 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.HttpEntityWrapper._consumeContent25817 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.HttpEntityWrapper._HttpEntityWrapper25818 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.HttpEntityWrapper.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;)V");
		}
	}
}
