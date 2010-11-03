namespace java.util.prefs
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PreferenceChangeEvent : java.util.EventObject
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PreferenceChangeEvent(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Key
		{
			get
			{
				return getKey();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.PreferenceChangeEvent.staticClass, "getKey", "()Ljava/lang/String;", ref global::java.util.prefs.PreferenceChangeEvent._m0) as java.lang.String;
		}
		public new global::java.lang.String NewValue
		{
			get
			{
				return getNewValue();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getNewValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.prefs.PreferenceChangeEvent.staticClass, "getNewValue", "()Ljava/lang/String;", ref global::java.util.prefs.PreferenceChangeEvent._m1) as java.lang.String;
		}
		public new global::java.util.prefs.Preferences Node
		{
			get
			{
				return getNode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.util.prefs.Preferences getNode()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.PreferenceChangeEvent.staticClass, "getNode", "()Ljava/util/prefs/Preferences;", ref global::java.util.prefs.PreferenceChangeEvent._m2) as java.util.prefs.Preferences;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PreferenceChangeEvent(java.util.prefs.Preferences arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.prefs.PreferenceChangeEvent._m3.native == global::System.IntPtr.Zero)
				global::java.util.prefs.PreferenceChangeEvent._m3 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeEvent.staticClass, "<init>", "(Ljava/util/prefs/Preferences;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.PreferenceChangeEvent.staticClass, global::java.util.prefs.PreferenceChangeEvent._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PreferenceChangeEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.PreferenceChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/PreferenceChangeEvent"));
		}
	}
}
