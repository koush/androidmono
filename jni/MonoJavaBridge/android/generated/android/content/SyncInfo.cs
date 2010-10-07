namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SyncInfo : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SyncInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.SyncInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.SyncInfo(@__env);
			}
		}
		protected SyncInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.FieldId _account1698;
		public global::android.accounts.Account account
		{
			get
			{
				return default(global::android.accounts.Account);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _authority1699;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _startTime1700;
		public long startTime
		{
			get
			{
				return default(long);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.SyncInfo.staticClass = @__class;
		}
	}
}
