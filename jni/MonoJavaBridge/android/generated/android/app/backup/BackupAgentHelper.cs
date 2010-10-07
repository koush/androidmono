namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BackupAgentHelper : android.app.backup.BackupAgent
	{
		internal new static global::java.lang.Class staticClass;
		static BackupAgentHelper()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.BackupAgentHelper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.BackupAgentHelper(@__env);
			}
		}
		protected BackupAgentHelper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBackup907;
		public override void onBackup(android.os.ParcelFileDescriptor arg0, android.app.backup.BackupDataOutput arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupAgentHelper._onBackup907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._onBackup907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRestore908;
		public override void onRestore(android.app.backup.BackupDataInput arg0, int arg1, android.os.ParcelFileDescriptor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupAgentHelper._onRestore908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._onRestore908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addHelper909;
		public virtual void addHelper(java.lang.String arg0, android.app.backup.BackupHelper arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupAgentHelper._addHelper909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._addHelper909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BackupAgentHelper910;
		public BackupAgentHelper()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.backup.BackupAgentHelper.staticClass, global::android.app.backup.BackupAgentHelper._BackupAgentHelper910, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.BackupAgentHelper.staticClass = @__class;
			global::android.app.backup.BackupAgentHelper._onBackup907 = @__env.GetMethodID(global::android.app.backup.BackupAgentHelper.staticClass, "onBackup", "(Landroid/os/ParcelFileDescriptor;Landroid/app/backup/BackupDataOutput;Landroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgentHelper._onRestore908 = @__env.GetMethodID(global::android.app.backup.BackupAgentHelper.staticClass, "onRestore", "(Landroid/app/backup/BackupDataInput;ILandroid/os/ParcelFileDescriptor;)V");
			global::android.app.backup.BackupAgentHelper._addHelper909 = @__env.GetMethodID(global::android.app.backup.BackupAgentHelper.staticClass, "addHelper", "(Ljava/lang/String;Landroid/app/backup/BackupHelper;)V");
			global::android.app.backup.BackupAgentHelper._BackupAgentHelper910 = @__env.GetMethodID(global::android.app.backup.BackupAgentHelper.staticClass, "<init>", "()V");
		}
	}
}
