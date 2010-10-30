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
		internal static global::MonoJavaBridge.MethodId _getKey2309;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.app.backup.BackupDataInput.staticClass, "getKey", "()Ljava/lang/String;", ref global::android.app.backup.BackupDataInput._getKey2309) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readNextHeader2310;
		public virtual bool readNextHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.app.backup.BackupDataInput.staticClass, "readNextHeader", "()Z", ref global::android.app.backup.BackupDataInput._readNextHeader2310);
		}
		public new int DataSize
		{
			get
			{
				return getDataSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataSize2311;
		public virtual int getDataSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInput.staticClass, "getDataSize", "()I", ref global::android.app.backup.BackupDataInput._getDataSize2311);
		}
		internal static global::MonoJavaBridge.MethodId _readEntityData2312;
		public virtual int readEntityData(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.backup.BackupDataInput.staticClass, "readEntityData", "([BII)I", ref global::android.app.backup.BackupDataInput._readEntityData2312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skipEntityData2313;
		public virtual void skipEntityData()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.backup.BackupDataInput.staticClass, "skipEntityData", "()V", ref global::android.app.backup.BackupDataInput._skipEntityData2313);
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
