namespace android.app
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class UiModeManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static UiModeManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.UiModeManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.app.UiModeManager(@__env);
			}
		}
		protected UiModeManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _enableCarMode817;
		public virtual void enableCarMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.UiModeManager._enableCarMode817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._enableCarMode817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _disableCarMode818;
		public virtual void disableCarMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.UiModeManager._disableCarMode818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._disableCarMode818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentModeType819;
		public virtual int getCurrentModeType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.UiModeManager._getCurrentModeType819);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getCurrentModeType819);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNightMode820;
		public virtual void setNightMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.UiModeManager._setNightMode820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._setNightMode820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNightMode821;
		public virtual int getNightMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.app.UiModeManager._getNightMode821);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.app.UiModeManager.staticClass, global::android.app.UiModeManager._getNightMode821);
		}
		internal static global::net.sf.jni4net.jni.FieldId _ACTION_ENTER_CAR_MODE822;
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
		internal static global::net.sf.jni4net.jni.FieldId _ACTION_EXIT_CAR_MODE823;
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
		internal static global::net.sf.jni4net.jni.FieldId _ACTION_ENTER_DESK_MODE824;
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
		internal static global::net.sf.jni4net.jni.FieldId _ACTION_EXIT_DESK_MODE825;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.UiModeManager.staticClass = @__class;
			global::android.app.UiModeManager._enableCarMode817 = @__env.GetMethodID(global::android.app.UiModeManager.staticClass, "enableCarMode", "(I)V");
			global::android.app.UiModeManager._disableCarMode818 = @__env.GetMethodID(global::android.app.UiModeManager.staticClass, "disableCarMode", "(I)V");
			global::android.app.UiModeManager._getCurrentModeType819 = @__env.GetMethodID(global::android.app.UiModeManager.staticClass, "getCurrentModeType", "()I");
			global::android.app.UiModeManager._setNightMode820 = @__env.GetMethodID(global::android.app.UiModeManager.staticClass, "setNightMode", "(I)V");
			global::android.app.UiModeManager._getNightMode821 = @__env.GetMethodID(global::android.app.UiModeManager.staticClass, "getNightMode", "()I");
		}
	}
}
