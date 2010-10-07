namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class ViewGroup : android.view.View, ViewParent, ViewManager
	{
		internal new static global::java.lang.Class staticClass;
		static ViewGroup()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected ViewGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class LayoutParams : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static LayoutParams()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewGroup.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewGroup.LayoutParams(@__env);
				}
			}
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes9175;
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.LayoutParams._setBaseAttributes9175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._setBaseAttributes9175, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9176;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams9176, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9177;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams9177, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9178;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams9178, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			public static int FILL_PARENT
			{
				get
				{
					return -1;
				}
			}
			public static int MATCH_PARENT
			{
				get
				{
					return -1;
				}
			}
			public static int WRAP_CONTENT
			{
				get
				{
					return -2;
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _width9179;
			public int width
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _height9180;
			public int height
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _layoutAnimationParameters9181;
			public global::android.view.animation.LayoutAnimationController.AnimationParameters layoutAnimationParameters
			{
				get
				{
					return default(global::android.view.animation.LayoutAnimationController.AnimationParameters);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewGroup.LayoutParams.staticClass = @__class;
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes9175 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams9176 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams9177 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.LayoutParams._LayoutParams9178 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class MarginLayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::java.lang.Class staticClass;
			static MarginLayoutParams()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewGroup.MarginLayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewGroup.MarginLayoutParams(@__env);
				}
			}
			protected MarginLayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _setMargins9182;
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.MarginLayoutParams._setMargins9182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._setMargins9182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams9183;
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9183, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams9184;
			public MarginLayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9184, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams9185;
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9185, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams9186;
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9186, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _leftMargin9187;
			public int leftMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _topMargin9188;
			public int topMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _rightMargin9189;
			public int rightMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _bottomMargin9190;
			public int bottomMargin
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewGroup.MarginLayoutParams.staticClass = @__class;
				global::android.view.ViewGroup.MarginLayoutParams._setMargins9182 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9183 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9184 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9185 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams9186 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnHierarchyChangeListener 
		{
			void onChildViewAdded(android.view.View arg0, android.view.View arg1);
			void onChildViewRemoved(android.view.View arg0, android.view.View arg1);
		}

		public partial class OnHierarchyChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnHierarchyChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnHierarchyChangeListener : java.lang.Object, OnHierarchyChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnHierarchyChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewGroup.__OnHierarchyChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewGroup.__OnHierarchyChangeListener(@__env);
				}
			}
			internal __OnHierarchyChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onChildViewAdded9191;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewAdded9191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewAdded9191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onChildViewRemoved9192;
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewRemoved9192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewRemoved9192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass = @__class;
				global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewAdded9191 = @__env.GetMethodID(global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, "android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
				global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewRemoved9192 = @__env.GetMethodID(global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, "android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _debug9193;
		protected virtual void debug(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._debug9193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._debug9193, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addStatesFromChildren9194;
		public virtual bool addStatesFromChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._addStatesFromChildren9194);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addStatesFromChildren9194);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus9195;
		public override bool hasFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._hasFocus9195);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocus9195);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent9196;
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchKeyEvent9196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEvent9196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent9197;
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchTouchEvent9197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTouchEvent9197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent9198;
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchTrackballEvent9198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTrackballEvent9198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9199;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent9199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent9199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView9200;
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView9200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView9201;
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView9201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView9202;
		public virtual void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView9202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9202, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView9203;
		public virtual void addView(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView9203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9203, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView9204;
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView9204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView9204, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateViewLayout9205;
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._updateViewLayout9205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._updateViewLayout9205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeView9206;
		public virtual void removeView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeView9206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeView9206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearFocus9207;
		public override void clearFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._clearFocus9207);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearFocus9207);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFocusable9208;
		public override bool hasFocusable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._hasFocusable9208);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocusable9208);
		}
		internal static global::net.sf.jni4net.jni.MethodId _findFocus9209;
		public override global::android.view.View findFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._findFocus9209));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._findFocus9209));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fitSystemWindows9210;
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._fitSystemWindows9210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._fitSystemWindows9210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed9211;
		protected override void dispatchSetPressed(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchSetPressed9211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetPressed9211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch9212;
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._focusSearch9212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusSearch9212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove9213;
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchUnhandledMove9213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchUnhandledMove9213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables9214;
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addFocusables9214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables9214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables9215;
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addFocusables9215, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables9215, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables9216;
		public override void addTouchables(java.util.ArrayList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addTouchables9216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addTouchables9216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus9217;
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._requestFocus9217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestFocus9217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEventPreIme9218;
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchKeyEventPreIme9218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEventPreIme9218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyShortcutEvent9219;
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchKeyShortcutEvent9219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyShortcutEvent9219, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged9220;
		public override void dispatchWindowFocusChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchWindowFocusChanged9220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowFocusChanged9220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchVisibilityChanged9221;
		protected override void dispatchVisibilityChanged(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchVisibilityChanged9221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchVisibilityChanged9221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDisplayHint9222;
		public override void dispatchDisplayHint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchDisplayHint9222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDisplayHint9222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowVisibilityChanged9223;
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchWindowVisibilityChanged9223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowVisibilityChanged9223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchConfigurationChanged9224;
		public override void dispatchConfigurationChanged(android.content.res.Configuration arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchConfigurationChanged9224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchConfigurationChanged9224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw9225;
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchDraw9225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDraw9225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState9226;
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchSaveInstanceState9226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSaveInstanceState9226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState9227;
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchRestoreInstanceState9227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchRestoreInstanceState9227, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9228;
		protected abstract new void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4);
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9229;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._drawableStateChanged9229);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawableStateChanged9229);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9230;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._onCreateDrawableState9230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onCreateDrawableState9230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPadding9231;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setPadding9231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPadding9231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected9232;
		public virtual new void dispatchSetSelected(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchSetSelected9232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetSelected9232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart9233;
		protected override void onAnimationStart() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._onAnimationStart9233);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationStart9233);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd9234;
		protected override void onAnimationEnd() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._onAnimationEnd9234);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationEnd9234);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDescendantFocusability9235;
		public virtual int getDescendantFocusability() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getDescendantFocusability9235);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getDescendantFocusability9235);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDescendantFocusability9236;
		public virtual void setDescendantFocusability(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setDescendantFocusability9236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setDescendantFocusability9236, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus9237;
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._requestChildFocus9237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildFocus9237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _focusableViewAvailable9238;
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._focusableViewAvailable9238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusableViewAvailable9238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild9239;
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._showContextMenuForChild9239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._showContextMenuForChild9239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen9240;
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._requestChildRectangleOnScreen9240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildRectangleOnScreen9240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearChildFocus9241;
		public virtual void clearChildFocus(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._clearChildFocus9241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearChildFocus9241, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedChild9242;
		public virtual global::android.view.View getFocusedChild() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getFocusedChild9242));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getFocusedChild9242));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recomputeViewAttributes9243;
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._recomputeViewAttributes9243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._recomputeViewAttributes9243, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bringChildToFront9244;
		public virtual void bringChildToFront(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._bringChildToFront9244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._bringChildToFront9244, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestDisallowInterceptTouchEvent9245;
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent9245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent9245, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent9246;
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._onInterceptTouchEvent9246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onInterceptTouchEvent9246, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants9247;
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._onRequestFocusInDescendants9247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onRequestFocusInDescendants9247, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchFreezeSelfOnly9248;
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchFreezeSelfOnly9248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchFreezeSelfOnly9248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchThawSelfOnly9249;
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchThawSelfOnly9249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchThawSelfOnly9249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawingCacheEnabled9250;
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled9250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled9250, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder9251;
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getChildDrawingOrder9251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildDrawingOrder9251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawChild9252;
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._drawChild9252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawChild9252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClipChildren9253;
		public virtual void setClipChildren(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setClipChildren9253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipChildren9253, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClipToPadding9254;
		public virtual void setClipToPadding(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setClipToPadding9254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipToPadding9254, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStaticTransformationsEnabled9255;
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setStaticTransformationsEnabled9255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setStaticTransformationsEnabled9255, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildStaticTransformation9256;
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._getChildStaticTransformation9256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildStaticTransformation9256, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9257;
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._checkLayoutParams9257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._checkLayoutParams9257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener9258;
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setOnHierarchyChangeListener9258, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setOnHierarchyChangeListener9258, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addViewInLayout9259;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._addViewInLayout9259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout9259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addViewInLayout9260;
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._addViewInLayout9260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout9260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cleanupLayoutState9261;
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._cleanupLayoutState9261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._cleanupLayoutState9261, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachLayoutAnimationParameters9262;
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._attachLayoutAnimationParameters9262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachLayoutAnimationParameters9262, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewInLayout9263;
		public virtual void removeViewInLayout(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViewInLayout9263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewInLayout9263, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewsInLayout9264;
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViewsInLayout9264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewsInLayout9264, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt9265;
		public virtual void removeViewAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViewAt9265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewAt9265, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeViews9266;
		public virtual void removeViews(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViews9266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViews9266, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews9267;
		public virtual void removeAllViews() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeAllViews9267);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViews9267);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViewsInLayout9268;
		public virtual void removeAllViewsInLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeAllViewsInLayout9268);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViewsInLayout9268);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeDetachedView9269;
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeDetachedView9269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeDetachedView9269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachViewToParent9270;
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._attachViewToParent9270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachViewToParent9270, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _detachViewFromParent9271;
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachViewFromParent9271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent9271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _detachViewFromParent9272;
		protected virtual void detachViewFromParent(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachViewFromParent9272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent9272, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _detachViewsFromParent9273;
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachViewsFromParent9273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewsFromParent9273, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _detachAllViewsFromParent9274;
		protected virtual void detachAllViewsFromParent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachAllViewsFromParent9274);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachAllViewsFromParent9274);
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChild9275;
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._invalidateChild9275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChild9275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChildInParent9276;
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._invalidateChildInParent9276, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChildInParent9276, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetDescendantRectToMyCoords9277;
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._offsetDescendantRectToMyCoords9277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetDescendantRectToMyCoords9277, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _offsetRectIntoDescendantCoords9278;
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._offsetRectIntoDescendantCoords9278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetRectIntoDescendantCoords9278, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildVisibleRect9279;
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._getChildVisibleRect9279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildVisibleRect9279, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate9280;
		protected virtual bool canAnimate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._canAnimate9280);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._canAnimate9280);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startLayoutAnimation9281;
		public virtual void startLayoutAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._startLayoutAnimation9281);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._startLayoutAnimation9281);
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleLayoutAnimation9282;
		public virtual void scheduleLayoutAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._scheduleLayoutAnimation9282);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._scheduleLayoutAnimation9282);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAnimation9283;
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setLayoutAnimation9283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimation9283, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAnimation9284;
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getLayoutAnimation9284));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimation9284));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAnimationCacheEnabled9285;
		public virtual bool isAnimationCacheEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isAnimationCacheEnabled9285);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAnimationCacheEnabled9285);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationCacheEnabled9286;
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setAnimationCacheEnabled9286, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAnimationCacheEnabled9286, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAlwaysDrawnWithCacheEnabled9287;
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled9287);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled9287);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlwaysDrawnWithCacheEnabled9288;
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled9288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled9288, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChildrenDrawnWithCacheEnabled9289;
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled9289);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled9289);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawnWithCacheEnabled9290;
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled9290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled9290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChildrenDrawingOrderEnabled9291;
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled9291);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled9291);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawingOrderEnabled9292;
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled9292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled9292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPersistentDrawingCache9293;
		public virtual int getPersistentDrawingCache() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getPersistentDrawingCache9293);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getPersistentDrawingCache9293);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPersistentDrawingCache9294;
		public virtual void setPersistentDrawingCache(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setPersistentDrawingCache9294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPersistentDrawingCache9294, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9295;
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._generateLayoutParams9295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams9295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9296;
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._generateLayoutParams9296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams9296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9297;
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._generateDefaultLayoutParams9297));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateDefaultLayoutParams9297));
		}
		internal static global::net.sf.jni4net.jni.MethodId _indexOfChild9298;
		public virtual int indexOfChild(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._indexOfChild9298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._indexOfChild9298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildCount9299;
		public virtual int getChildCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getChildCount9299);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildCount9299);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildAt9300;
		public virtual global::android.view.View getChildAt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getChildAt9300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildAt9300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChildren9301;
		protected virtual void measureChildren(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._measureChildren9301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildren9301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChild9302;
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._measureChild9302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChild9302, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins9303;
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._measureChildWithMargins9303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildWithMargins9303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChildMeasureSpec9304;
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildMeasureSpec9304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearDisappearingChildren9305;
		public virtual void clearDisappearingChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._clearDisappearingChildren9305);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearDisappearingChildren9305);
		}
		internal static global::net.sf.jni4net.jni.MethodId _gatherTransparentRegion9306;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._gatherTransparentRegion9306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._gatherTransparentRegion9306, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestTransparentRegion9307;
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._requestTransparentRegion9307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestTransparentRegion9307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAnimationListener9308;
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Animation.AnimationListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getLayoutAnimationListener9308));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Animation.AnimationListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimationListener9308));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAddStatesFromChildren9309;
		public virtual void setAddStatesFromChildren(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setAddStatesFromChildren9309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAddStatesFromChildren9309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _childDrawableStateChanged9310;
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._childDrawableStateChanged9310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._childDrawableStateChanged9310, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAnimationListener9311;
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setLayoutAnimationListener9311, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimationListener9311, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup9312;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup9312, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup9313;
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup9313, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup9314;
		public ViewGroup(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup9314, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int FOCUS_BEFORE_DESCENDANTS
		{
			get
			{
				return 131072;
			}
		}
		public static int FOCUS_AFTER_DESCENDANTS
		{
			get
			{
				return 262144;
			}
		}
		public static int FOCUS_BLOCK_DESCENDANTS
		{
			get
			{
				return 393216;
			}
		}
		public static int PERSISTENT_NO_CACHE
		{
			get
			{
				return 0;
			}
		}
		public static int PERSISTENT_ANIMATION_CACHE
		{
			get
			{
				return 1;
			}
		}
		public static int PERSISTENT_SCROLLING_CACHE
		{
			get
			{
				return 2;
			}
		}
		public static int PERSISTENT_ALL_CACHES
		{
			get
			{
				return 3;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ViewGroup.staticClass = @__class;
			global::android.view.ViewGroup._debug9193 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "debug", "(I)V");
			global::android.view.ViewGroup._addStatesFromChildren9194 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z");
			global::android.view.ViewGroup._hasFocus9195 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z");
			global::android.view.ViewGroup._dispatchKeyEvent9196 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchTouchEvent9197 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchTrackballEvent9198 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent9199 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.view.ViewGroup._addView9200 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._addView9201 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._addView9202 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._addView9203 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._addView9204 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._updateViewLayout9205 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._removeView9206 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._clearFocus9207 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearFocus", "()V");
			global::android.view.ViewGroup._hasFocusable9208 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z");
			global::android.view.ViewGroup._findFocus9209 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;");
			global::android.view.ViewGroup._fitSystemWindows9210 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchSetPressed9211 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V");
			global::android.view.ViewGroup._focusSearch9212 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			global::android.view.ViewGroup._dispatchUnhandledMove9213 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z");
			global::android.view.ViewGroup._addFocusables9214 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V");
			global::android.view.ViewGroup._addFocusables9215 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V");
			global::android.view.ViewGroup._addTouchables9216 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V");
			global::android.view.ViewGroup._requestFocus9217 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchKeyEventPreIme9218 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchKeyShortcutEvent9219 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z");
			global::android.view.ViewGroup._dispatchWindowFocusChanged9220 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V");
			global::android.view.ViewGroup._dispatchVisibilityChanged9221 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchVisibilityChanged", "(Landroid/view/View;I)V");
			global::android.view.ViewGroup._dispatchDisplayHint9222 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchDisplayHint", "(I)V");
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged9223 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V");
			global::android.view.ViewGroup._dispatchConfigurationChanged9224 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			global::android.view.ViewGroup._dispatchDraw9225 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			global::android.view.ViewGroup._dispatchSaveInstanceState9226 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchRestoreInstanceState9227 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._onLayout9228 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V");
			global::android.view.ViewGroup._drawableStateChanged9229 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V");
			global::android.view.ViewGroup._onCreateDrawableState9230 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.view.ViewGroup._setPadding9231 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V");
			global::android.view.ViewGroup._dispatchSetSelected9232 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V");
			global::android.view.ViewGroup._onAnimationStart9233 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V");
			global::android.view.ViewGroup._onAnimationEnd9234 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V");
			global::android.view.ViewGroup._getDescendantFocusability9235 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I");
			global::android.view.ViewGroup._setDescendantFocusability9236 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V");
			global::android.view.ViewGroup._requestChildFocus9237 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			global::android.view.ViewGroup._focusableViewAvailable9238 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._showContextMenuForChild9239 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z");
			global::android.view.ViewGroup._requestChildRectangleOnScreen9240 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			global::android.view.ViewGroup._clearChildFocus9241 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getFocusedChild9242 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;");
			global::android.view.ViewGroup._recomputeViewAttributes9243 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._bringChildToFront9244 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent9245 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V");
			global::android.view.ViewGroup._onInterceptTouchEvent9246 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z");
			global::android.view.ViewGroup._onRequestFocusInDescendants9247 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z");
			global::android.view.ViewGroup._dispatchFreezeSelfOnly9248 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._dispatchThawSelfOnly9249 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V");
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled9250 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildDrawingOrder9251 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I");
			global::android.view.ViewGroup._drawChild9252 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z");
			global::android.view.ViewGroup._setClipChildren9253 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V");
			global::android.view.ViewGroup._setClipToPadding9254 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V");
			global::android.view.ViewGroup._setStaticTransformationsEnabled9255 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V");
			global::android.view.ViewGroup._getChildStaticTransformation9256 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z");
			global::android.view.ViewGroup._checkLayoutParams9257 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._setOnHierarchyChangeListener9258 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.view.ViewGroup._addViewInLayout9259 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z");
			global::android.view.ViewGroup._addViewInLayout9260 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z");
			global::android.view.ViewGroup._cleanupLayoutState9261 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._attachLayoutAnimationParameters9262 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.view.ViewGroup._removeViewInLayout9263 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._removeViewsInLayout9264 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V");
			global::android.view.ViewGroup._removeViewAt9265 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V");
			global::android.view.ViewGroup._removeViews9266 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V");
			global::android.view.ViewGroup._removeAllViews9267 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V");
			global::android.view.ViewGroup._removeAllViewsInLayout9268 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V");
			global::android.view.ViewGroup._removeDetachedView9269 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V");
			global::android.view.ViewGroup._attachViewToParent9270 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.view.ViewGroup._detachViewFromParent9271 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._detachViewFromParent9272 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V");
			global::android.view.ViewGroup._detachViewsFromParent9273 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V");
			global::android.view.ViewGroup._detachAllViewsFromParent9274 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V");
			global::android.view.ViewGroup._invalidateChild9275 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._invalidateChildInParent9276 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords9277 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords9278 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			global::android.view.ViewGroup._getChildVisibleRect9279 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			global::android.view.ViewGroup._canAnimate9280 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z");
			global::android.view.ViewGroup._startLayoutAnimation9281 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V");
			global::android.view.ViewGroup._scheduleLayoutAnimation9282 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V");
			global::android.view.ViewGroup._setLayoutAnimation9283 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V");
			global::android.view.ViewGroup._getLayoutAnimation9284 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;");
			global::android.view.ViewGroup._isAnimationCacheEnabled9285 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAnimationCacheEnabled9286 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled9287 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled9288 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled9289 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled9290 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V");
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled9291 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z");
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled9292 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V");
			global::android.view.ViewGroup._getPersistentDrawingCache9293 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I");
			global::android.view.ViewGroup._setPersistentDrawingCache9294 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V");
			global::android.view.ViewGroup._generateLayoutParams9295 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateLayoutParams9296 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._generateDefaultLayoutParams9297 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.view.ViewGroup._indexOfChild9298 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I");
			global::android.view.ViewGroup._getChildCount9299 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildCount", "()I");
			global::android.view.ViewGroup._getChildAt9300 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;");
			global::android.view.ViewGroup._measureChildren9301 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V");
			global::android.view.ViewGroup._measureChild9302 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V");
			global::android.view.ViewGroup._measureChildWithMargins9303 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V");
			global::android.view.ViewGroup._getChildMeasureSpec9304 = @__env.GetStaticMethodID(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I");
			global::android.view.ViewGroup._clearDisappearingChildren9305 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V");
			global::android.view.ViewGroup._gatherTransparentRegion9306 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z");
			global::android.view.ViewGroup._requestTransparentRegion9307 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._getLayoutAnimationListener9308 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;");
			global::android.view.ViewGroup._setAddStatesFromChildren9309 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V");
			global::android.view.ViewGroup._childDrawableStateChanged9310 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V");
			global::android.view.ViewGroup._setLayoutAnimationListener9311 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V");
			global::android.view.ViewGroup._ViewGroup9312 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.view.ViewGroup._ViewGroup9313 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.view.ViewGroup._ViewGroup9314 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
