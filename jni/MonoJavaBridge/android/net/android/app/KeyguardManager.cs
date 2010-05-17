namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class KeyguardManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static KeyguardManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.KeyguardManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.KeyguardManager(@__env); 
			} 
		} 
		protected KeyguardManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class KeyguardLock : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static KeyguardLock() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.KeyguardManager.KeyguardLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.KeyguardManager.KeyguardLock(@__env); 
				} 
			} 
			protected KeyguardLock(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _disableKeyguard603; 
			public virtual void disableKeyguard() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.KeyguardManager.KeyguardLock)) 
					@__env.CallVoidMethod(this, _disableKeyguard603); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.KeyguardManager.KeyguardLock.staticClass, _disableKeyguard603); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reenableKeyguard604; 
			public virtual void reenableKeyguard() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.app.KeyguardManager.KeyguardLock)) 
					@__env.CallVoidMethod(this, _reenableKeyguard604); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.app.KeyguardManager.KeyguardLock.staticClass, _reenableKeyguard604); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.KeyguardManager.KeyguardLock.staticClass = @__class; 
				global::android.app.KeyguardManager.KeyguardLock._disableKeyguard603 = @__env.GetMethodID(global::android.app.KeyguardManager.KeyguardLock.staticClass, "disableKeyguard", "()V"); 
				global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard604 = @__env.GetMethodID(global::android.app.KeyguardManager.KeyguardLock.staticClass, "reenableKeyguard", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnKeyguardExitResult 
		{ 
			void onKeyguardExitResult(bool arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newKeyguardLock605; 
		public virtual android.app.KeyguardManager.KeyguardLock newKeyguardLock(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.KeyguardManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.KeyguardManager.KeyguardLock>(@__env, @__env.CallObjectMethodPtr(this, _newKeyguardLock605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.KeyguardManager.KeyguardLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.KeyguardManager.staticClass, _newKeyguardLock605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inKeyguardRestrictedInputMode606; 
		public virtual bool inKeyguardRestrictedInputMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.KeyguardManager)) 
				return @__env.CallBooleanMethod(this, _inKeyguardRestrictedInputMode606); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.KeyguardManager.staticClass, _inKeyguardRestrictedInputMode606); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _exitKeyguardSecurely607; 
		public virtual void exitKeyguardSecurely(android.app.KeyguardManager.OnKeyguardExitResult arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.KeyguardManager)) 
				@__env.CallVoidMethod(this, _exitKeyguardSecurely607, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.KeyguardManager.staticClass, _exitKeyguardSecurely607, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.KeyguardManager.staticClass = @__class; 
			global::android.app.KeyguardManager._newKeyguardLock605 = @__env.GetMethodID(global::android.app.KeyguardManager.staticClass, "newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;"); 
			global::android.app.KeyguardManager._inKeyguardRestrictedInputMode606 = @__env.GetMethodID(global::android.app.KeyguardManager.staticClass, "inKeyguardRestrictedInputMode", "()Z"); 
			global::android.app.KeyguardManager._exitKeyguardSecurely607 = @__env.GetMethodID(global::android.app.KeyguardManager.staticClass, "exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V"); 
		} 
	} 
} 
