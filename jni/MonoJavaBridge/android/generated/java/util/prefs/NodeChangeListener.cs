namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.prefs.NodeChangeListener_))]
	public partial interface NodeChangeListener : EventListener
	{
		void childAdded(java.util.prefs.NodeChangeEvent arg0);
		void childRemoved(java.util.prefs.NodeChangeEvent arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.prefs.NodeChangeListener))]
	internal sealed partial class NodeChangeListener_ : java.lang.Object, NodeChangeListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NodeChangeListener_()
		{
			InitJNI();
		}
		internal NodeChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _childAdded28180;
		void java.util.prefs.NodeChangeListener.childAdded(java.util.prefs.NodeChangeEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.NodeChangeListener_._childAdded28180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.NodeChangeListener_.staticClass, global::java.util.prefs.NodeChangeListener_._childAdded28180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _childRemoved28181;
		void java.util.prefs.NodeChangeListener.childRemoved(java.util.prefs.NodeChangeEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.prefs.NodeChangeListener_._childRemoved28181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.prefs.NodeChangeListener_.staticClass, global::java.util.prefs.NodeChangeListener_._childRemoved28181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.NodeChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/NodeChangeListener"));
			global::java.util.prefs.NodeChangeListener_._childAdded28180 = @__env.GetMethodIDNoThrow(global::java.util.prefs.NodeChangeListener_.staticClass, "childAdded", "(Ljava/util/prefs/NodeChangeEvent;)V");
			global::java.util.prefs.NodeChangeListener_._childRemoved28181 = @__env.GetMethodIDNoThrow(global::java.util.prefs.NodeChangeListener_.staticClass, "childRemoved", "(Ljava/util/prefs/NodeChangeEvent;)V");
		}
	}
}
