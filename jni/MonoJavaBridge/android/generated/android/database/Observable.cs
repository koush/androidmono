namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Observable : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Observable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.Observable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Observable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerObserver2613;
		public virtual void registerObserver(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.Observable._registerObserver2613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.Observable.staticClass, global::android.database.Observable._registerObserver2613, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterObserver2614;
		public virtual void unregisterObserver(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.Observable._unregisterObserver2614, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.Observable.staticClass, global::android.database.Observable._unregisterObserver2614, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterAll2615;
		public virtual void unregisterAll() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.Observable._unregisterAll2615);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.Observable.staticClass, global::android.database.Observable._unregisterAll2615);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Observable2616;
		public Observable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.Observable.staticClass, global::android.database.Observable._Observable2616, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.Observable.staticClass = @__class;
			global::android.database.Observable._registerObserver2613 = @__env.GetMethodID(global::android.database.Observable.staticClass, "registerObserver", "(Ljava/lang/Object;)V");
			global::android.database.Observable._unregisterObserver2614 = @__env.GetMethodID(global::android.database.Observable.staticClass, "unregisterObserver", "(Ljava/lang/Object;)V");
			global::android.database.Observable._unregisterAll2615 = @__env.GetMethodID(global::android.database.Observable.staticClass, "unregisterAll", "()V");
			global::android.database.Observable._Observable2616 = @__env.GetMethodID(global::android.database.Observable.staticClass, "<init>", "()V");
		}
	}
}
