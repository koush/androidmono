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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.util.prefs.Preferences getParent()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.NodeChangeEvent.staticClass, "getParent", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.NodeChangeEvent._m0) as java.util.prefs.Preferences;
		}
		public new global::java.util.prefs.Preferences Child
		{
			get
			{
				return getChild();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.util.prefs.Preferences getChild()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.NodeChangeEvent.staticClass, "getChild", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.NodeChangeEvent._m1) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public NodeChangeEvent(java.util.prefs.Preferences arg0, java.util.prefs.Preferences arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.NodeChangeEvent._m2.native == global::System.IntPtr.Zero)
				global::java.util.prefs.NodeChangeEvent._m2 = @__env.GetMethodIDNoThrow(global::java.util.prefs.NodeChangeEvent.staticClass, "<init>", "(Ljava/util/prefs/Preferences;Ljava/util/prefs/Preferences;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.NodeChangeEvent.staticClass, global::java.util.prefs.NodeChangeEvent._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static NodeChangeEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.NodeChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/NodeChangeEvent"));
		}
	}
}
