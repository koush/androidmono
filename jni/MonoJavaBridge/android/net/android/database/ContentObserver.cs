namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ContentObserver : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ContentObserver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.ContentObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected ContentObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deliverSelfNotifications2169; 
		public virtual bool deliverSelfNotifications() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.ContentObserver)) 
				return @__env.CallBooleanMethod(this, _deliverSelfNotifications2169); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.ContentObserver.staticClass, _deliverSelfNotifications2169); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChange2170; 
		public virtual void onChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.ContentObserver)) 
				@__env.CallVoidMethod(this, _onChange2170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.ContentObserver.staticClass, _onChange2170, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchChange2171; 
		public virtual void dispatchChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.ContentObserver)) 
				@__env.CallVoidMethod(this, _dispatchChange2171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.ContentObserver.staticClass, _dispatchChange2171, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentObserver2172; 
		public ContentObserver(android.os.Handler arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.ContentObserver.staticClass, _ContentObserver2172, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.ContentObserver.staticClass = @__class; 
			global::android.database.ContentObserver._deliverSelfNotifications2169 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "deliverSelfNotifications", "()Z"); 
			global::android.database.ContentObserver._onChange2170 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "onChange", "(Z)V"); 
			global::android.database.ContentObserver._dispatchChange2171 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "dispatchChange", "(Z)V"); 
			global::android.database.ContentObserver._ContentObserver2172 = @__env.GetMethodID(global::android.database.ContentObserver.staticClass, "<init>", "(Landroid/os/Handler;)V"); 
		} 
	} 
} 
