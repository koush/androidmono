namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addObserver26527;
		public virtual void addObserver(java.util.Observer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V", ref global::java.util.Observable._addObserver26527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObserver26528;
		public virtual void deleteObserver(java.util.Observer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V", ref global::java.util.Observable._deleteObserver26528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers26529;
		public virtual void notifyObservers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "notifyObservers", "()V", ref global::java.util.Observable._notifyObservers26529);
		}
		internal static global::MonoJavaBridge.MethodId _notifyObservers26530;
		public virtual void notifyObservers(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V", ref global::java.util.Observable._notifyObservers26530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteObservers26531;
		public virtual void deleteObservers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "deleteObservers", "()V", ref global::java.util.Observable._deleteObservers26531);
		}
		internal static global::MonoJavaBridge.MethodId _setChanged26532;
		protected virtual void setChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "setChanged", "()V", ref global::java.util.Observable._setChanged26532);
		}
		internal static global::MonoJavaBridge.MethodId _clearChanged26533;
		protected virtual void clearChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "clearChanged", "()V", ref global::java.util.Observable._clearChanged26533);
		}
		internal static global::MonoJavaBridge.MethodId _hasChanged26534;
		public virtual bool hasChanged()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Observable.staticClass, "hasChanged", "()Z", ref global::java.util.Observable._hasChanged26534);
		}
		internal static global::MonoJavaBridge.MethodId _countObservers26535;
		public virtual int countObservers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Observable.staticClass, "countObservers", "()I", ref global::java.util.Observable._countObservers26535);
		}
		internal static global::MonoJavaBridge.MethodId _Observable26536;
		public Observable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Observable._Observable26536.native == global::System.IntPtr.Zero)
				global::java.util.Observable._Observable26536 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._Observable26536);
			Init(@__env, handle);
		}
		static Observable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Observable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Observable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
