namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PowerManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PowerManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.PowerManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.PowerManager.WakeLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString5554; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.PowerManager.WakeLock)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString5554)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.PowerManager.WakeLock.staticClass, _toString5554)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _acquire5555; 
			public virtual void acquire() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.PowerManager.WakeLock)) 
					@__env.CallVoidMethod(this, _acquire5555); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.os.PowerManager.WakeLock.staticClass, _acquire5555); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _acquire5556; 
			public virtual void acquire(long arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.PowerManager.WakeLock)) 
					@__env.CallVoidMethod(this, _acquire5556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.os.PowerManager.WakeLock.staticClass, _acquire5556, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _release5557; 
			public virtual void release() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.PowerManager.WakeLock)) 
					@__env.CallVoidMethod(this, _release5557); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.os.PowerManager.WakeLock.staticClass, _release5557); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setReferenceCounted5558; 
			public virtual void setReferenceCounted(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.PowerManager.WakeLock)) 
					@__env.CallVoidMethod(this, _setReferenceCounted5558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.os.PowerManager.WakeLock.staticClass, _setReferenceCounted5558, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isHeld5559; 
			public virtual bool isHeld() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.os.PowerManager.WakeLock)) 
					return @__env.CallBooleanMethod(this, _isHeld5559); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.os.PowerManager.WakeLock.staticClass, _isHeld5559); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.PowerManager.WakeLock.staticClass = @__class; 
				global::android.os.PowerManager.WakeLock._toString5554 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.os.PowerManager.WakeLock._acquire5555 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "acquire", "()V"); 
				global::android.os.PowerManager.WakeLock._acquire5556 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "acquire", "(J)V"); 
				global::android.os.PowerManager.WakeLock._release5557 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "release", "()V"); 
				global::android.os.PowerManager.WakeLock._setReferenceCounted5558 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "setReferenceCounted", "(Z)V"); 
				global::android.os.PowerManager.WakeLock._isHeld5559 = @__env.GetMethodID(global::android.os.PowerManager.WakeLock.staticClass, "isHeld", "()Z"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newWakeLock5560; 
		public virtual android.os.PowerManager.WakeLock newWakeLock(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PowerManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PowerManager.WakeLock>(@__env, @__env.CallObjectMethodPtr(this, _newWakeLock5560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.PowerManager.WakeLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.PowerManager.staticClass, _newWakeLock5560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _userActivity5561; 
		public virtual void userActivity(long arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PowerManager)) 
				@__env.CallVoidMethod(this, _userActivity5561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.PowerManager.staticClass, _userActivity5561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _goToSleep5562; 
		public virtual void goToSleep(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PowerManager)) 
				@__env.CallVoidMethod(this, _goToSleep5562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.PowerManager.staticClass, _goToSleep5562, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isScreenOn5563; 
		public virtual bool isScreenOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PowerManager)) 
				return @__env.CallBooleanMethod(this, _isScreenOn5563); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.PowerManager.staticClass, _isScreenOn5563); 
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
			global::android.os.PowerManager._newWakeLock5560 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "newWakeLock", "(ILjava/lang/String;)Landroid/os/PowerManager$WakeLock;"); 
			global::android.os.PowerManager._userActivity5561 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "userActivity", "(JZ)V"); 
			global::android.os.PowerManager._goToSleep5562 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "goToSleep", "(J)V"); 
			global::android.os.PowerManager._isScreenOn5563 = @__env.GetMethodID(global::android.os.PowerManager.staticClass, "isScreenOn", "()Z"); 
		} 
	} 
} 
