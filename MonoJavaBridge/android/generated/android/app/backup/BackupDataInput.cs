namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupDataInput : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BackupDataInput(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.backup.BackupDataInput.staticClass, "getKey", "()Ljava/lang/String;", ref global::android.app.backup.BackupDataInput._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool readNextHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.backup.BackupDataInput.staticClass, "readNextHeader", "()Z", ref global::android.app.backup.BackupDataInput._m1);
		}
		public new int DataSize
		{
			get
			{
				return getDataSize();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getDataSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInput.staticClass, "getDataSize", "()I", ref global::android.app.backup.BackupDataInput._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int readEntityData(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInput.staticClass, "readEntityData", "([BII)I", ref global::android.app.backup.BackupDataInput._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void skipEntityData()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupDataInput.staticClass, "skipEntityData", "()V", ref global::android.app.backup.BackupDataInput._m4);
		}
		static BackupDataInput()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupDataInput.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupDataInput"));
		}
		internal static void InitJNI()
		{
		}
	}
}
