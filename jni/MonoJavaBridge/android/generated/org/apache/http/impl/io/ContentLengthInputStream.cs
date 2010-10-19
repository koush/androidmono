namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentLengthInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentLengthInputStream()
		{
			InitJNI();
		}
		protected ContentLengthInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close26682;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream._close26682);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._close26682);
		}
		internal static global::MonoJavaBridge.MethodId _read26683;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream._read26683);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._read26683);
		}
		internal static global::MonoJavaBridge.MethodId _read26684;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream._read26684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._read26684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read26685;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream._read26685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._read26685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skip26686;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream._skip26686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._skip26686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ContentLengthInputStream26687;
		public ContentLengthInputStream(org.apache.http.io.SessionInputBuffer arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.ContentLengthInputStream.staticClass, global::org.apache.http.impl.io.ContentLengthInputStream._ContentLengthInputStream26687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.ContentLengthInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/ContentLengthInputStream"));
			global::org.apache.http.impl.io.ContentLengthInputStream._close26682 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "close", "()V");
			global::org.apache.http.impl.io.ContentLengthInputStream._read26683 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "()I");
			global::org.apache.http.impl.io.ContentLengthInputStream._read26684 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "([BII)I");
			global::org.apache.http.impl.io.ContentLengthInputStream._read26685 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "read", "([B)I");
			global::org.apache.http.impl.io.ContentLengthInputStream._skip26686 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "skip", "(J)J");
			global::org.apache.http.impl.io.ContentLengthInputStream._ContentLengthInputStream26687 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.ContentLengthInputStream.staticClass, "<init>", "(Lorg/apache/http/io/SessionInputBuffer;J)V");
		}
	}
}
