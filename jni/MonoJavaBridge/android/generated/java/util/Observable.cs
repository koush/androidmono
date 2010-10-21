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
		internal static global::MonoJavaBridge.MethodId _addObserver26408;
		public virtual void addObserver(java.util.Observer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._addObserver26408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._addObserver26408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObserver26409;
		public virtual void deleteObserver(java.util.Observer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObserver26409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObserver26409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers26410;
		public virtual void notifyObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers26410);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers26410);
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers26411;
		public virtual void notifyObservers(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers26411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers26411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObservers26412;
		public virtual void deleteObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObservers26412);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObservers26412);
		}
		internal static global::MonoJavaBridge.MethodId _setChanged26413;
		protected virtual void setChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._setChanged26413);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._setChanged26413);
		}
		internal static global::MonoJavaBridge.MethodId _clearChanged26414;
		protected virtual void clearChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._clearChanged26414);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._clearChanged26414);
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged26415;
		public virtual bool hasChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Observable._hasChanged26415);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._hasChanged26415);
		}
		internal static global::MonoJavaBridge.MethodId _countObservers26416;
		public virtual int countObservers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Observable._countObservers26416);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._countObservers26416);
		}
		internal static global::MonoJavaBridge.MethodId _Observable26417;
		public Observable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable26417);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Observable"));
			global::java.util.Observable._addObserver26408 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._deleteObserver26409 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._notifyObservers26410 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "()V");
			global::java.util.Observable._notifyObservers26411 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V");
			global::java.util.Observable._deleteObservers26412 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObservers", "()V");
			global::java.util.Observable._setChanged26413 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "setChanged", "()V");
			global::java.util.Observable._clearChanged26414 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "clearChanged", "()V");
			global::java.util.Observable._hasChanged26415 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "hasChanged", "()Z");
			global::java.util.Observable._countObservers26416 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "countObservers", "()I");
			global::java.util.Observable._Observable26417 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "<init>", "()V");
		}
	}
}
