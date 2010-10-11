namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.ContentObserver_))]
	public abstract partial class ContentObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentObserver()
		{
			InitJNI();
		}
		protected ContentObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _deliverSelfNotifications2516;
		public virtual bool deliverSelfNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.ContentObserver._deliverSelfNotifications2516);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._deliverSelfNotifications2516);
		}
		internal static global::MonoJavaBridge.MethodId _onChange2517;
		public virtual void onChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObserver._onChange2517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._onChange2517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchChange2518;
		public virtual void dispatchChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObserver._dispatchChange2518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._dispatchChange2518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ContentObserver2519;
		public ContentObserver(android.os.Handler arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.ContentObserver.staticClass, global::android.database.ContentObserver._ContentObserver2519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.ContentObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/ContentObserver"));
			global::android.database.ContentObserver._deliverSelfNotifications2516 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "deliverSelfNotifications", "()Z");
			global::android.database.ContentObserver._onChange2517 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "onChange", "(Z)V");
			global::android.database.ContentObserver._dispatchChange2518 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "dispatchChange", "(Z)V");
			global::android.database.ContentObserver._ContentObserver2519 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "<init>", "(Landroid/os/Handler;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.ContentObserver))]
	public sealed partial class ContentObserver_ : android.database.ContentObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentObserver_()
		{
			InitJNI();
		}
		internal ContentObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.ContentObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/ContentObserver"));
		}
	}
}
