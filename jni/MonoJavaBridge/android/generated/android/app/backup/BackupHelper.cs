namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface BackupHelper 
	{
		void performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2);
		void restoreEntity(android.app.backup.BackupDataInputStream arg0);
		void writeNewStateDescription(android.os.ParcelFileDescriptor arg0);
	}

	public partial class BackupHelper_
	{
		public static global::java.lang.Class _class
		{
			get { return __BackupHelper.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __BackupHelper : java.lang.Object, BackupHelper
	{
		internal static global::java.lang.Class staticClass;
		static __BackupHelper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.__BackupHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.__BackupHelper(@__env);
			}
		}
		internal __BackupHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _performBackup923;
		 void android.app.backup.BackupHelper.performBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.__BackupHelper._performBackup923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.__BackupHelper.staticClass, global::android.app.backup.__BackupHelper._performBackup923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreEntity924;
		 void android.app.backup.BackupHelper.restoreEntity(android.app.backup.BackupDataInputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.__BackupHelper._restoreEntity924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.__BackupHelper.staticClass, global::android.app.backup.__BackupHelper._restoreEntity924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeNewStateDescription925;
		 void android.app.backup.BackupHelper.writeNewStateDescription(android.os.ParcelFileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.__BackupHelper._writeNewStateDescription925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.__BackupHelper.staticClass, global::android.app.backup.__BackupHelper._writeNewStateDescription925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.__BackupHelper.staticClass = @__class;
			global::android.app.backup.__BackupHelper._performBackup923 = @__env.GetMethodID(global::android.app.backup.__BackupHelper.staticClass, "android.app.backup.BackupHelper.performBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.__BackupHelper._restoreEntity924 = @__env.GetMethodID(global::android.app.backup.__BackupHelper.staticClass, "android.app.backup.BackupHelper.restoreEntity", "(Landroid/app/backup/BackupDataInputStream;)V");
			global::android.app.backup.__BackupHelper._writeNewStateDescription925 = @__env.GetMethodID(global::android.app.backup.__BackupHelper.staticClass, "android.app.backup.BackupHelper.writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V");
		}
	}
}
