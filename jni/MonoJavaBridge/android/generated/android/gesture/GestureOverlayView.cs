namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GestureOverlayView : android.widget.FrameLayout
	{
		internal new static global::java.lang.Class staticClass;
		static GestureOverlayView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureOverlayView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureOverlayView.__OnGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _onGestureStarted2799;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureStarted2799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureStarted2799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGesture2800;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGesture(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener._onGesture2800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, global::android.gesture.GestureOverlayView.__OnGestureListener._onGesture2800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGestureEnded2801;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureEnded2801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureEnded2801, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGestureCancelled2802;
			 void android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled(android.gesture.GestureOverlayView arg0, android.view.MotionEvent arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureCancelled2802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureCancelled2802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass = @__class;
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureStarted2799 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGestureStarted", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGesture2800 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGesture", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureEnded2801 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGestureEnded", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
				global::android.gesture.GestureOverlayView.__OnGestureListener._onGestureCancelled2802 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGestureListener.staticClass, "android.gesture.GestureOverlayView.OnGestureListener.onGestureCancelled", "(Landroid/gesture/GestureOverlayView;Landroid/view/MotionEvent;)V");
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureOverlayView.__OnGesturePerformedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _onGesturePerformed2803;
			 void android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed(android.gesture.GestureOverlayView arg0, android.gesture.Gesture arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGesturePerformedListener._onGesturePerformed2803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGesturePerformedListener.staticClass, global::android.gesture.GestureOverlayView.__OnGesturePerformedListener._onGesturePerformed2803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.gesture.GestureOverlayView.__OnGesturePerformedListener.staticClass = @__class;
				global::android.gesture.GestureOverlayView.__OnGesturePerformedListener._onGesturePerformed2803 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGesturePerformedListener.staticClass, "android.gesture.GestureOverlayView.OnGesturePerformedListener.onGesturePerformed", "(Landroid/gesture/GestureOverlayView;Landroid/gesture/Gesture;)V");
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureOverlayView.__OnGesturingListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _onGesturingStarted2804;
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted(android.gesture.GestureOverlayView arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingStarted2804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingStarted2804, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onGesturingEnded2805;
			 void android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded(android.gesture.GestureOverlayView arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingEnded2805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingEnded2805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass = @__class;
				global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingStarted2804 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, "android.gesture.GestureOverlayView.OnGesturingListener.onGesturingStarted", "(Landroid/gesture/GestureOverlayView;)V");
				global::android.gesture.GestureOverlayView.__OnGesturingListener._onGesturingEnded2805 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.__OnGesturingListener.staticClass, "android.gesture.GestureOverlayView.OnGesturingListener.onGesturingEnded", "(Landroid/gesture/GestureOverlayView;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear2806;
		public virtual void clear(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._clear2806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._clear2806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw2807;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._draw2807, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._draw2807, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDetachedFromWindow2808;
		protected override void onDetachedFromWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._onDetachedFromWindow2808);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._onDetachedFromWindow2808);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent2809;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureOverlayView._dispatchTouchEvent2809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._dispatchTouchEvent2809, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation2810;
		public virtual void setOrientation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setOrientation2810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setOrientation2810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation2811;
		public virtual int getOrientation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.GestureOverlayView._getOrientation2811);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getOrientation2811);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentStroke2812;
		public virtual global::java.util.ArrayList getCurrentStroke() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureOverlayView._getCurrentStroke2812));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getCurrentStroke2812));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureColor2813;
		public virtual void setGestureColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureColor2813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureColor2813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUncertainGestureColor2814;
		public virtual void setUncertainGestureColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setUncertainGestureColor2814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setUncertainGestureColor2814, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUncertainGestureColor2815;
		public virtual int getUncertainGestureColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.GestureOverlayView._getUncertainGestureColor2815);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getUncertainGestureColor2815);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureColor2816;
		public virtual int getGestureColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.GestureOverlayView._getGestureColor2816);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureColor2816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeWidth2817;
		public virtual float getGestureStrokeWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.gesture.GestureOverlayView._getGestureStrokeWidth2817);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeWidth2817);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeWidth2818;
		public virtual void setGestureStrokeWidth(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureStrokeWidth2818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeWidth2818, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeType2819;
		public virtual int getGestureStrokeType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.gesture.GestureOverlayView._getGestureStrokeType2819);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeType2819);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeType2820;
		public virtual void setGestureStrokeType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureStrokeType2820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeType2820, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeLengthThreshold2821;
		public virtual float getGestureStrokeLengthThreshold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2821);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2821);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeLengthThreshold2822;
		public virtual void setGestureStrokeLengthThreshold(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2822, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeSquarenessTreshold2823;
		public virtual float getGestureStrokeSquarenessTreshold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2823);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2823);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeSquarenessTreshold2824;
		public virtual void setGestureStrokeSquarenessTreshold(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGestureStrokeAngleThreshold2825;
		public virtual float getGestureStrokeAngleThreshold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2825);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2825);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureStrokeAngleThreshold2826;
		public virtual void setGestureStrokeAngleThreshold(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold2826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold2826, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEventsInterceptionEnabled2827;
		public virtual bool isEventsInterceptionEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled2827);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled2827);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEventsInterceptionEnabled2828;
		public virtual void setEventsInterceptionEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled2828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled2828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFadeEnabled2829;
		public virtual bool isFadeEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureOverlayView._isFadeEnabled2829);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isFadeEnabled2829);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFadeEnabled2830;
		public virtual void setFadeEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setFadeEnabled2830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setFadeEnabled2830, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGesture2831;
		public virtual global::android.gesture.Gesture getGesture() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.Gesture>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureOverlayView._getGesture2831));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.Gesture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesture2831));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGesture2832;
		public virtual void setGesture(android.gesture.Gesture arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGesture2832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGesture2832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGesturePath2833;
		public virtual global::android.graphics.Path getGesturePath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureOverlayView._getGesturePath2833));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesturePath2833));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getGesturePath2834;
		public virtual global::android.graphics.Path getGesturePath(android.graphics.Path arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallObjectMethodPtr(this, global::android.gesture.GestureOverlayView._getGesturePath2834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Path>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getGesturePath2834, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGestureVisible2835;
		public virtual bool isGestureVisible() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureOverlayView._isGestureVisible2835);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isGestureVisible2835);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGestureVisible2836;
		public virtual void setGestureVisible(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setGestureVisible2836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setGestureVisible2836, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFadeOffset2837;
		public virtual long getFadeOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.gesture.GestureOverlayView._getFadeOffset2837);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._getFadeOffset2837);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFadeOffset2838;
		public virtual void setFadeOffset(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._setFadeOffset2838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._setFadeOffset2838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnGestureListener2839;
		public virtual void addOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._addOnGestureListener2839, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGestureListener2839, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGestureListener2840;
		public virtual void removeOnGestureListener(android.gesture.GestureOverlayView.OnGestureListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._removeOnGestureListener2840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGestureListener2840, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGestureListeners2841;
		public virtual void removeAllOnGestureListeners() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._removeAllOnGestureListeners2841);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGestureListeners2841);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnGesturePerformedListener2842;
		public virtual void addOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._addOnGesturePerformedListener2842, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGesturePerformedListener2842, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGesturePerformedListener2843;
		public virtual void removeOnGesturePerformedListener(android.gesture.GestureOverlayView.OnGesturePerformedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener2843, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener2843, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGesturePerformedListeners2844;
		public virtual void removeAllOnGesturePerformedListeners() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners2844);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners2844);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addOnGesturingListener2845;
		public virtual void addOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._addOnGesturingListener2845, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._addOnGesturingListener2845, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeOnGesturingListener2846;
		public virtual void removeOnGesturingListener(android.gesture.GestureOverlayView.OnGesturingListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._removeOnGesturingListener2846, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeOnGesturingListener2846, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllOnGesturingListeners2847;
		public virtual void removeAllOnGesturingListeners() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners2847);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners2847);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGesturing2848;
		public virtual bool isGesturing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.gesture.GestureOverlayView._isGesturing2848);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._isGesturing2848);
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelClearAnimation2849;
		public virtual void cancelClearAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._cancelClearAnimation2849);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._cancelClearAnimation2849);
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelGesture2850;
		public virtual void cancelGesture() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.gesture.GestureOverlayView._cancelGesture2850);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._cancelGesture2850);
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2851;
		public GestureOverlayView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView2851, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2852;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView2852, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureOverlayView2853;
		public GestureOverlayView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.gesture.GestureOverlayView.staticClass, global::android.gesture.GestureOverlayView._GestureOverlayView2853, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
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
			global::android.gesture.GestureOverlayView._clear2806 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "clear", "(Z)V");
			global::android.gesture.GestureOverlayView._draw2807 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.gesture.GestureOverlayView._onDetachedFromWindow2808 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "onDetachedFromWindow", "()V");
			global::android.gesture.GestureOverlayView._dispatchTouchEvent2809 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.gesture.GestureOverlayView._setOrientation2810 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setOrientation", "(I)V");
			global::android.gesture.GestureOverlayView._getOrientation2811 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getOrientation", "()I");
			global::android.gesture.GestureOverlayView._getCurrentStroke2812 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getCurrentStroke", "()Ljava/util/ArrayList;");
			global::android.gesture.GestureOverlayView._setGestureColor2813 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureColor", "(I)V");
			global::android.gesture.GestureOverlayView._setUncertainGestureColor2814 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setUncertainGestureColor", "(I)V");
			global::android.gesture.GestureOverlayView._getUncertainGestureColor2815 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getUncertainGestureColor", "()I");
			global::android.gesture.GestureOverlayView._getGestureColor2816 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureColor", "()I");
			global::android.gesture.GestureOverlayView._getGestureStrokeWidth2817 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeWidth", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeWidth2818 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeWidth", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeType2819 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeType", "()I");
			global::android.gesture.GestureOverlayView._setGestureStrokeType2820 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeType", "(I)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeLengthThreshold2821 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeLengthThreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeLengthThreshold2822 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeLengthThreshold", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeSquarenessTreshold2823 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeSquarenessTreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeSquarenessTreshold2824 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeSquarenessTreshold", "(F)V");
			global::android.gesture.GestureOverlayView._getGestureStrokeAngleThreshold2825 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGestureStrokeAngleThreshold", "()F");
			global::android.gesture.GestureOverlayView._setGestureStrokeAngleThreshold2826 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureStrokeAngleThreshold", "(F)V");
			global::android.gesture.GestureOverlayView._isEventsInterceptionEnabled2827 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isEventsInterceptionEnabled", "()Z");
			global::android.gesture.GestureOverlayView._setEventsInterceptionEnabled2828 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setEventsInterceptionEnabled", "(Z)V");
			global::android.gesture.GestureOverlayView._isFadeEnabled2829 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isFadeEnabled", "()Z");
			global::android.gesture.GestureOverlayView._setFadeEnabled2830 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setFadeEnabled", "(Z)V");
			global::android.gesture.GestureOverlayView._getGesture2831 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesture", "()Landroid/gesture/Gesture;");
			global::android.gesture.GestureOverlayView._setGesture2832 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGesture", "(Landroid/gesture/Gesture;)V");
			global::android.gesture.GestureOverlayView._getGesturePath2833 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "()Landroid/graphics/Path;");
			global::android.gesture.GestureOverlayView._getGesturePath2834 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getGesturePath", "(Landroid/graphics/Path;)Landroid/graphics/Path;");
			global::android.gesture.GestureOverlayView._isGestureVisible2835 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isGestureVisible", "()Z");
			global::android.gesture.GestureOverlayView._setGestureVisible2836 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setGestureVisible", "(Z)V");
			global::android.gesture.GestureOverlayView._getFadeOffset2837 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "getFadeOffset", "()J");
			global::android.gesture.GestureOverlayView._setFadeOffset2838 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "setFadeOffset", "(J)V");
			global::android.gesture.GestureOverlayView._addOnGestureListener2839 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGestureListener2840 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGestureListener", "(Landroid/gesture/GestureOverlayView$OnGestureListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGestureListeners2841 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGestureListeners", "()V");
			global::android.gesture.GestureOverlayView._addOnGesturePerformedListener2842 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGesturePerformedListener2843 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturePerformedListener", "(Landroid/gesture/GestureOverlayView$OnGesturePerformedListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGesturePerformedListeners2844 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturePerformedListeners", "()V");
			global::android.gesture.GestureOverlayView._addOnGesturingListener2845 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "addOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V");
			global::android.gesture.GestureOverlayView._removeOnGesturingListener2846 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeOnGesturingListener", "(Landroid/gesture/GestureOverlayView$OnGesturingListener;)V");
			global::android.gesture.GestureOverlayView._removeAllOnGesturingListeners2847 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "removeAllOnGesturingListeners", "()V");
			global::android.gesture.GestureOverlayView._isGesturing2848 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "isGesturing", "()Z");
			global::android.gesture.GestureOverlayView._cancelClearAnimation2849 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "cancelClearAnimation", "()V");
			global::android.gesture.GestureOverlayView._cancelGesture2850 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "cancelGesture", "()V");
			global::android.gesture.GestureOverlayView._GestureOverlayView2851 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.gesture.GestureOverlayView._GestureOverlayView2852 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.gesture.GestureOverlayView._GestureOverlayView2853 = @__env.GetMethodID(global::android.gesture.GestureOverlayView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
