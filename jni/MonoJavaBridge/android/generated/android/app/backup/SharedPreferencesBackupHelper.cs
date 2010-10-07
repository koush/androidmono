namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SharedPreferencesBackupHelper : android.app.backup.FileBackupHelperBase, BackupHelper
	{
		internal new static global::java.lang.Class staticClass;
		static SharedPreferencesBackupHelper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.SharedPreferencesBackupHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.SharedPreferencesBackupHelper(@__env);
			}
		}
		protected SharedPreferencesBackupHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _performBackup938;
		public virtual void performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.SharedPreferencesBackupHelper._performBackup938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.SharedPreferencesBackupHelper.staticClass, global::android.app.backup.SharedPreferencesBackupHelper._performBackup938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreEntity939;
		public virtual void restoreEntity(android.app.backup.BackupDataInputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.SharedPreferencesBackupHelper._restoreEntity939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.SharedPreferencesBackupHelper.staticClass, global::android.app.backup.SharedPreferencesBackupHelper._restoreEntity939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SharedPreferencesBackupHelper940;
		public SharedPreferencesBackupHelper(android.content.Context arg0, java.lang.String[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.backup.SharedPreferencesBackupHelper.staticClass, global::android.app.backup.SharedPreferencesBackupHelper._SharedPreferencesBackupHelper940, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.SharedPreferencesBackupHelper.staticClass = @__class;
			global::android.app.backup.SharedPreferencesBackupHelper._performBackup938 = @__env.GetMethodID(global::android.app.backup.SharedPreferencesBackupHelper.staticClass, "performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.SharedPreferencesBackupHelper._restoreEntity939 = @__env.GetMethodID(global::android.app.backup.SharedPreferencesBackupHelper.staticClass, "restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V");
			global::android.app.backup.SharedPreferencesBackupHelper._SharedPreferencesBackupHelper940 = @__env.GetMethodID(global::android.app.backup.SharedPreferencesBackupHelper.staticClass, "<init>", "(Landroid/content/Context;[Ljava/lang/String;)V");
		}
	}
}
