namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileBackupHelperBase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileBackupHelperBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.FileBackupHelperBase.staticClass, "finalize", "()V", ref global::android.app.backup.FileBackupHelperBase._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeNewStateDescription(android.os.ParcelFileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.FileBackupHelperBase.staticClass, "writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.FileBackupHelperBase._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static FileBackupHelperBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.FileBackupHelperBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/FileBackupHelperBase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
