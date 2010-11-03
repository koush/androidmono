namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRetryException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRetryException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Location
		{
			get
			{
				return getLocation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getLocation()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.HttpRetryException.staticClass, "getLocation", "()Ljava/lang/String;", ref global::java.net.HttpRetryException._m0) as java.lang.String;
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getReason()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.HttpRetryException.staticClass, "getReason", "()Ljava/lang/String;", ref global::java.net.HttpRetryException._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int responseCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.HttpRetryException.staticClass, "responseCode", "()I", ref global::java.net.HttpRetryException._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public HttpRetryException(java.lang.String arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.HttpRetryException._m3.native == global::System.IntPtr.Zero)
				global::java.net.HttpRetryException._m3 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public HttpRetryException(java.lang.String arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.HttpRetryException._m4.native == global::System.IntPtr.Zero)
				global::java.net.HttpRetryException._m4 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static HttpRetryException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpRetryException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpRetryException"));
		}
	}
}
