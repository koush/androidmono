namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class BackupAgent : android.content.ContextWrapper
	{
		internal new static global::java.lang.Class staticClass;
		static BackupAgent()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.BackupAgent), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected BackupAgent(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreate902;
		public virtual void onCreate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupAgent._onCreate902);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._onCreate902);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDestroy903;
		public virtual void onDestroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupAgent._onDestroy903);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._onDestroy903);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBackup904;
		public abstract void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2);
		internal static global::net.sf.jni4net.jni.MethodId _onRestore905;
		public abstract void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2);
		internal static global::net.sf.jni4net.jni.MethodId _BackupAgent906;
		public BackupAgent()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._BackupAgent906, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.BackupAgent.staticClass = @__class;
			global::android.app.backup.BackupAgent._onCreate902 = @__env.GetMethodID(global::android.app.backup.BackupAgent.staticClass, "onCreate", "()V");
			global::android.app.backup.BackupAgent._onDestroy903 = @__env.GetMethodID(global::android.app.backup.BackupAgent.staticClass, "onDestroy", "()V");
			global::android.app.backup.BackupAgent._onBackup904 = @__env.GetMethodID(global::android.app.backup.BackupAgent.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgent._onRestore905 = @__env.GetMethodID(global::android.app.backup.BackupAgent.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgent._BackupAgent906 = @__env.GetMethodID(global::android.app.backup.BackupAgent.staticClass, "<init>", "()V");
		}
	}
}
