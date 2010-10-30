namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.entity.AbstractHttpEntity_))]
	public abstract partial class AbstractHttpEntity : java.lang.Object, HttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent32486;
		public abstract global::java.io.InputStream getContent();
		internal static global::MonoJavaBridge.MethodId _writeTo32487;
		public abstract void writeTo(java.io.OutputStream arg0);
		internal static global::MonoJavaBridge.MethodId _getContentLength32488;
		public abstract long getContentLength();
		internal static global::MonoJavaBridge.MethodId _isRepeatable32489;
		public abstract bool isRepeatable();
		internal static global::MonoJavaBridge.MethodId _isStreaming32490;
		public abstract bool isStreaming();
		internal static global::MonoJavaBridge.MethodId _getContentType32491;
		public virtual global::org.apache.http.Header getContentType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentType", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.AbstractHttpEntity._getContentType32491) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _setContentType32492;
		public virtual void setContentType(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Ljava/lang/String;)V", ref global::org.apache.http.entity.AbstractHttpEntity._setContentType32492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentType32493;
		public virtual void setContentType(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentType", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.entity.AbstractHttpEntity._setContentType32493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentEncoding32494;
		public virtual global::org.apache.http.Header getContentEncoding()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "getContentEncoding", "()Lorg/apache/http/Header;", ref global::org.apache.http.entity.AbstractHttpEntity._getContentEncoding32494) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _isChunked32495;
		public virtual bool isChunked()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "isChunked", "()Z", ref global::org.apache.http.entity.AbstractHttpEntity._isChunked32495);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32496;
		public virtual void consumeContent()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "consumeContent", "()V", ref global::org.apache.http.entity.AbstractHttpEntity._consumeContent32496);
		}
		internal static global::MonoJavaBridge.MethodId _setContentEncoding32497;
		public virtual void setContentEncoding(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentEncoding32498;
		public virtual void setContentEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setContentEncoding", "(Ljava/lang/String;)V", ref global::org.apache.http.entity.AbstractHttpEntity._setContentEncoding32498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChunked32499;
		public virtual void setChunked(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity.staticClass, "setChunked", "(Z)V", ref global::org.apache.http.entity.AbstractHttpEntity._setChunked32499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractHttpEntity32500;
		protected AbstractHttpEntity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity32500.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity32500 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.AbstractHttpEntity.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.AbstractHttpEntity.staticClass, global::org.apache.http.entity.AbstractHttpEntity._AbstractHttpEntity32500);
			Init(@__env, handle);
		}
		static AbstractHttpEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.AbstractHttpEntity))]
	internal sealed partial class AbstractHttpEntity_ : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractHttpEntity_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent32501;
		public override global::java.io.InputStream getContent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContent", "()Ljava/io/InputStream;", ref global::org.apache.http.entity.AbstractHttpEntity_._getContent32501) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32502;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V", ref global::org.apache.http.entity.AbstractHttpEntity_._writeTo32502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32503;
		public override long getContentLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "getContentLength", "()J", ref global::org.apache.http.entity.AbstractHttpEntity_._getContentLength32503);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32504;
		public override bool isRepeatable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isRepeatable", "()Z", ref global::org.apache.http.entity.AbstractHttpEntity_._isRepeatable32504);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32505;
		public override bool isStreaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.AbstractHttpEntity_.staticClass, "isStreaming", "()Z", ref global::org.apache.http.entity.AbstractHttpEntity_._isStreaming32505);
		}
		static AbstractHttpEntity_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.AbstractHttpEntity_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/AbstractHttpEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
