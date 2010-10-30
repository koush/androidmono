namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentObservable : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentObservable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void notifyChange(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.ContentObservable.staticClass, "notifyChange", "(Z)V", ref global::android.database.ContentObservable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void dispatchChange(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.ContentObservable.staticClass, "dispatchChange", "(Z)V", ref global::android.database.ContentObservable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void registerObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.ContentObservable.staticClass, "registerObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.ContentObservable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ContentObservable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.ContentObservable._m3.native == global::System.IntPtr.Zero)
				global::android.database.ContentObservable._m3 = @__env.GetMethodIDNoThrow(global::android.database.ContentObservable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.ContentObservable.staticClass, global::android.database.ContentObservable._m3);
			Init(@__env, handle);
		}
		static ContentObservable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.ContentObservable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/ContentObservable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
