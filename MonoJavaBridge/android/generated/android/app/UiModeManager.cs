namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UiModeManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UiModeManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void enableCarMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.UiModeManager.staticClass, "enableCarMode", "(I)V", ref global::android.app.UiModeManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void disableCarMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.UiModeManager.staticClass, "disableCarMode", "(I)V", ref global::android.app.UiModeManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentModeType
		{
			get
			{
				return getCurrentModeType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getCurrentModeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.UiModeManager.staticClass, "getCurrentModeType", "()I", ref global::android.app.UiModeManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setNightMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.app.UiModeManager.staticClass, "setNightMode", "(I)V", ref global::android.app.UiModeManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int NightMode
		{
			get
			{
				return getNightMode();
			}
			set
			{
				setNightMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getNightMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.app.UiModeManager.staticClass, "getNightMode", "()I", ref global::android.app.UiModeManager._m4);
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_CAR_MODE1438;
		public static global::java.lang.String ACTION_ENTER_CAR_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_ENTER_CAR_MODE1438)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_CAR_MODE1439;
		public static global::java.lang.String ACTION_EXIT_CAR_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_EXIT_CAR_MODE1439)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_DESK_MODE1440;
		public static global::java.lang.String ACTION_ENTER_DESK_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_ENTER_DESK_MODE1440)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_DESK_MODE1441;
		public static global::java.lang.String ACTION_EXIT_DESK_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_EXIT_DESK_MODE1441)) as java.lang.String;
			}
			set
			{
			}
		}
		public static int MODE_NIGHT_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int MODE_NIGHT_NO
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_NIGHT_YES
		{
			get
			{
				return 2;
			}
		}
		public static int ENABLE_CAR_MODE_GO_CAR_HOME
		{
			get
			{
				return 1;
			}
		}
		public static int DISABLE_CAR_MODE_GO_HOME
		{
			get
			{
				return 1;
			}
		}
		static UiModeManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.UiModeManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/UiModeManager"));
			global::android.app.UiModeManager._ACTION_ENTER_CAR_MODE1438 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_ENTER_CAR_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_EXIT_CAR_MODE1439 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_EXIT_CAR_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_ENTER_DESK_MODE1440 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_ENTER_DESK_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_EXIT_DESK_MODE1441 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_EXIT_DESK_MODE", "Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
