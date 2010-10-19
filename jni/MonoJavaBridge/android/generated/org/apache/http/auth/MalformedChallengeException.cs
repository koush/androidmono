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
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException25168;
		public MalformedChallengeException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException25168);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException25169;
		public MalformedChallengeException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException25169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _MalformedChallengeException25170;
		public MalformedChallengeException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.auth.MalformedChallengeException.staticClass, global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException25170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.MalformedChallengeException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/MalformedChallengeException"));
			global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException25168 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "()V");
			global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException25169 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.apache.http.auth.MalformedChallengeException._MalformedChallengeException25170 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.MalformedChallengeException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
