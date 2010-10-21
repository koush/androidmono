namespace java.beans
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyChangeListenerProxy : java.util.EventListenerProxy, PropertyChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PropertyChangeListenerProxy()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getPropertyName18664;
		public virtual global::java.lang.String getPropertyName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeListenerProxy._getPropertyName18664)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.beans.PropertyChangeListenerProxy.staticClass, global::java.beans.PropertyChangeListenerProxy._getPropertyName18664)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _propertyChange18665;
		public virtual void propertyChange(java.beans.PropertyChangeEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeListenerProxy._propertyChange18665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeListenerProxy.staticClass, global::java.beans.PropertyChangeListenerProxy._propertyChange18665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PropertyChangeListenerProxy18666;
		public PropertyChangeListenerProxy(java.lang.String arg0, java.beans.PropertyChangeListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.beans.PropertyChangeListenerProxy.staticClass, global::java.beans.PropertyChangeListenerProxy._PropertyChangeListenerProxy18666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeListenerProxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeListenerProxy"));
			global::java.beans.PropertyChangeListenerProxy._getPropertyName18664 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListenerProxy.staticClass, "getPropertyName", "()Ljava/lang/String;");
			global::java.beans.PropertyChangeListenerProxy._propertyChange18665 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListenerProxy.staticClass, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
			global::java.beans.PropertyChangeListenerProxy._PropertyChangeListenerProxy18666 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListenerProxy.staticClass, "<init>", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V");
		}
	}
}
