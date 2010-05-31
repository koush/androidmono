namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class KeyguardManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static KeyguardManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.KeyguardManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.KeyguardManager.KeyguardLock), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _disableKeyguard611; 
			public virtual void disableKeyguard() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock._disableKeyguard611); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock.staticClass, global::android.app.KeyguardManager.KeyguardLock._disableKeyguard611); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _reenableKeyguard612; 
			public virtual void reenableKeyguard() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard612); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.app.KeyguardManager.KeyguardLock.staticClass, global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard612); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.KeyguardManager.KeyguardLock.staticClass = @__class; 
				global::android.app.KeyguardManager.KeyguardLock._disableKeyguard611 = @__env.GetMethodID(global::android.app.KeyguardManager.KeyguardLock.staticClass, "disableKeyguard", "()V"); 
				global::android.app.KeyguardManager.KeyguardLock._reenableKeyguard612 = @__env.GetMethodID(global::android.app.KeyguardManager.KeyguardLock.staticClass, "reenableKeyguard", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnKeyguardExitResult 
		{ 
			void onKeyguardExitResult(bool arg0); 
		} 

		public partial class OnKeyguardExitResult_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnKeyguardExitResult.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnKeyguardExitResult : java.lang.Object, OnKeyguardExitResult
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnKeyguardExitResult() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.KeyguardManager.__OnKeyguardExitResult), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.app.KeyguardManager.__OnKeyguardExitResult(@__env); 
				} 
			} 
			internal __OnKeyguardExitResult(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onKeyguardExitResult613; 
			 void android.app.KeyguardManager.OnKeyguardExitResult.onKeyguardExitResult(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.app.KeyguardManager.__OnKeyguardExitResult._onKeyguardExitResult613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.app.KeyguardManager.__OnKeyguardExitResult.staticClass, global::android.app.KeyguardManager.__OnKeyguardExitResult._onKeyguardExitResult613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.app.KeyguardManager.__OnKeyguardExitResult.staticClass = @__class; 
				global::android.app.KeyguardManager.__OnKeyguardExitResult._onKeyguardExitResult613 = @__env.GetMethodID(global::android.app.KeyguardManager.__OnKeyguardExitResult.staticClass, "android.app.KeyguardManager.OnKeyguardExitResult.onKeyguardExitResult", "(Z)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newKeyguardLock614; 
		public virtual global::android.app.KeyguardManager.KeyguardLock newKeyguardLock(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.KeyguardManager.KeyguardLock>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.KeyguardManager._newKeyguardLock614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.KeyguardManager.KeyguardLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._newKeyguardLock614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inKeyguardRestrictedInputMode615; 
		public virtual bool inKeyguardRestrictedInputMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.KeyguardManager._inKeyguardRestrictedInputMode615); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._inKeyguardRestrictedInputMode615); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _exitKeyguardSecurely616; 
		public virtual void exitKeyguardSecurely(android.app.KeyguardManager.OnKeyguardExitResult arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.KeyguardManager._exitKeyguardSecurely616, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.KeyguardManager.staticClass, global::android.app.KeyguardManager._exitKeyguardSecurely616, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.KeyguardManager.staticClass = @__class; 
			global::android.app.KeyguardManager._newKeyguardLock614 = @__env.GetMethodID(global::android.app.KeyguardManager.staticClass, "newKeyguardLock", "(Ljava/lang/String;)Landroid/app/KeyguardManager$KeyguardLock;"); 
			global::android.app.KeyguardManager._inKeyguardRestrictedInputMode615 = @__env.GetMethodID(global::android.app.KeyguardManager.staticClass, "inKeyguardRestrictedInputMode", "()Z"); 
			global::android.app.KeyguardManager._exitKeyguardSecurely616 = @__env.GetMethodID(global::android.app.KeyguardManager.staticClass, "exitKeyguardSecurely", "(Landroid/app/KeyguardManager$OnKeyguardExitResult;)V"); 
		} 
	} 
} 
