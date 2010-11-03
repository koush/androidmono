namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class PasswordAuthentication : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PasswordAuthentication(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new char[] Password
		{
			get
			{
				return getPassword();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public char[] getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::java.net.PasswordAuthentication.staticClass, "getPassword", "()[C", ref global::java.net.PasswordAuthentication._m0) as char[];
		}
		public new global::java.lang.String UserName
		{
			get
			{
				return getUserName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.lang.String getUserName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.PasswordAuthentication.staticClass, "getUserName", "()Ljava/lang/String;", ref global::java.net.PasswordAuthentication._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public PasswordAuthentication(java.lang.String arg0, char[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.PasswordAuthentication._m2.native == global::System.IntPtr.Zero)
				global::java.net.PasswordAuthentication._m2 = @__env.GetMethodIDNoThrow(global::java.net.PasswordAuthentication.staticClass, "<init>", "(Ljava/lang/String;[C)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.PasswordAuthentication.staticClass, global::java.net.PasswordAuthentication._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PasswordAuthentication()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.PasswordAuthentication.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/PasswordAuthentication"));
		}
	}
}
