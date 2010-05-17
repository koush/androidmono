namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class MetaKeyKeyListener : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MetaKeyKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.MetaKeyKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected MetaKeyKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6812; 
		public virtual bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MetaKeyKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.MetaKeyKeyListener.staticClass, _onKeyDown6812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp6813; 
		public virtual bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MetaKeyKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyUp6813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.MetaKeyKeyListener.staticClass, _onKeyUp6813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState6814; 
		public static int getMetaState(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, _getMetaState6814, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState6815; 
		public static int getMetaState(java.lang.CharSequence arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, _getMetaState6815, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState6816; 
		public static int getMetaState(long arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, _getMetaState6816, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState6817; 
		public static int getMetaState(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, _getMetaState6817, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState6818; 
		public virtual long clearMetaKeyState(long arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MetaKeyKeyListener)) 
				return @__env.CallLongMethod(this, _clearMetaKeyState6818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.text.method.MetaKeyKeyListener.staticClass, _clearMetaKeyState6818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState6819; 
		public virtual void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.MetaKeyKeyListener)) 
				@__env.CallVoidMethod(this, _clearMetaKeyState6819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.MetaKeyKeyListener.staticClass, _clearMetaKeyState6819, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState6820; 
		public static void clearMetaKeyState(android.text.Editable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, _clearMetaKeyState6820, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetMetaState6821; 
		public static void resetMetaState(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, _resetMetaState6821, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustMetaAfterKeypress6822; 
		public static long adjustMetaAfterKeypress(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, _adjustMetaAfterKeypress6822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustMetaAfterKeypress6823; 
		public static void adjustMetaAfterKeypress(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, _adjustMetaAfterKeypress6823, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMetaTracker6824; 
		public static bool isMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, _isMetaTracker6824, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSelectingMetaTracker6825; 
		public static bool isSelectingMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, _isSelectingMetaTracker6825, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetLockedMeta6826; 
		protected static void resetLockedMeta(android.text.Spannable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, _resetLockedMeta6826, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resetLockedMeta6827; 
		public static long resetLockedMeta(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, _resetLockedMeta6827, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleKeyDown6828; 
		public static long handleKeyDown(long arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, _handleKeyDown6828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleKeyUp6829; 
		public static long handleKeyUp(long arg0, int arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, _handleKeyUp6829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MetaKeyKeyListener6830; 
		public MetaKeyKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.MetaKeyKeyListener.staticClass, _MetaKeyKeyListener6830, this); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.MetaKeyKeyListener.staticClass = @__class; 
			global::android.text.method.MetaKeyKeyListener._onKeyDown6812 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.MetaKeyKeyListener._onKeyUp6813 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.MetaKeyKeyListener._getMetaState6814 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;)I"); 
			global::android.text.method.MetaKeyKeyListener._getMetaState6815 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;I)I"); 
			global::android.text.method.MetaKeyKeyListener._getMetaState6816 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(JI)I"); 
			global::android.text.method.MetaKeyKeyListener._getMetaState6817 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(J)I"); 
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState6818 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(JI)J"); 
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState6819 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V"); 
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState6820 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/text/Editable;I)V"); 
			global::android.text.method.MetaKeyKeyListener._resetMetaState6821 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "resetMetaState", "(Landroid/text/Spannable;)V"); 
			global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress6822 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(J)J"); 
			global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress6823 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V"); 
			global::android.text.method.MetaKeyKeyListener._isMetaTracker6824 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z"); 
			global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker6825 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z"); 
			global::android.text.method.MetaKeyKeyListener._resetLockedMeta6826 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(Landroid/text/Spannable;)V"); 
			global::android.text.method.MetaKeyKeyListener._resetLockedMeta6827 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(J)J"); 
			global::android.text.method.MetaKeyKeyListener._handleKeyDown6828 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyDown", "(JILandroid/view/KeyEvent;)J"); 
			global::android.text.method.MetaKeyKeyListener._handleKeyUp6829 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyUp", "(JILandroid/view/KeyEvent;)J"); 
			global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener6830 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
