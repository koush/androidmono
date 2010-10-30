namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyChangeListenerProxy : java.util.EventListenerProxy, PropertyChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PropertyChangeListenerProxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String PropertyName
		{
			get
			{
				return getPropertyName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPropertyName18782;
		public virtual global::java.lang.String getPropertyName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.PropertyChangeListenerProxy._getPropertyName18782.native == global::System.IntPtr.Zero)
				global::java.beans.PropertyChangeListenerProxy._getPropertyName18782 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListenerProxy.staticClass, "getPropertyName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.beans.PropertyChangeListenerProxy.staticClass, global::java.beans.PropertyChangeListenerProxy._getPropertyName18782) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _propertyChange18783;
		public virtual void propertyChange(java.beans.PropertyChangeEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.PropertyChangeListenerProxy._propertyChange18783.native == global::System.IntPtr.Zero)
				global::java.beans.PropertyChangeListenerProxy._propertyChange18783 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListenerProxy.staticClass, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.beans.PropertyChangeListenerProxy.staticClass, global::java.beans.PropertyChangeListenerProxy._propertyChange18783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PropertyChangeListenerProxy18784;
		public PropertyChangeListenerProxy(java.lang.String arg0, java.beans.PropertyChangeListener arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.PropertyChangeListenerProxy._PropertyChangeListenerProxy18784.native == global::System.IntPtr.Zero)
				global::java.beans.PropertyChangeListenerProxy._PropertyChangeListenerProxy18784 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListenerProxy.staticClass, "<init>", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeListenerProxy.staticClass, global::java.beans.PropertyChangeListenerProxy._PropertyChangeListenerProxy18784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static PropertyChangeListenerProxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeListenerProxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeListenerProxy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
