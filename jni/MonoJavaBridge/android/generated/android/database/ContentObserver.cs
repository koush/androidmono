namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ContentObserver : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ContentObserver()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.ContentObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ContentObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _deliverSelfNotifications2350;
		public virtual bool deliverSelfNotifications() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.ContentObserver._deliverSelfNotifications2350);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._deliverSelfNotifications2350);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChange2351;
		public virtual void onChange(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.ContentObserver._onChange2351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._onChange2351, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchChange2352;
		public virtual void dispatchChange(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.ContentObserver._dispatchChange2352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.ContentObserver.staticClass, global::android.database.ContentObserver._dispatchChange2352, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ContentObserver2353;
		public ContentObserver(android.os.Handler arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.database.ContentObserver.staticClass, global::android.database.ContentObserver._ContentObserver2353, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.ContentObserver.staticClass = @__class;
			global::android.database.ContentObserver._deliverSelfNotifications2350 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "deliverSelfNotifications", "()Z");
			global::android.database.ContentObserver._onChange2351 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "onChange", "(Z)V");
			global::android.database.ContentObserver._dispatchChange2352 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "dispatchChange", "(Z)V");
			global::android.database.ContentObserver._ContentObserver2353 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "<init>", "(Landroid/os/Handler;)V");
		}
	}
}
