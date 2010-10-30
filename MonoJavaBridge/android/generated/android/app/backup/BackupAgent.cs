namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.backup.BackupAgent_))]
	public abstract partial class BackupAgent : android.content.ContextWrapper
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackupAgent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onCreate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgent.staticClass, "onCreate", "()V", ref global::android.app.backup.BackupAgent._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgent.staticClass, "onDestroy", "()V", ref global::android.app.backup.BackupAgent._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2);
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		public BackupAgent() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.app.backup.BackupAgent._m4.native == global::System.IntPtr.Zero)
				global::android.app.backup.BackupAgent._m4 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupAgent.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.BackupAgent.staticClass, global::android.app.backup.BackupAgent._m4);
			Init(@__env, handle);
		}
		static BackupAgent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupAgent.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupAgent"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.backup.BackupAgent))]
	internal sealed partial class BackupAgent_ : android.app.backup.BackupAgent
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BackupAgent_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgent_.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.BackupAgent_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupAgent_.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V", ref global::android.app.backup.BackupAgent_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static BackupAgent_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupAgent_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupAgent"));
		}
		internal static void InitJNI()
		{
		}
	}
}
