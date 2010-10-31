namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.method.MetaKeyKeyListener_))]
	public abstract partial class MetaKeyKeyListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MetaKeyKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.MetaKeyKeyListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z", ref global::android.text.method.MetaKeyKeyListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static int getMetaState(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m2.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int getMetaState(string arg0)
		{
			return getMetaState((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static int getMetaState(java.lang.CharSequence arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m3.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m3 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(Ljava/lang/CharSequence;I)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static int getMetaState(string arg0, int arg1)
		{
			return getMetaState((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int getMetaState(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m4.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m4 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(JI)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static int getMetaState(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m5.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m5 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "getMetaState", "(J)I");
			return @__env.CallStaticIntMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual long clearMetaKeyState(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(JI)J", ref global::android.text.method.MetaKeyKeyListener._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void clearMetaKeyState(android.view.View arg0, android.text.Editable arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/view/View;Landroid/text/Editable;I)V", ref global::android.text.method.MetaKeyKeyListener._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static void clearMetaKeyState(android.text.Editable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m8.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m8 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "clearMetaKeyState", "(Landroid/text/Editable;I)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void resetMetaState(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m9.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m9 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetMetaState", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static long adjustMetaAfterKeypress(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m10.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m10 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(J)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void adjustMetaAfterKeypress(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m11.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m11 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "adjustMetaAfterKeypress", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool isMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m12.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m12 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "isMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool isMetaTracker(string arg0, java.lang.Object arg1)
		{
			return isMetaTracker((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static bool isSelectingMetaTracker(java.lang.CharSequence arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m13.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m13 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "isSelectingMetaTracker", "(Ljava/lang/CharSequence;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public static bool isSelectingMetaTracker(string arg0, java.lang.Object arg1)
		{
			return isSelectingMetaTracker((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected static void resetLockedMeta(android.text.Spannable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m14.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m14 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(Landroid/text/Spannable;)V");
			@__env.CallStaticVoidMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static long resetLockedMeta(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m15.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m15 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "resetLockedMeta", "(J)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static long handleKeyDown(long arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m16.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m16 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyDown", "(JILandroid/view/KeyEvent;)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static long handleKeyUp(long arg0, int arg1, android.view.KeyEvent arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m17.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m17 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "handleKeyUp", "(JILandroid/view/KeyEvent;)J");
			return @__env.CallStaticLongMethod(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public MetaKeyKeyListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.method.MetaKeyKeyListener._m18.native == global::System.IntPtr.Zero)
				global::android.text.method.MetaKeyKeyListener._m18 = @__env.GetMethodIDNoThrow(global::android.text.method.MetaKeyKeyListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.MetaKeyKeyListener.staticClass, global::android.text.method.MetaKeyKeyListener._m18);
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
	}
}
