namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContentObservable : android.database.Observable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ContentObservable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.ContentObservable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.ContentObservable(@__env); 
			} 
		} 
		protected ContentObservable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyChange2060; 
		public virtual void notifyChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.ContentObservable)) 
				@__env.CallVoidMethod(this, _notifyChange2060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.ContentObservable.staticClass, _notifyChange2060, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchChange2061; 
		public virtual void dispatchChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.ContentObservable)) 
				@__env.CallVoidMethod(this, _dispatchChange2061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.ContentObservable.staticClass, _dispatchChange2061, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerObserver2062; 
		public virtual void registerObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.ContentObservable)) 
				@__env.CallVoidMethod(this, _registerObserver2062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.ContentObservable.staticClass, _registerObserver2062, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentObservable2063; 
		public ContentObservable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.ContentObservable.staticClass, _ContentObservable2063, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.ContentObservable.staticClass = @__class; 
			global::android.database.ContentObservable._notifyChange2060 = @__env.GetMethodID(global::android.database.ContentObservable.staticClass, "notifyChange", "(Z)V"); 
			global::android.database.ContentObservable._dispatchChange2061 = @__env.GetMethodID(global::android.database.ContentObservable.staticClass, "dispatchChange", "(Z)V"); 
			global::android.database.ContentObservable._registerObserver2062 = @__env.GetMethodID(global::android.database.ContentObservable.staticClass, "registerObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.ContentObservable._ContentObservable2063 = @__env.GetMethodID(global::android.database.ContentObservable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
