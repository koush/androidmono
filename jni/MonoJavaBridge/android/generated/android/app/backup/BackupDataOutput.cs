namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BackupDataOutput : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static BackupDataOutput()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.BackupDataOutput), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.BackupDataOutput(@__env);
			}
		}
		protected BackupDataOutput(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeEntityHeader921;
		public virtual int writeEntityHeader(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataOutput._writeEntityHeader921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataOutput.staticClass, global::android.app.backup.BackupDataOutput._writeEntityHeader921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeEntityData922;
		public virtual int writeEntityData(byte[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataOutput._writeEntityData922, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataOutput.staticClass, global::android.app.backup.BackupDataOutput._writeEntityData922, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.BackupDataOutput.staticClass = @__class;
			global::android.app.backup.BackupDataOutput._writeEntityHeader921 = @__env.GetMethodID(global::android.app.backup.BackupDataOutput.staticClass, "writeEntityHeader", "(Ljava/lang/String;I)I");
			global::android.app.backup.BackupDataOutput._writeEntityData922 = @__env.GetMethodID(global::android.app.backup.BackupDataOutput.staticClass, "writeEntityData", "([BI)I");
		}
	}
}
