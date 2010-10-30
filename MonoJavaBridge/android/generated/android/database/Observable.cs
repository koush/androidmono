namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.Observable_))]
	public abstract partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _registerObserver4696;
		public virtual void registerObserver(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Observable.staticClass, "registerObserver", "(Ljava/lang/Object;)V", ref global::android.database.Observable._registerObserver4696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterObserver4697;
		public virtual void unregisterObserver(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Observable.staticClass, "unregisterObserver", "(Ljava/lang/Object;)V", ref global::android.database.Observable._unregisterObserver4697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterAll4698;
		public virtual void unregisterAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Observable.staticClass, "unregisterAll", "()V", ref global::android.database.Observable._unregisterAll4698);
		}
		internal static global::MonoJavaBridge.MethodId _Observable4699;
		public Observable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Observable._Observable4699.native == global::System.IntPtr.Zero)
				global::android.database.Observable._Observable4699 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.Observable.staticClass, global::android.database.Observable._Observable4699);
			Init(@__env, handle);
		}
		static Observable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.Observable))]
	internal sealed partial class Observable_ : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Observable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Observable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
