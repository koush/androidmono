namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BackupDataInput : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static BackupDataInput()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.BackupDataInput), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.backup.BackupDataInput(@__env);
			}
		}
		protected BackupDataInput(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getKey911;
		public virtual global::java.lang.String getKey() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.backup.BackupDataInput._getKey911));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._getKey911));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readNextHeader912;
		public virtual bool readNextHeader() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.backup.BackupDataInput._readNextHeader912);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._readNextHeader912);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataSize913;
		public virtual int getDataSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataInput._getDataSize913);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._getDataSize913);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readEntityData914;
		public virtual int readEntityData(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.backup.BackupDataInput._readEntityData914, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._readEntityData914, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _skipEntityData915;
		public virtual void skipEntityData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.BackupDataInput._skipEntityData915);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.BackupDataInput.staticClass, global::android.app.backup.BackupDataInput._skipEntityData915);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.BackupDataInput.staticClass = @__class;
			global::android.app.backup.BackupDataInput._getKey911 = @__env.GetMethodID(global::android.app.backup.BackupDataInput.staticClass, "getKey", "()Ljava/lang/String;");
			global::android.app.backup.BackupDataInput._readNextHeader912 = @__env.GetMethodID(global::android.app.backup.BackupDataInput.staticClass, "readNextHeader", "()Z");
			global::android.app.backup.BackupDataInput._getDataSize913 = @__env.GetMethodID(global::android.app.backup.BackupDataInput.staticClass, "getDataSize", "()I");
			global::android.app.backup.BackupDataInput._readEntityData914 = @__env.GetMethodID(global::android.app.backup.BackupDataInput.staticClass, "readEntityData", "([BII)I");
			global::android.app.backup.BackupDataInput._skipEntityData915 = @__env.GetMethodID(global::android.app.backup.BackupDataInput.staticClass, "skipEntityData", "()V");
		}
	}
}
