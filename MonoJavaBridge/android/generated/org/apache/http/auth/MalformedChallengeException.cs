namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedChallengeException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MalformedChallengeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException31831;
		public MalformedChallengeException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31831.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31831 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31831);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException31832;
		public MalformedChallengeException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31832.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31832 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException31833;
		public MalformedChallengeException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31833.native == global::System.IntPtr.Zero)
				global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31833 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MalformedChallengeException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.MalformedChallengeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/MalformedChallengeException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
