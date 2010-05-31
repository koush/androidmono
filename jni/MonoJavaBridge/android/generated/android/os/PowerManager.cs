namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PowerManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PowerManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.PowerManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.PowerManager(@__env);
			}
		}
		protected PowerManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class WakeLock : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static WakeLock()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.PowerManager.WakeLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.PowerManager.WakeLock(@__env);
				}
			}
			protected WakeLock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString5828;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.PowerManager.WakeLock._toString5828));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._toString5828));
			}
			internal static global::net.sf.jni4net.jni.MethodId _acquire5829;
			public virtual void acquire() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.PowerManager.WakeLock._acquire5829);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._acquire5829);
			}
			internal static global::net.sf.jni4net.jni.MethodId _acquire5830;
			public virtual void acquire(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.PowerManager.WakeLock._acquire5830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._acquire5830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _release5831;
			public virtual void release() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.PowerManager.WakeLock._release5831);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._release5831);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setReferenceCounted5832;
			public virtual void setReferenceCounted(bool arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.PowerManager.WakeLock._setReferenceCounted5832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._setReferenceCounted5832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isHeld5833;
			public virtual bool isHeld() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.os.PowerManager.WakeLock._isHeld5833);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.os.PowerManager.WakeLock.staticClass, global::android.os.PowerManager.WakeLock._isHeld5833);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.PowerManager.WakeLock.staticClass = @__class;
				global::android.os.PowerManager.WakeLock._toString5828 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "toString", "()Ljava/lang/String;");
				global::android.os.PowerManager.WakeLock._acquire5829 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "acquire", "()V");
				global::android.os.PowerManager.WakeLock._acquire5830 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "acquire", "(J)V");
				global::android.os.PowerManager.WakeLock._release5831 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "release", "()V");
				global::android.os.PowerManager.WakeLock._setReferenceCounted5832 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "setReferenceCounted", "(Z)V");
				global::android.os.PowerManager.WakeLock._isHeld5833 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "isHeld", "()Z");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _newWakeLock5834;
		public virtual global::android.os.PowerManager.WakeLock newWakeLock(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PowerManager.WakeLock>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.PowerManager._newWakeLock5834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PowerManager.WakeLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._newWakeLock5834, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _userActivity5835;
		public virtual void userActivity(long arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.PowerManager._userActivity5835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._userActivity5835, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _goToSleep5836;
		public virtual void goToSleep(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.PowerManager._goToSleep5836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._goToSleep5836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isScreenOn5837;
		public virtual bool isScreenOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.PowerManager._isScreenOn5837);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.PowerManager.staticClass, global::android.os.PowerManager._isScreenOn5837);
		}
		public static int PARTIAL_WAKE_LOCK
		{
			get
			{
				return 1;
			}
		}
		public static int FULL_WAKE_LOCK
		{
			get
			{
				return 26;
			}
		}
		public static int SCREEN_BRIGHT_WAKE_LOCK
		{
			get
			{
				return 10;
			}
		}
		public static int SCREEN_DIM_WAKE_LOCK
		{
			get
			{
				return 6;
			}
		}
		public static int ACQUIRE_CAUSES_WAKEUP
		{
			get
			{
				return 268435456;
			}
		}
		public static int ON_AFTER_RELEASE
		{
			get
			{
				return 536870912;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.PowerManager.staticClass = @__class;
			global::android.os.PowerManager._newWakeLock5834 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "newWakeLock", "(ILjava/lang/String;)Landroid/os/PowerManager$WakeLock;");
			global::android.os.PowerManager._userActivity5835 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "userActivity", "(JZ)V");
			global::android.os.PowerManager._goToSleep5836 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "goToSleep", "(J)V");
			global::android.os.PowerManager._isScreenOn5837 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "isScreenOn", "()Z");
		}
	}
}
