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
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapConfirmed8424;
			 bool android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener._onSingleTapConfirmed8424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, global::android.view.GestureDetector.__OnDoubleTapListener._onSingleTapConfirmed8424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTap8425;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTap8425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTap8425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTapEvent8426;
			 bool android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTapEvent8426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTapEvent8426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.GestureDetector.__OnDoubleTapListener.staticClass = @__class;
				global::android.view.GestureDetector.__OnDoubleTapListener._onSingleTapConfirmed8424 = @__env.GetMethodID(global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, "android.view.GestureDetector.OnDoubleTapListener.onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTap8425 = @__env.GetMethodID(global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, "android.view.GestureDetector.OnDoubleTapListener.onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.__OnDoubleTapListener._onDoubleTapEvent8426 = @__env.GetMethodID(global::android.view.GestureDetector.__OnDoubleTapListener.staticClass, "android.view.GestureDetector.OnDoubleTapListener.onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
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
			internal static global::net.sf.jni4net.jni.MethodId _onLongPress8427;
			 void android.view.GestureDetector.OnGestureListener.onLongPress(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener._onLongPress8427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onLongPress8427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp8428;
			 bool android.view.GestureDetector.OnGestureListener.onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onSingleTapUp8428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onSingleTapUp8428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScroll8429;
			 bool android.view.GestureDetector.OnGestureListener.onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onScroll8429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onScroll8429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onFling8430;
			 bool android.view.GestureDetector.OnGestureListener.onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onFling8430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onFling8430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onShowPress8431;
			 void android.view.GestureDetector.OnGestureListener.onShowPress(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener._onShowPress8431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onShowPress8431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDown8432;
			 bool android.view.GestureDetector.OnGestureListener.onDown(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener._onDown8432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.__OnGestureListener.staticClass, global::android.view.GestureDetector.__OnGestureListener._onDown8432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.GestureDetector.__OnGestureListener.staticClass = @__class;
				global::android.view.GestureDetector.__OnGestureListener._onLongPress8427 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.__OnGestureListener._onSingleTapUp8428 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.__OnGestureListener._onScroll8429 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.__OnGestureListener._onFling8430 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.__OnGestureListener._onShowPress8431 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.__OnGestureListener._onDown8432 = @__env.GetMethodID(global::android.view.GestureDetector.__OnGestureListener.staticClass, "android.view.GestureDetector.OnGestureListener.onDown", "(Landroid/view/MotionEvent;)Z");
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
			internal static global::net.sf.jni4net.jni.MethodId _onLongPress8433;
			public virtual void onLongPress(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress8433, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress8433, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapConfirmed8434;
			public virtual bool onSingleTapConfirmed(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed8434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed8434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTap8435;
			public virtual bool onDoubleTap(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap8435, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap8435, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDoubleTapEvent8436;
			public virtual bool onDoubleTapEvent(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent8436, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent8436, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onSingleTapUp8437;
			public virtual bool onSingleTapUp(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp8437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp8437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScroll8438;
			public virtual bool onScroll(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll8438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onScroll8438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onFling8439;
			public virtual bool onFling(android.view.MotionEvent arg0, android.view.MotionEvent arg1, float arg2, float arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onFling8439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onFling8439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onShowPress8440;
			public virtual void onShowPress(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress8440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress8440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onDown8441;
			public virtual bool onDown(android.view.MotionEvent arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener._onDown8441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._onDown8441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SimpleOnGestureListener8442;
			public SimpleOnGestureListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.GestureDetector.SimpleOnGestureListener.staticClass, global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener8442, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.GestureDetector.SimpleOnGestureListener.staticClass = @__class;
				global::android.view.GestureDetector.SimpleOnGestureListener._onLongPress8433 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onLongPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapConfirmed8434 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTap8435 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDoubleTapEvent8436 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onSingleTapUp8437 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onScroll8438 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onFling8439 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._onShowPress8440 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onShowPress", "(Landroid/view/MotionEvent;)V");
				global::android.view.GestureDetector.SimpleOnGestureListener._onDown8441 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "onDown", "(Landroid/view/MotionEvent;)Z");
				global::android.view.GestureDetector.SimpleOnGestureListener._SimpleOnGestureListener8442 = @__env.GetMethodID(global::android.view.GestureDetector.SimpleOnGestureListener.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8443;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.GestureDetector._onTouchEvent8443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._onTouchEvent8443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnDoubleTapListener8444;
		public virtual void setOnDoubleTapListener(android.view.GestureDetector.OnDoubleTapListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.GestureDetector._setOnDoubleTapListener8444, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setOnDoubleTapListener8444, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIsLongpressEnabled8445;
		public virtual void setIsLongpressEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.GestureDetector._setIsLongpressEnabled8445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._setIsLongpressEnabled8445, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLongpressEnabled8446;
		public virtual bool isLongpressEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.GestureDetector._isLongpressEnabled8446);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.GestureDetector.staticClass, global::android.view.GestureDetector._isLongpressEnabled8446);
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector8447;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0, android.os.Handler arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8447, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector8448;
		public GestureDetector(android.view.GestureDetector.OnGestureListener arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8448, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector8449;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8449, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector8450;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GestureDetector8451;
		public GestureDetector(android.content.Context arg0, android.view.GestureDetector.OnGestureListener arg1, android.os.Handler arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.GestureDetector.staticClass, global::android.view.GestureDetector._GestureDetector8451, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.GestureDetector.staticClass = @__class;
			global::android.view.GestureDetector._onTouchEvent8443 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.GestureDetector._setOnDoubleTapListener8444 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			global::android.view.GestureDetector._setIsLongpressEnabled8445 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "setIsLongpressEnabled", "(Z)V");
			global::android.view.GestureDetector._isLongpressEnabled8446 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "isLongpressEnabled", "()Z");
			global::android.view.GestureDetector._GestureDetector8447 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector8448 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector8449 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;)V");
			global::android.view.GestureDetector._GestureDetector8450 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;)V");
			global::android.view.GestureDetector._GestureDetector8451 = @__env.GetMethodID(global::android.view.GestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/GestureDetector$OnGestureListener;Landroid/os/Handler;Z)V");
		}
	}
}
