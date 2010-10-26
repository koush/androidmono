namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.backup.BackupAgent_))]
	public abstract partial class BackupAgent : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupAgent()
		{
			InitJNI();
		}
		protected BackupAgent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate2298;
		public virtual void onCreate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent._onCreate2298);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._onCreate2298);
		}
		internal static global::MonoJavaBridge.MethodId _onDestroy2299;
		public virtual void onDestroy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent._onDestroy2299);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._onDestroy2299);
		}
		internal static global::MonoJavaBridge.MethodId _onBackup2300;
		public abstract void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2);
		internal static global::MonoJavaBridge.MethodId _onRestore2301;
		public abstract void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2);
		internal static global::MonoJavaBridge.MethodId _BackupAgent2302;
		public BackupAgent()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._BackupAgent2302);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupAgent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupAgent"));
			global::android.app.backup.BackupAgent._onCreate2298 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent.staticClass, "onCreate", "()V");
			global::android.app.backup.BackupAgent._onDestroy2299 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent.staticClass, "onDestroy", "()V");
			global::android.app.backup.BackupAgent._onBackup2300 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgent._onRestore2301 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgent._BackupAgent2302 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.backup.BackupAgent))]
	internal sealed partial class BackupAgent_ : android.app.backup.BackupAgent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupAgent_()
		{
			InitJNI();
		}
		internal BackupAgent_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onBackup2303;
		public override void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent_._onBackup2303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent_.staticClass, global::android.app.backup.BackupAgent_._onBackup2303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onRestore2304;
		public override void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent_._onRestore2304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupAgent_.staticClass, global::android.app.backup.BackupAgent_._onRestore2304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupAgent_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupAgent"));
			global::android.app.backup.BackupAgent_._onBackup2303 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent_.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgent_._onRestore2304 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent_.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V");
		}
	}
}
