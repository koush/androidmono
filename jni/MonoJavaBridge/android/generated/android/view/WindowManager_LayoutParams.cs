namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class WindowManager_LayoutParams : android.view.ViewGroup.LayoutParams, android.os.Parcelable
	{
		internal new static global::java.lang.Class staticClass;
		static WindowManager_LayoutParams()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.WindowManager_LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.WindowManager_LayoutParams(@__env);
			}
		}
		protected WindowManager_LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString9453;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.WindowManager_LayoutParams._toString9453));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._toString9453));
		}
		internal static global::net.sf.jni4net.jni.MethodId _debug9454;
		public virtual global::java.lang.String debug(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.WindowManager_LayoutParams._debug9454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._debug9454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel9455;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.WindowManager_LayoutParams._writeToParcel9455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._writeToParcel9455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents9456;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.WindowManager_LayoutParams._describeContents9456);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._describeContents9456);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTitle9457;
		public virtual void setTitle(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.WindowManager_LayoutParams._setTitle9457, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._setTitle9457, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTitle9458;
		public virtual global::java.lang.CharSequence getTitle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.WindowManager_LayoutParams._getTitle9458));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._getTitle9458));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mayUseInputMethod9459;
		public static bool mayUseInputMethod(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._mayUseInputMethod9459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyFrom9460;
		public virtual int copyFrom(android.view.WindowManager_LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.WindowManager_LayoutParams._copyFrom9460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._copyFrom9460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9461;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9461, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9462;
		public WindowManager_LayoutParams(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9462, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9463;
		public WindowManager_LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9463, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9464;
		public WindowManager_LayoutParams()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9464, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9465;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9465, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9466;
		public WindowManager_LayoutParams(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9466, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _WindowManager_LayoutParams9467;
		public WindowManager_LayoutParams(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.WindowManager_LayoutParams.staticClass, global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9467, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _x9468;
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
		internal static global::net.sf.jni4net.jni.FieldId _y9469;
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
		internal static global::net.sf.jni4net.jni.FieldId _horizontalWeight9470;
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
		internal static global::net.sf.jni4net.jni.FieldId _verticalWeight9471;
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
		internal static global::net.sf.jni4net.jni.FieldId _type9472;
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
		internal static global::net.sf.jni4net.jni.FieldId _memoryType9473;
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
		internal static global::net.sf.jni4net.jni.FieldId _flags9474;
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
		internal static global::net.sf.jni4net.jni.FieldId _softInputMode9475;
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
		internal static global::net.sf.jni4net.jni.FieldId _gravity9476;
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
		internal static global::net.sf.jni4net.jni.FieldId _horizontalMargin9477;
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
		internal static global::net.sf.jni4net.jni.FieldId _verticalMargin9478;
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
		internal static global::net.sf.jni4net.jni.FieldId _format9479;
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
		internal static global::net.sf.jni4net.jni.FieldId _windowAnimations9480;
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
		internal static global::net.sf.jni4net.jni.FieldId _alpha9481;
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
		internal static global::net.sf.jni4net.jni.FieldId _dimAmount9482;
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
		internal static global::net.sf.jni4net.jni.FieldId _screenBrightness9483;
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
		internal static global::net.sf.jni4net.jni.FieldId _buttonBrightness9484;
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
		internal static global::net.sf.jni4net.jni.FieldId _token9485;
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
		internal static global::net.sf.jni4net.jni.FieldId _packageName9486;
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
		internal static global::net.sf.jni4net.jni.FieldId _screenOrientation9487;
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR9488;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.WindowManager_LayoutParams.staticClass = @__class;
			global::android.view.WindowManager_LayoutParams._toString9453 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.WindowManager_LayoutParams._debug9454 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.view.WindowManager_LayoutParams._writeToParcel9455 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.WindowManager_LayoutParams._describeContents9456 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "describeContents", "()I");
			global::android.view.WindowManager_LayoutParams._setTitle9457 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			global::android.view.WindowManager_LayoutParams._getTitle9458 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "getTitle", "()Ljava/lang/CharSequence;");
			global::android.view.WindowManager_LayoutParams._mayUseInputMethod9459 = @__env.GetStaticMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "mayUseInputMethod", "(I)Z");
			global::android.view.WindowManager_LayoutParams._copyFrom9460 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "copyFrom", "(Landroid/view/WindowManager$LayoutParams;)I");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9461 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(III)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9462 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(I)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9463 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(II)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9464 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "()V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9465 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(IIIII)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9466 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(IIIIIII)V");
			global::android.view.WindowManager_LayoutParams._WindowManager_LayoutParams9467 = @__env.GetMethodID(global::android.view.WindowManager_LayoutParams.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
