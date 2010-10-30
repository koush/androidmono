namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupDataInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackupDataInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size2314;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, "size", "()I", ref global::android.app.backup.BackupDataInputStream._size2314);
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey2315;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.backup.BackupDataInputStream.staticClass, "getKey", "()Ljava/lang/String;", ref global::android.app.backup.BackupDataInputStream._getKey2315) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read2316;
		public override int read()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, "read", "()I", ref global::android.app.backup.BackupDataInputStream._read2316);
		}
		internal static global::MonoJavaBridge.MethodId _read2317;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, "read", "([BII)I", ref global::android.app.backup.BackupDataInputStream._read2317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read2318;
		public override int read(byte[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInputStream.staticClass, "read", "([B)I", ref global::android.app.backup.BackupDataInputStream._read2318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static BackupDataInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupDataInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupDataInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
