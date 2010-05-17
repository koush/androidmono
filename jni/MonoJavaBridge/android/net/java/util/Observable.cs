namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Observable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Observable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Observable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _addObserver12028; 
		public virtual void addObserver(java.util.Observer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _addObserver12028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _addObserver12028, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteObserver12029; 
		public virtual void deleteObserver(java.util.Observer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _deleteObserver12029, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _deleteObserver12029, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyObservers12030; 
		public virtual void notifyObservers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _notifyObservers12030); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _notifyObservers12030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _notifyObservers12031; 
		public virtual void notifyObservers(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _notifyObservers12031, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _notifyObservers12031, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deleteObservers12032; 
		public virtual void deleteObservers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _deleteObservers12032); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _deleteObservers12032); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChanged12033; 
		protected virtual void setChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _setChanged12033); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _setChanged12033); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearChanged12034; 
		protected virtual void clearChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				@__env.CallVoidMethod(this, _clearChanged12034); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.util.Observable.staticClass, _clearChanged12034); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasChanged12035; 
		public virtual bool hasChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				return @__env.CallBooleanMethod(this, _hasChanged12035); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Observable.staticClass, _hasChanged12035); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _countObservers12036; 
		public virtual int countObservers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Observable)) 
				return @__env.CallIntMethod(this, _countObservers12036); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Observable.staticClass, _countObservers12036); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Observable12037; 
		public Observable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Observable.staticClass, _Observable12037, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Observable.staticClass = @__class; 
			global::java.util.Observable._addObserver12028 = @__env.GetMethodID(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V"); 
			global::java.util.Observable._deleteObserver12029 = @__env.GetMethodID(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V"); 
			global::java.util.Observable._notifyObservers12030 = @__env.GetMethodID(global::java.util.Observable.staticClass, "notifyObservers", "()V"); 
			global::java.util.Observable._notifyObservers12031 = @__env.GetMethodID(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V"); 
			global::java.util.Observable._deleteObservers12032 = @__env.GetMethodID(global::java.util.Observable.staticClass, "deleteObservers", "()V"); 
			global::java.util.Observable._setChanged12033 = @__env.GetMethodID(global::java.util.Observable.staticClass, "setChanged", "()V"); 
			global::java.util.Observable._clearChanged12034 = @__env.GetMethodID(global::java.util.Observable.staticClass, "clearChanged", "()V"); 
			global::java.util.Observable._hasChanged12035 = @__env.GetMethodID(global::java.util.Observable.staticClass, "hasChanged", "()Z"); 
			global::java.util.Observable._countObservers12036 = @__env.GetMethodID(global::java.util.Observable.staticClass, "countObservers", "()I"); 
			global::java.util.Observable._Observable12037 = @__env.GetMethodID(global::java.util.Observable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
