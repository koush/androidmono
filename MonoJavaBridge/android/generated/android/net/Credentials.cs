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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getUid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Credentials.staticClass, "getUid", "()I", ref global::android.net.Credentials._m0);
		}
		public new int Pid
		{
			get
			{
				return getPid();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getPid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Credentials.staticClass, "getPid", "()I", ref global::android.net.Credentials._m1);
		}
		public new int Gid
		{
			get
			{
				return getGid();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getGid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.Credentials.staticClass, "getGid", "()I", ref global::android.net.Credentials._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Credentials(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.Credentials._m3.native == global::System.IntPtr.Zero)
				global::android.net.Credentials._m3 = @__env.GetMethodIDNoThrow(global::android.net.Credentials.staticClass, "<init>", "(III)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.Credentials.staticClass, global::android.net.Credentials._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Credentials()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.Credentials.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/Credentials"));
		}
	}
}
