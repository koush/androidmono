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
		internal static global::MonoJavaBridge.MethodId _deliverSelfNotifications4431;
		public virtual bool deliverSelfNotifications() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.ContentObserver._deliverSelfNotifications4431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._deliverSelfNotifications4431);
		}
		internal static global::MonoJavaBridge.MethodId _onChange4432;
		public virtual void onChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObserver._onChange4432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._onChange4432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchChange4433;
		public virtual void dispatchChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObserver._dispatchChange4433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._dispatchChange4433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ContentObserver4434;
		public ContentObserver(android.os.Handler arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.ContentObserver.staticClass, global::android.database.ContentObserver._ContentObserver4434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.ContentObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/ContentObserver"));
			global::android.database.ContentObserver._deliverSelfNotifications4431 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "deliverSelfNotifications", "()Z");
			global::android.database.ContentObserver._onChange4432 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "onChange", "(Z)V");
			global::android.database.ContentObserver._dispatchChange4433 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "dispatchChange", "(Z)V");
			global::android.database.ContentObserver._ContentObserver4434 = @__env.GetMethodIDNoThrow(global::android.database.ContentObserver.staticClass, "<init>", "(Landroid/os/Handler;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.ContentObserver))]
	internal sealed partial class ContentObserver_ : android.database.ContentObserver
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
