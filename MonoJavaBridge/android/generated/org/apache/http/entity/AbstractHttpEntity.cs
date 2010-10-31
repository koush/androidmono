namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.entity.AbstractHttpEntity_))]
	public abstract partial class AbstractHttpEntity : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.io.InputStream getContent();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract void writeTo(java.io.OutputStream arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract long getContentLength();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool isRepeatable();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool isStreaming();
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::org.apache.http.Header getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentType", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.AbstractHttpEntity._m5) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setContentType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Ljava/lang/String;)V", ref global::org.apache.http.entity.AbstractHttpEntity._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setContentType(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.entity.AbstractHttpEntity._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::org.apache.http.Header getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.AbstractHttpEntity._m8) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isChunked", "()Z", ref global::org.apache.http.entity.AbstractHttpEntity._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "consumeContent", "()V", ref global::org.apache.http.entity.AbstractHttpEntity._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setContentEncoding(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.entity.AbstractHttpEntity._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setContentEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Ljava/lang/String;)V", ref global::org.apache.http.entity.AbstractHttpEntity._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setChunked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setChunked", "(Z)V", ref global::org.apache.http.entity.AbstractHttpEntity._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected AbstractHttpEntity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.AbstractHttpEntity._m14.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.AbstractHttpEntity._m14 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._m14);
			Init(@__env, handle);
		}
		static AbstractHttpEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.AbstractHttpEntity))]
	internal sealed partial class AbstractHttpEntity_ : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpEntity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.AbstractHttpEntity_._m0) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.AbstractHttpEntity_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.AbstractHttpEntity_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.AbstractHttpEntity_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.AbstractHttpEntity_._m4);
		}
		static AbstractHttpEntity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
		}
	}
}
