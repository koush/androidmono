namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class DataSetObserver : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DataSetObserver() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.DataSetObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected DataSetObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChanged2154; 
		public virtual void onChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.DataSetObserver)) 
				@__env.CallVoidMethod(this, _onChanged2154); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.DataSetObserver.staticClass, _onChanged2154); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInvalidated2155; 
		public virtual void onInvalidated() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.DataSetObserver)) 
				@__env.CallVoidMethod(this, _onInvalidated2155); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.DataSetObserver.staticClass, _onInvalidated2155); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DataSetObserver2156; 
		public DataSetObserver()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.DataSetObserver.staticClass, _DataSetObserver2156, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.DataSetObserver.staticClass = @__class; 
			global::android.database.DataSetObserver._onChanged2154 = @__env.GetMethodID(global::android.database.DataSetObserver.staticClass, "onChanged", "()V"); 
			global::android.database.DataSetObserver._onInvalidated2155 = @__env.GetMethodID(global::android.database.DataSetObserver.staticClass, "onInvalidated", "()V"); 
			global::android.database.DataSetObserver._DataSetObserver2156 = @__env.GetMethodID(global::android.database.DataSetObserver.staticClass, "<init>", "()V"); 
		} 
	} 
} 
