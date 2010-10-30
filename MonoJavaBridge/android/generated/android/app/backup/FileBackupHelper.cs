namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileBackupHelper : android.app.backup.FileBackupHelperBase, BackupHelper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileBackupHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _performBackup2328;
		public virtual void performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.FileBackupHelper.staticClass, global::android.app.backup.FileBackupHelper._performBackup2328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _restoreEntity2329;
		public virtual void restoreEntity(android.app.backup.BackupDataInputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.FileBackupHelper.staticClass, global::android.app.backup.FileBackupHelper._restoreEntity2329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _FileBackupHelper2330;
		public FileBackupHelper(android.content.Context arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.FileBackupHelper.staticClass, global::android.app.backup.FileBackupHelper._FileBackupHelper2330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FileBackupHelper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.FileBackupHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/FileBackupHelper"));
			global::android.app.backup.FileBackupHelper._performBackup2328 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelper.staticClass, "performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.FileBackupHelper._restoreEntity2329 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelper.staticClass, "restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V");
			global::android.app.backup.FileBackupHelper._FileBackupHelper2330 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelper.staticClass, "<init>", "(Landroid/content/Context;[Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
