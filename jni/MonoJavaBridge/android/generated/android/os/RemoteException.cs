namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RemoteException : android.util.AndroidException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RemoteException()
		{
			InitJNI();
		}
		protected RemoteException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RemoteException6714;
		public RemoteException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.RemoteException.staticClass, global::android.os.RemoteException._RemoteException6714);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.RemoteException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/RemoteException"));
			global::android.os.RemoteException._RemoteException6714 = @__env.GetMethodIDNoThrow(global::android.os.RemoteException.staticClass, "<init>", "()V");
		}
	}
}
