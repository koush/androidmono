namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SharedPreferencesBackupHelper : android.app.backup.FileBackupHelperBase, BackupHelper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SharedPreferencesBackupHelper()
		{
			InitJNI();
		}
		protected SharedPreferencesBackupHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _performBackup953;
		public virtual void performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.SharedPreferencesBackupHelper._performBackup953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.SharedPreferencesBackupHelper.staticClass, global::android.app.backup.SharedPreferencesBackupHelper._performBackup953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _restoreEntity954;
		public virtual void restoreEntity(android.app.backup.BackupDataInputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.SharedPreferencesBackupHelper._restoreEntity954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.SharedPreferencesBackupHelper.staticClass, global::android.app.backup.SharedPreferencesBackupHelper._restoreEntity954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SharedPreferencesBackupHelper955;
		public SharedPreferencesBackupHelper(android.content.Context arg0, java.lang.String[] arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.SharedPreferencesBackupHelper.staticClass, global::android.app.backup.SharedPreferencesBackupHelper._SharedPreferencesBackupHelper955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.SharedPreferencesBackupHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/SharedPreferencesBackupHelper"));
			global::android.app.backup.SharedPreferencesBackupHelper._performBackup953 = @__env.GetMethodIDNoThrow(global::android.app.backup.SharedPreferencesBackupHelper.staticClass, "performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.SharedPreferencesBackupHelper._restoreEntity954 = @__env.GetMethodIDNoThrow(global::android.app.backup.SharedPreferencesBackupHelper.staticClass, "restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V");
			global::android.app.backup.SharedPreferencesBackupHelper._SharedPreferencesBackupHelper955 = @__env.GetMethodIDNoThrow(global::android.app.backup.SharedPreferencesBackupHelper.staticClass, "<init>", "(Landroid/content/Context;[Ljava/lang/String;)V");
		}
	}
}
