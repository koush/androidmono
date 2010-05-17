namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GestureDetector : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureDetector() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.GestureDetector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.GestureDetector(@__env); 
			} 
		} 
		protected GestureDetector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDoubleTapListener 
		{ 
			bool onSingleTapConfirmed(android.view.MotionEvent arg0); 
			bool onDoubleTap(android.view.MotionEvent arg0); 
			bool onDoubleTapEvent(android.view.MotionEvent arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGestureListener 
		{ 
			void onLongPress(android.view.MotionEvent arg0); 
			bool onSingleTapUp(android.view.MotionEvent arg0); 
			bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3); 
			bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3); 
			void onShowPress(android.view.MotionEvent arg0); 
			bool onDown(android.view.MotionEvent arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SimpleOnGestureListener : java.lang.Object, OnGestureListener, OnDoubleTapListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static SimpleOnGestureListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.GestureDetector.SimpleOnGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.GestureDetector.SimpleOnGestureListener(@__env); 
				} 
			} 
			protected SimpleOnGestureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onLongPress7316; 
			public virtual void onLongPress(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					@__env.CallVoidMethod(this, _onLongPress7316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onLongPress7316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapConfirmed7317; 
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onSingleTapConfirmed7317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onSingleTapConfirmed7317, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTap7318; 
			public virtual bool onDoubleTap(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onDoubleTap7318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onDoubleTap7318, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTapEvent7319; 
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onDoubleTapEvent7319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onDoubleTapEvent7319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp7320; 
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onSingleTapUp7320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onSingleTapUp7320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onScroll7321; 
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onScroll7321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onScroll7321, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onFling7322; 
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onFling7322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onFling7322, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onShowPress7323; 
			public virtual void onShowPress(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					@__env.CallVoidMethod(this, _onShowPress7323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onShowPress7323, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDown7324; 
			public virtual bool onDown(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, _onDown7324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.SimpleOnGestureListener.staticClass, _onDown7324, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SimpleOnGestureListener7325; 
			public SimpleOnGestureListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, _SimpleOnGestureListener7325, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__class; 
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress7316 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed7317 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap7318 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent7319 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp7320 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll7321 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling7322 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress7323 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown7324 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener7325 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent7326; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				return @__env.CallBooleanMethod(this, _onTouchEvent7326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.staticClass, _onTouchEvent7326, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDoubleTapListener7327; 
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				@__env.CallVoidMethod(this, _setOnDoubleTapListener7327, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.GestureDetector.staticClass, _setOnDoubleTapListener7327, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsLongpressEnabled7328; 
		public virtual void setIsLongpressEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				@__env.CallVoidMethod(this, _setIsLongpressEnabled7328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.GestureDetector.staticClass, _setIsLongpressEnabled7328, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLongpressEnabled7329; 
		public virtual bool isLongpressEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				return @__env.CallBooleanMethod(this, _isLongpressEnabled7329); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.GestureDetector.staticClass, _isLongpressEnabled7329); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7330; 
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, _GestureDetector7330, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7331; 
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, _GestureDetector7331, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7332; 
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, _GestureDetector7332, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7333; 
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, _GestureDetector7333, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.GestureDetector.staticClass = @__class; 
			global::android.view.GestureDetector._onTouchEvent7326 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.GestureDetector._setOnDoubleTapListener7327 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V"); 
			global::android.view.GestureDetector._setIsLongpressEnabled7328 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V"); 
			global::android.view.GestureDetector._isLongpressEnabled7329 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z"); 
			global::android.view.GestureDetector._GestureDetector7330 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V"); 
			global::android.view.GestureDetector._GestureDetector7331 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V"); 
			global::android.view.GestureDetector._GestureDetector7332 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V"); 
			global::android.view.GestureDetector._GestureDetector7333 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V"); 
		} 
	} 
} 
