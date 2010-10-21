namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GestureOverlayView : android.widget.FrameLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GestureOverlayView()
		{
			InitJNI();
		}
		protected GestureOverlayView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGestureListener_))]
		public interface OnGestureListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
			void onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGestureListener))]
		public sealed partial class OnGestureListener_ : java.lang.Object, OnGestureListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGestureListener_()
			{
				InitJNI();
			}
			internal OnGestureListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGestureStarted4883;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted4883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted4883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGesture4884;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture4884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture4884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGestureEnded4885;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded4885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded4885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onGestureCancelled4886;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled4886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled4886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGestureListener"));
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureStarted4883 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGesture4884 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureEnded4885 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.OnGestureListener_._onGestureCancelled4886 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGestureListener_.staticClass, "onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGesturePerformedListener_))]
		public interface OnGesturePerformedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGesturePerformedListener))]
		public sealed partial class OnGesturePerformedListener_ : java.lang.Object, OnGesturePerformedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGesturePerformedListener_()
			{
				InitJNI();
			}
			internal OnGesturePerformedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGesturePerformed4887;
			 void android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed4887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass, global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed4887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturePerformedListener"));
				global::android.gesture.GestureOverlayView.OnGesturePerformedListener_._onGesturePerformed4887 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturePerformedListener_.staticClass, "onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.gesture.GestureOverlayView.OnGesturingListener_))]
		public interface OnGesturingListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGesturingStarted(android.gesture.GestureOverlayView arg0);
			void onGesturingEnded(android.gesture.GestureOverlayView arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.gesture.GestureOverlayView.OnGesturingListener))]
		public sealed partial class OnGesturingListener_ : java.lang.Object, OnGesturingListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnGesturingListener_()
			{
				InitJNI();
			}
			internal OnGesturingListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGesturingStarted4888;
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted(android.gesture.GestureOverlayView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted4888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted4888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onGesturingEnded4889;
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded(android.gesture.GestureOverlayView arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded4889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded4889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView$OnGesturingListener"));
				global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingStarted4888 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V");
				global::android.gesture.GestureOverlayView.OnGesturingListener_._onGesturingEnded4889 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.OnGesturingListener_.staticClass, "onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear4890;
		public virtual void clear(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._clear4890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._clear4890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _draw4891;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._draw4891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._draw4891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow4892;
		protected override void onDetachedFromWindow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._onDetachedFromWindow4892);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._onDetachedFromWindow4892);
		}
		internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent4893;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._dispatchTouchEvent4893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._dispatchTouchEvent4893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation4894;
		public virtual void setOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setOrientation4894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setOrientation4894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getOrientation4895;
		public virtual int getOrientation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getOrientation4895);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getOrientation4895);
		}
		public new global::java.util.ArrayList CurrentStroke
		{
			get
			{
				return getCurrentStroke();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentStroke4896;
		public virtual global::java.util.ArrayList getCurrentStroke() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getCurrentStroke4896)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getCurrentStroke4896)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _setGestureColor4897;
		public virtual void setGestureColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureColor4897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureColor4897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setUncertainGestureColor4898;
		public virtual void setUncertainGestureColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setUncertainGestureColor4898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setUncertainGestureColor4898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getUncertainGestureColor4899;
		public virtual int getUncertainGestureColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getUncertainGestureColor4899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getUncertainGestureColor4899);
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
		internal static global::MonoJavaBridge.MethodId _getGestureColor4900;
		public virtual int getGestureColor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureColor4900);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureColor4900);
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeWidth4901;
		public virtual float getGestureStrokeWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeWidth4901);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeWidth4901);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeWidth4902;
		public virtual void setGestureStrokeWidth(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeWidth4902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeWidth4902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeType4903;
		public virtual int getGestureStrokeType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeType4903);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeType4903);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeType4904;
		public virtual void setGestureStrokeType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeType4904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeType4904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeLengthThreshold4905;
		public virtual float getGestureStrokeLengthThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold4905);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold4905);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeLengthThreshold4906;
		public virtual void setGestureStrokeLengthThreshold(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold4906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold4906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeSquarenessTreshold4907;
		public virtual float getGestureStrokeSquarenessTreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold4907);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold4907);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeSquarenessTreshold4908;
		public virtual void setGestureStrokeSquarenessTreshold(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold4908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold4908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGestureStrokeAngleThreshold4909;
		public virtual float getGestureStrokeAngleThreshold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold4909);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold4909);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureStrokeAngleThreshold4910;
		public virtual void setGestureStrokeAngleThreshold(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold4910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold4910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEventsInterceptionEnabled4911;
		public virtual bool isEventsInterceptionEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled4911);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled4911);
		}
		internal static global::MonoJavaBridge.MethodId _setEventsInterceptionEnabled4912;
		public virtual void setEventsInterceptionEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled4912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled4912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isFadeEnabled4913;
		public virtual bool isFadeEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isFadeEnabled4913);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isFadeEnabled4913);
		}
		internal static global::MonoJavaBridge.MethodId _setFadeEnabled4914;
		public virtual void setFadeEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setFadeEnabled4914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setFadeEnabled4914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getGesture4915;
		public virtual global::android.gesture.Gesture getGesture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGesture4915)) as android.gesture.Gesture;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesture4915)) as android.gesture.Gesture;
		}
		internal static global::MonoJavaBridge.MethodId _setGesture4916;
		public virtual void setGesture(android.gesture.Gesture arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGesture4916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGesture4916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Path GesturePath
		{
			get
			{
				return getGesturePath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGesturePath4917;
		public virtual global::android.graphics.Path getGesturePath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGesturePath4917)) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesturePath4917)) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _getGesturePath4918;
		public virtual global::android.graphics.Path getGesturePath(android.graphics.Path arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getGesturePath4918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesturePath4918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Path;
		}
		internal static global::MonoJavaBridge.MethodId _isGestureVisible4919;
		public virtual bool isGestureVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isGestureVisible4919);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isGestureVisible4919);
		}
		internal static global::MonoJavaBridge.MethodId _setGestureVisible4920;
		public virtual void setGestureVisible(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setGestureVisible4920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureVisible4920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getFadeOffset4921;
		public virtual long getFadeOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._getFadeOffset4921);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getFadeOffset4921);
		}
		internal static global::MonoJavaBridge.MethodId _setFadeOffset4922;
		public virtual void setFadeOffset(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._setFadeOffset4922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setFadeOffset4922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addOnGestureListener4923;
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._addOnGestureListener4923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGestureListener4923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGestureListener4924;
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeOnGestureListener4924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGestureListener4924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGestureListeners4925;
		public virtual void removeAllOnGestureListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeAllOnGestureListeners4925);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGestureListeners4925);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGesturePerformedListener4926;
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._addOnGesturePerformedListener4926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGesturePerformedListener4926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGesturePerformedListener4927;
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener4927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener4927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGesturePerformedListeners4928;
		public virtual void removeAllOnGesturePerformedListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners4928);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners4928);
		}
		internal static global::MonoJavaBridge.MethodId _addOnGesturingListener4929;
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._addOnGesturingListener4929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGesturingListener4929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeOnGesturingListener4930;
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeOnGesturingListener4930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGesturingListener4930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAllOnGesturingListeners4931;
		public virtual void removeAllOnGesturingListeners() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners4931);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners4931);
		}
		internal static global::MonoJavaBridge.MethodId _isGesturing4932;
		public virtual bool isGesturing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._isGesturing4932);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isGesturing4932);
		}
		internal static global::MonoJavaBridge.MethodId _cancelClearAnimation4933;
		public virtual void cancelClearAnimation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._cancelClearAnimation4933);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._cancelClearAnimation4933);
		}
		internal static global::MonoJavaBridge.MethodId _cancelGesture4934;
		public virtual void cancelGesture() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView._cancelGesture4934);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._cancelGesture4934);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView4935;
		public GestureOverlayView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView4935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView4936;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView4936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GestureOverlayView4937;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView4937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureOverlayView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureOverlayView"));
			global::android.gesture.GestureOverlayView._clear4890 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V");
			global::android.gesture.GestureOverlayView._draw4891 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.gesture.GestureOverlayView._onDetachedFromWindow4892 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V");
			global::android.gesture.GestureOverlayView._dispatchTouchEvent4893 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.gesture.GestureOverlayView._setOrientation4894 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V");
			global::android.gesture.GestureOverlayView._getOrientation4895 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I");
			global::android.gesture.GestureOverlayView._getCurrentStroke4896 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;");
			global::android.gesture.GestureOverlayView._setGestureColor4897 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V");
			global::android.gesture.GestureOverlayView._setUncertainGestureColor4898 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V");
			global::android.gesture.GestureOverlayView._getUncertainGestureColor4899 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I");
			global::android.gesture.GestureOverlayView._getGestureColor4900 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I");
			global::android.gesture.GestureOverlayView._getGestureStrokeWidth4901 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeWidth4902 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeType4903 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I");
			global::android.gesture.GestureOverlayView._setGestureStrokeType4904 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold4905 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold4906 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold4907 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold4908 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold4909 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold4910 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V");
			global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled4911 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z");
			global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled4912 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V");
			global::android.gesture.GestureOverlayView._isFadeEnabled4913 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z");
			global::android.gesture.GestureOverlayView._setFadeEnabled4914 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V");
			global::android.gesture.GestureOverlayView._getGesture4915 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;");
			global::android.gesture.GestureOverlayView._setGesture4916 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureOverlayView._getGesturePath4917 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;");
			global::android.gesture.GestureOverlayView._getGesturePath4918 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.GestureOverlayView._isGestureVisible4919 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z");
			global::android.gesture.GestureOverlayView._setGestureVisible4920 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V");
			global::android.gesture.GestureOverlayView._getFadeOffset4921 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J");
			global::android.gesture.GestureOverlayView._setFadeOffset4922 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V");
			global::android.gesture.GestureOverlayView._addOnGestureListener4923 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGestureListener4924 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGestureListeners4925 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V");
			global::android.gesture.GestureOverlayView._addOnGesturePerformedListener4926 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener4927 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners4928 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V");
			global::android.gesture.GestureOverlayView._addOnGesturingListener4929 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGesturingListener4930 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners4931 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V");
			global::android.gesture.GestureOverlayView._isGesturing4932 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z");
			global::android.gesture.GestureOverlayView._cancelClearAnimation4933 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V");
			global::android.gesture.GestureOverlayView._cancelGesture4934 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V");
			global::android.gesture.GestureOverlayView._GestureOverlayView4935 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.gesture.GestureOverlayView._GestureOverlayView4936 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.gesture.GestureOverlayView._GestureOverlayView4937 = @__env.GetMethodIDNoThrow(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
