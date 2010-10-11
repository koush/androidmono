namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataSetObservable : android.database.Observable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DataSetObservable()
		{
			InitJNI();
		}
		protected DataSetObservable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _notifyChanged2683;
		public virtual void notifyChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.DataSetObservable._notifyChanged2683);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyChanged2683);
		}
		internal static global::MonoJavaBridge.MethodId _notifyInvalidated2684;
		public virtual void notifyInvalidated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.DataSetObservable._notifyInvalidated2684);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyInvalidated2684);
		}
		internal static global::MonoJavaBridge.MethodId _DataSetObservable2685;
		public DataSetObservable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._DataSetObservable2685);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.DataSetObservable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/DataSetObservable"));
			global::android.database.DataSetObservable._notifyChanged2683 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "notifyChanged", "()V");
			global::android.database.DataSetObservable._notifyInvalidated2684 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "notifyInvalidated", "()V");
			global::android.database.DataSetObservable._DataSetObservable2685 = @__env.GetMethodIDNoThrow(global::android.database.DataSetObservable.staticClass, "<init>", "()V");
		}
	}
}
