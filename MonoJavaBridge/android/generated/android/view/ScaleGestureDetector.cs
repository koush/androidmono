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
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScale(android.view.ScaleGestureDetector arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z", ref global::android.view.ScaleGestureDetector.OnScaleGestureListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin(android.view.ScaleGestureDetector arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", ref global::android.view.ScaleGestureDetector.OnScaleGestureListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd(android.view.ScaleGestureDetector arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", ref global::android.view.ScaleGestureDetector.OnScaleGestureListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnScaleGestureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.OnScaleGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$OnScaleGestureListener"));
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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual bool onScale(android.view.ScaleGestureDetector arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z", ref global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual bool onScaleBegin(android.view.ScaleGestureDetector arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z", ref global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void onScaleEnd(android.view.ScaleGestureDetector arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V", ref global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public SimpleOnScaleGestureListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._m3.native == global::System.IntPtr.Zero)
					global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._m3 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._m3);
				Init(@__env, handle);
			}
			static SimpleOnScaleGestureListener()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector$SimpleOnScaleGestureListener"));
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual long getEventTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getEventTime", "()J", ref global::android.view.ScaleGestureDetector._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.view.ScaleGestureDetector._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool isInProgress()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.staticClass, "isInProgress", "()Z", ref global::android.view.ScaleGestureDetector._m2);
		}
		public new float FocusX
		{
			get
			{
				return getFocusX();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual float getFocusX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getFocusX", "()F", ref global::android.view.ScaleGestureDetector._m3);
		}
		public new float FocusY
		{
			get
			{
				return getFocusY();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual float getFocusY()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getFocusY", "()F", ref global::android.view.ScaleGestureDetector._m4);
		}
		public new float CurrentSpan
		{
			get
			{
				return getCurrentSpan();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual float getCurrentSpan()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getCurrentSpan", "()F", ref global::android.view.ScaleGestureDetector._m5);
		}
		public new float PreviousSpan
		{
			get
			{
				return getPreviousSpan();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual float getPreviousSpan()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getPreviousSpan", "()F", ref global::android.view.ScaleGestureDetector._m6);
		}
		public new float ScaleFactor
		{
			get
			{
				return getScaleFactor();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual float getScaleFactor()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getScaleFactor", "()F", ref global::android.view.ScaleGestureDetector._m7);
		}
		public new long TimeDelta
		{
			get
			{
				return getTimeDelta();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long getTimeDelta()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.view.ScaleGestureDetector.staticClass, "getTimeDelta", "()J", ref global::android.view.ScaleGestureDetector._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ScaleGestureDetector(android.content.Context arg0, android.view.ScaleGestureDetector.OnScaleGestureListener arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ScaleGestureDetector._m9.native == global::System.IntPtr.Zero)
				global::android.view.ScaleGestureDetector._m9 = @__env.GetMethodIDNoThrow(global::android.view.ScaleGestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ScaleGestureDetector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ScaleGestureDetector.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ScaleGestureDetector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
