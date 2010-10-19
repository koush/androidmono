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
		internal static global::MonoJavaBridge.MethodId _getContent25819;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._getContent25819)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._getContent25819)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25820;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._writeTo25820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._writeTo25820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength25821;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._getContentLength25821);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._getContentLength25821);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25822;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._isRepeatable25822);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._isRepeatable25822);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25823;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._isStreaming25823);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._isStreaming25823);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent25824;
		public override void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity._consumeContent25824);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._consumeContent25824);
		}
		internal static global::MonoJavaBridge.MethodId _InputStreamEntity25825;
		public InputStreamEntity(java.io.InputStream arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.InputStreamEntity.staticClass, global::org.apache.http.entity.InputStreamEntity._InputStreamEntity25825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.InputStreamEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/InputStreamEntity"));
			global::org.apache.http.entity.InputStreamEntity._getContent25819 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.InputStreamEntity._writeTo25820 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.InputStreamEntity._getContentLength25821 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.InputStreamEntity._isRepeatable25822 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.InputStreamEntity._isStreaming25823 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.InputStreamEntity._consumeContent25824 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.InputStreamEntity._InputStreamEntity25825 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.InputStreamEntity.staticClass, "<init>", "(Ljava/io/InputStream;J)V");
		}
	}
}
