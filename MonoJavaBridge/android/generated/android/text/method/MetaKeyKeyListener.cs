namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.MetaKeyKeyListener_))]
	public abstract partial class MetaKeyKeyListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MetaKeyKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown13310;
		public virtual bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.MetaKeyKeyListener._onKeyDown13310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp13311;
		public virtual bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.MetaKeyKeyListener._onKeyUp13311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState13312;
		public static int getMetaState(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._getMetaState13312.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._getMetaState13312 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState13312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getMetaState(string arg0)
		{
			return getMetaState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState13313;
		public static int getMetaState(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._getMetaState13313.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._getMetaState13313 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState13313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int getMetaState(string arg0, int arg1)
		{
			return getMetaState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState13314;
		public static int getMetaState(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._getMetaState13314.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._getMetaState13314 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(JI)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState13314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState13315;
		public static int getMetaState(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._getMetaState13315.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._getMetaState13315 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(J)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState13315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState13316;
		public virtual long clearMetaKeyState(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(JI)J", ref global::android.text.method.MetaKeyKeyListener._clearMetaKeyState13316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState13317;
		public virtual void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", ref global::android.text.method.MetaKeyKeyListener._clearMetaKeyState13317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState13318;
		public static void clearMetaKeyState(android.text.Editable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._clearMetaKeyState13318.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._clearMetaKeyState13318 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/text/Editable;I)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState13318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resetMetaState13319;
		public static void resetMetaState(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._resetMetaState13319.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._resetMetaState13319 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetMetaState", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetMetaState13319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustMetaAfterKeypress13320;
		public static long adjustMetaAfterKeypress(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress13320.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress13320 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(J)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress13320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustMetaAfterKeypress13321;
		public static void adjustMetaAfterKeypress(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress13321.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress13321 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress13321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMetaTracker13322;
		public static bool isMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._isMetaTracker13322.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._isMetaTracker13322 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._isMetaTracker13322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool isMetaTracker(string arg0, java.lang.Object arg1)
		{
			return isMetaTracker((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _isSelectingMetaTracker13323;
		public static bool isSelectingMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker13323.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker13323 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker13323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool isSelectingMetaTracker(string arg0, java.lang.Object arg1)
		{
			return isSelectingMetaTracker((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		internal static global::MonoJavaBridge.MethodId _resetLockedMeta13324;
		protected static void resetLockedMeta(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._resetLockedMeta13324.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._resetLockedMeta13324 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetLockedMeta13324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetLockedMeta13325;
		public static long resetLockedMeta(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._resetLockedMeta13325.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._resetLockedMeta13325 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(J)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetLockedMeta13325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleKeyDown13326;
		public static long handleKeyDown(long arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._handleKeyDown13326.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._handleKeyDown13326 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyDown", "(JILandroid/view/KeyEvent;)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._handleKeyDown13326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _handleKeyUp13327;
		public static long handleKeyUp(long arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._handleKeyUp13327.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._handleKeyUp13327 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyUp", "(JILandroid/view/KeyEvent;)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._handleKeyUp13327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _MetaKeyKeyListener13328;
		public MetaKeyKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener13328.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener13328 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener13328);
			Init(@__env, handle);
		}
		public static int META_SHIFT_ON
		{
			get
			{
				return 1;
			}
		}
		public static int META_ALT_ON
		{
			get
			{
				return 2;
			}
		}
		public static int META_SYM_ON
		{
			get
			{
				return 4;
			}
		}
		public static int META_CAP_LOCKED
		{
			get
			{
				return 256;
			}
		}
		public static int META_ALT_LOCKED
		{
			get
			{
				return 512;
			}
		}
		public static int META_SYM_LOCKED
		{
			get
			{
				return 1024;
			}
		}
		static MetaKeyKeyListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.MetaKeyKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/MetaKeyKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.MetaKeyKeyListener))]
	internal sealed partial class MetaKeyKeyListener_ : android.text.method.MetaKeyKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MetaKeyKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static MetaKeyKeyListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.MetaKeyKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/MetaKeyKeyListener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
