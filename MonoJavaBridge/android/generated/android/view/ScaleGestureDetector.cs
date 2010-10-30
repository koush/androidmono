namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ScaleGestureDetector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ScaleGestureDetector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ScaleGestureDetector.OnScaleGestureListener_))]
		public partial interface OnScaleGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			bool onScale(android.view.ScaleGestureDetector arg0);
			bool onScaleBegin(android.view.ScaleGestureDetector arg0);
			void onScaleEnd(android.view.ScaleGestureDetector arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ScaleGestureDetector.OnScaleGestureListener))]
		internal sealed partial class OnScaleGestureListener_ : java.lang.Object, OnScaleGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnScaleGestureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScale14465;
			bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScale(android.view.ScaleGestureDetector arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale14465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin14466;
			bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin(android.view.ScaleGestureDetector arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin14466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd14467;
			void android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd(android.view.ScaleGestureDetector arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd14467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnScaleGestureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$OnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScale14465 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleBegin14466 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_._onScaleEnd14467 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class SimpleOnScaleGestureListener : java.lang.Object, OnScaleGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SimpleOnScaleGestureListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onScale14468;
			public virtual bool onScale(android.view.ScaleGestureDetector arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale14468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleBegin14469;
			public virtual bool onScaleBegin(android.view.ScaleGestureDetector arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin14469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onScaleEnd14470;
			public virtual void onScaleEnd(android.view.ScaleGestureDetector arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd14470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _SimpleOnScaleGestureListener14471;
			public SimpleOnScaleGestureListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener14471);
				Init(@__env, handle);
			}
			static SimpleOnScaleGestureListener()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$SimpleOnScaleGestureListener"));
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale14468 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin14469 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd14470 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener14471 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
			}
		}
		public new long EventTime
		{
			get
			{
				return getEventTime();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getEventTime14472;
		public virtual long getEventTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getEventTime14472);
		}
		internal static global::MonoJavaBridge.MethodId _onTouchEvent14473;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._onTouchEvent14473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isInProgress14474;
		public virtual bool isInProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._isInProgress14474);
		}
		public new float FocusX
		{
			get
			{
				return getFocusX();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFocusX14475;
		public virtual float getFocusX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusX14475);
		}
		public new float FocusY
		{
			get
			{
				return getFocusY();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFocusY14476;
		public virtual float getFocusY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusY14476);
		}
		public new float CurrentSpan
		{
			get
			{
				return getCurrentSpan();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentSpan14477;
		public virtual float getCurrentSpan()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getCurrentSpan14477);
		}
		public new float PreviousSpan
		{
			get
			{
				return getPreviousSpan();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPreviousSpan14478;
		public virtual float getPreviousSpan()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getPreviousSpan14478);
		}
		public new float ScaleFactor
		{
			get
			{
				return getScaleFactor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getScaleFactor14479;
		public virtual float getScaleFactor()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getScaleFactor14479);
		}
		public new long TimeDelta
		{
			get
			{
				return getTimeDelta();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDelta14480;
		public virtual long getTimeDelta()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getTimeDelta14480);
		}
		internal static global::MonoJavaBridge.MethodId _ScaleGestureDetector14481;
		public ScaleGestureDetector(android.content.Context arg0, android.view.ScaleGestureDetector.OnScaleGestureListener arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._ScaleGestureDetector14481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ScaleGestureDetector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ScaleGestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector"));
			global::android.view.ScaleGestureDetector._getEventTime14472 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getEventTime", "()J");
			global::android.view.ScaleGestureDetector._onTouchEvent14473 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ScaleGestureDetector._isInProgress14474 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "isInProgress", "()Z");
			global::android.view.ScaleGestureDetector._getFocusX14475 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusX", "()F");
			global::android.view.ScaleGestureDetector._getFocusY14476 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getFocusY", "()F");
			global::android.view.ScaleGestureDetector._getCurrentSpan14477 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getCurrentSpan", "()F");
			global::android.view.ScaleGestureDetector._getPreviousSpan14478 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getPreviousSpan", "()F");
			global::android.view.ScaleGestureDetector._getScaleFactor14479 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getScaleFactor", "()F");
			global::android.view.ScaleGestureDetector._getTimeDelta14480 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "getTimeDelta", "()J");
			global::android.view.ScaleGestureDetector._ScaleGestureDetector14481 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListener;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
