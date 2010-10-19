namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WindowManager_LayoutParams : android.view.ViewGroup.LayoutParams, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WindowManager_LayoutParams()
		{
			InitJNI();
		}
		protected WindowManager_LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString10346;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._toString10346)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._toString10346)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _debug10347;
		public virtual global::java.lang.String debug(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._debug10347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._debug10347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10348;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._writeToParcel10348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._writeToParcel10348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10349;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._describeContents10349);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._describeContents10349);
		}
		internal static global::MonoJavaBridge.MethodId _setTitle10350;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._setTitle10350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._setTitle10350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		public new string Title
		{
			get
			{
				return getTitle().toString();
			}
			set
			{
				setTitle((global::java.lang.CharSequence)(global::java.lang.String)value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTitle10351;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._getTitle10351)) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._getTitle10351)) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _mayUseInputMethod10352;
		public static bool mayUseInputMethod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._mayUseInputMethod10352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyFrom10353;
		public virtual int copyFrom(android.view.WindowManager_LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams._copyFrom10353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._copyFrom10353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10354;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10355;
		public WindowManager_LayoutParams(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10356;
		public WindowManager_LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10357;
		public WindowManager_LayoutParams()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10357);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10358;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10359;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _WindowManager_LayoutParams10360;
		public WindowManager_LayoutParams(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x10361;
		public int x
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _y10362;
		public int y
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _horizontalWeight10363;
		public float horizontalWeight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _verticalWeight10364;
		public float verticalWeight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _type10365;
		public int type
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int FIRST_APPLICATION_WINDOW
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_BASE_APPLICATION
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_APPLICATION
		{
			get
			{
				return 2;
			}
		}
		public static int TYPE_APPLICATION_STARTING
		{
			get
			{
				return 3;
			}
		}
		public static int LAST_APPLICATION_WINDOW
		{
			get
			{
				return 99;
			}
		}
		public static int FIRST_SUB_WINDOW
		{
			get
			{
				return 1000;
			}
		}
		public static int TYPE_APPLICATION_PANEL
		{
			get
			{
				return 1000;
			}
		}
		public static int TYPE_APPLICATION_MEDIA
		{
			get
			{
				return 1001;
			}
		}
		public static int TYPE_APPLICATION_SUB_PANEL
		{
			get
			{
				return 1002;
			}
		}
		public static int TYPE_APPLICATION_ATTACHED_DIALOG
		{
			get
			{
				return 1003;
			}
		}
		public static int LAST_SUB_WINDOW
		{
			get
			{
				return 1999;
			}
		}
		public static int FIRST_SYSTEM_WINDOW
		{
			get
			{
				return 2000;
			}
		}
		public static int TYPE_STATUS_BAR
		{
			get
			{
				return 2000;
			}
		}
		public static int TYPE_SEARCH_BAR
		{
			get
			{
				return 2001;
			}
		}
		public static int TYPE_PHONE
		{
			get
			{
				return 2002;
			}
		}
		public static int TYPE_SYSTEM_ALERT
		{
			get
			{
				return 2003;
			}
		}
		public static int TYPE_KEYGUARD
		{
			get
			{
				return 2004;
			}
		}
		public static int TYPE_TOAST
		{
			get
			{
				return 2005;
			}
		}
		public static int TYPE_SYSTEM_OVERLAY
		{
			get
			{
				return 2006;
			}
		}
		public static int TYPE_PRIORITY_PHONE
		{
			get
			{
				return 2007;
			}
		}
		public static int TYPE_SYSTEM_DIALOG
		{
			get
			{
				return 2008;
			}
		}
		public static int TYPE_KEYGUARD_DIALOG
		{
			get
			{
				return 2009;
			}
		}
		public static int TYPE_SYSTEM_ERROR
		{
			get
			{
				return 2010;
			}
		}
		public static int TYPE_INPUT_METHOD
		{
			get
			{
				return 2011;
			}
		}
		public static int TYPE_INPUT_METHOD_DIALOG
		{
			get
			{
				return 2012;
			}
		}
		public static int TYPE_WALLPAPER
		{
			get
			{
				return 2013;
			}
		}
		public static int TYPE_STATUS_BAR_PANEL
		{
			get
			{
				return 2014;
			}
		}
		public static int LAST_SYSTEM_WINDOW
		{
			get
			{
				return 2999;
			}
		}
		internal static global::MonoJavaBridge.FieldId _memoryType10366;
		public int memoryType
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int MEMORY_TYPE_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int MEMORY_TYPE_HARDWARE
		{
			get
			{
				return 1;
			}
		}
		public static int MEMORY_TYPE_GPU
		{
			get
			{
				return 2;
			}
		}
		public static int MEMORY_TYPE_PUSH_BUFFERS
		{
			get
			{
				return 3;
			}
		}
		internal static global::MonoJavaBridge.FieldId _flags10367;
		public int flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		public static int FLAG_ALLOW_LOCK_WHILE_SCREEN_ON
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_DIM_BEHIND
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_BLUR_BEHIND
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_NOT_FOCUSABLE
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_NOT_TOUCHABLE
		{
			get
			{
				return 16;
			}
		}
		public static int FLAG_NOT_TOUCH_MODAL
		{
			get
			{
				return 32;
			}
		}
		public static int FLAG_TOUCHABLE_WHEN_WAKING
		{
			get
			{
				return 64;
			}
		}
		public static int FLAG_KEEP_SCREEN_ON
		{
			get
			{
				return 128;
			}
		}
		public static int FLAG_LAYOUT_IN_SCREEN
		{
			get
			{
				return 256;
			}
		}
		public static int FLAG_LAYOUT_NO_LIMITS
		{
			get
			{
				return 512;
			}
		}
		public static int FLAG_FULLSCREEN
		{
			get
			{
				return 1024;
			}
		}
		public static int FLAG_FORCE_NOT_FULLSCREEN
		{
			get
			{
				return 2048;
			}
		}
		public static int FLAG_DITHER
		{
			get
			{
				return 4096;
			}
		}
		public static int FLAG_SECURE
		{
			get
			{
				return 8192;
			}
		}
		public static int FLAG_SCALED
		{
			get
			{
				return 16384;
			}
		}
		public static int FLAG_IGNORE_CHEEK_PRESSES
		{
			get
			{
				return 32768;
			}
		}
		public static int FLAG_LAYOUT_INSET_DECOR
		{
			get
			{
				return 65536;
			}
		}
		public static int FLAG_ALT_FOCUSABLE_IM
		{
			get
			{
				return 131072;
			}
		}
		public static int FLAG_WATCH_OUTSIDE_TOUCH
		{
			get
			{
				return 262144;
			}
		}
		public static int FLAG_SHOW_WHEN_LOCKED
		{
			get
			{
				return 524288;
			}
		}
		public static int FLAG_SHOW_WALLPAPER
		{
			get
			{
				return 1048576;
			}
		}
		public static int FLAG_TURN_SCREEN_ON
		{
			get
			{
				return 2097152;
			}
		}
		public static int FLAG_DISMISS_KEYGUARD
		{
			get
			{
				return 4194304;
			}
		}
		public static int SOFT_INPUT_MASK_STATE
		{
			get
			{
				return 15;
			}
		}
		public static int SOFT_INPUT_STATE_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int SOFT_INPUT_STATE_UNCHANGED
		{
			get
			{
				return 1;
			}
		}
		public static int SOFT_INPUT_STATE_HIDDEN
		{
			get
			{
				return 2;
			}
		}
		public static int SOFT_INPUT_STATE_ALWAYS_HIDDEN
		{
			get
			{
				return 3;
			}
		}
		public static int SOFT_INPUT_STATE_VISIBLE
		{
			get
			{
				return 4;
			}
		}
		public static int SOFT_INPUT_STATE_ALWAYS_VISIBLE
		{
			get
			{
				return 5;
			}
		}
		public static int SOFT_INPUT_MASK_ADJUST
		{
			get
			{
				return 240;
			}
		}
		public static int SOFT_INPUT_ADJUST_UNSPECIFIED
		{
			get
			{
				return 0;
			}
		}
		public static int SOFT_INPUT_ADJUST_RESIZE
		{
			get
			{
				return 16;
			}
		}
		public static int SOFT_INPUT_ADJUST_PAN
		{
			get
			{
				return 32;
			}
		}
		public static int SOFT_INPUT_IS_FORWARD_NAVIGATION
		{
			get
			{
				return 256;
			}
		}
		public static float BRIGHTNESS_OVERRIDE_NONE
		{
			get
			{
				return -1.0f;
			}
		}
		public static float BRIGHTNESS_OVERRIDE_OFF
		{
			get
			{
				return 0.0f;
			}
		}
		public static float BRIGHTNESS_OVERRIDE_FULL
		{
			get
			{
				return 1.0f;
			}
		}
		internal static global::MonoJavaBridge.FieldId _softInputMode10368;
		public int softInputMode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _gravity10369;
		public int gravity
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _horizontalMargin10370;
		public float horizontalMargin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _verticalMargin10371;
		public float verticalMargin
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _format10372;
		public int format
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _windowAnimations10373;
		public int windowAnimations
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _alpha10374;
		public float alpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _dimAmount10375;
		public float dimAmount
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _screenBrightness10376;
		public float screenBrightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _buttonBrightness10377;
		public float buttonBrightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _token10378;
		public global::android.os.IBinder token
		{
			get
			{
				return default(global::android.os.IBinder);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _packageName10379;
		public global::java.lang.String packageName
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _screenOrientation10380;
		public int screenOrientation
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10381;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		public static int LAYOUT_CHANGED
		{
			get
			{
				return 1;
			}
		}
		public static int TYPE_CHANGED
		{
			get
			{
				return 2;
			}
		}
		public static int FLAGS_CHANGED
		{
			get
			{
				return 4;
			}
		}
		public static int FORMAT_CHANGED
		{
			get
			{
				return 8;
			}
		}
		public static int ANIMATION_CHANGED
		{
			get
			{
				return 16;
			}
		}
		public static int DIM_AMOUNT_CHANGED
		{
			get
			{
				return 32;
			}
		}
		public static int TITLE_CHANGED
		{
			get
			{
				return 64;
			}
		}
		public static int ALPHA_CHANGED
		{
			get
			{
				return 128;
			}
		}
		public static int MEMORY_TYPE_CHANGED
		{
			get
			{
				return 256;
			}
		}
		public static int SOFT_INPUT_MODE_CHANGED
		{
			get
			{
				return 512;
			}
		}
		public static int SCREEN_ORIENTATION_CHANGED
		{
			get
			{
				return 1024;
			}
		}
		public static int SCREEN_BRIGHTNESS_CHANGED
		{
			get
			{
				return 2048;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.WindowManager_LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/WindowManager_LayoutParams"));
			global::android.view.WindowManager_LayoutParams._toString10346 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.WindowManager_LayoutParams._debug10347 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.view.WindowManager_LayoutParams._writeToParcel10348 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.WindowManager_LayoutParams._describeContents10349 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "describeContents", "()I");
			global::android.view.WindowManager_LayoutParams._setTitle10350 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.WindowManager_LayoutParams._getTitle10351 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.view.WindowManager_LayoutParams._mayUseInputMethod10352 = @__env.GetStaticMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "mayUseInputMethod", "(I)Z");
			global::android.view.WindowManager_LayoutParams._copyFrom10353 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "copyFrom", "(Landroid/view/WindowManager$LayoutParams;)I");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10354 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(III)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10355 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(I)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10356 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(II)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10357 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "()V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10358 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(IIIII)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10359 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(IIIIIII)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams10360 = @__env.GetMethodIDNoThrow(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
