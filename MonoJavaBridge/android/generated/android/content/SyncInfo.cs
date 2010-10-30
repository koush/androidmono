namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _account1882;
		public global::android.accounts.Account account
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _account1882)) as android.accounts.Account;
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority1883;
		public global::java.lang.String authority
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _authority1883)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _startTime1884;
		public long startTime
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _startTime1884);
			}
		}
		static SyncInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncInfo"));
			global::android.content.SyncInfo._account1882 = @__env.GetFieldIDNoThrow(global::android.content.SyncInfo.staticClass, "account", "Landroid/accounts/Account;");
			global::android.content.SyncInfo._authority1883 = @__env.GetFieldIDNoThrow(global::android.content.SyncInfo.staticClass, "authority", "Ljava/lang/String;");
			global::android.content.SyncInfo._startTime1884 = @__env.GetFieldIDNoThrow(global::android.content.SyncInfo.staticClass, "startTime", "J");
		}
		internal static void InitJNI()
		{
		}
	}
}
