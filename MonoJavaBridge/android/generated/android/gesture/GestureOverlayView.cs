namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureOverlayView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GestureOverlayView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGestureListener_))]
		public partial interface OnGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGestureListener))]
		internal sealed partial class OnGestureListener_ : java.lang.Object, OnGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGestureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.gesture.GestureOverlayView.OnGestureListener.onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			void android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			void android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnGestureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGestureListener"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGesturePerformedListener_))]
		public partial interface OnGesturePerformedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGesturePerformedListener))]
		internal sealed partial class OnGesturePerformedListener_ : java.lang.Object, OnGesturePerformedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGesturePerformedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass, "onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnGesturePerformedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturePerformedListener"));
			}
		}

		public delegate void OnGesturePerformedListenerDelegate(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1);

		internal partial class OnGesturePerformedListenerDelegateWrapper : java.lang.Object, OnGesturePerformedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGesturePerformedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnGesturePerformedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper.staticClass, global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnGesturePerformedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView_OnGesturePerformedListenerDelegateWrapper"));
			}
		}
		internal partial class OnGesturePerformedListenerDelegateWrapper
		{
			private OnGesturePerformedListenerDelegate myDelegate;
			public void onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnGesturePerformedListenerDelegateWrapper(OnGesturePerformedListenerDelegate d)
			{
				global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper ret = new global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGesturingListener_))]
		public partial interface OnGesturingListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGesturingStarted(android.gesture.GestureOverlayView arg0);
			void onGesturingEnded(android.gesture.GestureOverlayView arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGesturingListener))]
		internal sealed partial class OnGesturingListener_ : java.lang.Object, OnGesturingListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnGesturingListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted(android.gesture.GestureOverlayView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V", ref global::android.gesture.GestureOverlayView.OnGesturingListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded(android.gesture.GestureOverlayView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V", ref global::android.gesture.GestureOverlayView.OnGesturingListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnGesturingListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturingListener"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void clear(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V", ref global::android.gesture.GestureOverlayView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.gesture.GestureOverlayView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V", ref global::android.gesture.GestureOverlayView._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.gesture.GestureOverlayView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setOrientation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V", ref global::android.gesture.GestureOverlayView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Orientation
		{
			get
			{
				return getOrientation();
			}
			set
			{
				setOrientation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I", ref global::android.gesture.GestureOverlayView._m5);
		}
		public new global::java.util.ArrayList CurrentStroke
		{
			get
			{
				return getCurrentStroke();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.util.ArrayList getCurrentStroke()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;", ref global::android.gesture.GestureOverlayView._m6) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setGestureColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V", ref global::android.gesture.GestureOverlayView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setUncertainGestureColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V", ref global::android.gesture.GestureOverlayView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int UncertainGestureColor
		{
			get
			{
				return getUncertainGestureColor();
			}
			set
			{
				setUncertainGestureColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getUncertainGestureColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I", ref global::android.gesture.GestureOverlayView._m9);
		}
		public new int GestureColor
		{
			get
			{
				return getGestureColor();
			}
			set
			{
				setGestureColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getGestureColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I", ref global::android.gesture.GestureOverlayView._m10);
		}
		public new float GestureStrokeWidth
		{
			get
			{
				return getGestureStrokeWidth();
			}
			set
			{
				setGestureStrokeWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual float getGestureStrokeWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F", ref global::android.gesture.GestureOverlayView._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setGestureStrokeWidth(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V", ref global::android.gesture.GestureOverlayView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int GestureStrokeType
		{
			get
			{
				return getGestureStrokeType();
			}
			set
			{
				setGestureStrokeType(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getGestureStrokeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I", ref global::android.gesture.GestureOverlayView._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setGestureStrokeType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V", ref global::android.gesture.GestureOverlayView._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float GestureStrokeLengthThreshold
		{
			get
			{
				return getGestureStrokeLengthThreshold();
			}
			set
			{
				setGestureStrokeLengthThreshold(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual float getGestureStrokeLengthThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F", ref global::android.gesture.GestureOverlayView._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setGestureStrokeLengthThreshold(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V", ref global::android.gesture.GestureOverlayView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float GestureStrokeSquarenessTreshold
		{
			get
			{
				return getGestureStrokeSquarenessTreshold();
			}
			set
			{
				setGestureStrokeSquarenessTreshold(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual float getGestureStrokeSquarenessTreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F", ref global::android.gesture.GestureOverlayView._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setGestureStrokeSquarenessTreshold(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V", ref global::android.gesture.GestureOverlayView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float GestureStrokeAngleThreshold
		{
			get
			{
				return getGestureStrokeAngleThreshold();
			}
			set
			{
				setGestureStrokeAngleThreshold(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual float getGestureStrokeAngleThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F", ref global::android.gesture.GestureOverlayView._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setGestureStrokeAngleThreshold(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V", ref global::android.gesture.GestureOverlayView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isEventsInterceptionEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z", ref global::android.gesture.GestureOverlayView._m21);
		}
		public new bool EventsInterceptionEnabled
		{
			set
			{
				setEventsInterceptionEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setEventsInterceptionEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V", ref global::android.gesture.GestureOverlayView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isFadeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z", ref global::android.gesture.GestureOverlayView._m23);
		}
		public new bool FadeEnabled
		{
			set
			{
				setFadeEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setFadeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V", ref global::android.gesture.GestureOverlayView._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.gesture.Gesture Gesture
		{
			get
			{
				return getGesture();
			}
			set
			{
				setGesture(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::android.gesture.Gesture getGesture()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;", ref global::android.gesture.GestureOverlayView._m25) as android.gesture.Gesture;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setGesture(android.gesture.Gesture arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureOverlayView._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Path GesturePath
		{
			get
			{
				return getGesturePath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.graphics.Path getGesturePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;", ref global::android.gesture.GestureOverlayView._m27) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.graphics.Path getGesturePath(android.graphics.Path arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;", ref global::android.gesture.GestureOverlayView._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Path;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isGestureVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z", ref global::android.gesture.GestureOverlayView._m29);
		}
		public new bool GestureVisible
		{
			set
			{
				setGestureVisible(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setGestureVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V", ref global::android.gesture.GestureOverlayView._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long FadeOffset
		{
			get
			{
				return getFadeOffset();
			}
			set
			{
				setFadeOffset(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual long getFadeOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J", ref global::android.gesture.GestureOverlayView._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setFadeOffset(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V", ref global::android.gesture.GestureOverlayView._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V", ref global::android.gesture.GestureOverlayView._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V", ref global::android.gesture.GestureOverlayView._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void removeAllOnGestureListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V", ref global::android.gesture.GestureOverlayView._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V", ref global::android.gesture.GestureOverlayView._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnGesturePerformedListener(global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegate arg0)
		{
			addOnGesturePerformedListener((global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V", ref global::android.gesture.GestureOverlayView._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnGesturePerformedListener(global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegate arg0)
		{
			removeOnGesturePerformedListener((global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void removeAllOnGesturePerformedListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V", ref global::android.gesture.GestureOverlayView._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V", ref global::android.gesture.GestureOverlayView._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V", ref global::android.gesture.GestureOverlayView._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void removeAllOnGesturingListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V", ref global::android.gesture.GestureOverlayView._m41);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual bool isGesturing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z", ref global::android.gesture.GestureOverlayView._m42);
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void cancelClearAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V", ref global::android.gesture.GestureOverlayView._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void cancelGesture()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V", ref global::android.gesture.GestureOverlayView._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public GestureOverlayView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureOverlayView._m45.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureOverlayView._m45 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureOverlayView._m46.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureOverlayView._m46 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureOverlayView._m47.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureOverlayView._m47 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int GESTURE_STROKE_TYPE_SINGLE
		{
			get
			{
				return 0;
			}
		}
		public static int GESTURE_STROKE_TYPE_MULTIPLE
		{
			get
			{
				return 1;
			}
		}
		public static int ORIENTATION_HORIZONTAL
		{
			get
			{
				return 0;
			}
		}
		public static int ORIENTATION_VERTICAL
		{
			get
			{
				return 1;
			}
		}
		static GestureOverlayView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureOverlayView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView"));
		}
	}
}
