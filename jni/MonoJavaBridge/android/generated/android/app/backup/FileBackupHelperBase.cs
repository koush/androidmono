namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FileBackupHelperBase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileBackupHelperBase()
		{
			InitJNI();
		}
		protected FileBackupHelperBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize947;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.FileBackupHelperBase._finalize947);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.FileBackupHelperBase.staticClass, global::android.app.backup.FileBackupHelperBase._finalize947);
		}
		internal static global::MonoJavaBridge.MethodId _writeNewStateDescription948;
		public virtual void writeNewStateDescription(android.os.ParcelFileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.FileBackupHelperBase._writeNewStateDescription948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.FileBackupHelperBase.staticClass, global::android.app.backup.FileBackupHelperBase._writeNewStateDescription948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.FileBackupHelperBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/FileBackupHelperBase"));
			global::android.app.backup.FileBackupHelperBase._finalize947 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelperBase.staticClass, "finalize", "()V");
			global::android.app.backup.FileBackupHelperBase._writeNewStateDescription948 = @__env.GetMethodIDNoThrow(global::android.app.backup.FileBackupHelperBase.staticClass, "writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V");
		}
	}
}
