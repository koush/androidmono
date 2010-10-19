namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.MetaKeyKeyListener_))]
	public abstract partial class MetaKeyKeyListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MetaKeyKeyListener()
		{
			InitJNI();
		}
		protected MetaKeyKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown8637;
		public virtual bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener._onKeyDown8637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._onKeyDown8637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp8638;
		public virtual bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener._onKeyUp8638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._onKeyUp8638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState8639;
		public static int getMetaState(java.lang.CharSequence arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState8639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState8640;
		public static int getMetaState(java.lang.CharSequence arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState8640, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState8641;
		public static int getMetaState(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState8641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaState8642;
		public static int getMetaState(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState8642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState8643;
		public virtual long clearMetaKeyState(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState8644;
		public virtual void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearMetaKeyState8645;
		public static void clearMetaKeyState(android.text.Editable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resetMetaState8646;
		public static void resetMetaState(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetMetaState8646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustMetaAfterKeypress8647;
		public static long adjustMetaAfterKeypress(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress8647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustMetaAfterKeypress8648;
		public static void adjustMetaAfterKeypress(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress8648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMetaTracker8649;
		public static bool isMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._isMetaTracker8649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isSelectingMetaTracker8650;
		public static bool isSelectingMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker8650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _resetLockedMeta8651;
		protected static void resetLockedMeta(android.text.Spannable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetLockedMeta8651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resetLockedMeta8652;
		public static long resetLockedMeta(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetLockedMeta8652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _handleKeyDown8653;
		public static long handleKeyDown(long arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._handleKeyDown8653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _handleKeyUp8654;
		public static long handleKeyUp(long arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._handleKeyUp8654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _MetaKeyKeyListener8655;
		public MetaKeyKeyListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener8655);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.MetaKeyKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/MetaKeyKeyListener"));
			global::android.text.method.MetaKeyKeyListener._onKeyDown8637 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MetaKeyKeyListener._onKeyUp8638 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MetaKeyKeyListener._getMetaState8639 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;)I");
			global::android.text.method.MetaKeyKeyListener._getMetaState8640 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;I)I");
			global::android.text.method.MetaKeyKeyListener._getMetaState8641 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(JI)I");
			global::android.text.method.MetaKeyKeyListener._getMetaState8642 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(J)I");
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8643 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(JI)J");
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8644 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V");
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState8645 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/text/Editable;I)V");
			global::android.text.method.MetaKeyKeyListener._resetMetaState8646 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetMetaState", "(Landroid/text/Spannable;)V");
			global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress8647 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(J)J");
			global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress8648 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V");
			global::android.text.method.MetaKeyKeyListener._isMetaTracker8649 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker8650 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			global::android.text.method.MetaKeyKeyListener._resetLockedMeta8651 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(Landroid/text/Spannable;)V");
			global::android.text.method.MetaKeyKeyListener._resetLockedMeta8652 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(J)J");
			global::android.text.method.MetaKeyKeyListener._handleKeyDown8653 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyDown", "(JILandroid/view/KeyEvent;)J");
			global::android.text.method.MetaKeyKeyListener._handleKeyUp8654 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyUp", "(JILandroid/view/KeyEvent;)J");
			global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener8655 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.method.MetaKeyKeyListener))]
	public sealed partial class MetaKeyKeyListener_ : android.text.method.MetaKeyKeyListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MetaKeyKeyListener_()
		{
			InitJNI();
		}
		internal MetaKeyKeyListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.MetaKeyKeyListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/MetaKeyKeyListener"));
		}
	}
}
