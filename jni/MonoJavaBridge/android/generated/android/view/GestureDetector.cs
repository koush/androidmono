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
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed14027;
			bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed14027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed14027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap14028;
			bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap14028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap14028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent14029;
			bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent14029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent14029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnDoubleTapListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnDoubleTapListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnDoubleTapListener"));
				global::android.view.GestureDetector.OnDoubleTapListener_._onSingleTapConfirmed14027 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTap14028 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnDoubleTapListener_._onDoubleTapEvent14029 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnDoubleTapListener_.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onLongPress14030;
			void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onLongPress14030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onLongPress14030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp14031;
			bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp14031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp14031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll14032;
			bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onScroll14032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onScroll14032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling14033;
			bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onFling14033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onFling14033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress14034;
			void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onShowPress14034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onShowPress14034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown14035;
			bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_._onDown14035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.OnGestureListener_.staticClass, global::android.view.GestureDetector.OnGestureListener_._onDown14035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnGestureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$OnGestureListener"));
				global::android.view.GestureDetector.OnGestureListener_._onLongPress14030 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onSingleTapUp14031 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.OnGestureListener_._onScroll14032 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onFling14033 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.OnGestureListener_._onShowPress14034 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.OnGestureListener_._onDown14035 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.OnGestureListener_.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SimpleOnGestureListener : java.lang.Object, OnGestureListener, OnDoubleTapListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SimpleOnGestureListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLongPress14036;
			public virtual void onLongPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress14036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress14036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapConfirmed14037;
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed14037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed14037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTap14038;
			public virtual bool onDoubleTap(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap14038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap14038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDoubleTapEvent14039;
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent14039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent14039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onSingleTapUp14040;
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp14040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp14040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScroll14041;
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll14041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll14041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onFling14042;
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onFling14042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onFling14042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			internal static global::MonoJavaBridge.MethodId _onShowPress14043;
			public virtual void onShowPress(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress14043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress14043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onDown14044;
			public virtual bool onDown(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener._onDown14044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDown14044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnGestureListener14045;
			public SimpleOnGestureListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener14045);
				Init(@__env, handle);
			}
			static SimpleOnGestureListener()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector$SimpleOnGestureListener"));
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress14036 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed14037 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap14038 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent14039 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp14040 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll14041 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling14042 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress14043 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown14044 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener14045 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14046;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._onTouchEvent14046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._onTouchEvent14046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnDoubleTapListener14047;
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setOnDoubleTapListener14047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setOnDoubleTapListener14047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIsLongpressEnabled14048;
		public virtual void setIsLongpressEnabled(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.GestureDetector._setIsLongpressEnabled14048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setIsLongpressEnabled14048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLongpressEnabled14049;
		public virtual bool isLongpressEnabled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.GestureDetector._isLongpressEnabled14049);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._isLongpressEnabled14049);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector14050;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector14050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector14051;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector14051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector14052;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector14052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector14053;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector14053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureDetector14054;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector14054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static GestureDetector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.GestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/GestureDetector"));
			global::android.view.GestureDetector._onTouchEvent14046 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.GestureDetector._setOnDoubleTapListener14047 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			global::android.view.GestureDetector._setIsLongpressEnabled14048 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V");
			global::android.view.GestureDetector._isLongpressEnabled14049 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z");
			global::android.view.GestureDetector._GestureDetector14050 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector14051 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector14052 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector14053 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector14054 = @__env.GetMethodIDNoThrow(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
