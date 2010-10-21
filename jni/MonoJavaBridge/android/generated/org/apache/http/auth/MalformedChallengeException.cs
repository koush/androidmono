namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MalformedChallengeException : org.apache.http.ProtocolException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MalformedChallengeException()
		{
			InitJNI();
		}
		protected MalformedChallengeException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException31712;
		public MalformedChallengeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31712);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException31713;
		public MalformedChallengeException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException31714;
		public MalformedChallengeException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.MalformedChallengeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/MalformedChallengeException"));
			global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31712 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "()V");
			global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31713 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException31714 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
