namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentObservable : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentObservable()
		{
			InitJNI();
		}
		protected ContentObservable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _notifyChange2512;
		public virtual void notifyChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObservable._notifyChange2512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObservable.staticClass, global::android.database.ContentObservable._notifyChange2512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _dispatchChange2513;
		public virtual void dispatchChange(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObservable._dispatchChange2513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObservable.staticClass, global::android.database.ContentObservable._dispatchChange2513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerObserver2514;
		public virtual void registerObserver(android.database.ContentObserver arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.ContentObservable._registerObserver2514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.ContentObservable.staticClass, global::android.database.ContentObservable._registerObserver2514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ContentObservable2515;
		public ContentObservable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.ContentObservable.staticClass, global::android.database.ContentObservable._ContentObservable2515);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.ContentObservable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/ContentObservable"));
			global::android.database.ContentObservable._notifyChange2512 = @__env.GetMethodIDNoThrow(global::android.database.ContentObservable.staticClass, "notifyChange", "(Z)V");
			global::android.database.ContentObservable._dispatchChange2513 = @__env.GetMethodIDNoThrow(global::android.database.ContentObservable.staticClass, "dispatchChange", "(Z)V");
			global::android.database.ContentObservable._registerObserver2514 = @__env.GetMethodIDNoThrow(global::android.database.ContentObservable.staticClass, "registerObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.ContentObservable._ContentObservable2515 = @__env.GetMethodIDNoThrow(global::android.database.ContentObservable.staticClass, "<init>", "()V");
		}
	}
}
