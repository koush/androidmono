namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHttpEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
			set
			{
				setContent(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32506;
		public override global::java.io.InputStream getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._getContent32506)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._getContent32506)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32507;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._writeTo32507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._writeTo32507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
			set
			{
				setContentLength(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32508;
		public override long getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._getContentLength32508);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._getContentLength32508);
		}
		internal static global::MonoJavaBridge.MethodId _setContentLength32509;
		public virtual void setContentLength(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._setContentLength32509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._setContentLength32509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32510;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._isRepeatable32510);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._isRepeatable32510);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32511;
		public override bool isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._isStreaming32511);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._isStreaming32511);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32512;
		public override void consumeContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._consumeContent32512);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._consumeContent32512);
		}
		internal static global::MonoJavaBridge.MethodId _setContent32513;
		public virtual void setContent(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._setContent32513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._setContent32513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpEntity32514;
		public BasicHttpEntity() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._BasicHttpEntity32514);
			Init(@__env, handle);
		}
		static BasicHttpEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.BasicHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/BasicHttpEntity"));
			global::org.apache.http.entity.BasicHttpEntity._getContent32506 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.BasicHttpEntity._writeTo32507 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.BasicHttpEntity._getContentLength32508 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.BasicHttpEntity._setContentLength32509 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "setContentLength", "(J)V");
			global::org.apache.http.entity.BasicHttpEntity._isRepeatable32510 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.BasicHttpEntity._isStreaming32511 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.BasicHttpEntity._consumeContent32512 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.BasicHttpEntity._setContent32513 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "setContent", "(Ljava/io/InputStream;)V");
			global::org.apache.http.entity.BasicHttpEntity._BasicHttpEntity32514 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
