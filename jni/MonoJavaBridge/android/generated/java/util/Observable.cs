namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Observable()
		{
			InitJNI();
		}
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addObserver20583;
		public virtual void addObserver(java.util.Observer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._addObserver20583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._addObserver20583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObserver20584;
		public virtual void deleteObserver(java.util.Observer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObserver20584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObserver20584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers20585;
		public virtual void notifyObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers20585);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers20585);
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers20586;
		public virtual void notifyObservers(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers20586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers20586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObservers20587;
		public virtual void deleteObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObservers20587);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObservers20587);
		}
		internal static global::MonoJavaBridge.MethodId _setChanged20588;
		protected virtual void setChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._setChanged20588);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._setChanged20588);
		}
		internal static global::MonoJavaBridge.MethodId _clearChanged20589;
		protected virtual void clearChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._clearChanged20589);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._clearChanged20589);
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged20590;
		public virtual bool hasChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Observable._hasChanged20590);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._hasChanged20590);
		}
		internal static global::MonoJavaBridge.MethodId _countObservers20591;
		public virtual int countObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Observable._countObservers20591);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._countObservers20591);
		}
		internal static global::MonoJavaBridge.MethodId _Observable20592;
		public Observable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable20592);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Observable"));
			global::java.util.Observable._addObserver20583 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._deleteObserver20584 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._notifyObservers20585 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "()V");
			global::java.util.Observable._notifyObservers20586 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V");
			global::java.util.Observable._deleteObservers20587 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObservers", "()V");
			global::java.util.Observable._setChanged20588 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "setChanged", "()V");
			global::java.util.Observable._clearChanged20589 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "clearChanged", "()V");
			global::java.util.Observable._hasChanged20590 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "hasChanged", "()Z");
			global::java.util.Observable._countObservers20591 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "countObservers", "()I");
			global::java.util.Observable._Observable20592 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "<init>", "()V");
		}
	}
}
