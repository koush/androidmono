namespace android.database.sqlite 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class SQLiteClosable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SQLiteClosable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.sqlite.SQLiteClosable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected SQLiteClosable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2252; 
		protected abstract void onAllReferencesReleased(); 
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleasedFromContainer2253; 
		protected virtual void onAllReferencesReleasedFromContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteClosable)) 
				@__env.CallVoidMethod(this, _onAllReferencesReleasedFromContainer2253); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteClosable.staticClass, _onAllReferencesReleasedFromContainer2253); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _acquireReference2254; 
		public virtual void acquireReference() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteClosable)) 
				@__env.CallVoidMethod(this, _acquireReference2254); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteClosable.staticClass, _acquireReference2254); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _releaseReference2255; 
		public virtual void releaseReference() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteClosable)) 
				@__env.CallVoidMethod(this, _releaseReference2255); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteClosable.staticClass, _releaseReference2255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _releaseReferenceFromContainer2256; 
		public virtual void releaseReferenceFromContainer() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.sqlite.SQLiteClosable)) 
				@__env.CallVoidMethod(this, _releaseReferenceFromContainer2256); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.sqlite.SQLiteClosable.staticClass, _releaseReferenceFromContainer2256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SQLiteClosable2257; 
		public SQLiteClosable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.sqlite.SQLiteClosable.staticClass, _SQLiteClosable2257, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.sqlite.SQLiteClosable.staticClass = @__class; 
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleased2252 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleased", "()V"); 
			global::android.database.sqlite.SQLiteClosable._onAllReferencesReleasedFromContainer2253 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "onAllReferencesReleasedFromContainer", "()V"); 
			global::android.database.sqlite.SQLiteClosable._acquireReference2254 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "acquireReference", "()V"); 
			global::android.database.sqlite.SQLiteClosable._releaseReference2255 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReference", "()V"); 
			global::android.database.sqlite.SQLiteClosable._releaseReferenceFromContainer2256 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "releaseReferenceFromContainer", "()V"); 
			global::android.database.sqlite.SQLiteClosable._SQLiteClosable2257 = @__env.GetMethodID(global::android.database.sqlite.SQLiteClosable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
