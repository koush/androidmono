namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ScaleGestureDetector : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ScaleGestureDetector()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ScaleGestureDetector), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.ScaleGestureDetector(@__env);
			}
		}
		protected ScaleGestureDetector(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnScaleGestureListener 
		{
			bool onScale(android.view.ScaleGestureDetector arg0);
			bool onScaleBegin(android.view.ScaleGestureDetector arg0);
			void onScaleEnd(android.view.ScaleGestureDetector arg0);
		}

		public partial class OnScaleGestureListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnScaleGestureListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnScaleGestureListener : java.lang.Object, OnScaleGestureListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnScaleGestureListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ScaleGestureDetector.__OnScaleGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ScaleGestureDetector.__OnScaleGestureListener(@__env);
				}
			}
			internal __OnScaleGestureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScale8672;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScale8672, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScale8672, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScaleBegin8673;
			 bool android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScaleBegin8673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScaleBegin8673, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScaleEnd8674;
			 void android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScaleEnd8674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScaleEnd8674, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass = @__class;
				global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScale8672 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass, "android.view.ScaleGestureDetector.OnScaleGestureListener.onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScaleBegin8673 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass, "android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.__OnScaleGestureListener._onScaleEnd8674 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.__OnScaleGestureListener.staticClass, "android.view.ScaleGestureDetector.OnScaleGestureListener.onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class SimpleOnScaleGestureListener : java.lang.Object, OnScaleGestureListener
		{
			internal static global::java.lang.Class staticClass;
			static SimpleOnScaleGestureListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener(@__env);
				}
			}
			protected SimpleOnScaleGestureListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScale8675;
			public virtual bool onScale(android.view.ScaleGestureDetector arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale8675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale8675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScaleBegin8676;
			public virtual bool onScaleBegin(android.view.ScaleGestureDetector arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin8676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin8676, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onScaleEnd8677;
			public virtual void onScaleEnd(android.view.ScaleGestureDetector arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd8677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd8677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _SimpleOnScaleGestureListener8678;
			public SimpleOnScaleGestureListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener8678, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass = @__class;
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScale8675 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScale", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleBegin8676 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleBegin", "(Landroid/view/ScaleGestureDetector;)Z");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._onScaleEnd8677 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "onScaleEnd", "(Landroid/view/ScaleGestureDetector;)V");
				global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener._SimpleOnScaleGestureListener8678 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.SimpleOnScaleGestureListener.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getEventTime8679;
		public virtual long getEventTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.ScaleGestureDetector._getEventTime8679);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getEventTime8679);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onTouchEvent8680;
		public virtual bool onTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ScaleGestureDetector._onTouchEvent8680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._onTouchEvent8680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isInProgress8681;
		public virtual bool isInProgress() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ScaleGestureDetector._isInProgress8681);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._isInProgress8681);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusX8682;
		public virtual float getFocusX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.ScaleGestureDetector._getFocusX8682);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusX8682);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusY8683;
		public virtual float getFocusY() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.ScaleGestureDetector._getFocusY8683);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getFocusY8683);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentSpan8684;
		public virtual float getCurrentSpan() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.ScaleGestureDetector._getCurrentSpan8684);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getCurrentSpan8684);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPreviousSpan8685;
		public virtual float getPreviousSpan() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.ScaleGestureDetector._getPreviousSpan8685);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getPreviousSpan8685);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaleFactor8686;
		public virtual float getScaleFactor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.view.ScaleGestureDetector._getScaleFactor8686);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getScaleFactor8686);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTimeDelta8687;
		public virtual long getTimeDelta() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.view.ScaleGestureDetector._getTimeDelta8687);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._getTimeDelta8687);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScaleGestureDetector8688;
		public ScaleGestureDetector(android.content.Context arg0, android.view.ScaleGestureDetector.OnScaleGestureListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ScaleGestureDetector.staticClass, global::android.view.ScaleGestureDetector._ScaleGestureDetector8688, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ScaleGestureDetector.staticClass = @__class;
			global::android.view.ScaleGestureDetector._getEventTime8679 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getEventTime", "()J");
			global::android.view.ScaleGestureDetector._onTouchEvent8680 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ScaleGestureDetector._isInProgress8681 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "isInProgress", "()Z");
			global::android.view.ScaleGestureDetector._getFocusX8682 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getFocusX", "()F");
			global::android.view.ScaleGestureDetector._getFocusY8683 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getFocusY", "()F");
			global::android.view.ScaleGestureDetector._getCurrentSpan8684 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getCurrentSpan", "()F");
			global::android.view.ScaleGestureDetector._getPreviousSpan8685 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getPreviousSpan", "()F");
			global::android.view.ScaleGestureDetector._getScaleFactor8686 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getScaleFactor", "()F");
			global::android.view.ScaleGestureDetector._getTimeDelta8687 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "getTimeDelta", "()J");
			global::android.view.ScaleGestureDetector._ScaleGestureDetector8688 = @__env.GetMethodID(global::android.view.ScaleGestureDetector.staticClass, "<init>", "(Landroid/content/Context;Landroid/view/ScaleGestureDetector$OnScaleGestureListener;)V");
		}
	}
}
