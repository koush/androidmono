namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NodeChangeEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NodeChangeEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.util.prefs.Preferences Parent
		{
			get
			{
				return getParent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParent28177;
		public virtual global::java.util.prefs.Preferences getParent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.NodeChangeEvent._getParent28177)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.NodeChangeEvent.staticClass, global::java.util.prefs.NodeChangeEvent._getParent28177)) as java.util.prefs.Preferences;
		}
		public new global::java.util.prefs.Preferences Child
		{
			get
			{
				return getChild();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChild28178;
		public virtual global::java.util.prefs.Preferences getChild()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.prefs.NodeChangeEvent._getChild28178)) as java.util.prefs.Preferences;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.prefs.NodeChangeEvent.staticClass, global::java.util.prefs.NodeChangeEvent._getChild28178)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _NodeChangeEvent28179;
		public NodeChangeEvent(java.util.prefs.Preferences arg0, java.util.prefs.Preferences arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.NodeChangeEvent.staticClass, global::java.util.prefs.NodeChangeEvent._NodeChangeEvent28179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static NodeChangeEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.NodeChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/NodeChangeEvent"));
			global::java.util.prefs.NodeChangeEvent._getParent28177 = @__env.GetMethodIDNoThrow(global::java.util.prefs.NodeChangeEvent.staticClass, "getParent", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.NodeChangeEvent._getChild28178 = @__env.GetMethodIDNoThrow(global::java.util.prefs.NodeChangeEvent.staticClass, "getChild", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.NodeChangeEvent._NodeChangeEvent28179 = @__env.GetMethodIDNoThrow(global::java.util.prefs.NodeChangeEvent.staticClass, "<init>", "(Ljava/util/prefs/Preferences;Ljava/util/prefs/Preferences;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
