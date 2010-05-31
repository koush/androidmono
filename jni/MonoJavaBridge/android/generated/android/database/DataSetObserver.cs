namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class DataSetObserver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DataSetObserver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.DataSetObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected DataSetObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChanged2338;
		public virtual void onChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.DataSetObserver._onChanged2338);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._onChanged2338);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInvalidated2339;
		public virtual void onInvalidated() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.DataSetObserver._onInvalidated2339);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._onInvalidated2339);
		}
		internal static global::net.sf.jni4net.jni.MethodId _DataSetObserver2340;
		public DataSetObserver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.DataSetObserver.staticClass, global::android.database.DataSetObserver._DataSetObserver2340, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.DataSetObserver.staticClass = @__class;
			global::android.database.DataSetObserver._onChanged2338 = @__env.GetMethodID(global::android.database.DataSetObserver.staticClass, "onChanged", "()V");
			global::android.database.DataSetObserver._onInvalidated2339 = @__env.GetMethodID(global::android.database.DataSetObserver.staticClass, "onInvalidated", "()V");
			global::android.database.DataSetObserver._DataSetObserver2340 = @__env.GetMethodID(global::android.database.DataSetObserver.staticClass, "<init>", "()V");
		}
	}
}
