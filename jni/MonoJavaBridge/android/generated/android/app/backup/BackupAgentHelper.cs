namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupAgentHelper : android.app.backup.BackupAgent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupAgentHelper()
		{
			InitJNI();
		}
		protected BackupAgentHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBackup2305;
		public override void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgentHelper._onBackup2305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._onBackup2305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onRestore2306;
		public override void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgentHelper._onRestore2306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._onRestore2306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addHelper2307;
		public virtual void addHelper(java.lang.String arg0, android.app.backup.BackupHelper arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgentHelper._addHelper2307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._addHelper2307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BackupAgentHelper2308;
		public BackupAgentHelper()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._BackupAgentHelper2308);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupAgentHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupAgentHelper"));
			global::android.app.backup.BackupAgentHelper._onBackup2305 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgentHelper.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgentHelper._onRestore2306 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgentHelper.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgentHelper._addHelper2307 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgentHelper.staticClass, "addHelper", "(Ljava/lang/String;Landroid/app/backup/BackupHelper;)V");
			global::android.app.backup.BackupAgentHelper._BackupAgentHelper2308 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgentHelper.staticClass, "<init>", "()V");
		}
	}
}
