namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileEntity : org.apache.http.entity.AbstractHttpEntity, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone32540;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._clone32540.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._clone32540 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._clone32540) as java.lang.Object;
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32541;
		public override global::java.io.InputStream getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._getContent32541.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._getContent32541 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._getContent32541) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32542;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._writeTo32542.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._writeTo32542 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._writeTo32542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long ContentLength
		{
			get
			{
				return getContentLength();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContentLength32543;
		public override long getContentLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._getContentLength32543.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._getContentLength32543 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "getContentLength", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._getContentLength32543);
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32544;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._isRepeatable32544.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._isRepeatable32544 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "isRepeatable", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._isRepeatable32544);
		}
		internal static global::MonoJavaBridge.MethodId _isStreaming32545;
		public override bool isStreaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._isStreaming32545.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._isStreaming32545 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "isStreaming", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._isStreaming32545);
		}
		internal static global::MonoJavaBridge.MethodId _FileEntity32546;
		public FileEntity(java.io.File arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.FileEntity._FileEntity32546.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.FileEntity._FileEntity32546 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.FileEntity.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.entity.FileEntity.staticClass, global::org.apache.http.entity.FileEntity._FileEntity32546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FileEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.FileEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/FileEntity"));
		}
		internal static void InitJNI()
		{
		}
	}
}
