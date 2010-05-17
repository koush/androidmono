namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GestureOverlayView : android.widget.FrameLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GestureOverlayView() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureOverlayView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.gesture.GestureOverlayView(@__env); 
			} 
		} 
		protected GestureOverlayView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGestureListener 
		{ 
			void onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1); 
			void onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1); 
			void onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1); 
			void onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGesturePerformedListener 
		{ 
			void onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGesturingListener 
		{ 
			void onGesturingStarted(android.gesture.GestureOverlayView arg0); 
			void onGesturingEnded(android.gesture.GestureOverlayView arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear2416; 
		public virtual void clear(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _clear2416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _clear2416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw2417; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _draw2417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _draw2417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow2418; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow2418); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _onDetachedFromWindow2418); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent2419; 
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _dispatchTouchEvent2419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _dispatchTouchEvent2419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation2420; 
		public virtual void setOrientation(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setOrientation2420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setOrientation2420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation2421; 
		public virtual int getOrientation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getOrientation2421); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getOrientation2421); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentStroke2422; 
		public virtual java.util.ArrayList getCurrentStroke() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentStroke2422)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getCurrentStroke2422)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureColor2423; 
		public virtual void setGestureColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureColor2423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureColor2423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUncertainGestureColor2424; 
		public virtual void setUncertainGestureColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setUncertainGestureColor2424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setUncertainGestureColor2424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUncertainGestureColor2425; 
		public virtual int getUncertainGestureColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getUncertainGestureColor2425); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getUncertainGestureColor2425); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureColor2426; 
		public virtual int getGestureColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getGestureColor2426); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureColor2426); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeWidth2427; 
		public virtual float getGestureStrokeWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeWidth2427); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeWidth2427); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeWidth2428; 
		public virtual void setGestureStrokeWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeWidth2428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeWidth2428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeType2429; 
		public virtual int getGestureStrokeType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getGestureStrokeType2429); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeType2429); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeType2430; 
		public virtual void setGestureStrokeType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeType2430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeType2430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeLengthThreshold2431; 
		public virtual float getGestureStrokeLengthThreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeLengthThreshold2431); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeLengthThreshold2431); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeLengthThreshold2432; 
		public virtual void setGestureStrokeLengthThreshold(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeLengthThreshold2432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeLengthThreshold2432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeSquarenessTreshold2433; 
		public virtual float getGestureStrokeSquarenessTreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeSquarenessTreshold2433); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeSquarenessTreshold2433); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeSquarenessTreshold2434; 
		public virtual void setGestureStrokeSquarenessTreshold(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeSquarenessTreshold2434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeSquarenessTreshold2434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeAngleThreshold2435; 
		public virtual float getGestureStrokeAngleThreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeAngleThreshold2435); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeAngleThreshold2435); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeAngleThreshold2436; 
		public virtual void setGestureStrokeAngleThreshold(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeAngleThreshold2436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeAngleThreshold2436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEventsInterceptionEnabled2437; 
		public virtual bool isEventsInterceptionEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isEventsInterceptionEnabled2437); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isEventsInterceptionEnabled2437); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventsInterceptionEnabled2438; 
		public virtual void setEventsInterceptionEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setEventsInterceptionEnabled2438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setEventsInterceptionEnabled2438, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFadeEnabled2439; 
		public virtual bool isFadeEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isFadeEnabled2439); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isFadeEnabled2439); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFadeEnabled2440; 
		public virtual void setFadeEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setFadeEnabled2440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setFadeEnabled2440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGesture2441; 
		public virtual android.gesture.Gesture getGesture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.Gesture>(@__env, @__env.CallObjectMethodPtr(this, _getGesture2441)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.Gesture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getGesture2441)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGesture2442; 
		public virtual void setGesture(android.gesture.Gesture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGesture2442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGesture2442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGesturePath2443; 
		public virtual android.graphics.Path getGesturePath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _getGesturePath2443)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getGesturePath2443)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGesturePath2444; 
		public virtual android.graphics.Path getGesturePath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _getGesturePath2444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getGesturePath2444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGestureVisible2445; 
		public virtual bool isGestureVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isGestureVisible2445); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isGestureVisible2445); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureVisible2446; 
		public virtual void setGestureVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureVisible2446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureVisible2446, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFadeOffset2447; 
		public virtual long getFadeOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallLongMethod(this, _getFadeOffset2447); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.gesture.GestureOverlayView.staticClass, _getFadeOffset2447); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFadeOffset2448; 
		public virtual void setFadeOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setFadeOffset2448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setFadeOffset2448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGestureListener2449; 
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _addOnGestureListener2449, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _addOnGestureListener2449, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGestureListener2450; 
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeOnGestureListener2450, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeOnGestureListener2450, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGestureListeners2451; 
		public virtual void removeAllOnGestureListeners() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeAllOnGestureListeners2451); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeAllOnGestureListeners2451); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGesturePerformedListener2452; 
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _addOnGesturePerformedListener2452, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _addOnGesturePerformedListener2452, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGesturePerformedListener2453; 
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeOnGesturePerformedListener2453, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeOnGesturePerformedListener2453, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGesturePerformedListeners2454; 
		public virtual void removeAllOnGesturePerformedListeners() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeAllOnGesturePerformedListeners2454); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeAllOnGesturePerformedListeners2454); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGesturingListener2455; 
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _addOnGesturingListener2455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _addOnGesturingListener2455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGesturingListener2456; 
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeOnGesturingListener2456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeOnGesturingListener2456, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGesturingListeners2457; 
		public virtual void removeAllOnGesturingListeners() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeAllOnGesturingListeners2457); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeAllOnGesturingListeners2457); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGesturing2458; 
		public virtual bool isGesturing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isGesturing2458); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isGesturing2458); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelClearAnimation2459; 
		public virtual void cancelClearAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _cancelClearAnimation2459); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _cancelClearAnimation2459); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelGesture2460; 
		public virtual void cancelGesture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _cancelGesture2460); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _cancelGesture2460); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2461; 
		public GestureOverlayView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, _GestureOverlayView2461, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2462; 
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, _GestureOverlayView2462, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2463; 
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, _GestureOverlayView2463, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GestureOverlayView.staticClass = @__class; 
			global::android.gesture.GestureOverlayView._clear2416 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V"); 
			global::android.gesture.GestureOverlayView._draw2417 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.gesture.GestureOverlayView._onDetachedFromWindow2418 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.gesture.GestureOverlayView._dispatchTouchEvent2419 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.gesture.GestureOverlayView._setOrientation2420 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V"); 
			global::android.gesture.GestureOverlayView._getOrientation2421 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I"); 
			global::android.gesture.GestureOverlayView._getCurrentStroke2422 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;"); 
			global::android.gesture.GestureOverlayView._setGestureColor2423 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V"); 
			global::android.gesture.GestureOverlayView._setUncertainGestureColor2424 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V"); 
			global::android.gesture.GestureOverlayView._getUncertainGestureColor2425 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I"); 
			global::android.gesture.GestureOverlayView._getGestureColor2426 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeWidth2427 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeWidth2428 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeType2429 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeType2430 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2431 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2432 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2433 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2434 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2435 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold2436 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V"); 
			global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled2437 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z"); 
			global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled2438 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V"); 
			global::android.gesture.GestureOverlayView._isFadeEnabled2439 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z"); 
			global::android.gesture.GestureOverlayView._setFadeEnabled2440 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V"); 
			global::android.gesture.GestureOverlayView._getGesture2441 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;"); 
			global::android.gesture.GestureOverlayView._setGesture2442 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureOverlayView._getGesturePath2443 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;"); 
			global::android.gesture.GestureOverlayView._getGesturePath2444 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;"); 
			global::android.gesture.GestureOverlayView._isGestureVisible2445 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z"); 
			global::android.gesture.GestureOverlayView._setGestureVisible2446 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V"); 
			global::android.gesture.GestureOverlayView._getFadeOffset2447 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J"); 
			global::android.gesture.GestureOverlayView._setFadeOffset2448 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V"); 
			global::android.gesture.GestureOverlayView._addOnGestureListener2449 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V"); 
			global::android.gesture.GestureOverlayView._removeOnGestureListener2450 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V"); 
			global::android.gesture.GestureOverlayView._removeAllOnGestureListeners2451 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V"); 
			global::android.gesture.GestureOverlayView._addOnGesturePerformedListener2452 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V"); 
			global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener2453 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V"); 
			global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners2454 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V"); 
			global::android.gesture.GestureOverlayView._addOnGesturingListener2455 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V"); 
			global::android.gesture.GestureOverlayView._removeOnGesturingListener2456 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V"); 
			global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners2457 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V"); 
			global::android.gesture.GestureOverlayView._isGesturing2458 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z"); 
			global::android.gesture.GestureOverlayView._cancelClearAnimation2459 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V"); 
			global::android.gesture.GestureOverlayView._cancelGesture2460 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V"); 
			global::android.gesture.GestureOverlayView._GestureOverlayView2461 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.gesture.GestureOverlayView._GestureOverlayView2462 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.gesture.GestureOverlayView._GestureOverlayView2463 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
