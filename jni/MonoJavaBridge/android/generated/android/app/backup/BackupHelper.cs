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
	public sealed partial class BackupHelper_ : java.lang.Object, BackupHelper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupHelper_()
		{
			InitJNI();
		}
		internal BackupHelper_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _performBackup2313;
		 void android.app.backup.BackupHelper.performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupHelper_._performBackup2313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupHelper_.staticClass, global::android.app.backup.BackupHelper_._performBackup2313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _restoreEntity2314;
		 void android.app.backup.BackupHelper.restoreEntity(android.app.backup.BackupDataInputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupHelper_._restoreEntity2314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupHelper_.staticClass, global::android.app.backup.BackupHelper_._restoreEntity2314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNewStateDescription2315;
		 void android.app.backup.BackupHelper.writeNewStateDescription(android.os.ParcelFileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupHelper_._writeNewStateDescription2315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupHelper_.staticClass, global::android.app.backup.BackupHelper_._writeNewStateDescription2315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupHelper_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupHelper"));
			global::android.app.backup.BackupHelper_._performBackup2313 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupHelper_.staticClass, "performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupHelper_._restoreEntity2314 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupHelper_.staticClass, "restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V");
			global::android.app.backup.BackupHelper_._writeNewStateDescription2315 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupHelper_.staticClass, "writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V");
		}
	}
}
