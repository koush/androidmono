namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class FileBackupHelperBase : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static FileBackupHelperBase()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.FileBackupHelperBase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.FileBackupHelperBase(@__env);
			}
		}
		protected FileBackupHelperBase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeNewStateDescription933;
		public virtual void writeNewStateDescription(android.os.ParcelFileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.FileBackupHelperBase._writeNewStateDescription933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.FileBackupHelperBase.staticClass, global::android.app.backup.FileBackupHelperBase._writeNewStateDescription933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.FileBackupHelperBase.staticClass = @__class;
			global::android.app.backup.FileBackupHelperBase._writeNewStateDescription933 = @__env.GetMethodID(global::android.app.backup.FileBackupHelperBase.staticClass, "writeNewStateDescription", "(Landroid/os/ParcelFileDescriptor;)V");
		}
	}
}
