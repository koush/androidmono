namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackupManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void dataChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupManager.staticClass, "dataChanged", "()V", ref global::android.app.backup.BackupManager._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void dataChanged(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.backup.BackupManager._m1.native == global::System.IntPtr.Zero)
				global::android.app.backup.BackupManager._m1 = @__env.GetStaticMethodIDNoThrow(global::android.app.backup.BackupManager.staticClass, "dataChanged", "(Ljava/lang/String;)V");
			@__env.CallStaticVoidMethod(android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int requestRestore(android.app.backup.RestoreObserver arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupManager.staticClass, "requestRestore", "(Landroid/app/backup/RestoreObserver;)I", ref global::android.app.backup.BackupManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public BackupManager(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.backup.BackupManager._m3.native == global::System.IntPtr.Zero)
				global::android.app.backup.BackupManager._m3 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupManager.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BackupManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupManager"));
		}
	}
}
