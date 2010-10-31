namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.backup.RestoreObserver_))]
	public abstract partial class RestoreObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RestoreObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void restoreStarting(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.RestoreObserver.staticClass, "restoreStarting", "(I)V", ref global::android.app.backup.RestoreObserver._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onUpdate(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.RestoreObserver.staticClass, "onUpdate", "(ILjava/lang/String;)V", ref global::android.app.backup.RestoreObserver._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void restoreFinished(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.RestoreObserver.staticClass, "restoreFinished", "(I)V", ref global::android.app.backup.RestoreObserver._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public RestoreObserver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.backup.RestoreObserver._m3.native == global::System.IntPtr.Zero)
				global::android.app.backup.RestoreObserver._m3 = @__env.GetMethodIDNoThrow(global::android.app.backup.RestoreObserver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._m3);
			Init(@__env, handle);
		}
		static RestoreObserver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.RestoreObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/RestoreObserver"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.backup.RestoreObserver))]
	internal sealed partial class RestoreObserver_ : android.app.backup.RestoreObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RestoreObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static RestoreObserver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.RestoreObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/RestoreObserver"));
		}
	}
}
