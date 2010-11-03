namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class URISyntaxException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected URISyntaxException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URISyntaxException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.net.URISyntaxException._m0) as java.lang.String;
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URISyntaxException.staticClass, "getIndex", "()I", ref global::java.net.URISyntaxException._m1);
		}
		public new global::java.lang.String Input
		{
			get
			{
				return getInput();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URISyntaxException.staticClass, "getInput", "()Ljava/lang/String;", ref global::java.net.URISyntaxException._m2) as java.lang.String;
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getReason()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URISyntaxException.staticClass, "getReason", "()Ljava/lang/String;", ref global::java.net.URISyntaxException._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public URISyntaxException(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URISyntaxException._m4.native == global::System.IntPtr.Zero)
				global::java.net.URISyntaxException._m4 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public URISyntaxException(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URISyntaxException._m5.native == global::System.IntPtr.Zero)
				global::java.net.URISyntaxException._m5 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static URISyntaxException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URISyntaxException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URISyntaxException"));
		}
	}
}
