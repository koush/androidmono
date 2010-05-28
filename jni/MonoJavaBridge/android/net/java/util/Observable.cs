namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Observable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Observable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Observable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.Observable(@__env); 
			} 
		} 
		protected Observable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addObserver12950; 
		public virtual void addObserver(java.util.Observer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._addObserver12950, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._addObserver12950, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteObserver12951; 
		public virtual void deleteObserver(java.util.Observer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._deleteObserver12951, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObserver12951, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyObservers12952; 
		public virtual void notifyObservers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._notifyObservers12952); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers12952); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyObservers12953; 
		public virtual void notifyObservers(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._notifyObservers12953, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers12953, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteObservers12954; 
		public virtual void deleteObservers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._deleteObservers12954); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObservers12954); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChanged12955; 
		protected virtual void setChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._setChanged12955); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._setChanged12955); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearChanged12956; 
		protected virtual void clearChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, global::java.util.Observable._clearChanged12956); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._clearChanged12956); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasChanged12957; 
		public virtual bool hasChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				return @__env.CallBooleanMethod(this, global::java.util.Observable._hasChanged12957); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._hasChanged12957); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countObservers12958; 
		public virtual int countObservers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				return @__env.CallIntMethod(this, global::java.util.Observable._countObservers12958); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Observable.staticClass, global::java.util.Observable._countObservers12958); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Observable12959; 
		public Observable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable12959, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Observable.staticClass = @__class; 
			global::java.util.Observable._addObserver12950 = @__env.GetMethodID(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V"); 
			global::java.util.Observable._deleteObserver12951 = @__env.GetMethodID(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V"); 
			global::java.util.Observable._notifyObservers12952 = @__env.GetMethodID(global::java.util.Observable.staticClass, "notifyObservers", "()V"); 
			global::java.util.Observable._notifyObservers12953 = @__env.GetMethodID(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V"); 
			global::java.util.Observable._deleteObservers12954 = @__env.GetMethodID(global::java.util.Observable.staticClass, "deleteObservers", "()V"); 
			global::java.util.Observable._setChanged12955 = @__env.GetMethodID(global::java.util.Observable.staticClass, "setChanged", "()V"); 
			global::java.util.Observable._clearChanged12956 = @__env.GetMethodID(global::java.util.Observable.staticClass, "clearChanged", "()V"); 
			global::java.util.Observable._hasChanged12957 = @__env.GetMethodID(global::java.util.Observable.staticClass, "hasChanged", "()Z"); 
			global::java.util.Observable._countObservers12958 = @__env.GetMethodID(global::java.util.Observable.staticClass, "countObservers", "()I"); 
			global::java.util.Observable._Observable12959 = @__env.GetMethodID(global::java.util.Observable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
