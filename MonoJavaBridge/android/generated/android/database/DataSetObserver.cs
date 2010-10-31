namespace android.database
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.database.DataSetObserver_))]
	public abstract partial class DataSetObserver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataSetObserver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObserver.staticClass, "onChanged", "()V", ref global::android.database.DataSetObserver._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObserver.staticClass, "onInvalidated", "()V", ref global::android.database.DataSetObserver._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DataSetObserver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DataSetObserver._m2.native == global::System.IntPtr.Zero)
				global::android.database.DataSetObserver._m2 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObserver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._m2);
			Init(@__env, handle);
		}
		static DataSetObserver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObserver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObserver"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.DataSetObserver))]
	internal sealed partial class DataSetObserver_ : android.database.DataSetObserver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DataSetObserver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static DataSetObserver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObserver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObserver"));
		}
	}
}
