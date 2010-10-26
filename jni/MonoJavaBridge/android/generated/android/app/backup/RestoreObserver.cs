namespace android.app.backup
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.app.backup.RestoreObserver_))]
	public abstract partial class RestoreObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RestoreObserver()
		{
			InitJNI();
		}
		protected RestoreObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _restoreStarting2333;
		public virtual void restoreStarting(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.RestoreObserver._restoreStarting2333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._restoreStarting2333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdate2334;
		public virtual void onUpdate(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.RestoreObserver._onUpdate2334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._onUpdate2334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _restoreFinished2335;
		public virtual void restoreFinished(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.backup.RestoreObserver._restoreFinished2335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._restoreFinished2335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RestoreObserver2336;
		public RestoreObserver()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.app.backup.RestoreObserver.staticClass, global::android.app.backup.RestoreObserver._RestoreObserver2336);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.RestoreObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/RestoreObserver"));
			global::android.app.backup.RestoreObserver._restoreStarting2333 = @__env.GetMethodIDNoThrow(global::android.app.backup.RestoreObserver.staticClass, "restoreStarting", "(I)V");
			global::android.app.backup.RestoreObserver._onUpdate2334 = @__env.GetMethodIDNoThrow(global::android.app.backup.RestoreObserver.staticClass, "onUpdate", "(ILjava/lang/String;)V");
			global::android.app.backup.RestoreObserver._restoreFinished2335 = @__env.GetMethodIDNoThrow(global::android.app.backup.RestoreObserver.staticClass, "restoreFinished", "(I)V");
			global::android.app.backup.RestoreObserver._RestoreObserver2336 = @__env.GetMethodIDNoThrow(global::android.app.backup.RestoreObserver.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.app.backup.RestoreObserver))]
	internal sealed partial class RestoreObserver_ : android.app.backup.RestoreObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RestoreObserver_()
		{
			InitJNI();
		}
		internal RestoreObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.backup.RestoreObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/backup/RestoreObserver"));
		}
	}
}
