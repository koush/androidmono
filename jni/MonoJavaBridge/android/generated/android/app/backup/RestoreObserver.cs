namespace android.app.backup
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class RestoreObserver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static RestoreObserver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.backup.RestoreObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected RestoreObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreStarting934;
		public virtual void restoreStarting(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.RestoreObserver._restoreStarting934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._restoreStarting934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdate935;
		public virtual void onUpdate(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.RestoreObserver._onUpdate935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._onUpdate935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _restoreFinished936;
		public virtual void restoreFinished(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.backup.RestoreObserver._restoreFinished936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._restoreFinished936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RestoreObserver937;
		public RestoreObserver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._RestoreObserver937, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.backup.RestoreObserver.staticClass = @__class;
			global::android.app.backup.RestoreObserver._restoreStarting934 = @__env.GetMethodID(global::android.app.backup.RestoreObserver.staticClass, "restoreStarting", "(I)V");
			global::android.app.backup.RestoreObserver._onUpdate935 = @__env.GetMethodID(global::android.app.backup.RestoreObserver.staticClass, "onUpdate", "(ILjava/lang/String;)V");
			global::android.app.backup.RestoreObserver._restoreFinished936 = @__env.GetMethodID(global::android.app.backup.RestoreObserver.staticClass, "restoreFinished", "(I)V");
			global::android.app.backup.RestoreObserver._RestoreObserver937 = @__env.GetMethodID(global::android.app.backup.RestoreObserver.staticClass, "<init>", "()V");
		}
	}
}
