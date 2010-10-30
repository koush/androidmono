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
			internal static global::MonoJavaBridge.MethodId _onGestureStarted4901;
			void android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted4901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGesture4902;
			void android.gesture.GestureOverlayView.OnGestureListener.onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture4902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGestureEnded4903;
			void android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded4903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGestureCancelled4904;
			void android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V", ref global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled4904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnGestureListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGestureListener"));
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onGesturePerformed4905;
			void android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass, "onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed4905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnGesturePerformedListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturePerformedListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnGesturePerformedListenerDelegate(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1);

		internal partial class OnGesturePerformedListenerDelegateWrapper : java.lang.Object, OnGesturePerformedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnGesturePerformedListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnGesturePerformedListenerDelegateWrapper4906;
			public OnGesturePerformedListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper._OnGesturePerformedListenerDelegateWrapper4906.native == global::System.IntPtr.Zero)
					global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper._OnGesturePerformedListenerDelegateWrapper4906 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper.staticClass, global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper._OnGesturePerformedListenerDelegateWrapper4906);
				Init(@__env, handle);
			}
			static OnGesturePerformedListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView_OnGesturePerformedListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
			internal static global::MonoJavaBridge.MethodId _onGesturingStarted4907;
			void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted(android.gesture.GestureOverlayView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V", ref global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted4907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onGesturingEnded4908;
			void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded(android.gesture.GestureOverlayView arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V", ref global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded4908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnGesturingListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturingListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear4909;
		public virtual void clear(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V", ref global::android.gesture.GestureOverlayView._clear4909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw4910;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.gesture.GestureOverlayView._draw4910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow4911;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V", ref global::android.gesture.GestureOverlayView._onDetachedFromWindow4911);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent4912;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z", ref global::android.gesture.GestureOverlayView._dispatchTouchEvent4912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation4913;
		public virtual void setOrientation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V", ref global::android.gesture.GestureOverlayView._setOrientation4913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrientation4914;
		public virtual int getOrientation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I", ref global::android.gesture.GestureOverlayView._getOrientation4914);
		}
		public new global::java.util.ArrayList CurrentStroke
		{
			get
			{
				return getCurrentStroke();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentStroke4915;
		public virtual global::java.util.ArrayList getCurrentStroke()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;", ref global::android.gesture.GestureOverlayView._getCurrentStroke4915) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _setGestureColor4916;
		public virtual void setGestureColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V", ref global::android.gesture.GestureOverlayView._setGestureColor4916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUncertainGestureColor4917;
		public virtual void setUncertainGestureColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V", ref global::android.gesture.GestureOverlayView._setUncertainGestureColor4917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUncertainGestureColor4918;
		public virtual int getUncertainGestureColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I", ref global::android.gesture.GestureOverlayView._getUncertainGestureColor4918);
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
		internal static global::MonoJavaBridge.MethodId _getGestureColor4919;
		public virtual int getGestureColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I", ref global::android.gesture.GestureOverlayView._getGestureColor4919);
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeWidth4920;
		public virtual float getGestureStrokeWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F", ref global::android.gesture.GestureOverlayView._getGestureStrokeWidth4920);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeWidth4921;
		public virtual void setGestureStrokeWidth(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V", ref global::android.gesture.GestureOverlayView._setGestureStrokeWidth4921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeType4922;
		public virtual int getGestureStrokeType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I", ref global::android.gesture.GestureOverlayView._getGestureStrokeType4922);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeType4923;
		public virtual void setGestureStrokeType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V", ref global::android.gesture.GestureOverlayView._setGestureStrokeType4923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeLengthThreshold4924;
		public virtual float getGestureStrokeLengthThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F", ref global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold4924);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeLengthThreshold4925;
		public virtual void setGestureStrokeLengthThreshold(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V", ref global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold4925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeSquarenessTreshold4926;
		public virtual float getGestureStrokeSquarenessTreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F", ref global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold4926);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeSquarenessTreshold4927;
		public virtual void setGestureStrokeSquarenessTreshold(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V", ref global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold4927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeAngleThreshold4928;
		public virtual float getGestureStrokeAngleThreshold()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F", ref global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold4928);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeAngleThreshold4929;
		public virtual void setGestureStrokeAngleThreshold(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V", ref global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold4929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEventsInterceptionEnabled4930;
		public virtual bool isEventsInterceptionEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z", ref global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled4930);
		}
		public new bool EventsInterceptionEnabled
		{
			set
			{
				setEventsInterceptionEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEventsInterceptionEnabled4931;
		public virtual void setEventsInterceptionEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V", ref global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled4931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFadeEnabled4932;
		public virtual bool isFadeEnabled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z", ref global::android.gesture.GestureOverlayView._isFadeEnabled4932);
		}
		public new bool FadeEnabled
		{
			set
			{
				setFadeEnabled(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFadeEnabled4933;
		public virtual void setFadeEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V", ref global::android.gesture.GestureOverlayView._setFadeEnabled4933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGesture4934;
		public virtual global::android.gesture.Gesture getGesture()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;", ref global::android.gesture.GestureOverlayView._getGesture4934) as android.gesture.Gesture;
		}
		internal static global::MonoJavaBridge.MethodId _setGesture4935;
		public virtual void setGesture(android.gesture.Gesture arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V", ref global::android.gesture.GestureOverlayView._setGesture4935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Path GesturePath
		{
			get
			{
				return getGesturePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGesturePath4936;
		public virtual global::android.graphics.Path getGesturePath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;", ref global::android.gesture.GestureOverlayView._getGesturePath4936) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getGesturePath4937;
		public virtual global::android.graphics.Path getGesturePath(android.graphics.Path arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;", ref global::android.gesture.GestureOverlayView._getGesturePath4937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _isGestureVisible4938;
		public virtual bool isGestureVisible()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z", ref global::android.gesture.GestureOverlayView._isGestureVisible4938);
		}
		public new bool GestureVisible
		{
			set
			{
				setGestureVisible(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGestureVisible4939;
		public virtual void setGestureVisible(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V", ref global::android.gesture.GestureOverlayView._setGestureVisible4939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFadeOffset4940;
		public virtual long getFadeOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J", ref global::android.gesture.GestureOverlayView._getFadeOffset4940);
		}
		internal static global::MonoJavaBridge.MethodId _setFadeOffset4941;
		public virtual void setFadeOffset(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V", ref global::android.gesture.GestureOverlayView._setFadeOffset4941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnGestureListener4942;
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V", ref global::android.gesture.GestureOverlayView._addOnGestureListener4942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGestureListener4943;
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V", ref global::android.gesture.GestureOverlayView._removeOnGestureListener4943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGestureListeners4944;
		public virtual void removeAllOnGestureListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V", ref global::android.gesture.GestureOverlayView._removeAllOnGestureListeners4944);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGesturePerformedListener4945;
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V", ref global::android.gesture.GestureOverlayView._addOnGesturePerformedListener4945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void addOnGesturePerformedListener(global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegate arg0)
		{
			addOnGesturePerformedListener((global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGesturePerformedListener4946;
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V", ref global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener4946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void removeOnGesturePerformedListener(global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegate arg0)
		{
			removeOnGesturePerformedListener((global::android.gesture.GestureOverlayView.OnGesturePerformedListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGesturePerformedListeners4947;
		public virtual void removeAllOnGesturePerformedListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V", ref global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners4947);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGesturingListener4948;
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V", ref global::android.gesture.GestureOverlayView._addOnGesturingListener4948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGesturingListener4949;
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V", ref global::android.gesture.GestureOverlayView._removeOnGesturingListener4949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGesturingListeners4950;
		public virtual void removeAllOnGesturingListeners()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V", ref global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners4950);
		}
		internal static global::MonoJavaBridge.MethodId _isGesturing4951;
		public virtual bool isGesturing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z", ref global::android.gesture.GestureOverlayView._isGesturing4951);
		}
		internal static global::MonoJavaBridge.MethodId _cancelClearAnimation4952;
		public virtual void cancelClearAnimation()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V", ref global::android.gesture.GestureOverlayView._cancelClearAnimation4952);
		}
		internal static global::MonoJavaBridge.MethodId _cancelGesture4953;
		public virtual void cancelGesture()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V", ref global::android.gesture.GestureOverlayView._cancelGesture4953);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView4954;
		public GestureOverlayView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureOverlayView._GestureOverlayView4954.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureOverlayView._GestureOverlayView4954 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView4954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView4955;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureOverlayView._GestureOverlayView4955.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureOverlayView._GestureOverlayView4955 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView4955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView4956;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureOverlayView._GestureOverlayView4956.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureOverlayView._GestureOverlayView4956 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView4956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static void InitJNI()
		{
		}
	}
}
