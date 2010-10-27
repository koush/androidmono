namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InputStreamEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static InputStreamEntity()
		{
			InitJNI();
		}
		protected InputStreamEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32556;
		public override global::java.io.InputStream getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._getContent32556)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._getContent32556)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32557;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._writeTo32557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._writeTo32557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32558;
		public override long getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._getContentLength32558);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._getContentLength32558);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32559;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._isRepeatable32559);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._isRepeatable32559);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32560;
		public override bool isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._isStreaming32560);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._isStreaming32560);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32561;
		public override void consumeContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._consumeContent32561);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._consumeContent32561);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamEntity32562;
		public InputStreamEntity(java.io.InputStream arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._InputStreamEntity32562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.InputStreamEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/InputStreamEntity"));
			global::org.apache.http.entity.InputStreamEntity._getContent32556 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.InputStreamEntity._writeTo32557 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.InputStreamEntity._getContentLength32558 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.InputStreamEntity._isRepeatable32559 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.InputStreamEntity._isStreaming32560 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.InputStreamEntity._consumeContent32561 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.InputStreamEntity._InputStreamEntity32562 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "<init>", "(Ljava/io/InputStream;J)V");
		}
	}
}
