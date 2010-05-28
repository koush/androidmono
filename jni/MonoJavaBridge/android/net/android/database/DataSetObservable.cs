namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DataSetObservable : android.database.Observable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DataSetObservable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.DataSetObservable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.DataSetObservable(@__env); 
			} 
		} 
		protected DataSetObservable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyChanged2335; 
		public virtual void notifyChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.DataSetObservable)) 
				@__env.CallVoidMethod(this, global::android.database.DataSetObservable._notifyChanged2335); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyChanged2335); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyInvalidated2336; 
		public virtual void notifyInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.DataSetObservable)) 
				@__env.CallVoidMethod(this, global::android.database.DataSetObservable._notifyInvalidated2336); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._notifyInvalidated2336); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DataSetObservable2337; 
		public DataSetObservable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.DataSetObservable.staticClass, global::android.database.DataSetObservable._DataSetObservable2337, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.DataSetObservable.staticClass = @__class; 
			global::android.database.DataSetObservable._notifyChanged2335 = @__env.GetMethodID(global::android.database.DataSetObservable.staticClass, "notifyChanged", "()V"); 
			global::android.database.DataSetObservable._notifyInvalidated2336 = @__env.GetMethodID(global::android.database.DataSetObservable.staticClass, "notifyInvalidated", "()V"); 
			global::android.database.DataSetObservable._DataSetObservable2337 = @__env.GetMethodID(global::android.database.DataSetObservable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
