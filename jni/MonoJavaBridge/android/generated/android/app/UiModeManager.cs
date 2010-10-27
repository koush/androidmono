namespace android.app
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UiModeManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static UiModeManager()
		{
			InitJNI();
		}
		protected UiModeManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _enableCarMode2182;
		public virtual void enableCarMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._enableCarMode2182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._enableCarMode2182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disableCarMode2183;
		public virtual void disableCarMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._disableCarMode2183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._disableCarMode2183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int CurrentModeType
		{
			get
			{
				return getCurrentModeType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentModeType2184;
		public virtual int getCurrentModeType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.UiModeManager._getCurrentModeType2184);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getCurrentModeType2184);
		}
		internal static global::MonoJavaBridge.MethodId _setNightMode2185;
		public virtual void setNightMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._setNightMode2185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._setNightMode2185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNightMode2186;
		public virtual int getNightMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.UiModeManager._getNightMode2186);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getNightMode2186);
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_CAR_MODE2187;
		public static global::java.lang.String ACTION_ENTER_CAR_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_ENTER_CAR_MODE2187)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_CAR_MODE2188;
		public static global::java.lang.String ACTION_EXIT_CAR_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_EXIT_CAR_MODE2188)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_DESK_MODE2189;
		public static global::java.lang.String ACTION_ENTER_DESK_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_ENTER_DESK_MODE2189)) as java.lang.String;
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_DESK_MODE2190;
		public static global::java.lang.String ACTION_EXIT_DESK_MODE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.app.UiModeManager.staticClass, _ACTION_EXIT_DESK_MODE2190)) as java.lang.String;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.app.UiModeManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/app/UiModeManager"));
			global::android.app.UiModeManager._enableCarMode2182 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "enableCarMode", "(I)V");
			global::android.app.UiModeManager._disableCarMode2183 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "disableCarMode", "(I)V");
			global::android.app.UiModeManager._getCurrentModeType2184 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "getCurrentModeType", "()I");
			global::android.app.UiModeManager._setNightMode2185 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "setNightMode", "(I)V");
			global::android.app.UiModeManager._getNightMode2186 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "getNightMode", "()I");
			global::android.app.UiModeManager._ACTION_ENTER_CAR_MODE2187 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_ENTER_CAR_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_EXIT_CAR_MODE2188 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_EXIT_CAR_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_ENTER_DESK_MODE2189 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_ENTER_DESK_MODE", "Ljava/lang/String;");
			global::android.app.UiModeManager._ACTION_EXIT_DESK_MODE2190 = @__env.GetStaticFieldIDNoThrow(global::android.app.UiModeManager.staticClass, "ACTION_EXIT_DESK_MODE", "Ljava/lang/String;");
		}
	}
}
