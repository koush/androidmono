namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupDataInputStream : java.io.InputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupDataInputStream()
		{
			InitJNI();
		}
		protected BackupDataInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size2306;
		public virtual int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream._size2306);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._size2306);
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKey2307;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream._getKey2307)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._getKey2307)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _read2308;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream._read2308);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._read2308);
		}
		internal static global::MonoJavaBridge.MethodId _read2309;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream._read2309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._read2309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read2310;
		public override int read(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream._read2310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInputStream.staticClass, global::android.app.backup.BackupDataInputStream._read2310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupDataInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupDataInputStream"));
			global::android.app.backup.BackupDataInputStream._size2306 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInputStream.staticClass, "size", "()I");
			global::android.app.backup.BackupDataInputStream._getKey2307 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInputStream.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.app.backup.BackupDataInputStream._read2308 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInputStream.staticClass, "read", "()I");
			global::android.app.backup.BackupDataInputStream._read2309 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInputStream.staticClass, "read", "([BII)I");
			global::android.app.backup.BackupDataInputStream._read2310 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInputStream.staticClass, "read", "([B)I");
		}
	}
}
