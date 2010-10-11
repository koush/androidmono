namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncInfo : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncInfo()
		{
			InitJNI();
		}
		protected SyncInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _account1792;
		public global::android.accounts.Account account
		{
			get
			{
				return default(global::android.accounts.Account);
			}
		}
		internal static global::MonoJavaBridge.FieldId _authority1793;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _startTime1794;
		public long startTime
		{
			get
			{
				return default(long);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncInfo"));
		}
	}
}
