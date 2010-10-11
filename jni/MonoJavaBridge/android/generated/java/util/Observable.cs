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
		internal static global::MonoJavaBridge.MethodId _addObserver15592;
		public virtual void addObserver(java.util.Observer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._addObserver15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._addObserver15592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObserver15593;
		public virtual void deleteObserver(java.util.Observer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObserver15593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObserver15593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers15594;
		public virtual void notifyObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers15594);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers15594);
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers15595;
		public virtual void notifyObservers(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers15595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers15595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObservers15596;
		public virtual void deleteObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObservers15596);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObservers15596);
		}
		internal static global::MonoJavaBridge.MethodId _setChanged15597;
		protected virtual void setChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._setChanged15597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._setChanged15597);
		}
		internal static global::MonoJavaBridge.MethodId _clearChanged15598;
		protected virtual void clearChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._clearChanged15598);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._clearChanged15598);
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged15599;
		public virtual bool hasChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Observable._hasChanged15599);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._hasChanged15599);
		}
		internal static global::MonoJavaBridge.MethodId _countObservers15600;
		public virtual int countObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Observable._countObservers15600);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._countObservers15600);
		}
		internal static global::MonoJavaBridge.MethodId _Observable15601;
		public Observable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable15601);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Observable"));
			global::java.util.Observable._addObserver15592 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._deleteObserver15593 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._notifyObservers15594 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "()V");
			global::java.util.Observable._notifyObservers15595 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V");
			global::java.util.Observable._deleteObservers15596 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObservers", "()V");
			global::java.util.Observable._setChanged15597 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "setChanged", "()V");
			global::java.util.Observable._clearChanged15598 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "clearChanged", "()V");
			global::java.util.Observable._hasChanged15599 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "hasChanged", "()Z");
			global::java.util.Observable._countObservers15600 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "countObservers", "()I");
			global::java.util.Observable._Observable15601 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "<init>", "()V");
		}
	}
}
