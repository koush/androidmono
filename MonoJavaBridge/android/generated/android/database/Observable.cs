namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.Observable_))]
	public abstract partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void registerObserver(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Observable.staticClass, "registerObserver", "(Ljava/lang/Object;)V", ref global::android.database.Observable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void unregisterObserver(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Observable.staticClass, "unregisterObserver", "(Ljava/lang/Object;)V", ref global::android.database.Observable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void unregisterAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.Observable.staticClass, "unregisterAll", "()V", ref global::android.database.Observable._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Observable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.Observable._m3.native == global::System.IntPtr.Zero)
				global::android.database.Observable._m3 = @__env.GetMethodIDNoThrow(global::android.database.Observable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.Observable.staticClass, global::android.database.Observable._m3);
			Init(@__env, handle);
		}
		static Observable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/Observable"));
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
	}
}
