namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpRetryException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpRetryException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getLocation15804;
		public virtual global::java.lang.String getLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpRetryException._getLocation15804)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._getLocation15804)) as java.lang.String;
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReason15805;
		public virtual global::java.lang.String getReason() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.HttpRetryException._getReason15805)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._getReason15805)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _responseCode15806;
		public virtual int responseCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.HttpRetryException._responseCode15806);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._responseCode15806);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRetryException15807;
		public HttpRetryException(java.lang.String arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._HttpRetryException15807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpRetryException15808;
		public HttpRetryException(java.lang.String arg0, int arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.HttpRetryException.staticClass, global::java.net.HttpRetryException._HttpRetryException15808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.HttpRetryException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/HttpRetryException"));
			global::java.net.HttpRetryException._getLocation15804 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "getLocation", "()Ljava/lang/String;");
			global::java.net.HttpRetryException._getReason15805 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "getReason", "()Ljava/lang/String;");
			global::java.net.HttpRetryException._responseCode15806 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "responseCode", "()I");
			global::java.net.HttpRetryException._HttpRetryException15807 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "<init>", "(Ljava/lang/String;I)V");
			global::java.net.HttpRetryException._HttpRetryException15808 = @__env.GetMethodIDNoThrow(global::java.net.HttpRetryException.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
		}
	}
}
