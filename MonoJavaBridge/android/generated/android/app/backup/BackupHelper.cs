namespace android.app.backup
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.app.backup.BackupHelper_))]
	public partial interface BackupHelper  : global::MonoJavaBridge.IJavaObject 
	{
		void performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2);
		void restoreEntity(android.app.backup.BackupDataInputStream arg0);
		void writeNewStateDescription(android.os.ParcelFileDescriptor arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.backup.BackupHelper))]
	internal sealed partial class BackupHelper_ : java.lang.Object, BackupHelper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BackupHelper_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void android.app.backup.BackupHelper.performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupHelper_.staticClass, "performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.BackupHelper_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void android.app.backup.BackupHelper.restoreEntity(android.app.backup.BackupDataInputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupHelper_.staticClass, "restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V", ref global::android.app.backup.BackupHelper_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void android.app.backup.BackupHelper.writeNewStateDescription(android.os.ParcelFileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupHelper_.staticClass, "writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.BackupHelper_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static BackupHelper_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupHelper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupHelper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
