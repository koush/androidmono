namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SyncContext : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SyncContext()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.SyncContext), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.SyncContext(@__env);
			}
		}
		protected SyncContext(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFinished1696;
		public virtual void onFinished(android.content.SyncResult arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.SyncContext._onFinished1696, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.SyncContext.staticClass, global::android.content.SyncContext._onFinished1696, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSyncContextBinder1697;
		public virtual global::android.os.IBinder getSyncContextBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.SyncContext._getSyncContextBinder1697));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.SyncContext.staticClass, global::android.content.SyncContext._getSyncContextBinder1697));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.SyncContext.staticClass = @__class;
			global::android.content.SyncContext._onFinished1696 = @__env.GetMethodID(global::android.content.SyncContext.staticClass, "onFinished", "(Landroid/content/SyncResult;)V");
			global::android.content.SyncContext._getSyncContextBinder1697 = @__env.GetMethodID(global::android.content.SyncContext.staticClass, "getSyncContextBinder", "()Landroid/os/IBinder;");
		}
	}
}
