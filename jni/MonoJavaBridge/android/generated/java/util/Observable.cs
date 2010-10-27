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
		internal static global::MonoJavaBridge.MethodId _addObserver26526;
		public virtual void addObserver(java.util.Observer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._addObserver26526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._addObserver26526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObserver26527;
		public virtual void deleteObserver(java.util.Observer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObserver26527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObserver26527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers26528;
		public virtual void notifyObservers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers26528);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers26528);
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers26529;
		public virtual void notifyObservers(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._notifyObservers26529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._notifyObservers26529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObservers26530;
		public virtual void deleteObservers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._deleteObservers26530);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._deleteObservers26530);
		}
		internal static global::MonoJavaBridge.MethodId _setChanged26531;
		protected virtual void setChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._setChanged26531);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._setChanged26531);
		}
		internal static global::MonoJavaBridge.MethodId _clearChanged26532;
		protected virtual void clearChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Observable._clearChanged26532);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._clearChanged26532);
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged26533;
		public virtual bool hasChanged()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Observable._hasChanged26533);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._hasChanged26533);
		}
		internal static global::MonoJavaBridge.MethodId _countObservers26534;
		public virtual int countObservers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Observable._countObservers26534);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Observable.staticClass, global::java.util.Observable._countObservers26534);
		}
		internal static global::MonoJavaBridge.MethodId _Observable26535;
		public Observable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable26535);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Observable"));
			global::java.util.Observable._addObserver26526 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._deleteObserver26527 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V");
			global::java.util.Observable._notifyObservers26528 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "()V");
			global::java.util.Observable._notifyObservers26529 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V");
			global::java.util.Observable._deleteObservers26530 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "deleteObservers", "()V");
			global::java.util.Observable._setChanged26531 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "setChanged", "()V");
			global::java.util.Observable._clearChanged26532 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "clearChanged", "()V");
			global::java.util.Observable._hasChanged26533 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "hasChanged", "()Z");
			global::java.util.Observable._countObservers26534 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "countObservers", "()I");
			global::java.util.Observable._Observable26535 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "<init>", "()V");
		}
	}
}
