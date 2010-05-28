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
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes8473; 
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewGroup.LayoutParams)) 
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.LayoutParams._setBaseAttributes8473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._setBaseAttributes8473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8474; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams8474, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8475; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams8475, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams8476; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, global::android.view.ViewGroup.LayoutParams._LayoutParams8476, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			public static int FILL_PARENT
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
			internal static global::net.sf.jni4net.jni.FieldId _width8477; 
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
			internal static global::net.sf.jni4net.jni.FieldId _height8478; 
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
			internal static global::net.sf.jni4net.jni.FieldId _layoutAnimationParameters8479; 
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
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes8473 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V"); 
				global::android.view.ViewGroup.LayoutParams._LayoutParams8474 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.view.ViewGroup.LayoutParams._LayoutParams8475 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.view.ViewGroup.LayoutParams._LayoutParams8476 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _setMargins8480; 
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewGroup.MarginLayoutParams)) 
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.MarginLayoutParams._setMargins8480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._setMargins8480, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams8481; 
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8481, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams8482; 
			public MarginLayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8482, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams8483; 
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8483, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams8484; 
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8484, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _leftMargin8485; 
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
			internal static global::net.sf.jni4net.jni.FieldId _topMargin8486; 
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
			internal static global::net.sf.jni4net.jni.FieldId _rightMargin8487; 
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
			internal static global::net.sf.jni4net.jni.FieldId _bottomMargin8488; 
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
				global::android.view.ViewGroup.MarginLayoutParams._setMargins8480 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8481 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8482 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8483 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams8484 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onChildViewAdded8489; 
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded(android.view.View arg0, android.view.View arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewGroup.__OnHierarchyChangeListener)) 
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewAdded8489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewAdded8489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onChildViewRemoved8490; 
			 void android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved(android.view.View arg0, android.view.View arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewGroup.__OnHierarchyChangeListener)) 
					@__env.CallVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewRemoved8490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewRemoved8490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass = @__class; 
				global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewAdded8489 = @__env.GetMethodID(global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, "android.view.ViewGroup.OnHierarchyChangeListener.onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V"); 
				global::android.view.ViewGroup.__OnHierarchyChangeListener._onChildViewRemoved8490 = @__env.GetMethodID(global::android.view.ViewGroup.__OnHierarchyChangeListener.staticClass, "android.view.ViewGroup.OnHierarchyChangeListener.onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _debug8491; 
		protected virtual void debug(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._debug8491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._debug8491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addStatesFromChildren8492; 
		public virtual bool addStatesFromChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._addStatesFromChildren8492); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addStatesFromChildren8492); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus8493; 
		public override bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._hasFocus8493); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocus8493); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent8494; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchKeyEvent8494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEvent8494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent8495; 
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchTouchEvent8495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTouchEvent8495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent8496; 
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchTrackballEvent8496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchTrackballEvent8496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent8497; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent8497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent8497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView8498; 
		public virtual void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView8498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView8498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView8499; 
		public virtual void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView8499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView8499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView8500; 
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView8500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView8500, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView8501; 
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView8501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView8501, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView8502; 
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addView8502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addView8502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateViewLayout8503; 
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._updateViewLayout8503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._updateViewLayout8503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView8504; 
		public virtual void removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeView8504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeView8504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFocus8505; 
		public override void clearFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._clearFocus8505); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearFocus8505); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocusable8506; 
		public override bool hasFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._hasFocusable8506); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._hasFocusable8506); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findFocus8507; 
		public override global::android.view.View findFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._findFocus8507)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._findFocus8507)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fitSystemWindows8508; 
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._fitSystemWindows8508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._fitSystemWindows8508, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed8509; 
		protected override void dispatchSetPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchSetPressed8509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetPressed8509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch8510; 
		public virtual global::android.view.View focusSearch(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._focusSearch8510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusSearch8510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove8511; 
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchUnhandledMove8511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchUnhandledMove8511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables8512; 
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addFocusables8512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables8512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables8513; 
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addFocusables8513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addFocusables8513, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables8514; 
		public override void addTouchables(java.util.ArrayList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._addTouchables8514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addTouchables8514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus8515; 
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._requestFocus8515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestFocus8515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEventPreIme8516; 
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchKeyEventPreIme8516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyEventPreIme8516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyShortcutEvent8517; 
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._dispatchKeyShortcutEvent8517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchKeyShortcutEvent8517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged8518; 
		public override void dispatchWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchWindowFocusChanged8518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowFocusChanged8518, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowVisibilityChanged8519; 
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchWindowVisibilityChanged8519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchWindowVisibilityChanged8519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw8520; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchDraw8520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchDraw8520, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState8521; 
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchSaveInstanceState8521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSaveInstanceState8521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState8522; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchRestoreInstanceState8522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchRestoreInstanceState8522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout8523; 
		protected abstract new void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged8524; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._drawableStateChanged8524); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawableStateChanged8524); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState8525; 
		protected override int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._onCreateDrawableState8525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onCreateDrawableState8525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding8526; 
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setPadding8526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPadding8526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected8527; 
		public virtual new void dispatchSetSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchSetSelected8527, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchSetSelected8527, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart8528; 
		protected override void onAnimationStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._onAnimationStart8528); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationStart8528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd8529; 
		protected override void onAnimationEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._onAnimationEnd8529); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onAnimationEnd8529); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDescendantFocusability8530; 
		public virtual int getDescendantFocusability() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getDescendantFocusability8530); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getDescendantFocusability8530); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDescendantFocusability8531; 
		public virtual void setDescendantFocusability(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setDescendantFocusability8531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setDescendantFocusability8531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus8532; 
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._requestChildFocus8532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildFocus8532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusableViewAvailable8533; 
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._focusableViewAvailable8533, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._focusableViewAvailable8533, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild8534; 
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._showContextMenuForChild8534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._showContextMenuForChild8534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen8535; 
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._requestChildRectangleOnScreen8535, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestChildRectangleOnScreen8535, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearChildFocus8536; 
		public virtual void clearChildFocus(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._clearChildFocus8536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearChildFocus8536, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedChild8537; 
		public virtual global::android.view.View getFocusedChild() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getFocusedChild8537)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getFocusedChild8537)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recomputeViewAttributes8538; 
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._recomputeViewAttributes8538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._recomputeViewAttributes8538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bringChildToFront8539; 
		public virtual void bringChildToFront(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._bringChildToFront8539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._bringChildToFront8539, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestDisallowInterceptTouchEvent8540; 
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent8540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestDisallowInterceptTouchEvent8540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent8541; 
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._onInterceptTouchEvent8541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onInterceptTouchEvent8541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants8542; 
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._onRequestFocusInDescendants8542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._onRequestFocusInDescendants8542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchFreezeSelfOnly8543; 
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchFreezeSelfOnly8543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchFreezeSelfOnly8543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchThawSelfOnly8544; 
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._dispatchThawSelfOnly8544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._dispatchThawSelfOnly8544, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawingCacheEnabled8545; 
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled8545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingCacheEnabled8545, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder8546; 
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getChildDrawingOrder8546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildDrawingOrder8546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawChild8547; 
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._drawChild8547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._drawChild8547, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClipChildren8548; 
		public virtual void setClipChildren(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setClipChildren8548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipChildren8548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClipToPadding8549; 
		public virtual void setClipToPadding(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setClipToPadding8549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setClipToPadding8549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStaticTransformationsEnabled8550; 
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setStaticTransformationsEnabled8550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setStaticTransformationsEnabled8550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildStaticTransformation8551; 
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._getChildStaticTransformation8551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildStaticTransformation8551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams8552; 
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._checkLayoutParams8552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._checkLayoutParams8552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener8553; 
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setOnHierarchyChangeListener8553, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setOnHierarchyChangeListener8553, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addViewInLayout8554; 
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._addViewInLayout8554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout8554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addViewInLayout8555; 
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._addViewInLayout8555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._addViewInLayout8555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cleanupLayoutState8556; 
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._cleanupLayoutState8556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._cleanupLayoutState8556, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachLayoutAnimationParameters8557; 
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._attachLayoutAnimationParameters8557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachLayoutAnimationParameters8557, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewInLayout8558; 
		public virtual void removeViewInLayout(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViewInLayout8558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewInLayout8558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewsInLayout8559; 
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViewsInLayout8559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewsInLayout8559, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt8560; 
		public virtual void removeViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViewAt8560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViewAt8560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViews8561; 
		public virtual void removeViews(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeViews8561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeViews8561, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews8562; 
		public virtual void removeAllViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeAllViews8562); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViews8562); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViewsInLayout8563; 
		public virtual void removeAllViewsInLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeAllViewsInLayout8563); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeAllViewsInLayout8563); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeDetachedView8564; 
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._removeDetachedView8564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._removeDetachedView8564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachViewToParent8565; 
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._attachViewToParent8565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._attachViewToParent8565, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachViewFromParent8566; 
		protected virtual void detachViewFromParent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachViewFromParent8566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent8566, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachViewFromParent8567; 
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachViewFromParent8567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewFromParent8567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachViewsFromParent8568; 
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachViewsFromParent8568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachViewsFromParent8568, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachAllViewsFromParent8569; 
		protected virtual void detachAllViewsFromParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._detachAllViewsFromParent8569); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._detachAllViewsFromParent8569); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChild8570; 
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._invalidateChild8570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChild8570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChildInParent8571; 
		public virtual global::android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._invalidateChildInParent8571, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._invalidateChildInParent8571, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetDescendantRectToMyCoords8572; 
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._offsetDescendantRectToMyCoords8572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetDescendantRectToMyCoords8572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetRectIntoDescendantCoords8573; 
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._offsetRectIntoDescendantCoords8573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._offsetRectIntoDescendantCoords8573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildVisibleRect8574; 
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._getChildVisibleRect8574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildVisibleRect8574, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate8575; 
		protected virtual bool canAnimate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._canAnimate8575); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._canAnimate8575); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startLayoutAnimation8576; 
		public virtual void startLayoutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._startLayoutAnimation8576); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._startLayoutAnimation8576); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleLayoutAnimation8577; 
		public virtual void scheduleLayoutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._scheduleLayoutAnimation8577); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._scheduleLayoutAnimation8577); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAnimation8578; 
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setLayoutAnimation8578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimation8578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAnimation8579; 
		public virtual global::android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getLayoutAnimation8579)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimation8579)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAnimationCacheEnabled8580; 
		public virtual bool isAnimationCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isAnimationCacheEnabled8580); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAnimationCacheEnabled8580); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationCacheEnabled8581; 
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setAnimationCacheEnabled8581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAnimationCacheEnabled8581, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAlwaysDrawnWithCacheEnabled8582; 
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled8582); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled8582); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlwaysDrawnWithCacheEnabled8583; 
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled8583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled8583, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildrenDrawnWithCacheEnabled8584; 
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled8584); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled8584); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawnWithCacheEnabled8585; 
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled8585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled8585, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildrenDrawingOrderEnabled8586; 
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled8586); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._isChildrenDrawingOrderEnabled8586); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawingOrderEnabled8587; 
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled8587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setChildrenDrawingOrderEnabled8587, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistentDrawingCache8588; 
		public virtual int getPersistentDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getPersistentDrawingCache8588); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getPersistentDrawingCache8588); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPersistentDrawingCache8589; 
		public virtual void setPersistentDrawingCache(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setPersistentDrawingCache8589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setPersistentDrawingCache8589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams8590; 
		protected virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._generateLayoutParams8590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams8590, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams8591; 
		public virtual global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._generateLayoutParams8591, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateLayoutParams8591, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams8592; 
		protected virtual global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._generateDefaultLayoutParams8592)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._generateDefaultLayoutParams8592)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfChild8593; 
		public virtual int indexOfChild(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._indexOfChild8593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._indexOfChild8593, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildCount8594; 
		public virtual int getChildCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, global::android.view.ViewGroup._getChildCount8594); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildCount8594); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildAt8595; 
		public virtual global::android.view.View getChildAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getChildAt8595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildAt8595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildren8596; 
		protected virtual void measureChildren(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._measureChildren8596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildren8596, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChild8597; 
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._measureChild8597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChild8597, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins8598; 
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._measureChildWithMargins8598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._measureChildWithMargins8598, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildMeasureSpec8599; 
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getChildMeasureSpec8599, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearDisappearingChildren8600; 
		public virtual void clearDisappearingChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._clearDisappearingChildren8600); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._clearDisappearingChildren8600); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _gatherTransparentRegion8601; 
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, global::android.view.ViewGroup._gatherTransparentRegion8601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._gatherTransparentRegion8601, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestTransparentRegion8602; 
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._requestTransparentRegion8602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._requestTransparentRegion8602, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAnimationListener8603; 
		public virtual global::android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Animation.AnimationListener>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewGroup._getLayoutAnimationListener8603)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Animation.AnimationListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._getLayoutAnimationListener8603)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddStatesFromChildren8604; 
		public virtual void setAddStatesFromChildren(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setAddStatesFromChildren8604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setAddStatesFromChildren8604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _childDrawableStateChanged8605; 
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._childDrawableStateChanged8605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._childDrawableStateChanged8605, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAnimationListener8606; 
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, global::android.view.ViewGroup._setLayoutAnimationListener8606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.view.ViewGroup.staticClass, global::android.view.ViewGroup._setLayoutAnimationListener8606, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup8607; 
		public ViewGroup(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup8607, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup8608; 
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup8608, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup8609; 
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewGroup.staticClass, global::android.view.ViewGroup._ViewGroup8609, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
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
			global::android.view.ViewGroup._debug8491 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "debug", "(I)V"); 
			global::android.view.ViewGroup._addStatesFromChildren8492 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z"); 
			global::android.view.ViewGroup._hasFocus8493 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z"); 
			global::android.view.ViewGroup._dispatchKeyEvent8494 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.ViewGroup._dispatchTouchEvent8495 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.ViewGroup._dispatchTrackballEvent8496 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent8497 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.view.ViewGroup._addView8498 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.view.ViewGroup._addView8499 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._addView8500 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V"); 
			global::android.view.ViewGroup._addView8501 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._addView8502 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._updateViewLayout8503 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._removeView8504 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._clearFocus8505 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearFocus", "()V"); 
			global::android.view.ViewGroup._hasFocusable8506 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z"); 
			global::android.view.ViewGroup._findFocus8507 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;"); 
			global::android.view.ViewGroup._fitSystemWindows8508 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.ViewGroup._dispatchSetPressed8509 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V"); 
			global::android.view.ViewGroup._focusSearch8510 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;"); 
			global::android.view.ViewGroup._dispatchUnhandledMove8511 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z"); 
			global::android.view.ViewGroup._addFocusables8512 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V"); 
			global::android.view.ViewGroup._addFocusables8513 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V"); 
			global::android.view.ViewGroup._addTouchables8514 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V"); 
			global::android.view.ViewGroup._requestFocus8515 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z"); 
			global::android.view.ViewGroup._dispatchKeyEventPreIme8516 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.ViewGroup._dispatchKeyShortcutEvent8517 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.ViewGroup._dispatchWindowFocusChanged8518 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V"); 
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged8519 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V"); 
			global::android.view.ViewGroup._dispatchDraw8520 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.ViewGroup._dispatchSaveInstanceState8521 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._dispatchRestoreInstanceState8522 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._onLayout8523 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.view.ViewGroup._drawableStateChanged8524 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V"); 
			global::android.view.ViewGroup._onCreateDrawableState8525 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.view.ViewGroup._setPadding8526 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V"); 
			global::android.view.ViewGroup._dispatchSetSelected8527 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V"); 
			global::android.view.ViewGroup._onAnimationStart8528 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V"); 
			global::android.view.ViewGroup._onAnimationEnd8529 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V"); 
			global::android.view.ViewGroup._getDescendantFocusability8530 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I"); 
			global::android.view.ViewGroup._setDescendantFocusability8531 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V"); 
			global::android.view.ViewGroup._requestChildFocus8532 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.view.ViewGroup._focusableViewAvailable8533 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._showContextMenuForChild8534 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z"); 
			global::android.view.ViewGroup._requestChildRectangleOnScreen8535 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.view.ViewGroup._clearChildFocus8536 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._getFocusedChild8537 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;"); 
			global::android.view.ViewGroup._recomputeViewAttributes8538 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._bringChildToFront8539 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent8540 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V"); 
			global::android.view.ViewGroup._onInterceptTouchEvent8541 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.ViewGroup._onRequestFocusInDescendants8542 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z"); 
			global::android.view.ViewGroup._dispatchFreezeSelfOnly8543 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._dispatchThawSelfOnly8544 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled8545 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._getChildDrawingOrder8546 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I"); 
			global::android.view.ViewGroup._drawChild8547 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z"); 
			global::android.view.ViewGroup._setClipChildren8548 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V"); 
			global::android.view.ViewGroup._setClipToPadding8549 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V"); 
			global::android.view.ViewGroup._setStaticTransformationsEnabled8550 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V"); 
			global::android.view.ViewGroup._getChildStaticTransformation8551 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z"); 
			global::android.view.ViewGroup._checkLayoutParams8552 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.view.ViewGroup._setOnHierarchyChangeListener8553 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V"); 
			global::android.view.ViewGroup._addViewInLayout8554 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.view.ViewGroup._addViewInLayout8555 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z"); 
			global::android.view.ViewGroup._cleanupLayoutState8556 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._attachLayoutAnimationParameters8557 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V"); 
			global::android.view.ViewGroup._removeViewInLayout8558 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._removeViewsInLayout8559 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V"); 
			global::android.view.ViewGroup._removeViewAt8560 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V"); 
			global::android.view.ViewGroup._removeViews8561 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V"); 
			global::android.view.ViewGroup._removeAllViews8562 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V"); 
			global::android.view.ViewGroup._removeAllViewsInLayout8563 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V"); 
			global::android.view.ViewGroup._removeDetachedView8564 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V"); 
			global::android.view.ViewGroup._attachViewToParent8565 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._detachViewFromParent8566 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V"); 
			global::android.view.ViewGroup._detachViewFromParent8567 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._detachViewsFromParent8568 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V"); 
			global::android.view.ViewGroup._detachAllViewsFromParent8569 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V"); 
			global::android.view.ViewGroup._invalidateChild8570 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V"); 
			global::android.view.ViewGroup._invalidateChildInParent8571 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;"); 
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords8572 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V"); 
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords8573 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V"); 
			global::android.view.ViewGroup._getChildVisibleRect8574 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z"); 
			global::android.view.ViewGroup._canAnimate8575 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z"); 
			global::android.view.ViewGroup._startLayoutAnimation8576 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V"); 
			global::android.view.ViewGroup._scheduleLayoutAnimation8577 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V"); 
			global::android.view.ViewGroup._setLayoutAnimation8578 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V"); 
			global::android.view.ViewGroup._getLayoutAnimation8579 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;"); 
			global::android.view.ViewGroup._isAnimationCacheEnabled8580 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z"); 
			global::android.view.ViewGroup._setAnimationCacheEnabled8581 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled8582 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z"); 
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled8583 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled8584 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z"); 
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled8585 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled8586 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z"); 
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled8587 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V"); 
			global::android.view.ViewGroup._getPersistentDrawingCache8588 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I"); 
			global::android.view.ViewGroup._setPersistentDrawingCache8589 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V"); 
			global::android.view.ViewGroup._generateLayoutParams8590 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.ViewGroup._generateLayoutParams8591 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.ViewGroup._generateDefaultLayoutParams8592 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.ViewGroup._indexOfChild8593 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I"); 
			global::android.view.ViewGroup._getChildCount8594 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildCount", "()I"); 
			global::android.view.ViewGroup._getChildAt8595 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;"); 
			global::android.view.ViewGroup._measureChildren8596 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V"); 
			global::android.view.ViewGroup._measureChild8597 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V"); 
			global::android.view.ViewGroup._measureChildWithMargins8598 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V"); 
			global::android.view.ViewGroup._getChildMeasureSpec8599 = @__env.GetStaticMethodID(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I"); 
			global::android.view.ViewGroup._clearDisappearingChildren8600 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V"); 
			global::android.view.ViewGroup._gatherTransparentRegion8601 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z"); 
			global::android.view.ViewGroup._requestTransparentRegion8602 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._getLayoutAnimationListener8603 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;"); 
			global::android.view.ViewGroup._setAddStatesFromChildren8604 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V"); 
			global::android.view.ViewGroup._childDrawableStateChanged8605 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._setLayoutAnimationListener8606 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V"); 
			global::android.view.ViewGroup._ViewGroup8607 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.ViewGroup._ViewGroup8608 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.view.ViewGroup._ViewGroup8609 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
