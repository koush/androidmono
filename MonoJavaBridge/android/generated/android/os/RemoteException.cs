namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteException : android.util.AndroidException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RemoteException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RemoteException10195;
		public RemoteException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.RemoteException._RemoteException10195.native == global::System.IntPtr.Zero)
				global::android.os.RemoteException._RemoteException10195 = @__env.GetMethodIDNoThrow(global::android.os.RemoteException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RemoteException.staticClass, global::android.os.RemoteException._RemoteException10195);
			Init(@__env, handle);
		}
		static RemoteException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RemoteException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RemoteException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
