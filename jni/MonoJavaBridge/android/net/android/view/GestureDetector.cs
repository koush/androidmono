namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GestureDetector : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GestureDetector() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.GestureDetector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.GestureDetector(@__env); 
			} 
		} 
		protected GestureDetector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnDoubleTapListener 
		{ 
			bool onSingleTapConfirmed(android.view.MotionEvent arg0); 
			bool onDoubleTap(android.view.MotionEvent arg0); 
			bool onDoubleTapEvent(android.view.MotionEvent arg0); 
		} 

		public partial class OnDoubleTapListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnDoubleTapListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnDoubleTapListener : java.lang.Object, OnDoubleTapListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnDoubleTapListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.GestureDetector.__OnDoubleTapListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.GestureDetector.__OnDoubleTapListener(@__env); 
				} 
			} 
			internal __OnDoubleTapListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapConfirmed7749; 
			 bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnDoubleTapListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener._onSingleTapConfirmed7749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, global::android.view.GestureDetector.__OnDoubleTapListener._onSingleTapConfirmed7749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTap7750; 
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnDoubleTapListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTap7750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTap7750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTapEvent7751; 
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnDoubleTapListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTapEvent7751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTapEvent7751, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.GestureDetector.__OnDoubleTapListener.staticClass = @__class; 
				global::android.view.GestureDetector.__OnDoubleTapListener._onSingleTapConfirmed7749 = @__env.GetMethodID(global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, "android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTap7750 = @__env.GetMethodID(global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, "android.view.GestureDetector.OnDoubleTapListener.onDoubleTap", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTapEvent7751 = @__env.GetMethodID(global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, "android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnGestureListener 
		{ 
			void onLongPress(android.view.MotionEvent arg0); 
			bool onSingleTapUp(android.view.MotionEvent arg0); 
			bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3); 
			bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3); 
			void onShowPress(android.view.MotionEvent arg0); 
			bool onDown(android.view.MotionEvent arg0); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.GestureDetector.__OnGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.GestureDetector.__OnGestureListener(@__env); 
				} 
			} 
			internal __OnGestureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onLongPress7752; 
			 void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnGestureListener)) 
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener._onLongPress7752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onLongPress7752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp7753; 
			 bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onSingleTapUp7753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onSingleTapUp7753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onScroll7754; 
			 bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onScroll7754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onScroll7754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onFling7755; 
			 bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onFling7755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onFling7755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onShowPress7756; 
			 void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnGestureListener)) 
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener._onShowPress7756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onShowPress7756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDown7757; 
			 bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.__OnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onDown7757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onDown7757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.GestureDetector.__OnGestureListener.staticClass = @__class; 
				global::android.view.GestureDetector.__OnGestureListener._onLongPress7752 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onLongPress", "(Landroid/view/MotionEvent;)V"); 
				global::android.view.GestureDetector.__OnGestureListener._onSingleTapUp7753 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onSingleTapUp", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.__OnGestureListener._onScroll7754 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
				global::android.view.GestureDetector.__OnGestureListener._onFling7755 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
				global::android.view.GestureDetector.__OnGestureListener._onShowPress7756 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onShowPress", "(Landroid/view/MotionEvent;)V"); 
				global::android.view.GestureDetector.__OnGestureListener._onDown7757 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onDown", "(Landroid/view/MotionEvent;)Z"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class SimpleOnGestureListener : java.lang.Object, OnGestureListener, OnDoubleTapListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static SimpleOnGestureListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.GestureDetector.SimpleOnGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.GestureDetector.SimpleOnGestureListener(@__env); 
				} 
			} 
			protected SimpleOnGestureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onLongPress7758; 
			public virtual void onLongPress(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress7758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress7758, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapConfirmed7759; 
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed7759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed7759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTap7760; 
			public virtual bool onDoubleTap(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap7760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap7760, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTapEvent7761; 
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent7761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent7761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp7762; 
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp7762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp7762, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onScroll7763; 
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll7763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll7763, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onFling7764; 
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onFling7764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onFling7764, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onShowPress7765; 
			public virtual void onShowPress(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress7765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress7765, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onDown7766; 
			public virtual bool onDown(android.view.MotionEvent arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.GestureDetector.SimpleOnGestureListener)) 
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onDown7766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDown7766, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SimpleOnGestureListener7767; 
			public SimpleOnGestureListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener7767, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__class; 
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress7758 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed7759 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap7760 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent7761 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp7762 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll7763 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling7764 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress7765 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown7766 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z"); 
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener7767 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent7768; 
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				return @__env.CallBooleanMethod(this, global::android.view.GestureDetector._onTouchEvent7768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._onTouchEvent7768, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnDoubleTapListener7769; 
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				@__env.CallVoidMethod(this, global::android.view.GestureDetector._setOnDoubleTapListener7769, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setOnDoubleTapListener7769, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIsLongpressEnabled7770; 
		public virtual void setIsLongpressEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				@__env.CallVoidMethod(this, global::android.view.GestureDetector._setIsLongpressEnabled7770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setIsLongpressEnabled7770, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLongpressEnabled7771; 
		public virtual bool isLongpressEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.GestureDetector)) 
				return @__env.CallBooleanMethod(this, global::android.view.GestureDetector._isLongpressEnabled7771); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._isLongpressEnabled7771); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7772; 
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector7772, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7773; 
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector7773, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7774; 
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector7774, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector7775; 
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector7775, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.GestureDetector.staticClass = @__class; 
			global::android.view.GestureDetector._onTouchEvent7768 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.GestureDetector._setOnDoubleTapListener7769 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V"); 
			global::android.view.GestureDetector._setIsLongpressEnabled7770 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V"); 
			global::android.view.GestureDetector._isLongpressEnabled7771 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z"); 
			global::android.view.GestureDetector._GestureDetector7772 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V"); 
			global::android.view.GestureDetector._GestureDetector7773 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V"); 
			global::android.view.GestureDetector._GestureDetector7774 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V"); 
			global::android.view.GestureDetector._GestureDetector7775 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V"); 
		} 
	} 
} 
