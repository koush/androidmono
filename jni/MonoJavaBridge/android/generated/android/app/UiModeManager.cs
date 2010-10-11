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
		internal static global::MonoJavaBridge.MethodId _enableCarMode829;
		public virtual void enableCarMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._enableCarMode829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._enableCarMode829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _disableCarMode830;
		public virtual void disableCarMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._disableCarMode830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._disableCarMode830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentModeType831;
		public virtual int getCurrentModeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.UiModeManager._getCurrentModeType831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getCurrentModeType831);
		}
		internal static global::MonoJavaBridge.MethodId _setNightMode832;
		public virtual void setNightMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.app.UiModeManager._setNightMode832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._setNightMode832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNightMode833;
		public virtual int getNightMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.app.UiModeManager._getNightMode833);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getNightMode833);
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_CAR_MODE834;
		public static global::java.lang.String ACTION_ENTER_CAR_MODE
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_CAR_MODE835;
		public static global::java.lang.String ACTION_EXIT_CAR_MODE
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_ENTER_DESK_MODE836;
		public static global::java.lang.String ACTION_ENTER_DESK_MODE
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _ACTION_EXIT_DESK_MODE837;
		public static global::java.lang.String ACTION_EXIT_DESK_MODE
		{
			get
			{
				return default(global::java.lang.String);
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
			global::android.app.UiModeManager._enableCarMode829 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "enableCarMode", "(I)V");
			global::android.app.UiModeManager._disableCarMode830 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "disableCarMode", "(I)V");
			global::android.app.UiModeManager._getCurrentModeType831 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "getCurrentModeType", "()I");
			global::android.app.UiModeManager._setNightMode832 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "setNightMode", "(I)V");
			global::android.app.UiModeManager._getNightMode833 = @__env.GetMethodIDNoThrow(global::android.app.UiModeManager.staticClass, "getNightMode", "()I");
		}
	}
}
