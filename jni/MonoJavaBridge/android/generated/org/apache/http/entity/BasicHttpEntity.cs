namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHttpEntity : org.apache.http.entity.AbstractHttpEntity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BasicHttpEntity()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getContent25770;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._getContent25770)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._getContent25770)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25771;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._writeTo25771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._writeTo25771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getContentLength25772;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._getContentLength25772);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._getContentLength25772);
		}
		internal static global::MonoJavaBridge.MethodId _setContentLength25773;
		public virtual void setContentLength(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._setContentLength25773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._setContentLength25773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25774;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._isRepeatable25774);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._isRepeatable25774);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25775;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._isStreaming25775);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._isStreaming25775);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent25776;
		public override void consumeContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._consumeContent25776);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._consumeContent25776);
		}
		internal static global::MonoJavaBridge.MethodId _setContent25777;
		public virtual void setContent(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity._setContent25777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._setContent25777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _BasicHttpEntity25778;
		public BasicHttpEntity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.BasicHttpEntity.staticClass, global::org.apache.http.entity.BasicHttpEntity._BasicHttpEntity25778);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.BasicHttpEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/BasicHttpEntity"));
			global::org.apache.http.entity.BasicHttpEntity._getContent25770 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.BasicHttpEntity._writeTo25771 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.BasicHttpEntity._getContentLength25772 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.BasicHttpEntity._setContentLength25773 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "setContentLength", "(J)V");
			global::org.apache.http.entity.BasicHttpEntity._isRepeatable25774 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.BasicHttpEntity._isStreaming25775 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.BasicHttpEntity._consumeContent25776 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.entity.BasicHttpEntity._setContent25777 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "setContent", "(Ljava/io/InputStream;)V");
			global::org.apache.http.entity.BasicHttpEntity._BasicHttpEntity25778 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.BasicHttpEntity.staticClass, "<init>", "()V");
		}
	}
}
