namespace java.beans
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.beans.PropertyChangeListener_))]
	public interface PropertyChangeListener : java.util.EventListener
	{
		void propertyChange(java.beans.PropertyChangeEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.beans.PropertyChangeListener))]
	public sealed partial class PropertyChangeListener_ : java.lang.Object, PropertyChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PropertyChangeListener_()
		{
			InitJNI();
		}
		internal PropertyChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _propertyChange18663;
		 void java.beans.PropertyChangeListener.propertyChange(java.beans.PropertyChangeEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeListener_._propertyChange18663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeListener_.staticClass, global::java.beans.PropertyChangeListener_._propertyChange18663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeListener"));
			global::java.beans.PropertyChangeListener_._propertyChange18663 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListener_.staticClass, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
		}
	}
}
