namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FileBackupHelper : android.app.backup.FileBackupHelperBase, BackupHelper
	{
		internal new static global::java.lang.Class staticClass;
		static FileBackupHelper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.FileBackupHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.FileBackupHelper(@__env);
			}
		}
		protected FileBackupHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _performBackup930;
		public virtual void performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.FileBackupHelper._performBackup930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.FileBackupHelper.staticClass, global::android.app.backup.FileBackupHelper._performBackup930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreEntity931;
		public virtual void restoreEntity(android.app.backup.BackupDataInputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.FileBackupHelper._restoreEntity931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.FileBackupHelper.staticClass, global::android.app.backup.FileBackupHelper._restoreEntity931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _FileBackupHelper932;
		public FileBackupHelper(android.content.Context arg0, java.lang.String[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.backup.FileBackupHelper.staticClass, global::android.app.backup.FileBackupHelper._FileBackupHelper932, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.FileBackupHelper.staticClass = @__class;
			global::android.app.backup.FileBackupHelper._performBackup930 = @__env.GetMethodID(global::android.app.backup.FileBackupHelper.staticClass, "performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.FileBackupHelper._restoreEntity931 = @__env.GetMethodID(global::android.app.backup.FileBackupHelper.staticClass, "restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V");
			global::android.app.backup.FileBackupHelper._FileBackupHelper932 = @__env.GetMethodID(global::android.app.backup.FileBackupHelper.staticClass, "<init>", "(Landroid/content/Context;[Ljava/lang/String;)V");
		}
	}
}
