namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class MetaKeyKeyListener : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static MetaKeyKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.MetaKeyKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected MetaKeyKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7798;
		public virtual bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.MetaKeyKeyListener._onKeyDown7798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._onKeyDown7798, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp7799;
		public virtual bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.MetaKeyKeyListener._onKeyUp7799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._onKeyUp7799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7800;
		public static int getMetaState(java.lang.CharSequence arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState7800, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7801;
		public static int getMetaState(java.lang.CharSequence arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState7801, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7802;
		public static int getMetaState(long arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState7802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMetaState7803;
		public static int getMetaState(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._getMetaState7803, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState7804;
		public virtual long clearMetaKeyState(long arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState7805;
		public virtual void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearMetaKeyState7806;
		public static void clearMetaKeyState(android.text.Editable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7806, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetMetaState7807;
		public static void resetMetaState(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetMetaState7807, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _adjustMetaAfterKeypress7808;
		public static long adjustMetaAfterKeypress(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress7808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _adjustMetaAfterKeypress7809;
		public static void adjustMetaAfterKeypress(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress7809, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMetaTracker7810;
		public static bool isMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._isMetaTracker7810, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSelectingMetaTracker7811;
		public static bool isSelectingMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker7811, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetLockedMeta7812;
		protected static void resetLockedMeta(android.text.Spannable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetLockedMeta7812, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _resetLockedMeta7813;
		public static long resetLockedMeta(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._resetLockedMeta7813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleKeyDown7814;
		public static long handleKeyDown(long arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._handleKeyDown7814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleKeyUp7815;
		public static long handleKeyUp(long arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._handleKeyUp7815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _MetaKeyKeyListener7816;
		public MetaKeyKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener7816, this);
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
			global::android.text.method.MetaKeyKeyListener._onKeyDown7798 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MetaKeyKeyListener._onKeyUp7799 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.MetaKeyKeyListener._getMetaState7800 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;)I");
			global::android.text.method.MetaKeyKeyListener._getMetaState7801 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;I)I");
			global::android.text.method.MetaKeyKeyListener._getMetaState7802 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(JI)I");
			global::android.text.method.MetaKeyKeyListener._getMetaState7803 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(J)I");
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7804 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(JI)J");
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7805 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V");
			global::android.text.method.MetaKeyKeyListener._clearMetaKeyState7806 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/text/Editable;I)V");
			global::android.text.method.MetaKeyKeyListener._resetMetaState7807 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "resetMetaState", "(Landroid/text/Spannable;)V");
			global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress7808 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(J)J");
			global::android.text.method.MetaKeyKeyListener._adjustMetaAfterKeypress7809 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V");
			global::android.text.method.MetaKeyKeyListener._isMetaTracker7810 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			global::android.text.method.MetaKeyKeyListener._isSelectingMetaTracker7811 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			global::android.text.method.MetaKeyKeyListener._resetLockedMeta7812 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(Landroid/text/Spannable;)V");
			global::android.text.method.MetaKeyKeyListener._resetLockedMeta7813 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(J)J");
			global::android.text.method.MetaKeyKeyListener._handleKeyDown7814 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyDown", "(JILandroid/view/KeyEvent;)J");
			global::android.text.method.MetaKeyKeyListener._handleKeyUp7815 = @__env.GetStaticMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyUp", "(JILandroid/view/KeyEvent;)J");
			global::android.text.method.MetaKeyKeyListener._MetaKeyKeyListener7816 = @__env.GetMethodID(global::android.text.method.MetaKeyKeyListener.staticClass, "<init>", "()V");
		}
	}
}
