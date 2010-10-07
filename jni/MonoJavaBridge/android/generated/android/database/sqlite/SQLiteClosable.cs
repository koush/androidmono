namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SQLiteClosable : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SQLiteClosable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteClosable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SQLiteClosable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2623;
		protected abstract void onAllReferencesReleased();
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleasedFromContainer2624;
		protected virtual void onAllReferencesReleasedFromContainer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2624);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2624);
		}
		internal static global::net.sf.jni4net.jni.MethodId _acquireReference2625;
		public virtual void acquireReference() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable._acquireReference2625);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._acquireReference2625);
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseReference2626;
		public virtual void releaseReference() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable._releaseReference2626);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._releaseReference2626);
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseReferenceFromContainer2627;
		public virtual void releaseReferenceFromContainer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2627);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2627);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteClosable2628;
		public SQLiteClosable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.sqlite.SQLiteClosable.staticClass, global::android.database.sqlite.SQLiteClosable._SQLiteClosable2628, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteClosable.staticClass = @__class;
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleased2623 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2624 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleasedFromContainer", "()V");
			global::android.database.sqlite.SQLiteClosable._acquireReference2625 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "acquireReference", "()V");
			global::android.database.sqlite.SQLiteClosable._releaseReference2626 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReference", "()V");
			global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2627 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReferenceFromContainer", "()V");
			global::android.database.sqlite.SQLiteClosable._SQLiteClosable2628 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "<init>", "()V");
		}
	}
}
