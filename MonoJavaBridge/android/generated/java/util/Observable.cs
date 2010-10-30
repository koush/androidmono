namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Observable : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Observable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void addObserver(java.util.Observer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "addObserver", "(Ljava/util/Observer;)V", ref global::java.util.Observable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void deleteObserver(java.util.Observer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "deleteObserver", "(Ljava/util/Observer;)V", ref global::java.util.Observable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void notifyObservers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "notifyObservers", "()V", ref global::java.util.Observable._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void notifyObservers(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "notifyObservers", "(Ljava/lang/Object;)V", ref global::java.util.Observable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void deleteObservers()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "deleteObservers", "()V", ref global::java.util.Observable._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual void setChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "setChanged", "()V", ref global::java.util.Observable._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void clearChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Observable.staticClass, "clearChanged", "()V", ref global::java.util.Observable._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool hasChanged()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Observable.staticClass, "hasChanged", "()Z", ref global::java.util.Observable._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int countObservers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Observable.staticClass, "countObservers", "()I", ref global::java.util.Observable._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public Observable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Observable._m9.native == global::System.IntPtr.Zero)
				global::java.util.Observable._m9 = @__env.GetMethodIDNoThrow(global::java.util.Observable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Observable.staticClass, global::java.util.Observable._m9);
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
