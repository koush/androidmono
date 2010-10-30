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
		internal static global::MonoJavaBridge.MethodId _getMessage21874;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URISyntaxException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.net.URISyntaxException._getMessage21874) as java.lang.String;
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex21875;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.URISyntaxException.staticClass, "getIndex", "()I", ref global::java.net.URISyntaxException._getIndex21875);
		}
		public new global::java.lang.String Input
		{
			get
			{
				return getInput();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInput21876;
		public virtual global::java.lang.String getInput()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URISyntaxException.staticClass, "getInput", "()Ljava/lang/String;", ref global::java.net.URISyntaxException._getInput21876) as java.lang.String;
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReason21877;
		public virtual global::java.lang.String getReason()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.net.URISyntaxException.staticClass, "getReason", "()Ljava/lang/String;", ref global::java.net.URISyntaxException._getReason21877) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _URISyntaxException21878;
		public URISyntaxException(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URISyntaxException._URISyntaxException21878.native == global::System.IntPtr.Zero)
				global::java.net.URISyntaxException._URISyntaxException21878 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._URISyntaxException21878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _URISyntaxException21879;
		public URISyntaxException(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.URISyntaxException._URISyntaxException21879.native == global::System.IntPtr.Zero)
				global::java.net.URISyntaxException._URISyntaxException21879 = @__env.GetMethodIDNoThrow(global::java.net.URISyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.URISyntaxException.staticClass, global::java.net.URISyntaxException._URISyntaxException21879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static URISyntaxException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.URISyntaxException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/URISyntaxException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
