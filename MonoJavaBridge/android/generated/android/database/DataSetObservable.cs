namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataSetObservable : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataSetObservable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void notifyChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObservable.staticClass, "notifyChanged", "()V", ref global::android.database.DataSetObservable._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void notifyInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObservable.staticClass, "notifyInvalidated", "()V", ref global::android.database.DataSetObservable._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public DataSetObservable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.DataSetObservable._m2.native == global::System.IntPtr.Zero)
				global::android.database.DataSetObservable._m2 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._m2);
			Init(@__env, handle);
		}
		static DataSetObservable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObservable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObservable"));
		}
	}
}
