namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ByteArrayEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ByteArrayEntity()
		{
			InitJNI();
		}
		protected ByteArrayEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone25786;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity._clone25786)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._clone25786)) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent25787;
		public override global::java.io.InputStream getContent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity._getContent25787)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._getContent25787)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo25788;
		public override void writeTo(java.io.OutputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity._writeTo25788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._writeTo25788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength25789;
		public override long getContentLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity._getContentLength25789);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._getContentLength25789);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable25790;
		public override bool isRepeatable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity._isRepeatable25790);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._isRepeatable25790);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming25791;
		public override bool isStreaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity._isStreaming25791);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._isStreaming25791);
		}
		internal static global::MonoJavaBridge.MethodId _ByteArrayEntity25792;
		public ByteArrayEntity(byte[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.ByteArrayEntity.staticClass, global::org.apache.http.entity.ByteArrayEntity._ByteArrayEntity25792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ByteArrayEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ByteArrayEntity"));
			global::org.apache.http.entity.ByteArrayEntity._clone25786 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "clone", "()Ljava/lang/Object;");
			global::org.apache.http.entity.ByteArrayEntity._getContent25787 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.entity.ByteArrayEntity._writeTo25788 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.entity.ByteArrayEntity._getContentLength25789 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "getContentLength", "()J");
			global::org.apache.http.entity.ByteArrayEntity._isRepeatable25790 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.entity.ByteArrayEntity._isStreaming25791 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "isStreaming", "()Z");
			global::org.apache.http.entity.ByteArrayEntity._ByteArrayEntity25792 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ByteArrayEntity.staticClass, "<init>", "([B)V");
		}
	}
}
