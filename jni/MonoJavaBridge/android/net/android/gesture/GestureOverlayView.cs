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

		public partial class OnGestureListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnGestureListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnGestureListener : java.lang.Object, OnGestureListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnGestureListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureOverlayView.__OnGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.gesture.GestureOverlayView.__OnGestureListener(@__env); 
				} 
			} 
			internal __OnGestureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGestureStarted2609; 
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGestureListener)) 
					@__env.CallVoidMethod(this, _onGestureStarted2609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGestureListener.staticClass, _onGestureStarted2609, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGesture2610; 
			 void android.gesture.GestureOverlayView.OnGestureListener.onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGestureListener)) 
					@__env.CallVoidMethod(this, _onGesture2610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGestureListener.staticClass, _onGesture2610, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGestureEnded2611; 
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGestureListener)) 
					@__env.CallVoidMethod(this, _onGestureEnded2611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGestureListener.staticClass, _onGestureEnded2611, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGestureCancelled2612; 
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGestureListener)) 
					@__env.CallVoidMethod(this, _onGestureCancelled2612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGestureListener.staticClass, _onGestureCancelled2612, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass = @__class; 
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureStarted2609 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V"); 
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGesture2610 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V"); 
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureEnded2611 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V"); 
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureCancelled2612 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGesturePerformedListener 
		{ 
			void onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1); 
		} 

		public partial class OnGesturePerformedListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnGesturePerformedListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnGesturePerformedListener : java.lang.Object, OnGesturePerformedListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnGesturePerformedListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureOverlayView.__OnGesturePerformedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.gesture.GestureOverlayView.__OnGesturePerformedListener(@__env); 
				} 
			} 
			internal __OnGesturePerformedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGesturePerformed2613; 
			 void android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGesturePerformedListener)) 
					@__env.CallVoidMethod(this, _onGesturePerformed2613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGesturePerformedListener.staticClass, _onGesturePerformed2613, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.gesture.GestureOverlayView.__OnGesturePerformedListener.staticClass = @__class; 
				global::android.gesture.GestureOverlayView.__OnGesturePerformedListener._onGesturePerformed2613 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGesturePerformedListener.staticClass, "android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGesturingListener 
		{ 
			void onGesturingStarted(android.gesture.GestureOverlayView arg0); 
			void onGesturingEnded(android.gesture.GestureOverlayView arg0); 
		} 

		public partial class OnGesturingListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnGesturingListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnGesturingListener : java.lang.Object, OnGesturingListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnGesturingListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GestureOverlayView.__OnGesturingListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.gesture.GestureOverlayView.__OnGesturingListener(@__env); 
				} 
			} 
			internal __OnGesturingListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGesturingStarted2614; 
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted(android.gesture.GestureOverlayView arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGesturingListener)) 
					@__env.CallVoidMethod(this, _onGesturingStarted2614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, _onGesturingStarted2614, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onGesturingEnded2615; 
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded(android.gesture.GestureOverlayView arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.gesture.GestureOverlayView.__OnGesturingListener)) 
					@__env.CallVoidMethod(this, _onGesturingEnded2615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, _onGesturingEnded2615, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass = @__class; 
				global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingStarted2614 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, "android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V"); 
				global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingEnded2615 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, "android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear2616; 
		public virtual void clear(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _clear2616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _clear2616, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw2617; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _draw2617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _draw2617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow2618; 
		protected override void onDetachedFromWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _onDetachedFromWindow2618); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _onDetachedFromWindow2618); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent2619; 
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _dispatchTouchEvent2619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _dispatchTouchEvent2619, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation2620; 
		public virtual void setOrientation(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setOrientation2620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setOrientation2620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation2621; 
		public virtual int getOrientation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getOrientation2621); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getOrientation2621); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentStroke2622; 
		public virtual java.util.ArrayList getCurrentStroke() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _getCurrentStroke2622)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getCurrentStroke2622)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureColor2623; 
		public virtual void setGestureColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureColor2623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureColor2623, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUncertainGestureColor2624; 
		public virtual void setUncertainGestureColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setUncertainGestureColor2624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setUncertainGestureColor2624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUncertainGestureColor2625; 
		public virtual int getUncertainGestureColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getUncertainGestureColor2625); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getUncertainGestureColor2625); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureColor2626; 
		public virtual int getGestureColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getGestureColor2626); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureColor2626); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeWidth2627; 
		public virtual float getGestureStrokeWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeWidth2627); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeWidth2627); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeWidth2628; 
		public virtual void setGestureStrokeWidth(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeWidth2628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeWidth2628, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeType2629; 
		public virtual int getGestureStrokeType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallIntMethod(this, _getGestureStrokeType2629); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeType2629); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeType2630; 
		public virtual void setGestureStrokeType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeType2630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeType2630, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeLengthThreshold2631; 
		public virtual float getGestureStrokeLengthThreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeLengthThreshold2631); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeLengthThreshold2631); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeLengthThreshold2632; 
		public virtual void setGestureStrokeLengthThreshold(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeLengthThreshold2632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeLengthThreshold2632, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeSquarenessTreshold2633; 
		public virtual float getGestureStrokeSquarenessTreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeSquarenessTreshold2633); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeSquarenessTreshold2633); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeSquarenessTreshold2634; 
		public virtual void setGestureStrokeSquarenessTreshold(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeSquarenessTreshold2634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeSquarenessTreshold2634, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeAngleThreshold2635; 
		public virtual float getGestureStrokeAngleThreshold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallFloatMethod(this, _getGestureStrokeAngleThreshold2635); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.gesture.GestureOverlayView.staticClass, _getGestureStrokeAngleThreshold2635); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeAngleThreshold2636; 
		public virtual void setGestureStrokeAngleThreshold(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureStrokeAngleThreshold2636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureStrokeAngleThreshold2636, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEventsInterceptionEnabled2637; 
		public virtual bool isEventsInterceptionEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isEventsInterceptionEnabled2637); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isEventsInterceptionEnabled2637); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setEventsInterceptionEnabled2638; 
		public virtual void setEventsInterceptionEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setEventsInterceptionEnabled2638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setEventsInterceptionEnabled2638, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFadeEnabled2639; 
		public virtual bool isFadeEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isFadeEnabled2639); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isFadeEnabled2639); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFadeEnabled2640; 
		public virtual void setFadeEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setFadeEnabled2640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setFadeEnabled2640, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGesture2641; 
		public virtual android.gesture.Gesture getGesture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.Gesture>(@__env, @__env.CallObjectMethodPtr(this, _getGesture2641)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.Gesture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getGesture2641)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGesture2642; 
		public virtual void setGesture(android.gesture.Gesture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGesture2642, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGesture2642, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGesturePath2643; 
		public virtual android.graphics.Path getGesturePath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _getGesturePath2643)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getGesturePath2643)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGesturePath2644; 
		public virtual android.graphics.Path getGesturePath(android.graphics.Path arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, _getGesturePath2644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.GestureOverlayView.staticClass, _getGesturePath2644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGestureVisible2645; 
		public virtual bool isGestureVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isGestureVisible2645); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isGestureVisible2645); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGestureVisible2646; 
		public virtual void setGestureVisible(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setGestureVisible2646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setGestureVisible2646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFadeOffset2647; 
		public virtual long getFadeOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallLongMethod(this, _getFadeOffset2647); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.gesture.GestureOverlayView.staticClass, _getFadeOffset2647); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFadeOffset2648; 
		public virtual void setFadeOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _setFadeOffset2648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _setFadeOffset2648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGestureListener2649; 
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _addOnGestureListener2649, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _addOnGestureListener2649, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGestureListener2650; 
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeOnGestureListener2650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeOnGestureListener2650, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGestureListeners2651; 
		public virtual void removeAllOnGestureListeners() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeAllOnGestureListeners2651); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeAllOnGestureListeners2651); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGesturePerformedListener2652; 
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _addOnGesturePerformedListener2652, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _addOnGesturePerformedListener2652, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGesturePerformedListener2653; 
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeOnGesturePerformedListener2653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeOnGesturePerformedListener2653, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGesturePerformedListeners2654; 
		public virtual void removeAllOnGesturePerformedListeners() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeAllOnGesturePerformedListeners2654); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeAllOnGesturePerformedListeners2654); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addOnGesturingListener2655; 
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _addOnGesturingListener2655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _addOnGesturingListener2655, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGesturingListener2656; 
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeOnGesturingListener2656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeOnGesturingListener2656, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGesturingListeners2657; 
		public virtual void removeAllOnGesturingListeners() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _removeAllOnGesturingListeners2657); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _removeAllOnGesturingListeners2657); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGesturing2658; 
		public virtual bool isGesturing() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				return @__env.CallBooleanMethod(this, _isGesturing2658); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.gesture.GestureOverlayView.staticClass, _isGesturing2658); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelClearAnimation2659; 
		public virtual void cancelClearAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _cancelClearAnimation2659); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _cancelClearAnimation2659); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelGesture2660; 
		public virtual void cancelGesture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.GestureOverlayView)) 
				@__env.CallVoidMethod(this, _cancelGesture2660); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.gesture.GestureOverlayView.staticClass, _cancelGesture2660); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2661; 
		public GestureOverlayView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, _GestureOverlayView2661, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2662; 
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, _GestureOverlayView2662, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2663; 
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, _GestureOverlayView2663, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
			global::android.gesture.GestureOverlayView._clear2616 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V"); 
			global::android.gesture.GestureOverlayView._draw2617 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.gesture.GestureOverlayView._onDetachedFromWindow2618 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V"); 
			global::android.gesture.GestureOverlayView._dispatchTouchEvent2619 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.gesture.GestureOverlayView._setOrientation2620 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V"); 
			global::android.gesture.GestureOverlayView._getOrientation2621 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I"); 
			global::android.gesture.GestureOverlayView._getCurrentStroke2622 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;"); 
			global::android.gesture.GestureOverlayView._setGestureColor2623 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V"); 
			global::android.gesture.GestureOverlayView._setUncertainGestureColor2624 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V"); 
			global::android.gesture.GestureOverlayView._getUncertainGestureColor2625 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I"); 
			global::android.gesture.GestureOverlayView._getGestureColor2626 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeWidth2627 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeWidth2628 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeType2629 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeType2630 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2631 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2632 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2633 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2634 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V"); 
			global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2635 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F"); 
			global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold2636 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V"); 
			global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled2637 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z"); 
			global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled2638 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V"); 
			global::android.gesture.GestureOverlayView._isFadeEnabled2639 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z"); 
			global::android.gesture.GestureOverlayView._setFadeEnabled2640 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V"); 
			global::android.gesture.GestureOverlayView._getGesture2641 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;"); 
			global::android.gesture.GestureOverlayView._setGesture2642 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V"); 
			global::android.gesture.GestureOverlayView._getGesturePath2643 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;"); 
			global::android.gesture.GestureOverlayView._getGesturePath2644 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;"); 
			global::android.gesture.GestureOverlayView._isGestureVisible2645 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z"); 
			global::android.gesture.GestureOverlayView._setGestureVisible2646 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V"); 
			global::android.gesture.GestureOverlayView._getFadeOffset2647 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J"); 
			global::android.gesture.GestureOverlayView._setFadeOffset2648 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V"); 
			global::android.gesture.GestureOverlayView._addOnGestureListener2649 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V"); 
			global::android.gesture.GestureOverlayView._removeOnGestureListener2650 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V"); 
			global::android.gesture.GestureOverlayView._removeAllOnGestureListeners2651 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V"); 
			global::android.gesture.GestureOverlayView._addOnGesturePerformedListener2652 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V"); 
			global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener2653 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V"); 
			global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners2654 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V"); 
			global::android.gesture.GestureOverlayView._addOnGesturingListener2655 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V"); 
			global::android.gesture.GestureOverlayView._removeOnGesturingListener2656 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V"); 
			global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners2657 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V"); 
			global::android.gesture.GestureOverlayView._isGesturing2658 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z"); 
			global::android.gesture.GestureOverlayView._cancelClearAnimation2659 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V"); 
			global::android.gesture.GestureOverlayView._cancelGesture2660 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V"); 
			global::android.gesture.GestureOverlayView._GestureOverlayView2661 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.gesture.GestureOverlayView._GestureOverlayView2662 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.gesture.GestureOverlayView._GestureOverlayView2663 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
