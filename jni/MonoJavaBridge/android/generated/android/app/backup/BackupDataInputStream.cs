namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BackupDataInputStream : java.io.InputStream
	{
		internal static global::java.lang.Class staticClass;
		static BackupDataInputStream()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.BackupDataInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.BackupDataInputStream(@__env);
			}
		}
		protected BackupDataInputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _size916;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataInputStream._size916);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._size916);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKey917;
		public virtual global::java.lang.String getKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.backup.BackupDataInputStream._getKey917));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._getKey917));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read918;
		public override int read() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataInputStream._read918);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._read918);
		}
		internal static global::net.sf.jni4net.jni.MethodId _read919;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataInputStream._read919, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._read919, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read920;
		public override int read(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataInputStream._read920, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._read920, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.BackupDataInputStream.staticClass = @__class;
			global::android.app.backup.BackupDataInputStream._size916 = @__env.GetMethodID(global::android.app.backup.BackupDataInputStream.staticClass, "size", "()I");
			global::android.app.backup.BackupDataInputStream._getKey917 = @__env.GetMethodID(global::android.app.backup.BackupDataInputStream.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.app.backup.BackupDataInputStream._read918 = @__env.GetMethodID(global::android.app.backup.BackupDataInputStream.staticClass, "read", "()I");
			global::android.app.backup.BackupDataInputStream._read919 = @__env.GetMethodID(global::android.app.backup.BackupDataInputStream.staticClass, "read", "([BII)I");
			global::android.app.backup.BackupDataInputStream._read920 = @__env.GetMethodID(global::android.app.backup.BackupDataInputStream.staticClass, "read", "([B)I");
		}
	}
}
