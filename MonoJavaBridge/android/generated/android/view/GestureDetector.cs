namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureDetector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureDetector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.GestureDetector.OnDoubleTapListener_))]
		public partial interface OnDoubleTapListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onSingleTapConfirmed(android.view.MotionEvent arg0);
			bool onDoubleTap(android.view.MotionEvent arg0);
			bool onDoubleTapEvent(android.view.MotionEvent arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.GestureDetector.OnDoubleTapListener))]
		internal sealed partial class OnDoubleTapListener_ : java.lang.Object, OnDoubleTapListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnDoubleTapListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.OnDoubleTapListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.OnDoubleTapListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.OnDoubleTapListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnDoubleTapListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnDoubleTapListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnDoubleTapListener"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.GestureDetector.OnGestureListener_))]
		public partial interface OnGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onLongPress(android.view.MotionEvent arg0);
			bool onSingleTapUp(android.view.MotionEvent arg0);
			bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3);
			bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3);
			void onShowPress(android.view.MotionEvent arg0);
			bool onDown(android.view.MotionEvent arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.GestureDetector.OnGestureListener))]
		internal sealed partial class OnGestureListener_ : java.lang.Object, OnGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGestureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.GestureDetector.OnGestureListener_.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V", ref global::android.view.GestureDetector.OnGestureListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnGestureListener_.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.OnGestureListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnGestureListener_.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.view.GestureDetector.OnGestureListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnGestureListener_.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.view.GestureDetector.OnGestureListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.GestureDetector.OnGestureListener_.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V", ref global::android.view.GestureDetector.OnGestureListener_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.OnGestureListener_.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.OnGestureListener_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnGestureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnGestureListener"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SimpleOnGestureListener : java.lang.Object, OnGestureListener, OnDoubleTapListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SimpleOnGestureListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void onLongPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V", ref global::android.view.GestureDetector.SimpleOnGestureListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual bool onDoubleTap(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void onShowPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V", ref global::android.view.GestureDetector.SimpleOnGestureListener._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual bool onDown(android.view.MotionEvent arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector.SimpleOnGestureListener._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public SimpleOnGestureListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.GestureDetector.SimpleOnGestureListener._m9.native == global::System.IntPtr.Zero)
					global::android.view.GestureDetector.SimpleOnGestureListener._m9 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._m9);
				Init(@__env, handle);
			}
			static SimpleOnGestureListener()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$SimpleOnGestureListener"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.GestureDetector._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V", ref global::android.view.GestureDetector._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setIsLongpressEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V", ref global::android.view.GestureDetector._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool isLongpressEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z", ref global::android.view.GestureDetector._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.GestureDetector._m4.native == global::System.IntPtr.Zero)
				global::android.view.GestureDetector._m4 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.GestureDetector._m5.native == global::System.IntPtr.Zero)
				global::android.view.GestureDetector._m5 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.GestureDetector._m6.native == global::System.IntPtr.Zero)
				global::android.view.GestureDetector._m6 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.GestureDetector._m7.native == global::System.IntPtr.Zero)
				global::android.view.GestureDetector._m7 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.GestureDetector._m8.native == global::System.IntPtr.Zero)
				global::android.view.GestureDetector._m8 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static GestureDetector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.GestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector"));
		}
	}
}
