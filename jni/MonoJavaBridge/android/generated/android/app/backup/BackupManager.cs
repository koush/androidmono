namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BackupManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static BackupManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.BackupManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.BackupManager(@__env);
			}
		}
		protected BackupManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _dataChanged926;
		public virtual void dataChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupManager._dataChanged926);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._dataChanged926);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dataChanged927;
		public static void dataChanged(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._dataChanged927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestRestore928;
		public virtual int requestRestore(android.app.backup.RestoreObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupManager._requestRestore928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._requestRestore928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BackupManager929;
		public BackupManager(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.backup.BackupManager.staticClass, global::android.app.backup.BackupManager._BackupManager929, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.BackupManager.staticClass = @__class;
			global::android.app.backup.BackupManager._dataChanged926 = @__env.GetMethodID(global::android.app.backup.BackupManager.staticClass, "dataChanged", "()V");
			global::android.app.backup.BackupManager._dataChanged927 = @__env.GetStaticMethodID(global::android.app.backup.BackupManager.staticClass, "dataChanged", "(Ljava/lang/String;)V");
			global::android.app.backup.BackupManager._requestRestore928 = @__env.GetMethodID(global::android.app.backup.BackupManager.staticClass, "requestRestore", "(Landroid/app/backup/RestoreObserver;)I");
			global::android.app.backup.BackupManager._BackupManager929 = @__env.GetMethodID(global::android.app.backup.BackupManager.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
