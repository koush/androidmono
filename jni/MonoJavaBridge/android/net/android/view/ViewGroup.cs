namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class ViewGroup : android.view.View, ViewParent, ViewManager
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ViewGroup() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewGroup.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes7886; 
			protected virtual void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewGroup.LayoutParams)) 
					@__env.CallVoidMethod(this, _setBaseAttributes7886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.LayoutParams.staticClass, _setBaseAttributes7886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams7887; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, _LayoutParams7887, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams7888; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, _LayoutParams7888, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams7889; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.LayoutParams.staticClass, _LayoutParams7889, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			internal static global::net.sf.jni4net.jni.FieldId _width7890; 
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
			internal static global::net.sf.jni4net.jni.FieldId _height7891; 
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
			internal static global::net.sf.jni4net.jni.FieldId _layoutAnimationParameters7892; 
			public android.view.animation.LayoutAnimationController.AnimationParameters layoutAnimationParameters
			{ 
				get 
				{ 
					return default(android.view.animation.LayoutAnimationController.AnimationParameters); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.ViewGroup.LayoutParams.staticClass = @__class; 
				global::android.view.ViewGroup.LayoutParams._setBaseAttributes7886 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V"); 
				global::android.view.ViewGroup.LayoutParams._LayoutParams7887 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.view.ViewGroup.LayoutParams._LayoutParams7888 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.view.ViewGroup.LayoutParams._LayoutParams7889 = @__env.GetMethodID(global::android.view.ViewGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class MarginLayoutParams : android.view.ViewGroup.LayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static MarginLayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.ViewGroup.MarginLayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _setMargins7893; 
			public virtual void setMargins(int arg0, int arg1, int arg2, int arg3) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.view.ViewGroup.MarginLayoutParams)) 
					@__env.CallVoidMethod(this, _setMargins7893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.MarginLayoutParams.staticClass, _setMargins7893, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams7894; 
			public MarginLayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, _MarginLayoutParams7894, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams7895; 
			public MarginLayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, _MarginLayoutParams7895, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams7896; 
			public MarginLayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, _MarginLayoutParams7896, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _MarginLayoutParams7897; 
			public MarginLayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.ViewGroup.MarginLayoutParams.staticClass, _MarginLayoutParams7897, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _leftMargin7898; 
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
			internal static global::net.sf.jni4net.jni.FieldId _topMargin7899; 
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
			internal static global::net.sf.jni4net.jni.FieldId _rightMargin7900; 
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
			internal static global::net.sf.jni4net.jni.FieldId _bottomMargin7901; 
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
				global::android.view.ViewGroup.MarginLayoutParams._setMargins7893 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "setMargins", "(IIII)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams7894 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams7895 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams7896 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
				global::android.view.ViewGroup.MarginLayoutParams._MarginLayoutParams7897 = @__env.GetMethodID(global::android.view.ViewGroup.MarginLayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnHierarchyChangeListener 
		{ 
			void onChildViewAdded(android.view.View arg0, android.view.View arg1); 
			void onChildViewRemoved(android.view.View arg0, android.view.View arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _debug7902; 
		protected virtual void debug(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _debug7902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _debug7902, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addStatesFromChildren7903; 
		public virtual bool addStatesFromChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _addStatesFromChildren7903); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _addStatesFromChildren7903); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocus7904; 
		public override bool hasFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _hasFocus7904); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _hasFocus7904); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEvent7905; 
		public override bool dispatchKeyEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEvent7905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchKeyEvent7905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTouchEvent7906; 
		public override bool dispatchTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchTouchEvent7906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchTouchEvent7906, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchTrackballEvent7907; 
		public override bool dispatchTrackballEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchTrackballEvent7907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchTrackballEvent7907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent7908; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent7908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchPopulateAccessibilityEvent7908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView7909; 
		public virtual void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addView7909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addView7909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView7910; 
		public virtual void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addView7910, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addView7910, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView7911; 
		public virtual void addView(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addView7911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addView7911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView7912; 
		public virtual void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addView7912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addView7912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView7913; 
		public virtual void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addView7913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addView7913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateViewLayout7914; 
		public virtual void updateViewLayout(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _updateViewLayout7914, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _updateViewLayout7914, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeView7915; 
		public virtual void removeView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeView7915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeView7915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFocus7916; 
		public override void clearFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _clearFocus7916); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _clearFocus7916); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFocusable7917; 
		public override bool hasFocusable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _hasFocusable7917); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _hasFocusable7917); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findFocus7918; 
		public override android.view.View findFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _findFocus7918)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _findFocus7918)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fitSystemWindows7919; 
		protected override bool fitSystemWindows(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _fitSystemWindows7919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _fitSystemWindows7919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetPressed7920; 
		protected override void dispatchSetPressed(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchSetPressed7920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchSetPressed7920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusSearch7921; 
		public virtual android.view.View focusSearch(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _focusSearch7921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _focusSearch7921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchUnhandledMove7922; 
		public override bool dispatchUnhandledMove(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchUnhandledMove7922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchUnhandledMove7922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables7923; 
		public override void addFocusables(java.util.ArrayList arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addFocusables7923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addFocusables7923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFocusables7924; 
		public override void addFocusables(java.util.ArrayList arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addFocusables7924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addFocusables7924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addTouchables7925; 
		public override void addTouchables(java.util.ArrayList arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _addTouchables7925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _addTouchables7925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestFocus7926; 
		public override bool requestFocus(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _requestFocus7926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _requestFocus7926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyEventPreIme7927; 
		public override bool dispatchKeyEventPreIme(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyEventPreIme7927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchKeyEventPreIme7927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchKeyShortcutEvent7928; 
		public override bool dispatchKeyShortcutEvent(android.view.KeyEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _dispatchKeyShortcutEvent7928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _dispatchKeyShortcutEvent7928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowFocusChanged7929; 
		public override void dispatchWindowFocusChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchWindowFocusChanged7929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchWindowFocusChanged7929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchWindowVisibilityChanged7930; 
		public override void dispatchWindowVisibilityChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchWindowVisibilityChanged7930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchWindowVisibilityChanged7930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchDraw7931; 
		protected override void dispatchDraw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchDraw7931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchDraw7931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSaveInstanceState7932; 
		protected override void dispatchSaveInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchSaveInstanceState7932, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchSaveInstanceState7932, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchRestoreInstanceState7933; 
		protected override void dispatchRestoreInstanceState(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchRestoreInstanceState7933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchRestoreInstanceState7933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout7934; 
		protected abstract new void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4); 
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged7935; 
		protected override void drawableStateChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _drawableStateChanged7935); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _drawableStateChanged7935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState7936; 
		protected override int[] onCreateDrawableState(int arg0) 
		{ 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _onCreateDrawableState7936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _onCreateDrawableState7936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPadding7937; 
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setPadding7937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setPadding7937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchSetSelected7938; 
		public virtual new void dispatchSetSelected(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchSetSelected7938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchSetSelected7938, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationStart7939; 
		protected override void onAnimationStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _onAnimationStart7939); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _onAnimationStart7939); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAnimationEnd7940; 
		protected override void onAnimationEnd() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _onAnimationEnd7940); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _onAnimationEnd7940); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDescendantFocusability7941; 
		public virtual int getDescendantFocusability() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, _getDescendantFocusability7941); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewGroup.staticClass, _getDescendantFocusability7941); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDescendantFocusability7942; 
		public virtual void setDescendantFocusability(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setDescendantFocusability7942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setDescendantFocusability7942, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildFocus7943; 
		public virtual void requestChildFocus(android.view.View arg0, android.view.View arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _requestChildFocus7943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _requestChildFocus7943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _focusableViewAvailable7944; 
		public virtual void focusableViewAvailable(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _focusableViewAvailable7944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _focusableViewAvailable7944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _showContextMenuForChild7945; 
		public virtual bool showContextMenuForChild(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _showContextMenuForChild7945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _showContextMenuForChild7945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestChildRectangleOnScreen7946; 
		public virtual bool requestChildRectangleOnScreen(android.view.View arg0, android.graphics.Rect arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _requestChildRectangleOnScreen7946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _requestChildRectangleOnScreen7946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearChildFocus7947; 
		public virtual void clearChildFocus(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _clearChildFocus7947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _clearChildFocus7947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFocusedChild7948; 
		public virtual android.view.View getFocusedChild() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getFocusedChild7948)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _getFocusedChild7948)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recomputeViewAttributes7949; 
		public virtual void recomputeViewAttributes(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _recomputeViewAttributes7949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _recomputeViewAttributes7949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _bringChildToFront7950; 
		public virtual void bringChildToFront(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _bringChildToFront7950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _bringChildToFront7950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestDisallowInterceptTouchEvent7951; 
		public virtual void requestDisallowInterceptTouchEvent(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _requestDisallowInterceptTouchEvent7951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _requestDisallowInterceptTouchEvent7951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInterceptTouchEvent7952; 
		public virtual bool onInterceptTouchEvent(android.view.MotionEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _onInterceptTouchEvent7952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _onInterceptTouchEvent7952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRequestFocusInDescendants7953; 
		protected virtual bool onRequestFocusInDescendants(int arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _onRequestFocusInDescendants7953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _onRequestFocusInDescendants7953, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchFreezeSelfOnly7954; 
		protected virtual void dispatchFreezeSelfOnly(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchFreezeSelfOnly7954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchFreezeSelfOnly7954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchThawSelfOnly7955; 
		protected virtual void dispatchThawSelfOnly(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _dispatchThawSelfOnly7955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _dispatchThawSelfOnly7955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawingCacheEnabled7956; 
		protected virtual void setChildrenDrawingCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setChildrenDrawingCacheEnabled7956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setChildrenDrawingCacheEnabled7956, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildDrawingOrder7957; 
		protected virtual int getChildDrawingOrder(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, _getChildDrawingOrder7957, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewGroup.staticClass, _getChildDrawingOrder7957, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _drawChild7958; 
		protected virtual bool drawChild(android.graphics.Canvas arg0, android.view.View arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _drawChild7958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _drawChild7958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClipChildren7959; 
		public virtual void setClipChildren(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setClipChildren7959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setClipChildren7959, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setClipToPadding7960; 
		public virtual void setClipToPadding(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setClipToPadding7960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setClipToPadding7960, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStaticTransformationsEnabled7961; 
		protected virtual void setStaticTransformationsEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setStaticTransformationsEnabled7961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setStaticTransformationsEnabled7961, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildStaticTransformation7962; 
		protected virtual bool getChildStaticTransformation(android.view.View arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _getChildStaticTransformation7962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _getChildStaticTransformation7962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams7963; 
		protected virtual bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams7963, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _checkLayoutParams7963, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener7964; 
		public virtual void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setOnHierarchyChangeListener7964, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setOnHierarchyChangeListener7964, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addViewInLayout7965; 
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _addViewInLayout7965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _addViewInLayout7965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addViewInLayout7966; 
		protected virtual bool addViewInLayout(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _addViewInLayout7966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _addViewInLayout7966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cleanupLayoutState7967; 
		protected virtual void cleanupLayoutState(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _cleanupLayoutState7967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _cleanupLayoutState7967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachLayoutAnimationParameters7968; 
		protected virtual void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _attachLayoutAnimationParameters7968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _attachLayoutAnimationParameters7968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewInLayout7969; 
		public virtual void removeViewInLayout(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeViewInLayout7969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeViewInLayout7969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewsInLayout7970; 
		public virtual void removeViewsInLayout(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeViewsInLayout7970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeViewsInLayout7970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViewAt7971; 
		public virtual void removeViewAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeViewAt7971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeViewAt7971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeViews7972; 
		public virtual void removeViews(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeViews7972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeViews7972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViews7973; 
		public virtual void removeAllViews() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeAllViews7973); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeAllViews7973); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllViewsInLayout7974; 
		public virtual void removeAllViewsInLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeAllViewsInLayout7974); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeAllViewsInLayout7974); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeDetachedView7975; 
		protected virtual void removeDetachedView(android.view.View arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _removeDetachedView7975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _removeDetachedView7975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _attachViewToParent7976; 
		protected virtual void attachViewToParent(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _attachViewToParent7976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _attachViewToParent7976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachViewFromParent7977; 
		protected virtual void detachViewFromParent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _detachViewFromParent7977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _detachViewFromParent7977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachViewFromParent7978; 
		protected virtual void detachViewFromParent(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _detachViewFromParent7978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _detachViewFromParent7978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachViewsFromParent7979; 
		protected virtual void detachViewsFromParent(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _detachViewsFromParent7979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _detachViewsFromParent7979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _detachAllViewsFromParent7980; 
		protected virtual void detachAllViewsFromParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _detachAllViewsFromParent7980); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _detachAllViewsFromParent7980); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChild7981; 
		public virtual void invalidateChild(android.view.View arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _invalidateChild7981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _invalidateChild7981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateChildInParent7982; 
		public virtual android.view.ViewParent invalidateChildInParent(int[] arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallObjectMethodPtr(this, _invalidateChildInParent7982, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.ViewParent>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _invalidateChildInParent7982, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetDescendantRectToMyCoords7983; 
		public virtual void offsetDescendantRectToMyCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _offsetDescendantRectToMyCoords7983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _offsetDescendantRectToMyCoords7983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _offsetRectIntoDescendantCoords7984; 
		public virtual void offsetRectIntoDescendantCoords(android.view.View arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _offsetRectIntoDescendantCoords7984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _offsetRectIntoDescendantCoords7984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildVisibleRect7985; 
		public virtual bool getChildVisibleRect(android.view.View arg0, android.graphics.Rect arg1, android.graphics.Point arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _getChildVisibleRect7985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _getChildVisibleRect7985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _canAnimate7986; 
		protected virtual bool canAnimate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _canAnimate7986); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _canAnimate7986); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startLayoutAnimation7987; 
		public virtual void startLayoutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _startLayoutAnimation7987); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _startLayoutAnimation7987); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleLayoutAnimation7988; 
		public virtual void scheduleLayoutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _scheduleLayoutAnimation7988); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _scheduleLayoutAnimation7988); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAnimation7989; 
		public virtual void setLayoutAnimation(android.view.animation.LayoutAnimationController arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setLayoutAnimation7989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setLayoutAnimation7989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAnimation7990; 
		public virtual android.view.animation.LayoutAnimationController getLayoutAnimation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutAnimation7990)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.LayoutAnimationController>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _getLayoutAnimation7990)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAnimationCacheEnabled7991; 
		public virtual bool isAnimationCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _isAnimationCacheEnabled7991); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _isAnimationCacheEnabled7991); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationCacheEnabled7992; 
		public virtual void setAnimationCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setAnimationCacheEnabled7992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setAnimationCacheEnabled7992, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAlwaysDrawnWithCacheEnabled7993; 
		public virtual bool isAlwaysDrawnWithCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _isAlwaysDrawnWithCacheEnabled7993); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _isAlwaysDrawnWithCacheEnabled7993); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlwaysDrawnWithCacheEnabled7994; 
		public virtual void setAlwaysDrawnWithCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setAlwaysDrawnWithCacheEnabled7994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setAlwaysDrawnWithCacheEnabled7994, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildrenDrawnWithCacheEnabled7995; 
		protected virtual bool isChildrenDrawnWithCacheEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _isChildrenDrawnWithCacheEnabled7995); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _isChildrenDrawnWithCacheEnabled7995); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawnWithCacheEnabled7996; 
		protected virtual void setChildrenDrawnWithCacheEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setChildrenDrawnWithCacheEnabled7996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setChildrenDrawnWithCacheEnabled7996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isChildrenDrawingOrderEnabled7997; 
		protected virtual bool isChildrenDrawingOrderEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _isChildrenDrawingOrderEnabled7997); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _isChildrenDrawingOrderEnabled7997); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChildrenDrawingOrderEnabled7998; 
		protected virtual void setChildrenDrawingOrderEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setChildrenDrawingOrderEnabled7998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setChildrenDrawingOrderEnabled7998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPersistentDrawingCache7999; 
		public virtual int getPersistentDrawingCache() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, _getPersistentDrawingCache7999); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewGroup.staticClass, _getPersistentDrawingCache7999); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPersistentDrawingCache8000; 
		public virtual void setPersistentDrawingCache(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setPersistentDrawingCache8000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setPersistentDrawingCache8000, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams8001; 
		protected virtual android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams8001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _generateLayoutParams8001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams8002; 
		public virtual android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams8002, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _generateLayoutParams8002, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams8003; 
		protected virtual android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams8003)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _generateDefaultLayoutParams8003)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _indexOfChild8004; 
		public virtual int indexOfChild(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, _indexOfChild8004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewGroup.staticClass, _indexOfChild8004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildCount8005; 
		public virtual int getChildCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallIntMethod(this, _getChildCount8005); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.ViewGroup.staticClass, _getChildCount8005); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildAt8006; 
		public virtual android.view.View getChildAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getChildAt8006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _getChildAt8006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildren8007; 
		protected virtual void measureChildren(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _measureChildren8007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _measureChildren8007, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChild8008; 
		protected virtual void measureChild(android.view.View arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _measureChild8008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _measureChild8008, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _measureChildWithMargins8009; 
		protected virtual void measureChildWithMargins(android.view.View arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _measureChildWithMargins8009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _measureChildWithMargins8009, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChildMeasureSpec8010; 
		public static int getChildMeasureSpec(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.view.ViewGroup.staticClass, _getChildMeasureSpec8010, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearDisappearingChildren8011; 
		public virtual void clearDisappearingChildren() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _clearDisappearingChildren8011); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _clearDisappearingChildren8011); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _gatherTransparentRegion8012; 
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return @__env.CallBooleanMethod(this, _gatherTransparentRegion8012, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.ViewGroup.staticClass, _gatherTransparentRegion8012, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestTransparentRegion8013; 
		public virtual void requestTransparentRegion(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _requestTransparentRegion8013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _requestTransparentRegion8013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLayoutAnimationListener8014; 
		public virtual android.view.animation.Animation.AnimationListener getLayoutAnimationListener() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Animation.AnimationListener>(@__env, @__env.CallObjectMethodPtr(this, _getLayoutAnimationListener8014)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Animation.AnimationListener>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.ViewGroup.staticClass, _getLayoutAnimationListener8014)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddStatesFromChildren8015; 
		public virtual void setAddStatesFromChildren(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setAddStatesFromChildren8015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setAddStatesFromChildren8015, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _childDrawableStateChanged8016; 
		public virtual void childDrawableStateChanged(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _childDrawableStateChanged8016, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _childDrawableStateChanged8016, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayoutAnimationListener8017; 
		public virtual void setLayoutAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.ViewGroup)) 
				@__env.CallVoidMethod(this, _setLayoutAnimationListener8017, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.ViewGroup.staticClass, _setLayoutAnimationListener8017, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup8018; 
		public ViewGroup(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewGroup.staticClass, _ViewGroup8018, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup8019; 
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewGroup.staticClass, _ViewGroup8019, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ViewGroup8020; 
		public ViewGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.ViewGroup.staticClass, _ViewGroup8020, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
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
			global::android.view.ViewGroup._debug7902 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "debug", "(I)V"); 
			global::android.view.ViewGroup._addStatesFromChildren7903 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addStatesFromChildren", "()Z"); 
			global::android.view.ViewGroup._hasFocus7904 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "hasFocus", "()Z"); 
			global::android.view.ViewGroup._dispatchKeyEvent7905 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.ViewGroup._dispatchTouchEvent7906 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.ViewGroup._dispatchTrackballEvent7907 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.ViewGroup._dispatchPopulateAccessibilityEvent7908 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.view.ViewGroup._addView7909 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.view.ViewGroup._addView7910 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._addView7911 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;II)V"); 
			global::android.view.ViewGroup._addView7912 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._addView7913 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._updateViewLayout7914 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._removeView7915 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeView", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._clearFocus7916 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearFocus", "()V"); 
			global::android.view.ViewGroup._hasFocusable7917 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "hasFocusable", "()Z"); 
			global::android.view.ViewGroup._findFocus7918 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "findFocus", "()Landroid/view/View;"); 
			global::android.view.ViewGroup._fitSystemWindows7919 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "fitSystemWindows", "(Landroid/graphics/Rect;)Z"); 
			global::android.view.ViewGroup._dispatchSetPressed7920 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSetPressed", "(Z)V"); 
			global::android.view.ViewGroup._focusSearch7921 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;"); 
			global::android.view.ViewGroup._dispatchUnhandledMove7922 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchUnhandledMove", "(Landroid/view/View;I)Z"); 
			global::android.view.ViewGroup._addFocusables7923 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;II)V"); 
			global::android.view.ViewGroup._addFocusables7924 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addFocusables", "(Ljava/util/ArrayList;I)V"); 
			global::android.view.ViewGroup._addTouchables7925 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addTouchables", "(Ljava/util/ArrayList;)V"); 
			global::android.view.ViewGroup._requestFocus7926 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestFocus", "(ILandroid/graphics/Rect;)Z"); 
			global::android.view.ViewGroup._dispatchKeyEventPreIme7927 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyEventPreIme", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.ViewGroup._dispatchKeyShortcutEvent7928 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchKeyShortcutEvent", "(Landroid/view/KeyEvent;)Z"); 
			global::android.view.ViewGroup._dispatchWindowFocusChanged7929 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchWindowFocusChanged", "(Z)V"); 
			global::android.view.ViewGroup._dispatchWindowVisibilityChanged7930 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchWindowVisibilityChanged", "(I)V"); 
			global::android.view.ViewGroup._dispatchDraw7931 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.ViewGroup._dispatchSaveInstanceState7932 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSaveInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._dispatchRestoreInstanceState7933 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._onLayout7934 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.view.ViewGroup._drawableStateChanged7935 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "drawableStateChanged", "()V"); 
			global::android.view.ViewGroup._onCreateDrawableState7936 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onCreateDrawableState", "(I)[I"); 
			global::android.view.ViewGroup._setPadding7937 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setPadding", "(IIII)V"); 
			global::android.view.ViewGroup._dispatchSetSelected7938 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchSetSelected", "(Z)V"); 
			global::android.view.ViewGroup._onAnimationStart7939 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onAnimationStart", "()V"); 
			global::android.view.ViewGroup._onAnimationEnd7940 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onAnimationEnd", "()V"); 
			global::android.view.ViewGroup._getDescendantFocusability7941 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getDescendantFocusability", "()I"); 
			global::android.view.ViewGroup._setDescendantFocusability7942 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setDescendantFocusability", "(I)V"); 
			global::android.view.ViewGroup._requestChildFocus7943 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V"); 
			global::android.view.ViewGroup._focusableViewAvailable7944 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "focusableViewAvailable", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._showContextMenuForChild7945 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "showContextMenuForChild", "(Landroid/view/View;)Z"); 
			global::android.view.ViewGroup._requestChildRectangleOnScreen7946 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z"); 
			global::android.view.ViewGroup._clearChildFocus7947 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearChildFocus", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._getFocusedChild7948 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getFocusedChild", "()Landroid/view/View;"); 
			global::android.view.ViewGroup._recomputeViewAttributes7949 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "recomputeViewAttributes", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._bringChildToFront7950 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "bringChildToFront", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._requestDisallowInterceptTouchEvent7951 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestDisallowInterceptTouchEvent", "(Z)V"); 
			global::android.view.ViewGroup._onInterceptTouchEvent7952 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onInterceptTouchEvent", "(Landroid/view/MotionEvent;)Z"); 
			global::android.view.ViewGroup._onRequestFocusInDescendants7953 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "onRequestFocusInDescendants", "(ILandroid/graphics/Rect;)Z"); 
			global::android.view.ViewGroup._dispatchFreezeSelfOnly7954 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchFreezeSelfOnly", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._dispatchThawSelfOnly7955 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "dispatchThawSelfOnly", "(Landroid/util/SparseArray;)V"); 
			global::android.view.ViewGroup._setChildrenDrawingCacheEnabled7956 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawingCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._getChildDrawingOrder7957 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildDrawingOrder", "(II)I"); 
			global::android.view.ViewGroup._drawChild7958 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "drawChild", "(Landroid/graphics/Canvas;Landroid/view/View;J)Z"); 
			global::android.view.ViewGroup._setClipChildren7959 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setClipChildren", "(Z)V"); 
			global::android.view.ViewGroup._setClipToPadding7960 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setClipToPadding", "(Z)V"); 
			global::android.view.ViewGroup._setStaticTransformationsEnabled7961 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setStaticTransformationsEnabled", "(Z)V"); 
			global::android.view.ViewGroup._getChildStaticTransformation7962 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildStaticTransformation", "(Landroid/view/View;Landroid/view/animation/Transformation;)Z"); 
			global::android.view.ViewGroup._checkLayoutParams7963 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.view.ViewGroup._setOnHierarchyChangeListener7964 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V"); 
			global::android.view.ViewGroup._addViewInLayout7965 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.view.ViewGroup._addViewInLayout7966 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "addViewInLayout", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;Z)Z"); 
			global::android.view.ViewGroup._cleanupLayoutState7967 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "cleanupLayoutState", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._attachLayoutAnimationParameters7968 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V"); 
			global::android.view.ViewGroup._removeViewInLayout7969 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewInLayout", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._removeViewsInLayout7970 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewsInLayout", "(II)V"); 
			global::android.view.ViewGroup._removeViewAt7971 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViewAt", "(I)V"); 
			global::android.view.ViewGroup._removeViews7972 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeViews", "(II)V"); 
			global::android.view.ViewGroup._removeAllViews7973 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeAllViews", "()V"); 
			global::android.view.ViewGroup._removeAllViewsInLayout7974 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeAllViewsInLayout", "()V"); 
			global::android.view.ViewGroup._removeDetachedView7975 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "removeDetachedView", "(Landroid/view/View;Z)V"); 
			global::android.view.ViewGroup._attachViewToParent7976 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "attachViewToParent", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.view.ViewGroup._detachViewFromParent7977 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(I)V"); 
			global::android.view.ViewGroup._detachViewFromParent7978 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewFromParent", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._detachViewsFromParent7979 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachViewsFromParent", "(II)V"); 
			global::android.view.ViewGroup._detachAllViewsFromParent7980 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "detachAllViewsFromParent", "()V"); 
			global::android.view.ViewGroup._invalidateChild7981 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V"); 
			global::android.view.ViewGroup._invalidateChildInParent7982 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;"); 
			global::android.view.ViewGroup._offsetDescendantRectToMyCoords7983 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "offsetDescendantRectToMyCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V"); 
			global::android.view.ViewGroup._offsetRectIntoDescendantCoords7984 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "offsetRectIntoDescendantCoords", "(Landroid/view/View;Landroid/graphics/Rect;)V"); 
			global::android.view.ViewGroup._getChildVisibleRect7985 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z"); 
			global::android.view.ViewGroup._canAnimate7986 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "canAnimate", "()Z"); 
			global::android.view.ViewGroup._startLayoutAnimation7987 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "startLayoutAnimation", "()V"); 
			global::android.view.ViewGroup._scheduleLayoutAnimation7988 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "scheduleLayoutAnimation", "()V"); 
			global::android.view.ViewGroup._setLayoutAnimation7989 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setLayoutAnimation", "(Landroid/view/animation/LayoutAnimationController;)V"); 
			global::android.view.ViewGroup._getLayoutAnimation7990 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getLayoutAnimation", "()Landroid/view/animation/LayoutAnimationController;"); 
			global::android.view.ViewGroup._isAnimationCacheEnabled7991 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isAnimationCacheEnabled", "()Z"); 
			global::android.view.ViewGroup._setAnimationCacheEnabled7992 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAnimationCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._isAlwaysDrawnWithCacheEnabled7993 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isAlwaysDrawnWithCacheEnabled", "()Z"); 
			global::android.view.ViewGroup._setAlwaysDrawnWithCacheEnabled7994 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAlwaysDrawnWithCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._isChildrenDrawnWithCacheEnabled7995 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isChildrenDrawnWithCacheEnabled", "()Z"); 
			global::android.view.ViewGroup._setChildrenDrawnWithCacheEnabled7996 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawnWithCacheEnabled", "(Z)V"); 
			global::android.view.ViewGroup._isChildrenDrawingOrderEnabled7997 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "isChildrenDrawingOrderEnabled", "()Z"); 
			global::android.view.ViewGroup._setChildrenDrawingOrderEnabled7998 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setChildrenDrawingOrderEnabled", "(Z)V"); 
			global::android.view.ViewGroup._getPersistentDrawingCache7999 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getPersistentDrawingCache", "()I"); 
			global::android.view.ViewGroup._setPersistentDrawingCache8000 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setPersistentDrawingCache", "(I)V"); 
			global::android.view.ViewGroup._generateLayoutParams8001 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.ViewGroup._generateLayoutParams8002 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.ViewGroup._generateDefaultLayoutParams8003 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.view.ViewGroup._indexOfChild8004 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "indexOfChild", "(Landroid/view/View;)I"); 
			global::android.view.ViewGroup._getChildCount8005 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildCount", "()I"); 
			global::android.view.ViewGroup._getChildAt8006 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getChildAt", "(I)Landroid/view/View;"); 
			global::android.view.ViewGroup._measureChildren8007 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChildren", "(II)V"); 
			global::android.view.ViewGroup._measureChild8008 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChild", "(Landroid/view/View;II)V"); 
			global::android.view.ViewGroup._measureChildWithMargins8009 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "measureChildWithMargins", "(Landroid/view/View;IIII)V"); 
			global::android.view.ViewGroup._getChildMeasureSpec8010 = @__env.GetStaticMethodID(global::android.view.ViewGroup.staticClass, "getChildMeasureSpec", "(III)I"); 
			global::android.view.ViewGroup._clearDisappearingChildren8011 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "clearDisappearingChildren", "()V"); 
			global::android.view.ViewGroup._gatherTransparentRegion8012 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z"); 
			global::android.view.ViewGroup._requestTransparentRegion8013 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "requestTransparentRegion", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._getLayoutAnimationListener8014 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "getLayoutAnimationListener", "()Landroid/view/animation/Animation$AnimationListener;"); 
			global::android.view.ViewGroup._setAddStatesFromChildren8015 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setAddStatesFromChildren", "(Z)V"); 
			global::android.view.ViewGroup._childDrawableStateChanged8016 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "childDrawableStateChanged", "(Landroid/view/View;)V"); 
			global::android.view.ViewGroup._setLayoutAnimationListener8017 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "setLayoutAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V"); 
			global::android.view.ViewGroup._ViewGroup8018 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.view.ViewGroup._ViewGroup8019 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
			global::android.view.ViewGroup._ViewGroup8020 = @__env.GetMethodID(global::android.view.ViewGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
