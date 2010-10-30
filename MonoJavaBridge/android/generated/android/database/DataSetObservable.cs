namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataSetObservable : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataSetObservable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _notifyChanged4598;
		public virtual void notifyChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyChanged4598);
		}
		internal static global::MonoJavaBridge.MethodId _notifyInvalidated4599;
		public virtual void notifyInvalidated()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyInvalidated4599);
		}
		internal static global::MonoJavaBridge.MethodId _DataSetObservable4600;
		public DataSetObservable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._DataSetObservable4600);
			Init(@__env, handle);
		}
		static DataSetObservable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObservable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObservable"));
			global::android.database.DataSetObservable._notifyChanged4598 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "notifyChanged", "()V");
			global::android.database.DataSetObservable._notifyInvalidated4599 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "notifyInvalidated", "()V");
			global::android.database.DataSetObservable._DataSetObservable4600 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
