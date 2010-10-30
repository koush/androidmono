namespace java.beans
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.beans.PropertyChangeListener_))]
	public partial interface PropertyChangeListener : java.util.EventListener
	{
		void propertyChange(java.beans.PropertyChangeEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.beans.PropertyChangeListener))]
	internal sealed partial class PropertyChangeListener_ : java.lang.Object, PropertyChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PropertyChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _propertyChange18781;
		void java.beans.PropertyChangeListener.propertyChange(java.beans.PropertyChangeEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.beans.PropertyChangeListener_._propertyChange18781.native == global::System.IntPtr.Zero)
				global::java.beans.PropertyChangeListener_._propertyChange18781 = @__env.GetMethodIDNoThrow(global::java.beans.PropertyChangeListener_.staticClass, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.beans.PropertyChangeListener_._propertyChange18781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static PropertyChangeListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.beans.PropertyChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/beans/PropertyChangeListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
