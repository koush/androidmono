namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.Observable_))]
	public abstract partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Observable()
		{
			InitJNI();
		}
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _registerObserver2780;
		public virtual void registerObserver(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Observable._registerObserver2780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Observable.staticClass, global::android.database.Observable._registerObserver2780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterObserver2781;
		public virtual void unregisterObserver(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Observable._unregisterObserver2781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Observable.staticClass, global::android.database.Observable._unregisterObserver2781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterAll2782;
		public virtual void unregisterAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.Observable._unregisterAll2782);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.Observable.staticClass, global::android.database.Observable._unregisterAll2782);
		}
		internal static global::MonoJavaBridge.MethodId _Observable2783;
		public Observable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.Observable.staticClass, global::android.database.Observable._Observable2783);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
			global::android.database.Observable._registerObserver2780 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "registerObserver", "(Ljava/lang/Object;)V");
			global::android.database.Observable._unregisterObserver2781 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "unregisterObserver", "(Ljava/lang/Object;)V");
			global::android.database.Observable._unregisterAll2782 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "unregisterAll", "()V");
			global::android.database.Observable._Observable2783 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.Observable))]
	public sealed partial class Observable_ : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Observable_()
		{
			InitJNI();
		}
		internal Observable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
		}
	}
}
