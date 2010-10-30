namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileBackupHelperBase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileBackupHelperBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize2331;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.FileBackupHelperBase.staticClass, global::android.app.backup.FileBackupHelperBase._finalize2331);
		}
		internal static global::MonoJavaBridge.MethodId _writeNewStateDescription2332;
		public virtual void writeNewStateDescription(android.os.ParcelFileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.FileBackupHelperBase.staticClass, global::android.app.backup.FileBackupHelperBase._writeNewStateDescription2332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static FileBackupHelperBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.FileBackupHelperBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/FileBackupHelperBase"));
			global::android.app.backup.FileBackupHelperBase._finalize2331 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelperBase.staticClass, "finalize", "()V");
			global::android.app.backup.FileBackupHelperBase._writeNewStateDescription2332 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelperBase.staticClass, "writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
