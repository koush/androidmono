namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BackupDataInput : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BackupDataInput()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getKey925;
		public virtual global::java.lang.String getKey() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.app.backup.BackupDataInput._getKey925)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._getKey925)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _readNextHeader926;
		public virtual bool readNextHeader() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.app.backup.BackupDataInput._readNextHeader926);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._readNextHeader926);
		}
		public new int DataSize
		{
			get
			{
				return getDataSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataSize927;
		public virtual int getDataSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInput._getDataSize927);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._getDataSize927);
		}
		internal static global::MonoJavaBridge.MethodId _readEntityData928;
		public virtual int readEntityData(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInput._readEntityData928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._readEntityData928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skipEntityData929;
		public virtual void skipEntityData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.BackupDataInput._skipEntityData929);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._skipEntityData929);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.BackupDataInput.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/BackupDataInput"));
			global::android.app.backup.BackupDataInput._getKey925 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInput.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.app.backup.BackupDataInput._readNextHeader926 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInput.staticClass, "readNextHeader", "()Z");
			global::android.app.backup.BackupDataInput._getDataSize927 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInput.staticClass, "getDataSize", "()I");
			global::android.app.backup.BackupDataInput._readEntityData928 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInput.staticClass, "readEntityData", "([BII)I");
			global::android.app.backup.BackupDataInput._skipEntityData929 = @__env.GetMethodIDNoThrow(global::android.app.backup.BackupDataInput.staticClass, "skipEntityData", "()V");
		}
	}
}
