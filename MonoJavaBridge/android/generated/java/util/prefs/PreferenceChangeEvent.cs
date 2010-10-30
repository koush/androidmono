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
		internal static global::MonoJavaBridge.MethodId _getKey28182;
		public virtual global::java.lang.String getKey()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.PreferenceChangeEvent.staticClass, global::java.util.prefs.PreferenceChangeEvent._getKey28182)) as java.lang.String;
		}
		public new global::java.lang.String NewValue
		{
			get
			{
				return getNewValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNewValue28183;
		public virtual global::java.lang.String getNewValue()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.PreferenceChangeEvent.staticClass, global::java.util.prefs.PreferenceChangeEvent._getNewValue28183)) as java.lang.String;
		}
		public new global::java.util.prefs.Preferences Node
		{
			get
			{
				return getNode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNode28184;
		public virtual global::java.util.prefs.Preferences getNode()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.prefs.PreferenceChangeEvent.staticClass, global::java.util.prefs.PreferenceChangeEvent._getNode28184)) as java.util.prefs.Preferences;
		}
		internal static global::MonoJavaBridge.MethodId _PreferenceChangeEvent28185;
		public PreferenceChangeEvent(java.util.prefs.Preferences arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.prefs.PreferenceChangeEvent.staticClass, global::java.util.prefs.PreferenceChangeEvent._PreferenceChangeEvent28185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PreferenceChangeEvent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.prefs.PreferenceChangeEvent.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/prefs/PreferenceChangeEvent"));
			global::java.util.prefs.PreferenceChangeEvent._getKey28182 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeEvent.staticClass, "getKey", "()Ljava/lang/String;");
			global::java.util.prefs.PreferenceChangeEvent._getNewValue28183 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeEvent.staticClass, "getNewValue", "()Ljava/lang/String;");
			global::java.util.prefs.PreferenceChangeEvent._getNode28184 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeEvent.staticClass, "getNode", "()Ljava/util/prefs/Preferences;");
			global::java.util.prefs.PreferenceChangeEvent._PreferenceChangeEvent28185 = @__env.GetMethodIDNoThrow(global::java.util.prefs.PreferenceChangeEvent.staticClass, "<init>", "(Ljava/util/prefs/Preferences;Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
