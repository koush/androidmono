namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Credentials : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Credentials(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Uid
		{
			get
			{
				return getUid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getUid7644;
		public virtual int getUid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Credentials.staticClass, "getUid", "()I", ref global::android.net.Credentials._getUid7644);
		}
		public new int Pid
		{
			get
			{
				return getPid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPid7645;
		public virtual int getPid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Credentials.staticClass, "getPid", "()I", ref global::android.net.Credentials._getPid7645);
		}
		public new int Gid
		{
			get
			{
				return getGid();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGid7646;
		public virtual int getGid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Credentials.staticClass, "getGid", "()I", ref global::android.net.Credentials._getGid7646);
		}
		internal static global::MonoJavaBridge.MethodId _Credentials7647;
		public Credentials(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Credentials._Credentials7647.native == global::System.IntPtr.Zero)
				global::android.net.Credentials._Credentials7647 = @__env.GetMethodIDNoThrow(global::android.net.Credentials.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Credentials.staticClass, global::android.net.Credentials._Credentials7647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Credentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Credentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Credentials"));
		}
		internal static void InitJNI()
		{
		}
	}
}
